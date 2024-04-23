using DevExpress.LookAndFeel;
using DevExpress.Utils.Colors;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraSplashScreen;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;


namespace WINlogistica.Modulo
{
    public partial class UC_Grafico_CurvaS_Reporte : DevExpress.XtraEditors.XtraUserControl
    {
        private Model.Pac_HojaTrabajo_detalle pacpendiente = new Model.Pac_HojaTrabajo_detalle();
        //private SRsafnet.SAFnetEClient objWCF = new SRsafnet.SAFnetEClient();
        private Service.Data objDATA = new Service.Data();
        public UC_Grafico_CurvaS_Reporte()
        {
            InitializeComponent();
            this.lista();
            tileView1.FocusedRowHandle = 0;
            this.Grd_ListaCCosto.SizeChanged += (s, e) => { CompactTemplate = Grd_ListaCCosto.Width <= 300; };
            //if (MainFormHelper.TakeScreens) tileView1.AnimateArrival = false;
            UpdateColors();
        }

        Color UnreadTextColor;
        private static UC_Grafico_CurvaS_Reporte _instance;
        public static UC_Grafico_CurvaS_Reporte Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Grafico_CurvaS_Reporte();
                return _instance;
            }
        }

        bool compact_Template = false;
        bool CompactTemplate
        {
            get { return compact_Template; }
            set
            {
                if (compact_Template == value) return;
                compact_Template = value;
                tileView1.RefreshData();
            }
        }


        private void lista()
        {
            DataTable dt = new DataTable();
            if (MyStuff.UsaWCF == true)
            {
                //jesusdt = objWCF.Lista_CentroCosto(MyStuff.CodigoEmpresa).Tables[0];
            }
            else
            {
                dt = objDATA.Lista_ProcesoLogistico_Detalle_CurvaS().Tables[0];
            }
            this.Grd_ListaCCosto.DataSource = dt;
            if (dt.Rows.Count == 0) this.Btn_Abajo.Enabled = false;
            if (dt.Rows.Count == 0) this.Btn_Arriba.Enabled = false;


        }

        void UpdateColors()
        {
            UnreadTextColor = DXSkinColorHelper.GetDXSkinColor(DXSkinColors.FillColors.Primary, LookAndFeel);
            this.tileView1.Appearance.GroupText.ForeColor = UnreadTextColor;
            this.tileView1.Appearance.ItemFocused.BackColor = Color.FromArgb(40, UnreadTextColor);
            this.tileView1.Appearance.ItemHovered.BackColor = Color.FromArgb(40, UnreadTextColor);
            //this.labelControl1.Appearance.ForeColor =
            //    this.labelControl1.AppearanceHovered.ForeColor =
            //    this.labelControl1.AppearancePressed.ForeColor =
            //    this.labelControl1.AppearanceDropDown.ForeColor =
            //    this.labelControl1.AppearanceDropDownHovered.ForeColor =
            //    this.labelControl1.AppearanceDropDownPressed.ForeColor = UnreadTextColor;
        }

        private void ActualizaDatosGrid(Model.CentroCosto obj)
        {
            Type t = obj.GetType();
            PropertyInfo[] props = t.GetProperties();
            foreach (var prop in props)
            {
                string nombreCampo = Convert.ToString(prop.Name);
                string contenidoCampo = Convert.ToString(prop.GetValue(obj));
                string tipoCampo = Convert.ToString(prop.PropertyType.Name);

                tileView1.SetFocusedRowCellValue(nombreCampo, contenidoCampo);
            }
        }

        private void dataNavigator1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Abajo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int visibleIndex = tileView1.GetVisibleIndex(tileView1.FocusedRowHandle);
            visibleIndex++;
            tileView1.FocusedRowHandle = tileView1.GetVisibleRowHandle(visibleIndex);
            if (visibleIndex > 0) this.Btn_Arriba.Enabled = true;
            if (tileView1.RowCount - 1 == visibleIndex) this.Btn_Abajo.Enabled = false;
        }

        private void Btn_Arriba_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int visibleIndex = tileView1.GetVisibleIndex(tileView1.FocusedRowHandle);
            visibleIndex--;
            tileView1.FocusedRowHandle = tileView1.GetVisibleRowHandle(visibleIndex);
            if (visibleIndex == 0) this.Btn_Arriba.Enabled = false;
            if (tileView1.RowCount - 1 > visibleIndex) this.Btn_Abajo.Enabled = true;

        }



        private void tileView1_ItemClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            this.Habilitar_Arriba_Abajo();
        }

        private void Habilitar_Arriba_Abajo()
        {
            int visibleIndex = tileView1.GetVisibleIndex(tileView1.FocusedRowHandle);
            if (tileView1.RowCount > 1)
            {
                if (visibleIndex == tileView1.RowCount - 1)
                {
                    this.Btn_Arriba.Enabled = true;
                    this.Btn_Abajo.Enabled = false;
                    return;
                }
                if (visibleIndex == 0)
                {
                    this.Btn_Arriba.Enabled = false;
                    this.Btn_Abajo.Enabled = true;
                    return;
                }

                this.Btn_Arriba.Enabled = true;
                this.Btn_Abajo.Enabled = true;
            }
            else
            {
                this.Btn_Arriba.Enabled = false;
                this.Btn_Abajo.Enabled = false;
            }
        }

        private void Btn_Actualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.lista();
            this.Habilitar_Arriba_Abajo();
        }

        private void tileView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.Habilitar_Arriba_Abajo();
        }

        private void Btn_Imprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowGridPreview(Grd_ListaCCosto);
        }

        private void ShowGridPreview(GridControl grid)
        {
            // Check whether the GridControl can be previewed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            grid.ShowRibbonPrintPreview();
        }

        private void PrintGrid(GridControl grid)
        {
            // Check whether the GridControl can be printed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Print.
            grid.Print();
        }

        private void tileView1_PrintInitialize(object sender, DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
        {
            PrintingSystemBase pb = e.PrintingSystem as PrintingSystemBase;
            pb.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            pb.PageSettings.Landscape = true;
            pb.PageSettings.LeftMargin = 20;
            pb.PageSettings.RightMargin = 20;
            pb.PageSettings.TopMargin = 20;
            pb.PageSettings.BottomMargin = 20;

        }

        private void Grd_ListaCCosto_Click(object sender, EventArgs e)
        {

        }

        private void tileView1_ContextButtonClick(object sender, DevExpress.Utils.ContextItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "Btn_Curva_S":
                    string strNumProcedimiento = Convert.ToString(this.tileView1.GetFocusedRowCellValue("cNumProcedimiento"));
                    SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                    SplashScreenManager.Default.SetWaitFormDescription("Trayendo grafico de la curva S...");
                    WINlogistica.UC_HojaTrabajo_CurvaS frm = new WINlogistica.UC_HojaTrabajo_CurvaS();
                    frm.ShowMe(strNumProcedimiento, "Reporte");
                    SplashScreenManager.CloseForm();
                    frm.ShowDialog();
                    break;
            }
        }
    }
}
