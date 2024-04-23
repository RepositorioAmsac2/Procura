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
        Service.Data sdl = new Service.Data();

        private Model.ProcesoLogistico_Cabecera MPC = new Model.ProcesoLogistico_Cabecera();
        private Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();
        private Model.ParametroLogistica MPL = new Model.ParametroLogistica();
        private Model.Centro MC = new Model.Centro();

        private Model.CentroGestor MCG = new Model.CentroGestor();

        private DataSet DS_Centro = new DataSet();
        private DataSet DS_CentroGestor = new DataSet();
        private DataSet DS_ItemsPAC = new DataSet();

        private WINlogistica.Framework FS = new WINlogistica.Framework();
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public bool blnGrabo = false;
        public Frm_Inclusion_Pac()
        {
            InitializeComponent();
        }

        private void Frm_Inclusion_Pac_Load(object sender, EventArgs e)
        {
            if (MyStuff.UsaWCF == true)
            {
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
                    DS_ItemsPAC = sdl.ayuda_Pac_HojaTrabajo(MyStuff.CodigoEmpresa,
                                                                          MyStuff.AñoProceso
                                                                        );

                    this.txt_CodPac.nombreDS = DS_ItemsPAC;

                    this.cbo_ObjetoContratacion.CargaDT(sdl.Combo_ObjetoContratacion(strCodTipoProceso).Tables[0]);

                    this.cbo_UnidadMedida.CargaDT(sdl.Combo_UnidadMedida().Tables[0]);

                    this.cbo_TipoMoneda.CargaDT(sdl.Combo_TipoMoneda().Tables[0]);

                    this.cbo_FuenteFinanciamiento.CargaDT(sdl.Combo_TipoFuenteFinanciamiento().Tables[0]);

                    this.cbo_TipoAdquisicion.CargaDT(sdl.Combo_TipoAdquisicion().Tables[0]);

                    this.cbo_EntidadConvocante.CargaDT(sdl.Combo_EntidadEncargadaConvocante().Tables[0]);

                    MPL = sdl.Recupera_ParametroLogistica_Codigo("20");

                    this.cbo_EntidadConvocante.SelectedValue = MPL.vValParametroLogistica.TrimEnd();

                    this.cbo_ModalidadSeleccion.CargaDT(sdl.Combo_ModalidadSeleccion().Tables[0]);

                    DS_Centro = sdl.Ayuda_Centro();
                    this.Txt_CodCentro.nombreDS = DS_Centro;

                    DS_CentroGestor = sdl.Ayuda_CentroGestor("XX");
                }
                
                this.Txt_CodCentroGestor.nombreDS = DS_CentroGestor;

                this.BlanquearDatos();

                this.txt_CodPac.Focus();

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
                }
                else
                {
                    this.cbo_ObjetoContratacion.CargaDT(sdl.Combo_ObjetoContratacion(strCodTipoProceso).Tables[0]);
                }
                
                this.Txt_NumProcedimiento.Text = "";
                }
        }

        private void BlanquearDatos()
        {

            Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();

            this.txt_CodPac.Value = MPD.cCodProcesoLogistico;
            this.Txt_NumProcedimiento.Text = MPD.cNumProcedimiento;
            this.cbo_TipoProceso.SelectedValue = MPD.cCodTipoProceso;
            this.cbo_ObjetoContratacion.SelectedValue = MPD.cCodObjetoContratacion;
            this.edt_Descripcion.Value = MPD.tDesContratacion;
            this.cbo_UnidadMedida.SelectedValue = MPD.cCodUnidadMedida;
            this.txt_Cantidad.Value = Convert.ToString(MPD.fCantidad);
            this.txt_PrecioEstimado.Value = Convert.ToDecimal( MPD.fPrecioEstimado );
            this.cbo_TipoMoneda.SelectedValue = MPD.cCodTipoMoneda;
            this.cbo_FuenteFinanciamiento.SelectedValue = MPD.cCodTipoFuenteFinanciamiento;
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
                    if (MyStuff.UsaWCF == true)
                    {
                    }
                    else
                    {
                        intIdPac_Deralle = sdl.Recupera_ProcesoLogistico_Detalle_Codigo(this.Txt_NumProcedimiento.Text).iIdProcesoLogistico_Detalle;
                    }
                    

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

                MPD.iIdProcesoLogistico_Cabecera = MPC.iIdProcesoLogistico_Cabecera;
                MPD.cCodTipoProcesoLogistico = "01";
                MPD.cNumeroRelacionado = Convert.ToString(this.txt_CodPac.Value);
                MPD.cCodProcesoLogistico = Convert.ToString(this.txt_CodPac.Value);
                MPD.cNumProcedimiento = Convert.ToString(this.Txt_NumProcedimiento.Text);
                MPD.cCodTipoProceso = Convert.ToString(this.cbo_TipoProceso.SelectedValue);
                MPD.cCodUnidadMedida = Convert.ToString(this.cbo_UnidadMedida.SelectedValue);
                MPD.cCodObjetoContratacion = Convert.ToString(this.cbo_ObjetoContratacion.SelectedValue);
                MPD.tDesContratacion = Convert.ToString(this.edt_Descripcion.Value);
                MPD.fCantidad = Convert.ToInt32(this.txt_Cantidad.Value);
                MPD.fPrecioEstimado = Convert.ToDouble(this.txt_PrecioEstimado.Value);
                MPD.cCodTipoMoneda = Convert.ToString(this.cbo_TipoMoneda.SelectedValue);
                MPD.cCodTipoFuenteFinanciamiento = Convert.ToString(this.cbo_FuenteFinanciamiento.SelectedValue);
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
                if (MyStuff.UsaWCF == true)
                {
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
                    blnGrabo = true;
                    MessageBox.Show("OK: El registro se Incluyo Correctamente");
                }
                else
                {
                    MessageBox.Show("Error: No se pudo incluir el registro");
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

        private void Btn_TipoProcedimientoAutomatico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(  this.cbo_TipoProceso.SelectedValue)) )
            {
                MessageBox.Show("Debe Elegir un Tipo de Proceso");
                return;
            }
            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                string[] Codigo = sdl.HallarTipoProcedimiento_ProcesoLogistico_Detalle(MPC.cAñoProceso,
                                                                        MPC.cVersion,
                                                                        Convert.ToString(this.cbo_TipoProceso.SelectedValue)
                                                                      );
                this.Txt_NumProcedimiento.Text = Codigo[0];
            }
            
            
        }

        private void Txt_CodCentro_Leave(object sender, EventArgs e)
        {
            this.Txt_DesCentro.Value = FS.TraerDescripcion_DataTable(DS_Centro.Tables[0],
                                                                                            0,
                                                                                            1,
                                                                                            Convert.ToString(this.Txt_CodCentro.Value)
                                                                                            );
        }

        private void Txt_CodCentroGestor_Leave(object sender, EventArgs e)
        {
            this.Txt_NomCentroGestor.Value = FS.TraerDescripcion_DataTable(DS_CentroGestor.Tables[0],
                                                                                            0,
                                                                                            1,
                                                                                            Convert.ToString(this.Txt_CodCentroGestor.Value)
                                                                                            );
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
                    }
                    else
                    {
                        MPL = sdl.Recupera_ParametroLogistica_Codigo("20");
                    }
                    this.cbo_EntidadConvocante.SelectedValue = MPL.vValParametroLogistica.Trim();

                }
            }

        }

        private void ultraTabControl1_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {

        }

        private void cbo_ObjetoContratacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_UnidadMedida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_EntidadConvocante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_ModalidadSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_FuenteFinanciamiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.TraerDatosPac();
        }

        private void TraerDatosPac()
        {
            if ( string.IsNullOrEmpty( Convert.ToString( this.Txt_DesPac.Value )) == false )
            {
                string strCodProcesoLofistico = Convert.ToString(this.txt_CodPac.Value);
                Model.Pac_HojaTrabajo MPHT = new Model.Pac_HojaTrabajo();
                MPHT = sdl.recupera_Pac_HojaTrabajo( MyStuff.CodigoEmpresa,
                                                     MyStuff.AñoProceso,
                                                     strCodProcesoLofistico
                                                    );

                this.edt_Descripcion.Value = MPHT.tDesContratacion;
                this.txt_PrecioEstimado.Value = MPHT.fValIncluyeIgv;
                this.cbo_TipoAdquisicion.SelectedValue = MPHT.cCodTipoProceso;
                this.cbo_ObjetoContratacion.SelectedValue = MPHT.cCodObjetoContratacion;
                this.cbo_ModalidadSeleccion.SelectedValue = ""; // MPHT.cCodModalidadSeleccion;
                this.cbo_EntidadConvocante.SelectedValue = ""; // MPHT.cCodEntidadEncargadaConvocante;

                this.Grp_DatosGenerales.Enabled = true;
                this.Grp_OtrosDatos.Enabled = true;
            }
            else
            {
                this.Grp_DatosGenerales.Enabled = false;
                this.Grp_OtrosDatos.Enabled = false;
                MessageBox.Show("Debe ingresar el código del PAC",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation
                                );
            }
        }

        private void txt_CodPac_Leave(object sender, EventArgs e)
        {
            this.Txt_DesPac.Value = FS.TraerDescripcion_DataTable(DS_ItemsPAC.Tables[0],
                                                                                            0,
                                                                                            1,
                                                                                            Convert.ToString(this.txt_CodPac.Value)
                                                                                            );
        }

        private void ultraGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
