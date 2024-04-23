using DevExpress.Spreadsheet;
using DevExpress.XtraSplashScreen;
using System;
using System.Data;
using System.IO;

namespace WINlogistica
{


    public partial class UC_HojaTrabajo_CurvaS : DevExpress.XtraEditors.XtraForm
    {
        IWorkbook workbook;
        //private SRsafnet.SAFnetEClient objWCF = new SRsafnet.SAFnetEClient();
        private Service.Data objDATA = new Service.Data();

        DataSet DS_Detalle;
        DataView DV_Detalle_01;
        private Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();

        private Framework FS = new Framework();

        public UC_HojaTrabajo_CurvaS()
        {
            InitializeComponent();
        }

        public void ShowMe( string strNumProcedimiento,  
                            string strTipoReporte
                          )
        {

            if (MyStuff.UsaWCF == true)
            {
                //jesus
            }
            else
            {
                DS_Detalle = objDATA.Reporte_Pac_Paso_CurvaS(strNumProcedimiento
                                                );
                MPD = objDATA.Recupera_ProcesoLogistico_Detalle_Codigo(strNumProcedimiento);
            }

            workbook = spreadsheetControl.Document;
            string sRutaInterna = "";

            if (strTipoReporte.TrimEnd() == "Procura")
            {
                sRutaInterna = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Excel\Grafico_CurvaS.xlsx");
                this.Btn_LibroExcel.Caption = "Grafico_CurvaS.xlsx";
            }
            else
            {
                sRutaInterna = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Excel\Grafico_CurvaS_Reporte.xlsx");
                this.Btn_LibroExcel.Caption = "Grafico_CurvaS_Reporte.xlsx";
            }
            
            workbook.LoadDocument(sRutaInterna, DocumentFormat.Xlsx);
            Worksheet worksheet_Detalle = workbook.Worksheets[0];
            worksheet_Detalle.ActiveView.ShowHeadings = false;

            DV_Detalle_01 = DS_Detalle.Tables[0].DefaultView;
            //DV_Detalle_02 = DS_Detalle.Tables[1].DefaultView;
            worksheet_Detalle.DataBindings.BindToDataSource(DV_Detalle_01, 16, 1);
            //worksheet_Detalle.DataBindings.BindToDataSource(DV_Detalle_02, 8, 7);

            worksheet_Detalle.Cells[6, 0].Value = "CUADRO DE SEGUIMIENTO DEL PROCESO PAC( " +
                                                    MPD.cNumProcedimiento.TrimEnd().ToUpper() +
                                                    " )";
            worksheet_Detalle.Cells[8, 5].Value = MPD.tDesContratacion.TrimEnd().ToUpper();
            worksheet_Detalle.Cells[9, 5].Value = MPD.vDesTipoProceso.TrimEnd().ToUpper();
            worksheet_Detalle.Cells[10, 5].Value = MPD.fPrecioEstimado;
            worksheet_Detalle.Cells[11, 5].Value = MPD.vNomTipoMoneda.TrimEnd().ToUpper();
            worksheet_Detalle.Cells[12, 8].Value = MPD.vNomCentroGestor.TrimEnd().ToUpper();
            worksheet_Detalle.Cells[13, 8].Value = MPD.vApeOperadorLogistico.TrimEnd().ToUpper();
            worksheet_Detalle.Cells[12, 24].Value = Convert.ToDateTime( DS_Detalle.Tables[1].Rows[0][0] );
            worksheet_Detalle.Cells[13, 24].Value = Convert.ToDateTime(DS_Detalle.Tables[1].Rows[0][1]);
        }

        private void UC_HojaTrabajo_CurvaS_Load(object sender, EventArgs e)
        {

        }
    }
}