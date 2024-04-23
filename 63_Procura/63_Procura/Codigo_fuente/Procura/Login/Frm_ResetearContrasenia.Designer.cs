namespace WINlogistica
{
    partial class Frm_ResetearContrasenia
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
            this.pcGeneral = new DevExpress.XtraEditors.PanelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtRepiteNuevaContrasenia = new DevExpress.XtraEditors.TextEdit();
            this.txtNuevaContrasenia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblNuevaContrasenia = new DevExpress.XtraEditors.LabelControl();
            this.epReseteoContrasenia = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcGeneral)).BeginInit();
            this.pcGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepiteNuevaContrasenia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuevaContrasenia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epReseteoContrasenia)).BeginInit();
            this.SuspendLayout();
            // 
            // pcGeneral
            // 
            this.pcGeneral.Controls.Add(this.btnGuardar);
            this.pcGeneral.Controls.Add(this.txtRepiteNuevaContrasenia);
            this.pcGeneral.Controls.Add(this.txtNuevaContrasenia);
            this.pcGeneral.Controls.Add(this.labelControl1);
            this.pcGeneral.Controls.Add(this.lblNuevaContrasenia);
            this.pcGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcGeneral.Location = new System.Drawing.Point(0, 0);
            this.pcGeneral.Name = "pcGeneral";
            this.pcGeneral.Size = new System.Drawing.Size(454, 161);
            this.pcGeneral.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(343, 123);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtRepiteNuevaContrasenia
            // 
            this.txtRepiteNuevaContrasenia.Location = new System.Drawing.Point(161, 59);
            this.txtRepiteNuevaContrasenia.Name = "txtRepiteNuevaContrasenia";
            this.txtRepiteNuevaContrasenia.Properties.PasswordChar = '*';
            this.txtRepiteNuevaContrasenia.Size = new System.Drawing.Size(257, 20);
            this.txtRepiteNuevaContrasenia.TabIndex = 7;
            // 
            // txtNuevaContrasenia
            // 
            this.txtNuevaContrasenia.Location = new System.Drawing.Point(161, 32);
            this.txtNuevaContrasenia.Name = "txtNuevaContrasenia";
            this.txtNuevaContrasenia.Properties.PasswordChar = '*';
            this.txtNuevaContrasenia.Size = new System.Drawing.Size(257, 20);
            this.txtNuevaContrasenia.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(132, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Repetir Nueva Contraseña:";
            // 
            // lblNuevaContrasenia
            // 
            this.lblNuevaContrasenia.Location = new System.Drawing.Point(60, 32);
            this.lblNuevaContrasenia.Name = "lblNuevaContrasenia";
            this.lblNuevaContrasenia.Size = new System.Drawing.Size(94, 13);
            this.lblNuevaContrasenia.TabIndex = 4;
            this.lblNuevaContrasenia.Text = "Nueva Contraseña:";
            // 
            // epReseteoContrasenia
            // 
            this.epReseteoContrasenia.ContainerControl = this;
            // 
            // Frm_ResetearContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(454, 161);
            this.Controls.Add(this.pcGeneral);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ResetearContrasenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = ".:: Cambiar Contraseña ::.";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pcGeneral)).EndInit();
            this.pcGeneral.ResumeLayout(false);
            this.pcGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepiteNuevaContrasenia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuevaContrasenia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epReseteoContrasenia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pcGeneral;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.TextEdit txtRepiteNuevaContrasenia;
        private DevExpress.XtraEditors.TextEdit txtNuevaContrasenia;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblNuevaContrasenia;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider epReseteoContrasenia;
    }
}