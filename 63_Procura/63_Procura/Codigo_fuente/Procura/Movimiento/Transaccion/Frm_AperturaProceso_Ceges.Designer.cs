namespace WINlogistica
{
    partial class Frm_AperturaProceso_Ceges
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
            Infragistics.Win.Appearance Appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance7 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AperturaProceso_Ceges));
            this.UltraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.grd_mvto_Activo = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Exportar = new System.Windows.Forms.ToolStripButton();
            this.UltraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Txt_DesCeGes = new gnUserControl.gnTextBox();
            this.Txt_CodCeges = new gnUserControl.gnTextBox();
            this.CLabel3 = new System.Windows.Forms.Label();
            this.Cbo_Version = new gnUserControl.gnComboBox();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.CLabel1 = new System.Windows.Forms.Label();
            this.CLabel2 = new System.Windows.Forms.Label();
            this.Cbo_PeriodoProceso = new gnUserControl.gnComboBox();
            this.SaveDocumento = new System.Windows.Forms.SaveFileDialog();
            this.UltraGridExcelExporter1 = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox1)).BeginInit();
            this.UltraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).BeginInit();
            this.ultraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_mvto_Activo)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).BeginInit();
            this.UltraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DesCeGes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CodCeges)).BeginInit();
            this.SuspendLayout();
            // 
            // UltraGroupBox1
            // 
            this.UltraGroupBox1.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.UltraGroupBox1.Controls.Add(this.ultraGroupBox3);
            this.UltraGroupBox1.Controls.Add(this.UltraGroupBox2);
            this.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.UltraGroupBox1.Name = "UltraGroupBox1";
            this.UltraGroupBox1.Size = new System.Drawing.Size(888, 450);
            this.UltraGroupBox1.TabIndex = 1;
            this.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // ultraGroupBox3
            // 
            this.ultraGroupBox3.Controls.Add(this.grd_mvto_Activo);
            this.ultraGroupBox3.Controls.Add(this.ToolStrip1);
            this.ultraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox3.Location = new System.Drawing.Point(1, 45);
            this.ultraGroupBox3.Name = "ultraGroupBox3";
            this.ultraGroupBox3.Size = new System.Drawing.Size(886, 404);
            this.ultraGroupBox3.TabIndex = 46;
            this.ultraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // grd_mvto_Activo
            // 
            Appearance10.BackColor = System.Drawing.Color.Transparent;
            Appearance10.BackColor2 = System.Drawing.Color.Transparent;
            Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal;
            this.grd_mvto_Activo.DisplayLayout.Appearance = Appearance10;
            this.grd_mvto_Activo.DisplayLayout.InterBandSpacing = 10;
            Appearance2.BackColor = System.Drawing.Color.PowderBlue;
            Appearance2.BackColor2 = System.Drawing.Color.PowderBlue;
            this.grd_mvto_Activo.DisplayLayout.Override.ActiveCellAppearance = Appearance2;
            Appearance3.BackColor = System.Drawing.Color.Transparent;
            this.grd_mvto_Activo.DisplayLayout.Override.CardAreaAppearance = Appearance3;
            Appearance4.BackColor = System.Drawing.Color.Transparent;
            Appearance4.BackColor2 = System.Drawing.Color.Transparent;
            Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance4.ForeColor = System.Drawing.Color.Black;
            Appearance4.TextHAlignAsString = "Center";
            Appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.grd_mvto_Activo.DisplayLayout.Override.HeaderAppearance = Appearance4;
            Appearance5.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.grd_mvto_Activo.DisplayLayout.Override.RowAppearance = Appearance5;
            Appearance6.BackColor = System.Drawing.Color.PapayaWhip;
            Appearance6.BackColor2 = System.Drawing.Color.PapayaWhip;
            Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.grd_mvto_Activo.DisplayLayout.Override.RowSelectorAppearance = Appearance6;
            this.grd_mvto_Activo.DisplayLayout.Override.RowSelectorWidth = 12;
            this.grd_mvto_Activo.DisplayLayout.Override.RowSpacingBefore = 2;
            Appearance7.BackColor = System.Drawing.Color.PapayaWhip;
            Appearance7.BackColor2 = System.Drawing.Color.PapayaWhip;
            Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance7.ForeColor = System.Drawing.Color.Black;
            this.grd_mvto_Activo.DisplayLayout.Override.SelectedRowAppearance = Appearance7;
            this.grd_mvto_Activo.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.grd_mvto_Activo.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.grd_mvto_Activo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_mvto_Activo.Location = new System.Drawing.Point(3, 25);
            this.grd_mvto_Activo.Name = "grd_mvto_Activo";
            this.grd_mvto_Activo.Size = new System.Drawing.Size(880, 376);
            this.grd_mvto_Activo.TabIndex = 53;
            this.grd_mvto_Activo.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.grd_mvto_Activo_InitializeLayout);
            this.grd_mvto_Activo.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.grd_mvto_Activo_ClickCellButton);
            this.grd_mvto_Activo.DoubleClickCell += new Infragistics.Win.UltraWinGrid.DoubleClickCellEventHandler(this.grd_mvto_Activo_DoubleClickCell);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Exportar});
            this.ToolStrip1.Location = new System.Drawing.Point(3, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(880, 25);
            this.ToolStrip1.TabIndex = 44;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // tsb_Exportar
            // 
            this.tsb_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Exportar.Name = "tsb_Exportar";
            this.tsb_Exportar.Size = new System.Drawing.Size(55, 22);
            this.tsb_Exportar.Text = "Exportar";
            this.tsb_Exportar.Click += new System.EventHandler(this.tsb_Exportar_Click);
            // 
            // UltraGroupBox2
            // 
            this.UltraGroupBox2.Controls.Add(this.Txt_DesCeGes);
            this.UltraGroupBox2.Controls.Add(this.Txt_CodCeges);
            this.UltraGroupBox2.Controls.Add(this.CLabel3);
            this.UltraGroupBox2.Controls.Add(this.Cbo_Version);
            this.UltraGroupBox2.Controls.Add(this.btn_Mostrar);
            this.UltraGroupBox2.Controls.Add(this.CLabel1);
            this.UltraGroupBox2.Controls.Add(this.CLabel2);
            this.UltraGroupBox2.Controls.Add(this.Cbo_PeriodoProceso);
            this.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.UltraGroupBox2.Location = new System.Drawing.Point(1, 0);
            this.UltraGroupBox2.Name = "UltraGroupBox2";
            this.UltraGroupBox2.Size = new System.Drawing.Size(886, 45);
            this.UltraGroupBox2.TabIndex = 45;
            this.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Txt_DesCeGes
            // 
            this.Txt_DesCeGes.anchoColumnasAyuda = "150,70";
            this.Txt_DesCeGes.DatoAnterior = "";
            this.Txt_DesCeGes.EligevariosElementos = false;
            this.Txt_DesCeGes.Enabled = false;
            this.Txt_DesCeGes.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_DesCeGes.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_DesCeGes.exigirCampoLleno = false;
            this.Txt_DesCeGes.InputMask = "";
            this.Txt_DesCeGes.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_DesCeGes.Location = new System.Drawing.Point(519, 12);
            this.Txt_DesCeGes.LongitudTexto = 200;
            this.Txt_DesCeGes.mensajeExisteDatoSP = "";
            this.Txt_DesCeGes.mensajeNoExisteDatoSP = "";
            this.Txt_DesCeGes.Name = "Txt_DesCeGes";
            this.Txt_DesCeGes.nombreDS = null;
            this.Txt_DesCeGes.nombreExisteDatoSP = "";
            this.Txt_DesCeGes.nombreNoExisteDatoSP = "";
            this.Txt_DesCeGes.nombreSP = "";
            this.Txt_DesCeGes.parametrosExisteDatoSP = "";
            this.Txt_DesCeGes.parametrosNoExisteDatoSP = "";
            this.Txt_DesCeGes.parametrosSP = "";
            this.Txt_DesCeGes.PosicionCampo = 1;
            this.Txt_DesCeGes.PosicionCampoTexto = 1;
            this.Txt_DesCeGes.PosicionValue = 1;
            this.Txt_DesCeGes.resaltarCampoOmitido = false;
            this.Txt_DesCeGes.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_DesCeGes.Size = new System.Drawing.Size(273, 21);
            this.Txt_DesCeGes.TabIndex = 93;
            this.Txt_DesCeGes.tipoAyuda = gnUserControl.gnTextBox.Ayuda.SinAyudaInicial;
            this.Txt_DesCeGes.tipoDato = gnUserControl.gnTextBox.Tipo.Ninguno;
            this.Txt_DesCeGes.tipoDatoC = gnUserControl.gnTextBox.TipoC.Ninguno;
            this.Txt_DesCeGes.tipoextraccion = gnUserControl.gnTextBox.TipoExtra.DataSet;
            this.Txt_DesCeGes.valorDevueltoVarios = "";
            this.Txt_DesCeGes.ValorDigitado = "";
            // 
            // Txt_CodCeges
            // 
            this.Txt_CodCeges.anchoColumnasAyuda = "70,500";
            this.Txt_CodCeges.DatoAnterior = "";
            this.Txt_CodCeges.EligevariosElementos = false;
            this.Txt_CodCeges.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_CodCeges.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_CodCeges.exigirCampoLleno = false;
            this.Txt_CodCeges.InputMask = "";
            this.Txt_CodCeges.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_CodCeges.Location = new System.Drawing.Point(410, 13);
            this.Txt_CodCeges.LongitudTexto = 200;
            this.Txt_CodCeges.mensajeExisteDatoSP = "";
            this.Txt_CodCeges.mensajeNoExisteDatoSP = "";
            this.Txt_CodCeges.Name = "Txt_CodCeges";
            this.Txt_CodCeges.nombreDS = null;
            this.Txt_CodCeges.nombreExisteDatoSP = "";
            this.Txt_CodCeges.nombreNoExisteDatoSP = "";
            this.Txt_CodCeges.nombreSP = "";
            this.Txt_CodCeges.parametrosExisteDatoSP = "";
            this.Txt_CodCeges.parametrosNoExisteDatoSP = "";
            this.Txt_CodCeges.parametrosSP = "";
            this.Txt_CodCeges.PosicionCampo = 0;
            this.Txt_CodCeges.PosicionCampoTexto = 1;
            this.Txt_CodCeges.PosicionValue = 0;
            this.Txt_CodCeges.resaltarCampoOmitido = false;
            this.Txt_CodCeges.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_CodCeges.Size = new System.Drawing.Size(105, 21);
            this.Txt_CodCeges.TabIndex = 92;
            this.Txt_CodCeges.tipoAyuda = gnUserControl.gnTextBox.Ayuda.ConAyudaInicial;
            this.Txt_CodCeges.tipoDato = gnUserControl.gnTextBox.Tipo.Ninguno;
            this.Txt_CodCeges.tipoDatoC = gnUserControl.gnTextBox.TipoC.Ninguno;
            this.Txt_CodCeges.tipoextraccion = gnUserControl.gnTextBox.TipoExtra.DataSet;
            this.Txt_CodCeges.valorDevueltoVarios = "";
            this.Txt_CodCeges.ValorDigitado = "";
            this.Txt_CodCeges.Leave += new System.EventHandler(this.Txt_CodCeges_Leave);
            // 
            // CLabel3
            // 
            this.CLabel3.AutoSize = true;
            this.CLabel3.BackColor = System.Drawing.Color.Transparent;
            this.CLabel3.Location = new System.Drawing.Point(332, 17);
            this.CLabel3.Name = "CLabel3";
            this.CLabel3.Size = new System.Drawing.Size(75, 13);
            this.CLabel3.TabIndex = 91;
            this.CLabel3.Text = "Centro Gestor:";
            // 
            // Cbo_Version
            // 
            this.Cbo_Version.BackColor = System.Drawing.Color.White;
            this.Cbo_Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Version.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_Version.FormattingEnabled = true;
            this.Cbo_Version.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_Version.Location = new System.Drawing.Point(234, 13);
            this.Cbo_Version.Name = "Cbo_Version";
            this.Cbo_Version.nombreDS = null;
            this.Cbo_Version.nombreSP = "";
            this.Cbo_Version.parametrosSP = "";
            this.Cbo_Version.resaltarCampoOmitido = false;
            this.Cbo_Version.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_Version.Size = new System.Drawing.Size(84, 21);
            this.Cbo_Version.TabIndex = 30;
            this.Cbo_Version.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(798, 12);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Mostrar.TabIndex = 23;
            this.btn_Mostrar.Text = "&Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // CLabel1
            // 
            this.CLabel1.AutoSize = true;
            this.CLabel1.BackColor = System.Drawing.Color.Transparent;
            this.CLabel1.Location = new System.Drawing.Point(186, 17);
            this.CLabel1.Name = "CLabel1";
            this.CLabel1.Size = new System.Drawing.Size(45, 13);
            this.CLabel1.TabIndex = 29;
            this.CLabel1.Text = "Versión:";
            // 
            // CLabel2
            // 
            this.CLabel2.AutoSize = true;
            this.CLabel2.BackColor = System.Drawing.Color.Transparent;
            this.CLabel2.Location = new System.Drawing.Point(9, 16);
            this.CLabel2.Name = "CLabel2";
            this.CLabel2.Size = new System.Drawing.Size(86, 13);
            this.CLabel2.TabIndex = 25;
            this.CLabel2.Text = "Año de Proceso:";
            // 
            // Cbo_PeriodoProceso
            // 
            this.Cbo_PeriodoProceso.BackColor = System.Drawing.Color.White;
            this.Cbo_PeriodoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_PeriodoProceso.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_PeriodoProceso.FormattingEnabled = true;
            this.Cbo_PeriodoProceso.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_PeriodoProceso.Location = new System.Drawing.Point(97, 13);
            this.Cbo_PeriodoProceso.Name = "Cbo_PeriodoProceso";
            this.Cbo_PeriodoProceso.nombreDS = null;
            this.Cbo_PeriodoProceso.nombreSP = "";
            this.Cbo_PeriodoProceso.parametrosSP = "";
            this.Cbo_PeriodoProceso.resaltarCampoOmitido = false;
            this.Cbo_PeriodoProceso.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_PeriodoProceso.Size = new System.Drawing.Size(78, 21);
            this.Cbo_PeriodoProceso.TabIndex = 26;
            this.Cbo_PeriodoProceso.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // SaveDocumento
            // 
            this.SaveDocumento.DefaultExt = "XLS";
            this.SaveDocumento.Filter = "Excel (*.xls)|*.xls";
            this.SaveDocumento.RestoreDirectory = true;
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Silver;
            this.ImageList1.Images.SetKeyName(0, "esfera_verde.png");
            this.ImageList1.Images.SetKeyName(1, "esfera_roja.jpg");
            this.ImageList1.Images.SetKeyName(2, "esfera_ambar.png");
            // 
            // Frm_AperturaProceso_Ceges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.UltraGroupBox1);
            this.Name = "Frm_AperturaProceso_Ceges";
            this.Text = "Frm_AperturaProceso_Ceges";
            this.Load += new System.EventHandler(this.Frm_AperturaProceso_Ceges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox1)).EndInit();
            this.UltraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).EndInit();
            this.ultraGroupBox3.ResumeLayout(false);
            this.ultraGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_mvto_Activo)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).EndInit();
            this.UltraGroupBox2.ResumeLayout(false);
            this.UltraGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DesCeGes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CodCeges)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox1;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox2;
        internal gnUserControl.gnTextBox Txt_DesCeGes;
        internal gnUserControl.gnTextBox Txt_CodCeges;
        internal System.Windows.Forms.Label CLabel3;
        internal gnUserControl.gnComboBox Cbo_Version;
        internal System.Windows.Forms.Button btn_Mostrar;
        internal System.Windows.Forms.Label CLabel1;
        internal System.Windows.Forms.Label CLabel2;
        internal gnUserControl.gnComboBox Cbo_PeriodoProceso;
        internal Infragistics.Win.Misc.UltraGroupBox ultraGroupBox3;
        internal Infragistics.Win.UltraWinGrid.UltraGrid grd_mvto_Activo;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton tsb_Exportar;
        internal System.Windows.Forms.SaveFileDialog SaveDocumento;
        internal Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter UltraGridExcelExporter1;
        internal System.Windows.Forms.ImageList ImageList1;
    }
}