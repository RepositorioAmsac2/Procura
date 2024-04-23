namespace WINlogistica
{
    partial class Frm_ActualizaPaso_PAC_cierre
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
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Btn_Grabar = new System.Windows.Forms.Button();
            this.UltraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Txt_ArchivoOrigen = new gnUserControl.gnTextBox_Simple();
            this.Btn_Adjunto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Edt_Nota = new gnUserControl.gnEditBox();
            this.Dtp_Cierre = new gnUserControl.gnDateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).BeginInit();
            this.UltraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ArchivoOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edt_Nota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtp_Cierre)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.ultraGroupBox1.Controls.Add(this.Btn_Grabar);
            this.ultraGroupBox1.Controls.Add(this.UltraGroupBox2);
            this.ultraGroupBox1.Controls.Add(this.toolStrip1);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(555, 211);
            this.ultraGroupBox1.TabIndex = 1;
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Btn_Grabar
            // 
            this.Btn_Grabar.Location = new System.Drawing.Point(414, 177);
            this.Btn_Grabar.Name = "Btn_Grabar";
            this.Btn_Grabar.Size = new System.Drawing.Size(129, 23);
            this.Btn_Grabar.TabIndex = 11;
            this.Btn_Grabar.Text = "Grabar";
            this.Btn_Grabar.UseVisualStyleBackColor = true;
            this.Btn_Grabar.Click += new System.EventHandler(this.Btn_Grabar_Click);
            // 
            // UltraGroupBox2
            // 
            this.UltraGroupBox2.Controls.Add(this.Txt_ArchivoOrigen);
            this.UltraGroupBox2.Controls.Add(this.Btn_Adjunto);
            this.UltraGroupBox2.Controls.Add(this.label2);
            this.UltraGroupBox2.Controls.Add(this.label1);
            this.UltraGroupBox2.Controls.Add(this.Edt_Nota);
            this.UltraGroupBox2.Controls.Add(this.Dtp_Cierre);
            this.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.UltraGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.UltraGroupBox2.Location = new System.Drawing.Point(1, 25);
            this.UltraGroupBox2.Name = "UltraGroupBox2";
            this.UltraGroupBox2.Size = new System.Drawing.Size(553, 136);
            this.UltraGroupBox2.TabIndex = 10;
            this.UltraGroupBox2.Text = "Datos del Cierre";
            this.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Txt_ArchivoOrigen
            // 
            this.Txt_ArchivoOrigen.Enabled = false;
            this.Txt_ArchivoOrigen.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_ArchivoOrigen.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_ArchivoOrigen.exigirCampoLleno = false;
            this.Txt_ArchivoOrigen.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_ArchivoOrigen.Location = new System.Drawing.Point(158, 96);
            this.Txt_ArchivoOrigen.LongitudTexto = 200;
            this.Txt_ArchivoOrigen.Name = "Txt_ArchivoOrigen";
            this.Txt_ArchivoOrigen.resaltarCampoOmitido = false;
            this.Txt_ArchivoOrigen.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_ArchivoOrigen.Size = new System.Drawing.Size(384, 21);
            this.Txt_ArchivoOrigen.TabIndex = 3;
            this.Txt_ArchivoOrigen.tipoDato = gnUserControl.gnTextBox_Simple.Tipo.Ninguno;
            this.Txt_ArchivoOrigen.tipoDatoC = gnUserControl.gnTextBox_Simple.TipoC.Ninguno;
            // 
            // Btn_Adjunto
            // 
            this.Btn_Adjunto.Location = new System.Drawing.Point(41, 96);
            this.Btn_Adjunto.Name = "Btn_Adjunto";
            this.Btn_Adjunto.Size = new System.Drawing.Size(111, 23);
            this.Btn_Adjunto.TabIndex = 2;
            this.Btn_Adjunto.Text = "Adjuntar...";
            this.Btn_Adjunto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(82, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Observación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(68, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Fecha de cierre:";
            // 
            // Edt_Nota
            // 
            this.Edt_Nota.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Edt_Nota.exigirCampoLleno = false;
            this.Edt_Nota.KeyDownUp = "";
            this.Edt_Nota.leaveFocusColor = System.Drawing.Color.White;
            this.Edt_Nota.Location = new System.Drawing.Point(158, 45);
            this.Edt_Nota.Multiline = true;
            this.Edt_Nota.Name = "Edt_Nota";
            this.Edt_Nota.resaltarCampoOmitido = false;
            this.Edt_Nota.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Edt_Nota.Size = new System.Drawing.Size(384, 48);
            this.Edt_Nota.TabIndex = 103;
            this.Edt_Nota.tipoDatoC = gnUserControl.gnEditBox.TipoC.Ninguno;
            // 
            // Dtp_Cierre
            // 
            this.Dtp_Cierre.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Dtp_Cierre.exigirCampoLleno = false;
            this.Dtp_Cierre.KeyDownUp = "";
            this.Dtp_Cierre.leaveFocusColor = System.Drawing.Color.White;
            this.Dtp_Cierre.Location = new System.Drawing.Point(158, 19);
            this.Dtp_Cierre.Name = "Dtp_Cierre";
            this.Dtp_Cierre.resaltarCampoOmitido = false;
            this.Dtp_Cierre.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Dtp_Cierre.Size = new System.Drawing.Size(144, 21);
            this.Dtp_Cierre.TabIndex = 102;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Location = new System.Drawing.Point(1, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(553, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Frm_ActualizaPaso_PAC_cierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 211);
            this.Controls.Add(this.ultraGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ActualizaPaso_PAC_cierre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre de Paso";
            this.Load += new System.EventHandler(this.Frm_ActualizaPaso_PAC_cierre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).EndInit();
            this.UltraGroupBox2.ResumeLayout(false);
            this.UltraGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ArchivoOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edt_Nota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtp_Cierre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        internal System.Windows.Forms.Button Btn_Grabar;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox2;
        private gnUserControl.gnTextBox_Simple Txt_ArchivoOrigen;
        private System.Windows.Forms.Button Btn_Adjunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal gnUserControl.gnEditBox Edt_Nota;
        internal gnUserControl.gnDateTimePicker Dtp_Cierre;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}