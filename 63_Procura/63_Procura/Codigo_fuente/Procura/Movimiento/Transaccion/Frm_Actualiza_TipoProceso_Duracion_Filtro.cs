using System;
using System.Data;
using System.Windows.Forms;

namespace WINlogistica
{
    public partial class Frm_Actualiza_TipoProceso_Duracion_Filtro : DevExpress.XtraEditors.XtraForm
    {
        private Service.Data objDATA = new Service.Data();

        public Boolean blnProcesaExcel = false;
        DataSet DS_TipoProceso;
        DataSet DS_ObjetoContratacion;

        private Framework FS = new Framework();

        public string strPeriodoProceso = "";
        public string strCodTipoProceso = "";
        public string strDesTipoProceso = "";

        public string strCodObjetoContratacion = "";
        public string strDesObjetoContratacion = "";
        public Frm_Actualiza_TipoProceso_Duracion_Filtro()
        {
            InitializeComponent();
        }

        public void ShowMe(string cCodTipoProceso,
                           string cDesTipoProceso,
                           string cCodObjetoContratacion,
                           string cDesObjetoContratacion
                          )
        {

            this.Txt_Empresa.Value = MyStuff.NombreEmpresa;

            this.Txt_CodTipoProceso.Value = cCodTipoProceso;
            this.Txt_DesTipoProceso.Value = cDesTipoProceso;

            this.Txt_CodObjetoContratacion.Value = cCodObjetoContratacion;
            this.Txt_DesObjetoContratacion.Value = cDesObjetoContratacion;

            if (MyStuff.UsaWCF)
            {
                //jesus
            }
            else
                this.Cbo_PeriodoProceso.CargaDT(objDATA.Combo_PeriodoProceso().Tables[0]);

            if (MyStuff.UsaWCF == true)
            {
                //jesusDS_TipoFormulacion = objWCF.Ayuda_TipoFormulacion_HojaTrabajo(MyStuff.CodigoEmpresa);
            }
            else
            {
                DS_TipoProceso = objDATA.Ayuda_TipoProceso();
            }

            this.Txt_CodTipoProceso.nombreDS = DS_TipoProceso;

            if (cCodTipoProceso.TrimEnd() != "")
            {
                if (MyStuff.UsaWCF == true)
                {
                    //jesus
                }
                else
                    DS_ObjetoContratacion = objDATA.Ayuda_ObjetoContratacion_TipoProceso(cCodTipoProceso
                                                                              );

                this.Txt_CodObjetoContratacion.nombreDS = DS_ObjetoContratacion;
                this.Txt_CodObjetoContratacion.Enabled = true;
            }
            else
                this.Txt_CodObjetoContratacion.Enabled = false;

            this.ShowDialog();
        }

        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_DesTipoProceso.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar un tipo de proceso";
            }
            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_DesObjetoContratacion.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar un objeto de contratación";
            }

            if (blnVerifica == false)
            {
                MessageBox.Show(strMensaje,
                                "Error", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Error
                           );
            }
            return blnVerifica;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (VerificaIngresoMovimiento())
            {
                this.strPeriodoProceso = Convert.ToString(this.Cbo_PeriodoProceso.SelectedValue);
                this.strCodTipoProceso = Convert.ToString(this.Txt_CodTipoProceso.Value);
                this.strDesTipoProceso = Convert.ToString(this.Txt_DesTipoProceso.Value);
                this.strCodObjetoContratacion = Convert.ToString(this.Txt_CodObjetoContratacion.Value);
                this.strDesObjetoContratacion = Convert.ToString(this.Txt_DesObjetoContratacion.Value);
                this.blnProcesaExcel = true;

                this.Close();

            }
        }

        private void Txt_CodTipoProceso_Leave(object sender, EventArgs e)
        {
            this.Txt_DesTipoProceso.Value = FS.TraerDescripcion_DataTable(DS_TipoProceso.Tables[0],
                                                                        0,
                                                                        1,
                                                                        Convert.ToString(this.Txt_CodTipoProceso.Value)
                                                                        );
            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_DesTipoProceso.Value)))
            {
                this.Txt_CodObjetoContratacion.Value = "";
                this.Txt_DesObjetoContratacion.Value = "";
                this.Txt_CodObjetoContratacion.Enabled = false;
            }
            else
            {
                if (MyStuff.UsaWCF == true)
                    {
                        //jesus
                    }                    
                else
                    DS_ObjetoContratacion = objDATA.Ayuda_ObjetoContratacion_TipoProceso( Convert.ToString(this.Txt_CodTipoProceso.Value)
                                                                              );

                this.Txt_CodObjetoContratacion.nombreDS = DS_ObjetoContratacion;
                this.Txt_CodObjetoContratacion.Enabled = true;
                this.Txt_CodObjetoContratacion.Focus();
            }

        }

        private void Txt_CodObjetoContratacion_Leave(object sender, EventArgs e)
        {
            this.Txt_DesObjetoContratacion.Value = FS.TraerDescripcion_DataTable(DS_ObjetoContratacion.Tables[0],
                                                                        0,
                                                                        1,
                                                                        Convert.ToString(this.Txt_CodObjetoContratacion.Value)
                                                                        );

        }
    }
}