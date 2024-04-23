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
    public partial class UC_Lista_EtapaProcesoLogistico : DevExpress.XtraEditors.XtraUserControl
    {
        private Model.Paso pasopendiente = new Model.Paso();
        private Service.Data objDATA = new Service.Data();
        public UC_Lista_EtapaProcesoLogistico()
        {
            InitializeComponent();
            this.lista();
            tileView1.FocusedRowHandle = 0;
            this.Grd_ListaCCosto.SizeChanged += (s, e) => { CompactTemplate = Grd_ListaCCosto.Width <= 300; };
            //if (MainFormHelper.TakeScreens) tileView1.AnimateArrival = false;
            UpdateColors();
        }

        Color UnreadTextColor;
        private static UC_Lista_EtapaProcesoLogistico _instance;
        public static UC_Lista_EtapaProcesoLogistico Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Lista_EtapaProcesoLogistico();
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
                //jesus
            }
            else
            {
                dt = objDATA.Lista_Paso(MyStuff.CodigoEmpresa).Tables[0];
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

        private void Btn_Modificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(this.tileView1.GetFocusedRowCellValue("cCodPaso"))) == false)
            {
                int intIdPaso = Convert.ToInt32(this.tileView1.GetFocusedRowCellValue("iIdPaso"));
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                SplashScreenManager.Default.SetWaitFormDescription("Trayendo información...");

                WINlogistica.Frm_ActualizarEtapaProcesoLogistico frm = new WINlogistica.Frm_ActualizarEtapaProcesoLogistico();
                frm.ShowMe(MyStuff.CodigoEmpresa,
                            intIdPaso,
                            false,
                            pasopendiente
                          );
                SplashScreenManager.CloseForm();
                frm.ShowDialog();

                if (frm.IngresoDatos == true)
                {
                    pasopendiente = frm.pasoanterior;
                }

                if (frm.blnGrabar == true)
                {
                    pasopendiente = (new Model.Paso());
                    this.ActualizaDatosGrid(frm.pasoanterior);
                    int visibleIndex = tileView1.GetVisibleIndex(tileView1.FocusedRowHandle);
                    tileView1.FocusedRowHandle = tileView1.GetVisibleRowHandle(visibleIndex);
                    this.Habilitar_Arriba_Abajo();
                }
            }
        }

        private void Btn_Nuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
            SplashScreenManager.Default.SetWaitFormDescription("Trayendo información...");
            WINlogistica.Frm_ActualizarEtapaProcesoLogistico frm = new WINlogistica.Frm_ActualizarEtapaProcesoLogistico();
            frm.ShowMe(MyStuff.CodigoEmpresa,
                        0,
                        true,
                        new Model.Paso()
                      );
            SplashScreenManager.CloseForm();
            frm.ShowDialog();
            if (frm.blnGrabar == true)
            {
                tileView1.AddNewRow();
                this.ActualizaDatosGrid(frm.pasoanterior);
                int visibleIndex = tileView1.GetVisibleIndex(tileView1.FocusedRowHandle);
                tileView1.FocusedRowHandle = tileView1.GetVisibleRowHandle(visibleIndex);
                this.Habilitar_Arriba_Abajo();
            }
        }

        private void ActualizaDatosGrid(Model.Paso obj)
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

        private void Btn_Eliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string pasoCodigo = Convert.ToString(this.tileView1.GetFocusedRowCellValue("cCodPaso"));

            XtraMessageBoxArgs argumentos = new XtraMessageBoxArgs();
            argumentos.Caption = "Advertencia";
            argumentos.Text = "Desea eliminar la Etapa " + pasoCodigo.TrimEnd() + " ?";
            argumentos.Buttons = new DialogResult[] { DialogResult.Yes, DialogResult.No };
            argumentos.Icon = System.Drawing.SystemIcons.Question; // <-- Mucho más simple
            if (XtraMessageBox.Show(argumentos) == System.Windows.Forms.DialogResult.Yes)
            {
                int Id = Convert.ToInt32(this.tileView1.GetFocusedRowCellValue("iIdPaso"));
                if (MyStuff.UsaWCF)
                {
                    //jesusobjWCF.Elimina_Paso(Id);
                }
                else
                    objDATA.Elimina_Paso(Id);

                //Eliminar linea de la cuadricula
                int visibleIndex = tileView1.GetVisibleIndex(tileView1.FocusedRowHandle);
                tileView1.FocusedRowHandle = tileView1.GetVisibleRowHandle(visibleIndex);
                tileView1.DeleteRow(tileView1.FocusedRowHandle);

                this.Habilitar_Arriba_Abajo();
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
    }
}
