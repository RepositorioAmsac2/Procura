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
    public partial class Frm_ListaConsulta_PAC : Form
    {
        bool blnMarcarColumna = false;
        bool blnPintaFormato = true;
        private Service.Data sdl = new Service.Data();
        private Model.ProcesoLogistico_Modificado MPDM = new Model.ProcesoLogistico_Modificado();
        private Model.ProcesoLogistico_Insertado MPDI = new Model.ProcesoLogistico_Insertado();
        private Model.ProcesoLogistico_Eliminado MPDE = new Model.ProcesoLogistico_Eliminado();
        private string strVersionUltima = "";
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public Frm_ListaConsulta_PAC()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            this.MostrarRelacion();
        }

        private void MostrarRelacion()
        {
            string strAñoProceso = Convert.ToString(this.Cbo_PeriodoProceso.SelectedValue).Trim();
            string strVersion = Convert.ToString(this.Cbo_Version.SelectedValue);
            if (MyStuff.UsaWCF == true)
            {
                this.Grd_mvto_ItemPAC.DataSource = objWCF.Lista_Pac_Detalle(strAñoProceso, strVersion);
            }
            else
            {
                this.Grd_mvto_ItemPAC.DataSource = sdl.Lista_ProcesoLogistico_Detalle(strAñoProceso, strVersion);
            }

            if (blnPintaFormato)
            {
                this.FormatoGrid();
                blnPintaFormato = false;
            }
            MostrarIconoGrilla();
        }

        private void FormatoGrid()
        {
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
                foreach (Infragistics.Win.UltraWinGrid.UltraGridColumn  oColumn in oBand.Columns)
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
            oBand0.Columns[0].Header.Caption = "Incluido";
            oBand0.Columns[0].Width = 70;
            oBand0.Columns[1].Header.Caption = "Modificado";
            oBand0.Columns[1].Width = 70;
            oBand0.Columns[2].Header.Caption = "Excluido";
            oBand0.Columns[2].Width = 70;
            oBand0.Columns[3].Header.Caption = "Item del PAC";
            oBand0.Columns[3].Width = 100;
            oBand0.Columns[4].Header.Caption = "Procedimiento";
            oBand0.Columns[4].Width = 120;
            oBand0.Columns[5].Header.Caption = "Centro";
            oBand0.Columns[5].Width = 100;
            oBand0.Columns[6].Header.Caption = "Centro Gestor";
            oBand0.Columns[6].Width = 140;
            oBand0.Columns[7].Header.Caption = "Tipo de Proceso";
            oBand0.Columns[7].Width = 140;
            oBand0.Columns[8].Header.Caption = "Objeto de Contratación";
            oBand0.Columns[8].Width = 140;
            oBand0.Columns[9].Header.Caption = "Descripción";
            oBand0.Columns[9].Width = 200;
            oBand0.Columns[10].Header.Caption = "Cantidad";
            oBand0.Columns[10].Width = 60;
            oBand0.Columns[11].Header.Caption = "Moneda";
            oBand0.Columns[11].Width = 50;
            oBand0.Columns[12].Header.Caption = "Precio Estimado";
            oBand0.Columns[12].Width = 90;
            oBand0.Columns[13].Header.Caption = "Observación";
            oBand0.Columns[13].Width = 150;
            oBand0.Columns[14].Header.Caption = "Financia";
            oBand0.Columns[14].Width = 160;
            oBand0.Columns[15].Header.Caption = "Periodo";
            oBand0.Columns[15].Width = 80;
            oBand0.Columns[16].Header.Caption = "Tipo de Compra";
            oBand0.Columns[16].Width = 100;
            oBand0.Columns[17].Header.Caption = "Modalidad";
            oBand0.Columns[17].Width = 150;

            oBand0.Columns[18].Hidden = true;
            oBand0.Columns[19].Hidden = true;
            oBand0.Columns[20].Hidden = true;
            oBand0.Columns[21].Hidden = true;
            oBand0.Columns[22].Hidden = true;
        }

        private void MostrarIconoGrilla()
        {
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow oRow in this.Grd_mvto_ItemPAC.Rows)
            {

                if (Convert.ToInt32(oRow.Cells[20].Value) != 0)
                {
                    oRow.Cells[0].Appearance.Image = ImageList1.Images[0];
                    oRow.Cells[0].Appearance.ImageHAlign = HAlign.Left;
                    oRow.Cells[0].Appearance.TextHAlign = HAlign.Right;

                    oRow.Cells[0].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                    oRow.Cells[0].ButtonAppearance.ImageHAlign = HAlign.Left;
                    oRow.Cells[0].ButtonAppearance.Image = ImageList1.Images[0];
                }

                if (Convert.ToInt32(oRow.Cells[21].Value) != 0)
                {
                    oRow.Cells[1].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton;
                    oRow.Cells[1].Appearance.Image = ImageList1.Images[1];
                    oRow.Cells[1].Appearance.ImageHAlign = HAlign.Left;
                    oRow.Cells[1].Appearance.TextHAlign = HAlign.Right;
                    oRow.Cells[1].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                    oRow.Cells[1].ButtonAppearance.ImageHAlign = HAlign.Left;
                    oRow.Cells[1].ButtonAppearance.Image = ImageList1.Images[1];
                }

                if (Convert.ToInt32(oRow.Cells[22].Value) != 0)
                {
                    oRow.Cells[2].Appearance.Image = ImageList1.Images[2];
                    oRow.Cells[2].Appearance.ImageHAlign = HAlign.Left;
                    oRow.Cells[2].Appearance.TextHAlign = HAlign.Right;
                    oRow.Cells[2].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                    oRow.Cells[2].ButtonAppearance.ImageHAlign = HAlign.Left;
                    oRow.Cells[2].ButtonAppearance.Image = ImageList1.Images[2];
                }


            }
        }

        private void Frm_ListaConsulta_PAC_Load(object sender, EventArgs e)
        {
            if (MyStuff.UsaWCF == true)
            {
                this.Cbo_PeriodoProceso.CargaDT(objWCF.Combo_PeriodoProceso().Tables[0]);
            }
            else
            {
                this.Cbo_PeriodoProceso.CargaDT(sdl.Combo_PeriodoProceso().Tables[0]);
            }
            
            if (Convert.ToString(this.Cbo_PeriodoProceso.SelectedValue).Trim() != "")
            {
                if (MyStuff.UsaWCF == true)
                {
                    this.Cbo_Version.CargaDT(objWCF.Combo_Version(Convert.ToString(this.Cbo_PeriodoProceso.SelectedValue).Trim()).Tables[0]);
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

            if (MyStuff.InicioControlItem == true)
            {
                MyStuff.InicioControlItem = false;
                this.MostrarRelacion();
            }

        }

        private void Grd_mvto_ItemPAC_DoubleClickCell(object sender, Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs e)
        {
            try
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.Grd_mvto_ItemPAC.ActiveRow;
                string strCodPAC = Convert.ToString( oRow.Cells[3].Value );
                string strDescripcion = Convert.ToString(oRow.Cells[9].Value );
                int intIdPac_Detalle = Convert.ToInt32(oRow.Cells[18].Value);
                int intIdPac_Cabecera = Convert.ToInt32(oRow.Cells[19].Value);
                ShowPrograma(strCodPAC, strDescripcion, intIdPac_Detalle, intIdPac_Cabecera);

            }
            catch (Exception ex)
            {

            }
        }

        private void ShowPrograma(  string strCodPAC,
                                    string strDescripcion,
                                    int intIdPac_Detalle,
                                    int intIdPac_Cabecera
                                 )
            {

            Frm_ConsultaItemPAC frm = new Frm_ConsultaItemPAC();

            frm.ShowMe(intIdPac_Detalle,
                        this.Grd_mvto_ItemPAC,
                       false
                       );
        }

        private void Grd_mvto_ItemPAC_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
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

        private void Grd_mvto_ItemPAC_ClickCellButton(object sender, CellEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_mvto_ItemPAC.ActiveRow;


            if (e.Cell.Column.Index == 0)
            {
                if (Convert.ToInt32(oRow.Cells[20].Value) != 0)
                {
                    int intInsertado = Convert.ToInt32(oRow.Cells[20].Value);
                    if (MyStuff.UsaWCF == true)
                    {
                        MPDI = objWCF.Recupera_Pac_Insertado(intInsertado);
                    }
                    else
                    {
                        MPDI = sdl.Recupera_ProcesoLogistico_Insertado(intInsertado);
                    }
                    
                     MessageBox.Show(   "Aviso: El Item ha sido Incluido" + (char)(13) + (char)(13) +
                                        "Fecha          : " + Convert.ToString(MPDI.dFecInsertado) + (char)(13) +
                                        "Motivo         : " + Convert.ToString(MPDI.tMotInsertado) + (char)(13) +
                                        "Incluido    por: " + Convert.ToString(MPDI.vApeEmpleado)
                                    );
                }
            }
            else if (e.Cell.Column.Index == 1)
            {
                if (Convert.ToInt32(oRow.Cells[21].Value) != 0)
                {
                    int intModificado = Convert.ToInt32(oRow.Cells[21].Value);
                    if (MyStuff.UsaWCF == true)
                    {
                        MPDM = objWCF.Recupera_Pac_Modificado(intModificado);
                    }
                    else
                    {
                        MPDM = sdl.Recupera_ProcesoLogistico_Modificado(intModificado);
                    }
                    
                    MessageBox.Show("Aviso: El Item ha sido Incluido" + (char)(13) + (char)(13) +
                                       "Fecha          : " + Convert.ToString(MPDM.dFecModificado) + (char)(13) +
                                       "Motivo         : " + Convert.ToString(MPDM.tMotModificado) + (char)(13) +
                                       "Incluido    por: " + Convert.ToString(MPDM.vApeEmpleado)
                                   );
                }
            }
            else if (e.Cell.Column.Index == 2)
            {
                if (Convert.ToInt32(oRow.Cells[22].Value) != 0)
                {
                    int intEliminado = Convert.ToInt32(oRow.Cells[22].Value);
                    if (MyStuff.UsaWCF == true)
                    {
                        MPDE = objWCF.Recupera_Pac_Eliminado(intEliminado);
                    }
                    else
                    {
                        MPDE = sdl.Recupera_ProcesoLogistico_Eliminado(intEliminado);
                    }
                    
                    MessageBox.Show("Aviso: El Item ha sido Incluido" + (char)(13) + (char)(13) +
                                       "Fecha          : " + Convert.ToString(MPDE.dFecEliminado) + (char)(13) +
                                       "Motivo         : " + Convert.ToString(MPDE.tMotEliminado) + (char)(13) +
                                       "Incluido    por: " + Convert.ToString(MPDE.vApeEmpleado)
                                   );

                }
            }
        }

        private void Tsb_Exportar_Click(object sender, EventArgs e)
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

                    this.UltraGridExcelExporter1.Export(this.Grd_mvto_ItemPAC, strFile);

                }
                catch
                {
                    MessageBox.Show("Error", "Error");
                }
            }
        }
    }
}
