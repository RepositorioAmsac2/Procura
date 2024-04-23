using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid.ExcelExport;

namespace WINlogistica
{
    public partial class Frm_AsignaDependenciaOperadorLogistico : Form
    {

        private Model.OperadorLogistico MOL = new Model.OperadorLogistico();
        private Service.Data sdl = new Service.Data();
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        public Frm_AsignaDependenciaOperadorLogistico()
        {
            InitializeComponent();
        }


        private void FormatoGrid()
        {
            this.Grd_msto_OperadorLogistico.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_msto_OperadorLogistico.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.Grd_msto_OperadorLogistico.DisplayLayout.Bands[0];
            oBand0.Columns[0].Header.Caption = "Jefatura";
            oBand0.Columns[0].Width = 80;
            oBand0.Columns[1].Header.Caption = "Apellidos y Nombres";
            oBand0.Columns[1].Width = 280;
            oBand0.Columns[2].Header.Caption = "Empleado";
            oBand0.Columns[2].Width = 80;
            oBand0.Columns[3].Header.Caption = "Apellidos y Nombres";
            oBand0.Columns[3].Width = 280;
            oBand0.Columns[4].Header.Caption = "Centro Gestor";
            oBand0.Columns[4].Width = 80;
            oBand0.Columns[5].Header.Caption = "Descripción";
            oBand0.Columns[5].Width = 150;
            oBand0.Columns[6].Header.Caption = "E-Mail";
            oBand0.Columns[6].Width = 220;

            oBand0.Columns[4].Hidden = true;
            oBand0.Columns[5].Hidden = true;
            oBand0.Columns[7].Hidden = true;
            oBand0.Columns[8].Hidden = true;
            oBand0.Columns[9].Hidden = true;
        }

        private void Grd_msto_OperadorLogistico_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
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

            this.Grd_msto_OperadorLogistico.DisplayLayout.ScrollStyle = ScrollStyle.Immediate;
            this.Grd_msto_OperadorLogistico.DisplayLayout.Scrollbars = Scrollbars.Both;
            this.Grd_msto_OperadorLogistico.DisplayLayout.ColumnScrollbarSmallChange = 100;
            this.Grd_msto_OperadorLogistico.DisplayLayout.UseScrollWindow = UseScrollWindow.None;
            this.Grd_msto_OperadorLogistico.DisplayLayout.UseFixedHeaders = true;

            this.Grd_msto_OperadorLogistico.DisplayLayout.ScrollBarLook.MinMaxButtonsVisible = true;

            this.Grd_msto_OperadorLogistico.DisplayLayout.ScrollBarLook.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.BothAtRightBottom;
            this.Grd_msto_OperadorLogistico.DisplayLayout.ScrollBarLook.Appearance.BackGradientStyle = GradientStyle.Vertical;
        }

        private void TSB_ExportarExcel_Click(object sender, EventArgs e)
        {
            this.Exportar();
        }

        private void TSMI_Modificar_Click(object sender, EventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            int intIdEmpleado = 0;
            oRow = this.Grd_msto_OperadorLogistico.ActiveRow;

            string strCodEmpleado = Convert.ToString( oRow.Cells[2].Value );
            string strCodDependencia = Convert.ToString(  oRow.Cells[0].Value );
            string strApeDependencia = Convert.ToString( oRow.Cells[1].Value );
            string strCodCentroGestor = Convert.ToString( oRow.Cells[4].Value );
            string strDesCentroGestor = Convert.ToString( oRow.Cells[5].Value );
            string strEmail = Convert.ToString( oRow.Cells[6].Value );
            intIdEmpleado = Convert.ToInt32( oRow.Cells[9].Value );

            Frm_AsignaDependenciaOperadorLogistico_D frm = new Frm_AsignaDependenciaOperadorLogistico_D();

            frm.ShowMe( strCodEmpleado, 
                        strCodDependencia, 
                        strApeDependencia, 
                        strCodCentroGestor, 
                        strDesCentroGestor, 
                        strEmail, 
                        intIdEmpleado, 
                        this.Grd_msto_OperadorLogistico
                        );
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
                    this.UltraGridExcelExporter1.Export(this.Grd_msto_OperadorLogistico, strFile);
                }
                catch 
                {
                    MessageBox.Show("Error", "Error");
                }
            }
        }

        private void Frm_AsignaDependenciaOperadorLogistico_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if (MyStuff.UsaWCF == true)
            {
                ds = objWCF.Lista_OperadorLogistico();
            }
            else
            {
                ds = sdl.Lista_OperadorLogistico();
            }
            this.Grd_msto_OperadorLogistico.DataSource = ds;

            this.FormatoGrid();

        }
    }
}
