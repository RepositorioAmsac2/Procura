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
    public partial class Frm_FormatoConformidad_Pantalla : Form
    {
        private WINlogistica.Framework FS = new WINlogistica.Framework();
        private Service.Data sl = new Service.Data();
        private static DataTable tblOtrosGastos;
        private static DataTable tblAdjuntos;
        private DataSet DS_Conformidad = new DataSet();
        private DataTable DT_Contrato = new DataTable();
        private DataTable DT_Conformidad = new DataTable();
        private DataTable DT_Documento = new DataTable();
        private DataTable DT_Proyecto = new DataTable();
        private DataTable DT_Adjunto = new DataTable();
        private string strCodCompañia = "";
        private string strNroConformidad = "";
        public Frm_FormatoConformidad_Pantalla()
        {
            InitializeComponent();
        }

        public void ShowMe( string cCodCompañia,
                             string strNroContrato,
                             string cNroConformidad
                            )
        {
            strCodCompañia = cCodCompañia;
            strNroConformidad = cNroConformidad;
            DS_Conformidad = sl.reporte_Conformidad_Pantalla(strCodCompañia,
                                                             strNroContrato,
                                                             strNroConformidad
                                                            );
            DT_Contrato = DS_Conformidad.Tables[0];
            DT_Conformidad = DS_Conformidad.Tables[1];
            DT_Proyecto = DS_Conformidad.Tables[2];
            DT_Documento = DS_Conformidad.Tables[3];
            DT_Adjunto = DS_Conformidad.Tables[4];

            // Datos del contrato
            this.Txt_NroContrato.Value = Convert.ToString(DT_Contrato.Rows[0]["cNroContrato"]);
            this.Txt_DesContrato.Value = Convert.ToString(DT_Contrato.Rows[0]["tDesContrato"]);
            this.Txt_CodFuenteFinanciamiento.Value = Convert.ToString(DT_Contrato.Rows[0]["cCodFuenteFinanciamiento"]);
            this.Txt_DesFuenteFinanciamiento.Value = Convert.ToString(DT_Contrato.Rows[0]["vNomFuenteFinanciamiento"]);
            this.Txt_CodProveedor.Value = Convert.ToString(DT_Contrato.Rows[0]["cCodProveedor"]);
            this.Txt_NomProveedor.Value = Convert.ToString(DT_Contrato.Rows[0]["vNomProveedor"]);

            // datos de la conformidad
            this.Dtp_FecConformidad.Value = Convert.ToDateTime(DT_Conformidad.Rows[0]["dfecConformidad"]);
            this.Txt_ImporteConformidad.Value = Convert.ToDouble(DT_Conformidad.Rows[0]["fImporteConformidad"]);
            this.Txt_Retencion.Value = Convert.ToDouble(DT_Conformidad.Rows[0]["fImporteRetencion"]);
            this.Txt_ContingenciaSocial.Value = Convert.ToDouble(DT_Conformidad.Rows[0]["fImporteContingenciaSocial"]);
            this.Txt_Garantia.Value = Convert.ToDouble(DT_Conformidad.Rows[0]["fImporteGarantia"]);
            this.Txt_ImporteAjustePolinomico.Value = Convert.ToDouble(DT_Conformidad.Rows[0]["fImporteAjustePolinomico"]);
            this.Txt_Otros.Value = Convert.ToDouble(DT_Conformidad.Rows[0]["fImporteOtros"]);
            this.Edt_ComentarioConformidad.Value = Convert.ToString(DT_Conformidad.Rows[0]["tComentarioConformidad"]);
            this.Txt_ImportePenalidad.Value = Convert.ToDouble(DT_Conformidad.Rows[0]["fImportePenalidad"]);
            this.Txt_MotPenalidad.Value = Convert.ToString(DT_Conformidad.Rows[0]["tComentarioPenalidad"]);

            // Datos del Proyecto
            this.Grd_Contrato_Proyecto.DataSource = DT_Proyecto;
            this.FormatoGrid_Contrato_Proyecto();

            // datos del documento
            this.Txt_DesTipoDocumento.Value = Convert.ToString(DT_Documento.Rows[0]["vDesTipoDocumento"]);
            this.Txt_NumDocumento.Value = Convert.ToString(DT_Documento.Rows[0]["cNumDocumento"]);
            this.Txt_Afecto.Value = Convert.ToDouble(DT_Documento.Rows[0]["fImporteAfecto"]);
            this.Txt_Impuesto.Value = Convert.ToDouble(DT_Documento.Rows[0]["fImpuesto"]);
            this.Txt_SubTotal.Value = Convert.ToDouble(DT_Documento.Rows[0]["fSubTotal"]);
            this.Txt_Total.Value = Convert.ToDouble(DT_Documento.Rows[0]["fImporteInafecto"]);
            this.Txt_Total.Value = Convert.ToDouble(DT_Documento.Rows[0]["fTotal"]);

            // Encender o Apagar adjuntos

            Btn_Adjunto_Conformidad.Visible = this.VerSiTieneAdjunto("CONF");
            Btn_Adjunto_Penalidad.Visible = this.VerSiTieneAdjunto("PENA");
            Btn_Adjunto_Retencion.Visible = this.VerSiTieneAdjunto("RETE");
            Btn_Adjunto_ContingenciaSocial.Visible = this.VerSiTieneAdjunto("CONT");
            Btn_Adjunto_Otros.Visible = this.VerSiTieneAdjunto("OTR");
            Btn_Adjunto_Garantia.Visible = this.VerSiTieneAdjunto("GARA");
            Btn_Adjunto_Documento.Visible = this.VerSiTieneAdjunto("FACT");
            this.ShowDialog();
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
        private void LlenarFilasTablaOtrosGastos( Model.ConformidadOtros obj)
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

            col = new DataColumn("TArchivoOrigen", typeof(string));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("TArchivoDestino", typeof(string));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("VnombreArchivo", typeof(string));
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
            tblAdjuntos.Rows.Add(OtrosGastosRow);
        }

        #endregion

        #region "FormatoGrid_Fuente_Proyecto"
        private void FormatoGrid_Contrato_Proyecto()
        {
            //this.Grd_Entregables.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            //this.Grd_Entregables.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Contrato_Proyecto.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("fImporteConformidad"))
                {
                    oBand.Summaries.Add("Sum_fImporteConformidad", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImporteConformidad"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImporteConformidad"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fImporteConformidad"].Appearance.TextHAlign = HAlign.Right;
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
            oBand0.Columns[0].Header.Caption = "Código";
            oBand0.Columns[0].Width = 110;
            oBand0.Columns[1].Header.Caption = "Nombre de Proyecto";
            oBand0.Columns[1].Width = 360;
            oBand0.Columns[2].Header.Caption = "Conformidad";
            oBand0.Columns[2].Width = 110;
        }


        #endregion

       

        #region "Botones de avance"
        private void btn_Atras_Click(object sender, EventArgs e)
        {
            this.UltraTabControl1.PerformAction(Infragistics.Win.UltraWinTabControl.UltraTabControlAction.SelectPreviousTab);
            this.btn_Atras.Focus();
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            this.UltraTabControl1.PerformAction(Infragistics.Win.UltraWinTabControl.UltraTabControlAction.SelectNextTab);
            this.btn_Siguiente.Focus();
        }

        private void treeList_AfterSelect(object sender, Infragistics.Win.UltraWinTree.SelectEventArgs e)
        {

        }

        private void treeList_AfterActivate(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
        {
            this.UltraTabControl1.SelectedTab = this.UltraTabControl1.Tabs[e.TreeNode.Key];
        }

        #endregion

        #region "Adjuntos"
        private void Btn_Adjunto_Conformidad_Click(object sender, EventArgs e)
        {
            this.AdjuntarArchivo("CONF");
        }

        private void Btn_Adjunto_Penalidad_Click(object sender, EventArgs e)
        {
            this.AdjuntarArchivo("PENA");
        }

        private void Btn_Adjunto_Retencion_Click(object sender, EventArgs e)
        {
            this.AdjuntarArchivo("RETE");
        }

        private void Btn_Adjunto_ContingenciaSocial_Click(object sender, EventArgs e)
        {
            this.AdjuntarArchivo("CONT");
        }

        private void Btn_Adjunto_Otros_Click(object sender, EventArgs e)
        {
            this.AdjuntarArchivo("OTR");
        }

        private void Btn_Adjunto_Garantia_Click(object sender, EventArgs e)
        {
            this.AdjuntarArchivo("GARA");
        }

        private void Btn_Adjunto_Documento_Click(object sender, EventArgs e)
        {
            this.AdjuntarArchivo("FACT");
        }

        private bool VerSiTieneAdjunto( string strCodTipoAdjunto )
        {
            Boolean blnTipo = true;
            string strEncuentraTipo = "";
            strEncuentraTipo = FS.TraerDescripcion_DataTable(DT_Adjunto,
                                                                       0,
                                                                       0,
                                                                       strCodTipoAdjunto
                                                                     );
            if (string.IsNullOrEmpty(strEncuentraTipo))
            {
                blnTipo = false;
            }
            return blnTipo;
        }
        private bool AdjuntarArchivo(string strCodTipoArchivo)
        {
            bool blnAdjuntoArchivo = true;

            WINlogistica.Frm_Consulta_Conformidad_Adjunto frm = new WINlogistica.Frm_Consulta_Conformidad_Adjunto();
            frm.ShowMe( strCodCompañia, 
                        strNroConformidad,
                        strCodTipoArchivo
                      );
            return blnAdjuntoArchivo;
        }
        #endregion

        private void Btn_OtrosGastos_Click(object sender, EventArgs e)
        {
            WINlogistica.Frm_NuevoConformidad_Otros frm = new WINlogistica.Frm_NuevoConformidad_Otros();
            frm.Showme(tblOtrosGastos);
        }

        private void ultraGroupBox6_Click(object sender, EventArgs e)
        {

        }

        private void UltraTabControl1_SelectedTabChanged(object sender, Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs e)
        {
            this.treeList.ActiveNode = this.treeList.GetNodeByKey(e.Tab.Key);
            this.treeList.ActiveNode.Selected = true;

            this.btn_Atras.Enabled = e.Tab.Index > 0;
            this.btn_Siguiente.Enabled = e.Tab.Index < e.Tab.TabControl.Tabs.Count - 1;

            // update the caption
            this.ultraLabelCaption.Text = e.Tab.Text;

        }

    }
}
