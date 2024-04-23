
namespace WINlogistica.Modulo
{
    partial class UC_ActualizaEmpresa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Acceso = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_LogoIzquierdo = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_LogoCentro = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_LogoMenu = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_RUC = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Empresa = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ImgLogo_Menu = new DevExpress.XtraEditors.PictureEdit();
            this.ImgLogo_Centro = new DevExpress.XtraEditors.PictureEdit();
            this.ImgLogo_Izquierdo = new DevExpress.XtraEditors.PictureEdit();
            this.imageDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_RUC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Empresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo_Menu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo_Centro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo_Izquierdo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Acceso
            // 
            this.Btn_Acceso.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.Btn_Acceso.Appearance.Options.UseFont = true;
            this.Btn_Acceso.Location = new System.Drawing.Point(499, 443);
            this.Btn_Acceso.Name = "Btn_Acceso";
            this.Btn_Acceso.Size = new System.Drawing.Size(157, 37);
            this.Btn_Acceso.TabIndex = 37;
            this.Btn_Acceso.Text = "Grabar Cambios";
            this.Btn_Acceso.Click += new System.EventHandler(this.Btn_Acceso_Click);
            // 
            // Btn_LogoIzquierdo
            // 
            this.Btn_LogoIzquierdo.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.Btn_LogoIzquierdo.Appearance.Options.UseFont = true;
            this.Btn_LogoIzquierdo.Location = new System.Drawing.Point(18, 443);
            this.Btn_LogoIzquierdo.Name = "Btn_LogoIzquierdo";
            this.Btn_LogoIzquierdo.Size = new System.Drawing.Size(271, 37);
            this.Btn_LogoIzquierdo.TabIndex = 45;
            this.Btn_LogoIzquierdo.Text = "Vincular Imagen";
            this.Btn_LogoIzquierdo.Click += new System.EventHandler(this.Btn_LogoIzquierdo_Click);
            // 
            // Btn_LogoCentro
            // 
            this.Btn_LogoCentro.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.Btn_LogoCentro.Appearance.Options.UseFont = true;
            this.Btn_LogoCentro.Location = new System.Drawing.Point(375, 163);
            this.Btn_LogoCentro.Name = "Btn_LogoCentro";
            this.Btn_LogoCentro.Size = new System.Drawing.Size(191, 37);
            this.Btn_LogoCentro.TabIndex = 46;
            this.Btn_LogoCentro.Text = "Vincular Imagen";
            this.Btn_LogoCentro.Click += new System.EventHandler(this.Btn_LogoCentro_Click);
            // 
            // Btn_LogoMenu
            // 
            this.Btn_LogoMenu.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.Btn_LogoMenu.Appearance.Options.UseFont = true;
            this.Btn_LogoMenu.Location = new System.Drawing.Point(65, 33);
            this.Btn_LogoMenu.Name = "Btn_LogoMenu";
            this.Btn_LogoMenu.Size = new System.Drawing.Size(224, 37);
            this.Btn_LogoMenu.TabIndex = 47;
            this.Btn_LogoMenu.Text = "Vincular Imagen en el menú";
            this.Btn_LogoMenu.Click += new System.EventHandler(this.Btn_LogoMenu_Click);
            // 
            // Txt_RUC
            // 
            this.Txt_RUC.EditValue = "RUC";
            this.Txt_RUC.Location = new System.Drawing.Point(328, 254);
            this.Txt_RUC.Name = "Txt_RUC";
            this.Txt_RUC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.Txt_RUC.Properties.Appearance.Options.UseFont = true;
            this.Txt_RUC.Properties.AutoHeight = false;
            this.Txt_RUC.Properties.NullText = "Usuario";
            this.Txt_RUC.Properties.ValidateOnEnterKey = true;
            this.Txt_RUC.Size = new System.Drawing.Size(328, 36);
            this.Txt_RUC.TabIndex = 49;
            this.Txt_RUC.EditValueChanged += new System.EventHandler(this.Txt_RUC_EditValueChanged);
            // 
            // Txt_Empresa
            // 
            this.Txt_Empresa.EditValue = "Empresa";
            this.Txt_Empresa.Location = new System.Drawing.Point(328, 296);
            this.Txt_Empresa.Name = "Txt_Empresa";
            this.Txt_Empresa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.Txt_Empresa.Properties.Appearance.Options.UseFont = true;
            this.Txt_Empresa.Properties.AutoHeight = false;
            this.Txt_Empresa.Properties.NullText = "Usuario";
            this.Txt_Empresa.Properties.ValidateOnEnterKey = true;
            this.Txt_Empresa.Size = new System.Drawing.Size(328, 36);
            this.Txt_Empresa.TabIndex = 50;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ImgLogo_Menu);
            this.groupControl1.Controls.Add(this.ImgLogo_Centro);
            this.groupControl1.Controls.Add(this.ImgLogo_Izquierdo);
            this.groupControl1.Controls.Add(this.Txt_Empresa);
            this.groupControl1.Controls.Add(this.Txt_RUC);
            this.groupControl1.Controls.Add(this.Btn_LogoMenu);
            this.groupControl1.Controls.Add(this.Btn_Acceso);
            this.groupControl1.Controls.Add(this.Btn_LogoCentro);
            this.groupControl1.Controls.Add(this.Btn_LogoIzquierdo);
            this.groupControl1.Location = new System.Drawing.Point(22, 86);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(676, 500);
            this.groupControl1.TabIndex = 51;
            this.groupControl1.Text = "Datos de la Empresa";
            // 
            // ImgLogo_Menu
            // 
            this.ImgLogo_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImgLogo_Menu.Location = new System.Drawing.Point(27, 33);
            this.ImgLogo_Menu.Name = "ImgLogo_Menu";
            this.ImgLogo_Menu.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImgLogo_Menu.Size = new System.Drawing.Size(32, 36);
            this.ImgLogo_Menu.TabIndex = 53;
            // 
            // ImgLogo_Centro
            // 
            this.ImgLogo_Centro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImgLogo_Centro.Location = new System.Drawing.Point(375, 50);
            this.ImgLogo_Centro.Name = "ImgLogo_Centro";
            this.ImgLogo_Centro.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImgLogo_Centro.Size = new System.Drawing.Size(191, 107);
            this.ImgLogo_Centro.TabIndex = 52;
            // 
            // ImgLogo_Izquierdo
            // 
            this.ImgLogo_Izquierdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImgLogo_Izquierdo.Location = new System.Drawing.Point(27, 75);
            this.ImgLogo_Izquierdo.Name = "ImgLogo_Izquierdo";
            this.ImgLogo_Izquierdo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImgLogo_Izquierdo.Size = new System.Drawing.Size(262, 362);
            this.ImgLogo_Izquierdo.TabIndex = 51;
            // 
            // imageDialog
            // 
            this.imageDialog.Filter = "Image files (BMP,JPG,PNG,GIF) |*.bmp;*.jpg;*.png;*.gif| All files|*.*";
            this.imageDialog.Multiselect = true;
            // 
            // UC_ActualizaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "UC_ActualizaEmpresa";
            this.Size = new System.Drawing.Size(720, 602);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_RUC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Empresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo_Menu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo_Centro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo_Izquierdo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton Btn_Acceso;
        private DevExpress.XtraEditors.SimpleButton Btn_LogoIzquierdo;
        private DevExpress.XtraEditors.SimpleButton Btn_LogoCentro;
        private DevExpress.XtraEditors.SimpleButton Btn_LogoMenu;
        private DevExpress.XtraEditors.TextEdit Txt_RUC;
        private DevExpress.XtraEditors.TextEdit Txt_Empresa;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PictureEdit ImgLogo_Menu;
        private DevExpress.XtraEditors.PictureEdit ImgLogo_Centro;
        private DevExpress.XtraEditors.PictureEdit ImgLogo_Izquierdo;
        private System.Windows.Forms.OpenFileDialog imageDialog;
    }
}
