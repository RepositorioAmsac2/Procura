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
    public partial class Frm_AyudaEntregable : Form
    {
        public Frm_AyudaEntregable()
        {
            InitializeComponent();
        }
        public string strNroEntregable = "";
        public string strDesEntregable = "";
        public double dblFactor = 0.0;
        public double dblImporte = 0.0;
        public DateTime dateFecha = DateTime.Now;
        public int intDiasTotal = 0;
        public bool blnEligio = false;
        public void ShowMe( string strCodCompañia,
                            string strNroContrato,
                            string strDesContrato,
                            double dblImporteContrato
                          )
        {
            this.Txt_numContrato.Value = strNroContrato;
            this.Edt_DesContrato.Value = strDesContrato;
            this.Txt_MontoTotal.Value = dblImporteContrato;

            Service.Data SL = new Service.Data();

            this.Grd_Entregables.DataSource = SL.ayuda_EntregableCabecera(strCodCompañia,
                                                                            strNroContrato
                                                                         );
            this.FormatoGrid();
            this.RecorreImagenesGrillaEnviados();
            this.ShowDialog();
        }

        private void FormatoGrid()
        {
            //Infragistics.Win.UltraWinGrid.UltraGridBand oBand;
            //Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn;
            this.Grd_Entregables.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_Entregables.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Entregables.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("IdiasDuracion"))
                {
                    oBand.Summaries.Add("Sum_IdiasDuracion", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["IdiasDuracion"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_IdiasDuracion"].DisplayFormat = "{0:#,###,###,###,###}";
                    oBand.Summaries["Sum_IdiasDuracion"].Appearance.TextHAlign = HAlign.Right;
                }
                if (oBand.Columns.Exists("FFactor"))
                {
                    oBand.Summaries.Add("Sum_FFactor", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["FFactor"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_FFactor"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_FFactor"].Appearance.TextHAlign = HAlign.Right;
                }
                if (oBand.Columns.Exists("FImporte"))
                {
                    oBand.Summaries.Add("Sum_FImporte", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["FImporte"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_FImporte"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_FImporte"].Appearance.TextHAlign = HAlign.Right;
                }
            }
            this.Grd_Entregables.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default


            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Entregables.DisplayLayout.Bands)
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
            oBand0 = this.Grd_Entregables.DisplayLayout.Bands[0];
            oBand0 = this.Grd_Entregables.DisplayLayout.Bands[0];
            oBand0.Columns[1].Header.Caption = "Entregable";
            oBand0.Columns[1].Width = 80;
            oBand0.Columns[2].Header.Caption = "Adenda";
            oBand0.Columns[2].Width = 120;
            oBand0.Columns[3].Header.Caption = "Descripción Entregable";
            oBand0.Columns[3].Width = 380;
            oBand0.Columns[5].Header.Caption = "Dias";
            oBand0.Columns[5].Width = 40;
            oBand0.Columns[6].Header.Caption = "Inicio";
            oBand0.Columns[6].Width = 75;
            oBand0.Columns[7].Header.Caption = "Final";
            oBand0.Columns[7].Width = 75;
            oBand0.Columns[9].Header.Caption = "Factor%";
            oBand0.Columns[9].Width = 50;
            oBand0.Columns[10].Header.Caption = "Importe";
            oBand0.Columns[10].Width = 110;
            oBand0.Columns[11].Header.Caption = "Conformidad";
            oBand0.Columns[11].Width = 110;

            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[4].Hidden = true;
            oBand0.Columns[8].Hidden = true;
            oBand0.Columns[12].Hidden = true;
        }

        private void RecorreImagenesGrillaEnviados()
        {
            foreach (UltraGridRow oRow in this.Grd_Entregables.Rows)
            {
                RefrescarCeldaGrillaEnviados(oRow);
            }
        }

        private void RefrescarCeldaGrillaEnviados(UltraGridRow oRow)
        {

            if (string.IsNullOrEmpty(Convert.ToString(oRow.Cells[2].Value).TrimEnd()) == false)
            {
                oRow.Cells[2].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                oRow.Cells[2].Appearance.Image = imageList1.Images[0];
                oRow.Cells[2].ButtonAppearance.Image = imageList1.Images[0];
                oRow.Cells[2].ButtonAppearance.TextHAlign = HAlign.Right;
            }
        }


        private void ultraNumericEditor1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Ajuste_B_Click(object sender, EventArgs e)
        {

        }

        private void Frm_NuevoEntregable_Load(object sender, EventArgs e)
        {

        }

        private void Grd_Entregables_DoubleClick(object sender, EventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_Entregables.ActiveRow;
            string strNroConformidad = Convert.ToString(oRow.Cells[11].Value);
            if (string.IsNullOrEmpty(strNroConformidad.TrimEnd()) )
            {
                dblImporte = Convert.ToDouble(oRow.Cells[10].Value);
                if (dblImporte > 0)
                {
                    strNroEntregable = Convert.ToString(oRow.Cells[1].Value);
                    strDesEntregable = Convert.ToString(oRow.Cells[3].Value);
                    dblFactor = Convert.ToDouble(oRow.Cells[9].Value);

                    dateFecha = Convert.ToDateTime(oRow.Cells[7].Value);
                    intDiasTotal = Convert.ToInt32(oRow.Cells[12].Value);
                    blnEligio = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El entrgable elegido NO tiene importe que pagar");
                }
            }
            else
            {
                MessageBox.Show("El Entregable elegido ya tiene conformidad");
            }

        }
    }
}
