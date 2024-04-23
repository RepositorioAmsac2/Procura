using DevExpress.DashboardCommon;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.Spreadsheet;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml;

namespace WINlogistica
{


    public partial class UC_ProcesoLogistico_Dashboard : DevExpress.XtraEditors.XtraUserControl
    {
        //private SRsafnet.SAFnetEClient objWCF = new SRsafnet.SAFnetEClient();
        private Service.Data objDATA = new Service.Data();
        private List<Model.Dashboard_ProcesoLogistico_TipoProceso> lista = new List<Model.Dashboard_ProcesoLogistico_TipoProceso>();
        Model.xmlDATA obj = new Model.xmlDATA();


        public UC_ProcesoLogistico_Dashboard()
        {
            InitializeComponent();
           
        }

        private static UC_ProcesoLogistico_Dashboard _instance;
        public static UC_ProcesoLogistico_Dashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ProcesoLogistico_Dashboard();
                return _instance;
            }
        }
        private void MostrarInformacion()
        {

            if (MyStuff.UsaWCF == true)
            {
                //jesus
            }
            else
            {
                lista = objDATA.Reporte_ProcesoLogistico_Dashboard(MyStuff.CodigoEmpresa,
                                                    MyStuff.AñoProceso,
                                                    "01",
                                                    true
                                                );
            }


            if (MyStuff.UsaWCF == true)
            {
                //jesus
            }
            else
            {
                obj = objDATA.recupera_xmlData_Logistica("01");
            }

            this.listar();

            using (Stream stream = new MemoryStream())
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml(obj.xmlData);
                xdoc.Save(stream);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                dashboardViewerData.Dashboard.LoadFromXml(stream);

            }
        }

        public DashboardObjectDataSource CreateDataSource(List<Model.Dashboard_ProcesoLogistico_TipoProceso> lista)
        {
            DashboardObjectDataSource dataSource = new DashboardObjectDataSource("SQL Data Source 2");
            dashboardViewerData.DataLoading += (s, ev) => {
                if (ev.DataSourceName == "SQL Data Source 2")
                    ev.Data = lista;
            };

            return dataSource;

        }


        private void Btn_Actualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.MostrarInformacion();
        }

        private void listar()
        {
            dashboardViewerData.Dashboard = new Dashboard();
            DashboardObjectDataSource objDataSource = new DashboardObjectDataSource();
            objDataSource = CreateDataSource(lista);
            dashboardViewerData.Dashboard.DataSources.Add(objDataSource);
        }
   
        private void Btn_Tablero_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WINlogistica.Frm_TableroDashboard frm = new WINlogistica.Frm_TableroDashboard();
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
            SplashScreenManager.Default.SetWaitFormDescription("Trayendo el tablero...");
            frm.ShowMe(lista, obj);
            SplashScreenManager.CloseForm();
            frm.ShowDialog();
            if (frm.blnModifico)
            {
                this.MostrarInformacion();
            }
        }

        private void UC_ProcesoLogistico_Dashboard_Load(object sender, EventArgs e)
        {
            this.MostrarInformacion();

        }
    }
}