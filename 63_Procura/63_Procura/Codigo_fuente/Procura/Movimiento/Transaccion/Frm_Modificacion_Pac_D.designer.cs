namespace WINlogistica
{
    partial class Frm_Modificacion_Pac_D
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
            Infragistics.Win.Appearance Appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance23 = new Infragistics.Win.Appearance();
            this.UltraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.btn_Modificar = new Infragistics.Win.Misc.UltraButton();
            this.UltraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.txt_NumDocumento = new gnUserControl.gnTextBox_Simple();
            this.cbo_CodTipoDocumento = new gnUserControl.gnComboBox();
            this.UltraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.UltraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.cbo_EstadoPacDetalle = new gnUserControl.gnComboBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.dtp_FecModificado = new gnUserControl.gnDateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.edt_MotModificado = new gnUserControl.gnEditBox();
            this.Label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).BeginInit();
            this.UltraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).BeginInit();
            this.UltraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NumDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_FecModificado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_MotModificado)).BeginInit();
            this.SuspendLayout();
            // 
            // UltraGroupBox3
            // 
            this.UltraGroupBox3.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.UltraGroupBox3.Controls.Add(this.btn_Modificar);
            this.UltraGroupBox3.Controls.Add(this.UltraGroupBox2);
            this.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox3.Location = new System.Drawing.Point(0, 0);
            this.UltraGroupBox3.Name = "UltraGroupBox3";
            this.UltraGroupBox3.Size = new System.Drawing.Size(616, 215);
            this.UltraGroupBox3.TabIndex = 52;
            this.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(537, 180);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // UltraGroupBox2
            // 
            this.UltraGroupBox2.Controls.Add(this.txt_NumDocumento);
            this.UltraGroupBox2.Controls.Add(this.cbo_CodTipoDocumento);
            this.UltraGroupBox2.Controls.Add(this.UltraLabel4);
            this.UltraGroupBox2.Controls.Add(this.UltraLabel3);
            this.UltraGroupBox2.Controls.Add(this.cbo_EstadoPacDetalle);
            this.UltraGroupBox2.Controls.Add(this.Label17);
            this.UltraGroupBox2.Controls.Add(this.dtp_FecModificado);
            this.UltraGroupBox2.Controls.Add(this.Label1);
            this.UltraGroupBox2.Controls.Add(this.edt_MotModificado);
            this.UltraGroupBox2.Controls.Add(this.Label16);
            this.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.UltraGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.UltraGroupBox2.Location = new System.Drawing.Point(1, 0);
            this.UltraGroupBox2.Name = "UltraGroupBox2";
            this.UltraGroupBox2.Size = new System.Drawing.Size(614, 167);
            this.UltraGroupBox2.TabIndex = 1;
            this.UltraGroupBox2.Text = "1. Datos de la Modificación";
            this.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // txt_NumDocumento
            // 
            this.txt_NumDocumento.enabledFocusColor = System.Drawing.Color.Lavender;
            this.txt_NumDocumento.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.txt_NumDocumento.exigirCampoLleno = false;
            this.txt_NumDocumento.leaveFocusColor = System.Drawing.Color.White;
            this.txt_NumDocumento.Location = new System.Drawing.Point(157, 36);
            this.txt_NumDocumento.LongitudTexto = 200;
            this.txt_NumDocumento.Name = "txt_NumDocumento";
            this.txt_NumDocumento.resaltarCampoOmitido = false;
            this.txt_NumDocumento.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.txt_NumDocumento.Size = new System.Drawing.Size(182, 21);
            this.txt_NumDocumento.TabIndex = 1;
            this.txt_NumDocumento.tipoDato = gnUserControl.gnTextBox_Simple.Tipo.Ninguno;
            this.txt_NumDocumento.tipoDatoC = gnUserControl.gnTextBox_Simple.TipoC.Ninguno;
            // 
            // cbo_CodTipoDocumento
            // 
            this.cbo_CodTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_CodTipoDocumento.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.cbo_CodTipoDocumento.FormattingEnabled = true;
            this.cbo_CodTipoDocumento.leaveFocusColor = System.Drawing.Color.White;
            this.cbo_CodTipoDocumento.Location = new System.Drawing.Point(157, 12);
            this.cbo_CodTipoDocumento.Name = "cbo_CodTipoDocumento";
            this.cbo_CodTipoDocumento.nombreDS = null;
            this.cbo_CodTipoDocumento.nombreSP = "";
            this.cbo_CodTipoDocumento.parametrosSP = "";
            this.cbo_CodTipoDocumento.resaltarCampoOmitido = false;
            this.cbo_CodTipoDocumento.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.cbo_CodTipoDocumento.Size = new System.Drawing.Size(182, 21);
            this.cbo_CodTipoDocumento.TabIndex = 0;
            this.cbo_CodTipoDocumento.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // UltraLabel4
            // 
            Appearance7.BackColor = System.Drawing.Color.Transparent;
            this.UltraLabel4.Appearance = Appearance7;
            this.UltraLabel4.AutoSize = true;
            this.UltraLabel4.Location = new System.Drawing.Point(28, 40);
            this.UltraLabel4.Name = "UltraLabel4";
            this.UltraLabel4.Size = new System.Drawing.Size(124, 14);
            this.UltraLabel4.TabIndex = 663;
            this.UltraLabel4.Text = "Numero de Documento:";
            // 
            // UltraLabel3
            // 
            Appearance23.BackColor = System.Drawing.Color.Transparent;
            this.UltraLabel3.Appearance = Appearance23;
            this.UltraLabel3.AutoSize = true;
            this.UltraLabel3.Location = new System.Drawing.Point(46, 16);
            this.UltraLabel3.Name = "UltraLabel3";
            this.UltraLabel3.Size = new System.Drawing.Size(106, 14);
            this.UltraLabel3.TabIndex = 662;
            this.UltraLabel3.Text = "Tipo de Documento:";
            // 
            // cbo_EstadoPacDetalle
            // 
            this.cbo_EstadoPacDetalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_EstadoPacDetalle.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.cbo_EstadoPacDetalle.FormattingEnabled = true;
            this.cbo_EstadoPacDetalle.leaveFocusColor = System.Drawing.Color.White;
            this.cbo_EstadoPacDetalle.Location = new System.Drawing.Point(157, 60);
            this.cbo_EstadoPacDetalle.Name = "cbo_EstadoPacDetalle";
            this.cbo_EstadoPacDetalle.nombreDS = null;
            this.cbo_EstadoPacDetalle.nombreSP = "";
            this.cbo_EstadoPacDetalle.parametrosSP = "";
            this.cbo_EstadoPacDetalle.resaltarCampoOmitido = false;
            this.cbo_EstadoPacDetalle.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.cbo_EstadoPacDetalle.Size = new System.Drawing.Size(261, 21);
            this.cbo_EstadoPacDetalle.TabIndex = 2;
            this.cbo_EstadoPacDetalle.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.Location = new System.Drawing.Point(32, 64);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(120, 13);
            this.Label17.TabIndex = 659;
            this.Label17.Text = "Motivo de Modificación:";
            // 
            // dtp_FecModificado
            // 
            this.dtp_FecModificado.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.dtp_FecModificado.exigirCampoLleno = false;
            this.dtp_FecModificado.KeyDownUp = "";
            this.dtp_FecModificado.leaveFocusColor = System.Drawing.Color.White;
            this.dtp_FecModificado.Location = new System.Drawing.Point(157, 84);
            this.dtp_FecModificado.Name = "dtp_FecModificado";
            this.dtp_FecModificado.resaltarCampoOmitido = false;
            this.dtp_FecModificado.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.dtp_FecModificado.Size = new System.Drawing.Size(144, 21);
            this.dtp_FecModificado.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(34, 88);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(118, 13);
            this.Label1.TabIndex = 656;
            this.Label1.Text = "Fecha de Modificación:";
            // 
            // edt_MotModificado
            // 
            this.edt_MotModificado.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.edt_MotModificado.exigirCampoLleno = false;
            this.edt_MotModificado.KeyDownUp = "";
            this.edt_MotModificado.leaveFocusColor = System.Drawing.Color.White;
            this.edt_MotModificado.Location = new System.Drawing.Point(156, 108);
            this.edt_MotModificado.Multiline = true;
            this.edt_MotModificado.Name = "edt_MotModificado";
            this.edt_MotModificado.resaltarCampoOmitido = false;
            this.edt_MotModificado.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.edt_MotModificado.Size = new System.Drawing.Size(448, 43);
            this.edt_MotModificado.TabIndex = 4;
            this.edt_MotModificado.tipoDatoC = gnUserControl.gnEditBox.TipoC.Ninguno;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.Location = new System.Drawing.Point(119, 111);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(33, 13);
            this.Label16.TabIndex = 654;
            this.Label16.Text = "Nota:";
            // 
            // Frm_Modificacion_Pac_D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 215);
            this.Controls.Add(this.UltraGroupBox3);
            this.Name = "Frm_Modificacion_Pac_D";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación del Item del PAC";
            this.Load += new System.EventHandler(this.Frm_Modificacion_Pac_D_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).EndInit();
            this.UltraGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).EndInit();
            this.UltraGroupBox2.ResumeLayout(false);
            this.UltraGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NumDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_FecModificado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_MotModificado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox3;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox2;
        internal gnUserControl.gnTextBox_Simple txt_NumDocumento;
        internal gnUserControl.gnComboBox cbo_CodTipoDocumento;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel4;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel3;
        internal gnUserControl.gnComboBox cbo_EstadoPacDetalle;
        internal System.Windows.Forms.Label Label17;
        internal gnUserControl.gnDateTimePicker dtp_FecModificado;
        internal System.Windows.Forms.Label Label1;
        internal gnUserControl.gnEditBox edt_MotModificado;
        internal System.Windows.Forms.Label Label16;
        internal Infragistics.Win.Misc.UltraButton btn_Modificar;
    }
}