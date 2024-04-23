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
    public partial class Frm_ConsultaPac_Cabecera_Adjunto : Form
    {
        Model.ProcesoLogistico_Cabecera_Adjunto MPPA = new Model.ProcesoLogistico_Cabecera_Adjunto();
        Service.Data sdl = new Service.Data();

        DataTable dtGrilla = new DataTable();
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public Frm_ConsultaPac_Cabecera_Adjunto()
        {
            InitializeComponent();
        }

        public void ShowMe( string strAñoProceso,
                            string strVersion
            )
        {
            if (MyStuff.UsaWCF == true)
            {
                dtGrilla = objWCF.Lista_Pac_Cabecera_Adjunto_Consulta(strAñoProceso, strVersion).Tables[0];
            }
            else
            {
                dtGrilla = sdl.Lista_ProcesoLogistico_Cabecera_Adjunto_Consulta(strAñoProceso, strVersion).Tables[0];
            }
            

            if (dtGrilla.Rows.Count > 0)
            {
                //DataRow row;

                foreach (DataRow row in dtGrilla.Rows)
                {
                    row.BeginEdit();
                    row["vArchivo"] = NombreArchivo( Convert.ToString(  row["vArchivo"]));
                    row.EndEdit();
                }
            }
            this.Grd_Adjunto.DataSource = dtGrilla;
            pintarGrilla();
            AdicionaImagenesGrilla();
            this.ShowDialog();
        }

        private object NombreArchivo(string strArchivoDestino)
        {
            while (strArchivoDestino.IndexOf(@"\") != -1)
            {
                strArchivoDestino = strArchivoDestino.Substring(strArchivoDestino.IndexOf(@"\") + 1);
            }
            return strArchivoDestino;
        }
        private void pintarGrilla()
        {
            this.Grd_Adjunto.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_Adjunto.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.Grd_Adjunto.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.Grd_Adjunto.DisplayLayout.Bands[0];

            oBand0.Columns[0].Header.Caption = "";
            oBand0.Columns[0].Width = 20;
            oBand0.Columns[0].Header.Appearance.ImageBackgroundAlpha = Infragistics.Win.Alpha.Transparent;
            oBand0.Columns[0].Header.Appearance.Image = this.imageList2.Images[11];
            oBand0.Columns[0].Header.Appearance.ImageHAlign = HAlign.Right;

            oBand0.Columns[1].Header.Caption = "Archivo";
            oBand0.Columns[1].Width = 350;
            oBand0.Columns[3].Header.Caption = "Nombre";
            oBand0.Columns[3].Width = 350;
            oBand0.Columns[4].Header.Caption = "Creado";
            oBand0.Columns[4].Width = 80;
            oBand0.Columns[6].Header.Caption = "Subibo por";
            oBand0.Columns[6].Width = 200;
            oBand0.Columns[2].Hidden = true;
            oBand0.Columns[5].Hidden = true;
        }
        private void Frm_ConsultaAdjunto_Load(object sender, EventArgs e)
        {

        }

        private void Grd_Adjunto_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
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

        private void AdicionaImagenesGrilla()
        {
            //Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow oRow in this.Grd_Adjunto.Rows)
            {
                RefrescarCeldaGrilla(oRow);
            }
        }
        private void RefrescarCeldaGrilla(Infragistics.Win.UltraWinGrid.UltraGridRow oRow)
        {

            oRow.Cells[0].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            oRow.Cells[0].Appearance.Image = this.imageList2.Images[11];
            oRow.Cells[0].ButtonAppearance.Image = this.imageList2.Images[11];
        }
        private void grd_mvto_DocumntoComite_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            if (e.Cell.Column.Index == 0)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.Grd_Adjunto.ActiveRow;
                string strArchivoDestino = Convert.ToString(oRow.Cells[2].Value);
                try
                {
                    System.Diagnostics.Process proceso = new System.Diagnostics.Process();

                    proceso.StartInfo.FileName = strArchivoDestino;
                    proceso.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

    }
}
