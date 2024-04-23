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
    public partial class Frm_AperturaProceso_Ceges : Form
    {
        bool blnMarcarColumna = false;
        bool blnPintaFormato = true;
        private Service.Data sdl = new Service.Data();


        private Model.ProcesoLogistico_Modificado MPDM = new Model.ProcesoLogistico_Modificado();
        private Model.ProcesoLogistico_Insertado MPDI = new Model.ProcesoLogistico_Insertado();
        private Model.ProcesoLogistico_Eliminado MPDE = new Model.ProcesoLogistico_Eliminado();

        private DataSet DS_CentroGestor = new DataSet();

        private WINlogistica.Framework FS = new WINlogistica.Framework();

        private string strVersionUltima = "";
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public Frm_AperturaProceso_Ceges()
        {
            InitializeComponent();
        }

        private void Frm_AperturaProceso_Ceges_Load(object sender, EventArgs e)
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

            string strCodCentroGestor = MyStuff.CodigoCentroGestorSuperior;
            if (MyStuff.UsaWCF == true)
            {
                //jesusDS_CentroGestor = objWCF.Ayuda_Proyecto_CentroGestor(MyStuff.CodigoCentroGestorSuperior, MyStuff.DigitoCentroGestor, "XX");
            }
            else
            {
                DS_CentroGestor = sdl.Ayuda_ProcesoLogistico_CentroGestor(MyStuff.CodigoCentroGestorSuperior, MyStuff.CodigoEmpleado);
            }
            this.Txt_CodCeges.Value = MyStuff.CodigoCentroGestor;
            this.Txt_DesCeGes.Value = MyStuff.NombreCentroGestor;

            this.Txt_CodCeges.nombreDS = DS_CentroGestor;
            if (DS_CentroGestor.Tables[0].Rows.Count > 1)
            {
                this.Txt_CodCeges.Enabled = true;
            }
            else
            {
                this.Txt_CodCeges.Enabled = false;
                //this.Txt_CodCeges.Value = Convert.ToString(DS_CentroGestor.Tables[0].Rows[0][0]);
                //this.Txt_DesCeGes.Value = Convert.ToString(DS_CentroGestor.Tables[0].Rows[0][1]);
            }

            if (MyStuff.InicioControlItem == true)
            {
                MyStuff.InicioControlItem = false;
                this.MostrarRelacion();
            }

        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            this.MostrarRelacion();
        }

        private void MostrarRelacion()
        {
            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_DesCeGes.Value)))
            {
                MessageBox.Show("Debe Digitar el Centro Gestor");
                this.Txt_CodCeges.Focus();
            }
            else
            {
                string strAñoProceso = Convert.ToString(this.Cbo_PeriodoProceso.SelectedValue).Trim();
                string strVersion = Convert.ToString(this.Cbo_Version.SelectedValue);
                string strCodCeges = Convert.ToString(this.Txt_CodCeges.Value);

                if (MyStuff.UsaWCF == true)
                {
                    this.grd_mvto_Activo.DataSource = objWCF.Lista_Pac_Detalle_PorCeges(strAñoProceso, strVersion, strCodCeges);
                }
                else
                {
                    this.grd_mvto_Activo.DataSource = sdl.Lista_ProcesoLogistico_Detalle_PorCeges(strAñoProceso, strVersion, strCodCeges);
                }

                if (blnPintaFormato)
                {
                    this.FormatoGrid();
                    blnPintaFormato = false;
                }
                if (strVersionUltima == strVersion)
                {
                    MostrarIconoGrilla();
                }

            }
        }

        private void MostrarIconoGrilla()
        {
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow  oRow in this.grd_mvto_Activo.Rows)
            {
                MostrarIconoGrilla_Row(oRow);
            }
        }

        private void FormatoGrid()
        {
            this.grd_mvto_Activo.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.grd_mvto_Activo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand  oBand in this.grd_mvto_Activo.DisplayLayout.Bands)
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
            this.grd_mvto_Activo.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default


            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand  oBand in this.grd_mvto_Activo.DisplayLayout.Bands)
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
            oBand0 = this.grd_mvto_Activo.DisplayLayout.Bands[0];
            oBand0.Columns[0].Header.Caption = " ";
            oBand0.Columns[0].Width = 20;
            oBand0.Columns[1].Header.Caption = "Item";
            oBand0.Columns[1].Width = 50;
            oBand0.Columns[2].Header.Caption = "Procedimiento";
            oBand0.Columns[2].Width = 120;
            oBand0.Columns[3].Header.Caption = "Centro";
            oBand0.Columns[3].Width = 100;
            oBand0.Columns[4].Header.Caption = "Centro Gestor";
            oBand0.Columns[4].Width = 140;
            oBand0.Columns[5].Header.Caption = "Tipo de Proceso";
            oBand0.Columns[5].Width = 140;
            oBand0.Columns[6].Header.Caption = "Objeto de Contratación";
            oBand0.Columns[6].Width = 140;
            oBand0.Columns[7].Header.Caption = "Descripción";
            oBand0.Columns[7].Width = 200;
            oBand0.Columns[8].Header.Caption = "Cantidad";
            oBand0.Columns[8].Width = 60;
            oBand0.Columns[9].Header.Caption = "Precio Estimado";
            oBand0.Columns[9].Width = 90;
            oBand0.Columns[10].Header.Caption = "Moneda";
            oBand0.Columns[10].Width = 50;
            oBand0.Columns[11].Header.Caption = "Tipo de Compra";
            oBand0.Columns[11].Width = 100;

            oBand0.Columns[12].Hidden = true;
            oBand0.Columns[13].Hidden = true;
        }

        private void grd_mvto_Activo_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
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

                    this.UltraGridExcelExporter1.Export(this.grd_mvto_Activo, strFile);

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

        private void grd_mvto_Activo_DoubleClickCell(object sender, DoubleClickCellEventArgs e)
        {
            try
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.grd_mvto_Activo.ActiveRow;
                int intIdPac_Detalle = Convert.ToInt32(oRow.Cells[12].Value);
                ShowPrograma(intIdPac_Detalle);

            }
            catch (Exception ex)
            {

            }
        }

        private void ShowPrograma(int intIdPac_Detalle)
        {
            Frm_ConsultaItemPAC frm = new Frm_ConsultaItemPAC();

            frm.ShowMe(intIdPac_Detalle,
                        this.grd_mvto_Activo,
                       false
                       );
        }

        private void grd_mvto_Activo_ClickCellButton(object sender, CellEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.grd_mvto_Activo.ActiveRow;
            if (e.Cell.Column.Index == 0)
            {
                string strNumProcedimiento = Convert.ToString(oRow.Cells[2].Value);
                int intIdPac_Detalle_Paso_Apertura = Convert.ToInt32(oRow.Cells[13].Value);
                if (  intIdPac_Detalle_Paso_Apertura == 0 )
                {
                    WINlogistica.Frm_ActualizaPaso_Apertura_Inicio frm = new WINlogistica.Frm_ActualizaPaso_Apertura_Inicio();

                    frm.ShowMe(strNumProcedimiento, 0);
                    if (frm.blnGrabaApertura == true)
                    {
                        oRow.Cells[13].Value = frm.intIdPac_Paso_Apertura;
                        this.MostrarIconoGrilla_Row(oRow);
                    }
                }
                else
                {
                    WINlogistica.Frm_AperturaPaso_Inicial_consulta frm = new WINlogistica.Frm_AperturaPaso_Inicial_consulta();
                    frm.ShowMe(strNumProcedimiento, 
                               intIdPac_Detalle_Paso_Apertura
                              );
                }
            }
        }

        private void MostrarIconoGrilla_Row(Infragistics.Win.UltraWinGrid.UltraGridRow oRow)
        {
            if (Convert.ToInt32(oRow.Cells[13].Value) == 0)
            {
                oRow.Cells[0].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                oRow.Cells[0].Appearance.Image = ImageList1.Images[1];
                oRow.Cells[0].ButtonAppearance.Image = ImageList1.Images[1];
            }
            else
            {
                oRow.Cells[0].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                oRow.Cells[0].Appearance.Image = ImageList1.Images[0];
                oRow.Cells[0].ButtonAppearance.Image = ImageList1.Images[0];

            }
        }

        private void Txt_CodCeges_Leave(object sender, EventArgs e)
        {
            this.Txt_DesCeGes.Value = FS.TraerDescripcion_DataTable(DS_CentroGestor.Tables[0],
                                                                                   0,
                                                                                   1,
                                                                                   Convert.ToString(this.Txt_CodCeges.Value)
                                                                                 );

        }
    }
}
