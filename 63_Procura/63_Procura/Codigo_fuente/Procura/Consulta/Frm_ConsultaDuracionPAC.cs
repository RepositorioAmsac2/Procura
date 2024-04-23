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
    public partial class Frm_ConsultaDuracionPAC : Form
    {
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        private Service.Data sdl = new Service.Data();
        public Frm_ConsultaDuracionPAC()
        {
            InitializeComponent();
        }

        public void ShowMe( string strAñoProceso,
                            string strVersion,
                            string strNumProcedimiento 
                          )
        {


            DataTable dt = new DataTable();
            if (MyStuff.UsaWCF == true)
            {
                dt = objWCF.Lista_Pac_Duracion_Consulta(strAñoProceso,
                                                 strVersion,
                                                 strNumProcedimiento
                                                ).Tables[0];
            }
            else
            {
                dt = sdl.Lista_ProcesoLogistico_Duracion_Consulta(strAñoProceso,
                                                 strVersion,
                                                 strNumProcedimiento
                                                ).Tables[0];
            }
            


            this.grd_mvto_DocumntoComite.DataSource = dt;
        pintarGrilla();
            this.ShowDialog();
        }

        private void Frm_ConsultaDuracionPAC_Load(object sender, EventArgs e)
        {

        }

        private void pintarGrilla()
        {
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.grd_mvto_DocumntoComite.DisplayLayout.Bands[0];

            oBand0.Columns[1].Header.Caption = "Grupo";
            oBand0.Columns[1].Width = 150;
            oBand0.Columns[2].Header.Caption = "Paso ";
            oBand0.Columns[2].Width = 250;
            oBand0.Columns[4].Header.Caption = "F.Inicio";
            oBand0.Columns[4].Width = 72;
            oBand0.Columns[5].Header.Caption = "F.Final";
            oBand0.Columns[5].Width = 72;
            oBand0.Columns[12].Header.Caption = "Avance (%)";
            oBand0.Columns[12].Width = 70;

            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[3].Hidden = true;
            oBand0.Columns[6].Hidden = true;
            oBand0.Columns[7].Hidden = true;
            oBand0.Columns[8].Hidden = true;
            oBand0.Columns[9].Hidden = true;
            oBand0.Columns[10].Hidden = true;
            oBand0.Columns[11].Hidden = true;
            oBand0.Columns[13].Hidden = true;
        }

        private void grd_mvto_DocumntoComite_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            //e.Layout.Override.FilterUIType = FilterUIType.FilterRow


            e.Layout.Override.RowSizing = Infragistics.Win.UltraWinGrid.RowSizing.Free;
            e.Layout.Bands[0].AutoPreviewEnabled = true;

            e.Layout.Override.MergedCellStyle = MergedCellStyle.OnlyWhenSorted;
            e.Layout.Override.MergedCellContentArea = MergedCellContentArea.VirtualRect;
            e.Layout.Override.HeaderClickAction = HeaderClickAction.SortMulti;
            e.Layout.Override.MergedCellAppearance.BackColor = Color.LightYellow;
            e.Layout.Bands[0].SortedColumns.Add("GanttSeries", false);
            e.Layout.Bands[0].Columns["GanttSeries"].Header.VisiblePosition = 0;

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
    }
}
