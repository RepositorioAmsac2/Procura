using System;
using System.Data;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win;

namespace WINlogistica
{
    public partial class Frm_NuevoConformidad_Otros : Form
    {
        private int intIdConformidadOtros = 0;
        private Model.ConformidadOtros objMOG = new Model.ConformidadOtros();
        private Model.TipoDocumento MTD = new Model.TipoDocumento();
        private Model.TipoImpuesto MTI = new Model.TipoImpuesto();
        private Service.Data sl = new Service.Data();
        public DataTable tblOtrosGastos;
        public bool blnEligio = false;
        public Frm_NuevoConformidad_Otros()
        {
            InitializeComponent();
        }

        public void Showme(DataTable tbl_tempo )
        {

            if (tbl_tempo.Rows.Count > 0)
            {
                foreach (DataRow row in tbl_tempo.Rows)
                {
                    objMOG.IidConformidadOtros = Convert.ToInt32(row["IidConformidadOtros"]);
                    objMOG.CcodCompañia = Convert.ToString(row["CcodCompañia"]);
                    objMOG.CnroConformidad = Convert.ToString(row["CnroConformidad"]);
                    objMOG.ITipoDocumento = Convert.ToInt32(row["ITipoDocumento"]);
                    objMOG.VdesDocumento = Convert.ToString(row["VdesDocumento"]);
                    objMOG.CserDocumento = Convert.ToString(row["CserDocumento"]);
                    objMOG.CnumDocumento = Convert.ToString(row["CnumDocumento"]);
                    objMOG.CserDocumentoRelacionado = Convert.ToString(row["CserDocumentoRelacionado"]);
                    objMOG.CnumDocumentoRelacionado = Convert.ToString(row["CnumDocumentoRelacionado"]);
                    objMOG.Dfecdocumento = Convert.ToDateTime(row["Dfecdocumento"]);
                    objMOG.CcodTipoImpuesto = Convert.ToString(row["CcodTipoImpuesto"]);
                    objMOG.fAfecto = Convert.ToDouble(row["fAfecto"]);
                    objMOG.fImpuesto = Convert.ToDouble(row["fImpuesto"]);
                    objMOG.fSubTotal = Convert.ToDouble(row["fSubTotal"]);
                    objMOG.fInafecto = Convert.ToDouble(row["fInafecto"]);
                    objMOG.fTotal = Convert.ToDouble(row["fTotal"]);


                    this.mostrarOtrosGastos(objMOG);

                    break;
                }
            }
            else
            {
                objMOG = new Model.ConformidadOtros();
                mostrarOtrosGastos(objMOG);
            }

            this.Grd_ListaOtrosGastos.DataSource = tbl_tempo;
            FormatoGrid();
            if (tbl_tempo.Rows.Count == 0)
            {
                this.semaforoBotones(false, true);
            }

            Service.Data objSC = new Service.Data();
            this.Cbo_CodTipoDocumento.CargaDS( objSC.combo_TipoDocumento_Filtro(true,"6/7/") );

            ShowDialog();
            this.Txt_Afecto_Igv.Focus();
        }

