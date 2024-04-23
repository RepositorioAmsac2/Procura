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
        private SRsafnet.SAFnetEClient objWCF = new SRsafnet.SAFnetEClient();
        private Service.Data objDATA = new Service.Data();
        private List<Model.Dashboard_Formulacion_PIA> lista = new List<Model.Dashboard_Formulacion_PIA>();
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
                lista = objDATA.Reporte_Detalle_ModificacionFormulacion_dashboard(MyStuff.CodigoEmpresa,
                                                    "2024",
                                                    "01",
                                                    "01",
                                                    "",
                                                    "",
                                                    ""
                                                );
            }


            if (MyStuff.UsaWCF == true)
            {
                //jesus
            }
            else
            {
                obj = objDATA.recupera_xmlData("01");
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

        public DashboardObjectDataSource CreateDataSource(List<Model.Dashboard_Formulacion_PIA> lista)
        {
            DashboardObjectDataSource dataSource = new DashboardObjectDataSource("SQL Data Source 2");
            dashboardViewerData.DataLoading += (s, ev) => {
                if (ev.DataSourceName == "SQL Data Source 2")
                    ev.Data = lista;
            };

            return dataSource;

        }
        private CardDashboardItem CreateCards(DashboardObjectDataSource dataSource)
        {
            // Creates a card dashboard item and specifies its data source.
            CardDashboardItem cards = new CardDashboardItem();
            cards.DataSource = dataSource;

            // Creates the Card object with measures that provide data for calculating actual and target
            // values, and then adds this object to the Cards collection of the card dashboard item.

            CardCustomLayoutTemplate customTemplate = new CardCustomLayoutTemplate();
            customTemplate.MinWidth = 100;
            customTemplate.MaxWidth = 150;


            Card card = new Card()
            {
                LayoutTemplate = customTemplate
                
            };

            card.ActualValue = new Measure("ANTERIOR");

            card.ActualValue.NumericFormat.FormatType = DataItemNumericFormatType.Number;
            card.ActualValue.NumericFormat.Precision = 0;
            card.ActualValue.NumericFormat.Unit = DataItemNumericUnit.Ones;
            card.ActualValue.NumericFormat.IncludeGroupSeparator = true;
            card.Name = "APROBADO 2023";

            //card.TargetValue = new Measure("RevenueQTDTarget (Sum)");

            cards.Cards.Add(card);

            // Specifies dimensions that provides data for a card dashboard item series.
            //cards.SeriesDimensions.Add(new Dimension("Category"));
            //cards.SeriesDimensions.Add(new Dimension("Product"));
            
            cards.InteractivityOptions.IsDrillDownEnabled = true;

            return cards;
        }


        private void Frm_Formulacion_Detalle_Modificacion_Load(object sender, EventArgs e)
        {
            this.MostrarInformacion();
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
   

        private void dashboardViewerData_DashboardLoaded(object sender, DevExpress.DashboardWin.DashboardLoadedEventArgs e)
        {
            //var usefulsource = dashboardViewerData.Dashboard.Items.OfType<DataDashboardItem>().Select(i => i.DataSource).Distinct().ToArray();
            //for (int i = 0; i < dashboardViewerData.Dashboard.DataSources.Count; i++)
            //{
            //    var currentDataSources = dashboardViewerData.Dashboard.DataSources[i];
            //    if (usefulsource.Contains(currentDataSources))
            //    {
            //        dashboardViewerData.Dashboard.DataSources.Remove(currentDataSources);
            //    }
            //}

        }

        private void Btn_Tablero_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WINformulacion.Frm_TableroDashboard frm = new WINformulacion.Frm_TableroDashboard();
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
    }
}