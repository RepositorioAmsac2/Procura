namespace WINlogistica
{
    partial class Frm_ActualizaPaso_Apertura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ActualizaPaso_Apertura));
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.grd_mvto_Activo = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.UltraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.txt_DesCeGes = new gnUserControl.gnTextBox();
            this.txt_CodCeges = new gnUserControl.gnTextBox();
            this.CLabel3 = new System.Windows.Forms.Label();
            this.cbo_Version = new gnUserControl.gnComboBox();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.CLabel1 = new System.Windows.Forms.Label();
            this.CLabel2 = new System.Windows.Forms.Label();
            this.cbo_PeriodoProceso = new gnUserControl.gnComboBox();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Exportar = new System.Windows.Forms.ToolStripButton();
            this.SaveDocumento = new System.Windows.Forms.SaveFileDialog();
            this.UltraGridExcelExporter1 = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_mvto_Activo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).BeginInit();
            this.UltraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DesCeGes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CodCeges)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.ultraGroupBox1.Controls.Add(this.grd_mvto_Activo);
            this.ultraGroupBox1.Controls.Add(this.UltraGroupBox2);
            this.ultraGroupBox1.Controls.Add(this.ToolStrip1);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(885, 414);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
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
            this.grd_mvto_Activo.Location = new System.Drawing.Point(1, 70);
            this.grd_mvto_Activo.Name = "grd_mvto_Activo";
            this.grd_mvto_Activo.Size = new System.Drawing.Size(883, 343);
            this.grd_mvto_Activo.TabIndex = 53;
            this.grd_mvto_Activo.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.grd_mvto_Activo_InitializeLayout);
            this.grd_mvto_Activo.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.grd_mvto_Activo_ClickCellButton);
            this.grd_mvto_Activo.DoubleClickCell += new Infragistics.Win.UltraWinGrid.DoubleClickCellEventHandler(this.grd_mvto_Activo_DoubleClickCell);
            // 
            // UltraGroupBox2
            // 
            this.UltraGroupBox2.Controls.Add(this.txt_DesCeGes);
            this.UltraGroupBox2.Controls.Add(this.txt_CodCeges);
            this.UltraGroupBox2.Controls.Add(this.CLabel3);
            this.UltraGroupBox2.Controls.Add(this.cbo_Version);
            this.UltraGroupBox2.Controls.Add(this.btn_Mostrar);
            this.UltraGroupBox2.Controls.Add(this.CLabel1);
            this.UltraGroupBox2.Controls.Add(this.CLabel2);
            this.UltraGroupBox2.Controls.Add(this.cbo_PeriodoProceso);
            this.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.UltraGroupBox2.Location = new System.Drawing.Point(1, 25);
            this.UltraGroupBox2.Name = "UltraGroupBox2";
            this.UltraGroupBox2.Size = new System.Drawing.Size(883, 45);
            this.UltraGroupBox2.TabIndex = 46;
            this.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // txt_DesCeGes
            // 
            this.txt_DesCeGes.anchoColumnasAyuda = "150,70";
            this.txt_DesCeGes.DatoAnterior = "";
            this.txt_DesCeGes.Enabled = false;
            this.txt_DesCeGes.enabledFocusColor = System.Drawing.Color.Lavender;
            this.txt_DesCeGes.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.txt_DesCeGes.exigirCampoLleno = false;
            this.txt_DesCeGes.InputMask = "";
            this.txt_DesCeGes.leaveFocusColor = System.Drawing.Color.White;
            this.txt_DesCeGes.Location = new System.Drawing.Point(519, 12);
            this.txt_DesCeGes.LongitudTexto = 200;
            this.txt_DesCeGes.mensajeExisteDatoSP = "";
            this.txt_DesCeGes.mensajeNoExisteDatoSP = "";
            this.txt_DesCeGes.Name = "txt_DesCeGes";
            this.txt_DesCeGes.nombreDS = null;
            this.txt_DesCeGes.nombreExisteDatoSP = "";
            this.txt_DesCeGes.nombreNoExisteDatoSP = "";
            this.txt_DesCeGes.nombreSP = "";
            this.txt_DesCeGes.parametrosExisteDatoSP = "";
            this.txt_DesCeGes.parametrosNoExisteDatoSP = "";
            this.txt_DesCeGes.parametrosSP = "";
            this.txt_DesCeGes.PosicionCampo = 1;
            this.txt_DesCeGes.PosicionCampoTexto = 1;
            this.txt_DesCeGes.PosicionValue = 1;
            this.txt_DesCeGes.resaltarCampoOmitido = false;
            this.txt_DesCeGes.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.txt_DesCeGes.Size = new System.Drawing.Size(273, 21);
            this.txt_DesCeGes.TabIndex = 93;
            this.txt_DesCeGes.tipoAyuda = gnUserControl.gnTextBox.Ayuda.SinAyudaInicial;
            this.txt_DesCeGes.tipoDato = gnUserControl.gnTextBox.Tipo.Ninguno;
            this.txt_DesCeGes.tipoDatoC = gnUserControl.gnTextBox.TipoC.Ninguno;
            this.txt_DesCeGes.tipoextraccion = gnUserControl.gnTextBox.TipoExtra.StoredProcedure;
            this.txt_DesCeGes.ValorDigitado = "";
            // 
            // txt_CodCeges
            // 
            this.txt_CodCeges.anchoColumnasAyuda = "70,500";
            this.txt_CodCeges.DatoAnterior = "";
            this.txt_CodCeges.enabledFocusColor = System.Drawing.Color.Lavender;
            this.txt_CodCeges.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.txt_CodCeges.exigirCampoLleno = false;
            this.txt_CodCeges.InputMask = "";
            this.txt_CodCeges.leaveFocusColor = System.Drawing.Color.White;
            this.txt_CodCeges.Location = new System.Drawing.Point(410, 13);
            this.txt_CodCeges.LongitudTexto = 200;
            this.txt_CodCeges.mensajeExisteDatoSP = "";
            this.txt_CodCeges.mensajeNoExisteDatoSP = "";
            this.txt_CodCeges.Name = "txt_CodCeges";
            this.txt_CodCeges.nombreDS = null;
            this.txt_CodCeges.nombreExisteDatoSP = "";
            this.txt_CodCeges.nombreNoExisteDatoSP = "";
            this.txt_CodCeges.nombreSP = "";
            this.txt_CodCeges.parametrosExisteDatoSP = "";
            this.txt_CodCeges.parametrosNoExisteDatoSP = "";
            this.txt_CodCeges.parametrosSP = "";
            this.txt_CodCeges.PosicionCampo = 0;
            this.txt_CodCeges.PosicionCampoTexto = 1;
            this.txt_CodCeges.PosicionValue = 0;
            this.txt_CodCeges.resaltarCampoOmitido = false;
            this.txt_CodCeges.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.txt_CodCeges.Size = new System.Drawing.Size(105, 21);
            this.txt_CodCeges.TabIndex = 92;
            this.txt_CodCeges.tipoAyuda = gnUserControl.gnTextBox.Ayuda.ConAyudaInicial;
            this.txt_CodCeges.tipoDato = gnUserControl.gnTextBox.Tipo.Ninguno;
            this.txt_CodCeges.tipoDatoC = gnUserControl.gnTextBox.TipoC.Ninguno;
            this.txt_CodCeges.tipoextraccion = gnUserControl.gnTextBox.TipoExtra.DataSet;
            this.txt_CodCeges.ValorDigitado = "";
            this.txt_CodCeges.Leave += new System.EventHandler(this.txt_CodCeges_Leave);
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
            // cbo_Version
            // 
            this.cbo_Version.BackColor = System.Drawing.Color.White;
            this.cbo_Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Version.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.cbo_Version.FormattingEnabled = true;
            this.cbo_Version.leaveFocusColor = System.Drawing.Color.White;
            this.cbo_Version.Location = new System.Drawing.Point(234, 13);
            this.cbo_Version.Name = "cbo_Version";
            this.cbo_Version.nombreDS = null;
            this.cbo_Version.nombreSP = "Logistica.spp_cbo_mvto_PAC_Cabecera_Version";
            this.cbo_Version.parametrosSP = "";
            this.cbo_Version.resaltarCampoOmitido = false;
            this.cbo_Version.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.cbo_Version.Size = new System.Drawing.Size(84, 21);
            this.cbo_Version.TabIndex = 30;
            this.cbo_Version.tipoConsumo = gnUserControl.gnComboBox.Tipo.StoredProcedure;
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
            // cbo_PeriodoProceso
            // 
            this.cbo_PeriodoProceso.BackColor = System.Drawing.Color.White;
            this.cbo_PeriodoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_PeriodoProceso.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.cbo_PeriodoProceso.FormattingEnabled = true;
            this.cbo_PeriodoProceso.leaveFocusColor = System.Drawing.Color.White;
            this.cbo_PeriodoProceso.Location = new System.Drawing.Point(97, 13);
            this.cbo_PeriodoProceso.Name = "cbo_PeriodoProceso";
            this.cbo_PeriodoProceso.nombreDS = null;
            this.cbo_PeriodoProceso.nombreSP = "";
            this.cbo_PeriodoProceso.parametrosSP = "";
            this.cbo_PeriodoProceso.resaltarCampoOmitido = false;
            this.cbo_PeriodoProceso.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.cbo_PeriodoProceso.Size = new System.Drawing.Size(78, 21);
            this.cbo_PeriodoProceso.TabIndex = 26;
            this.cbo_PeriodoProceso.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            this.cbo_PeriodoProceso.Leave += new System.EventHandler(this.cbo_PeriodoProceso_Leave);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Exportar});
            this.ToolStrip1.Location = new System.Drawing.Point(1, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(883, 25);
            this.ToolStrip1.TabIndex = 44;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // tsb_Exportar
            // 
            this.tsb_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Exportar.Name = "tsb_Exportar";
            this.tsb_Exportar.Size = new System.Drawing.Size(54, 22);
            this.tsb_Exportar.Text = "Exportar";
            this.tsb_Exportar.Click += new System.EventHandler(this.tsb_Exportar_Click);
            // 
            // SaveDocumento
            // 
            this.SaveDocumento.DefaultExt = "XLS";
            this.SaveDocumento.Filter = "Excel (*.xls)|*.xls";
            this.SaveDocumento.RestoreDirectory = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mod_Documento.bmp");
            this.imageList1.Images.SetKeyName(1, "del_Documento.bmp");
            this.imageList1.Images.SetKeyName(2, "esfera_ambar.png");
            this.imageList1.Images.SetKeyName(3, "esfera_roja.jpg");
            this.imageList1.Images.SetKeyName(4, "esfera_verde.png");
            // 
            // Frm_AperturaProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 414);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "Frm_AperturaProceso";
            this.Text = "Frm_AperturaProceso";
            this.Load += new System.EventHandler(this.Frm_AperturaProceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_mvto_Activo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).EndInit();
            this.UltraGroupBox2.ResumeLayout(false);
            this.UltraGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DesCeGes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CodCeges)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        internal Infragistics.Win.UltraWinGrid.UltraGrid grd_mvto_Activo;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox2;
        internal gnUserControl.gnTextBox txt_DesCeGes;
        internal gnUserControl.gnTextBox txt_CodCeges;
        internal System.Windows.Forms.Label CLabel3;
        internal gnUserControl.gnComboBox cbo_Version;
        internal System.Windows.Forms.Button btn_Mostrar;
        internal System.Windows.Forms.Label CLabel1;
        internal System.Windows.Forms.Label CLabel2;
        internal gnUserControl.gnComboBox cbo_PeriodoProceso;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton tsb_Exportar;
        internal System.Windows.Forms.SaveFileDialog SaveDocumento;
        internal Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter UltraGridExcelExporter1;
        private System.Windows.Forms.ImageList imageList1;
    }
}