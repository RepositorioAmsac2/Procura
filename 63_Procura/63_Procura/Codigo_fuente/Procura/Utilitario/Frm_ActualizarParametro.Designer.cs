
namespace WINlogistica
{
    partial class Frm_ActualizarParametro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ActualizarParametro));
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Btn_ListaProyecto = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_CargarImagen = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_BorrarImagen = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Grabar = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Grabar_Salir = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Salir = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_ValorInicial = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ubicacionGeograficaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Txt_ValParametro = new gnUserControl.gnTextBox_Simple();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.Txt_NomParametro = new gnUserControl.gnTextBox_Simple();
            this.Txt_CodParametro = new gnUserControl.gnTextBox_Simple();
            this.UltraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.UltraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.empresaContratanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.macroProyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionGeograficaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ValParametro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NomParametro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CodParametro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaContratanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macroProyectoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.ribbonControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(498, 154);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.Btn_ListaProyecto,
            this.Btn_CargarImagen,
            this.Btn_BorrarImagen,
            this.Btn_Grabar,
            this.Btn_Grabar_Salir,
            this.Btn_Salir,
            this.Btn_ValorInicial});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(498, 150);
            // 
            // Btn_ListaProyecto
            // 
            this.Btn_ListaProyecto.Caption = "Lista de Parametro";
            this.Btn_ListaProyecto.Id = 1;
            this.Btn_ListaProyecto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ListaProyecto.ImageOptions.Image")));
            this.Btn_ListaProyecto.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_ListaProyecto.ImageOptions.LargeImage")));
            this.Btn_ListaProyecto.Name = "Btn_ListaProyecto";
            this.Btn_ListaProyecto.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.Btn_ListaProyecto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_ListaProyecto_ItemClick);
            // 
            // Btn_CargarImagen
            // 
            this.Btn_CargarImagen.Caption = "Cargar imagen";
            this.Btn_CargarImagen.Id = 2;
            this.Btn_CargarImagen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CargarImagen.ImageOptions.Image")));
            this.Btn_CargarImagen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_CargarImagen.ImageOptions.LargeImage")));
            this.Btn_CargarImagen.Name = "Btn_CargarImagen";
            this.Btn_CargarImagen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // Btn_BorrarImagen
            // 
            this.Btn_BorrarImagen.Caption = "Borrar imagen";
            this.Btn_BorrarImagen.Id = 3;
            this.Btn_BorrarImagen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_BorrarImagen.ImageOptions.Image")));
            this.Btn_BorrarImagen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_BorrarImagen.ImageOptions.LargeImage")));
            this.Btn_BorrarImagen.Name = "Btn_BorrarImagen";
            this.Btn_BorrarImagen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // Btn_Grabar
            // 
            this.Btn_Grabar.Caption = "Grabar";
            this.Btn_Grabar.Id = 4;
            this.Btn_Grabar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Grabar.ImageOptions.Image")));
            this.Btn_Grabar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Grabar.ImageOptions.LargeImage")));
            this.Btn_Grabar.Name = "Btn_Grabar";
            this.Btn_Grabar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.Btn_Grabar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Grabar_ItemClick);
            // 
            // Btn_Grabar_Salir
            // 
            this.Btn_Grabar_Salir.Caption = "Grabar y salir";
            this.Btn_Grabar_Salir.Id = 5;
            this.Btn_Grabar_Salir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Grabar_Salir.ImageOptions.Image")));
            this.Btn_Grabar_Salir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Grabar_Salir.ImageOptions.LargeImage")));
            this.Btn_Grabar_Salir.Name = "Btn_Grabar_Salir";
            this.Btn_Grabar_Salir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.Btn_Grabar_Salir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Grabar_Salir_ItemClick);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Caption = "Salir";
            this.Btn_Salir.Id = 6;
            this.Btn_Salir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.ImageOptions.Image")));
            this.Btn_Salir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.ImageOptions.LargeImage")));
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.Btn_Salir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Salir_ItemClick);
            // 
            // Btn_ValorInicial
            // 
            this.Btn_ValorInicial.Caption = "Valores iniciales";
            this.Btn_ValorInicial.Id = 7;
            this.Btn_ValorInicial.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ValorInicial.ImageOptions.Image")));
            this.Btn_ValorInicial.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_ValorInicial.ImageOptions.LargeImage")));
            this.Btn_ValorInicial.Name = "Btn_ValorInicial";
            this.Btn_ValorInicial.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.Btn_ValorInicial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_ValorInicial_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Detalle parametro";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_ListaProyecto);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Inicio";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.Btn_Grabar);
            this.ribbonPageGroup2.ItemLinks.Add(this.Btn_Grabar_Salir);
            this.ribbonPageGroup2.ItemLinks.Add(this.Btn_ValorInicial, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.Btn_Salir, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Principal";
            // 
            // ubicacionGeograficaBindingSource
            // 
            this.ubicacionGeograficaBindingSource.DataSource = typeof(Model.UbicacionGeografica);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Txt_ValParametro);
            this.groupControl2.Controls.Add(this.ultraLabel1);
            this.groupControl2.Controls.Add(this.Txt_NomParametro);
            this.groupControl2.Controls.Add(this.Txt_CodParametro);
            this.groupControl2.Controls.Add(this.UltraLabel6);
            this.groupControl2.Controls.Add(this.UltraLabel5);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 154);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(498, 235);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Datos del parametro";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // Txt_ValParametro
            // 
            this.Txt_ValParametro.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_ValParametro.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_ValParametro.exigirCampoLleno = false;
            this.Txt_ValParametro.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_ValParametro.Location = new System.Drawing.Point(31, 175);
            this.Txt_ValParametro.LongitudTexto = 200;
            this.Txt_ValParametro.Multiline = true;
            this.Txt_ValParametro.Name = "Txt_ValParametro";
            this.Txt_ValParametro.resaltarCampoOmitido = false;
            this.Txt_ValParametro.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_ValParametro.Size = new System.Drawing.Size(434, 50);
            this.Txt_ValParametro.TabIndex = 99;
            this.Txt_ValParametro.tipoDato = gnUserControl.gnTextBox_Simple.Tipo.Ninguno;
            this.Txt_ValParametro.tipoDatoC = gnUserControl.gnTextBox_Simple.TipoC.Ninguno;
            // 
            // ultraLabel1
            // 
            appearance5.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel1.Appearance = appearance5;
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(31, 154);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(30, 15);
            this.ultraLabel1.TabIndex = 98;
            this.ultraLabel1.Text = "Valor";
            // 
            // Txt_NomParametro
            // 
            this.Txt_NomParametro.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_NomParametro.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_NomParametro.exigirCampoLleno = false;
            this.Txt_NomParametro.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_NomParametro.Location = new System.Drawing.Point(31, 115);
            this.Txt_NomParametro.LongitudTexto = 200;
            this.Txt_NomParametro.Multiline = true;
            this.Txt_NomParametro.Name = "Txt_NomParametro";
            this.Txt_NomParametro.resaltarCampoOmitido = false;
            this.Txt_NomParametro.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_NomParametro.Size = new System.Drawing.Size(434, 24);
            this.Txt_NomParametro.TabIndex = 95;
            this.Txt_NomParametro.tipoDato = gnUserControl.gnTextBox_Simple.Tipo.Ninguno;
            this.Txt_NomParametro.tipoDatoC = gnUserControl.gnTextBox_Simple.TipoC.Ninguno;
            // 
            // Txt_CodParametro
            // 
            this.Txt_CodParametro.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_CodParametro.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_CodParametro.exigirCampoLleno = false;
            this.Txt_CodParametro.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_CodParametro.Location = new System.Drawing.Point(31, 68);
            this.Txt_CodParametro.LongitudTexto = 200;
            this.Txt_CodParametro.Name = "Txt_CodParametro";
            this.Txt_CodParametro.resaltarCampoOmitido = false;
            this.Txt_CodParametro.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_CodParametro.Size = new System.Drawing.Size(130, 22);
            this.Txt_CodParametro.TabIndex = 94;
            this.Txt_CodParametro.tipoDato = gnUserControl.gnTextBox_Simple.Tipo.Ninguno;
            this.Txt_CodParametro.tipoDatoC = gnUserControl.gnTextBox_Simple.TipoC.Ninguno;
            // 
            // UltraLabel6
            // 
            appearance6.BackColor = System.Drawing.Color.Transparent;
            this.UltraLabel6.Appearance = appearance6;
            this.UltraLabel6.AutoSize = true;
            this.UltraLabel6.Location = new System.Drawing.Point(31, 48);
            this.UltraLabel6.Name = "UltraLabel6";
            this.UltraLabel6.Size = new System.Drawing.Size(60, 15);
            this.UltraLabel6.TabIndex = 93;
            this.UltraLabel6.Text = "Parametro:";
            // 
            // UltraLabel5
            // 
            appearance3.BackColor = System.Drawing.Color.Transparent;
            this.UltraLabel5.Appearance = appearance3;
            this.UltraLabel5.AutoSize = true;
            this.UltraLabel5.Location = new System.Drawing.Point(31, 95);
            this.UltraLabel5.Name = "UltraLabel5";
            this.UltraLabel5.Size = new System.Drawing.Size(65, 15);
            this.UltraLabel5.TabIndex = 92;
            this.UltraLabel5.Text = "Descripción:";
            // 
            // macroProyectoBindingSource
            // 
            this.macroProyectoBindingSource.DataSource = typeof(Model.MacroProyecto);
            // 
            // Frm_ActualizarParametro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 391);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.sidePanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ActualizarParametro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Parametros";
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionGeograficaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ValParametro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NomParametro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CodParametro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaContratanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macroProyectoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem Btn_ListaProyecto;
        private DevExpress.XtraBars.BarButtonItem Btn_CargarImagen;
        private DevExpress.XtraBars.BarButtonItem Btn_BorrarImagen;
        private DevExpress.XtraBars.BarButtonItem Btn_Grabar;
        private DevExpress.XtraBars.BarButtonItem Btn_Grabar_Salir;
        private DevExpress.XtraBars.BarButtonItem Btn_Salir;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.BindingSource ubicacionGeograficaBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource macroProyectoBindingSource;
        private System.Windows.Forms.BindingSource empresaContratanteBindingSource;
        private DevExpress.XtraBars.BarButtonItem Btn_ValorInicial;
        internal Infragistics.Win.Misc.UltraLabel ultraLabel1;
        internal gnUserControl.gnTextBox_Simple Txt_NomParametro;
        internal gnUserControl.gnTextBox_Simple Txt_CodParametro;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel6;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel5;
        internal gnUserControl.gnTextBox_Simple Txt_ValParametro;
    }
}