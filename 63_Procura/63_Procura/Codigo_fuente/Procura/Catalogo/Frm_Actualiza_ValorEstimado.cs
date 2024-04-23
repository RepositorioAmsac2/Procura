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
    public partial class Frm_Actualiza_ValorEstimado : Form
    {
        Model.ProcesoLogistico_Paso MPDP = new Model.ProcesoLogistico_Paso();
        Model.Paso MP = new Model.Paso();
        Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();
        Model.ProcesoLogistico_Paso_Apertura MPDPA = new Model.ProcesoLogistico_Paso_Apertura();
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        Model.ProcesoLogistico_Paso_Cierre MPDPC = new Model.ProcesoLogistico_Paso_Cierre();
        Service.Data sdl = new Service.Data();
        Model.ValorEstimado mec = new Model.ValorEstimado();
        Model.ValorEstimado_Cronograma mvec = new Model.ValorEstimado_Cronograma();
        private WINlogistica.Framework FS = new WINlogistica.Framework();
        private DataSet DS_ValorEstimado = new DataSet();
        private DataSet DS_Proveedor = new DataSet();
        private string strCodEmpresa = "";
        private string strAñoProceso = "";
        private string strNumProcedimiento = "";
        private int intIdValorEstimado = 0;
        public int intNumeroRegistro = 0;

        public int intIdPac_Paso_Cierre = 0;
        public int intIdPac_Paso = 0;
        public DateTime dateFecFinal = DateTime.Today;
        public string strNota = "";
        public bool blnGrabaPaso = false;

        private string strFormulario = "";
        private string strDesPac = "";
        private DateTime dateFecApertura = DateTime.Now;
        private Infragistics.Win.UltraWinGrid.UltraGrid m_Grid;
        private int intIdPasoSiguiente = 0;
        private string strFormularioSiguiente = "";
        private int intIdProcesoLogistico_PasoSiguiente = 0;

        public Frm_Actualiza_ValorEstimado()
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
            intIdPasoSiguiente = iIdPasoSiguiente;
            strFormularioSiguiente = vFormularioSiguiente;
            strCodEmpresa = cCodEmpresa;
            strAñoProceso = cAñoProceso;
            strFormulario = vFormulario;
            strNumProcedimiento = cNumProcedimiento;
            strDesPac = vDesPac;
            intIdPac_Paso = iIdPac_Detalle_Paso;
            dateFecApertura = dFecApertura;
            intIdProcesoLogistico_PasoSiguiente = iIdProcesoLogistico_PasoSiguiente;
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
            this.Cbo_CodTipoImpuesto.CargaDT(sdl.combo_TipoImpuesto().Tables[0]);

            DS_Proveedor = sdl.ayuda_Cotizacion(MyStuff.CodigoEmpresa,
                                                strNumProcedimiento
                                                );

            mec = sdl.recupera_ValorEstimado_Codigo(strCodEmpresa,
                                                     strAñoProceso,
                                                     strNumProcedimiento
                                                    );

           

            this.Txt_CodProveedor.nombreDS = DS_Proveedor;

            this.llenarDatosControlesValorEstimado(mec);



            this.ShowDialog();
        }

        private bool VerificaIngresoValorEstimado()
        {
            bool blnVerifica = true;
            int iTipoMensaje = 0;
            string strMensaje = "";


            if (Convert.ToDateTime(this.Dtp_Cierre.Value) < this.dateFecApertura)
            {
                blnVerifica = false;
                strMensaje = "La Fecha de Inicio tiene que ser mayor o igual a la Fecha de Inicio";
            }

            if (this.Edt_Nota.Value == null)
            {
                blnVerifica = false;
                strMensaje = "Debe Ingresar un comentario en la Nota";
            }

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
            if (Convert.ToDouble(this.Txt_Total.Value) == 0)
            {
                blnVerifica = false;
                strMensaje = "El Importe NO debe estar Vacio";
            }

            //if (Convert.ToDouble(this.txt_TotalCronograma_S.Value) != Convert.ToDouble(this.Txt_Total.Value) )
            //{
            //    blnVerifica = false;
            //    strMensaje = "El Total es diferente al total del cronograma";
            //}


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


        private void llenarDatosControlesValorEstimado(Model.ValorEstimado objValorEstimado)
        {
            intIdValorEstimado = objValorEstimado.iIdValorEstimado;
            this.Txt_CodProveedor.Value = objValorEstimado.cCodProveedor;
            this.VerProveedor(objValorEstimado.cCodProveedor);
            this.cbo_CodTipoMoneda.SelectedValue = objValorEstimado.CcodTipoMoneda;
            if (objValorEstimado.CcodTipoImpuesto.TrimEnd() == "00")
            {
                this.Txt_Impuesto.Value = 0;
                if (objValorEstimado.CcodTipoMoneda.TrimEnd() == "LO")
                {
                    this.Txt_SubTotal.Value = objValorEstimado.FprecioUnitario_Local;
                }
                else
                {
                    this.Txt_SubTotal.Value = objValorEstimado.FprecioUnitario_Extranjero;
                }
            }
            else
            {
                if (objValorEstimado.CcodTipoMoneda.TrimEnd() == "LO")
                {
                    this.Txt_SubTotal.Value = objValorEstimado.FprecioUnitario_Local;
                    this.Txt_Impuesto.Value = objValorEstimado.Fimpuesto_Local;
                }
                else
                {
                    this.Txt_SubTotal.Value = objValorEstimado.FprecioUnitario_Extranjero;
                    this.Txt_Impuesto.Value = objValorEstimado.Fimpuesto_Extranjero;
                }
            }
            this.Txt_Total.Value = Convert.ToDouble(this.Txt_SubTotal.Value) +
                                   Convert.ToDouble(this.Txt_Impuesto.Value);
        }


        private void Grabar_ValorEstimado()
        {
            try
            {
                if (this.VerificaIngresoValorEstimado())
                {
                    blnGrabaPaso = true;

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
                        // Grabar Valor Estimado

                        Model.ValorEstimado MVE = new Model.ValorEstimado();

                        MVE.cCodEmpresa = MyStuff.CodigoEmpresa;
                        MVE.cAñoProceso = strAñoProceso;
                        MVE.cNumProcedimiento = strNumProcedimiento;
                        MVE.cCodProveedor = Convert.ToString(this.Txt_CodProveedor.Value);
                        MVE.CcodTipoMoneda = Convert.ToString(this.cbo_CodTipoMoneda.SelectedValue);
                        MVE.CcodTipoImpuesto = Convert.ToString(this.Cbo_CodTipoImpuesto.SelectedValue);
                        MVE.FtipoCambio = Convert.ToDouble( this.Txt_TipoCambio.Value );
                        if (MVE.CcodTipoImpuesto.TrimEnd() == "00")
                        {
                            if (MVE.CcodTipoMoneda.TrimEnd() == "LO")
                            {
                                MVE.FprecioUnitario_Local = Convert.ToDouble(this.Txt_SubTotal.Value);
                                MVE.FprecioUnitario_Extranjero = 0;
                                MVE.Fimpuesto_Local = 0;
                                MVE.Fimpuesto_Extranjero = 0;
                            }
                            else
                            {
                                MVE.FprecioUnitario_Extranjero = Convert.ToDouble(this.Txt_SubTotal.Value);
                                MVE.FprecioUnitario_Local = 0;
                                MVE.Fimpuesto_Local = 0;
                                MVE.Fimpuesto_Extranjero = 0;
                            }
                        }
                        else
                        {
                            if (MVE.CcodTipoMoneda.TrimEnd() == "LO")
                            {
                                MVE.FprecioUnitario_Local = Convert.ToDouble(this.Txt_SubTotal.Value);
                                MVE.FprecioUnitario_Extranjero = 0;
                                MVE.Fimpuesto_Local = Convert.ToDouble(this.Txt_Impuesto.Value);
                                MVE.Fimpuesto_Extranjero = 0;
                            }
                            else
                            {
                                MVE.FprecioUnitario_Extranjero = Convert.ToDouble(this.Txt_SubTotal.Value);
                                MVE.FprecioUnitario_Local = 0;
                                MVE.Fimpuesto_Local = 0;
                                MVE.Fimpuesto_Extranjero = Convert.ToDouble(this.Txt_Impuesto.Value);
                            }
                        }
                        MVE.dFecEstimacion = Convert.ToDateTime(this.Dtp_Cierre.Value);
                        MVE.tObservacion = Convert.ToString(this.Edt_Nota.Value);

                        sdl.graba_ValorEstimado(MVE);
                        mvec.cCodEmpresa = MVE.cCodEmpresa;
                        mvec.cAñoProceso = MVE.cAñoProceso;
                        mvec.cNumProcedimiento = MVE.cNumProcedimiento;
                        //mvec.Fene_0 = Convert.ToDouble(this.Txt_Ene_0.Value);
                        //mvec.Ffeb_0 = Convert.ToDouble(this.Txt_Feb_0.Value);
                        //mvec.Fmar_0 = Convert.ToDouble(this.Txt_Mar_0.Value);
                        //mvec.Fabr_0 = Convert.ToDouble(this.Txt_Abr_0.Value);
                        //mvec.Fmay_0 = Convert.ToDouble(this.Txt_May_0.Value);
                        //mvec.Fjun_0 = Convert.ToDouble(this.Txt_Jun_0.Value);
                        //mvec.Fjul_0 = Convert.ToDouble(this.Txt_Jul_0.Value);
                        //mvec.Fago_0 = Convert.ToDouble(this.Txt_Ago_0.Value);
                        //mvec.Fset_0 = Convert.ToDouble(this.Txt_Set_0.Value);
                        //mvec.Foct_0 = Convert.ToDouble(this.Txt_Oct_0.Value);
                        //mvec.Fnov_0 = Convert.ToDouble(this.Txt_Nov_0.Value);
                        //mvec.Fdic_0 = Convert.ToDouble(this.Txt_Dic_0.Value);

                        //mvec.Fene_1 = Convert.ToDouble(this.Txt_Ene_1.Value);
                        //mvec.Ffeb_1 = Convert.ToDouble(this.Txt_Feb_1.Value);
                        //mvec.Fmar_1 = Convert.ToDouble(this.Txt_Mar_1.Value);
                        //mvec.Fabr_1 = Convert.ToDouble(this.Txt_Abr_1.Value);
                        //mvec.Fmay_1 = Convert.ToDouble(this.Txt_May_1.Value);
                        //mvec.Fjun_1 = Convert.ToDouble(this.Txt_Jun_1.Value);
                        //mvec.Fjul_1 = Convert.ToDouble(this.Txt_Jul_1.Value);
                        //mvec.Fago_1 = Convert.ToDouble(this.Txt_Ago_1.Value);
                        //mvec.Fset_1 = Convert.ToDouble(this.Txt_Set_1.Value);
                        //mvec.Foct_1 = Convert.ToDouble(this.Txt_Oct_1.Value);
                        //mvec.Fnov_1 = Convert.ToDouble(this.Txt_Nov_1.Value);
                        //mvec.Fdic_1 = Convert.ToDouble(this.Txt_Dic_1.Value);

                        //mvec.Fene_2 = Convert.ToDouble(this.Txt_Ene_2.Value);
                        //mvec.Ffeb_2 = Convert.ToDouble(this.Txt_Feb_2.Value);
                        //mvec.Fmar_2 = Convert.ToDouble(this.Txt_Mar_2.Value);
                        //mvec.Fabr_2 = Convert.ToDouble(this.Txt_Abr_2.Value);
                        //mvec.Fmay_2 = Convert.ToDouble(this.Txt_May_2.Value);
                        //mvec.Fjun_2 = Convert.ToDouble(this.Txt_Jun_2.Value);
                        //mvec.Fjul_2 = Convert.ToDouble(this.Txt_Jul_2.Value);
                        //mvec.Fago_2 = Convert.ToDouble(this.Txt_Ago_2.Value);
                        //mvec.Fset_2 = Convert.ToDouble(this.Txt_Set_2.Value);
                        //mvec.Foct_2 = Convert.ToDouble(this.Txt_Oct_2.Value);
                        //mvec.Fnov_2 = Convert.ToDouble(this.Txt_Nov_2.Value);
                        //mvec.Fdic_2 = Convert.ToDouble(this.Txt_Dic_2.Value);

                        //mvec.Fene_3 = Convert.ToDouble(this.Txt_Ene_3.Value);
                        //mvec.Ffeb_3 = Convert.ToDouble(this.Txt_Feb_3.Value);
                        //mvec.Fmar_3 = Convert.ToDouble(this.Txt_Mar_3.Value);
                        //mvec.Fabr_3 = Convert.ToDouble(this.Txt_Abr_3.Value);
                        //mvec.Fmay_3 = Convert.ToDouble(this.Txt_May_3.Value);
                        //mvec.Fjun_3 = Convert.ToDouble(this.Txt_Jun_3.Value);
                        //mvec.Fjul_3 = Convert.ToDouble(this.Txt_Jul_3.Value);
                        //mvec.Fago_3 = Convert.ToDouble(this.Txt_Ago_3.Value);
                        //mvec.Fset_3 = Convert.ToDouble(this.Txt_Set_3.Value);
                        //mvec.Foct_3 = Convert.ToDouble(this.Txt_Oct_3.Value);
                        //mvec.Fnov_3 = Convert.ToDouble(this.Txt_Nov_3.Value);
                        //mvec.Fdic_3 = Convert.ToDouble(this.Txt_Dic_3.Value);
                        mvec.cCodEstadoValorEstimado_Cronograma = "1";

                        sdl.graba_ValorEstimado_Cronograma(mvec);

                        this.AperturaNuevoPaso();

                        MPDPC.iIdProcesoLogistico_Paso_Cierre = intIdPac_Paso_Cierre;
                        blnGrabaPaso = true;
                        dateFecFinal = Convert.ToDateTime(this.Dtp_Cierre.Value);
                        strNota = Convert.ToString(this.Edt_Nota.Text);
                        //this.Grabar_ValorEstimado();
                        MessageBox.Show("OK: El paso se cerro correctamente");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {

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
                int intIdPac_Apertura = 0;
                if (MyStuff.UsaWCF == true)
                {
                    intIdPac_Apertura = objWCF.Graba_Pac_Paso_Apertura(MPDPA, MPDP);
                }
                else
                {
                    intIdPac_Apertura = sdl.Graba_ProcesoLogistico_Paso_Apertura(MPDPA, MPDP);
                }

                if (intIdPac_Apertura == 0)
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
            plfp.fImporte = Convert.ToDouble( this.Txt_Total.Value);
            plfp.dFecMovimiento = DateTime.Now;
            plfp.cCodEmpleado = MyStuff.CodigoEmpleado;
            plfp.tObservacion = "";
            plfp.cCodEstadoProcesoLogistico_FichaPresupuestal = "1";
            plfp.iIdPaso = intIdPasoSiguiente;

            sdl.graba_ProcesoLogistico_FichaPresupuestal(plfp);
        }

        private void GrabaValorEstimado()
        {
            mec.iIdValorEstimado = intIdValorEstimado;
            mec.cCodEmpresa = strCodEmpresa;
            mec.cAñoProceso = strAñoProceso;
            mec.cNumProcedimiento = strNumProcedimiento;
            mec.cCodProveedor = Convert.ToString(this.Txt_CodProveedor.Value);
            mec.CcodTipoMoneda = Convert.ToString(this.cbo_CodTipoMoneda.SelectedValue);
            mec.dFecEstimacion = Convert.ToDateTime(this.Dtp_Cierre.Value);
            mec.tObservacion = Convert.ToString(this.Edt_Nota.Value);

            //----Enviar el objeto para la grabacion del registro
            if (intIdValorEstimado == 0)
            {
                intIdValorEstimado = sdl.graba_ValorEstimado(mec);
                mec.iIdValorEstimado = intIdValorEstimado;
            }
            else
            {
                Boolean blnResult = false;
                blnResult = sdl.modifica_ValorEstimado(mec);
            }

        }

        private void VerProveedor( string strCodProveedor )
        {
            this.Txt_NomProveedor.Value = FS.TraerDescripcion_DataTable(DS_Proveedor.Tables[0],
                                                                                   0,
                                                                                   1,
                                                                                   Convert.ToString(this.Txt_CodProveedor.Value)
                                                                                  );
        }

        private void VerOtrosdatos(string strCodProveedor)
        {

            this.cbo_CodTipoMoneda.SelectedValue = FS.TraerDescripcion_DataTable(DS_Proveedor.Tables[0],
                                                                                   0,
                                                                                   3,
                                                                                   Convert.ToString(this.Txt_CodProveedor.Value)
                                                                                  );

            if (string.IsNullOrEmpty(strCodProveedor) == false)
            {
                this.Txt_Total.Value = Convert.ToDouble(FS.TraerDescripcion_DataTable(DS_Proveedor.Tables[0],
                                                                                       0,
                                                                                       2,
                                                                                       Convert.ToString(this.Txt_CodProveedor.Value)
                                                                                      )
                                                                );

                this.Txt_SubTotal.Value = Math.Round(Convert.ToDouble(this.Txt_Total.Value) / 1.18, 2);
                this.Txt_Impuesto.Value = Convert.ToDouble( this.Txt_Total.Value ) - 
                                          Convert.ToDouble( this.Txt_SubTotal.Value );

            }

        }

        private void Frm_Actualiza_ValorEstimadoes_Load(object sender, EventArgs e)
        {

        }

        private void Txt_CodProveedor_Leave(object sender, EventArgs e)
        {
            this.VerProveedor( Convert.ToString( this.Txt_CodProveedor.Value));
            this.VerOtrosdatos(Convert.ToString(this.Txt_CodProveedor.Value));
        }

        private void Frm_Actualiza_ValorEstimado_Load(object sender, EventArgs e)
        {

        }

        private void tsb_Grabar_Salir_Click(object sender, EventArgs e)
        {
            this.Grabar_ValorEstimado();
        }

        private void cbo_CodTipoMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region "Cronograma"

        private void SumaCronograma()
        {
            //this.txt_TotalCronograma_S.Value = Convert.ToDouble(this.Txt_Ene_0.Value) +
            //            Convert.ToDouble(this.Txt_Feb_0.Value) +
            //            Convert.ToDouble(this.Txt_Mar_0.Value) +
            //            Convert.ToDouble(this.Txt_Abr_0.Value) +
            //            Convert.ToDouble(this.Txt_May_0.Value) +
            //            Convert.ToDouble(this.Txt_Jun_0.Value) +
            //            Convert.ToDouble(this.Txt_Jul_0.Value) +
            //            Convert.ToDouble(this.Txt_Ago_0.Value) +
            //            Convert.ToDouble(this.Txt_Set_0.Value) +
            //            Convert.ToDouble(this.Txt_Oct_0.Value) +
            //            Convert.ToDouble(this.Txt_Nov_0.Value) +
            //            Convert.ToDouble(this.Txt_Dic_0.Value) +
            //            Convert.ToDouble(this.Txt_Ene_1.Value) +
            //            Convert.ToDouble(this.Txt_Feb_1.Value) +
            //            Convert.ToDouble(this.Txt_Mar_1.Value) +
            //            Convert.ToDouble(this.Txt_Abr_1.Value) +
            //            Convert.ToDouble(this.Txt_May_1.Value) +
            //            Convert.ToDouble(this.Txt_Jun_1.Value) +
            //            Convert.ToDouble(this.Txt_Jul_1.Value) +
            //            Convert.ToDouble(this.Txt_Ago_1.Value) +
            //            Convert.ToDouble(this.Txt_Set_1.Value) +
            //            Convert.ToDouble(this.Txt_Oct_1.Value) +
            //            Convert.ToDouble(this.Txt_Nov_1.Value) +
            //            Convert.ToDouble(this.Txt_Dic_1.Value) +
            //            Convert.ToDouble(this.Txt_Ene_2.Value) +
            //            Convert.ToDouble(this.Txt_Feb_2.Value) +
            //            Convert.ToDouble(this.Txt_Mar_2.Value) +
            //            Convert.ToDouble(this.Txt_Abr_2.Value) +
            //            Convert.ToDouble(this.Txt_May_2.Value) +
            //            Convert.ToDouble(this.Txt_Jun_2.Value) +
            //            Convert.ToDouble(this.Txt_Jul_2.Value) +
            //            Convert.ToDouble(this.Txt_Ago_2.Value) +
            //            Convert.ToDouble(this.Txt_Set_2.Value) +
            //            Convert.ToDouble(this.Txt_Oct_2.Value) +
            //            Convert.ToDouble(this.Txt_Nov_2.Value) +
            //            Convert.ToDouble(this.Txt_Dic_2.Value) +
            //            Convert.ToDouble(this.Txt_Ene_3.Value) +
            //            Convert.ToDouble(this.Txt_Feb_3.Value) +
            //            Convert.ToDouble(this.Txt_Mar_3.Value) +
            //            Convert.ToDouble(this.Txt_Abr_3.Value) +
            //            Convert.ToDouble(this.Txt_May_3.Value) +
            //            Convert.ToDouble(this.Txt_Jun_3.Value) +
            //            Convert.ToDouble(this.Txt_Jul_3.Value) +
            //            Convert.ToDouble(this.Txt_Ago_3.Value) +
            //            Convert.ToDouble(this.Txt_Set_3.Value) +
            //            Convert.ToDouble(this.Txt_Oct_3.Value) +
            //            Convert.ToDouble(this.Txt_Nov_3.Value) +
            //            Convert.ToDouble(this.Txt_Dic_3.Value)
            //            ;
        }
        private void Txt_Ene_0_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Feb_0_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Mar_0_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Abr_0_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_May_0_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Jun_0_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Jul_0_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Ago_0_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Set_0_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Oct_0_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Nov_0_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Dic_0_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }


        private void Txt_Ene_1_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Feb_1_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Mar_1_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Abr_1_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_May_1_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Jun_1_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Jul_1_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Ago_1_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Set_1_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Oct_1_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Nov_1_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Dic_1_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }


        private void Txt_Ene_2_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Feb_2_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Mar_2_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Abr_2_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_May_2_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Jun_2_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Jul_2_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Ago_2_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Set_2_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Oct_2_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Nov_2_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Dic_2_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Ene_3_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Feb_3_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Mar_3_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Abr_3_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_May_3_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Jun_3_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Jul_3_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Ago_3_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Set_3_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Oct_3_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Nov_3_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }

        private void Txt_Dic_3_Leave(object sender, EventArgs e)
        {
            this.SumaCronograma();
        }


        #endregion
    }
}
