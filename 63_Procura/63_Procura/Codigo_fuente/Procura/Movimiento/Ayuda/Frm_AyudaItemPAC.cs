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

namespace WINlogistica
{
    public partial class Frm_AyudaItemPAC : Form
    {
        public DataSet DS_ayuda = new DataSet();
        public bool blnTrasladar = false;
        private Service.Data sdl = new Service.Data();
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public Frm_AyudaItemPAC()
        {
            InitializeComponent();
        }

        public void ShowMe(string strAñoProceso)
        {
            if (MyStuff.UsaWCF == true)
            {
                DS_ayuda = objWCF.Ayuda_PAC_OperadorLogistico_itemPAC_Todos(strAñoProceso);
            }
            else
            {
                DS_ayuda = sdl.Ayuda_ProcesoLogistico_OperadorLogistico_itemProcesoLogistico_Todos(strAñoProceso);
            }
            

            this.Grd_buscados.DataSource = DS_ayuda;
            this.FormatoGrid();
            this.ShowDialog();
        }

        private void CmdAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormatoGrid()
        {
            //Me.grd_buscados.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
            //Me.grd_buscados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.Grd_buscados.DisplayLayout.Bands[0];

            oBand0.Columns[0].Header.Caption = "Elegir";
            oBand0.Columns[0].Width = 40;
            oBand0.Columns[1].Header.Caption = "PAC";
            oBand0.Columns[1].Width = 100;
            oBand0.Columns[2].Header.Caption = "Descripción";
            oBand0.Columns[2].Width = 430;
            oBand0.Columns[3].Hidden = true;
            oBand0.Columns[4].Hidden = true;
            oBand0.Columns[5].Hidden = true;
        }

        private void Grd_buscados_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
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
            //Me.LoadColumnsCombo(Me.ultraComboEditorColumn, Me.grd_mvto_Activo.DisplayLayout)
        }

        private void Chk_MarcarTodos_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataRow oRow in DS_ayuda.Tables[0].Rows)
            {
                oRow.BeginEdit();
                oRow["Pase"] = Chk_MarcarTodos.Checked;
                oRow.EndEdit();
            }
            this.CmdAceptar.Enabled = true;
            blnTrasladar = true;
        }

        private void Grd_buscados_CellChange(object sender, CellEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_buscados.ActiveRow;
            if (e.Cell.Column.Index == 0)
            {
                if (Convert.ToBoolean(oRow.Cells[0].Value) == false)
                {
                    oRow.Cells[0].Value = true;
                }
                else
                {
                    oRow.Cells[0].Value = false;
                }
                blnTrasladar = true;
                CmdAceptar.Enabled = true;
            }
        }

        private void Frm_AyudaItemPAC_Load(object sender, EventArgs e)
        {

        }
    }
}
