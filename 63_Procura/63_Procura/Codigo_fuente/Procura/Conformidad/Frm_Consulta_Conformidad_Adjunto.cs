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
    public partial class Frm_Consulta_Conformidad_Adjunto : Form
    {
        Service.Data sl = new Service.Data();
        public Frm_Consulta_Conformidad_Adjunto()
        {
            InitializeComponent();
        }

        public void ShowMe( string strCodCompañia,
                            string strNroConformidad,
                            string strCodTipoArchivo
                          )
        {
            this.Text = "Archivo Adjunto de tipo ( " +
                     strCodTipoArchivo.TrimEnd() + " )";

            DataSet ds = new DataSet();
            ds = sl.lista_Conformidad_Adjuntos_Consulta( strCodCompañia,
                                                         strNroConformidad,
                                                         strCodTipoArchivo
                                                       );
            this.Grd_ListaOtrosGastos.DataSource = ds;
            this.FormatoGrid();
            this.AdicionaImagenesGrilla();
            this.ShowDialog();
        }

        private void FormatoGrid()
        {

            this.Grd_ListaOtrosGastos.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;

            this.Grd_ListaOtrosGastos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_ListaOtrosGastos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            Infragistics.Win.UltraWinGrid.UltraGridBand oBandPantalla;
            oBandPantalla = this.Grd_ListaOtrosGastos.DisplayLayout.Bands[0];

            oBandPantalla.Columns[0].Header.Caption = "?";
            oBandPantalla.Columns[0].Width = 25;
            oBandPantalla.Columns[1].Header.Caption = "Origen";
            oBandPantalla.Columns[1].Width = 240;
            oBandPantalla.Columns[2].Header.Caption = "Destino";
            oBandPantalla.Columns[2].Width = 240;
            oBandPantalla.Columns[3].Header.Caption = "Nombre";
            oBandPantalla.Columns[3].Width = 240;
        }

        private void AdicionaImagenesGrilla()
        {

            UltraGridBand band = this.Grd_ListaOtrosGastos.DisplayLayout.Bands[0];

            foreach (UltraGridRow row in band.GetRowEnumerator(GridRowType.DataRow))
            {
                RefrescarCeldaGrilla(row);
            }

        }
        private void RefrescarCeldaGrilla(Infragistics.Win.UltraWinGrid.UltraGridRow oRow)
        {
            oRow.Cells[0].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            oRow.Cells[0].Appearance.Image = this.imageList2.Images[0];
            oRow.Cells[0].ButtonAppearance.Image = this.imageList2.Images[0];
            oRow.Cells[0].ButtonAppearance.TextHAlign = HAlign.Right;
        }


        private void Frm_Consulta_Conformidad_Adjunto_Load(object sender, EventArgs e)
        {

        }

        private void Grd_ListaOtrosGastos_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            //e.Layout.Override.FilterUIType = FilterUIType.FilterRow;

            //FilterOperatorDropDownItems val = FilterOperatorDropDownItems.Contains;
            //Grd_ListaOtrosGastos.DisplayLayout.Override.FilterOperatorDropDownItems = val;

            FilterOperatorDefaultValue val1 = FilterOperatorDefaultValue.Contains;
            Grd_ListaOtrosGastos.DisplayLayout.Override.FilterOperatorDefaultValue = val1;

            Grd_ListaOtrosGastos.DisplayLayout.ScrollStyle = ScrollStyle.Immediate;
            Grd_ListaOtrosGastos.DisplayLayout.Scrollbars = Scrollbars.Both;
            Grd_ListaOtrosGastos.DisplayLayout.ColumnScrollbarSmallChange = 100;
            Grd_ListaOtrosGastos.DisplayLayout.UseScrollWindow = UseScrollWindow.None;
            // Turn off UseOsThemes to allow display of raw column header 
            this.Grd_ListaOtrosGastos.UseOsThemes = DefaultableBoolean.False;
        }

        private void Grd_ListaOtrosGastos_ClickCellButton(object sender, CellEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_ListaOtrosGastos.ActiveRow;
            if (e.Cell.Column.Index == 0)
            {
                string strArchivo = Convert.ToString(oRow.Cells[2].Value);
                WINlogistica.Framework sf = new WINlogistica.Framework();
                sf.DownLoadArchivo(strArchivo);
            }
        }
    }
}
