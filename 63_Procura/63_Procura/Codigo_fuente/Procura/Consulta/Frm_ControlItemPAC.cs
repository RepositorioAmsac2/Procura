using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
//using Microsoft.VisualBasic.Devices;

using Infragistics.Win.UltraWinGrid.ExcelExport;

using Infragistics.Shared;
using Infragistics.Win.UltraWinEditors;

namespace WINlogistica
{
    public partial class Frm_ControlItemPAC : Form
    {
        //private bool blnMarcarColumna = false;
        private bool blnPintaFormato = true;

        private Model.ParametroLogistica MPL = new Model.ParametroLogistica();
        private Service.Data sdl = new Service.Data();

        private Model.Empleado ME = new Model.Empleado();

        private string strVersionUltima = "";
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public Frm_ControlItemPAC()
        {
            InitializeComponent();
        }

        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
            this.MostrarRelacion();
        }

        private void MostrarRelacion()
        {
            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_ApeOperadorLogistico.Value)))
            {
                MessageBox.Show("Debe Ingresar un Operador Logistico");
            }
            else
            {
                string strAñoProceso = Convert.ToString(this.Cbo_PeriodoProceso.SelectedValue).Trim();
                string strVersion = Convert.ToString(this.Cbo_Version.SelectedValue);

                string strCodOperadorLogistico = Convert.ToString(this.Txt_CodOperadorLogistico.Value);
                if (MyStuff.UsaWCF == true)
                {
                    this.Grd_mvto_ItemPAC.DataSource = objWCF.Lista_Pac_Detalle_PorOperadorLogistico(strAñoProceso, strVersion, strCodOperadorLogistico);
                }
                else
                {
                    this.Grd_mvto_ItemPAC.DataSource = sdl.Lista_ProcesoLogistico_Detalle_PorOperadorLogistico(strAñoProceso, strVersion, strCodOperadorLogistico);
                }

                if (blnPintaFormato)
                {
                    this.FormatoGrid();
                    blnPintaFormato = false;
                }
                MostrarIconoGrilla();
            }
        }

        private void InicioProceso()
        {
            this.Cbo_PeriodoProceso.CargaDT(sdl.Combo_PeriodoProceso().Tables[0]);
            if (Convert.ToString(this.Cbo_PeriodoProceso.SelectedValue).Trim() != "")
            {
                if (MyStuff.UsaWCF == true)
                {
                }
                else
                {
                    this.Cbo_Version.CargaDT(sdl.Combo_Version(Convert.ToString(this.Cbo_PeriodoProceso.SelectedValue).Trim()).Tables[0]);
                }

            }
            else
            {
                if (MyStuff.UsaWCF == true)
                {
                    this.Cbo_Version.CargaDT(objWCF.Combo_Version(Convert.ToString(MyStuff.AñoProceso).TrimEnd()).Tables[0]);
                }
                else
                {
                    this.Cbo_Version.CargaDT(sdl.Combo_Version(Convert.ToString(MyStuff.AñoProceso).TrimEnd()).Tables[0]);
                }

            }

            strVersionUltima = Convert.ToString(this.Cbo_Version.SelectedValue);
            if (MyStuff.UsaWCF == true)
            {
                MPL = objWCF.Recupera_ParametroLogistica_Codigo(MyStuff.CodigoEmpleado);
            }
            else
            {
                MPL = sdl.Recupera_ParametroLogistica_Codigo(MyStuff.CodigoEmpleado);
            }

            if (MPL.vValParametroLogistica.Trim() == "")
            {
                this.Txt_CodOperadorLogistico.Value = MyStuff.CodigoEmpleado;
                this.verOperadorLogistico(MyStuff.CodigoEmpleado);
                this.Txt_CodOperadorLogistico.Enabled = false;
            }
            else
            {
                this.Txt_CodOperadorLogistico.nombreDS = sdl.Ayuda_OperadorLogistico_Jefatura(MyStuff.CodigoEmpleado);
                this.Txt_CodOperadorLogistico.Enabled = true;
            }
        }

        private void Frm_ControlItemPAC_Load(object sender, EventArgs e)
        {
            this.InicioProceso();
            if (MyStuff.InicioControlItem == true)
            {
                MyStuff.InicioControlItem = false;
                this.MostrarRelacion();
            }
        }

        private void verOperadorLogistico(string strCodOperadorLogistico)
        {
            if (MyStuff.UsaWCF == true)
            {
                ME = objWCF.Recupera_Empleado_Codigo(strCodOperadorLogistico);
            }
            else
            {
                ME = sdl.Recupera_Empleado_Codigo(strCodOperadorLogistico);
            }
            
            if (ME.CCodPersonal.TrimEnd() == "")
            {
                this.Txt_ApeOperadorLogistico.Value = "";
            }
            else
            {
                this.Txt_ApeOperadorLogistico.Value = ME.VApePersonal;
            }
            
        }

        private void Txt_CodOperadorLogistico_Leave(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty( Convert.ToString( this.Txt_CodOperadorLogistico.Value ) ) )
            {
                this.Txt_ApeOperadorLogistico.Value = "";
            }
            else
            {
                this.verOperadorLogistico(Convert.ToString(this.Txt_CodOperadorLogistico.Value));
            }
        }


        private void FormatoGrid()
        {
            //Infragistics.Win.UltraWinGrid.UltraGridBand oBand;
            //Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn;
            this.Grd_mvto_ItemPAC.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_mvto_ItemPAC.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_mvto_ItemPAC.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("fPrecioEstimado"))
                {
                    oBand.Summaries.Add("Sum_PrecioEstimado", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fPrecioEstimado"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_PrecioEstimado"].DisplayFormat = "{0:#,###,###.00}";
                    oBand.Summaries["Sum_PrecioEstimado"].Appearance.TextHAlign = HAlign.Right;
                }
                if (oBand.Columns.Exists("fCantidad"))
                {
                    oBand.Summaries.Add("Sum_Cantidad", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fCantidad"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_Cantidad"].DisplayFormat = "{0:#,###,###.00}";
                    oBand.Summaries["Sum_Cantidad"].Appearance.TextHAlign = HAlign.Right;
                }
            }
            this.Grd_mvto_ItemPAC.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default


            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_mvto_ItemPAC.DisplayLayout.Bands)
            {
                foreach (Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn in oBand.Columns)
                {
                    if (oColumn.DataType.ToString() == "System.Double")
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

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.Grd_mvto_ItemPAC.DisplayLayout.Bands[0];
            oBand0.Columns[0].Header.Caption = " ";
            oBand0.Columns[0].Width = 20;
            oBand0.Columns[1].Header.Caption = " ";
            oBand0.Columns[1].Width = 20;
            oBand0.Columns[2].Header.Caption = "Avance (%)";
            oBand0.Columns[2].Width = 110;
            oBand0.Columns[3].Header.Caption = "Item";
            oBand0.Columns[3].Width = 50;
            oBand0.Columns[4].Header.Caption = "Procedimiento";
            oBand0.Columns[4].Width = 120;
            oBand0.Columns[5].Header.Caption = "Centro";
            oBand0.Columns[5].Width = 100;
            oBand0.Columns[6].Header.Caption = "Centro Gestor";
            oBand0.Columns[6].Width = 140;
            oBand0.Columns[7].Header.Caption = "Observación";
            oBand0.Columns[7].Width = 150;
            oBand0.Columns[8].Header.Caption = "Tipo de Proceso";
            oBand0.Columns[8].Width = 140;
            oBand0.Columns[9].Header.Caption = "Objeto de Contratación";
            oBand0.Columns[9].Width = 140;
            oBand0.Columns[10].Header.Caption = "Descripción";
            oBand0.Columns[10].Width = 200;
            oBand0.Columns[11].Header.Caption = "Cantidad";
            oBand0.Columns[11].Width = 60;
            oBand0.Columns[12].Header.Caption = "Precio Estimado";
            oBand0.Columns[12].Width = 90;
            oBand0.Columns[13].Header.Caption = "Moneda";
            oBand0.Columns[13].Width = 50;
            oBand0.Columns[14].Header.Caption = "Financia";
            oBand0.Columns[14].Width = 160;
            oBand0.Columns[15].Header.Caption = "Periodo";
            oBand0.Columns[15].Width = 80;
            oBand0.Columns[16].Header.Caption = "Tipo de Compra";
            oBand0.Columns[16].Width = 100;
            oBand0.Columns[17].Header.Caption = "Modalidad";
            oBand0.Columns[17].Width = 150;

            oBand0.Columns[7].Hidden = true;
            oBand0.Columns[18].Hidden = true;
            oBand0.Columns[19].Hidden = true;
            oBand0.Columns[20].Hidden = true;
            oBand0.Columns[21].Hidden = true;
            oBand0.Columns[22].Hidden = true;
            oBand0.Columns[23].Hidden = true;
            oBand0.Columns[24].Hidden = true;
            oBand0.Columns[25].Hidden = true;
            oBand0.Columns[26].Hidden = true;
            oBand0.Columns[27].Hidden = true;
        }

        private void Grd_mvto_ItemPAC_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            e.Layout.Override.FilterUIType = FilterUIType.FilterRow;
            e.Layout.Override.FilterEvaluationTrigger = FilterEvaluationTrigger.OnCellValueChange;
            e.Layout.Override.FilterOperatorLocation = FilterOperatorLocation.WithOperand;
            e.Layout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.StartsWith;
            e.Layout.Override.FilterClearButtonLocation = FilterClearButtonLocation.RowAndCell;
            e.Layout.Override.FilterRowAppearance.BackColor = Color.LightYellow;
            //e.Layout.Override.FilterRowPrompt = "Click here to filter data..."
            e.Layout.Override.FilterRowPromptAppearance.BackColorAlpha = Alpha.Opaque;
            e.Layout.Override.SpecialRowSeparator = SpecialRowSeparator.FilterRow;
            e.Layout.Override.SpecialRowSeparatorAppearance.BackColor = Color.FromArgb(233, 242, 199);
            e.Layout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
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

                    this.UltraGridExcelExporter1.Export(this.Grd_mvto_ItemPAC, strFile);

                }
                catch 
                {
                    MessageBox.Show("Error", "Error");
                }
            }
        }

        private void tsb_Exportar_Click(object sender, EventArgs e)
        {
            this.Exportar();
        }

        private void Grd_mvto_ItemPAC_DoubleClickCell(object sender, DoubleClickCellEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_mvto_ItemPAC.ActiveRow;
            double dblPorcentaje = Convert.ToDouble(oRow.Cells[2].Value);
            if (dblPorcentaje>0)
            {
                string strCodPAC = oRow.Cells[3].Text;
                string strDescripcion = oRow.Cells[9].Text;
                int intIdPac_Detalle = Convert.ToInt32(oRow.Cells[18].Value);
                int intIdPac_Cabecera = Convert.ToInt32(oRow.Cells[19].Value);
                ShowPrograma(intIdPac_Detalle);
            }
            else
            {
                MessageBox.Show("El Item no ha sido aperturado, No tiene requerimiento",
                                 "Advertencia",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation
                                );
            }
            
        }

        private void MostrarIconoGrilla()
        {
            //Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow  oRow in this.Grd_mvto_ItemPAC.Rows)
            {


                //oRow.Cells(8).Appearance.TextHAlign = HAlign.Right
                if (Convert.ToInt32(oRow.Cells[20].Value) != 0)
                {
                    oRow.Cells[0].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                    oRow.Cells[0].Appearance.Image = this.imageList1.Images[1];
                    oRow.Cells[0].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                    oRow.Cells[0].ButtonAppearance.Image = this.imageList1.Images[1];
                }

                if (Convert.ToInt32(oRow.Cells[21].Value) != 0)
                {
                    oRow.Cells[1].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                    oRow.Cells[1].Appearance.Image = this.imageList1.Images[0];
                    oRow.Cells[1].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                    oRow.Cells[1].ButtonAppearance.Image = this.imageList1.Images[0];
                }

                if (Convert.ToString(oRow.Cells[25].Value) != "XX")
                {
                    if (Convert.ToString(oRow.Cells[25].Value) == "SI")
                    {
                        oRow.Cells[2].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                        oRow.Cells[2].Appearance.Image = this.imageList1.Images[4];
                        oRow.Cells[2].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                        oRow.Cells[2].ButtonAppearance.Image = this.imageList1.Images[4];
                    }
                    else
                    {
                        oRow.Cells[2].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                        oRow.Cells[2].Appearance.Image = this.imageList1.Images[3];
                        oRow.Cells[2].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                        oRow.Cells[2].ButtonAppearance.Image = this.imageList1.Images[3];
                    }
                }

            }
        }

        private void Grd_mvto_ItemPAC_ClickCellButton(object sender, CellEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_mvto_ItemPAC.ActiveRow;


            if (e.Cell.Column.Index == 0)
            {
                if (Convert.ToInt32(oRow.Cells[20].Value) != 0)
                {
                    //' Pintar formulario de eliminacion
                }
            }
            else if (e.Cell.Column.Index == 1)
            {
                if (Convert.ToInt32(oRow.Cells[21].Value) != 0)
                {
                    //' Pintar formulario de eliminacion
                }
            }
        }

        private void ShowPrograma(int intIdPac_Detalle)
        {
            Frm_ConsultaItemPAC frm = new Frm_ConsultaItemPAC();

            frm.ShowMe(intIdPac_Detalle,
                        this.Grd_mvto_ItemPAC,
                       true
                       );
        }

        private void Cbo_PeriodoProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Cbo_PeriodoProceso.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                if (Convert.ToString(this.Cbo_PeriodoProceso.SelectedValue).Trim() != "")
                {
                    this.Cbo_Version.CargaDT( sdl.Combo_Version(Convert.ToString(this.Cbo_PeriodoProceso.SelectedValue).Trim()).Tables[0]);
                }
                else
                {
                    this.Cbo_Version.CargaDT(sdl.Combo_Version(Convert.ToString(MyStuff.AñoProceso).Trim()).Tables[0]);
                }
            }
        }

        private void Btn_AperturaCierre_paso_Click(object sender, EventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_mvto_ItemPAC.ActiveRow;
            string strNumProcedimiento = Convert.ToString(oRow.Cells[4].Value);

            Frm_ActualizaPasoPAC frm = new Frm_ActualizaPasoPAC();
            frm.ShowMe(strNumProcedimiento, 0);

        }

        private void Btn_Gantt_Click(object sender, EventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_mvto_ItemPAC.ActiveRow;
            string strAñoProceso = Convert.ToString(this.Cbo_PeriodoProceso.SelectedValue);
            string strVersion = Convert.ToString(this.Cbo_Version.SelectedValue);
            string strNumProcedimiento = Convert.ToString(oRow.Cells[4].Value);
            string strDescripcion = Convert.ToString(oRow.Cells[10].Value);

            WINlogistica.Frm_AvanceItemPac_Gantt_Grafico frm = new WINlogistica.Frm_AvanceItemPac_Gantt_Grafico();
            frm.ShowMe( strDescripcion,
                        strAñoProceso,
                        strVersion,
                        strNumProcedimiento
                      );
        }

        private void Grd_mvto_ItemPAC_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_mvto_ItemPAC.ActiveRow;

            if (oRow.Cells[2].Value != null )
            {
                double dblPorcentaje = Convert.ToDouble(oRow.Cells[2].Value);
                //MessageBox.Show(Convert.ToString( dblPorcentaje) );
                if (dblPorcentaje > 0.0)
                {
                    this.Btn_AperturaCierre_paso.Visible = true;
                    this.Btn_Separador01.Visible = true;
                    this.Btn_Gantt.Visible = true;
                }
                else
                {
                    this.Btn_AperturaCierre_paso.Visible = false;
                    this.Btn_Separador01.Visible = false;
                    this.Btn_Gantt.Visible = false;
                }

            }

        }
    }
}
