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
    public partial class Frm_ConsultaContrato : Form
    {
        private bool blnMuestaFromato = true;
        private String strFecInicioActividad = "";
        public Frm_ConsultaContrato()
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
            //this.Txt_MontoTotal.Value = MCC.FMontoTotal;
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

            this.Grd_InicioActividad.DataSource = SL.lista_ContratoInicioActividad(strCodCompañia,
                                                                            strNumeroContrato
                                                                         );
            DataSet DS_Entregable = new DataSet();
            DS_Entregable = SL.lista_EntregableCabecera(strCodCompañia,
                                                                            strNumeroContrato
                                                                         );
            this.Grd_Entregable.DataSource = DS_Entregable;

            this.Grd_Garantia.DataSource = SL.lista_ContratoGarantia(  strCodCompañia,
                                                                            strNumeroContrato
                                                                         );

            this.Grd_Anticipo.DataSource = SL.lista_ContratoAnticipo(strCodCompañia,
                                                                            strNumeroContrato
                                                                         );

            this.Grd_Adenda.DataSource = SL.lista_ContratoAdicional(strCodCompañia,
                                                                            strNumeroContrato
                                                                         );
            if (blnMuestaFromato == true)
            {
                blnMuestaFromato = false;
                this.FormatoGrid_InicioActividad();
                this.FormatoGrid_Entregable();
                this.FormatoGrid_Garantia();
                this.FormatoGrid_Anticipo();
                this.FormatoGrid_Adenda();
            }
         }

        private void FormatoGrid_InicioActividad()
        {
            this.Grd_InicioActividad.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_InicioActividad.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;



            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.Grd_InicioActividad.DisplayLayout.Bands[0];
            oBand0 = this.Grd_InicioActividad.DisplayLayout.Bands[0];
            oBand0.Columns[1].Header.Caption = "F.Inicio";
            oBand0.Columns[1].Width = 100;
            oBand0.Columns[2].Header.Caption = "Nota";
            oBand0.Columns[2].Width = 500;

            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[3].Hidden = true;

        }
        private void FormatoGrid_Entregable()
        {
            this.Grd_Entregable.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_Entregable.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Entregable.DisplayLayout.Bands)
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
            this.Grd_Entregable.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default


            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Entregable.DisplayLayout.Bands)
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
            oBand0 = this.Grd_Entregable.DisplayLayout.Bands[0];
            oBand0 = this.Grd_Entregable.DisplayLayout.Bands[0];
            oBand0.Columns[1].Header.Caption = "Entregable";
            oBand0.Columns[1].Width = 100;
            oBand0.Columns[2].Header.Caption = "Adenda";
            oBand0.Columns[2].Width = 120;
            oBand0.Columns[3].Header.Caption = "Descripción Entregable";
            oBand0.Columns[3].Width = 500;
            oBand0.Columns[5].Header.Caption = "Dias";
            oBand0.Columns[5].Width = 50;
            oBand0.Columns[6].Header.Caption = "Inicio";
            oBand0.Columns[6].Width = 100;
            oBand0.Columns[7].Header.Caption = "Final";
            oBand0.Columns[7].Width = 100;
            oBand0.Columns[9].Header.Caption = "Factor%";
            oBand0.Columns[9].Width = 80;
            oBand0.Columns[10].Header.Caption = "Importe";
            oBand0.Columns[10].Width = 120;

            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[4].Hidden = true;
            oBand0.Columns[8].Hidden = true;
        }
        private void FormatoGrid_Garantia()
        {
            //Infragistics.Win.UltraWinGrid.UltraGridBand oBand;
            //Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn;
            this.Grd_Garantia.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_Garantia.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Garantia.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("fMontoTotal"))
                {
                    oBand.Summaries.Add("Sum_fMontoTotal", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fMontoTotal"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fMontoTotal"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fMontoTotal"].Appearance.TextHAlign = HAlign.Right;
                }
            }
            this.Grd_Garantia.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default


            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Garantia.DisplayLayout.Bands)
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
            oBand0 = this.Grd_Garantia.DisplayLayout.Bands[0];
            oBand0 = this.Grd_Garantia.DisplayLayout.Bands[0];
            oBand0.Columns[1].Header.Caption = "Garantia";
            oBand0.Columns[1].Width = 100;
            oBand0.Columns[2].Header.Caption = "Descripción de la garantía";
            oBand0.Columns[2].Width = 320;
            oBand0.Columns[3].Header.Caption = "Fecha";
            oBand0.Columns[3].Width = 80;
            oBand0.Columns[4].Header.Caption = "Tipo Garantia";
            oBand0.Columns[4].Width = 140;
            oBand0.Columns[6].Header.Caption = "Clase Garantia";
            oBand0.Columns[6].Width = 140;
            oBand0.Columns[8].Header.Caption = "Entidad Financiera";
            oBand0.Columns[8].Width = 140;
            oBand0.Columns[10].Header.Caption = "Importe";
            oBand0.Columns[10].Width = 120;
            oBand0.Columns[11].Header.Caption = "Inicio";
            oBand0.Columns[11].Width = 80;
            oBand0.Columns[12].Header.Caption = "Final";
            oBand0.Columns[12].Width = 80;

            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[5].Hidden = true;
            oBand0.Columns[7].Hidden = true;
            oBand0.Columns[9].Hidden = true;
        }
        private void FormatoGrid_Anticipo()
        {
            //Infragistics.Win.UltraWinGrid.UltraGridBand oBand;
            //Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn;
            this.Grd_Anticipo.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_Anticipo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Anticipo.DisplayLayout.Bands)
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
            this.Grd_Anticipo.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default


            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Anticipo.DisplayLayout.Bands)
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
            oBand0 = this.Grd_Anticipo.DisplayLayout.Bands[0];
            oBand0 = this.Grd_Anticipo.DisplayLayout.Bands[0];
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

        private void FormatoGrid_Adenda()
        {
            //Infragistics.Win.UltraWinGrid.UltraGridBand oBand;
            //Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn;
            this.Grd_Adenda.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_Adenda.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Adenda.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("IdiasDuracion"))
                {
                    oBand.Summaries.Add("Sum_IdiasDuracion", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["IdiasDuracion"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_IdiasDuracion"].DisplayFormat = "{0:#,###,###,###,###}";
                    oBand.Summaries["Sum_IdiasDuracion"].Appearance.TextHAlign = HAlign.Right;
                }
                if (oBand.Columns.Exists("FImporte"))
                {
                    oBand.Summaries.Add("Sum_FImporte", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["FImporte"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_FImporte"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_FImporte"].Appearance.TextHAlign = HAlign.Right;
                }
            }
            this.Grd_Adenda.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default


            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Adenda.DisplayLayout.Bands)
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
            oBand0 = this.Grd_Adenda.DisplayLayout.Bands[0];
            oBand0 = this.Grd_Adenda.DisplayLayout.Bands[0];
            oBand0.Columns[1].Header.Caption = "Adicional";
            oBand0.Columns[1].Width = 100;
            oBand0.Columns[2].Header.Caption = "Descripción del adicional";
            oBand0.Columns[2].Width = 500;
            oBand0.Columns[3].Header.Caption = "Fecha";
            oBand0.Columns[3].Width = 100;
            oBand0.Columns[5].Header.Caption = "Tipo Adicional";
            oBand0.Columns[5].Width = 180;
            oBand0.Columns[6].Header.Caption = "Entregable";
            oBand0.Columns[6].Width = 100;
            oBand0.Columns[7].Header.Caption = "Dias";
            oBand0.Columns[7].Width = 80;
            oBand0.Columns[8].Header.Caption = "Importe";
            oBand0.Columns[8].Width = 120;

            oBand0.Columns[0].Hidden = true;
            //oBand0.Columns[3].Hidden = true;
            oBand0.Columns[4].Hidden = true;
        }

        private void Frm_ConsultaContrato_Load(object sender, EventArgs e)
        {

        }
    }
}
