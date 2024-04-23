using DevExpress.Spreadsheet;
using DevExpress.XtraSplashScreen;
using System;
using System.Data;
using System.IO;

namespace WINlogistica
{


    public partial class UC_HojaTrabajo_Dashboard : DevExpress.XtraEditors.XtraUserControl
    {
        IWorkbook workbook;
        //private SRsafnet.SAFnetEClient objWCF = new SRsafnet.SAFnetEClient();
        private Service.Data objDATA = new Service.Data();

        DataSet DS_Detalle;
        DataView DV_Detalle;
        private string strCodPeriodoFormulacion = "";


        private Framework FS = new Framework();

        public UC_HojaTrabajo_Dashboard()
        {
            InitializeComponent();
            this.Inicio();
        }

        private static UC_HojaTrabajo_Dashboard _instance;
        public static UC_HojaTrabajo_Dashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_HojaTrabajo_Dashboard();
                return _instance;
            }
        }

        private void Inicio()
        {
            this.MostrarDataFiltro();
        }
        private void MostrarDataFiltro()
        {

            if (MyStuff.UsaWCF == true)
            {
                //jesus
            }
            else
            {
                this.Cbo_AñoProceso.CargaDT(objDATA.Combo_ProcesoLogistico_Año(MyStuff.CodigoEmpresa).Tables[0]);
                this.Cbo_Version.CargaDT(objDATA.Combo_ProcesoLogistico_Version(MyStuff.CodigoEmpresa,Convert.ToString(this.Cbo_AñoProceso.SelectedValue)).Tables[0]);
            }

        }

        private void MostrarInformacion()
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
            SplashScreenManager.Default.SetWaitFormDescription("Recopilando informaciòn...");


            if (MyStuff.UsaWCF == true)
            {
                //jesus
            }
            else
            {
                //DS_Detalle = objDATA.Reporte_ProcesoLogistico_Dashboard(MyStuff.CodigoEmpresa,
                //                                    Convert.ToString(this.Cbo_AñoProceso.SelectedValue),
                //                                    Convert.ToString(this.Cbo_Version.SelectedValue),
                //                                    this.Chk_Version.Checked
                //                                );
            }


            workbook = spreadsheetControl.Document;
            string sRutaInterna = "";

            sRutaInterna = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Excel\Reporte_ProcesoLogistico_Dashboard.xlsx");
            this.Btn_LibroExcel.Caption = "Reporte_ProcesoLogistico_Dashboard.xlsx";
            workbook.LoadDocument(sRutaInterna, DocumentFormat.Xlsx);
            Worksheet worksheet_Detalle = workbook.Worksheets[0];

            DV_Detalle = DS_Detalle.Tables[0].DefaultView;
            worksheet_Detalle.DataBindings.BindToDataSource(DV_Detalle, 1, 0);


            SplashScreenManager.CloseForm();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion();
        }

        private void ultraLabel4_Click(object sender, EventArgs e)
        {

        }

        private void OptFormulacion_CheckedChanged(object sender, EventArgs e)
        {
            this.MostrarDataFiltro();
        }

        private void OptModificacion_CheckedChanged(object sender, EventArgs e)
        {
            this.MostrarDataFiltro();
        }

        private void Chk_Version_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Chk_Version.Checked)
                this.Cbo_Version.Enabled = false;
            else
                this.Cbo_Version.Enabled = true;
        }
    }
}