        private void CreaTablaOtrosGastos()
        {
            tblOtrosGastos = new DataTable("OtrosGastos");
            DataColumn col;

            col = new DataColumn("IidConformidadOtros", typeof(int));
            tblOtrosGastos.Columns.Add(col);

            col = new DataColumn("cCodCompañia", typeof(string));
            tblOtrosGastos.Columns.Add(col);

            col = new DataColumn("cNroConformidad", typeof(string));
            tblOtrosGastos.Columns.Add(col);

            col = new DataColumn("iTipoDocumento", typeof(int));
            tblOtrosGastos.Columns.Add(col);

            col = new DataColumn("vDesTipoDocumento", typeof(string));
            tblOtrosGastos.Columns.Add(col);

            col = new DataColumn("cSerDocumento", typeof(string));
            tblOtrosGastos.Columns.Add(col);

            col = new DataColumn("cNumDocumento", typeof(string));
            tblOtrosGastos.Columns.Add(col);

            col = new DataColumn("cSerDocumentoRelacionado", typeof(string));
            tblOtrosGastos.Columns.Add(col);

            col = new DataColumn("cNumDocumentoRelacionado", typeof(string));
            tblOtrosGastos.Columns.Add(col);

            col = new DataColumn("dFecDocumento", typeof(DateTime));
            tblOtrosGastos.Columns.Add(col);

            col = new DataColumn("cCodTipoImpuesto", typeof(string));
            tblOtrosGastos.Columns.Add(col);

            col = new DataColumn("fAfecto", typeof(double));
            tblOtrosGastos.Columns.Add(col);

            col = new DataColumn("fImpuesto", typeof(double));
            tblOtrosGastos.Columns.Add(col);

            col = new DataColumn("fSubTotal", typeof(double));
            tblOtrosGastos.Columns.Add(col);

            col = new DataColumn("fInafecto", typeof(double));
            tblOtrosGastos.Columns.Add(col);

            col = new DataColumn("fTotal", typeof(double));
            tblOtrosGastos.Columns.Add(col);
        }

        private void LlenarFilasTablaOtrosGastos(   int intIdConformidadOtros,
                                                    string strCodCompañia,
                                                    string strNroConformidad,
                                                    int intTipoDocumento,
                                                    string strDesTipoDocumento,
                                                    string strSerDocumento,
                                                    string strNumDocumento,
                                                    string strSerDocumentoRelacionado,
                                                    string strNumDocumentoRelacionado,
                                                    DateTime dateFecDocumento,
                                                    string strCodTipoImpuesto,
                                                    double dblAfecto,
                                                    double dblImpuesto,
                                                    double dblSubTotal,
                                                    double dblInafecto,
                                                    double dblTotal
                                                )
        {

            DataRow OtrosGastosRow;
            OtrosGastosRow = tblOtrosGastos.NewRow();
            OtrosGastosRow["iIdConformidadOtros"] = intIdConformidadOtros;
            OtrosGastosRow["cCodCompañia"] = strCodCompañia;
            OtrosGastosRow["cNroConformidad"] = strNroConformidad;
            OtrosGastosRow["iTipoDocumento"] = intTipoDocumento;
            OtrosGastosRow["vDesTipoDocumento"] = strDesTipoDocumento;
            OtrosGastosRow["cSerDocumento"] = strSerDocumento;
            OtrosGastosRow["cNumDocumento"] = strNumDocumento;
            OtrosGastosRow["cSerDocumentoRelacionado"] = strSerDocumentoRelacionado;
            OtrosGastosRow["cNumDocumentoRelacionado"] = strNumDocumentoRelacionado;
            OtrosGastosRow["dFecDocumento"] = dateFecDocumento;
            OtrosGastosRow["cCodTipoImpuesto"] = strCodTipoImpuesto;
            OtrosGastosRow["fAfecto"] = dblAfecto;
            OtrosGastosRow["fImpuesto"] = dblImpuesto;
            OtrosGastosRow["fSubTotal"] = dblSubTotal;
            OtrosGastosRow["fInafecto"] = dblInafecto;
            OtrosGastosRow["fTotal"] = dblTotal;



            tblOtrosGastos.Rows.Add(OtrosGastosRow);
        }
        private void semaforoBotones(Boolean accionOne, Boolean accionTwo)
        {

            Btn_Nuevo.Enabled = accionOne;
            Btn_Grabar.Enabled = accionTwo;
            if (this.Grd_ListaOtrosGastos.Rows.Count == 0)
            {
                this.Btn_DesHacer.Enabled = accionOne;
            }
            else
            {
                this.Btn_DesHacer.Enabled = accionTwo;
            }

            this.Btn_Eliminar.Enabled = accionOne;
            //this.Btn_Listar.Enabled = accionOne;

        }
        private void mostrarOtrosGastos(Model.ConformidadOtros obj)
        {
            this.Cbo_CodTipoDocumento.SelectedValue = obj.ITipoDocumento;
            this.Txt_SerDocumento.Value = obj.CserDocumento;
            this.Txt_NumDocumento_Igv.Value = obj.CnumDocumento;
            this.Dtp_fecDocumento.Value = obj.Dfecdocumento;
            this.Txt_Afecto_Igv.Value = obj.fAfecto;
            this.Txt_Impuesto_Igv.Value = obj.fImpuesto;
            this.Txt_SubTotal_Igv.Value = obj.fSubTotal;
            this.Txt_Inafecto_Igv.Value = obj.fInafecto;
            this.Txt_Total_Igv.Value = obj.fTotal;
        }


