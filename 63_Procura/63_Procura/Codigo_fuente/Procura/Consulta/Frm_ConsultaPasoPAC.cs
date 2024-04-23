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
    public partial class Frm_ConsultaPasoPAC : Form
    {
        Service.Data sdl = new Service.Data();

        Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();

        Model.ProcesoLogistico_Paso MPDP = new Model.ProcesoLogistico_Paso();

        DataTable dtGrilla = new DataTable();
        bool blnPintarGrilla = true;
        int intIdPac_paso = 0;
        string strNumProcedimiento = "";
        bool blnPintaBoton = true;
        bool blnActualizaAdjunto = false;
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        public Frm_ConsultaPasoPAC()
        {
            InitializeComponent();
        }

        public void ShowMe(string cNumProcedimiento, bool bActualizaAdjunto = false)
        {
            
            strNumProcedimiento = cNumProcedimiento;
            blnActualizaAdjunto = bActualizaAdjunto;
            if (MyStuff.UsaWCF == true)
            {
                MPD = objWCF.Recupera_Pac_Detalle_Codigo(strNumProcedimiento);
                dtGrilla = objWCF.Lista_Pac_Paso(MPD.cAñoProceso, MPD.cNumProcedimiento).Tables[0];
            }
            else
            {
                MPD = sdl.Recupera_ProcesoLogistico_Detalle_Codigo(strNumProcedimiento);
                dtGrilla = sdl.Lista_ProcesoLogistico_Paso(MPD.cAñoProceso, MPD.cNumProcedimiento).Tables[0];

            }
            this.Grd_mvto_Pac_Paso.DataSource = dtGrilla;
            pintarGrilla();
            AdicionaImagenesGrilla();
            this.ShowDialog();

        }

        private void pintarGrilla()
        {
            this.Grd_mvto_Pac_Paso.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_mvto_Pac_Paso.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.Grd_mvto_Pac_Paso.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.Grd_mvto_Pac_Paso.DisplayLayout.Bands[0];

            oBand0.Columns[2].Header.Caption = "";
            oBand0.Columns[2].Width = 20;
            oBand0.Columns[2].Header.Appearance.ImageBackgroundAlpha = Infragistics.Win.Alpha.Transparent;
            oBand0.Columns[2].Header.Appearance.Image = this.imageList2.Images[3];
            oBand0.Columns[2].Header.Appearance.ImageHAlign = HAlign.Right;
            oBand0.Columns[3].Header.Caption = " ";
            oBand0.Columns[3].Width = 20;
            oBand0.Columns[4].Header.Caption = "Paso";
            oBand0.Columns[4].Width = 40;
            oBand0.Columns[5].Header.Caption = "Descripción";
            oBand0.Columns[5].Width = 150;
            oBand0.Columns[6].Header.Caption = "F.Inicio";
            oBand0.Columns[6].Width = 70;
            oBand0.Columns[7].Header.Caption = "F.Final";
            oBand0.Columns[7].Width = 70;
            oBand0.Columns[8].Header.Caption = "Apertura";
            oBand0.Columns[8].Width = 100;
            oBand0.Columns[9].Header.Caption = "Cierre";
            oBand0.Columns[9].Width = 100;
            oBand0.Columns[10].Header.Caption = "Nota";
            oBand0.Columns[10].Width = 350;
            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[1].Hidden = true;
            oBand0.Columns[3].Hidden = true;
            oBand0.Columns[11].Hidden = true;
        }

        private void AdicionaImagenesGrilla()
        {
            int intRegistro = 0;
            //bool blnPintaImagen = true;
            //Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow  oRow in this.Grd_mvto_Pac_Paso.Rows)
            {
                if (intRegistro == 0)
                {
                    if (Convert.ToString(oRow.Cells[8].Text).Trim() == "" & Convert.ToString(oRow.Cells[9].Text).Trim() == "")
                    {
                        break;
                    }
                    else
                    {
                        if (Convert.ToString(oRow.Cells[8].Text).Trim() != "" & Convert.ToString(oRow.Cells[9].Text).Trim() == "")
                        {
                            RefrescarCeldaGrilla(oRow);
                            break;
                        }
                        else
                        {
                            RefrescarCeldaGrilla(oRow);
                        }
                    }
                }
                else
                {
                    if (Convert.ToString(oRow.Cells[8].Text).Trim() == "" & Convert.ToString(oRow.Cells[9].Text).Trim() == "")
                    {
                        RefrescarCeldaGrilla(oRow);
                        break;
                    }
                    else
                    {
                        if (Convert.ToString(oRow.Cells[8].Text).Trim() != "" & Convert.ToString(oRow.Cells[9].Text).Trim() == "")
                        {
                            RefrescarCeldaGrilla(oRow);
                            break;
                        }
                        else
                        {
                            RefrescarCeldaGrilla(oRow);
                        }
                    }
                }
                intRegistro = intRegistro + 1;
            }
        }
        private void RefrescarCeldaGrilla(Infragistics.Win.UltraWinGrid.UltraGridRow oRow)
        {

            if (Convert.ToString(oRow.Cells[8].Text).Trim() != "")
            {
                oRow.Cells[2].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                oRow.Cells[2].Appearance.Image = this.imageList2.Images[3];
                oRow.Cells[2].ButtonAppearance.Image = this.imageList2.Images[3];
                oRow.Cells[2].ButtonAppearance.TextHAlign = HAlign.Right;
            }

        }

        private void Tsb_Exportar_Click(object sender, EventArgs e)
        {

        }

        private void Grd_mvto_Pac_Paso_ClickCellButton(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_mvto_Pac_Paso.ActiveRow;
            intIdPac_paso = Convert.ToInt32(oRow.Cells[0].Value);
            int intIdPaso = Convert.ToInt32(oRow.Cells[4].Value);

            if (e.Cell.Column.Index == 2)
            {
                if (blnActualizaAdjunto == true)
                {
                    WINlogistica.Frm_Pac_Paso_Adjunto frm = new WINlogistica.Frm_Pac_Paso_Adjunto();

                    frm.ShowMe(MPD.cNumProcedimiento, intIdPaso, Grd_mvto_Pac_Paso);

                }
                else
                {
                    //Frm_ConsultaAdjunto frm = new Frm_ConsultaAdjunto();
                    //frm.ShowMe(intIdPac_paso, 3);

                }
            }
            else if (e.Cell.Column.Index == 3)
            {
                //Dim frm As New frm_ActualizaComite_ItemPAC
                //frm.ShowMe(intIdComite,
                //            strCodComite,
                //            strCodTipoComite,
                //            strDesTipoComite,
                //            grd_mvto_DocumntoComite
                //              )
            }
        }

        private void Grd_mvto_Pac_Paso_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
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

        private void Frm_ConsultaPasoPAC_Load(object sender, EventArgs e)
        {

        }
    }
}
