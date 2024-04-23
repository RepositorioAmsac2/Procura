namespace WINlogistica
{
    partial class Frm_RechazoRequerimiento
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
            this.UltraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Btn_Rechazar = new Infragistics.Win.Misc.UltraButton();
            this.UltraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Cbo_MotivoRechazo = new gnUserControl.gnComboBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.Dtp_FecRechazo = new gnUserControl.gnDateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.Edt_MotRechazo = new gnUserControl.gnEditBox();
            this.Label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).BeginInit();
            this.UltraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).BeginInit();
            this.UltraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtp_FecRechazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edt_MotRechazo)).BeginInit();
            this.SuspendLayout();
            // 
            // UltraGroupBox3
            // 
            this.UltraGroupBox3.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.UltraGroupBox3.Controls.Add(this.Btn_Rechazar);
            this.UltraGroupBox3.Controls.Add(this.UltraGroupBox2);
            this.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox3.Location = new System.Drawing.Point(0, 0);
            this.UltraGroupBox3.Name = "UltraGroupBox3";
            this.UltraGroupBox3.Size = new System.Drawing.Size(553, 160);
            this.UltraGroupBox3.TabIndex = 53;
            this.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Btn_Rechazar
            // 
            this.Btn_Rechazar.Location = new System.Drawing.Point(447, 132);
            this.Btn_Rechazar.Name = "Btn_Rechazar";
            this.Btn_Rechazar.Size = new System.Drawing.Size(96, 23);
            this.Btn_Rechazar.TabIndex = 2;
            this.Btn_Rechazar.Text = "Enviar Rechazo";
            this.Btn_Rechazar.Click += new System.EventHandler(this.Btn_Rechazar_Click);
            // 
            // UltraGroupBox2
            // 
            this.UltraGroupBox2.Controls.Add(this.Cbo_MotivoRechazo);
            this.UltraGroupBox2.Controls.Add(this.Label17);
            this.UltraGroupBox2.Controls.Add(this.Dtp_FecRechazo);
            this.UltraGroupBox2.Controls.Add(this.Label1);
            this.UltraGroupBox2.Controls.Add(this.Edt_MotRechazo);
            this.UltraGroupBox2.Controls.Add(this.Label16);
            this.UltraGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.UltraGroupBox2.Location = new System.Drawing.Point(1, 0);
            this.UltraGroupBox2.Name = "UltraGroupBox2";
            this.UltraGroupBox2.Size = new System.Drawing.Size(611, 126);
            this.UltraGroupBox2.TabIndex = 1;
            this.UltraGroupBox2.Text = "1. Datos generales";
            this.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Cbo_MotivoRechazo
            // 
            this.Cbo_MotivoRechazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_MotivoRechazo.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_MotivoRechazo.FormattingEnabled = true;
            this.Cbo_MotivoRechazo.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_MotivoRechazo.Location = new System.Drawing.Point(94, 19);
            this.Cbo_MotivoRechazo.Name = "Cbo_MotivoRechazo";
            this.Cbo_MotivoRechazo.nombreDS = null;
            this.Cbo_MotivoRechazo.nombreSP = "";
            this.Cbo_MotivoRechazo.parametrosSP = "";
            this.Cbo_MotivoRechazo.resaltarCampoOmitido = false;
            this.Cbo_MotivoRechazo.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_MotivoRechazo.Size = new System.Drawing.Size(261, 21);
            this.Cbo_MotivoRechazo.TabIndex = 2;
            this.Cbo_MotivoRechazo.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.Location = new System.Drawing.Point(48, 23);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(42, 13);
            this.Label17.TabIndex = 659;
            this.Label17.Text = "Motivo:";
            // 
            // Dtp_FecRechazo
            // 
            this.Dtp_FecRechazo.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Dtp_FecRechazo.exigirCampoLleno = false;
            this.Dtp_FecRechazo.KeyDownUp = "";
            this.Dtp_FecRechazo.leaveFocusColor = System.Drawing.Color.White;
            this.Dtp_FecRechazo.Location = new System.Drawing.Point(94, 43);
            this.Dtp_FecRechazo.Name = "Dtp_FecRechazo";
            this.Dtp_FecRechazo.resaltarCampoOmitido = false;
            this.Dtp_FecRechazo.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Dtp_FecRechazo.Size = new System.Drawing.Size(144, 21);
            this.Dtp_FecRechazo.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(50, 47);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(40, 13);
            this.Label1.TabIndex = 656;
            this.Label1.Text = "Fecha:";
            // 
            // Edt_MotRechazo
            // 
            this.Edt_MotRechazo.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Edt_MotRechazo.exigirCampoLleno = false;
            this.Edt_MotRechazo.KeyDownUp = "";
            this.Edt_MotRechazo.leaveFocusColor = System.Drawing.Color.White;
            this.Edt_MotRechazo.Location = new System.Drawing.Point(94, 67);
            this.Edt_MotRechazo.Multiline = true;
            this.Edt_MotRechazo.Name = "Edt_MotRechazo";
            this.Edt_MotRechazo.resaltarCampoOmitido = false;
            this.Edt_MotRechazo.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Edt_MotRechazo.Size = new System.Drawing.Size(448, 43);
            this.Edt_MotRechazo.TabIndex = 4;
            this.Edt_MotRechazo.tipoDatoC = gnUserControl.gnEditBox.TipoC.Ninguno;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.Location = new System.Drawing.Point(57, 70);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(33, 13);
            this.Label16.TabIndex = 654;
            this.Label16.Text = "Nota:";
            // 
            // Frm_RechazoRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 160);
            this.Controls.Add(this.UltraGroupBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_RechazoRequerimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechazo de Requerimiento";
            this.Load += new System.EventHandler(this.Frm_RechazoRequerimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).EndInit();
            this.UltraGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).EndInit();
            this.UltraGroupBox2.ResumeLayout(false);
            this.UltraGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtp_FecRechazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edt_MotRechazo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox3;
        internal Infragistics.Win.Misc.UltraButton Btn_Rechazar;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox2;
        internal gnUserControl.gnComboBox Cbo_MotivoRechazo;
        internal System.Windows.Forms.Label Label17;
        internal gnUserControl.gnDateTimePicker Dtp_FecRechazo;
        internal System.Windows.Forms.Label Label1;
        internal gnUserControl.gnEditBox Edt_MotRechazo;
        internal System.Windows.Forms.Label Label16;
    }
}