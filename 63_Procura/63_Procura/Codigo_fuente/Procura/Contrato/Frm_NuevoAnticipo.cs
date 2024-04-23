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
    public partial class Frm_NuevoAnticipo : Form
    {
        private bool blnMuestaFromato = true;
        private String strFecInicioActividad = "";
        public Frm_NuevoAnticipo()
        {
            InitializeComponent();
        }

        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
            string strCodCompañia = MyStuff.CodigoEmpresa;
            string strNumeroContrato = Convert.ToString(this.Txt_numContrato.Value);
            Service.Data SL = new Service.Data();
            Model.ContratoCabecera MCC = new Model.ContratoCabecera();
            MCC = SL.recupera_Contrato( strCodCompañia,
                                                  strNumeroContrato
                                                );

            this.Edt_DesContrato.Value = MCC.TDesContrato;
            this.Txt_MontoTotal.Value = MCC.FprecioUnitario_Local + MCC.Fimpuesto_Local;
            this.Dtp_FecInicio.Value = MCC.DFecSuscripcionContrato;
            this.Txt_DesTipoAdquisicion.Value = MCC.VDesObjetoContratacion;
            strFecInicioActividad = Convert.ToString(MCC.DFecSuscripcionContrato);

            if (MCC.bTieneMontosAdicionales == true)
            {
                this.Btn_Adicionales.Visible = true;
            }
            else
            {
                this.Btn_Adicionales.Visible = false;
            }

            this.Grd_Entregables.DataSource = SL.lista_ContratoAnticipo(  strCodCompañia,
                                                                            strNumeroContrato
                                                                         );
            if (blnMuestaFromato == true)
            {
                blnMuestaFromato = false;
                this.FormatoGrid();
            }
         }

        private void FormatoGrid()
        {
            //Infragistics.Win.UltraWinGrid.UltraGridBand oBand;
            //Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn;
            this.Grd_Entregables.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_Entregables.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Entregables.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("fBaseImponible"))
                {
                    oBand.Summaries.Add("Sum_fBaseImponible", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fBaseImponible"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fBaseImponible"].DisplayFormat = "{0:#,###,###,###,###}";
                    oBand.Summaries["Sum_fBaseImponible"].Appearance.TextHAlign = HAlign.Right;
                }
                if (oBand.Columns.Exists("fImpuesto"))
                {
                    oBand.Summaries.Add("Sum_fImpuesto", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImpuesto"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImpuesto"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fImpuesto"].Appearance.TextHAlign = HAlign.Right;
                }
                if (oBand.Columns.Exists("fMontoTotal"))
                {
                    oBand.Summaries.Add("Sum_fMontoTotal", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fMontoTotal"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fMontoTotal"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fMontoTotal"].Appearance.TextHAlign = HAlign.Right;
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
            oBand0.Columns[1].Header.Caption = "Anticipo";
            oBand0.Columns[1].Width = 100;
            oBand0.Columns[2].Header.Caption = "Descripción del anticipo";
            oBand0.Columns[2].Width = 300;
            oBand0.Columns[3].Header.Caption = "Fecha anticipo";
            oBand0.Columns[3].Width = 80;
            oBand0.Columns[5].Header.Caption = "Tipo Anticipo";
            oBand0.Columns[5].Width = 140;
            oBand0.Columns[7].Header.Caption = "T_Doc.";
            oBand0.Columns[7].Width = 40;
            oBand0.Columns[8].Header.Caption = "Documento";
            oBand0.Columns[8].Width = 80;
            oBand0.Columns[9].Header.Caption = "Fecha";
            oBand0.Columns[9].Width = 80;
            oBand0.Columns[10].Header.Caption = "Sub-Total";
            oBand0.Columns[10].Width = 110;
            oBand0.Columns[12].Header.Caption = "Impuesto";
            oBand0.Columns[12].Width = 110;
            oBand0.Columns[13].Header.Caption = "Total";
            oBand0.Columns[13].Width = 110;
            oBand0.Columns[16].Header.Caption = "Garantía";
            oBand0.Columns[16].Width = 110;

            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[4].Hidden = true;
            oBand0.Columns[6].Hidden = true;
            oBand0.Columns[11].Hidden = true;
            oBand0.Columns[14].Hidden = true;
            oBand0.Columns[15].Hidden = true;
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

        private void Btn_NuevoAdicional_Click(object sender, EventArgs e)
        {
            string strCodCompañia = MyStuff.CodigoEmpresa;
            string strNroContrato = Convert.ToString(this.Txt_numContrato.Value);

            WINlogistica.Frm_NuevoAnticipo_D frm = new WINlogistica.Frm_NuevoAnticipo_D();
            frm.ShowMe(strCodCompañia,
                        strNroContrato,
                        Grd_Entregables
                      );

        }

        private void Btn_Busqueda_Click(object sender, EventArgs e)
        {
            WINlogistica.Frm_Ayuda_Contrato frm = new WINlogistica.Frm_Ayuda_Contrato();
            frm.ShowMe(MyStuff.CodigoEmpresa);
            if (frm.blnEligio == true)
            {
                this.Txt_numContrato.Value = frm.strCodContrato;
            }
        }
    }
}
