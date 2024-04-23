using DevExpress.Spreadsheet;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraSplashScreen;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace WINlogistica.Modulo
{
    public partial class UC_Programacion_CurvaS : DevExpress.XtraEditors.XtraUserControl
    {
        private WINlogistica.Framework FS = new WINlogistica.Framework();
        //private SRsafnet.SAFnetEClient objWCF = new SRsafnet.SAFnetEClient();
        private Service.Data objDATA = new Service.Data();

        IWorkbook workbook;

        private DataSet DS_NumProcedimiento = new DataSet();
        DataSet DS_Detalle;
        DataView DV_Detalle_01;

        Model.ParametroLogistica MPL = new Model.ParametroLogistica();
        private Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();
        Model.ProcesoLogistico_OperadorLogistico MPDOL = new Model.ProcesoLogistico_OperadorLogistico();

        private static UC_Programacion_CurvaS _instance;
        public static UC_Programacion_CurvaS Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Programacion_CurvaS();
                return _instance;
            }
        }
        public UC_Programacion_CurvaS()
        {
            InitializeComponent();
            this.IniciaTablas(true);
        }

        private void IniciaTablas(bool CargaCGestor)
        {
            if (MyStuff.UsaWCF)
            {
                //jesus
            }
            else
            {
                DS_NumProcedimiento = objDATA.ayuda_ProcesoLogistico(MyStuff.CodigoEmpresa,
                                                                      MyStuff.AñoProceso
                                                                    );
                this.Cbo_TipoProceso.CargaDT(objDATA.Combo_TipoProceso().Tables[0]);
            }
            this.Txt_NumProcedimiento.nombreDS = DS_NumProcedimiento;
            this.dtp_FechaCalculo.Value = DateTime.Now;

        }

        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            int iTipoMensaje = 0;
            string strMensaje = "";

            try
            {

         
                if (String.IsNullOrEmpty(Convert.ToString(this.Cbo_TipoProceso.SelectedValue)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Tipo de Proceso";
                }
                if (String.IsNullOrEmpty(Convert.ToString(this.Cbo_ObjetoContratacion.SelectedValue)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Objeto de Contratación";
                }

                if (String.IsNullOrEmpty(Convert.ToString(this.Edt_DesProcedimiento.Value)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe Ingresar la descripción del proceso";
                }


                if (blnVerifica == false)
                {
                    if (iTipoMensaje == 0)
                    {
                        MessageBox.Show(strMensaje,
                                        "Error", MessageBoxButtons.OKCancel,
                                        MessageBoxIcon.Error
                                   );
                    }
                    else
                    {
                        if (MessageBox.Show(strMensaje,
                                        "Error", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Error
                                    ) == System.Windows.Forms.DialogResult.Yes)
                        {
                            blnVerifica = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return blnVerifica;
        }
        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {


            if (VerificaIngresoMovimiento())
            {
                PintarDatos();
            }
        }

        private void PintarDatos()
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
            SplashScreenManager.Default.SetWaitFormDescription("Trayendo información...");

            int intTipoPreporte = 1;

            if (this.Opt_FechaConvocatoria.Checked == false)
                intTipoPreporte = 2;

            //Debe pintar los proyectos por elegir
            if (MyStuff.UsaWCF == true)
            {

            }
            else
            {

                DS_Detalle = objDATA.Lista_ProcesoLogistico_Programacion(MyStuff.CodigoEmpresa,
                                                                            Convert.ToString(this.Cbo_TipoProceso.SelectedValue),
                                                                            Convert.ToString(this.Cbo_ObjetoContratacion.SelectedValue),
                                                                            Convert.ToDateTime( this.dtp_FechaCalculo.Value ),
                                                                            intTipoPreporte
                                                                          ); 
            }

            if (DS_Detalle.Tables[0].Rows.Count == 0)
            {
                SplashScreenManager.CloseForm();
                MessageBox.Show("No existe información para el tipo de proceso y el objeto de contratacion");
            }
            else
            {
                workbook = spreadsheetControl.Document;
                string sRutaInterna = "";
                sRutaInterna = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Excel\Programacion_FechaContratacion.xlsx");
                //this.Btn_LibroExcel.Caption = "Programacion_FechaContratacion.xlsx";



                workbook.LoadDocument(sRutaInterna, DocumentFormat.Xlsx);
                Worksheet worksheet_Detalle = workbook.Worksheets[0];
                worksheet_Detalle.ActiveView.ShowHeadings = false;

                DV_Detalle_01 = DS_Detalle.Tables[0].DefaultView;
                //DV_Detalle_02 = DS_Detalle.Tables[1].DefaultView;
                worksheet_Detalle.DataBindings.BindToDataSource(DV_Detalle_01, 16, 1);
                //worksheet_Detalle.DataBindings.BindToDataSource(DV_Detalle_02, 8, 7);

                if (Chk_EstaEnListaPAC.Checked)
                {
                    worksheet_Detalle.Cells[6, 0].Value = "CUADRO DE PROYECCION DEL PROCESO PAC( " +
                                                            MPD.cNumProcedimiento.TrimEnd().ToUpper() +
                                                            " )";
                    worksheet_Detalle.Cells[8, 5].Value = MPD.tDesContratacion.TrimEnd().ToUpper();
                    worksheet_Detalle.Cells[9, 5].Value = MPD.vDesTipoProceso.TrimEnd().ToUpper();
                    worksheet_Detalle.Cells[10, 5].Value = MPD.fPrecioEstimado;
                    worksheet_Detalle.Cells[11, 5].Value = MPD.vNomTipoMoneda.TrimEnd().ToUpper();
                    worksheet_Detalle.Cells[12, 8].Value = MPD.vNomCentroGestor.TrimEnd().ToUpper();
                    worksheet_Detalle.Cells[13, 8].Value = MPD.vApeOperadorLogistico.TrimEnd().ToUpper();
                    worksheet_Detalle.Cells[12, 24].Value = Convert.ToDateTime(DS_Detalle.Tables[1].Rows[0][0]);
                    worksheet_Detalle.Cells[13, 24].Value = Convert.ToDateTime(DS_Detalle.Tables[1].Rows[0][1]);
                }
                else
                {
                    worksheet_Detalle.Cells[6, 0].Value = "CUADRO DE PROYECCION DEL PROCESO PAC";
                    worksheet_Detalle.Cells[8, 5].Value = Convert.ToString(this.Edt_DesProcedimiento.Value).TrimEnd().ToUpper();
                    worksheet_Detalle.Cells[9, 5].Value = Convert.ToString(this.Cbo_TipoProceso.Text).TrimEnd().ToUpper();
                    worksheet_Detalle.Cells[10, 5].Value = 0;
                    worksheet_Detalle.Cells[11, 5].Value = "";
                    worksheet_Detalle.Cells[12, 8].Value = "";
                    worksheet_Detalle.Cells[13, 8].Value = "";
                    worksheet_Detalle.Cells[12, 24].Value = Convert.ToDateTime(DS_Detalle.Tables[1].Rows[0][0]);
                    worksheet_Detalle.Cells[13, 24].Value = Convert.ToDateTime(DS_Detalle.Tables[1].Rows[0][1]);
                }
                SplashScreenManager.CloseForm();
            }
        }

        private void Chk_EstaEnListaPAC_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_EstaEnListaPAC.Checked)
            {
                this.Txt_NumProcedimiento.Enabled = true;
                this.Edt_DesProcedimiento.Enabled = false;
                this.Cbo_TipoProceso.Enabled = false;
                this.Cbo_ObjetoContratacion.Enabled = false;
                
            }
            else
            {
                this.Txt_NumProcedimiento.Enabled = false;
                this.Txt_NumProcedimiento.Value = "";
                this.Edt_DesProcedimiento.Value = "";
                this.Edt_DesProcedimiento.Enabled = true;
                this.Cbo_TipoProceso.Enabled = false;
                this.Cbo_ObjetoContratacion.Enabled = false;
                this.Cbo_TipoProceso.Enabled = true;
                this.Cbo_ObjetoContratacion.Enabled = true;
                this.dtp_FechaCalculo.Value = DateTime.Now;
            }
        }

        private void Opt_FechaConvocatoria_CheckedChanged(object sender, EventArgs e)
        {
            if (Opt_FechaConvocatoria.Checked)
                this.Lbl_FechaConvocatoria.Text = this.Opt_FechaConvocatoria.Text;
            else
                this.Lbl_FechaConvocatoria.Text = this.Opt_FechaBuenaPro.Text;
        }

        private void Opt_FechaBuenaPro_CheckedChanged(object sender, EventArgs e)
        {
            if (Opt_FechaBuenaPro.Checked)
                this.Lbl_FechaConvocatoria.Text = this.Opt_FechaBuenaPro.Text;
            else
                this.Lbl_FechaConvocatoria.Text = this.Opt_FechaConvocatoria.Text;
        }

        private void Cbo_TipoProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Cbo_TipoProceso.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                string strCodTipoProceso = Convert.ToString(this.Cbo_TipoProceso.SelectedValue);
                if (MyStuff.UsaWCF == true)
                {
                    //jesus
                }
                else
                {
                    this.Cbo_ObjetoContratacion.CargaDT(objDATA.Combo_ObjetoContratacion(strCodTipoProceso).Tables[0]);
                }

            }
        }

        private void Txt_NumProcedimiento_Leave(object sender, EventArgs e)
        {
            this.Edt_DesProcedimiento.Value = FS.TraerDescripcion_DataTable(DS_NumProcedimiento.Tables[0],
                                                                0,
                                                                1,
                                                                Convert.ToString(this.Txt_NumProcedimiento.Value)
                                                                );
            if ( string.IsNullOrEmpty( Convert.ToString( this.Edt_DesProcedimiento.Value).TrimEnd()) == false)
            {
                string strNumProcedimiento = FS.TraerDescripcion_DataTable(DS_NumProcedimiento.Tables[0],
                                                                0,
                                                                2,
                                                                Convert.ToString(this.Txt_NumProcedimiento.Value)
                                                                );
                MPD = objDATA.Recupera_ProcesoLogistico_Detalle_Codigo(strNumProcedimiento);
                this.Cbo_TipoProceso.SelectedValue = MPD.cCodTipoProceso;
                this.Cbo_ObjetoContratacion.SelectedValue = MPD.cCodObjetoContratacion;
                this.dtp_FechaCalculo.Value = MPD.dFechaPrevista;
            }
            else
            {
                this.dtp_FechaCalculo.Value = DateTime.Now;
            }
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
