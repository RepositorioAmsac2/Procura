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
    public partial class Frm_ActualizaPaso_Apertura_Inicio : Form
    {
        Model.ProcesoLogistico_Paso MPP = new Model.ProcesoLogistico_Paso();
        Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();
        Service.Data sdl = new Service.Data();

        Model.ProcesoLogistico_Paso MPDP = new Model.ProcesoLogistico_Paso();
        Model.ProcesoLogistico_Paso_Apertura MPDPA = new Model.ProcesoLogistico_Paso_Apertura();

        Model.Paso MP = new Model.Paso();

        public bool blnGrabaApertura = false;
        public int intIdPac_Paso_Apertura = 0;
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        public Frm_ActualizaPaso_Apertura_Inicio()
        {
            InitializeComponent();
        }

        public void ShowMe(string strNumProcedimiento, int intExcluido )
        {
            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                MPD = sdl.Recupera_ProcesoLogistico_Detalle_Codigo(strNumProcedimiento);
            }
            
            Model.TipoProceso_Duracion MTPD = new Model.TipoProceso_Duracion();

            this.txt_AñoProceso.Value = MPD.cAñoProceso;
            this.txt_Version.Value = MPD.cVersion;
            this.Txt_NumProcedimiento.Text = MPD.cNumProcedimiento;
            this.edt_PAC.Value = MPD.tDesContratacion;
            this.txt_PrecioEstimado.Value = String.Format("{0:0,0.00}", MPD.fPrecioEstimado);

            if (MyStuff.UsaWCF == true)
            {
                MPP = objWCF.Recupera_Pac_Paso_Apertura_Procedimiento(strNumProcedimiento);
            }
            else
            {
                MPP = sdl.Recupera_ProcesoLogistico_Paso_Apertura_Procedimiento(strNumProcedimiento);
            }
            

            Model.Paso MP = new Model.Paso();
            if (MyStuff.UsaWCF == true)
            {
                //jesusMP = objWCF.Recupera_Paso_codigo(MPP.cCodPaso);
            }
            else
            {
                MP = sdl.Recupera_Paso(  MPP.iIdPaso);
            }
            

            this.txt_CodPaso.Value = MP.cCodPaso;
            this.txt_DesPaso.Value = MP.vDesPaso;
            this.dtp_FecInicio.Value = MPP.dFecInicio;
            this.dtp_FecFinal.Value = MPP.dFecFinal;
            this.dtp_Apertura.Value = MPP.dFecInicio;
            if (intExcluido == 0)
                this.dtp_Apertura.Focus();
            else
                this.btnGrabar.Enabled = false;
        }

        private bool VerificaInformacion()
        {
            bool blnVerifica = true;
            string strMensaje = "";

            if (String.IsNullOrEmpty( Convert.ToString( this.txt_CodPaso.Value)))
            {
                blnVerifica = false;
                strMensaje = "Tiene que configurar los pasos de de este bien";
            }
            if (String.IsNullOrEmpty( Convert.ToString(  this.edt_Nota.Value)) )
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar alguna nota";
            }

            if ( Convert.ToDateTime( this.dtp_Apertura.Value ).Date < Convert.ToDateTime( this.dtp_FecInicio.Value).Date)
            {
                blnVerifica = false;
                strMensaje = "La Fecha de Apertura tiene que ser mayor o igual a la Fecha de Inicio";
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


        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            if (this.VerificaInformacion())
            {

                MPDP.cNumProcedimiento = MPD.cNumProcedimiento;
                MPDP.iIdPaso = Convert.ToInt32(MPP.iIdPaso);
                MPDP.dFecInicio = Convert.ToDateTime(this.dtp_FecInicio.Value);
                MPDP.dFecFinal = Convert.ToDateTime(this.dtp_FecFinal.Value);

                MPDPA.dFecApertura = Convert.ToDateTime(this.dtp_Apertura.Value);
                MPDPA.cCodEmpleado = MyStuff.CodigoEmpleado;
                MPDPA.tNota = Convert.ToString(this.edt_Nota.Value);

                if (MyStuff.UsaWCF == true)
                {
                    intIdPac_Paso_Apertura = objWCF.Graba_Pac_Paso_Apertura_Inicio(MPDP, MPDPA);
                }
                else
                {
                    intIdPac_Paso_Apertura = sdl.Graba_ProcesoLogistico_Paso_Apertura_Inicio(MPDP, MPDPA);
                }
                

                MPDPA.iIdProcesoLogistico_Paso_Apertura = intIdPac_Paso_Apertura;
                if (MPDPA.iIdProcesoLogistico_Paso_Apertura == 0)
                {
                    MessageBox.Show("Error: No se grabo el registro");
                }
                else
                {
                    this.dtp_Apertura.Enabled = false;
                    this.edt_Nota.Enabled = false;
                    this.btnGrabar.Enabled = false;
                    blnGrabaApertura = true;
                    MessageBox.Show("OK: El Proceso se inicio Correctamente");
                    this.Close();
                }
            }
        }

        private void Frm_ActualizaPaso_Apertura_Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
