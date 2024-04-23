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
    public partial class Frm_Inclusion_Pac_ConFormulacion : Form
    {
        private Model.ProcesoLogistico_Cabecera MPC = new Model.ProcesoLogistico_Cabecera();
        private Service.Data sdl = new Service.Data();

        private Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();

        private Model.TipoProceso MTP = new Model.TipoProceso();

        private Model.ObjetoContratacion MOC = new Model.ObjetoContratacion();

        private Model.TipoFuenteFinanciamiento MFF = new Model.TipoFuenteFinanciamiento();

        private Model.TipoAdquisicion MTA = new Model.TipoAdquisicion();

        private Model.EntidadEncargadaConvocante MEEC = new Model.EntidadEncargadaConvocante();

        private Model.ParametroLogistica MPL = new Model.ParametroLogistica();

        private Model.ModalidadSeleccion MMS = new Model.ModalidadSeleccion();


        private WINlogistica.Framework FS = new WINlogistica.Framework();
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public Frm_Inclusion_Pac_ConFormulacion()
        {
            InitializeComponent();
        }

        private void Frm_Inclusion_Pac_Load(object sender, EventArgs e)
        {
            if (MyStuff.UsaWCF == true)
            {
                MPC = objWCF.Recupera_Pac_Cabecera_Id();
            }
            else
            {
                MPC = sdl.Recupera_ProcesoLogistico_Cabecera_Id();
            }
            
            if (MPC.iIdProcesoLogistico_Cabecera != 0)
            {
                this.txt_AñoProceso.Value = MPC.cAñoProceso;
                this.txt_Version.Value = MPC.cVersion;

                this.tsb_Nuevo.Enabled = false;

                if (MyStuff.UsaWCF == true)
                {
                    this.cbo_TipoProceso.CargaDT(objWCF.Combo_TipoProceso().Tables[0]);
                }
                else
                {
                    this.cbo_TipoProceso.CargaDT(sdl.Combo_TipoProceso().Tables[0]);
                }
                
                String strCodTipoProceso = Convert.ToString(this.cbo_TipoProceso.SelectedValue);

                if (MyStuff.UsaWCF == true)
                {
                }
                else
                {
                    this.cbo_ObjetoContratacion.CargaDT(sdl.Combo_ObjetoContratacion(strCodTipoProceso).Tables[0]);

                    this.cbo_FuenteFinanciamiento.CargaDT(sdl.Combo_TipoFuenteFinanciamiento().Tables[0]);

                    this.cbo_TipoAdquisicion.CargaDT(sdl.Combo_TipoAdquisicion().Tables[0]);

                    this.cbo_EntidadConvocante.CargaDT(sdl.Combo_EntidadEncargadaConvocante().Tables[0]);

                    this.cbo_EntidadConvocante.SelectedValue = sdl.Recupera_ParametroLogistica_Codigo("20").vValParametroLogistica.TrimEnd();

                    this.cbo_ModalidadSeleccion.CargaDT(sdl.Combo_ModalidadSeleccion().Tables[0]);

                }

                this.BlanquearDatos();

            }

        }

        private void Txt_NumProcedimiento_Leave(object sender, EventArgs e)
        {

        }

        private void cbo_TipoProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( Convert.ToString( this.cbo_TipoProceso.SelectedValue ) != "System.Data.DataRowView" )
                {
                string strCodTipoProceso = Convert.ToString(this.cbo_TipoProceso.SelectedValue);
                if (MyStuff.UsaWCF == true)
                {
                    this.cbo_ObjetoContratacion.CargaDT(objWCF.Combo_ObjetoContratacion(strCodTipoProceso).Tables[0]);
                }
                else
                {
                    this.cbo_ObjetoContratacion.CargaDT(sdl.Combo_ObjetoContratacion(strCodTipoProceso).Tables[0]);
                }
                
                this.Txt_NumProcedimiento.Text = "";
                //this.txt_CodPac.Value = "";
                }
        }

        private void BlanquearDatos()
        {

            Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();

            //this.txt_CodPac.Value = MPD.cCodPac;
            this.Txt_NumProcedimiento.Text = MPD.cNumProcedimiento;
            this.cbo_TipoProceso.SelectedValue = MPD.cCodTipoProceso;
            this.cbo_ObjetoContratacion.SelectedValue = MPD.cCodObjetoContratacion;
            this.edt_Descripcion.Value = MPD.tDesContratacion;
            this.cbo_FuenteFinanciamiento.SelectedValue = MPD.cCodTipoFuenteFinanciamiento;
            this.dtp_FechaPrevista.Value = MPD.dFechaPrevista;
            this.cbo_TipoAdquisicion.SelectedValue = MPD.cCodTipoAdquisicion;
            this.cbo_EntidadConvocante.SelectedValue = MPD.cCodEntidadEncargadaConvocante;
            this.cbo_ModalidadSeleccion.SelectedValue = MPD.cCodModalidadSeleccion;
        }

        private void tsb_Nuevo_Click(object sender, EventArgs e)
        {
            this.BlanquearDatos();
            this.tsb_Grabar.Enabled = true;
            this.tsb_Grabar_Salir.Enabled = true;
            this.tsb_Nuevo.Enabled = false;
            this.Txt_NumProcedimiento.Focus();
        }

        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            int iTipoMensaje = 0;
            string strMensaje = "";

            try
            {

                if (String.IsNullOrEmpty(Convert.ToString(this.cbo_TipoProceso.SelectedValue)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Tipo de Proceso";
                }
                if (String.IsNullOrEmpty(Convert.ToString(this.cbo_ObjetoContratacion.SelectedValue)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Objeto de Contratación";
                }

                if (String.IsNullOrEmpty(Convert.ToString(this.cbo_FuenteFinanciamiento.SelectedValue)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe Ingresar la fuente de Financiamiento";
                }
                if (String.IsNullOrEmpty(Convert.ToString(this.cbo_TipoAdquisicion.SelectedValue)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Tipo de Compra o Selección";
                }
                if (String.IsNullOrEmpty(Convert.ToString(this.cbo_ModalidadSeleccion.SelectedValue)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe Ingresar la Modalidad de Selección";
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

        private void tsb_Grabar_Click(object sender, EventArgs e)
        {
            if ( this.VerificaIngresoMovimiento() ) 
                {
                this.Grabar_PAC();
            }
        }

        private bool Grabar_PAC()
        {
            bool blnSalir = false;

            Frm_Inclusion_Pac_D frm = new Frm_Inclusion_Pac_D();

            frm.ShowMe();
            if (frm.blnGrabar == true)
            {
                //
                //-- Grabar Datos en la tabla del PAC
                //
                Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();
                MPD.iIdProcesoLogistico_Cabecera = MPC.iIdProcesoLogistico_Cabecera;
                MPD.cCodProcesoLogistico = "";
                MPD.cNumProcedimiento = Convert.ToString(this.Txt_NumProcedimiento.Text);
                MPD.cCodTipoProceso = Convert.ToString(this.cbo_TipoProceso.SelectedValue);
                MPD.cCodUnidadMedida = "";
                MPD.cCodObjetoContratacion = Convert.ToString(this.cbo_ObjetoContratacion.SelectedValue);
                MPD.tDesContratacion = Convert.ToString(this.edt_Descripcion.Value);
                MPD.fCantidad = 1;
                MPD.fPrecioEstimado = 1;  // Sumatoria del detalle del requerimiento
                MPD.cCodTipoMoneda = "LO"; // Tipo de moneda de la cabecera del requerimiento
                MPD.cCodTipoFuenteFinanciamiento = Convert.ToString(this.cbo_FuenteFinanciamiento.SelectedValue);
                MPD.dFechaPrevista = Convert.ToDateTime(this.dtp_FechaPrevista.Value);
                MPD.cCodTipoAdquisicion = Convert.ToString(this.cbo_TipoAdquisicion.SelectedValue);
                MPD.cCodModalidadSeleccion = Convert.ToString(this.cbo_ModalidadSeleccion.SelectedValue);
                MPD.cCodCentro = "";  //Borrar
                MPD.cCodCentroGestor = "";  // CentroGestor General
                MPD.tObservacion = "";
                MPD.cCodEntidadEncargadaConvocante = Convert.ToString(this.cbo_EntidadConvocante.SelectedValue);
                MPD.cCodMotivoInserccion = frm.strCodMotivoInserccion;
                MPD.dFecInsertado = frm.dateFecInserccion;
                MPD.tMotInsertado = frm.strNota;
                MPD.cCodEmpleado  = WINlogistica.MyStuff.CodigoEmpleado;
                MPD.cCodTipoDocumento = frm.strCodTipoDocumento;
                MPD.cNumDocumento = frm.strNumDocumento;

                //
                //-- Grabar Datos en la tabla del detalle PAC
                //

                int intIdpac_Detalle = 0;
                if (MyStuff.UsaWCF == true)
                {
                    intIdpac_Detalle = objWCF.Graba_Pac_Detalle(MPD);
                }
                else
                {
                    intIdpac_Detalle = sdl.Graba_ProcesoLogistico_Detalle(MPD);
                }
                

                if (intIdpac_Detalle != 0)
                {
                    this.tsb_Nuevo.Enabled = true;
                    this.tsb_Grabar.Enabled = false;
                    this.tsb_Grabar_Salir.Enabled = false;
                    blnSalir = true;
                    MessageBox.Show("OK: El registro se Incluyo Correctamente");
                }
                else
                {
                    MessageBox.Show("Error: No se pudo Modificar el registro");
                }

            }
            return blnSalir;
        }

   


        private void tsb_Grabar_Salir_Click(object sender, EventArgs e)
        {
            if (this.VerificaIngresoMovimiento())
            {
                if ( this.Grabar_PAC() == true )
                {
                    this.Close();
                }
                
            }
        }


        private void cbo_TipoAdquisicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbo_TipoAdquisicion.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                if (Convert.ToString(this.cbo_TipoAdquisicion.SelectedValue).Trim() == "1")
                {
                    this.cbo_EntidadConvocante.Enabled = true;
                }
                else
                {
                    this.cbo_EntidadConvocante.Enabled = false;
                    if (MyStuff.UsaWCF == true)
                    {
                        MPL = objWCF.Recupera_ParametroLogistica_Codigo("20");
                    }
                    else
                    {
                        this.cbo_EntidadConvocante.SelectedValue = sdl.Recupera_ParametroLogistica_Codigo("20").vValParametroLogistica.Trim();
                    }
                    

                }
            }

        }

        private void TSMI_AgregarRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}
