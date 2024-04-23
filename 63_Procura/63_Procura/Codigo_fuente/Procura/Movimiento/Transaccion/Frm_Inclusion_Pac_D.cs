using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINlogistica
{
    public partial class Frm_Inclusion_Pac_D : Form
    {
        Model.TipoMotivoInserccionPAC MMIP = new Model.TipoMotivoInserccionPAC();
        Service.Data sdl = new Service.Data();

        Model.TipoDocumento_Pac MTDP = new Model.TipoDocumento_Pac();

        public string strCodTipoDocumento = "";
        public string strNumDocumento = "";
        public string strCodMotivoInserccion = "";
        public DateTime dateFecInserccion = DateTime.Today;
        public string strNota = "";
        public bool blnGrabar = false;
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public Frm_Inclusion_Pac_D()
        {
            InitializeComponent();
        }

        public void ShowMe()
        {
            if (MyStuff.UsaWCF == true)
            {
                this.cbo_EstadoPacDetalle.CargaDT(objWCF.Combo_TipoMotivoInserccionPAC().Tables[0]);
                this.cbo_CodTipoDocumento.CargaDT(objWCF.Combo_TipoDocumento_Pac().Tables[0]);
            }
            else
            {
                this.cbo_EstadoPacDetalle.CargaDT(sdl.Combo_TipoMotivoInserccionProcesoLogistico().Tables[0]);
                this.cbo_CodTipoDocumento.CargaDT(sdl.Combo_TipoDocumento_ProcesoLogistico().Tables[0]);
            }
            
            this.ShowDialog();
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            if (this.VerificaIngresoMovimiento() == true)
            {
                DialogResult result;

                result = MessageBox.Show("Desea Incluir el Item del PAC ?",
                                                                    "Advertencia", MessageBoxButtons.YesNo,
                                                                    MessageBoxIcon.Exclamation
                                                                   );

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    strCodTipoDocumento = Convert.ToString(this.cbo_CodTipoDocumento.SelectedValue);
                    strNumDocumento = Convert.ToString(this.txt_NumDocumento.Value);
                    strCodMotivoInserccion = Convert.ToString(this.cbo_EstadoPacDetalle.SelectedValue);
                    dateFecInserccion = Convert.ToDateTime(this.dtp_FecIncluido.Value);
                    strNota = Convert.ToString(edt_MotIncluido.Value);
                    blnGrabar = true;
                }

                this.Close();
            }
        }

        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";

            if (String.IsNullOrEmpty(Convert.ToString(this.cbo_CodTipoDocumento.SelectedValue)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el Tipo de Documento";
            }


            if (String.IsNullOrEmpty(Convert.ToString(this.txt_NumDocumento.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el Número de documento";
            }

            if (String.IsNullOrEmpty(Convert.ToString(this.cbo_EstadoPacDetalle.SelectedValue)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el Motivo de la inclusión";
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

        private void Frm_Inclusion_Pac_D_Load(object sender, EventArgs e)
        {

        }
    }
}
