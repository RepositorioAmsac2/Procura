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
    public partial class Frm_ActualizaPaso_Apertura_Proceso : Form
    {
        Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();
        Service.Data sdl = new Service.Data();

        Model.ProcesoLogistico_Paso MPDP = new Model.ProcesoLogistico_Paso();

        Model.ProcesoLogistico_Paso_Apertura MPDPA = new Model.ProcesoLogistico_Paso_Apertura();

        Model.Paso MP = new Model.Paso();

        public int intIdPac_Paso = 0;
        public string strNumProcedimiento = "";
        private string strFormulario = "";
        private   Infragistics.Win.UltraWinGrid.UltraGrid m_Grid;
        public int intIdPaso = 0;
        public DateTime dateFecInicio = DateTime.Today;
        public DateTime dateFecFinal = DateTime.Today;
        public DateTime dateFecInicial = DateTime.Today;
        public string strNota = "";
        public bool blnGrabaPaso = false;
        public bool blnCierreAutomatico = false;
        private int intIdPacPaso = 0;
        private string strAñoProceso = "";
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        public Frm_ActualizaPaso_Apertura_Proceso()
        {
            InitializeComponent();
        }

        private void Btn_Grabar_Click(object sender, EventArgs e)
        {
            if (this.VerificaInformacion())
            {
                MPDP.cNumProcedimiento = strNumProcedimiento;
                MPDP.iIdPaso = intIdPaso;
                MPDP.dFecInicio = Convert.ToDateTime( this.Dtp_FecInicio.Value );
                MPDP.dFecFinal = Convert.ToDateTime( this.Dtp_FecFinal.Value );

                MPDPA.cCodEmpleado = MyStuff.CodigoEmpleado;
                MPDPA.cCodTipoAperturaPaso = "1";
                MPDPA.dFecApertura = Convert.ToDateTime(this.Dtp_Apertura.Value);
                MPDPA.cCodEstadoAperturaPaso = "1";
                MPDPA.tNota = Convert.ToString(this.Edt_Nota.Text);
                if (MyStuff.UsaWCF == true)
                {
                    intIdPac_Paso = objWCF.Graba_Pac_Paso_Apertura(MPDPA, MPDP);
                }
                else
                {
                    intIdPac_Paso = sdl.Graba_ProcesoLogistico_Paso_Apertura(MPDPA, MPDP);
                }
                
                if (intIdPac_Paso == 0)
                {
                    blnGrabaPaso = false;
                    MessageBox.Show("Error: No se pudo grabar el registro");
                }
                else
                {
                    MPDPA.iIdProcesoLogistico_Paso = intIdPac_Paso;
                    blnGrabaPaso = true;
                    dateFecInicio = Convert.ToDateTime(this.Dtp_FecInicio.Value);
                    dateFecFinal = Convert.ToDateTime(this.Dtp_FecFinal.Value);
                    dateFecInicial = Convert.ToDateTime(this.Dtp_Apertura.Value);
                    strNota = Convert.ToString(this.Edt_Nota.Text);

                    switch (strFormulario.TrimEnd())
                    {
                        case "GrabaFicha":
                            this.Graba_FichaPresupuestal();
                            this.Cierre_Paso();
                            break;
                        default:
                            break;
                    }

                    //Grabar en Ficha Presupuestal


                    MessageBox.Show("OK: El Paso se aperturo Correctamente");
                    this.Close();
                }
            }
        }

        private void Graba_FichaPresupuestal()
        {
            Model.ProcesoLogistico_FichaPresupuestal plfp = new Model.ProcesoLogistico_FichaPresupuestal();
            plfp.cCodEmpresa = MyStuff.CodigoEmpresa;
            plfp.cNumProcedimiento = strNumProcedimiento;
            plfp.fImporte = 0;
            plfp.dFecMovimiento = DateTime.Now;
            plfp.cCodEmpleado = MyStuff.CodigoEmpleado;
            plfp.tObservacion = "";
            plfp.cCodEstadoProcesoLogistico_FichaPresupuestal = "1";

            sdl.graba_ProcesoLogistico_FichaPresupuestal(plfp);
        }

        private void Cierre_Paso()
        {
            strNota = "Cierre de Proceso Automatico";
            dateFecFinal = Convert.ToDateTime( DateTime.Now );
            Model.ProcesoLogistico_Paso_Cierre MPDPC = new Model.ProcesoLogistico_Paso_Cierre();
            MPDPC.iIdProcesoLogistico_Paso = intIdPac_Paso;
            MPDPC.cCodEmpleado = MyStuff.CodigoEmpleado; ;
            MPDPC.cCodTipoCierrePaso = "4";
            MPDPC.dFecCierre = dateFecFinal;
            MPDPC.cCodEstadoCierrePaso = "1";
            MPDPC.tNota = strNota;
            int intIdPac_Paso_Cierre = 0;
            if (MyStuff.UsaWCF == true)
            {
                intIdPac_Paso_Cierre = objWCF.Graba_Pac_Paso_Cierre(MPDPC);
                blnCierreAutomatico = true;
                
            }
            else
            {
                intIdPac_Paso_Cierre = sdl.Graba_ProcesoLogistico_Paso_Cierre(MPDPC);
            }

        }

        public void ShowMe( int iIdPacPaso,
                            string cAñoProceso,
                            string cNumProcedimiento,
                            int iIdPaso,
                            string cFormulario,
                            Infragistics.Win.UltraWinGrid.UltraGrid Grid
                          )
        {
            intIdPacPaso = iIdPacPaso;
            strAñoProceso = cAñoProceso;
            strFormulario = cFormulario;
            strNumProcedimiento = cNumProcedimiento;
            intIdPaso = iIdPaso;
            m_Grid = Grid;
            if (MyStuff.UsaWCF == true)
            {
                MPD = objWCF.Recupera_Pac_Detalle_Codigo(strNumProcedimiento);
            }
            else
            {
                MPD = sdl.Recupera_ProcesoLogistico_Detalle_Codigo(strNumProcedimiento);
            }
            

            this.Txt_AñoProceso.Value = MPD.cAñoProceso;
            this.Txt_Version.Value = MPD.cVersion;
            this.Txt_CodPac.Value = MPD.cCodProcesoLogistico;
            this.Edt_PAC.Value = MPD.tDesContratacion;
            this.Txt_PrecioEstimado.Value = String.Format("{0:0,0.00}", MPD.fPrecioEstimado);

            if (intIdPaso != 0)
            {
                this.Txt_CodPaso.Value = intIdPaso;
                if (MyStuff.UsaWCF == true)
                {
                }
                else
                {
                    MP = sdl.Recupera_Paso(  intIdPaso );
                }
                
                this.Txt_DesPaso.Value = MP.vDesPaso;
                DateTime[] dateFechas;
                if (MyStuff.UsaWCF == true)
                {
                    dateFechas = objWCF.Recupera_Pac_Paso_Apertura_Proceso(MPD.cNumProcedimiento, "");
                }
                else
                { 
                    dateFechas = sdl.Recupera_ProcesoLogistico_Paso_Apertura_Proceso(MPD.cNumProcedimiento,MPD.cCodTipoPlantilla, intIdPaso);
                }
                

                this.Dtp_FecInicio.Value = dateFechas[0];
                this.Dtp_FecFinal.Value = dateFechas[1];
                this.Dtp_Apertura.Value = dateFechas[0];
                this.Dtp_Apertura.Focus();
            }
            this.ShowDialog();

        }

        private bool VerificaInformacion()
        {
            bool blnVerifica = true;
            string strMensaje = "";

            if (String.IsNullOrEmpty( Convert.ToString( this.Txt_CodPaso.Value)) )
            {
                blnVerifica = false;
                strMensaje = "Tiene que configurar los pasos de de este bien";
            }
            if (String.IsNullOrEmpty( Convert.ToString( this.Edt_Nota.Value)) )
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar alguna nota";
            }

            if (  Convert.ToDateTime( this.Dtp_Apertura.Value ).Date < Convert.ToDateTime( this.Dtp_FecInicio.Value ).Date ) 
            {
                blnVerifica = false;
                strMensaje = "La Fecha de Inicio tiene que ser mayor o igual a la Fecha de Inicio";
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

        private void Frm_ActualizaPaso_Apertura_Proceso_Load(object sender, EventArgs e)
        {

        }
    }
}
