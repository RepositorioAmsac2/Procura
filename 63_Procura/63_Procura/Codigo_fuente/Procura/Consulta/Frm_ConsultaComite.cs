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
    public partial class Frm_ConsultaComite : Form
    {
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        private Service.Data sdl = new Service.Data();
        public Frm_ConsultaComite()
        {
            InitializeComponent();
        }

        public void ShowMe(string strNumProcedimiento)
        {
            if (MyStuff.UsaWCF == true)
            {
                this.grd_mvto_DocumntoComite.DataSource = objWCF.Lista_Comite_Integrante_Procedimiento(strNumProcedimiento);
            }
            else
            {
                this.grd_mvto_DocumntoComite.DataSource = sdl.Lista_Comite_Integrante_Procedimiento(strNumProcedimiento);
            }
            
            this.FormatoGrid();
            ShowDialog();

        }

        private void Frm_ConsultaComite_Load(object sender, EventArgs e)
        {

        }

        private void FormatoGrid()
        {
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.grd_mvto_DocumntoComite.DisplayLayout.Bands[0];
            oBand0.Columns[5].Header.Caption = "Integrante";
            oBand0.Columns[5].Width = 250;
            oBand0.Columns[7].Header.Caption = "Cargo";
            oBand0.Columns[7].Width = 100;
            oBand0.Columns[9].Header.Caption = "Condición";
            oBand0.Columns[9].Width = 100;
            oBand0.Columns[10].Header.Caption = "Firma Acta";
            oBand0.Columns[10].Width = 80;

            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[1].Hidden = true;
            oBand0.Columns[2].Hidden = true;
            oBand0.Columns[3].Hidden = true;
            oBand0.Columns[4].Hidden = true;
            oBand0.Columns[6].Hidden = true;
            oBand0.Columns[8].Hidden = true;
            oBand0.Columns[11].Hidden = true;
        }

        private void grd_mvto_DocumntoComite_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            //e.Layout.Override.FilterUIType = FilterUIType.FilterRow
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
