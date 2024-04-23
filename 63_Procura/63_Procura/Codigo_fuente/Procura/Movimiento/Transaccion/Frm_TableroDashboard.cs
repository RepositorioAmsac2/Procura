using DevExpress.DashboardCommon;
using DevExpress.XtraBars;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace WINlogistica
{
    public partial class Frm_TableroDashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Model.xmlDATA obj = new Model.xmlDATA();
        //private SRsafnet.SAFnetEClient objWCF = new SRsafnet.SAFnetEClient();
        private Service.Data objDATA = new Service.Data();
        public bool blnModifico = false;
        public Frm_TableroDashboard()
        {
            InitializeComponent();
        }

        public void ShowMe( List<Model.Dashboard_ProcesoLogistico_TipoProceso> lista, Model.xmlDATA _obj )
        {
            obj = _obj;
            dashboardDesigner1.DataSourceOptions.ObjectDataSourceLoadingBehavior = DevExpress.DataAccess.DocumentLoadingBehavior.LoadAsIs;
            dashboardDesigner1.CreateRibbon();

            List<BarItem> itemsToRemove = new List<BarItem>();
            foreach (DevExpress.XtraBars.BarItem item in dashboardDesigner1.Ribbon.Items)
            {
                if (item is DevExpress.DashboardWin.Bars.FileSaveAsBarItem) itemsToRemove.Add(item);
                if (item is DevExpress.DashboardWin.Bars.FileOpenBarItem) itemsToRemove.Add(item);
                if (item is DevExpress.DashboardWin.Bars.FileNewBarItem) itemsToRemove.Add(item);
            }
            foreach (BarItem item in itemsToRemove)
                dashboardDesigner1.Ribbon.Items.Remove(item);

            dashboardDesigner1.Dashboard = new Dashboard();
            DashboardObjectDataSource objDataSource = new DashboardObjectDataSource();
            objDataSource = CreateDataSource(lista);
            dashboardDesigner1.Dashboard.DataSources.Add(objDataSource);

            using (Stream stream = new MemoryStream())
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml(_obj.xmlData);
                xdoc.Save(stream);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                dashboardDesigner1.Dashboard.LoadFromXml(stream);

            }

        }

        public DashboardObjectDataSource CreateDataSource(List<Model.Dashboard_ProcesoLogistico_TipoProceso> lista)
        {
            DashboardObjectDataSource dataSource = new DashboardObjectDataSource("SQL Data Source 2");
            dashboardDesigner1.DataLoading += (s, ev) => {
                if (ev.DataSourceName == "SQL Data Source 2")
                    ev.Data = lista;
            };

            return dataSource;

        }

        private void dashboardDesigner1_DashboardSaving(object sender, DevExpress.DashboardWin.DashboardSavingEventArgs e)
        {
            if (e.Command == DevExpress.DashboardWin.DashboardSaveCommand.Save)
            {
                this.GrabarDashboard(true);
               

                e.Handled = true;
                e.Saved = true;

                blnModifico = true;
            }
        }

        private void GrabarDashboard(bool IncluirMensaje)
        {
            string archivoTemp = Path.GetTempFileName();

            archivoTemp = Path.ChangeExtension(archivoTemp, "XML");

            dashboardDesigner1.Dashboard.SaveToXml(archivoTemp);


            using (Stream stream = new MemoryStream())
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(archivoTemp);
                xdoc.Save(stream);
                stream.Seek(0, System.IO.SeekOrigin.Begin);

                //dashboardDesigner1.Dashboard.LoadFromXml(stream);

                obj.xmlData = GetXMLAsString(xdoc);

                if (MyStuff.UsaWCF)
                {
                    //jesus
                }
                else
                {
                    objDATA.modifica_xmlData_Logistica(obj);
                }
            }

            File.Delete(archivoTemp);

            if (IncluirMensaje)
                MessageBox.Show("Los nuevos cambios en el tablero ya han sido actualizados en la base de datos");

        }

        private string GetXMLAsString(XmlDocument myxml)
        {

            StringWriter sw = new StringWriter();
            XmlTextWriter tx = new XmlTextWriter(sw);
            myxml.WriteTo(tx);

            string str = sw.ToString();// 
            return str;
        }

        private void dashboardDesigner1_DashboardClosing(object sender, DevExpress.DashboardWin.DashboardClosingEventArgs e)
        {
            var modificado = e.IsDashboardModified;

            if (modificado)
            {
                if (MessageBox.Show("El tablero ha sido modificado, desea actualizar el tablero con los nuevos cambios ? ",
                                        "Grabar cambios", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question
                                    ) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.GrabarDashboard(false);
                    this.blnModifico = true;
                }

                e.IsDashboardModified = false; 
            }    
        }
    }
}
