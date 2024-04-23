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
    public partial class Frm_Modificacion_Pac : Form
    {
        Service.Data sdl = new Service.Data();
        private Model.ProcesoLogistico_Cabecera MPC = new Model.ProcesoLogistico_Cabecera();
        private Service.Data SPC = new Service.Data();

        private Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();

        private Model.TipoProceso MTP = new Model.TipoProceso();

        private Model.ObjetoContratacion MOC = new Model.ObjetoContratacion();

        private Model.UnidadMedida MUM = new Model.UnidadMedida();

        private Model.TipoMoneda MTM = new Model.TipoMoneda();

        private Model.TipoFuenteFinanciamiento MFF = new Model.TipoFuenteFinanciamiento();

        private Model.TipoAdquisicion MTA = new Model.TipoAdquisicion();

        private Model.EntidadEncargadaConvocante MEEC = new Model.EntidadEncargadaConvocante();

        private Model.ParametroLogistica MPL = new Model.ParametroLogistica();

        private Model.ModalidadSeleccion MMS = new Model.ModalidadSeleccion();

        private Model.Centro MC = new Model.Centro();

        private Model.CentroGestor MCG = new Model.CentroGestor();

        private Model.ProcesoLogistico_Modificado MPDM = new Model.ProcesoLogistico_Modificado();

        private Model.ProcesoLogistico_Eliminado MPDE = new Model.ProcesoLogistico_Eliminado();
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public bool blnGrabo = false;
        public Frm_Modificacion_Pac()
        {
            InitializeComponent();
        }

        public void ShowMe(string strNumProcedimiento)
        {
            if (MyStuff.UsaWCF == true)
            {
                MPC = objWCF.Recupera_Pac_Cabecera_Id();
            }
            else
            {
                MPC = SPC.Recupera_ProcesoLogistico_Cabecera_Id();
            }

            if (MPC.iIdProcesoLogistico_Cabecera != 0)
            {
                this.txt_AñoProceso.Value = MPC.cAñoProceso;
                this.txt_Version.Value = MPC.cVersion;
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

                    this.cbo_UnidadMedida.CargaDT(sdl.Combo_UnidadMedida().Tables[0]);

                    this.cbo_TipoMoneda.CargaDT(sdl.Combo_TipoMoneda().Tables[0]);

                    this.cbo_FuenteFinanciamiento.CargaDT(sdl.Combo_TipoFuenteFinanciamiento().Tables[0]);

                    this.cbo_TipoAdquisicion.CargaDT(sdl.Combo_TipoAdquisicion().Tables[0]);

                    this.cbo_EntidadConvocante.CargaDT(sdl.Combo_EntidadEncargadaConvocante().Tables[0]);

                    this.cbo_EntidadConvocante.SelectedValue = sdl.Recupera_ParametroLogistica_Codigo("20").vValParametroLogistica.TrimEnd();

                    this.cbo_ModalidadSeleccion.CargaDT(sdl.Combo_ModalidadSeleccion().Tables[0]);

                    this.Txt_CodCentro.nombreDS = sdl.Ayuda_Centro();

                    this.Txt_CodCentroGestor.nombreDS = sdl.Ayuda_CentroGestor("XX");
                }
            }

            this.BuscaNumProcedimiento(strNumProcedimiento);

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
                
                }
        }

        private void MostrarDatos( Model.ProcesoLogistico_Detalle obj )
        {

            this.txt_CodPac.Value = obj.cCodProcesoLogistico;
            this.cbo_TipoProceso.SelectedValue = obj.cCodTipoProceso;
            this.cbo_ObjetoContratacion.SelectedValue = obj.cCodObjetoContratacion;
            this.edt_Descripcion.Value = obj.tDesContratacion;
            this.Edt_DesJustificacion.Value = obj.tDesJustificacion;
            this.cbo_UnidadMedida.SelectedValue = obj.cCodUnidadMedida;
            this.txt_Cantidad.Value = Convert.ToString(obj.fCantidad);
            this.txt_PrecioEstimado.Value = Convert.ToDecimal( obj.fPrecioEstimado );
            this.cbo_TipoMoneda.SelectedValue = obj.cCodTipoMoneda;
            this.cbo_FuenteFinanciamiento.SelectedValue = obj.cCodTipoFuenteFinanciamiento;
            this.dtp_FechaPrevista.Value = obj.dFechaPrevista;
            this.cbo_TipoAdquisicion.SelectedValue = obj.cCodTipoAdquisicion;
            this.cbo_EntidadConvocante.SelectedValue = obj.cCodEntidadEncargadaConvocante;
            this.cbo_ModalidadSeleccion.SelectedValue = obj.cCodModalidadSeleccion;
            this.Txt_CodCentro.Value = obj.cCodCentro;
            this.Txt_DesCentro.Value = obj.vNomCentro;
            this.Txt_CodCentroGestor.Value = obj.cCodCentroGestor;
            this.Txt_NomCentroGestor.Value = obj.vNomCentroGestor;
            this.edt_Obervacion.Value = MPD.tObservacion;
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

        private bool Grabar_PAC()
        {
            bool blnSalir = false;

            Frm_Modificacion_Pac_D frm = new Frm_Modificacion_Pac_D();

            frm.ShowMe();
            if (frm.blnGrabar == true)
            {

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
                MPD.tDesJustificacion = Convert.ToString(this.Edt_DesJustificacion.Value);
                MPD.cCodEntidadEncargadaConvocante = Convert.ToString(this.cbo_EntidadConvocante.SelectedValue);
                MPD.cCodMotivoModificacion = frm.strCodMotivoModificacion;
                MPD.dFecModificado = frm.dateFecModificacion;
                MPD.tMotModificado = frm.strNota;
                MPD.cCodEmpleado  = WINlogistica.MyStuff.CodigoEmpleado;
                MPD.cCodTipoDocumento = frm.strCodTipoDocumento;
                MPD.cNumDocumento = frm.strNumDocumento;

                int intIdpac_Detalle = 0;
                if (MyStuff.UsaWCF == true)
                {
                }
                else
                {
                    intIdpac_Detalle = sdl.Modifica_ProcesoLogistico_Detalle(MPD);
                }
                

                if (intIdpac_Detalle != 0)
                {
                   this.tsb_Grabar_Salir.Enabled = false;
                    blnGrabo = true;
                    MessageBox.Show("OK: El registro se Modifico Correctamente");
                    blnSalir = true;
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
            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                MC = sdl.Recupera_Centro_Codigo(strCodCentro);
            }
            
            if (MC.cCodCentro.TrimEnd() != "")
            {
                this.Txt_DesCentro.Value = MC.vNomCentro;
            }
            if (MyStuff.UsaWCF == true)
            {
                this.Txt_CodCentroGestor.nombreDS = objWCF.Ayuda_CentroGestor(strCodCentro);
            }
            else
            {
                this.Txt_CodCentroGestor.nombreDS = sdl.Ayuda_CentroGestor(strCodCentro);
            }
            
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
                if (MyStuff.UsaWCF == true)
                {
                    MCG = objWCF.Recupera_CentroGestor_Codigo(strCodCentroGestor);
                }
                else
                {
                    MCG = sdl.Recupera_CentroGestor_Codigo( MyStuff.CodigoEmpresa, strCodCentroGestor);
                }
                
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
                if( this.Grabar_PAC() == true )
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
                        MPL = sdl.Recupera_ParametroLogistica_Codigo("20");
                    }
                    
                    this.cbo_EntidadConvocante.SelectedValue = MPL.vValParametroLogistica.Trim();
                }
            }
        }

        private void BuscaNumProcedimiento(string strNumProcedimiento)
        {
            this.Txt_NumProcedimiento.Text = strNumProcedimiento;
            this.tsb_Grabar_Salir.Enabled = false;

            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                MPD = sdl.Recupera_ProcesoLogistico_Detalle_Codigo(Convert.ToString(this.Txt_NumProcedimiento.Text));
            }

            if (MPD.iIdProcesoLogistico_Detalle == 0)
            {
                MessageBox.Show("El Tipo de Procedimiento NO Existe");
                return;
            }

            MostrarDatos(MPD);

            //if (MPD.iIdProcesoLogistico_Eliminado != 0)
            //{
            //    if (MyStuff.UsaWCF == true)
            //    {
            //    }
            //    else
            //    {
            //        MPDE = sdl.Recupera_ProcesoLogistico_Eliminado(MPD.iIdProcesoLogistico_Eliminado);
            //    }

            //    MessageBox.Show("Error: El Item ha sido Excluido" + (char)(13) +
            //    "Fecha        : " + Convert.ToString(MPDE.dFecEliminado) + (char)(13) +
            //    "Documento    : " + Convert.ToString(MPDE.vDesTipoDocumento) + (char)(13) +
            //    "Motivo       : " + Convert.ToString(MPDE.vDesTipoMotivo) + (char)(13) +
            //    "Nota         : " + Convert.ToString(MPDE.tMotEliminado) + (char)(13) +
            //    "Excluido  por: " + Convert.ToString(MPDE.vApeEmpleado)
            //           );
            //    this.Close();
            //}
            //else
            //{
            //    if (MPD.iIdProcesoLogistico_Modificado != 0)
            //    {
            //        if (MyStuff.UsaWCF == true)
            //        {
            //        }
            //        else
            //        {
            //            MPDM = sdl.Recupera_ProcesoLogistico_Modificado(MPD.iIdProcesoLogistico_Modificado);
            //        }

            //        MessageBox.Show("Error: El Item ha sido Modificado" + (char)(13) +
            //        "Fecha          : " + Convert.ToString(MPDM.dFecModificado) + (char)(13) +
            //        "Documento      : " + Convert.ToString(MPDM.vDesTipoDocumento) + (char)(13) +
            //        "Motivo         : " + Convert.ToString(MPDM.vDesTipoMotivo) + (char)(13) +
            //        "Nota           : " + Convert.ToString(MPDM.tMotModificado) + (char)(13) +
            //        "Modificado  por: " + Convert.ToString(MPDM.vApeEmpleado)
            //               );
            //        this.Close();
            //    }
            //}

            this.tsb_Grabar_Salir.Enabled = true;
            this.Txt_NumProcedimiento.Enabled = false;
            this.Btn_HallarItemPAC.Text = "Limpiar";
        }
    }
}
