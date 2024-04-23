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
    public partial class Frm_NuevoConformidad_FuenteFinanciamiento : Form
    {
        private WINlogistica.Framework FS = new WINlogistica.Framework();
        private DataSet DS_Proveedor = new DataSet();
        private DataSet DS_ContratoProyecto = new DataSet();
        private DataSet DS_ContratoFuenteFinanciamiento = new DataSet();
        private Model.ContratoCabecera MCC = new Model.ContratoCabecera();
        private Model.TipoDocumento MTD = new Model.TipoDocumento();
        private Model.TipoImpuesto MTI = new Model.TipoImpuesto();
        private Service.Data sdl = new Service.Data();
        private bool blnMuestraFormato_ListaProyecto = true;
        private bool blnMuestraFormato_ListaContrtoFuenteFinanciamiento = true;
        private static DataTable tblDocumentoTributario;
        private static DataTable tblOtrosGastos;
        private static DataTable tblAdjuntos;
        public Frm_NuevoConformidad_FuenteFinanciamiento()
        {
            InitializeComponent();
        }

        #region "Documentos Otros Gastos"

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

            col = new DataColumn("cNumDocumento", typeof(double));
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
        private void LlenarFilasTablaOtrosGastos(Model.ConformidadOtros obj)
        {

            DataRow OtrosGastosRow;
            OtrosGastosRow = tblOtrosGastos.NewRow();
            OtrosGastosRow["iIdConformidadOtros"] = obj.IidConformidadOtros;
            OtrosGastosRow["cCodCompañia"] = obj.CcodCompañia;
            OtrosGastosRow["cNroConformidad"] = obj.CnroConformidad;
            OtrosGastosRow["iTipoDocumento"] = obj.ITipoDocumento;
            OtrosGastosRow["vDesTipoDocumento"] = obj.VdesDocumento;
            OtrosGastosRow["cSerDocumento"] = obj.CserDocumento;
            OtrosGastosRow["cNumDocumento"] = obj.CnumDocumento;
            OtrosGastosRow["cSerDocumentoRelacionado"] = obj.CserDocumentoRelacionado;
            OtrosGastosRow["cNumDocumentoRelacionado"] = obj.CnumDocumentoRelacionado;
            OtrosGastosRow["dFecDocumento"] = obj.Dfecdocumento;
            OtrosGastosRow["cCodTipoImpuesto"] = obj.CcodTipoImpuesto;
            OtrosGastosRow["fAfecto"] = obj.fAfecto;
            OtrosGastosRow["fImpuesto"] = obj.fImpuesto;
            OtrosGastosRow["fSubTotal"] = obj.fSubTotal;
            OtrosGastosRow["fInafecto"] = obj.fInafecto;
            OtrosGastosRow["fTotal"] = obj.fTotal;

            tblOtrosGastos.Rows.Add(OtrosGastosRow);
        }
        #endregion

        #region "Documentos Tributarios"
        private void CreaTablaDocumentoTributario()
        {
            tblDocumentoTributario = new DataTable("DocumentoTributario");
            DataColumn col;

            col = new DataColumn("iIdConformidadDocumentoTributario", typeof(int));
            tblDocumentoTributario.Columns.Add(col);

            col = new DataColumn("cCodCompañia", typeof(string));
            tblDocumentoTributario.Columns.Add(col);

            col = new DataColumn("cNroConformidad", typeof(string));
            tblDocumentoTributario.Columns.Add(col);

            col = new DataColumn("iTipoDocumento", typeof(int));
            tblDocumentoTributario.Columns.Add(col);

            col = new DataColumn("vDesTipoDocumento", typeof(string));
            tblDocumentoTributario.Columns.Add(col);

            col = new DataColumn("cSerDocumento", typeof(string));
            tblDocumentoTributario.Columns.Add(col);

            col = new DataColumn("cNumDocumento", typeof(double));
            tblDocumentoTributario.Columns.Add(col);

            col = new DataColumn("dFecDocumento", typeof(DateTime));
            tblDocumentoTributario.Columns.Add(col);

            col = new DataColumn("cCodTipoImpuesto", typeof(string));
            tblDocumentoTributario.Columns.Add(col);

            col = new DataColumn("fAfecto", typeof(double));
            tblDocumentoTributario.Columns.Add(col);

            col = new DataColumn("fImpuesto", typeof(double));
            tblDocumentoTributario.Columns.Add(col);

            col = new DataColumn("fSubTotal", typeof(double));
            tblDocumentoTributario.Columns.Add(col);

            col = new DataColumn("fInafecto", typeof(double));
            tblDocumentoTributario.Columns.Add(col);

            col = new DataColumn("fTotal", typeof(double));
            tblDocumentoTributario.Columns.Add(col);
        }
        private void LlenarFilasTablaOtrosGastos(Model.ConformidadDocumentoTributario obj)
        {
            DataRow OtrosGastosRow;
            OtrosGastosRow = tblOtrosGastos.NewRow();
            OtrosGastosRow["iIdConformidadDocumentoTributario"] = obj.iIdContratoConformidad_Documento;
            OtrosGastosRow["cCodCompañia"] = obj.CcodCompañia;
            OtrosGastosRow["cNroConformidad"] = obj.CnroConformidad;
            OtrosGastosRow["iTipoDocumento"] = obj.ITipoDocumento;
            OtrosGastosRow["vDesTipoDocumento"] = obj.VdesDocumento;
            OtrosGastosRow["cSerDocumento"] = obj.CserDocumento;
            OtrosGastosRow["cNumDocumento"] = obj.CnumDocumento;
            OtrosGastosRow["dFecDocumento"] = obj.Dfecdocumento;
            OtrosGastosRow["cCodTipoImpuesto"] = obj.CcodTipoImpuesto;
            OtrosGastosRow["fAfecto"] = obj.fAfecto;
            OtrosGastosRow["fImpuesto"] = obj.fImpuesto;
            OtrosGastosRow["fSubTotal"] = obj.fSubTotal;
            OtrosGastosRow["fInafecto"] = obj.fInafecto;
            OtrosGastosRow["fTotal"] = obj.fTotal;

            tblOtrosGastos.Rows.Add(OtrosGastosRow);
        }


        #endregion

        #region "Documentos Adjuntos"
        private void CreaTablaAdjuntos()
        {
            tblAdjuntos = new DataTable("Adjuntos");
            DataColumn col;

            col = new DataColumn("IidConformidadAdjunto", typeof(int));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("cCodCompañia", typeof(string));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("cNroConformidad", typeof(string));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("CcodTipoArchivo", typeof(string));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("TAdjunto", typeof(string));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("TObservacion", typeof(string));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("CCodTipoObservacion", typeof(string));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("VdesTipoObservacion", typeof(string));
            tblAdjuntos.Columns.Add(col);

        }

        private void LlenarFilasTablaAdjuntos(Model.ConformidadAdjunto obj)
        {
            DataRow OtrosGastosRow;
            OtrosGastosRow = tblAdjuntos.NewRow();
            OtrosGastosRow["IidConformidadAdjunto"] = obj.IidConformidadAdjunto;
            OtrosGastosRow["cCodCompañia"] = obj.CcodCompañia;
            OtrosGastosRow["cNroConformidad"] = obj.CnroConformidad;
            OtrosGastosRow["CcodTipoArchivo"] = obj.CcodTipoArchivo;
            OtrosGastosRow["TAdjunto"] = obj.TAdjunto;
            OtrosGastosRow["TObservacion"] = obj.TObservacion;
            OtrosGastosRow["CcodTipoObservacion"] = obj.CcodTipoObservacion;
            OtrosGastosRow["VdesTipoObservacion"] = obj.VdesTipoObservacion;
            tblAdjuntos.Rows.Add(OtrosGastosRow);
        }

        #endregion

        #region "FormatoGrid_Fuente_Financiamiento"
        private void FormatoGrid_Contrato_FuenteFinanciamiento()
        {
            //this.Grd_Entregables.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            //this.Grd_Entregables.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Contrato_FuenteFinanciamiento.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("fImporteTotal"))
                {
                    oBand.Summaries.Add("Sum_fImporteTotal", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImporteTotal"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImporteTotal"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fImporteTotal"].Appearance.TextHAlign = HAlign.Right;
                }
                if (oBand.Columns.Exists("fImporteConformidad"))
                {
                    oBand.Summaries.Add("Sum_fImporteConformidad", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImporteConformidad"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImporteConformidad"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fImporteConformidad"].Appearance.TextHAlign = HAlign.Right;
                }
                if (oBand.Columns.Exists("fSaldo"))
                {
                    oBand.Summaries.Add("Sum_fSaldo", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fSaldo"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fSaldo"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fSaldo"].Appearance.TextHAlign = HAlign.Right;
                }
            }
            this.Grd_Contrato_FuenteFinanciamiento.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default


            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Contrato_FuenteFinanciamiento.DisplayLayout.Bands)
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
                    if (oColumn.DataType.ToString() == "System.Int32")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "#,###,###,###,###";
                    }
                }
            }

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.Grd_Contrato_FuenteFinanciamiento.DisplayLayout.Bands[0];
            oBand0 = this.Grd_Contrato_FuenteFinanciamiento.DisplayLayout.Bands[0];
            oBand0.Columns[0].Header.Caption = "?";
            oBand0.Columns[0].Width = 20;
            oBand0.Columns[1].Header.Caption = "Código";
            oBand0.Columns[1].Width = 90;
            oBand0.Columns[2].Header.Caption = "Fuente Financiamiento";
            oBand0.Columns[2].Width = 270;
            oBand0.Columns[3].Header.Caption = "Contrato";
            oBand0.Columns[3].Width = 120;
            oBand0.Columns[4].Header.Caption = "Ejecutado";
            oBand0.Columns[4].Width = 120;
            oBand0.Columns[5].Header.Caption = "Saldo";
            oBand0.Columns[5].Width = 120;
        }

        private void RecorreImagenesGrillaContratoFuenteFinanciamiento()
        {
            foreach (UltraGridRow oRow in this.Grd_Contrato_FuenteFinanciamiento.Rows)
            {
                RefrescarCeldaGrillaContratoFuenteFinanciamiento(oRow);
            }
        }
        private void RefrescarCeldaGrillaContratoFuenteFinanciamiento(UltraGridRow oRow)
        {
            if (Convert.ToBoolean(oRow.Cells[0].Value) == true)
            {
                //oRow.Cells[9].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                //oRow.Cells[9].Appearance.Image = imageList2.Images[1];
                //oRow.Cells[9].ButtonAppearance.Image = imageList2.Images[1];
                //oRow.Cells[9].ButtonAppearance.TextHAlign = HAlign.Right;
            }
        }

        private void Grd_Contrato_FuenteFinanciamiento_CellChange(object sender, CellEventArgs e)
        {

        }
        #endregion

        #region "FormatoGrid_Fuente_Proyecto"
        private void FormatoGrid_Contrato_Proyecto()
        {
            //this.Grd_Entregables.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            //this.Grd_Entregables.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Contrato_Proyecto.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("fImporteTotal"))
                {
                    oBand.Summaries.Add("Sum_fImporteTotal", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImporteTotal"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImporteTotal"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fImporteTotal"].Appearance.TextHAlign = HAlign.Right;
                }
                if (oBand.Columns.Exists("fImporteConformidad"))
                {
                    oBand.Summaries.Add("Sum_fImporteConformidad", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImporteConformidad"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImporteConformidad"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fImporteConformidad"].Appearance.TextHAlign = HAlign.Right;
                }
                if (oBand.Columns.Exists("fSaldo"))
                {
                    oBand.Summaries.Add("Sum_fSaldo", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fSaldo"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fSaldo"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fSaldo"].Appearance.TextHAlign = HAlign.Right;
                }
                if (oBand.Columns.Exists("fSaldoAutomatico"))
                {
                    oBand.Summaries.Add("Sum_fSaldoAutomatico", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fSaldoAutomatico"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fSaldoAutomatico"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fSaldoAutomatico"].Appearance.TextHAlign = HAlign.Right;
                }
                if (oBand.Columns.Exists("fSaldoManual"))
                {
                    oBand.Summaries.Add("Sum_fSaldoManual", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fSaldoManual"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fSaldoManual"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fSaldoManual"].Appearance.TextHAlign = HAlign.Right;
                }
            }
            this.Grd_Contrato_Proyecto.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default


            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Contrato_Proyecto.DisplayLayout.Bands)
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
                    if (oColumn.DataType.ToString() == "System.Int32")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "#,###,###,###,###";
                    }
                }
            }

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.Grd_Contrato_Proyecto.DisplayLayout.Bands[0];
            oBand0 = this.Grd_Contrato_Proyecto.DisplayLayout.Bands[0];
            oBand0.Columns[0].Header.Caption = "?";
            oBand0.Columns[0].Width = 20;
            oBand0.Columns[1].Header.Caption = "Código";
            oBand0.Columns[1].Width = 90;
            oBand0.Columns[2].Header.Caption = "Nombre de Proyecto";
            oBand0.Columns[2].Width = 240;
            oBand0.Columns[3].Header.Caption = "Contrato";
            oBand0.Columns[3].Width = 90;
            oBand0.Columns[4].Header.Caption = "Ejecutado";
            oBand0.Columns[4].Width = 90;
            oBand0.Columns[5].Header.Caption = "Saldo";
            oBand0.Columns[5].Width = 90;
            oBand0.Columns[6].Header.Caption = "Automatico";
            oBand0.Columns[6].Width = 90;
            oBand0.Columns[7].Header.Caption = "Manual";
            oBand0.Columns[7].Width = 90;
        }

        private void RecorreImagenesGrillaContratoProyecto()
        {
            foreach (UltraGridRow oRow in this.Grd_Contrato_Proyecto.Rows)
            {
                RefrescarCeldaGrillaContratoProyecto(oRow);
            }
        }
        private void RefrescarCeldaGrillaContratoProyecto(UltraGridRow oRow)
        {
            if (Convert.ToBoolean(oRow.Cells[0].Value) == true)
            {
                oRow.Cells[7].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                oRow.Cells[7].Appearance.Image = imageList2.Images[1];
                oRow.Cells[7].ButtonAppearance.Image = imageList2.Images[1];
                oRow.Cells[7].ButtonAppearance.TextHAlign = HAlign.Right;
            }
        }

        #endregion
        private void Frm_NuevoConformidad_FuenteFinanciamiento_Load(object sender, EventArgs e)
        {
            //this.CreaTablaOtrosGastos();
            //this.CreaTablaAdjuntos();

            this.CreaTablaDocumentoTributario();
            this.CreaTablaOtrosGastos();
            this.CreaTablaAdjuntos();
            this.Cbo_CodTipoDocumento.CargaDS(sdl.combo_TipoDocumento_Filtro(true,"4/5/"));

            this.Txt_NroContrato.nombreDS = sdl.ayuda_BuenaPro(MyStuff.CodigoEmpresa
                                                            );
            DS_Proveedor = sdl.ayuda_Proveedor(MyStuff.CodigoEmpresa);
        }

        private void Btn_NroContrato_Click(object sender, EventArgs e)
        {
            WINlogistica.Frm_Ayuda_Contrato frm = new WINlogistica.Frm_Ayuda_Contrato();
            frm.ShowMe(MyStuff.CodigoEmpresa);

            if (frm.blnEligio == true)
            {
                Model.ContratoCabecera MC = new Model.ContratoCabecera();
                string strContratoAnterior = Convert.ToString(this.Txt_NroContrato.Value);
                string strContrato = frm.strCodContrato;
                this.Txt_NroContrato.Value = strContrato;
                MC = sdl.recupera_Contrato(MyStuff.CodigoEmpresa,
                                          strContrato
                                         );
                this.Txt_DesObjetoContratacion.Value = MC.CCodObjetoContratacion;
                this.Edt_DesContrato.Value = MC.TDesContrato;
                this.Txt_MontoTotalContrato.Value = MCC.FprecioUnitario_Local + MCC.Fimpuesto_Local;
                this.Dtp_FecInicioActividad.Value = MC.DFecSuscripcionContrato;
                this.Txt_RucProveedor.Value = MC.cCodProveedor;
                this.Txt_RazonSocial.Value = MC.vRazonSocial;
                this.Dtp_FecConformidad.Value = DateTime.Now;

                if (MC.bSolicitaAnticipo == true)
                {
                    this.UTC_conformidad.Tabs["ADELANTO"].Visible = true;
                    //this.Grp_Adelanto.Visible = true;
                    this.Lbl_Garantia.Visible = false;
                    this.Chk_garantia.Visible = false;
                    this.Txt_Garantia.Visible = false;
                }
                else
                {
                    this.UTC_conformidad.Tabs["ADELANTO"].Visible = false;
                    //this.Grp_Adelanto.Visible = false;
                    this.Lbl_Garantia.Visible = true;
                    this.Chk_garantia.Visible = true;
                    this.Txt_Garantia.Visible = true;
                }

                // LLamar a saldos por fuente de financiamiento

                DS_ContratoFuenteFinanciamiento = sdl.lista_Contrato_FuenteFinanciemiento_Saldo(MyStuff.CodigoEmpresa,
                                                                                                strContrato
                                                                                              );

                this.Grd_Contrato_FuenteFinanciamiento.DataSource = DS_ContratoFuenteFinanciamiento;

                if (blnMuestraFormato_ListaContrtoFuenteFinanciamiento == true)
                {
                    blnMuestraFormato_ListaContrtoFuenteFinanciamiento = false;
                    this.FormatoGrid_Contrato_FuenteFinanciamiento();
                }
                this.RecorreImagenesGrillaContratoFuenteFinanciamiento();

                if (strContrato != strContratoAnterior)
                {
                    this.Txt_ImporteConformidad.Value = 0;
                    this.Txt_ImporteConformidad_C.Value = 0;
                    DS_ContratoProyecto.Clear();
                    this.Txt_SerDocumento.Value = "";
                    this.Txt_NumDocumento_Igv.Value = "";
                    this.Txt_NumDocumento_4TA.Value = "";
                    this.Dtp_FecDocumento.Value = DateTime.Now;
                    this.Txt_Afecto_Igv.Value = 0;
                    this.Txt_Impuesto_Igv.Value = 0;
                    this.Txt_SubTotal_Igv.Value = 0;
                    this.Txt_Inafecto_Igv.Value = 0;
                    this.Txt_SubTotal_Igv.Value = 0;
                    this.Txt_Afecto_4Ta.Value = 0;
                    this.Txt_Impuesto_4Ta.Value = 0;
                    this.Txt_Total_4Ta.Value = 0;
                }
            }
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            bool blnPase = false;
            string strCodFuenteFinanciamiento = "";
            string strNomFuenteFinanciamiento = "";
            switch (this.UltraTabControl1.ActiveTab.Index)
            {
                case 0:
                    int intNumeroFF = 0;
                    double dblSaldo = 0.0;
                    foreach (UltraGridRow oRow in this.Grd_Contrato_FuenteFinanciamiento.Rows)
                    {
                        if (Convert.ToBoolean(oRow.Cells[0].Value) == true)
                        {
                            dblSaldo = dblSaldo + Convert.ToDouble(oRow.Cells[5].Value);
                            strCodFuenteFinanciamiento = Convert.ToString(oRow.Cells[1].Value);
                            strNomFuenteFinanciamiento = Convert.ToString(oRow.Cells[2].Value);
                            intNumeroFF++;
                        }
                    }
                    switch (intNumeroFF)
                    {
                        case 0:
                            MessageBox.Show("Debe elegir una fuente definanciamiento", "Advertencia");
                            break;
                        case 1:
                            if (string.IsNullOrEmpty(Convert.ToString(this.Edt_DesContrato.Value)))
                            {
                                MessageBox.Show("Debe Digitar el Número de Contrato",
                                                 "Advertencia"
                                               );
                            }
                            else
                            {
                                if (dblSaldo == 0)
                                {
                                    MessageBox.Show("La Fuente de financiamiento elegido tiene dsaldo Cero",
                                                 "Advertencia"
                                               );
                                }
                                else
                                {
                                    blnPase = true;
                                    this.Txt_NroContrato_B.Value = Convert.ToString(this.Txt_NroContrato.Value);
                                    this.Txt_DesContrato_B.Value = Convert.ToString(this.Edt_DesContrato.Value);
                                    if (Convert.ToDouble(this.Txt_ImporteConformidad.Value) == 0)
                                    {
                                        this.Txt_ImporteConformidad.Value = dblSaldo;
                                    }
                                    else
                                    {
                                        if (strCodFuenteFinanciamiento.TrimEnd() != Convert.ToString(this.Txt_CodFuenteFinanciamiento_B.Value).TrimEnd())
                                        {
                                            this.Txt_ImporteConformidad.Value = dblSaldo;
                                        }
                                    }
                                    this.Txt_CodFuenteFinanciamiento_B.Value = strCodFuenteFinanciamiento;
                                    this.Txt_NomFuenteFinanciamiento_B.Value = strNomFuenteFinanciamiento;
                                    this.Txt_ImporteFuenteFinanciamiento.Value = dblSaldo;
                                }
                            }
                            break;
                        default:
                            MessageBox.Show("Solo debe elegir una fuente definanciamiento", "Advertencia");
                            break;
                    }
                    break;
                case 1:
                    //Preguntar si ha cambiado el valor de la conformidad
                    double dblImporteFF_A = Convert.ToDouble(this.Txt_ImporteConformidad.Value);
                    double dblImporteFF_C = Convert.ToDouble(this.Txt_ImporteConformidad_C.Value);
                    if (dblImporteFF_A != dblImporteFF_C)
                    {
                        if (Convert.ToDouble(this.Txt_ImporteConformidad.Value) > 0)
                        {
                            foreach (UltraGridRow oRow in this.Grd_Contrato_FuenteFinanciamiento.Rows)
                            {
                                if (Convert.ToBoolean(oRow.Cells[0].Value) == true)
                                {
                                    strCodFuenteFinanciamiento = Convert.ToString(oRow.Cells[1].Value);
                                    strNomFuenteFinanciamiento = Convert.ToString(oRow.Cells[2].Value);
                                }
                            }
                            String strContrato = Convert.ToString(this.Txt_NroContrato.Value);
                            double dblImporte = Convert.ToDouble(this.Txt_ImporteConformidad.Value);
                            this.Txt_NroContrato_C.Value = strContrato;
                            this.Txt_DesContrato.Value = this.Edt_DesContrato.Value;
                            this.Txt_CodFuenteFinanciamiento.Value = strCodFuenteFinanciamiento;
                            this.Txt_DesFuenteFinanciamiento.Value = strNomFuenteFinanciamiento;
                            this.Txt_CodProveedor_C.Value = this.Txt_RucProveedor.Value;
                            this.Txt_NomProveedor_C.Value = this.Txt_RazonSocial.Value;
                            this.Txt_ImporteConformidad_C.Value = this.Txt_ImporteConformidad.Value;

                            // LLenar Los Datos de la grilla de Proyectos

                            if (this.Grd_Contrato_Proyecto.Rows.Count > 0)
                            {
                                this.VolverAcalcularImportes(Convert.ToDouble(this.Txt_ImporteConformidad.Value));
                            }
                            else
                            {
                                DS_ContratoProyecto = sdl.lista_Contrato_Proyecto_Saldo(MyStuff.CodigoEmpresa,
                                                                        strContrato,
                                                                        strCodFuenteFinanciamiento,
                                                                        dblImporte
                                                                       );

                                this.Grd_Contrato_Proyecto.DataSource = DS_ContratoProyecto;

                                if (blnMuestraFormato_ListaProyecto == true)
                                {
                                    blnMuestraFormato_ListaProyecto = false;
                                    this.FormatoGrid_Contrato_Proyecto();
                                }
                                this.RecorreImagenesGrillaContratoProyecto();
                            }
                            blnPase = true;
                        }
                        else
                        {
                            MessageBox.Show("Debe digitar un importe de la conformidad", "Advertencia");
                        }
                    }
                    else
                    {
                        blnPase = true;
                    }
                    break;
                default:
                    break;
            }
            if (blnPase == true)
            {
                this.UltraTabControl1.PerformAction(Infragistics.Win.UltraWinTabControl.UltraTabControlAction.SelectNextTab);
                this.btn_Siguiente.Focus();
            }
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.UltraTabControl1.PerformAction(Infragistics.Win.UltraWinTabControl.UltraTabControlAction.SelectPreviousTab);
            this.btn_Atras.Focus();
        }

        private void btn_Finalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea grabar los datos de la Conformidad",
                            "Grabar Conformidad", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question
                           ) == DialogResult.OK)
            {
                if (this.VerificaIngresoMovimiento())
                {
                    // Grabar Conformidad
                    Model.Conformidad MC = new Model.Conformidad();
                    MC.cCodCompañia = MyStuff.CodigoEmpresa;
                    MC.cNroContrato = Convert.ToString(this.Txt_NroContrato.Value);
                    MC.cNroConformidad = "";
                    MC.cNroEntregable = "ENT-2021-0000";
                    MC.dFecEntregable = Convert.ToDateTime(this.Dtp_FecCierreEntregable.Value);
                    MC.dFecConformidad = Convert.ToDateTime(this.Dtp_FecConformidad.Value);
                    MC.fImporteConformidad = Convert.ToDouble(this.Txt_ImporteConformidad_C.Value);
                    MC.tComentarioConformidad = Convert.ToString(this.Edt_ComentarioConformidad.Value);
                    MC.cCodEmpleado = MyStuff.CodigoEmpleado;

                    MC.cNroConformidad = sdl.graba_Conformidad(MC).cNroConformidad;


                    //Grabar detalle de la conformidad
                    GrabarDetalleConformidad(Convert.ToString(this.Txt_CodFuenteFinanciamiento.Value),
                                              MC.cNroConformidad
                                            );

                    //Grabar el documento tributario
                    Model.ConformidadDocumentoTributario MCDT = new Model.ConformidadDocumentoTributario();
                    MCDT.CcodCompañia = MyStuff.CodigoEmpresa;
                    MCDT.CnroConformidad = MC.cNroConformidad;
                    MCDT.ITipoDocumento = Convert.ToInt32(this.Cbo_CodTipoDocumento.SelectedValue);
                    if (MCDT.ITipoDocumento == 4)
                    {
                        MCDT.CserDocumento = Convert.ToString(this.Txt_SerDocumento.Value);
                        MCDT.CnumDocumento = Convert.ToString(this.Txt_NumDocumento_Igv.Value);
                        MCDT.fAfecto = Convert.ToDouble(this.Txt_Afecto_Igv.Value);
                        MCDT.fImpuesto = Convert.ToDouble(this.Txt_Impuesto_Igv.Value);
                        MCDT.fInafecto = Convert.ToDouble(this.Txt_Inafecto_Igv.Value);
                    }
                    else
                    {
                        MCDT.CserDocumento = "";
                        MCDT.CnumDocumento = Convert.ToString(this.Txt_NumDocumento_4TA.Value);
                        MCDT.fAfecto = Convert.ToDouble(this.Txt_Afecto_4Ta.Value);
                        MCDT.fImpuesto = Convert.ToDouble(this.Txt_Impuesto_4Ta.Value) * -1;
                        MCDT.fInafecto = 0.0;
                    }
                    MCDT.Dfecdocumento = Convert.ToDateTime(this.Dtp_FecDocumento.Value);

                    MCDT.iIdContratoConformidad_Documento = sdl.graba_ConformidadDocumentoTributario(MCDT).iIdContratoConformidad_Documento;

                    // Grabar Adjuntos

                    this.GrabarAdjuntos(MC.cNroConformidad);

                    // Grabar Penalidad
                    if (Convert.ToDouble(this.Txt_ImportePenalidad.Value) > 0)
                    {
                        Model.ConformidadPenalidad MCP = new Model.ConformidadPenalidad();

                        MCP.cCodCompañia = MyStuff.CodigoEmpresa;
                        MCP.cNroConformidad = MC.cNroConformidad;
                        MCP.fImportePenalidad = Convert.ToDouble(this.Txt_ImportePenalidad.Value);
                        MCP.tComentarioPenalidad = "";

                        sdl.graba_ConformidadPenalidad(MCP);
                    }

                    // Grabar Garantia
                    if (Convert.ToDouble(this.Txt_Garantia.Value) > 0)
                    {
                        Model.Conformidadgarantia MCG = new Model.Conformidadgarantia();

                        MCG.cCodCompañia = MyStuff.CodigoEmpresa;
                        MCG.cNroConformidad = MC.cNroConformidad;
                        MCG.fImporteGarantia = Convert.ToDouble(this.Txt_Garantia.Value);
                        MCG.tComentarioGarantia = "";

                        sdl.graba_ConformidadGarantia(MCG);
                    }

                    // Grabar Ajuste Polinomico
                    if (Convert.ToDouble(this.Txt_ImporteAjustePolinomico.Value) > 0)
                    {
                        Model.ConformidadAjustePolinomico MCAP = new Model.ConformidadAjustePolinomico();

                        MCAP.cCodCompañia = MyStuff.CodigoEmpresa;
                        MCAP.cNroConformidad = MC.cNroConformidad;
                        MCAP.fImporteAjustePolinomico = Convert.ToDouble(Txt_ImporteAjustePolinomico.Value);
                        MCAP.tComentarioAjustePolinomico = "";

                        sdl.graba_ConformidadAjustePolinomico(MCAP);
                    }

                    // Grabar Retencion
                    if (Convert.ToDouble(this.Txt_Retencion.Value) > 0)
                    {
                        Model.ConformidadRetencion MCR = new Model.ConformidadRetencion();

                        MCR.cCodCompañia = MyStuff.CodigoEmpresa;
                        MCR.cNroConformidad = MC.cNroConformidad;
                        MCR.fImporteRetencion = Convert.ToDouble(Txt_Retencion.Value);
                        MCR.tComentarioRetencion = "";

                        sdl.graba_ConformidadRetencion(MCR);
                    }

                    MessageBox.Show("Se ha Generado correctamente la conformidad Nro. " +
                    "\n\n" +
                    MC.cNroConformidad,
                    "Generación de Conformidad"
                    );

                    this.Close();

                }

            }
        }

        private void GrabarAdjuntos(string strNroConformidad)
        {
            if (tblAdjuntos.Rows.Count > 0)
            {
                Model.ConformidadAdjunto MCA = new Model.ConformidadAdjunto();
                foreach (DataRow oRow in tblAdjuntos.Rows)
                {
                    MCA.CcodCompañia = MyStuff.CodigoEmpresa;
                    MCA.CnroConformidad = strNroConformidad;
                    MCA.CcodTipoArchivo = Convert.ToString(oRow["CcodTipoArchivo"]);
                    MCA.TAdjunto = Convert.ToString(oRow["TAdjunto"]);
                    MCA.TObservacion = Convert.ToString(oRow["TObservacion"]);
                    MCA.CcodTipoObservacion = Convert.ToString(oRow["CcodTipoObservacion"]);
                    MCA.IidConformidadAdjunto = sdl.graba_ConformidadAdjunto(MCA).IidConformidadAdjunto;
                }
            }
        }

        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";
            double dblImporteProyecto = 0.0;
            Boolean blnDescuadreProyecto = false;
            string strCodProyectoDescuadrado = "";
            foreach (DataRow oRow in DS_ContratoProyecto.Tables[0].Rows)
            {
                if (Convert.ToBoolean(oRow["bPase"]) == true)
                {
                    dblImporteProyecto = dblImporteProyecto + Convert.ToDouble(oRow["fSaldoManual"]);
                    if (Convert.ToDouble(oRow["fSaldomanual"]) > Convert.ToDouble(oRow["fSaldo"]))
                    {
                        blnDescuadreProyecto = true;
                        strCodProyectoDescuadrado = Convert.ToString(oRow["cCodProyecto"]);
                    }
                }
            }
            double dblImporteFuenteFinanciamiento = Convert.ToDouble(this.Txt_ImporteConformidad_C.Value);
            double dblImporteDocumento = 0;
            int intTipoDocumento = Convert.ToInt32(this.Cbo_CodTipoDocumento.SelectedValue);

            if (intTipoDocumento == 4 )
            {
                if (blnDescuadreProyecto == true)
                {
                    blnVerifica = false;
                    strMensaje = "El Importe manual del Proyecto " +
                                 strCodProyectoDescuadrado.TrimEnd() +
                                 " No cuadra con el Saldo automatico por proyecto";
                }

                dblImporteDocumento = Math.Round(Convert.ToDouble(this.Txt_Total_Igv.Value), 2);
                if (dblImporteFuenteFinanciamiento != dblImporteProyecto)
                {
                    blnVerifica = false;
                    strMensaje = "El Importe total de los proyectos debe ser igual al importe de la conformidad";
                }

                if (dblImporteFuenteFinanciamiento != dblImporteDocumento)
                {
                    blnVerifica = false;
                    strMensaje = "El Importe total del documento debe ser igual al importe de la conformidad";
                }

                if (string.IsNullOrEmpty(Convert.ToString(this.Txt_SerDocumento.Value)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe digitar la serie del documento";
                }
                if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NumDocumento_Igv.Value)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe digitar el número de documento";
                }

                if (Convert.ToDouble(this.Txt_Total_Igv.Value) == 0.0)
                {
                    blnVerifica = false;
                    strMensaje = "Debe digitar el importe del documento";
                }

            }
            else
            {
                dblImporteDocumento = Math.Round(Convert.ToDouble(this.Txt_Total_4Ta.Value), 2);
                if (dblImporteFuenteFinanciamiento != dblImporteProyecto)
                {
                    blnVerifica = false;
                    strMensaje = "El Importe total de los proyectos debe ser igual al monto de la fuente de financiamiento";
                }

                if (dblImporteFuenteFinanciamiento != dblImporteDocumento)
                {
                    blnVerifica = false;
                    strMensaje = "El Importe total del documento debe ser igual al monto de la fuente de financiamiento";
                }

                if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NumDocumento_4TA.Value)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe digitar el número de documento";
                }

                if (Convert.ToDouble(this.Txt_Total_4Ta.Value) == 0.0)
                {
                    blnVerifica = false;
                    strMensaje = "Debe digitar el importe del documento";
                }
            }

            if (blnVerifica == false)
            {
                MessageBox.Show(strMensaje,
                                "Error", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Error
                           );
            }
            return blnVerifica;
        }


        private void GrabarDetalleConformidad(string strCodFuenteFinanciamiento,
                                               string strNroConformidad
                                             )
        {
            Model.ConformidadProyecto MCP = new Model.ConformidadProyecto();
            DataSet ds = new DataSet();
            double dblImporteTotal = 0; // Convert.ToDouble( this.Txt_ImporteConformidad_C.Value );
            string strCodProyecto = "";
            string strCodFormulacion = "";
            foreach (DataRow oRow in DS_ContratoProyecto.Tables[0].Rows)
            {
                if (Convert.ToBoolean(oRow["bPase"]) == true)
                {
                    dblImporteTotal = Convert.ToDouble(oRow["fSaldomanual"]);
                    // Llamar el script del detalle de la conformidad
                    strCodProyecto = Convert.ToString(oRow["cCodProyecto"]);
                    ds = sdl.lista_Contrato_Proyecto_Detalle_Saldo(MyStuff.CodigoEmpresa,
                                                                   Convert.ToString(this.Txt_NroContrato.Value),
                                                                   Convert.ToString(this.Txt_CodFuenteFinanciamiento.Value),
                                                                   strCodProyecto
                                                                 );

                    double dblImporteProyecto = 0;
                    double dblImporteConformidad = 0;
                    double dblSumaImporteConformidad = 0;
                    double dblFactor = 0;
                    int intTotLinea = ds.Tables[0].Rows.Count;
                    int intLinea = 1;
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        strCodFormulacion = Convert.ToString(row["cCodFormulacion"]);
                        dblImporteProyecto = Convert.ToDouble(row["fSaldo"]);
                        dblFactor = (dblImporteProyecto / dblImporteTotal);
                        dblImporteConformidad = Math.Round(dblImporteTotal * dblFactor, 2);

                        MCP.cCodCompañia = MyStuff.CodigoEmpresa;
                        MCP.cNroConformidad = strNroConformidad;
                        MCP.cCodProyecto = strCodProyecto;
                        MCP.cCodFuenteFinanciamiento = strCodFuenteFinanciamiento;
                        MCP.cCodFormulacion = strCodFormulacion;

                        if (intLinea < intTotLinea)
                        {
                            MCP.fImporteConformidad = dblImporteConformidad;
                        }
                        else
                        {
                            MCP.fImporteConformidad = (dblImporteTotal - dblSumaImporteConformidad);
                        }
                        dblSumaImporteConformidad = dblSumaImporteConformidad + dblImporteConformidad;
                        sdl.graba_ConformidadProyecto(MCP);
                        intLinea = intLinea + 1;
                    }
                }
            }
        }

        private void Btn_TrasladarValor_Click(object sender, EventArgs e)
        {
            double dblImporte = 0.0;
            foreach (UltraGridRow oRow in this.Grd_Contrato_Proyecto.Rows)
            {
                if (Convert.ToBoolean(oRow.Cells[0].Value) == true)
                {
                    dblImporte = dblImporte + Math.Round((Convert.ToDouble(oRow.Cells[7].Value)), 2);
                }
            }
            this.Txt_Afecto_Igv.Value = Math.Round(dblImporte / 1.18, 2);
            this.Txt_Impuesto_Igv.Value = Math.Round(Convert.ToDouble(this.Txt_Afecto_Igv.Value) * .18, 2);
            this.Txt_SubTotal_Igv.Value = (Convert.ToDouble(this.Txt_Afecto_Igv.Value) +
                                           Convert.ToDouble(this.Txt_Impuesto_Igv.Value)
                                         );
            this.Txt_Total_Igv.Value = (Convert.ToDouble(this.Txt_Afecto_Igv.Value) +
                                         Convert.ToDouble(this.Txt_Impuesto_Igv.Value) +
                                         Convert.ToDouble(this.Txt_Inafecto_Igv.Value)
                                       );
        }

        private void VolverAcalcularImportes(double dblImporte)
        {
            double dblImporteTotal = 0;
            double dblImporteTotalConformidad = dblImporte;
            int intTotLinea = 0;
            foreach (DataRow oRow in DS_ContratoProyecto.Tables[0].Rows)
            {
                if (Convert.ToBoolean(oRow["bPase"]) == true)
                {
                    dblImporteTotal = dblImporteTotal + Convert.ToDouble(oRow["fSaldo"]);
                    intTotLinea++;
                }
            }

            double dblImporteProyecto = 0;
            double dblImporteConformidad = 0;
            double dblSumaImporteConformidad = 0;
            double dblFactor = 0;
            int intLinea = 1;


            foreach (DataRow oRow in DS_ContratoProyecto.Tables[0].Rows)
            {
                if (Convert.ToBoolean(oRow["bPase"]) == true)
                {
                    dblImporteProyecto = Convert.ToDouble(oRow["fSaldo"]);
                    dblFactor = (dblImporteProyecto / dblImporteTotal);
                    dblImporteConformidad = Math.Round(dblImporteTotalConformidad * dblFactor, 2);
                    if (intLinea < intTotLinea)
                    {
                        oRow["fSaldoManual"] = dblImporteConformidad;
                    }
                    else
                    {
                        oRow["fSaldoManual"] = (dblImporteTotalConformidad - dblSumaImporteConformidad);
                    }
                    dblSumaImporteConformidad = dblSumaImporteConformidad + dblImporteConformidad;
                    intLinea = intLinea + 1;
                }
            }
        }

        private void Btn_RecalcularImportes_Click(object sender, EventArgs e)
        {
            this.VolverAcalcularImportes(Convert.ToDouble(this.Txt_ImporteConformidad_C.Value));
        }

        private void Txt_Impuesto_4Ta_Leave(object sender, EventArgs e)
        {
            this.Txt_Total_4Ta.Value = Convert.ToDouble(this.Txt_Afecto_4Ta.Value) -
                           Convert.ToDouble(this.Txt_Impuesto_4Ta.Value);
        }

        private void Btn_OtrosGastos_Click(object sender, EventArgs e)
        {
            WINlogistica.Frm_NuevoConformidad_Otros frm = new WINlogistica.Frm_NuevoConformidad_Otros();
            frm.Showme(tblOtrosGastos);
            if (frm.blnEligio == true)
            {
                tblOtrosGastos.Rows.Clear();
                double dblSumaImporte = 0.0;

                if (frm.tblOtrosGastos != null)
                {
                    if (frm.tblOtrosGastos.Rows.Count > 0)
                    {
                        Model.ConformidadOtros MCO = new Model.ConformidadOtros();
                        foreach (DataRow oRow in frm.tblOtrosGastos.Rows)
                        {
                            MCO.IidConformidadOtros = 0;
                            MCO.CcodCompañia = "";
                            MCO.CnroConformidad = "";
                            MCO.ITipoDocumento = Convert.ToInt32(oRow["iTipoDocumento"]);
                            MCO.VdesDocumento = Convert.ToString(oRow["vDesTipoDocumento"]);
                            MCO.CserDocumento = Convert.ToString(oRow["cSerDocumento"]);
                            MCO.CnumDocumento = Convert.ToString(oRow["cNumDocumento"]);
                            MCO.CserDocumentoRelacionado = Convert.ToString(oRow["cSerDocumentoRelacionado"]);
                            MCO.CnumDocumentoRelacionado = Convert.ToString(oRow["cNumDocumentoRelacionado"]);
                            MCO.Dfecdocumento = Convert.ToDateTime(oRow["dFecdocumento"]);
                            MCO.CcodTipoImpuesto = Convert.ToString(oRow["cCodTipoImpuesto"]);
                            MCO.fAfecto = Convert.ToDouble(oRow["fAfecto"]);
                            MCO.fImpuesto = Convert.ToDouble(oRow["fImpuesto"]);
                            MCO.fSubTotal = Convert.ToDouble(oRow["fSubTotal"]);
                            MCO.fInafecto = Convert.ToDouble(oRow["fInafecto"]);
                            MCO.fTotal = Convert.ToDouble(oRow["fTotal"]);

                            this.LlenarFilasTablaOtrosGastos(MCO);

                            dblSumaImporte = dblSumaImporte + Convert.ToDouble(oRow["fAfecto"]) +
                                                              Convert.ToDouble(oRow["fImpuesto"]) +
                                                              Convert.ToDouble(oRow["fInafecto"]);
                        }
                    }
                }
                this.Txt_Otros.Value = dblSumaImporte;
            }
        }

        private void Chk_Penalidad_CheckedChanged(object sender, EventArgs e)
        {
            this.Txt_ImportePenalidad.Enabled = Chk_Penalidad.Checked;
            //this.Txt_MotPenalidad.Enabled = Chk_Penalidad.Checked;
            this.Btn_Adjunto_Penalidad.Visible = Chk_Penalidad.Checked;
        }

        private void Chk_Retencion_CheckedChanged(object sender, EventArgs e)
        {
            this.Txt_Retencion.Enabled = this.Chk_Retencion.Checked;
            this.Btn_Adjunto_Retencion.Visible = this.Chk_Retencion.Checked;
        }

        private void Chk_ContingenciaSocial_CheckedChanged(object sender, EventArgs e)
        {
            this.Txt_ContingenciaSocial.Enabled = this.Chk_ContingenciaSocial.Checked;
            this.Btn_Adjunto_ContingenciaSocial.Visible = this.Chk_ContingenciaSocial.Checked;
        }

        private void Chk_garantia_CheckedChanged(object sender, EventArgs e)
        {
            this.Txt_Garantia.Enabled = this.Chk_garantia.Checked;
            this.Btn_Adjunto_Garantia.Visible = this.Chk_garantia.Checked;
        }

        private void Chk_AjustePolinomico_CheckedChanged(object sender, EventArgs e)
        {
            this.Txt_ImporteAjustePolinomico.Enabled = this.Chk_AjustePolinomico.Checked;
            this.Btn_Adjunto_AjustePolinomico.Visible = this.Chk_AjustePolinomico.Checked;
        }

        private void Btn_Adjunto_Conformidad_Click(object sender, EventArgs e)
        {
            if (this.AdjuntarArchivo("CONF"))
            {
                //Imagen de color vivo
            }
            else
            {
                //Imagen de color muerto
            }
        }

        private void Btn_Adjunto_Penalidad_Click(object sender, EventArgs e)
        {
            if (this.AdjuntarArchivo("PENA",true))
            {
                //Imagen de color vivo
            }
            else
            {
                //Imagen de color muerto
            }
        }

        private void Btn_Adjunto_Retencion_Click(object sender, EventArgs e)
        {
            if (this.AdjuntarArchivo("RETE"))
            {
                //Imagen de color vivo
            }
            else
            {
                //Imagen de color muerto
            }
        }

        private void Btn_Adjunto_ContingenciaSocial_Click(object sender, EventArgs e)
        {
            if (this.AdjuntarArchivo("CONT"))
            {
                //Imagen de color vivo
            }
            else
            {
                //Imagen de color muerto
            }
        }

        private void Btn_Adjunto_Otros_Click(object sender, EventArgs e)
        {
            if (this.AdjuntarArchivo("OTR"))
            {
                //Imagen de color vivo
            }
            else
            {
                //Imagen de color muerto
            }
        }

        private void Btn_Adjunto_Garantia_Click(object sender, EventArgs e)
        {
            if (this.AdjuntarArchivo("GARA"))
            {
                //Imagen de color vivo
            }
            else
            {
                //Imagen de color muerto
            }
        }

        private void Btn_Adjunto_Documento_Click(object sender, EventArgs e)
        {
            if (this.AdjuntarArchivo("FACT"))
            {
                //Imagen de color vivo
            }
            else
            {
                //Imagen de color muerto
            }
        }

        private bool AdjuntarArchivo(string strCodTipoArchivo,
                                     bool blnActivaComboTipoObservacion = false
                                    )
        {
            bool blnAdjuntoArchivo = false;
            List<Model.ConformidadAdjunto> _lista = new List<Model.ConformidadAdjunto>();
            List<Model.ConformidadAdjunto> _lista_Temp = new List<Model.ConformidadAdjunto>();

            _lista =
            (from order in tblAdjuntos.AsEnumerable()
             where order.Field<string>("cCodTipoArchivo").TrimEnd() != strCodTipoArchivo.TrimEnd()
             orderby order.Field<string>("cCodTipoArchivo")
             select new Model.ConformidadAdjunto
             {
                 IidConformidadAdjunto = order.Field<int>("IidConformidadAdjunto"),
                 CcodCompañia = order.Field<string>("CcodCompañia"),
                 CnroConformidad = order.Field<string>("CnroConformidad"),
                 CcodTipoArchivo = order.Field<string>("CcodTipoArchivo"),
                 TAdjunto = order.Field<string>("TAdjunto"),
                 TObservacion = order.Field<string>("TObservacion"),
                 CcodTipoObservacion = order.Field<string>("CcodTipoObservacion"),
                 VdesTipoObservacion = order.Field<string>("VdesTipoObservacion"),
             }
            ).ToList();


            _lista_Temp =
                        (from order in tblAdjuntos.AsEnumerable()
                         where order.Field<string>("cCodTipoArchivo").TrimEnd() == strCodTipoArchivo.TrimEnd()
                         orderby order.Field<string>("cCodTipoArchivo")
                         select new Model.ConformidadAdjunto
                         {
                             IidConformidadAdjunto = order.Field<int>("IidConformidadAdjunto"),
                             CcodCompañia = order.Field<string>("CcodCompañia"),
                             CnroConformidad = order.Field<string>("CnroConformidad"),
                             CcodTipoArchivo = order.Field<string>("CcodTipoArchivo"),
                             TAdjunto = order.Field<string>("TAdjunto"),
                             TObservacion = order.Field<string>("TObservacion"),
                             CcodTipoObservacion = order.Field<string>("CcodTipoObservacion"),
                             VdesTipoObservacion = order.Field<string>("VdesTipoObservacion"),
                         }
                        ).ToList();
            WINlogistica.Frm_NuevoConformidad_Adjunto frm = new WINlogistica.Frm_NuevoConformidad_Adjunto();
            frm.Showme(_lista_Temp, strCodTipoArchivo, blnActivaComboTipoObservacion);
            if (frm.blnEligio == true)
            {
                tblAdjuntos.Rows.Clear();
                // Reemplazar los datos anteriores
                Model.ConformidadAdjunto MCA = new Model.ConformidadAdjunto();

                foreach (Model.ConformidadAdjunto p in _lista)
                {
                    MCA.IidConformidadAdjunto = p.IidConformidadAdjunto;
                    MCA.CcodCompañia = p.CcodCompañia;
                    MCA.CnroConformidad = p.CnroConformidad;
                    MCA.CcodTipoArchivo = p.CcodTipoArchivo;
                    MCA.TAdjunto = p.TAdjunto;
                    MCA.TObservacion = p.TObservacion;
                    MCA.CcodTipoObservacion = p.CcodTipoObservacion;
                    MCA.VdesTipoObservacion = p.VdesTipoObservacion;
                    this.LlenarFilasTablaAdjuntos(MCA);
                }

                if (frm.tblAdjuntos != null)
                {
                    if (frm.tblAdjuntos.Rows.Count > 0)
                    {
                        foreach (DataRow oRow in frm.tblAdjuntos.Rows)
                        {
                            MCA.IidConformidadAdjunto = 0;
                            MCA.CcodCompañia = "";
                            MCA.CnroConformidad = "";
                            MCA.CcodTipoArchivo = strCodTipoArchivo;
                            MCA.TAdjunto = Convert.ToString(oRow["TAdjunto"]);
                            MCA.TObservacion = Convert.ToString(oRow["TObservacion"]);
                            MCA.CcodTipoObservacion = Convert.ToString(oRow["CcodTipoObservacion"]);
                            MCA.VdesTipoObservacion = Convert.ToString(oRow["VdesTipoObservacion"]);
                            this.LlenarFilasTablaAdjuntos(MCA);
                            blnAdjuntoArchivo = true;
                        }
                    }
                }
                //Cambiar la imagen cuando ya tiene adjunto
            }
            return blnAdjuntoArchivo;
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

        private void Txt_NumDocumento_4TA_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(this.Txt_Afecto_4Ta.Value) != 0)
            {
                if (this.Chk_AfectoRetencion.Checked == true)
                {
                    this.Txt_Impuesto_4Ta.Value = Convert.ToDouble(this.Txt_Afecto_4Ta.Value) *
                                                  (MTI.fFactor / 100);
                    this.Txt_Total_4Ta.Value = Convert.ToDouble(this.Txt_Afecto_4Ta.Value) -
                                               Convert.ToDouble(this.Txt_Impuesto_4Ta.Value);
                }
                else
                {
                    this.Txt_Impuesto_4Ta.Value = 0;
                    this.Txt_Total_4Ta.Value = Convert.ToDouble(this.Txt_Afecto_4Ta.Value);
                }
            }
            else
            {
                this.Txt_Impuesto_4Ta.Value = 0;
                this.Txt_Total_4Ta.Value = 0;
            }

        }

        private void Chk_AfectoRetencion_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(this.Txt_Afecto_4Ta.Value) != 0)
            {
                if (this.Chk_AfectoRetencion.Checked == true)
                {
                    this.Txt_Impuesto_4Ta.Value = Convert.ToDouble(this.Txt_Afecto_4Ta.Value) *
                                                  (MTI.fFactor / 100);
                    this.Txt_Total_4Ta.Value = Convert.ToDouble(this.Txt_Afecto_4Ta.Value) -
                                               Convert.ToDouble(this.Txt_Impuesto_4Ta.Value);
                }
                else
                {
                    this.Txt_Impuesto_4Ta.Value = 0;
                    this.Txt_Total_4Ta.Value = Convert.ToDouble(this.Txt_Afecto_4Ta.Value);
                }
            }
            else
            {
                this.Txt_Impuesto_4Ta.Value = 0;
                this.Txt_Total_4Ta.Value = 0;
            }
        }

        private void Grd_Contrato_Proyecto_ClickCellButton(object sender, CellEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_Contrato_Proyecto.ActiveRow;
            switch (e.Cell.Column.Index)
            {
                case 7:
                    if (Convert.ToBoolean(oRow.Cells[0].Value) == true)
                    {
                        WINlogistica.Frm_NuevoConformidad_CambiaValor frm = new WINlogistica.Frm_NuevoConformidad_CambiaValor();
                        double dblNuevovalor = 0.0;
                        if (Convert.ToDouble(oRow.Cells[7].Value) > 0)
                        {
                            dblNuevovalor = Convert.ToDouble(oRow.Cells[7].Value);
                        }
                        else
                        {
                            dblNuevovalor = Convert.ToDouble(oRow.Cells[6].Value);
                        }
                        frm.Showme(dblNuevovalor);
                        if (frm.blnActializo == true)
                        {
                            oRow.Cells[7].Value = frm.dblValor;
                        }
                    }
                    else
                    {
                        MessageBox.Show("La linea ha sido deshabilitada");
                    }

                    break;
            }
        }

        private void Grd_Contrato_Proyecto_CellChange(object sender, CellEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_Contrato_Proyecto.ActiveRow;
            if (e.Cell.Column.Index == 0)
            {
                if (Convert.ToBoolean(oRow.Cells[0].Value) == false)
                {
                    oRow.Cells[0].Value = true;
                }
                else
                {
                    oRow.Cells[0].Value = false;
                    oRow.Cells[7].Value = 0.0;
                }
                //this.RefrescarCeldaGrillaEnviados(oRow);
            }
        }

        private void treeList_AfterActivate(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
        {
            this.UltraTabControl1.SelectedTab = this.UltraTabControl1.Tabs[e.TreeNode.Key];

        }

        private void UltraTabControl1_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {
            //keep the active node of the tree in sync with the tab
            this.treeList.ActiveNode = this.treeList.GetNodeByKey(e.Tab.Key);
            this.treeList.ActiveNode.Selected = true;

            this.btn_Atras.Enabled = e.Tab.Index > 0;
            this.btn_Siguiente.Enabled = e.Tab.Index < e.Tab.TabControl.Tabs.Count - 1;

            //update the caption
            this.ultraLabelCaption.Text = e.Tab.Text;
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

        private void Txt_Impuesto_Igv_Leave(object sender, EventArgs e)
        {
            this.Txt_Total_Igv.Value = Convert.ToDouble(this.Txt_Afecto_Igv.Value) +
                               Convert.ToDouble(this.Txt_Impuesto_Igv.Value) +
                               Convert.ToDouble(this.Txt_Inafecto_Igv.Value)
                               ;
        }

        private void Txt_Inafecto_Igv_Leave(object sender, EventArgs e)
        {
            this.Txt_Total_Igv.Value = Convert.ToDouble(this.Txt_Afecto_Igv.Value) +
                            Convert.ToDouble(this.Txt_Impuesto_Igv.Value) +
                            Convert.ToDouble(this.Txt_Inafecto_Igv.Value)
                            ;
        }

        private void Txt_Afecto_4Ta_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(this.Txt_Afecto_4Ta.Value) != 0)
            {
                if (this.Chk_AfectoRetencion.Checked == true)
                {
                    this.Txt_Impuesto_4Ta.Value = Convert.ToDouble(this.Txt_Afecto_4Ta.Value) *
                                                  (MTI.fFactor / 100);
                    this.Txt_Total_4Ta.Value = Convert.ToDouble(this.Txt_Afecto_4Ta.Value) -
                                               Convert.ToDouble(this.Txt_Impuesto_4Ta.Value);
                }
                else
                {
                    this.Txt_Impuesto_4Ta.Value = 0;
                    this.Txt_Total_4Ta.Value = Convert.ToDouble(this.Txt_Afecto_4Ta.Value);
                }
            }
            else
            {
                this.Txt_Impuesto_4Ta.Value = 0;
                this.Txt_Total_4Ta.Value = 0;
            }
        }

        private void Cbo_CodTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_CodTipoDocumento.SelectedValue.ToString().TrimEnd() != "System.Data.DataRowView")
            {
                int intTipoDocumento = Convert.ToInt32(this.Cbo_CodTipoDocumento.SelectedValue);
                MTD = sdl.recupera_TipoDocumento_Codigo(intTipoDocumento);
                if (MTD.vDesTipoDocumento.TrimEnd() == "")
                {
                    this.Txt_SerDocumento.Enabled = false;
                    this.Txt_NumDocumento_4TA.Enabled = false;
                    this.Txt_NumDocumento_Igv.Enabled = false;
                }
                else
                {
                    this.Txt_SerDocumento.Enabled = true;
                    this.Txt_NumDocumento_4TA.Enabled = true;
                    this.Txt_NumDocumento_Igv.Enabled = true;
                }
                MTI = sdl.recupera_TipoImpuesto_Codigo(MTD.cCodTipoImpuesto);
                verTipoImpuesto(MTI);
            }

        }

        private void verTipoImpuesto(Model.TipoImpuesto obj)
        {

            if (obj.cCodTipoImpuesto.TrimEnd() == "02")
            {
                this.Txt_SerDocumento.Visible = false;
                this.Txt_NumDocumento_Igv.Visible = false;
                this.Txt_NumDocumento_4TA.Visible = true;
                this.UTC_Principal.SelectedTab = this.UTC_Principal.Tabs["4TA"];
            }
            else
            {
                this.Txt_SerDocumento.Visible = true;
                this.Txt_NumDocumento_Igv.Visible = true;
                this.Txt_NumDocumento_4TA.Visible = false;
                this.UTC_Principal.SelectedTab = this.UTC_Principal.Tabs["IGV"];
            }
        }
    }
}
