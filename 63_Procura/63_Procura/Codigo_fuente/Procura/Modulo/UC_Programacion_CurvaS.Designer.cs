
namespace WINlogistica.Modulo
{
    partial class UC_Programacion_CurvaS
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
            Infragistics.Win.Appearance Appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Chk_EstaEnListaPAC = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.Opt_FechaBuenaPro = new System.Windows.Forms.RadioButton();
            this.Opt_FechaConvocatoria = new System.Windows.Forms.RadioButton();
            this.Lbl_FechaConvocatoria = new System.Windows.Forms.Label();
            this.dtp_FechaCalculo = new gnUserControl.gnDateTimePicker();
            this.Cbo_TipoProceso = new gnUserControl.gnComboBox();
            this.Cbo_ObjetoContratacion = new gnUserControl.gnComboBox();
            this.UltraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.UltraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.Txt_NumProcedimiento = new gnUserControl.gnTextBox();
            this.Edt_DesProcedimiento = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.Btn_Mostrar = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.spreadsheetControl = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_FechaCalculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NumProcedimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edt_DesProcedimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.groupControl2.Controls.Add(this.Chk_EstaEnListaPAC);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.ultraLabel3);
            this.groupControl2.Controls.Add(this.Opt_FechaBuenaPro);
            this.groupControl2.Controls.Add(this.Opt_FechaConvocatoria);
            this.groupControl2.Controls.Add(this.Lbl_FechaConvocatoria);
            this.groupControl2.Controls.Add(this.dtp_FechaCalculo);
            this.groupControl2.Controls.Add(this.Cbo_TipoProceso);
            this.groupControl2.Controls.Add(this.Cbo_ObjetoContratacion);
            this.groupControl2.Controls.Add(this.UltraLabel6);
            this.groupControl2.Controls.Add(this.UltraLabel5);
            this.groupControl2.Controls.Add(this.ultraLabel1);
            this.groupControl2.Controls.Add(this.Txt_NumProcedimiento);
            this.groupControl2.Controls.Add(this.Edt_DesProcedimiento);
            this.groupControl2.Controls.Add(this.Btn_Mostrar);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1055, 153);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Filtro de Datos";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // Chk_EstaEnListaPAC
            // 
            this.Chk_EstaEnListaPAC.AutoSize = true;
            this.Chk_EstaEnListaPAC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Chk_EstaEnListaPAC.Checked = true;
            this.Chk_EstaEnListaPAC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_EstaEnListaPAC.Location = new System.Drawing.Point(264, 42);
            this.Chk_EstaEnListaPAC.Name = "Chk_EstaEnListaPAC";
            this.Chk_EstaEnListaPAC.Size = new System.Drawing.Size(146, 17);
            this.Chk_EstaEnListaPAC.TabIndex = 670;
            this.Chk_EstaEnListaPAC.Text = "Esta en la lista del  PAC ?";
            this.Chk_EstaEnListaPAC.UseVisualStyleBackColor = true;
            this.Chk_EstaEnListaPAC.CheckedChanged += new System.EventHandler(this.Chk_EstaEnListaPAC_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(381, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 669;
            this.label1.Text = "Calcular las fehas por:";
            // 
            // ultraLabel3
            // 
            Appearance1.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel3.Appearance = Appearance1;
            this.ultraLabel3.AutoSize = true;
            this.ultraLabel3.Location = new System.Drawing.Point(73, 63);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(65, 15);
            this.ultraLabel3.TabIndex = 668;
            this.ultraLabel3.Text = "Descripción:";
            // 
            // Opt_FechaBuenaPro
            // 
            this.Opt_FechaBuenaPro.AutoSize = true;
            this.Opt_FechaBuenaPro.Location = new System.Drawing.Point(498, 119);
            this.Opt_FechaBuenaPro.Name = "Opt_FechaBuenaPro";
            this.Opt_FechaBuenaPro.Size = new System.Drawing.Size(154, 17);
            this.Opt_FechaBuenaPro.TabIndex = 666;
            this.Opt_FechaBuenaPro.Text = "Fecha Suscripción contrato";
            this.Opt_FechaBuenaPro.UseVisualStyleBackColor = true;
            this.Opt_FechaBuenaPro.CheckedChanged += new System.EventHandler(this.Opt_FechaBuenaPro_CheckedChanged);
            // 
            // Opt_FechaConvocatoria
            // 
            this.Opt_FechaConvocatoria.AutoSize = true;
            this.Opt_FechaConvocatoria.Checked = true;
            this.Opt_FechaConvocatoria.Location = new System.Drawing.Point(498, 95);
            this.Opt_FechaConvocatoria.Name = "Opt_FechaConvocatoria";
            this.Opt_FechaConvocatoria.Size = new System.Drawing.Size(168, 17);
            this.Opt_FechaConvocatoria.TabIndex = 665;
            this.Opt_FechaConvocatoria.TabStop = true;
            this.Opt_FechaConvocatoria.Text = "Fecha Remisión requerimiento";
            this.Opt_FechaConvocatoria.UseVisualStyleBackColor = true;
            this.Opt_FechaConvocatoria.CheckedChanged += new System.EventHandler(this.Opt_FechaConvocatoria_CheckedChanged);
            // 
            // Lbl_FechaConvocatoria
            // 
            this.Lbl_FechaConvocatoria.AutoSize = true;
            this.Lbl_FechaConvocatoria.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_FechaConvocatoria.Location = new System.Drawing.Point(765, 99);
            this.Lbl_FechaConvocatoria.Name = "Lbl_FechaConvocatoria";
            this.Lbl_FechaConvocatoria.Size = new System.Drawing.Size(150, 13);
            this.Lbl_FechaConvocatoria.TabIndex = 664;
            this.Lbl_FechaConvocatoria.Text = "Fecha Remisión requerimiento";
            // 
            // dtp_FechaCalculo
            // 
            this.dtp_FechaCalculo.DateTime = new System.DateTime(2013, 12, 18, 0, 0, 0, 0);
            this.dtp_FechaCalculo.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.dtp_FechaCalculo.exigirCampoLleno = false;
            this.dtp_FechaCalculo.KeyDownUp = "";
            this.dtp_FechaCalculo.leaveFocusColor = System.Drawing.Color.White;
            this.dtp_FechaCalculo.Location = new System.Drawing.Point(767, 119);
            this.dtp_FechaCalculo.Name = "dtp_FechaCalculo";
            this.dtp_FechaCalculo.resaltarCampoOmitido = false;
            this.dtp_FechaCalculo.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.dtp_FechaCalculo.Size = new System.Drawing.Size(97, 22);
            this.dtp_FechaCalculo.TabIndex = 663;
            this.dtp_FechaCalculo.Value = new System.DateTime(2013, 12, 18, 0, 0, 0, 0);
            // 
            // Cbo_TipoProceso
            // 
            this.Cbo_TipoProceso.BackColor = System.Drawing.Color.White;
            this.Cbo_TipoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_TipoProceso.Enabled = false;
            this.Cbo_TipoProceso.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_TipoProceso.FormattingEnabled = true;
            this.Cbo_TipoProceso.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_TipoProceso.Location = new System.Drawing.Point(143, 91);
            this.Cbo_TipoProceso.Name = "Cbo_TipoProceso";
            this.Cbo_TipoProceso.nombreDS = null;
            this.Cbo_TipoProceso.nombreSP = "Logistica.spp_cbo_ctrl_TipoProceso";
            this.Cbo_TipoProceso.parametrosSP = "";
            this.Cbo_TipoProceso.resaltarCampoOmitido = false;
            this.Cbo_TipoProceso.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_TipoProceso.Size = new System.Drawing.Size(222, 21);
            this.Cbo_TipoProceso.TabIndex = 143;
            this.Cbo_TipoProceso.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            this.Cbo_TipoProceso.SelectedIndexChanged += new System.EventHandler(this.Cbo_TipoProceso_SelectedIndexChanged);
            // 
            // Cbo_ObjetoContratacion
            // 
            this.Cbo_ObjetoContratacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_ObjetoContratacion.Enabled = false;
            this.Cbo_ObjetoContratacion.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_ObjetoContratacion.FormattingEnabled = true;
            this.Cbo_ObjetoContratacion.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_ObjetoContratacion.Location = new System.Drawing.Point(143, 118);
            this.Cbo_ObjetoContratacion.Name = "Cbo_ObjetoContratacion";
            this.Cbo_ObjetoContratacion.nombreDS = null;
            this.Cbo_ObjetoContratacion.nombreSP = "Logistica.spp_cbo_ctrl_ObjetoContratacion";
            this.Cbo_ObjetoContratacion.parametrosSP = "";
            this.Cbo_ObjetoContratacion.resaltarCampoOmitido = false;
            this.Cbo_ObjetoContratacion.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_ObjetoContratacion.Size = new System.Drawing.Size(222, 21);
            this.Cbo_ObjetoContratacion.TabIndex = 144;
            this.Cbo_ObjetoContratacion.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // UltraLabel6
            // 
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.UltraLabel6.Appearance = appearance4;
            this.UltraLabel6.AutoSize = true;
            this.UltraLabel6.Location = new System.Drawing.Point(50, 94);
            this.UltraLabel6.Name = "UltraLabel6";
            this.UltraLabel6.Size = new System.Drawing.Size(88, 15);
            this.UltraLabel6.TabIndex = 146;
            this.UltraLabel6.Text = "Tipo de Proceso:";
            // 
            // UltraLabel5
            // 
            Appearance10.BackColor = System.Drawing.Color.Transparent;
            this.UltraLabel5.Appearance = Appearance10;
            this.UltraLabel5.AutoSize = true;
            this.UltraLabel5.Location = new System.Drawing.Point(14, 121);
            this.UltraLabel5.Name = "UltraLabel5";
            this.UltraLabel5.Size = new System.Drawing.Size(124, 15);
            this.UltraLabel5.TabIndex = 145;
            this.UltraLabel5.Text = "Objeto de Contratacion:";
            // 
            // ultraLabel1
            // 
            appearance5.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel1.Appearance = appearance5;
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(44, 42);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(94, 15);
            this.ultraLabel1.TabIndex = 139;
            this.ultraLabel1.Text = "Proceso Logistico:";
            // 
            // Txt_NumProcedimiento
            // 
            this.Txt_NumProcedimiento.anchoColumnasAyuda = "100, 470";
            this.Txt_NumProcedimiento.DatoAnterior = "";
            this.Txt_NumProcedimiento.EligevariosElementos = false;
            this.Txt_NumProcedimiento.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_NumProcedimiento.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_NumProcedimiento.exigirCampoLleno = false;
            this.Txt_NumProcedimiento.InputMask = null;
            this.Txt_NumProcedimiento.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_NumProcedimiento.Location = new System.Drawing.Point(143, 39);
            this.Txt_NumProcedimiento.LongitudTexto = 200;
            this.Txt_NumProcedimiento.mensajeExisteDatoSP = "";
            this.Txt_NumProcedimiento.mensajeNoExisteDatoSP = "";
            this.Txt_NumProcedimiento.Name = "Txt_NumProcedimiento";
            this.Txt_NumProcedimiento.nombreDS = null;
            this.Txt_NumProcedimiento.nombreExisteDatoSP = "";
            this.Txt_NumProcedimiento.nombreNoExisteDatoSP = "";
            this.Txt_NumProcedimiento.nombreSP = "";
            this.Txt_NumProcedimiento.parametrosExisteDatoSP = "";
            this.Txt_NumProcedimiento.parametrosNoExisteDatoSP = "";
            this.Txt_NumProcedimiento.parametrosSP = null;
            this.Txt_NumProcedimiento.PosicionCampo = 0;
            this.Txt_NumProcedimiento.PosicionCampoTexto = 1;
            this.Txt_NumProcedimiento.PosicionValue = 0;
            this.Txt_NumProcedimiento.resaltarCampoOmitido = false;
            this.Txt_NumProcedimiento.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_NumProcedimiento.Size = new System.Drawing.Size(115, 22);
            this.Txt_NumProcedimiento.TabIndex = 137;
            this.Txt_NumProcedimiento.tipoAyuda = gnUserControl.gnTextBox.Ayuda.ConAyudaInicial;
            this.Txt_NumProcedimiento.tipoDato = gnUserControl.gnTextBox.Tipo.Alfanumerico;
            this.Txt_NumProcedimiento.tipoDatoC = gnUserControl.gnTextBox.TipoC.Ninguno;
            this.Txt_NumProcedimiento.tipoextraccion = gnUserControl.gnTextBox.TipoExtra.DataSet;
            this.Txt_NumProcedimiento.valorDevueltoVarios = "";
            this.Txt_NumProcedimiento.ValorDigitado = "";
            this.Txt_NumProcedimiento.Leave += new System.EventHandler(this.Txt_NumProcedimiento_Leave);
            // 
            // Edt_DesProcedimiento
            // 
            appearance2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Edt_DesProcedimiento.Appearance = appearance2;
            this.Edt_DesProcedimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Edt_DesProcedimiento.Enabled = false;
            this.Edt_DesProcedimiento.Location = new System.Drawing.Point(143, 62);
            this.Edt_DesProcedimiento.Multiline = true;
            this.Edt_DesProcedimiento.Name = "Edt_DesProcedimiento";
            this.Edt_DesProcedimiento.Size = new System.Drawing.Size(776, 23);
            this.Edt_DesProcedimiento.TabIndex = 138;
            // 
            // Btn_Mostrar
            // 
            this.Btn_Mostrar.Location = new System.Drawing.Point(961, 116);
            this.Btn_Mostrar.Name = "Btn_Mostrar";
            this.Btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Mostrar.TabIndex = 122;
            this.Btn_Mostrar.Text = "Mostrar";
            this.Btn_Mostrar.UseVisualStyleBackColor = true;
            this.Btn_Mostrar.Click += new System.EventHandler(this.Btn_Mostrar_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.spreadsheetControl);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1055, 680);
            this.panelControl1.TabIndex = 131;
            // 
            // spreadsheetControl
            // 
            this.spreadsheetControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl.Location = new System.Drawing.Point(0, 153);
            this.spreadsheetControl.Name = "spreadsheetControl";
            this.spreadsheetControl.Size = new System.Drawing.Size(1055, 527);
            this.spreadsheetControl.TabIndex = 11;
            this.spreadsheetControl.Text = "spreadsheetControl1";
            // 
            // UC_Programacion_CurvaS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "UC_Programacion_CurvaS";
            this.Size = new System.Drawing.Size(1055, 680);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_FechaCalculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NumProcedimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edt_DesProcedimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button Btn_Mostrar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        internal Infragistics.Win.Misc.UltraLabel ultraLabel1;
        internal gnUserControl.gnTextBox Txt_NumProcedimiento;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor Edt_DesProcedimiento;
        internal gnUserControl.gnComboBox Cbo_TipoProceso;
        internal gnUserControl.gnComboBox Cbo_ObjetoContratacion;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel6;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel5;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl;
        internal Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private System.Windows.Forms.RadioButton Opt_FechaBuenaPro;
        private System.Windows.Forms.RadioButton Opt_FechaConvocatoria;
        internal System.Windows.Forms.Label Lbl_FechaConvocatoria;
        internal gnUserControl.gnDateTimePicker dtp_FechaCalculo;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Chk_EstaEnListaPAC;
    }
}
