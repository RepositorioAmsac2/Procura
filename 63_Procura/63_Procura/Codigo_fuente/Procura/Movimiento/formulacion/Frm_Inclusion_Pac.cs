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
    public partial class Frm_Inclusion_Pac : Form
    {
        private Model.Pac_Cabecera MPC = new Model.Pac_Cabecera();
        private Service.Pac_Cabecera SPC = new Service.Pac_Cabecera();

        private Model.Pac_Detalle MPD = new Model.Pac_Detalle();
        private Service.Pac_Detalle SPD = new Service.Pac_Detalle();

        private Model.TipoProceso MTP = new Model.TipoProceso();
        private Service.TipoProceso STP = new Service.TipoProceso();

        private Model.ObjetoContratacion MOC = new Model.ObjetoContratacion();
        private Service.ObjetoContratacion SOC = new Service.ObjetoContratacion();

        private Model.UnidadMedida MUM = new Model.UnidadMedida();
        private Service.UnidadMedida SUM = new Service.UnidadMedida();

        private Model.TipoMoneda MTM = new Model.TipoMoneda();
        private Service.TipoMoneda STM = new Service.TipoMoneda();

        private Model.FuenteFinanciamientoPAC MFF = new Model.FuenteFinanciamientoPAC();
        private Service.FuenteFinanciamientoPAC SFF = new Service.FuenteFinanciamientoPAC();

        private Model.TipoAdquisicion MTA = new Model.TipoAdquisicion();
        private Service.TipoAdquisicion STA = new Service.TipoAdquisicion();

        private Model.EntidadEncargadaConvocante MEEC = new Model.EntidadEncargadaConvocante();
        private Service.EntidadEncargadaConvocante SEEC = new Service.EntidadEncargadaConvocante();

        private Model.ParametroLogistica MPL = new Model.ParametroLogistica();
        private Service.ParametroLogistica SPL = new Service.ParametroLogistica();

        private Model.ModalidadSeleccion MMS = new Model.ModalidadSeleccion();
        private Service.ModalidadSeleccion SMS = new Service.ModalidadSeleccion();

        private Model.Centro MC = new Model.Centro();
        private Service.Centro SC = new Service.Centro();

        private Model.CentroGestor MCG = new Model.CentroGestor();
        private Service.CentroGestor SCG = new Service.CentroGestor();


        public Frm_Inclusion_Pac()
        {
            InitializeComponent();
        }

        private void Frm_Inclusion_Pac_Load(object sender, EventArgs e)
        {
            MPC = SPC.Recupera_Pac_Cabecera_Id();
            if (MPC.iIdPac_Cabecera != 0)
            {
                this.txt_AñoProceso.Value = MPC.cAñoProceso;
                this.txt_Version.Value = MPC.cVersion;

                this.tsb_Nuevo.Enabled = false;

                this.cbo_TipoProceso.CargaDT(STP.Combo_TipoProceso());
                String strCodTipoProceso = Convert.ToString(this.cbo_TipoProceso.SelectedValue);

                this.cbo_ObjetoContratacion.CargaDT(SOC.Combo_ObjetoContratacion(strCodTipoProceso));

                this.cbo_UnidadMedida.CargaDT(SUM.Combo_UnidadMedida());

                this.cbo_TipoMoneda.CargaDT(STM.Combo_TipoMoneda());

                this.cbo_FuenteFinanciamiento.CargaDT(SFF.Combo_FuenteFinanciamiento());

                this.cbo_TipoAdquisicion.CargaDT(STA.Combo_TipoAdquisicion());

                this.cbo_EntidadConvocante.CargaDT(SEEC.Combo_EntidadEncargadaConvocante());

                MPL = SPL.Recupera_ParametroLogistica_Codigo("20");

                this.cbo_EntidadConvocante.SelectedValue = MPL.vValParametroLogistica.TrimEnd();

                this.cbo_ModalidadSeleccion.CargaDT(SMS.Combo_ModalidadSeleccion());

                this.Txt_CodCentro.nombreDS = SC.Ayuda_Centro();

                this.Txt_CodCentroGestor.nombreDS  = SCG.Ayuda_CentroGestor("XX");

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
                this.cbo_ObjetoContratacion.CargaDT(SOC.Combo_ObjetoContratacion(strCodTipoProceso));
                this.Txt_NumProcedimiento.Text = "";
                this.txt_CodPac.Value = "";
                }
        }

        private void BlanquearDatos()
        {

            Model.Pac_Detalle MPD = new Model.Pac_Detalle();

            this.txt_CodPac.Value = MPD.cCodPac;
            this.Txt_NumProcedimiento.Text = MPD.cNumProcedimiento;
            this.cbo_TipoProceso.SelectedValue = MPD.cCodTipoProceso;
            this.cbo_ObjetoContratacion.SelectedValue = MPD.cCodObjetoContratacion;
            this.edt_Descripcion.Value = MPD.tDesContratacion;
            this.cbo_UnidadMedida.SelectedValue = MPD.cCodUnidadMedida;
            this.txt_Cantidad.Value = Convert.ToString(MPD.fCantidad);
            this.txt_PrecioEstimado.Value = Convert.ToDecimal( MPD.fPrecioEstimado );
            this.cbo_TipoMoneda.SelectedValue = MPD.cCodTipoMoneda;
            this.cbo_FuenteFinanciamiento.SelectedValue = MPD.cCodFuenteFinanciamiento;
            this.dtp_FechaPrevista.Value = MPD.dFechaPrevista;
            this.cbo_TipoAdquisicion.SelectedValue = MPD.cCodTipoAdquisicion;
            this.cbo_EntidadConvocante.SelectedValue = MPD.cCodEntidadEncargadaConvocante;
            this.cbo_ModalidadSeleccion.SelectedValue = MPD.cCodModalidadSeleccion;
            this.Txt_CodCentro.Value = MPD.cCodCentro;
            this.Txt_DesCentro.Value = MPD.vNomCentro;
            this.Txt_CodCentroGestor.Value = MPD.cCodCentroGestor;
            this.Txt_NomCentroGestor.Value = MPD.vNomCentroGestor;
            this.edt_Obervacion.Value = MPD.tObservacion;
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

                if (String.IsNullOrEmpty(this.Txt_NumProcedimiento.Text))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Número de Procedimiento";
                }
                else
                {
                    int intIdPac_Deralle = 0;
                    Service.Pac_Detalle SPD = new Service.Pac_Detalle();

                    intIdPac_Deralle = SPD.Recupera_Pac_Detalle_Codigo(this.Txt_NumProcedimiento.Text).iIdPac_Detalle;

                    if ( intIdPac_Deralle != 0)
                    {
                        strMensaje = "Ya Existe el Código de PAC";
                    }
                }
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

                if (String.IsNullOrEmpty(Convert.ToString(this.cbo_UnidadMedida.SelectedValue)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe Ingresar la Unidad de Medida";
                }
                if (String.IsNullOrEmpty(Convert.ToString(this.cbo_TipoMoneda.SelectedValue)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Tipo de Moneda";
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
                if (String.IsNullOrEmpty(Convert.ToString(this.Txt_CodCentro.Value)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Centro";
                }
                if (String.IsNullOrEmpty(Convert.ToString(this.Txt_CodCentroGestor.Value)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe Ingresar el centro Gestor";
                }

                if (String.IsNullOrEmpty( Convert.ToString( this.txt_Cantidad.Value ) ) )
                {
                    blnVerifica = false;
                    strMensaje = "La Cantidad NO debe estar Vacia";
                }
                else if ( Convert.ToDecimal( this.txt_Cantidad.Value ) == 0)
                {
                    blnVerifica = false;
                    strMensaje = "La Cantidad NO debe tener valor cero";
                }

                if (String.IsNullOrEmpty( Convert.ToString( this.txt_PrecioEstimado.Value)) )
                {
                    blnVerifica = false;
                    strMensaje = "El Precio Estimado NO debe estar Vacio";
                }
                else if (Convert.ToDecimal( this.txt_PrecioEstimado.Value ) == 0)
                {
                    blnVerifica = false;
                    strMensaje = "El Precio Estimado NO debe tener valor cero";
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
                Model.Pac_Detalle MPD = new Model.Pac_Detalle();

                MPD.iIdPac_Cabecera = MPC.iIdPac_Cabecera;

                MPD.cCodPac = Convert.ToString(this.txt_CodPac.Value);
                MPD.cNumProcedimiento = Convert.ToString(this.Txt_NumProcedimiento.Text);
                MPD.cCodTipoProceso = Convert.ToString(this.cbo_TipoProceso.SelectedValue);
                MPD.cCodUnidadMedida = Convert.ToString(this.cbo_UnidadMedida.SelectedValue);
                MPD.cCodObjetoContratacion = Convert.ToString(this.cbo_ObjetoContratacion.SelectedValue);
                MPD.tDesContratacion = Convert.ToString(this.edt_Descripcion.Value);
                MPD.fCantidad = Convert.ToInt32(this.txt_Cantidad.Value);
                MPD.fPrecioEstimado = Convert.ToDouble(this.txt_PrecioEstimado.Value);
                MPD.cCodTipoMoneda = Convert.ToString(this.cbo_TipoMoneda.SelectedValue);
                MPD.cCodFuenteFinanciamiento = Convert.ToString(this.cbo_FuenteFinanciamiento.SelectedValue);
                MPD.dFechaPrevista = Convert.ToDateTime(this.dtp_FechaPrevista.Value);
                MPD.cCodTipoAdquisicion = Convert.ToString(this.cbo_TipoAdquisicion.SelectedValue);
                MPD.cCodModalidadSeleccion = Convert.ToString(this.cbo_ModalidadSeleccion.SelectedValue);
                MPD.cCodCentro = Convert.ToString(this.Txt_CodCentro.Value);
                MPD.cCodCentroGestor = Convert.ToString(this.Txt_CodCentroGestor.Value);
                MPD.tObservacion = Convert.ToString(this.edt_Obervacion.Value);
                MPD.cCodEntidadEncargadaConvocante = Convert.ToString(this.cbo_EntidadConvocante.SelectedValue);
                MPD.cCodMotivoInserccion = frm.strCodMotivoInserccion;
                MPD.dFecInsertado = frm.dateFecInserccion;
                MPD.tMotInsertado = frm.strNota;
                MPD.cCodEmpleado  = WINlogistica.MyStuff.CodigoEmpleado;
                MPD.cCodTipoDocumento = frm.strCodTipoDocumento;
                MPD.cNumDocumento = frm.strNumDocumento;

                int intIdpac_Detalle = 0;

                intIdpac_Detalle = SPD.Graba_Pac_Detalle(MPD);

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

        private void Txt_CodCentro_Leave(object sender, EventArgs e)
        {
            string strCodCentro = "XX";
            this.Txt_DesCentro.Value = MC.vNomCentro;

            if (!string.IsNullOrEmpty( Convert.ToString( this.Txt_CodCentro.Value)) )
            {
                strCodCentro = Convert.ToString(this.Txt_CodCentro.Value);
            }

            MC = SC.Recupera_Centro_Codigo(strCodCentro);
            if (MC.cCodCentro.TrimEnd() != "")
            {
                this.Txt_DesCentro.Value = MC.vNomCentro;
            }
            this.Txt_CodCentroGestor.nombreDS = SCG.Ayuda_CentroGestor(strCodCentro);
            this.Txt_CodCentroGestor.Value = "";
            this.Txt_NomCentroGestor.Value = "";

        }

        private void Txt_CodCentroGestor_Leave(object sender, EventArgs e)
        {
            string strCodCentroGestor = "";
            this.Txt_NomCentroGestor.Value = "";
            if (!string.IsNullOrEmpty(Convert.ToString(this.Txt_CodCentroGestor.Value)))
            {
                strCodCentroGestor = Convert.ToString(this.Txt_CodCentroGestor.Value);
                MCG = SCG.Recupera_CentroGestor_Codigo(strCodCentroGestor);
                if (MCG.CcodCeGe.TrimEnd() != "")
                {
                    this.Txt_NomCentroGestor.Value = MCG.VnomCeGe;
                }
            }

            

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
                    MPL = SPL.Recupera_ParametroLogistica_Codigo("20");
                    this.cbo_EntidadConvocante.SelectedValue = MPL.vValParametroLogistica.Trim();
                }
            }
        }

        private void Btn_TipoProcedimientoAutomatico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(  this.cbo_TipoProceso.SelectedValue)) )
            {
                MessageBox.Show("Debe Elegir un Tipo de Proceso");
                return;
            }
            string[] Codigo = SPD.hallarTipoProcedimiento_Pac_Detalle(MPC.cAñoProceso,
                                                                        MPC.cVersion,
                                                                        Convert.ToString(this.cbo_TipoProceso.SelectedValue)
                                                                      );
            this.Txt_NumProcedimiento.Text = Codigo[0];
            this.txt_CodPac.Value = Codigo[1];
        }
    }
}
