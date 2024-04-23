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
    public partial class Frm_Modificacion_Pac_D : Form
    {
        Model.TipoMotivoModificacionPAC MMIP = new Model.TipoMotivoModificacionPAC();
        Service.Data sdl = new Service.Data();

        Model.TipoDocumento_Pac MTDP = new Model.TipoDocumento_Pac();

        public string strCodTipoDocumento = "";
        public string strNumDocumento = "";
        public string strCodMotivoModificacion = "";
        public DateTime dateFecModificacion = DateTime.Today;
        public string strNota = "";
        public bool blnGrabar = false;
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        public Frm_Modificacion_Pac_D()
        {
            InitializeComponent();
        }

        public void ShowMe()
        {
            if (MyStuff.UsaWCF == true)
            {
                this.cbo_EstadoPacDetalle.CargaDT(objWCF.Combo_TipoMotivoModificacionPAC().Tables[0]);
                this.cbo_CodTipoDocumento.CargaDT(objWCF.Combo_TipoDocumento_Pac().Tables[0]);
            }
            else
            {
                this.cbo_EstadoPacDetalle.CargaDT(sdl.Combo_TipoMotivoModificacionProcesoLogistico().Tables[0]);
                this.cbo_CodTipoDocumento.CargaDT(sdl.Combo_TipoDocumento_ProcesoLogistico().Tables[0]);
            }
            
            this.ShowDialog();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (this.VerificaIngresoMovimiento() == true)
            {
                DialogResult result;

                result = MessageBox.Show("Desea Modificar el Item del PAC ?",
                                                                    "Advertencia", MessageBoxButtons.YesNo,
                                                                    MessageBoxIcon.Exclamation
                                                                   );

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    strCodTipoDocumento = Convert.ToString(this.cbo_CodTipoDocumento.SelectedValue);
                    strNumDocumento = Convert.ToString(this.txt_NumDocumento.Value);
                    strCodMotivoModificacion = Convert.ToString(this.cbo_EstadoPacDetalle.SelectedValue);
                    dateFecModificacion = Convert.ToDateTime(this.dtp_FecModificado.Value);
                    strNota = Convert.ToString(edt_MotModificado.Value);
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
                strMensaje = "Debe ingresar el Motivo de la modificación";
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

        private void Frm_Modificacion_Pac_D_Load(object sender, EventArgs e)
        {

        }
    }
}