        #region "Grilla"

        private void FormatoGrid()
        {

            foreach (UltraGridBand oBand in this.Grd_ListaOtrosGastos.DisplayLayout.Bands)
            {
                string[] Campos = { "dMontoTotal" };
                for (int i = 0; i < Campos.GetLength(0); i++)
                {
                    string strCampo = Campos[i];
                    string strKeyCampo = "Sum_" + Campos[i];

                    if (oBand.Columns.Exists(strCampo))
                    {
                        oBand.Summaries.Add(strKeyCampo, SummaryType.Sum, oBand.Columns[strCampo], SummaryPosition.UseSummaryPositionColumn);
                        oBand.Summaries[strKeyCampo].DisplayFormat = "{0:#,###,###.00}";
                        oBand.Summaries[strKeyCampo].Appearance.TextHAlign = HAlign.Right;
                    }
                }
            }

            this.Grd_ListaOtrosGastos.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_ListaOtrosGastos.DisplayLayout.Bands)
            {
                foreach (Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn in oBand.Columns)
                {
                    if (oColumn.DataType.ToString() == "System.Double")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "#,###,###.00";
                    }
                    if (oColumn.DataType.ToString() == "System.Decimal")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "#,###,###.00";
                    }
                    if (oColumn.DataType.ToString() == "System.Int32")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "#,###,###";
                    }
                }
            }

            this.Grd_ListaOtrosGastos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_ListaOtrosGastos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            Infragistics.Win.UltraWinGrid.UltraGridBand oBandPantalla;
            oBandPantalla = this.Grd_ListaOtrosGastos.DisplayLayout.Bands[0];

            oBandPantalla.Columns[4].Header.Caption = "Documento";
            oBandPantalla.Columns[4].Width = 100;
            oBandPantalla.Columns[5].Header.Caption = "Serie";
            oBandPantalla.Columns[5].Width = 40;
            oBandPantalla.Columns[6].Header.Caption = "Número";
            oBandPantalla.Columns[6].Width = 80;
            oBandPantalla.Columns[9].Header.Caption = "Fecha";
            oBandPantalla.Columns[9].Width = 80;
            oBandPantalla.Columns[11].Header.Caption = "Afecto";
            oBandPantalla.Columns[11].Width = 100;
            oBandPantalla.Columns[12].Header.Caption = "Impuesto";
            oBandPantalla.Columns[12].Width = 100;
            oBandPantalla.Columns[13].Header.Caption = "SubTotal";
            oBandPantalla.Columns[13].Width = 100;
            oBandPantalla.Columns[14].Header.Caption = "Inafecto";
            oBandPantalla.Columns[14].Width = 100;
            oBandPantalla.Columns[15].Header.Caption = "Total";
            oBandPantalla.Columns[15].Width = 100;

            oBandPantalla.Columns[0].Hidden = true;
            oBandPantalla.Columns[1].Hidden = true;
            oBandPantalla.Columns[2].Hidden = true;
            oBandPantalla.Columns[3].Hidden = true;
            oBandPantalla.Columns[7].Hidden = true;
            oBandPantalla.Columns[8].Hidden = true;
            oBandPantalla.Columns[10].Hidden = true;
        }
        #endregion
        private void Frm_SolicitudViatico_OtrosGastos_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
            // -- Aqui colocaremos las lineas de salida
            //
            if (this.Grd_ListaOtrosGastos.Rows.Count > 0)
            {
                this.CreaTablaOtrosGastos();
                this.blnEligio = true;
                int intIdConformidadOtros = 0;
                string strCodCompañia = "";
                string strNroConformidad = "";
                int intTipoDocumento = 0;
                string strDesTipoDocumento = "";
                string strSerDocumento = "";
                string strNumDocumento = "";
                string strSerDocumentoRelacionado = "";
                string strNumDocumentoRelacionado = "";
                DateTime dateFecDocumento = DateTime.Now;
                string strCodTipoImpuesto = "";
                double dblAfecto = 0;
                double dblImpuesto = 0;
                double dblSubTotal = 0;
                double dblInafecto = 0;
                double dblTotal = 0;

                foreach (UltraGridRow row in  this.Grd_ListaOtrosGastos.Rows)
                {

                    intIdConformidadOtros = 0;
                    strCodCompañia = "";
                    strNroConformidad = "";
                    intTipoDocumento = Convert.ToInt32(row.Cells[3].Value);
                    strDesTipoDocumento = Convert.ToString(row.Cells[4].Value);
                    strSerDocumento = Convert.ToString(row.Cells[5].Value);
                    strNumDocumento = Convert.ToString(row.Cells[6].Value);
                    strSerDocumentoRelacionado = Convert.ToString(row.Cells[7].Value);
                    strNumDocumentoRelacionado = Convert.ToString(row.Cells[8].Value);
                    dateFecDocumento = Convert.ToDateTime(row.Cells[9].Value);
                    strCodTipoImpuesto = Convert.ToString(row.Cells[10].Value);
                    dblAfecto = Convert.ToDouble(row.Cells[11].Value);
                    dblImpuesto = Convert.ToDouble(row.Cells[12].Value);
                    dblSubTotal = Convert.ToDouble(row.Cells[13].Value);
                    dblInafecto = Convert.ToDouble(row.Cells[14].Value);
                    dblTotal = Convert.ToDouble(row.Cells[15].Value);

                    this.LlenarFilasTablaOtrosGastos(intIdConformidadOtros,
                                                    strCodCompañia,
                                                    strNroConformidad,
                                                    intTipoDocumento,
                                                    strDesTipoDocumento,
                                                    strSerDocumento,
                                                    strNumDocumento,
                                                    strSerDocumentoRelacionado,
                                                    strNumDocumentoRelacionado,
                                                    dateFecDocumento,
                                                    strCodTipoImpuesto,
                                                    dblAfecto,
                                                    dblImpuesto,
                                                    dblSubTotal,
                                                    dblInafecto,
                                                    dblTotal
                                                    );
                }
            }
        }

        private bool VerificaDatos()
        {
            bool blnResult = true;
            string strMensajeError = "";

            if (string.IsNullOrEmpty( Convert.ToString( this.Cbo_CodTipoDocumento.SelectedValue)))
            {
                strMensajeError = "Debe ingresar el tipo de documento";
                blnResult = false;
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_Afecto_Igv.Value)))
            {
                strMensajeError = "Debe ingresar el valor afecto del documento";
                blnResult = false;
            }

            if (strMensajeError.TrimEnd() != "")
            {
                MessageBox.Show(strMensajeError);
            }

            return blnResult;
        }

        private void GrabarOtrosGastos()
        {
            if (this.VerificaDatos())
            {
                //objMOG.cCodConcepto = Convert.ToString(this.Txt_CodConcepto.Value);
                //objMOG.dMonto = Convert.ToDouble(this.Txt_Importe.Value);

                if (this.intIdConformidadOtros == 0)
                {
                    this.actualizarLineaOtrosGastos(true, true);
                }
                else
                {
                    this.actualizarLineaOtrosGastos(false, true);
                }
                this.blnEligio = true;

            }

        }

        private void actualizarLineaOtrosGastos(Boolean adiciona, Boolean pinta)
        {
            //UltraGridRow oRow = this.grd_mvto_Temas.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.Last;
            //oRow.Expanded = true;

            //   Make the first row's first child the active row
            //oRow = oRow.GetChild(Infragistics.Win.UltraWinGrid.ChildRow.First);
            //if (oRow == null)
            //    return;

            if (adiciona == true)
            {
                this.Grd_ListaOtrosGastos.DisplayLayout.Bands[0].AddNew();
            }

            if (pinta == true)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.Grd_ListaOtrosGastos.ActiveRow;
                //this.grd_mvto_Temas.ActiveRow = oRow;
                oRow.Cells[3].Value = Convert.ToString(this.Cbo_CodTipoDocumento.SelectedValue);
                oRow.Cells[4].Value = Convert.ToString(this.Cbo_CodTipoDocumento.Text);
                oRow.Cells[5].Value = Convert.ToString(this.Txt_SerDocumento.Value);
                oRow.Cells[6].Value = Convert.ToString(this.Txt_NumDocumento_Igv.Value);
                oRow.Cells[7].Value = "";
                oRow.Cells[8].Value = "";
                oRow.Cells[9].Value = Convert.ToDateTime(this.Dtp_fecDocumento.Value);
                oRow.Cells[10].Value = Convert.ToString(MTD.cCodTipoImpuesto);
                oRow.Cells[11].Value = Convert.ToDouble(this.Txt_Afecto_Igv.Value);
                oRow.Cells[12].Value = Convert.ToDouble(this.Txt_Impuesto_Igv.Value);
                oRow.Cells[13].Value = Convert.ToDouble(this.Txt_SubTotal_Igv.Value);
                oRow.Cells[14].Value = Convert.ToDouble(this.Txt_Inafecto_Igv.Value);
                oRow.Cells[15].Value = Convert.ToDouble(this.Txt_Total_Igv.Value);
            }
        }
        private void eliminarOtrosGastos()
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_ListaOtrosGastos.ActiveRow;
            oRow.Delete(false);
            this.blnEligio = true;
        }


        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            intIdConformidadOtros = 0;
            Model.ConformidadOtros obj = new Model.ConformidadOtros();

            this.mostrarOtrosGastos(obj);

            semaforoBotones(false, true);
            this.Txt_Afecto_Igv.Focus();
        }

        private void Btn_Grabar_Click(object sender, EventArgs e)
        {
            {
                this.GrabarOtrosGastos();
                this.semaforoBotones(true, true);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Desea Eliminar el Registro",
                                                                "Advertencia", MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Exclamation
                                                               );

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                eliminarOtrosGastos();
            }
        }

        private void Btn_DesHacer_Click(object sender, EventArgs e)
        {
            intIdConformidadOtros = objMOG.IidConformidadOtros;
            this.mostrarOtrosGastos(objMOG);
            this.semaforoBotones(true, false);
        }
        private void Grd_ListaOtrosGastos_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_ListaOtrosGastos.ActiveRow;

            //intIdConformidadOtros = Convert.ToInt32(oRow.Cells[0].Value);
            objMOG.ITipoDocumento = Convert.ToInt32(oRow.Cells[3].Value);
            objMOG.VdesDocumento = Convert.ToString(oRow.Cells[4].Text);
            objMOG.CserDocumento = Convert.ToString(oRow.Cells[5].Value);
            objMOG.CnumDocumento = Convert.ToString(oRow.Cells[6].Value);
            objMOG.CserDocumentoRelacionado = Convert.ToString(oRow.Cells[7].Value);
            objMOG.CnumDocumentoRelacionado = Convert.ToString(oRow.Cells[8].Value);
            objMOG.Dfecdocumento = Convert.ToDateTime(oRow.Cells[9].Value);
            objMOG.CcodTipoImpuesto = MTD.cCodTipoImpuesto;
            objMOG.fAfecto = Convert.ToDouble(oRow.Cells[11].Value);
            objMOG.fImpuesto = Convert.ToDouble(oRow.Cells[12].Value);
            objMOG.fSubTotal = Convert.ToDouble(oRow.Cells[13].Value);
            objMOG.fInafecto = Convert.ToDouble(oRow.Cells[14].Value);
            objMOG.fTotal = Convert.ToDouble(oRow.Cells[15].Value);
            this.mostrarOtrosGastos(objMOG);
        }

        private void Frm_NuevoConformidad_Otros_Load(object sender, EventArgs e)
        {

        }

        private void Cbo_CodTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_CodTipoDocumento.SelectedValue.ToString().TrimEnd() != "System.Data.DataRowView")
            {
                int intTipoDocumento = Convert.ToInt32(this.Cbo_CodTipoDocumento.SelectedValue);
                MTD = sl.recupera_TipoDocumento_Codigo(intTipoDocumento);
                if (MTD.vDesTipoDocumento.TrimEnd() == "")
                {
                    this.Txt_SerDocumento.Enabled = false;
                    this.Txt_NumDocumento_Igv.Enabled = false;
                }
                else
                {
                    this.Txt_SerDocumento.Enabled = true;
                    this.Txt_NumDocumento_Igv.Enabled = true;
                }
                MTI = sl.recupera_TipoImpuesto_Codigo(MTD.cCodTipoImpuesto);
            }

        }

        private void Txt_SerDocumento_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_SerDocumento.Value)) == false)
            {
                this.Txt_SerDocumento.Value = Convert.ToString(this.Txt_SerDocumento.Value).TrimEnd().PadLeft(MTD.iLongitudSerie, '0');
            }
        }

        private void Txt_NumDocumento_Igv_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NumDocumento_Igv.Value)) == false)
            {
                this.Txt_NumDocumento_Igv.Value = Convert.ToString(this.Txt_NumDocumento_Igv.Value).TrimEnd().PadLeft(MTD.iLongitudDocumento, '0');
            }

        }

        private void Txt_Afecto_Igv_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(this.Txt_Afecto_Igv.Value) != 0)
            {
                this.Txt_Impuesto_Igv.Value = Convert.ToDouble(this.Txt_Afecto_Igv.Value) *
                              (MTI.fFactor / 100);

                this.Txt_SubTotal_Igv.Value = Convert.ToDouble(this.Txt_Afecto_Igv.Value) +
                                           Convert.ToDouble(this.Txt_Impuesto_Igv.Value);

                this.Txt_Total_Igv.Value = Convert.ToDouble(this.Txt_Afecto_Igv.Value) +
                                           Convert.ToDouble(this.Txt_Impuesto_Igv.Value) +
                                           Convert.ToDouble(this.Txt_Inafecto_Igv.Value);

            }
            else
            {
                this.Txt_Impuesto_Igv.Value = 0;
                this.Txt_SubTotal_Igv.Value = 0;
                this.Txt_Total_Igv.Value = Txt_Inafecto_Igv.Value;
            }

        }

        private void Txt_Inafecto_Igv_Leave(object sender, EventArgs e)
        {
            this.Txt_Total_Igv.Value = Convert.ToDouble(this.Txt_Afecto_Igv.Value) +
                               Convert.ToDouble(this.Txt_Impuesto_Igv.Value) +
                               Convert.ToDouble(this.Txt_Inafecto_Igv.Value)
                               ;

        }
    }
}
