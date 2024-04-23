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
    public partial class Frm_RechazoRequerimiento : Form
    {
        public Boolean blnDescarta = false;
        public string strCodMotivoDescarte = "";
        public DateTime dtpFecDescarte = DateTime.Today;
        public string strNotaDescarte = "";
        //private SRgestionE.WCFgestionEClient objWCF = new SRgestionE.WCFgestionEClient();
        Service.Data sdl = new Service.Data();
        public Frm_RechazoRequerimiento()

        {
            InitializeComponent();
        }

        public void ShowMe(string strCodTipoRechazo)
        {
            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                if (strCodTipoRechazo.TrimEnd() == "3")
                {
                    this.Cbo_MotivoRechazo.CargaDT(sdl.Combo_TipoMensajeValidacion().Tables[0]);
                }
                else
                {
                    this.Cbo_MotivoRechazo.CargaDT(sdl.Combo_MotivoRechazoRequerimiento(strCodTipoRechazo).Tables[0]);
                }
                
            }

            switch (strCodTipoRechazo.TrimEnd())
            {
                case "1":
                    this.Text = "Rechazar Requerimiento";
                    break;
                case "2":
                    this.Text = "Anular Requerimiento";
                    break;
                default:
                    this.Text = "Rechazar el pase presupuestal";
                    break;
            }
            this.ShowDialog();
        }

        private void Btn_Rechazar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Convert.ToString(this.Cbo_MotivoRechazo.SelectedValue)))
            {
                MessageBox.Show("Debe elegir el Motivo");
            }
            else
            {
                strCodMotivoDescarte = Convert.ToString(this.Cbo_MotivoRechazo.SelectedValue);
                strNotaDescarte = Convert.ToString(this.Edt_MotRechazo.Value);
                dtpFecDescarte = Convert.ToDateTime(this.Dtp_FecRechazo.Value);
                blnDescarta = true;
                this.Close();
            }
            
        }

        private void Frm_RechazoRequerimiento_Load(object sender, EventArgs e)
        {

        }
    }
}
