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
    public partial class Frm_ActualizaPaso_PAC_cierre : Form
    {
        Model.ProcesoLogistico_Paso MPDP = new Model.ProcesoLogistico_Paso();
        Model.Paso MP = new Model.Paso();
        Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();
        Model.ProcesoLogistico_Paso_Apertura MPDPA = new Model.ProcesoLogistico_Paso_Apertura();
        Model.ProcesoLogistico_Paso_Cierre MPDPC = new Model.ProcesoLogistico_Paso_Cierre();
        Service.Data sdl = new Service.Data();

        public int intIdPac_Paso_Cierre = 0;
        public int intIdPac_Paso = 0;
        private Infragistics.Win.UltraWinGrid.UltraGrid m_Grid;
        public DateTime dateFecFinal =  DateTime.Today;
        public string strNota = "";
        public bool blnGrabaPaso = false;
        public DateTime dateFecApertura = DateTime.Today;
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        private string strFormulario = "";
        private String strNumProcedimiento = "";
        private string strDesPac = "";
        private string strCodEmpresa = "";
        private string strAñoProceso = "";
        private int intIdPasoSiguiente = 0;
        private string strFormularioSiguiente = "";
        private int intIdProcesoLogistico_PasoSiguiente = 0;

        public DateTime dateFecInicio = DateTime.Today;
        public DateTime dateFecInicial = DateTime.Today;
        public Frm_ActualizaPaso_PAC_cierre()
        {
            InitializeComponent();
        }

        public void ShowMe(int iIdPac_Detalle_Paso,
                           string cCodEmpresa,
                           string cAñoProceso,
                           DateTime dFecApertura,
                           string vFormulario,
                           string cNumProcedimiento,
                           string vDesPac,
                           Infragistics.Win.UltraWinGrid.UltraGrid Grid,
                           int iIdPasoSiguiente,
                           string vFormularioSiguiente,
                           int iIdProcesoLogistico_PasoSiguiente
                          )
        {
            intIdProcesoLogistico_PasoSiguiente = iIdProcesoLogistico_PasoSiguiente;
            intIdPasoSiguiente = iIdPasoSiguiente;
            strFormularioSiguiente = vFormularioSiguiente;
            strCodEmpresa = cCodEmpresa;
            strAñoProceso = cAñoProceso;
            strFormulario = vFormulario;
            strNumProcedimiento = cNumProcedimiento;
            strDesPac = vDesPac;
            intIdPac_Paso = iIdPac_Detalle_Paso;
            dateFecApertura = dFecApertura;
            DateTime dateFechaHoy = DateTime.Today;

            if (this.dateFecApertura < dateFechaHoy)
            {
                this.Dtp_Cierre.Value = dateFechaHoy;
            }
            else
            {
                this.Dtp_Cierre.Value = dateFecApertura;
            }


            this.Dtp_Cierre.Value = dFecApertura;
            m_Grid = Grid;
            this.ShowDialog();
        }
        private void Btn_Grabar_Click(object sender, EventArgs e)
        {
            if ( Convert.ToDateTime( this.Dtp_Cierre.Value ) < this.dateFecApertura)
            {
               MessageBox.Show("La Fecha de Inicio tiene que ser mayor o igual a la Fecha de Inicio");
            }
            else if (this.Edt_Nota.Value == null)
            {
                MessageBox.Show("Debe Ingresar un comentario en la Nota");
            }
            else
            {
                this.graba_Cierre();
            }
        }

        private void graba_Cierre()
        {
            MPDPC.iIdProcesoLogistico_Paso = intIdPac_Paso;
            MPDPC.cCodEmpleado = MyStuff.CodigoEmpleado; ;
            MPDPC.cCodTipoCierrePaso = "1";
            MPDPC.dFecCierre = Convert.ToDateTime(this.Dtp_Cierre.Value);
            MPDPC.cCodEstadoCierrePaso = "1";
            MPDPC.tNota = Convert.ToString(this.Edt_Nota.Text);
            if (MyStuff.UsaWCF == true)
            {
                intIdPac_Paso_Cierre = objWCF.Graba_Pac_Paso_Cierre(MPDPC);
            }
            else
            {
                intIdPac_Paso_Cierre = sdl.Graba_ProcesoLogistico_Paso_Cierre(MPDPC);
            }

            if (intIdPac_Paso_Cierre == 0)
            {
                blnGrabaPaso = false;
                MessageBox.Show("Error: No se pudo grabar el registro");
            }
            else
            {
                MPDPC.iIdProcesoLogistico_Paso_Cierre = intIdPac_Paso_Cierre;
                blnGrabaPaso = true;
                dateFecFinal = Convert.ToDateTime(this.Dtp_Cierre.Value);
                strNota = Convert.ToString(this.Edt_Nota.Text);

                this.AperturaNuevoPaso();

                MessageBox.Show("OK: El paso se cerro correctamente");
                this.Close();
            }
        }

        private void AperturaNuevoPaso()
        {

            if (MyStuff.UsaWCF == true)
            {
                MPD = objWCF.Recupera_Pac_Detalle_Codigo(strNumProcedimiento);
            }
            else
            {
                MPD = sdl.Recupera_ProcesoLogistico_Detalle_Codigo(strNumProcedimiento);
            }

            string strAñoProcesoValue = MPD.cAñoProceso;
            string strVersionValue = MPD.cVersion;
            string strCodPacValue = MPD.cCodProcesoLogistico;
            string strPACValue = MPD.tDesContratacion;
            double dblPrecioEstimadoValue = MPD.fPrecioEstimado;

            if (intIdPasoSiguiente != 0)
            {
                int intIdPaso_Value = intIdPasoSiguiente;
                if (MyStuff.UsaWCF == true)
                {
                }
                else
                {
                    MP = sdl.Recupera_Paso( intIdPasoSiguiente
                                                 );
                }

                string strDesPaso_Value = MP.vDesPaso;
                DateTime[] dateFechas;
                if (MyStuff.UsaWCF == true)
                {
                    dateFechas = objWCF.Recupera_Pac_Paso_Apertura_Proceso(MPD.cNumProcedimiento, "");
                }
                else
                {
                    //corregirdateFechas = sdl.Recupera_ProcesoLogistico_Paso_Apertura_Proceso(MPD.cNumProcedimiento, MPD.cCodTipoPlantilla, strCodPasoSiguiente);
                    dateFechas = sdl.Recupera_ProcesoLogistico_Paso_Apertura_Proceso(MPD.cNumProcedimiento, MPD.cCodTipoPlantilla, intIdPasoSiguiente);
                }


                DateTime dateFecInicio_Value = dateFechas[0];
                DateTime dateFecFinal_Value = dateFechas[1];
                DateTime dateApertura_Value = dateFechas[0];


                MPDP.cNumProcedimiento = strNumProcedimiento;
                MPDP.iIdPaso = intIdPasoSiguiente;
                //MPDP.ccod = 0;
                MPDP.dFecInicio = Convert.ToDateTime(dateFecInicio_Value);
                MPDP.dFecFinal = Convert.ToDateTime(dateFecFinal_Value);

                MPDPA.cCodEmpleado = MyStuff.CodigoEmpleado;
                MPDPA.cCodTipoAperturaPaso = "1";
                MPDPA.dFecApertura = Convert.ToDateTime(this.Dtp_Cierre.Value).AddDays(1);
                MPDPA.cCodEstadoAperturaPaso = "1";
                MPDPA.tNota = "El Paso se aperturo automaticamente";
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
                    MessageBox.Show("Error: No se pudo aperturar el registro");
                }
                else
                {
                    MPDPA.iIdProcesoLogistico_Paso = intIdPac_Paso;
                    blnGrabaPaso = true;
                    //dateFecInicio = Convert.ToDateTime(dateFecInicio_Value);
                    //dateFecFinal = Convert.ToDateTime(dateFecFinal_Value);
                    //dateFecInicial = Convert.ToDateTime(dateApertura_Value);
                    //strNota = "El Paso se aperturo automaticamente";

                    switch (strFormularioSiguiente.TrimEnd())
                    {
                        case "GrabaFicha":
                            this.Graba_FichaPresupuestal();
                            //this.Cierre_Paso();
                            break;
                        default:
                            break;
                    }

                    //Grabar en Ficha Presupuestal
                }


            }

        }

        private void Cierre_Paso()
        {
            strNota = "Cierre de Proceso Automatico";
            dateFecFinal = Convert.ToDateTime(DateTime.Now);
            Model.ProcesoLogistico_Paso_Cierre MPDPC = new Model.ProcesoLogistico_Paso_Cierre();
            MPDPC.iIdProcesoLogistico_Paso = intIdProcesoLogistico_PasoSiguiente;
            MPDPC.cCodEmpleado = MyStuff.CodigoEmpleado; ;
            MPDPC.cCodTipoCierrePaso = "4";
            MPDPC.dFecCierre = dateFecFinal;
            MPDPC.cCodEstadoCierrePaso = "1";
            MPDPC.tNota = "El Paso se cerro automaticamente";
            int intIdPac_Paso_Cierre = 0;
            if (MyStuff.UsaWCF == true)
            {
                intIdPac_Paso_Cierre = objWCF.Graba_Pac_Paso_Cierre(MPDPC);

            }
            else
            {
                intIdPac_Paso_Cierre = sdl.Graba_ProcesoLogistico_Paso_Cierre(MPDPC);
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
        private void Btn_Formulario_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_ActualizaPaso_PAC_cierre_Load(object sender, EventArgs e)
        {

        }
    }
}
