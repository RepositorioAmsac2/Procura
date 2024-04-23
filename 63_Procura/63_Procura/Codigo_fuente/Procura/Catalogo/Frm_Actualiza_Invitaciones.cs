using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
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
    public partial class Frm_Actualiza_Invitaciones : Form
    {

        Model.ProcesoLogistico_Paso MPDP = new Model.ProcesoLogistico_Paso();
        Model.Paso MP = new Model.Paso();
        Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();
        Model.ProcesoLogistico_Paso_Apertura MPDPA = new Model.ProcesoLogistico_Paso_Apertura();
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        Model.ProcesoLogistico_Paso_Cierre MPDPC = new Model.ProcesoLogistico_Paso_Cierre();
        Service.Data sdl = new Service.Data();
        Model.Invitacion mec = new Model.Invitacion();
        private WINlogistica.Framework FS = new WINlogistica.Framework();
        private DataSet DS_Invitacion = new DataSet();
        private DataSet DS_Proveedor = new DataSet();
        private string strNumProcedimiento = "";
        private int intIdInvitacion = 0;
        public Boolean blnActualizaInvitacion = false;
        public int intNumeroRegistro = 0;

        public int intIdPac_Paso_Cierre = 0;
        public int intIdPac_Paso = 0;
        public DateTime dateFecFinal = DateTime.Today;
        public string strNota = "";
        public bool blnGrabaPaso = false;

        private string strCodEmpresa = "";
        private string strAñoProceso = "";
        private string strFormulario = "";
        private string strDesPac = "";
        private DateTime dateFecApertura = DateTime.Now;
        private Infragistics.Win.UltraWinGrid.UltraGrid m_Grid;
        private int intIdPasoSiguiente = 0;
        private string strFormularioSiguiente = "";
        private int intIdProcesoLogistico_PasoSiguiente = 0;


        public Frm_Actualiza_Invitaciones()
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

            DS_Proveedor = sdl.ayuda_Proveedor(MyStuff.CodigoEmpresa);

            DS_Invitacion = sdl.lista_Invitacion(MyStuff.CodigoEmpresa,
                                                 strNumProcedimiento,
                                                 "XX"
                                                );
            this.Txt_CodProveedor.nombreDS = DS_Proveedor;
            this.Grd_Invitacion.DataSource = DS_Invitacion;

            pintarGrilla();

            if (DS_Invitacion.Tables[0].Rows.Count > 0)
            {
                intIdInvitacion = Convert.ToInt32(DS_Invitacion.Tables[0].Rows[0]["iIdInvitacion"]);
                this.verDatosInvitacion(intIdInvitacion);
                AccionBotones(true, false, false, true, false);
            }
            else
            {
                AccionBotones(false, true, false, true, false);
            }

            this.ShowDialog();
        }
       

        private void verDatosInvitacion(int intIdInvitacion)
        {
            mec = sdl.recupera_Invitacion(intIdInvitacion);
            if (mec.cCodProveedor.Trim() != "")
            {
                intIdInvitacion = mec.iIdInvitacion;
                llenarDatosControlesInvitacion(mec);
                AccionBotones(true, true, true, true, false);
            }
            else
            {
                llenarDatosControlesInvitacion(new Model.Invitacion());
                AccionBotones(false, true, false, false, false);
            }
        }

        private bool VerificaIngresoInvitacion()
        {
            bool blnVerifica = true;
            int iTipoMensaje = 0;
            string strMensaje = "";

            if (Convert.ToBoolean(this.opt_SiEsProveerdor.Checked) == true)
            {
                if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NomProveedor.Value)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar un proveedor";
                }
            }
            else
            {
                if (string.IsNullOrEmpty(Convert.ToString(this.Txt_RucProveedor.Value)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el RUC del proveedor";
                }

                if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NomProveedor.Value)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar un proveedor";
                }

                if (string.IsNullOrEmpty(Convert.ToString(this.Txt_Email.Value)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Email del proveedor";
                }

            }



            if (blnVerifica == false)
            {
                if (iTipoMensaje == 0)
                {
                    MessageBox.Show(strMensaje, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show(strMensaje, 
                                        "Advertencia", 
                                        MessageBoxButtons.YesNo, 
                                        MessageBoxIcon.Question
                                       ) == DialogResult.Yes
                                       )
                    {
                        blnVerifica = true;
                    }
                }
            }
            return blnVerifica;
        }

        private void AccionBotones(bool blnNuevo,
                            bool blnGrabar,
                            bool blnDesHacer,
                            bool blnEliminar,
                            bool blnListar
                          )
        {
            this.Btn_Nuevo.Enabled = blnNuevo;
            this.Btn_Grabar.Enabled = blnGrabar;
            this.Btn_DesHacer.Enabled = blnDesHacer;
            this.Btn_Eliminar.Enabled = blnEliminar;
            //this.btn_Listar.Enabled = blnListar;
        }

        private void llenarDatosControlesInvitacion(Model.Invitacion objInvitacion)
        {
            this.Txt_CodProveedor.Value = objInvitacion.cCodProveedor;
            this.Txt_RucProveedor.Value = objInvitacion.cRucProveedor;
            this.Txt_NomProveedor.Value = objInvitacion.vNomProveedor;
            this.Txt_Email.Value = objInvitacion.vEmail;
        }

        private void Grd_Invitacion_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            //e.Layout.Override.FilterUIType = FilterUIType.FilterRow;
            //FilterOperatorDefaultValue val1 = FilterOperatorDefaultValue.Contains;
            //Grd_Invitacion.DisplayLayout.Override.FilterOperatorDefaultValue = val1;


            this.Grd_Invitacion.DisplayLayout.ScrollStyle = ScrollStyle.Immediate;
            this.Grd_Invitacion.DisplayLayout.Scrollbars = Scrollbars.Both;
            this.Grd_Invitacion.DisplayLayout.ColumnScrollbarSmallChange = 100;
            this.Grd_Invitacion.DisplayLayout.UseScrollWindow = UseScrollWindow.None;
            this.Grd_Invitacion.DisplayLayout.UseFixedHeaders = true;
            this.Grd_Invitacion.DisplayLayout.ScrollBarLook.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.BothAtRightBottom;
            this.Grd_Invitacion.DisplayLayout.ScrollBarLook.Appearance.BackGradientStyle = GradientStyle.Vertical;
        }

        private void pintarGrilla()
        {
            this.Grd_Invitacion.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_Invitacion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.Grd_Invitacion.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.Grd_Invitacion.DisplayLayout.Bands[0];
            oBand0.Columns[1].Header.Caption = "R.U.C.";
            oBand0.Columns[1].Width = 100;
            oBand0.Columns[2].Header.Caption = "Proveedor";
            oBand0.Columns[2].Width = 300;
            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[3].Hidden = true;
            oBand0.Columns[4].Hidden = true;
            oBand0.Columns[5].Hidden = true;
            oBand0.Columns[6].Hidden = true;
        }

        private void Grd_Invitacion_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            if (DS_Invitacion.Tables[0].Rows.Count > 0)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.Grd_Invitacion.ActiveRow;
                if (oRow.Cells[1].Value != DBNull.Value)
                {
                    AccionBotones(true, false, false, true, false);
                    intIdInvitacion = Convert.ToInt32(oRow.Cells[0].Value);
                    this.verDatosInvitacion(intIdInvitacion);
                }
            }
            else
            {
                intIdInvitacion = 0;
                AccionBotones(false, true, false, false, false);
            }

        }

        private void Grabar_Invitacion()
        {
            try
            {
                if (this.VerificaIngresoInvitacion())
                {
                    blnActualizaInvitacion = true;

                    mec.iIdInvitacion = intIdInvitacion;
                    mec.cCodEmpresa = MyStuff.CodigoEmpresa;
                    mec.cNumProcedimiento = strNumProcedimiento;
                    mec.cCodProveedor = Convert.ToString(this.Txt_CodProveedor.Value);
                    mec.cRucProveedor = Convert.ToString(this.Txt_RucProveedor.Value);
                    mec.vNomProveedor = Convert.ToString(this.Txt_NomProveedor.Value);
                    mec.vEmail = Convert.ToString(this.Txt_Email.Value);
                    mec.dFecInvitacion = DateTime.Now;
                    mec.bEsProveedor = Convert.ToBoolean(this.opt_SiEsProveerdor.Checked);
                    mec.cNumRequerimiento = "";

                    //----Enviar el objeto para la grabacion del registro
                    if (intIdInvitacion == 0)
                    {
                        intIdInvitacion = sdl.graba_Invitacion(mec);
                        mec.iIdInvitacion = intIdInvitacion;
                        this.RegistroInvitacion();
                        AccionBotones(true, true, true, true, false);
                    }
                    else
                    {
                        Boolean blnResult = false;
                        blnResult = sdl.modifica_Invitacion(mec);
                        this.PintarDatosRegistro();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Btn_Grabar_Click(object sender, EventArgs e)
        {
            this.Grabar_Invitacion();
        }

        private void PintarDatosRegistro()
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = Grd_Invitacion.ActiveRow;
            oRow.Cells[0].Value = intIdInvitacion;
            oRow.Cells[1].Value = Convert.ToString(this.Txt_RucProveedor.Value);
            oRow.Cells[2].Value = Convert.ToString(this.Txt_NomProveedor.Value);
            oRow.Cells[3].Value = Convert.ToString(this.Txt_Email.Value);
            oRow.Cells[4].Value = Convert.ToDateTime(this.Dtp_Cierre.Value);
            oRow.Cells[5].Value = Convert.ToString(this.Txt_CodProveedor.Value);
            if (Convert.ToBoolean(this.opt_NoEsProveerdor.Checked) == true)
            {
                oRow.Cells[6].Value = true;
            }
            else
            {
                oRow.Cells[6].Value = false;
            }

        }
        private void RegistroInvitacion()
        {
            Grd_Invitacion.DisplayLayout.Bands[0].AddNew();
            PintarDatosRegistro();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            this.EliminarInvitacion(); 
        }

        private void EliminarInvitacion()
        {
            DialogResult intEliminaRegistro = MessageBox.Show("Desea Eliminar el Registro",
                                                                "Advertencia", MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Exclamation
                                                               );


            if (intEliminaRegistro == DialogResult.Yes)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.Grd_Invitacion.ActiveRow;

                bool blnResultado = false;
                if (MyStuff.UsaWCF == true)
                {
                }
                else
                {
                    blnResultado = sdl.elimina_Invitacion(intIdInvitacion);
                }

                if (blnResultado == false)
                {
                    MessageBox.Show("Error: No se pudo eliminar el registro");
                }
                else
                {
                    oRow.Delete(false);

                    if (Grd_Invitacion.Rows.Count > 0)
                    {
                        oRow = this.Grd_Invitacion.ActiveRow;
                        if (oRow == null)
                        {
                            oRow = this.Grd_Invitacion.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First);
                        }
                        intIdInvitacion = Convert.ToInt32(oRow.Cells[0].Value);
                        this.verDatosInvitacion(intIdInvitacion);
                        AccionBotones(true, true, true, true, true);
                    }
                    else
                    {
                        intIdInvitacion = 0;
                        this.llenarDatosControlesInvitacion(new Model.Invitacion());
                        AccionBotones(false, true, true, false, false);
                    }
                }
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            intIdInvitacion = 0;
            llenarDatosControlesInvitacion(new Model.Invitacion());
            AccionBotones(false, true, true, false, false);
            this.Txt_CodProveedor.Focus();
        }

        private void Btn_DesHacer_Click(object sender, EventArgs e)
        {
            llenarDatosControlesInvitacion(mec);
            AccionBotones(true, true, true, true, false);
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            //ImprimirContrato()   Falta
        }

        private void VerProveedor( string strCodProveedor )
        {
            Model.Proveedor MP = new Model.Proveedor();
            MP = sdl.recupera_Proveedor_Codigo(MyStuff.CodigoEmpresa,
                                                strCodProveedor
                                                );
            this.Txt_RucProveedor.Value = MP.cNumDocumentoIdentidad;
            this.Txt_NomProveedor.Value = MP.vRazonSocial;
            this.Txt_Email.Value = MP.vEmail;
        }
        private void Txt_CodProveedor_Leave(object sender, EventArgs e)
        {
            this.VerProveedor( Convert.ToString( this.Txt_CodProveedor.Value));
        }

        private void tsb_Grabar_Salir_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(this.Dtp_Cierre.Value) < this.dateFecApertura)
            {
                MessageBox.Show("La Fecha de Inicio tiene que ser mayor o igual a la Fecha de Inicio");
            }
            else if (this.Edt_Nota.Value == null)
            {
                MessageBox.Show("Debe Ingresar un comentario en la Nota");
            }
            else if (Grd_Invitacion.Rows.Count == 0)
                MessageBox.Show("Debe ingrear al menos un proveedor");
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
                MPDP.dFecInicio = Convert.ToDateTime(dateFecInicio_Value);
                MPDP.dFecFinal = Convert.ToDateTime(dateFecFinal_Value);

                MPDPA.cCodEmpleado = MyStuff.CodigoEmpleado;
                MPDPA.cCodTipoAperturaPaso = "1";
                MPDPA.dFecApertura = Convert.ToDateTime(this.Dtp_Cierre.Value);
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

        private void opt_SiEsProveerdor_CheckedChanged(object sender, EventArgs e)
        {
            this.SemaforoCodigoProveedor(true);
        }

        private void Frm_Actualiza_Invitaciones_Load(object sender, EventArgs e)
        {

        }

        private void opt_NoEsProveerdor_CheckedChanged(object sender, EventArgs e)
        {
            this.SemaforoCodigoProveedor(false);
        }

        private void SemaforoCodigoProveedor (bool blnEsProveedor)
        {
            this.Lbl_CodProveedor.Visible = blnEsProveedor;
            this.Txt_CodProveedor.Visible = blnEsProveedor;

            if (blnEsProveedor == true)
            {
                this.Txt_RucProveedor.Enabled = false;
                this.Txt_NomProveedor.Enabled = false;
                this.Txt_Email.Enabled = false;
                this.Txt_CodProveedor.Focus();
            }
            else
            {
                this.Txt_RucProveedor.Enabled = true;
                this.Txt_NomProveedor.Enabled = true;
                this.Txt_Email.Enabled = true;
                this.Txt_RucProveedor.Focus();
            }
            
        }

    }
}
