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
    public partial class Frm_Actualiza_Cotizaciones : Form
    {

        Model.ProcesoLogistico_Paso MPDP = new Model.ProcesoLogistico_Paso();
        Model.Paso MP = new Model.Paso();
        Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();
        Model.ProcesoLogistico_Paso_Apertura MPDPA = new Model.ProcesoLogistico_Paso_Apertura();
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        Model.ProcesoLogistico_Paso_Cierre MPDPC = new Model.ProcesoLogistico_Paso_Cierre();
        Service.Data sdl = new Service.Data();
        Model.Cotizacion mec = new Model.Cotizacion();
        private WINlogistica.Framework FS = new WINlogistica.Framework();
        private DataSet DS_Cotizacion = new DataSet();
        private DataSet DS_Proveedor = new DataSet();
        private string strNumProcedimiento = "";
        private int intIdCotizacion = 0;
        public Boolean blnActualizaCotizacion = false;
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


        public Frm_Actualiza_Cotizaciones()
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

            this.cbo_CodTipoMoneda.CargaDT(sdl.Combo_TipoMoneda().Tables[0]);

            DS_Proveedor = sdl.ayuda_Proveedor_Invitacion(MyStuff.CodigoEmpresa,
                                                          strNumProcedimiento,
                                                          "XX"
                                                          );

            DS_Cotizacion = sdl.lista_Cotizacion(MyStuff.CodigoEmpresa,
                                                 strNumProcedimiento
                                                );
            this.Txt_CodProveedor.nombreDS = DS_Proveedor;
            this.Grd_Cotizacion.DataSource = DS_Cotizacion;

            pintarGrilla();

            if (DS_Cotizacion.Tables[0].Rows.Count > 0)
            {
                intIdCotizacion = Convert.ToInt32(DS_Cotizacion.Tables[0].Rows[0]["iIdCotizacion"]);
                this.verDatosCotizacion(intIdCotizacion);
                AccionBotones(true, false, false, true, false);
            }
            else
            {
                AccionBotones(false, true, false, true, false);
            }

            this.ShowDialog();
        }
       

        private void verDatosCotizacion(int intIdCotizacion)
        {
            mec = sdl.recupera_Cotizacion(intIdCotizacion);
            if (mec.cCodProveedor.Trim() != "")
            {
                intIdCotizacion = mec.iIdCotizacion;
                llenarDatosControlesCotizacion(mec);
                AccionBotones(true, true, true, true, false);
            }
            else
            {
                llenarDatosControlesCotizacion(new Model.Cotizacion());
                AccionBotones(false, true, false, false, false);
            }
        }

        private bool VerificaIngresoCotizacion()
        {
            bool blnVerifica = true;
            int iTipoMensaje = 0;
            string strMensaje = "";

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NomProveedor.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar un proveedor";
            }

            if ( string.IsNullOrEmpty(  Convert.ToString(this.cbo_CodTipoMoneda.SelectedValue) ) )
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar un tipo de moneda";
            }
            if (Convert.ToDouble(this.Txt_Cotizacion.Value) == 0)
            {
                blnVerifica = false;
                strMensaje = "La Cotización  NO debe estar Vacio";
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

        private void llenarDatosControlesCotizacion(Model.Cotizacion objCotizacion)
        {
            this.Txt_CodProveedor.Value = objCotizacion.cCodProveedor;
            this.VerProveedor(objCotizacion.cCodProveedor);
            this.cbo_CodTipoMoneda.SelectedValue = objCotizacion.cCodTipoMoneda;
            this.Txt_Cotizacion.Value = objCotizacion.fImporteCotizacion;
            this.Dtp_FecRecepcion.Value = objCotizacion.dFecRecepcion;
            this.Edt_Observacion.Value = objCotizacion.tObservacion;
        }

        private void Grd_Cotizacion_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            //e.Layout.Override.FilterUIType = FilterUIType.FilterRow;
            //FilterOperatorDefaultValue val1 = FilterOperatorDefaultValue.Contains;
            //Grd_Cotizacion.DisplayLayout.Override.FilterOperatorDefaultValue = val1;


            this.Grd_Cotizacion.DisplayLayout.ScrollStyle = ScrollStyle.Immediate;
            this.Grd_Cotizacion.DisplayLayout.Scrollbars = Scrollbars.Both;
            this.Grd_Cotizacion.DisplayLayout.ColumnScrollbarSmallChange = 100;
            this.Grd_Cotizacion.DisplayLayout.UseScrollWindow = UseScrollWindow.None;
            this.Grd_Cotizacion.DisplayLayout.UseFixedHeaders = true;
            this.Grd_Cotizacion.DisplayLayout.ScrollBarLook.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.BothAtRightBottom;
            this.Grd_Cotizacion.DisplayLayout.ScrollBarLook.Appearance.BackGradientStyle = GradientStyle.Vertical;
        }

        private void pintarGrilla()
        {
            this.Grd_Cotizacion.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_Cotizacion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.Grd_Cotizacion.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default
 
            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Cotizacion.DisplayLayout.Bands)
            {
                foreach (Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn in oBand.Columns)
                {
                    if (oColumn.DataType.ToString() == "System.Double")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "#,###,###,###,###.00";
                    }
                    if (oColumn.DataType.ToString() == "System.Decimal")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "#,###,###,###,###.00";
                    }
                }
            }

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.Grd_Cotizacion.DisplayLayout.Bands[0];
            //oBand0.ColHeadersVisible = false;
            oBand0.Columns[1].Header.Caption = "Código";
            oBand0.Columns[1].Width = 80;
            oBand0.Columns[2].Header.Caption = "Proveedor";
            oBand0.Columns[2].Width = 270;
            oBand0.Columns[4].Header.Caption = "Cotizaciones";
            oBand0.Columns[4].Width = 100;
            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[3].Hidden = true;
            oBand0.Columns[5].Hidden = true;
            oBand0.Columns[6].Hidden = true;
        }

        private void Grd_Cotizacion_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            if (DS_Cotizacion.Tables[0].Rows.Count > 0)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.Grd_Cotizacion.ActiveRow;
                if (oRow.Cells[1].Value != DBNull.Value)
                {
                    AccionBotones(true, false, false, true, false);
                    intIdCotizacion = Convert.ToInt32(oRow.Cells[0].Value);
                    this.verDatosCotizacion(intIdCotizacion);
                }
            }
            else
            {
                intIdCotizacion = 0;
                AccionBotones(false, true, false, false, false);
            }
        }

        private void Grabar_Cotizacion()
        {
            try
            {
                if (this.VerificaIngresoCotizacion())
                {
                    blnActualizaCotizacion = true;

                    mec.iIdCotizacion = intIdCotizacion;
                    mec.cCodEmpresa = MyStuff.CodigoEmpresa;
                    mec.cNumProcedimiento = strNumProcedimiento;
                    mec.cCodProveedor = Convert.ToString(this.Txt_CodProveedor.Value);
                    mec.cCodTipoMoneda = Convert.ToString(this.cbo_CodTipoMoneda.SelectedValue);
                    mec.fImporteCotizacion = Convert.ToDouble(this.Txt_Cotizacion.Value);
                    mec.dFecRecepcion = Convert.ToDateTime(this.Dtp_FecRecepcion.Value);
                    mec.tObservacion = Convert.ToString(this.Edt_Observacion.Value);

                    //----Enviar el objeto para la grabacion del registro
                    if (intIdCotizacion == 0)
                    {
                        intIdCotizacion = sdl.graba_Cotizacion(mec);
                        mec.iIdCotizacion = intIdCotizacion;
                        this.RegistroCotizacion();
                        AccionBotones(true, true, true, true, false);
                    }
                    else
                    {
                        Boolean blnResult = false;
                        blnResult = sdl.modifica_Cotizacion(mec);
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
            this.Grabar_Cotizacion();
        }

        private void PintarDatosRegistro()
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = Grd_Cotizacion.ActiveRow;
            oRow.Cells[0].Value = intIdCotizacion;
            oRow.Cells[1].Value = Convert.ToString(this.Txt_CodProveedor.Value);
            oRow.Cells[2].Value = Convert.ToString(this.Txt_NomProveedor.Value);
            oRow.Cells[4].Value = Convert.ToDouble(this.Txt_Cotizacion.Value);
        }
        private void RegistroCotizacion()
        {
            Grd_Cotizacion.DisplayLayout.Bands[0].AddNew();
            PintarDatosRegistro();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            this.EliminarCotizacion(); 
        }

        private void EliminarCotizacion()
        {
            DialogResult intEliminaRegistro = MessageBox.Show("Desea Eliminar el Registro",
                                                                "Advertencia", MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Exclamation
                                                               );


            if (intEliminaRegistro == DialogResult.Yes)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.Grd_Cotizacion.ActiveRow;

                bool blnResultado = false;
                if (MyStuff.UsaWCF == true)
                {
                }
                else
                {
                    blnResultado = sdl.elimina_Cotizacion(intIdCotizacion);
                }

                if (blnResultado == false)
                {
                    MessageBox.Show("Error: No se pudo eliminar el registro");
                }
                else
                {
                    oRow.Delete(false);

                    if (Grd_Cotizacion.Rows.Count > 0)
                    {
                        oRow = this.Grd_Cotizacion.ActiveRow;
                        if (oRow == null)
                        {
                            oRow = this.Grd_Cotizacion.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First);
                        }
                        intIdCotizacion = Convert.ToInt32(oRow.Cells[0].Value);
                        this.verDatosCotizacion(intIdCotizacion);
                        AccionBotones(true, true, true, true, true);
                    }
                    else
                    {
                        intIdCotizacion = 0;
                        this.llenarDatosControlesCotizacion(new Model.Cotizacion());
                        AccionBotones(false, true, true, false, false);
                    }
                }
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            intIdCotizacion = 0;
            llenarDatosControlesCotizacion(new Model.Cotizacion());
            AccionBotones(false, true, true, false, false);
            this.Txt_CodProveedor.Focus();
        }

        private void Btn_DesHacer_Click(object sender, EventArgs e)
        {
            llenarDatosControlesCotizacion(mec);
            AccionBotones(true, true, true, true, false);
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            //ImprimirContrato()   Falta
        }

        private void VerProveedor( string strCodProveedor )
        {
            this.Txt_NomProveedor.Value = FS.TraerDescripcion_DataTable(DS_Proveedor.Tables[0],
                                                                                   0,
                                                                                   1,
                                                                                   Convert.ToString(this.Txt_CodProveedor.Value)
                                                                                  );
        }

        private void Frm_Actualiza_Cotizaciones_Load(object sender, EventArgs e)
        {

        }

        private void Txt_CodProveedor_Leave(object sender, EventArgs e)
        {
            this.VerProveedor( Convert.ToString( this.Txt_CodProveedor.Value));
        }

        private void Frm_Actualiza_Cotizaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            intNumeroRegistro = Grd_Cotizacion.Rows.Count;
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
            else if (Grd_Cotizacion.Rows.Count == 0)
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
                    MP = sdl.Recupera_Paso(intIdPasoSiguiente
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
    }
}
