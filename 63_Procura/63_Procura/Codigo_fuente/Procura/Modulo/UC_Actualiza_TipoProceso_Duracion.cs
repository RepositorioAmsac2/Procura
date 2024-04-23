using DevExpress.Spreadsheet;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraSpreadsheet;
using DevExpress.XtraSpreadsheet.Commands;
using DevExpress.XtraSpreadsheet.Menu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WINlogistica.Modulo
{
    public partial class UC_Actualiza_TipoProceso_Duracion : DevExpress.XtraEditors.XtraUserControl
    {
        IWorkbook workbook;
        private Service.Data objDATA = new Service.Data();

        private DataSet DS_Formulacion;
        Model.TipoProceso MTP = new Model.TipoProceso();

        DataView DV_Detalle_0;
        DataView DV_Detalle_1;
        private static DataTable tblResumen;
        string strPeriodoProceso = MyStuff.AñoProceso;
        string strCodTipoProceso = "1";
        string strDesTipoProceso = "";
        string strCodObjetoContratacion = "5";
        string strDesObjetoContratacion = "";

        int intLineaInicial = 8;
        int intTotalLineas = 50;
        int intIdDetalle = 0;
        int intTotalLineasrescatadas = 0;
        int intTotalLineasEliminaas = 0;
        const int intIDprincialDETALLE = 8;
        const int intCeldaAyudaEtapa = 1;

        string[] strColumna = { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z",
                                "AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AP","AQ","AR","AS","AT","AU","AV","AW","AX","AY","AZ",
                                "BA","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BO","BP","BQ","BR","BS","BT","BU","BV","BW","BX","BY","BZ",
                                "CA","CB","CC","CD","CE","CF","CG","CH","CI","CJ","CK","CL","CM","CN","CO","CP","CQ","CR","CS","CT","CU","CV","CW","CX","CY","CZ"
                              };


        private static UC_Actualiza_TipoProceso_Duracion _instance;
        public static UC_Actualiza_TipoProceso_Duracion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Actualiza_TipoProceso_Duracion();
                return _instance;
            }
        }


        public UC_Actualiza_TipoProceso_Duracion()
        {
            InitializeComponent();
            this.Inicio();
        }

        #region Inicio
        private void Inicio()
        {
            Model.ParametroFormulacion MPF = new Model.ParametroFormulacion();
            if (MyStuff.UsaWCF)
            {
                //MPF = objWCF.Recupera_ParametroFormulacion_Codigo(MyStuff.CodigoEmpresa, "103");
            }
                
            else
                MPF = objDATA.Recupera_ParametroFormulacion_Codigo(MyStuff.CodigoEmpresa, "103");
            if (string.IsNullOrEmpty(MPF.vValParametro) == false)
            {
                intTotalLineas = Convert.ToInt32(MPF.vValParametro);
            }
        }
        #endregion

        #region Nuevo
        

        private void MostrarFiltro(Boolean blnSalir)
        {
            WINlogistica.Frm_Actualiza_TipoProceso_Duracion_Filtro frm = new WINlogistica.Frm_Actualiza_TipoProceso_Duracion_Filtro();
            frm.ShowMe(strCodTipoProceso,
                        strDesTipoProceso,
                        strCodObjetoContratacion,
                        strDesObjetoContratacion
                      );

            if (frm.blnProcesaExcel == true)
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                SplashScreenManager.Default.SetWaitFormDescription("Recopilando informaciòn...");

                //Habilita Opciones

                this.strPeriodoProceso = frm.strPeriodoProceso;
                this.strCodTipoProceso = frm.strCodTipoProceso;
                this.strDesTipoProceso = frm.strDesTipoProceso;
                this.strCodObjetoContratacion = frm.strCodObjetoContratacion;
                this.strDesObjetoContratacion = frm.strDesObjetoContratacion;

                //this.Btn_DistribuyeLineaFormulada.Enabled = true;
                this.Btn_Guardar.Enabled = true;
                this.Btn_Imprimir.Enabled = true;
                //this.Btn_EliminarFilas.Enabled = true;
                this.Btn_Agrupacion.Enabled = true;
                this.Btn_Etapa.Enabled = true;

                //Traer Dato de la tabla




                //-- Recuperar Datos
                if (MyStuff.UsaWCF == true)
                {
                    //jesus
                }
                else
                {
                    MTP = objDATA.Recupera_TipoProceso_Codigo(strCodTipoProceso);

                    DS_Formulacion = objDATA.Reporte_TipoProceso_Duracion(strPeriodoProceso,
                                                                        strCodTipoProceso,
                                                                        strCodObjetoContratacion
                                                                            );
                }

                workbook = spreadsheetControl.Document;
                string sRutaInterna = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Excel\Formato_TipoProceso_Duracion.xlsx");
                workbook.LoadDocument(sRutaInterna, DocumentFormat.Xlsx);

                this.Btn_LibroExcel.Caption = "Formato_TipoProceso_Duracion.xlsx";

                Worksheet worksheet_HojaTrabajo = workbook.Worksheets[0];
                Worksheet worksheet_HojaTrabajo_ID = workbook.Worksheets[1];
                // Pintar los titulos
                worksheet_HojaTrabajo.Cells[2, 2].Value = strPeriodoProceso.TrimEnd();
                worksheet_HojaTrabajo.Cells[3, 2].Value = strDesTipoProceso;
                worksheet_HojaTrabajo.Cells[4, 2].Value = strDesObjetoContratacion;

                // Pintar los datos en la hoja de excel
                DV_Detalle_0 = DS_Formulacion.Tables[0].DefaultView;
                DV_Detalle_1 = DS_Formulacion.Tables[1].DefaultView;

                if (DS_Formulacion.Tables[1].Rows.Count > 1)
                    intIdDetalle = Convert.ToInt32(DS_Formulacion.Tables[1].Rows[0][0]);
                else
                    intIdDetalle = 0;

                worksheet_HojaTrabajo.DataBindings.BindToDataSource(DV_Detalle_0, intLineaInicial - 1, 0);
                worksheet_HojaTrabajo_ID.DataBindings.BindToDataSource(DV_Detalle_1, intLineaInicial - 1, intIDprincialDETALLE);


                CellRange boundrange_HojaTrabajo = worksheet_HojaTrabajo.DataBindings[0].Range;
                this.colocarIconoHoja(intLineaInicial, boundrange_HojaTrabajo.BottomRowIndex + 1, 0);

                intTotalLineasrescatadas = boundrange_HojaTrabajo.RowCount;
                this.SSL_mensajeDinamico.Text = "Total de lineas rescatadas: " + intTotalLineasrescatadas.ToString();
                // Formatear con datos numericos parte de la hoja para el ingreso de datos

                spreadsheetControl.RemoveShortcutKey(Keys.Delete, Keys.Control);

                SplashScreenManager.CloseForm();

                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                SplashScreenManager.Default.SetWaitFormDescription("Formateando formulas...");
                this.FormatearColumnas(intTotalLineasrescatadas + 1);
                SplashScreenManager.CloseForm();
            }
            else
            {
                //if (blnSalir == true)
                //this.Close();
            }
        }

        #endregion

        #region ColocaIconos
        private void colocarIconoHoja(int intLineaInicialF,
                                      int intLineaFinal,
                                      int intColumna
                                     )
        {
            string strRango = "";

            if (intColumna == 0)
                strRango = "A" + Convert.ToString(intLineaInicialF) + ":A" + Convert.ToString(intLineaFinal);
            else
                strRango = "B" + Convert.ToString(intLineaInicialF) + ":B" + Convert.ToString(intLineaFinal);

            Worksheet worksheet_HojaTrabajo = workbook.Worksheets[0];
            ConditionalFormattingCollection conditionalFormattings = worksheet_HojaTrabajo.ConditionalFormattings;
            ConditionalFormattingIconSetValue xxSQL = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "0", ConditionalFormattingValueOperator.GreaterOrEqual);
            ConditionalFormattingIconSetValue siSQL = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "1", ConditionalFormattingValueOperator.GreaterOrEqual);
            ConditionalFormattingIconSetValue noSQL = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "2", ConditionalFormattingValueOperator.GreaterOrEqual);
            IconSetConditionalFormatting cfRule = conditionalFormattings.AddIconSetConditionalFormatting(worksheet_HojaTrabajo.Range[strRango],
                                                  IconSetType.TrafficLights13, new ConditionalFormattingIconSetValue[] { xxSQL, siSQL, noSQL });
        }

        private void colocarIcono(int intLineaFinal, int intColumna)
        {

            string strRango = "";

            if (intColumna == 0)
                strRango = "A" + Convert.ToString(intLineaFinal) + ":A" + Convert.ToString(intLineaFinal);
            else
                strRango = "B" + Convert.ToString(intLineaFinal) + ":B" + Convert.ToString(intLineaFinal);

            Worksheet worksheet_HojaTrabajo = workbook.Worksheets[0];
            ConditionalFormattingCollection conditionalFormattings = worksheet_HojaTrabajo.ConditionalFormattings;
            ConditionalFormattingIconSetValue xxSQL = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "0", ConditionalFormattingValueOperator.GreaterOrEqual);
            ConditionalFormattingIconSetValue siSQL = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "1", ConditionalFormattingValueOperator.GreaterOrEqual);
            ConditionalFormattingIconSetValue noSQL = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "-1", ConditionalFormattingValueOperator.GreaterOrEqual);
            IconSetConditionalFormatting cfRule = conditionalFormattings.AddIconSetConditionalFormatting(worksheet_HojaTrabajo.Range[strRango],
                                                  IconSetType.TrafficLights13, new ConditionalFormattingIconSetValue[] { xxSQL, siSQL, noSQL });
        }

        private void colocarIconoFalso(int intLineaFinal, int intColumna)
        {
            string strRango = "";

            if (intColumna == 0)
                strRango = "A" + Convert.ToString(intLineaFinal) + ":A" + Convert.ToString(intLineaFinal);
            else
                strRango = "B" + Convert.ToString(intLineaFinal) + ":B" + Convert.ToString(intLineaFinal);

            Worksheet worksheet_HojaTrabajo = workbook.Worksheets[0];
            ConditionalFormattingCollection conditionalFormattings = worksheet_HojaTrabajo.ConditionalFormattings;
            ConditionalFormattingIconSetValue xxSQL = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "1", ConditionalFormattingValueOperator.GreaterOrEqual);
            ConditionalFormattingIconSetValue siSQL = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "2", ConditionalFormattingValueOperator.GreaterOrEqual);
            ConditionalFormattingIconSetValue noSQL = conditionalFormattings.CreateIconSetValue(ConditionalFormattingValueType.Number, "3", ConditionalFormattingValueOperator.GreaterOrEqual);
            IconSetConditionalFormatting cfRule = conditionalFormattings.AddIconSetConditionalFormatting(worksheet_HojaTrabajo.Range[strRango],
                                                  IconSetType.TrafficLights13, new ConditionalFormattingIconSetValue[] { xxSQL, siSQL, noSQL });
        }

        #endregion

        #region FormateoColumnas
        private void FormatearColumnas(int FinalLineas)
        {

            //Worksheet worksheet_HojaTrabajo = workbook.Worksheets[0];

            //worksheet_HojaTrabajo["T10:U205"].NumberFormat = "[Black]#,##0.00;";
            //worksheet_HojaTrabajo["W10:AH205"].NumberFormat = "[Black]#,##0.00;";
            //worksheet_HojaTrabajo["AJ10:AL205"].NumberFormat = "[Black]#,##0.00;";

            //DataValidation validation_worksheet_Importe =
            //        worksheet_HojaTrabajo.DataValidations.Add(worksheet_HojaTrabajo["T10:AL500"],
            //                                                    DataValidationType.Custom, "=AND( T10 >= 0, ISNUMBER(T10))"
            //                                                 );


            //validation_worksheet_Importe.ErrorTitle = "Advertencia";
            //validation_worksheet_Importe.ErrorMessage = "El Dato ingresado no es correcto";
            //validation_worksheet_Importe.ShowErrorMessage = true;

            //Inmovilizar filas y columnas


        }

        #endregion

        #region Grabar
        private void Btn_Guardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
            SplashScreenManager.Default.SetWaitFormDescription("Grabando información...");
            Worksheet worksheet_HojaTrabajo = workbook.Worksheets[0];
            Worksheet worksheet_HojaTrabajo_ID = workbook.Worksheets[1];
            Model.TipoProceso_Duracion MTPD = new Model.TipoProceso_Duracion();
            int _Rows = intLineaInicial - 1;

            int[] intColumnas_NC = { 3, 4, 5, 7 };
            int[] intColumnas_SC = { 2, 6 };
            int intVacio = 0;

            while (true)
            {
                try
                {
                    if (string.IsNullOrEmpty(worksheet_HojaTrabajo.Cells[_Rows, 1].Value.TextValue))
                    {
                        if (intVacio == 2)
                            break;
                        else
                            intVacio++;

                    }    
                    else
                    {
                        Boolean blnValidaColumnaString = false;
                        Boolean blnValidaColumnaNumeric = false;

                        blnValidaColumnaString = ValidaColumnaCaracter(_Rows, intColumnas_SC);
                        blnValidaColumnaNumeric = ValidaColumnaNumerico(_Rows, intColumnas_NC);

                        var intIdItem = Convert.ToInt32(worksheet_HojaTrabajo_ID.Cells[_Rows, intIDprincialDETALLE].Value.NumericValue);

                        if (blnValidaColumnaString == false && blnValidaColumnaNumeric == false)
                        {
                            MTPD.iIdTipoProceso_Duracion = intIdItem;
                            MTPD.cCodTipoProceso = this.strCodTipoProceso;
                            MTPD.cCodObjetoContratacion = this.strCodObjetoContratacion;
                            MTPD.cAñoProceso = this.strPeriodoProceso;
                            MTPD.iIdPaso = Convert.ToInt32(worksheet_HojaTrabajo.Cells[_Rows, 3].Value.NumericValue);
                            MTPD.iDuracion = Convert.ToInt32(worksheet_HojaTrabajo.Cells[_Rows, 4].Value.NumericValue);
                            MTPD.iDiaEmail = Convert.ToInt32(worksheet_HojaTrabajo.Cells[_Rows, 5].Value.NumericValue);
                            MTPD.cCodEstadoDuracionPaso = "1";

                            if (Convert.ToString(worksheet_HojaTrabajo.Cells[_Rows, 6].Value.TextValue).TrimStart().TrimEnd() == "H")
                            {
                                MTPD.iTipoDuracion = 1;
                            }
                            else
                            {
                                MTPD.iTipoDuracion = 2;
                            }

                            MTPD.iOrden = Convert.ToInt32(worksheet_HojaTrabajo.Cells[_Rows, 7].Value.NumericValue);

                            int[] intResult = new int[2];
                            if (intIdItem == 0)
                            {
                                //Grabar Detalle
                                MTPD.iIdTipoProceso_Duracion = 0;
                                if (MyStuff.UsaWCF == true)
                                {
                                    //intIdItem = objWCF.GrabaHojaTrabajo_Configuracion(MHTD);
                                }
                                else
                                    intResult = objDATA.Graba_TipoProceso_Duracion(MTPD);

                                MTPD.iIdTipoProceso_Duracion = intIdItem;
                                worksheet_HojaTrabajo.Cells[_Rows, 0].Value = 1;
                                worksheet_HojaTrabajo_ID.Cells[_Rows, intIDprincialDETALLE].Value = MTPD.iIdTipoProceso_Duracion;
                                colocarIcono(_Rows + 1, 0);
                            }
                            else
                            {
                                MTPD.iIdTipoProceso_Duracion = intIdItem;
                                if (MyStuff.UsaWCF)
                                {
                                    //intIdItem = objWCF.ModificaHojaTrabajo_Configuracion(MHTD);
                                }
                                else
                                    intIdItem = objDATA.Modifica_TipoProceso_Duracion(MTPD);

                                worksheet_HojaTrabajo.Cells[_Rows, 0].Value = 1;
                                colocarIcono(_Rows + 1, 0);
                            }
                        }
                        else
                        {
                            worksheet_HojaTrabajo.Cells[_Rows, 0].Value = 1;
                            colocarIconoFalso(_Rows + 1, 0);
                        }
                    }
                    


                    _Rows++;
                }
                catch (Exception)
                {
                    intVacio++;
                }
            }
            SplashScreenManager.CloseForm();

        }

        private void pintarError(int intFila, int intColumna, Boolean blnError)
        {
            string Rango = strColumna[intColumna] + Convert.ToString(intFila);
            Worksheet worksheet_HojaTrabajo = workbook.Worksheets[0];
            CellRange range = worksheet_HojaTrabajo.Range[Rango];
            Formatting rangeFormatting = range.BeginUpdateFormatting();
            if (blnError == true)
            {
                rangeFormatting.Fill.BackgroundColor = Color.Yellow;
            }
            else
            {
                rangeFormatting.Fill.BackgroundColor = Color.White;
            }
            range.EndUpdateFormatting(rangeFormatting);
        }


        private Boolean ValidaColumnaCaracter(int Linea, int[] intColumnas)
        {
            Boolean blnFilaErrada = false;
            Worksheet hoja = workbook.Worksheets[0];
            foreach (int i in intColumnas)
            {
                if (hoja.Cells[Linea, i].Value.TextValue == null)
                {
                    blnFilaErrada = true;
                    this.pintarError(Linea + 1, i, true);
                }
                else
                {
                    if (string.IsNullOrEmpty(Convert.ToString(hoja.Cells[Linea, i].Value.TextValue).TrimEnd()))
                    {
                        blnFilaErrada = true;
                        this.pintarError(Linea + 1, i, true);
                    }
                    else
                    {
                        this.pintarError(Linea + 1, i, false);
                    }
                }
            }
            return blnFilaErrada;
        }

        private Boolean ValidaColumnaNumerico(int Linea, int[] intColumnas)
        {
            Boolean blnFilaErrada = false;
            Worksheet hoja = workbook.Worksheets[0];
            foreach (int i in intColumnas)
            {
                if (hoja.Cells[Linea, i].Value.NumericValue == 0)
                {
                    blnFilaErrada = true;
                    this.pintarError(Linea + 1, i, true);
                }
                else
                {
                    if (Convert.ToInt32(hoja.Cells[Linea, i].Value.NumericValue ) == 0)
                    {
                        blnFilaErrada = true;
                        this.pintarError(Linea + 1, i, true);
                    }
                    else
                    {
                        this.pintarError(Linea + 1, i, false);
                    }
                }
            }
            return blnFilaErrada;
        }


        #endregion

        #region Imprimir
        private void Btn_Imprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SpreadsheetControl spreadsheet = new SpreadsheetControl();
            spreadsheet.Document.Worksheets[0].CopyFrom(spreadsheetControl.ActiveWorksheet);
            spreadsheet.SaveDocumentAs();
        }
        #endregion

        #region "EliminarFilas"
        private List<int> ObtenerFilasMarcadas(string strRangoMarcado)
        {

            string strRango = strRangoMarcado;



            int index1 = strRango.IndexOf("worksheet");
            if (index1 > 0)
            {
                strRango = strRango.Substring(0, index1).TrimEnd();
            }

            strRango = strRango.Replace("Range:", "");
            strRango = strRango.Replace(",", "");
            strRango = strRango.Replace(";", "");
            strRango = strRango.Replace("\"", "").TrimStart() + ":";




            int intLongitud = strRango.TrimEnd().Length;
            List<int> elementos = new List<int>();
            List<int> elementos01 = new List<int>();
            List<int> elementos02 = new List<int>();

            string strCaracter;
            string strFila = "";
            string strFilaAnterior = "";
            int i = 0;

            while (i < intLongitud)
            {
                strCaracter = strRango.Substring(i, 1).TrimEnd();
                if (strCaracter != "$" && strCaracter != ":")
                {
                    strFila = strFila + strRango.Substring(i, 1);
                }

                if ((strCaracter == "$" || strCaracter == ":") && strFila.TrimEnd().Length > 0)
                {
                    if (strFila.TrimEnd() != strFilaAnterior.TrimEnd())
                    {
                        strFilaAnterior = strFila;
                        elementos01.Add(Convert.ToInt32(strFila));
                    }
                    strFila = "";
                }

                i++;

            }

            if (strRango.Length == 6 && elementos01.Count == 2)
            {
                int inicio = elementos01[0];
                int fin = elementos01[1];

                while (inicio <= fin)
                {
                    elementos02.Add(Convert.ToInt32(inicio));
                    inicio++;
                }
            }

            if (elementos02.Count > 0)
            {
                elementos = elementos02;
            }
            else
            {
                elementos = elementos01;
            }

            return elementos;
        }

        private void EliminarFilas(List<int> elementos)
        {
            workbook = spreadsheetControl.Document;
            Worksheet worksheet_HojaTrabajo = workbook.Worksheets[0];
            Worksheet worksheet_HojaTrabajo_ID = workbook.Worksheets[1];
            int intNumeroElementos = elementos.Count;

            //List<CellRange> r = new List<CellRange>();


            int intIdItem = 0;
            for (int i = 0; i < intNumeroElementos; i++)
            {
                int LineaActual = elementos[i] - 1;
                intTotalLineasEliminaas++;

                this.SSL_mensajeDinamico.Text = "Total de lineas eliminadas: " + (i + 1).ToString();

                intIdItem = Convert.ToInt32(worksheet_HojaTrabajo_ID.Cells[elementos[i] - 1, intIDprincialDETALLE].Value.NumericValue);


                if (intIdDetalle > 0)
                {
                    Boolean blnResult = false;
                    if (MyStuff.UsaWCF == true)
                    {
                        //blnResult = objWCF.EliminaHojaTrabajo_Configuracion(intIdDetalle);
                    }
                    else
                    {
                        blnResult = objDATA.EliminaHojaTrabajo_Configuracion(intIdDetalle);
                    }
                }
                worksheet_HojaTrabajo_ID.Rows.Remove(LineaActual);
                worksheet_HojaTrabajo.Rows.Remove(LineaActual);
            }
        }


        private bool EliminarFila()
        {
            bool retorno = false;

            List<int> elementos = new List<int>();
            workbook = spreadsheetControl.Document;
            Worksheet worksheet_HojaTrabajo = workbook.Worksheets[0];
            string strRango = worksheet_HojaTrabajo.Selection.ToString().TrimEnd();
            elementos = this.ObtenerFilasMarcadas(strRango);
            if (elementos.Count > 0)
            {
                DialogResult intEliminaRegistro = MessageBox.Show("Desea Eliminar las lineas elegidas ",
                                                               "Advertencia", MessageBoxButtons.YesNo,
                                                               MessageBoxIcon.Exclamation
                                                              );


                if (intEliminaRegistro == DialogResult.Yes)
                {
                    SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                    SplashScreenManager.Default.SetWaitFormDescription("Eliminando filas...");

                    retorno = true;
                    this.EliminarFilas(elementos);
                    SplashScreenManager.CloseForm();
                }
            }

            return retorno;
        }
        #endregion

        private void spreadsheetControl_CellValueChanged(object sender,
                                                         DevExpress.XtraSpreadsheet.SpreadsheetCellEventArgs e
                                                        )
        {
            if (e.RowIndex >= 7)
            {
                Worksheet worksheet_HojaTrabajo = workbook.Worksheets[0];

                if (e.ColumnIndex == 6)
                {
                    if (worksheet_HojaTrabajo.Cells[e.RowIndex, 6].Value.TextValue != null)
                    {
                        var strTipoDato = Convert.ToString(worksheet_HojaTrabajo.Cells[e.RowIndex, 6].Value.TextValue);
                        if (strTipoDato.TrimEnd().ToUpper() != "C" && strTipoDato.TrimEnd().ToUpper() != "H")
                        {
                            MessageBox.Show("Debe ingresar un valor entre [H] o [C]");
                            worksheet_HojaTrabajo.Cells[e.RowIndex, 6].Value = e.OldValue;
                        }
                    }
                }
                if (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 7)
                {
                    this.Btn_Ayuda.Enabled = false;
                    if (e.Value.IsNumeric || e.Value.IsEmpty)
                    {
                        //jesus
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un dato númerico");
                        worksheet_HojaTrabajo.Cells[e.RowIndex, e.ColumnIndex].Value = e.OldValue;
                    }
                }
            }
        }

        private void spreadsheetControl_CellEndEdit(object sender, DevExpress.XtraSpreadsheet.SpreadsheetCellValidatingEventArgs e)
        {
        }

        private void spreadsheetControl_PopupMenuShowing(object sender, DevExpress.XtraSpreadsheet.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == SpreadsheetMenuType.Cell)
            {
                // Elimina el elemento de menú "Borrar contenido".
                e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                e.Menu.RemoveMenuItem(SpreadsheetCommandId.InsertHyperlinkContextMenuItem);
                e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                //e.Menu.RemoveMenuItem(SpreadsheetCommandId.CopySelection);
                //e.Menu.RemoveMenuItem(SpreadsheetCommandId.PasteSelection);
                e.Menu.RemoveMenuItem(SpreadsheetCommandId.CutSelection);



                // Inserte un nuevo elemento en el menú emergente de la hoja de cálculo para tomar fotos.
                SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("Ayuda", new EventHandler(Ayuda_Formulario));
                myItem.BeginGroup = true;
                myItem.ImageOptions.Image = this.imageCollection1.Images[0];
                e.Menu.Items.Add(myItem);
            }
            if (e.MenuType == SpreadsheetMenuType.RowHeading)
            {
                e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatClearContentsContextMenuItem);
                e.Menu.RemoveMenuItem(SpreadsheetCommandId.FormatCellsContextMenuItem);
                SpreadsheetMenuItem myItem = new SpreadsheetMenuItem("Eliminar linea formulación", new EventHandler(Elimina_LineaFormulacion));
                myItem.BeginGroup = true;
                myItem.ImageOptions.Image = this.imageCollection1.Images[1];
                e.Menu.Items.Add(myItem);
            }

        }

        private void Ayuda_Formulario(object sender, EventArgs e)
        {
            this.Ayuda_Data();
        }

        private void Ayuda_Data()
        {
            workbook = spreadsheetControl.Document;
            Worksheet worksheet_HojaTrabajo = workbook.Worksheets[0];
            int intLinea = worksheet_HojaTrabajo.SelectedCell.TopRowIndex;
            int intColumna = worksheet_HojaTrabajo.SelectedCell.LeftColumnIndex;

            switch (intColumna)
            {
                case intCeldaAyudaEtapa:
                    Frm_Ayuda_EtapaProcesoLogistico Ayuda_Etapa = new Frm_Ayuda_EtapaProcesoLogistico();
                    Ayuda_Etapa.ShowMe(intLinea,
                                        MTP.cCodTipoPlantilla
                                    );
                    this.Btn_Ayuda.Enabled = false;
                    if (Ayuda_Etapa.blnEligio == true)
                    {
                        worksheet_HojaTrabajo.Cells[intLinea, intColumna].Value = Ayuda_Etapa.strCodPaso;
                        worksheet_HojaTrabajo.Cells[intLinea, intColumna + 1].Value = Ayuda_Etapa.strDesPaso;
                        worksheet_HojaTrabajo.Cells[intLinea, intColumna + 2].Value = Ayuda_Etapa.intIdPaso;
                    }
                    break;

            }
        }
        private void Elimina_LineaFormulacion(object sender, EventArgs e)
        {
            this.EliminarFila();
        }
        private void alertControl1_BeforeFormShow(object sender, DevExpress.XtraBars.Alerter.AlertFormEventArgs e)
        {
            e.AlertForm.OpacityLevel = 1;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
            SplashScreenManager.Default.SetWaitFormDescription("Trayendo lista de etapas...");

            Model.TipoPlantillaPaso TPP = new Model.TipoPlantillaPaso();

            if (MyStuff.UsaWCF)
            {
                //jesus
            }
            else
                TPP = objDATA.Recupera_TipoPlantilla_Codigo( MTP.cCodTipoPlantilla);

            Frm_Actualiza_Etapa_ProcesoLogistico frm = new Frm_Actualiza_Etapa_ProcesoLogistico();
            frm.ShowMe(MTP.cCodTipoPlantilla, TPP.vDesTipoPlantilla);

            SplashScreenManager.CloseForm();
            frm.ShowDialog();

        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.MostrarFiltro(false);
        }

        private void spreadsheetControl_CellBeginEdit(object sender, SpreadsheetCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 2)
                e.Cancel = true;
        }
    }
}
