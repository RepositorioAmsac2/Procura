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
    public partial class Frm_ListaConformidades : Form
    {
        private bool blnMuestraFormato = false;
        private Service.Data sl = new Service.Data();
        private DataTable DT = new DataTable();
        private string strCodCompañia = "";
        private string strNroContrato = "";
        public Frm_ListaConformidades()
        {
            InitializeComponent();
        }

        public void ShowMe(  string cCodCompañia,
                        string cNroContrato
                     )
        {
            //SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            //SplashScreenManager.Default.SetWaitFormDescription("Cargando Tablas...");
            strCodCompañia = cCodCompañia;
            strNroContrato = cNroContrato;
            this.Text = "Lista de conformdades del contrato: " + strNroContrato;

            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {

                DT = sl.reporte_Conformidad(strCodCompañia,
                                         strNroContrato
                        ).Tables[0];

            }

            this.Grd_mvto_Mayor_FuenteFinanciamiento.DataSource = DT;
            if (blnMuestraFormato == false)
            {
                this.FormatoGrid();
                this.blnMuestraFormato = true;
            }
            this.AdicionaImagenesGrilla();
            this.ShowDialog();
            //SplashScreenManager.CloseForm();

        }
        
        #region "Formato"
        private void FormatoGrid()
        {
            //Infragistics.Win.UltraWinGrid.UltraGridBand oBand;
            //Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn;
            this.Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("fImporteConformidad"))
                {
                    oBand.Summaries.Add("Sum_fImporteConformidad", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImporteConformidad"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImporteConformidad"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fImporteConformidad"].Appearance.TextHAlign = HAlign.Right;
                }
                if (oBand.Columns.Exists("fImporteRetencion"))
                {
                    oBand.Summaries.Add("Sum_fImporteRetencion", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImporteRetencion"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImporteRetencion"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fImporteRetencion"].Appearance.TextHAlign = HAlign.Right;
                }

                if (oBand.Columns.Exists("fImportePenalidad"))
                {
                    oBand.Summaries.Add("Sum_fImportePenalidad", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImportePenalidad"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImportePenalidad"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fImportePenalidad"].Appearance.TextHAlign = HAlign.Right;
                }

                if (oBand.Columns.Exists("fImporteGarantia"))
                {
                    oBand.Summaries.Add("Sum_fImporteGarantia", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImporteGarantia"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImporteGarantia"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fImporteGarantia"].Appearance.TextHAlign = HAlign.Right;
                }

                if (oBand.Columns.Exists("fImporteOtros"))
                {
                    oBand.Summaries.Add("Sum_fImporteOtros", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImporteOtros"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImporteOtros"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fImporteOtros"].Appearance.TextHAlign = HAlign.Right;
                }

                if (oBand.Columns.Exists("fSaldo"))
                {
                    oBand.Summaries.Add("Sum_fSaldo", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fSaldo"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fSaldo"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fSaldo"].Appearance.TextHAlign = HAlign.Right;
                }
            }

            this.Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default


            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Bands)
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
            oBand0 = this.Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Bands[0];

            oBand0.Columns[0].Header.Caption = "Conformidad";
            oBand0.Columns[0].Width = 110;
            oBand0.Columns[1].Header.Caption = "Fecha";
            oBand0.Columns[1].Width = 80;
            oBand0.Columns[2].Header.Caption = "Importe";
            oBand0.Columns[2].Width = 110;
            oBand0.Columns[3].Header.Caption = "Retención";
            oBand0.Columns[3].Width = 110;
            oBand0.Columns[4].Header.Caption = "Penalidad";
            oBand0.Columns[4].Width = 110;
            oBand0.Columns[5].Header.Caption = "Garantía";
            oBand0.Columns[5].Width = 110;
            oBand0.Columns[6].Header.Caption = "Otros";
            oBand0.Columns[6].Width = 110;
            oBand0.Columns[7].Header.Caption = "Saldo";
            oBand0.Columns[7].Width = 110;
        }
        #endregion

        private void AdicionaImagenesGrilla()
        {

            UltraGridBand band = this.Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Bands[0];

            foreach (UltraGridRow row in band.GetRowEnumerator(GridRowType.DataRow))
            {
                RefrescarCeldaGrilla(row);
            }

        }

        private void RefrescarCeldaGrilla(Infragistics.Win.UltraWinGrid.UltraGridRow oRow)
        {
            oRow.Cells[0].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            oRow.Cells[0].Appearance.Image = this.imageList2.Images[0];
            oRow.Cells[0].ButtonAppearance.Image = this.imageList2.Images[0];
            oRow.Cells[0].ButtonAppearance.TextHAlign = HAlign.Right;
        }

        private void Btn_Listar_Click(object sender, EventArgs e)
        {
            this.Exportar();
        }

        private void Exportar()
        {
            string strFile = "";
            if (this.SaveDocumento.ShowDialog() == DialogResult.OK)
            {
                strFile = this.SaveDocumento.FileName;
                DateTime start;
                TimeSpan timespan;

                start = DateTime.Now;

                try
                {
                    timespan = DateTime.Now.Subtract(start);

                    this.UltraGridExcelExporter1.Export(this.Grd_mvto_Mayor_FuenteFinanciamiento, strFile);

                }
                catch
                {
                    MessageBox.Show("Error", "Error");
                }
            }
        }

        private void Grd_mvto_Mayor_FuenteFinanciamiento_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            e.Layout.Override.FilterUIType = FilterUIType.FilterRow;

            FilterOperatorDropDownItems val = FilterOperatorDropDownItems.Contains;
            Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Override.FilterOperatorDropDownItems = val;

            FilterOperatorDefaultValue val1 = FilterOperatorDefaultValue.Contains;
            Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Override.FilterOperatorDefaultValue = val1;

            Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.ScrollStyle = ScrollStyle.Immediate;
            Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Scrollbars = Scrollbars.Both;
            Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.ColumnScrollbarSmallChange = 100;
            Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.UseScrollWindow = UseScrollWindow.None;
            // Turn off UseOsThemes to allow display of raw column header 
            this.Grd_mvto_Mayor_FuenteFinanciamiento.UseOsThemes = DefaultableBoolean.False;
        }

        private void Frm_ListaConformidades_Load(object sender, EventArgs e)
        {

        }

        private void Grd_mvto_Mayor_FuenteFinanciamiento_ClickCellButton(object sender, CellEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_mvto_Mayor_FuenteFinanciamiento.ActiveRow;
            if (e.Cell.Column.Index == 0)
            {
                string strNroConformidad = Convert.ToString(oRow.Cells[0].Value);
                WINlogistica.Frm_FormatoConformidad_Pantalla frm = new WINlogistica.Frm_FormatoConformidad_Pantalla();
                frm.ShowMe(strCodCompañia,
                            strNroContrato,
                            strNroConformidad
                          );
            }

        }
    }
}
