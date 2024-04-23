namespace WINlogistica
{
    partial class Frm_NuevoConformidad_CambiaValor
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
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.UTC_Principal = new Infragistics.Win.UltraWinTabControl.UltraTabControl();
            this.ultraTabSharedControlsPage1 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Importe = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UTC_Principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Importe)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.Btn_Aceptar);
            this.ultraGroupBox1.Controls.Add(this.label6);
            this.ultraGroupBox1.Controls.Add(this.Txt_Importe);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(324, 98);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // ultraGroupBox3
            // 
            this.ultraGroupBox3.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.ultraGroupBox3.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox3.Name = "ultraGroupBox3";
            this.ultraGroupBox3.Size = new System.Drawing.Size(200, 110);
            this.ultraGroupBox3.TabIndex = 0;
            // 
            // UTC_Principal
            // 
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.UTC_Principal.Appearance = appearance4;
            this.UTC_Principal.Location = new System.Drawing.Point(0, 0);
            this.UTC_Principal.Name = "UTC_Principal";
            this.UTC_Principal.SharedControlsPage = this.ultraTabSharedControlsPage1;
            this.UTC_Principal.Size = new System.Drawing.Size(200, 100);
            this.UTC_Principal.TabIndex = 0;
            // 
            // ultraTabSharedControlsPage1
            // 
            this.ultraTabSharedControlsPage1.Location = new System.Drawing.Point(1, 20);
            this.ultraTabSharedControlsPage1.Name = "ultraTabSharedControlsPage1";
            this.ultraTabSharedControlsPage1.Size = new System.Drawing.Size(196, 77);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            this.OpenFileDialog1.Title = "Adjuntar Archivos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(24, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 92;
            this.label6.Text = "Importe de la linea del proyecto:";
            // 
            // Txt_Importe
            // 
            this.Txt_Importe.Location = new System.Drawing.Point(195, 25);
            this.Txt_Importe.Name = "Txt_Importe";
            this.Txt_Importe.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.Txt_Importe.Size = new System.Drawing.Size(116, 21);
            this.Txt_Importe.TabIndex = 91;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Location = new System.Drawing.Point(195, 61);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(117, 23);
            this.Btn_Aceptar.TabIndex = 93;
            this.Btn_Aceptar.Text = "Cambiar Valor";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Frm_NuevoConformidad_CambiaValor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 98);
            this.Controls.Add(this.ultraGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_NuevoConformidad_CambiaValor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de Valor";
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UTC_Principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Importe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox3;
        private Infragistics.Win.UltraWinTabControl.UltraTabControl UTC_Principal;
        private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage1;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Label label6;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor Txt_Importe;
    }
}