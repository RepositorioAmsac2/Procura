namespace WINlogistica
{
    partial class Frm_ControlItemPAC
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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ControlItemPAC));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.UltraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Grd_mvto_ItemPAC = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.Menu_Opciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Btn_AperturaCierre_paso = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Separador01 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Gantt = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Exportar = new System.Windows.Forms.ToolStripButton();
            this.UltraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Txt_DesProcesoLogistico = new gnUserControl.gnTextBox();
            this.Txt_CodProcesoLogistico = new gnUserControl.gnTextBox();
            this.UltraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.Btn_Mostrar = new System.Windows.Forms.Button();
            this.SaveDocumento = new System.Windows.Forms.SaveFileDialog();
            this.UltraGridExcelExporter1 = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Cbo_PeriodoProceso = new gnUserControl.gnComboBox();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).BeginInit();
            this.UltraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_mvto_ItemPAC)).BeginInit();
            this.Menu_Opciones.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).BeginInit();
            this.UltraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DesProcesoLogistico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CodProcesoLogistico)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.ultraGroupBox1.Controls.Add(this.UltraGroupBox3);
            this.ultraGroupBox1.Controls.Add(this.UltraGroupBox2);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(958, 405);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // UltraGroupBox3
            // 
            this.UltraGroupBox3.Controls.Add(this.Grd_mvto_ItemPAC);
            this.UltraGroupBox3.Controls.Add(this.ToolStrip1);
            this.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.UltraGroupBox3.Location = new System.Drawing.Point(1, 53);
            this.UltraGroupBox3.Name = "UltraGroupBox3";
            this.UltraGroupBox3.Size = new System.Drawing.Size(956, 351);
            this.UltraGroupBox3.TabIndex = 4;
            this.UltraGroupBox3.Text = "2. Lista de lineas de formulación";
            this.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Grd_mvto_ItemPAC
            // 
            this.Grd_mvto_ItemPAC.ContextMenuStrip = this.Menu_Opciones;
            Appearance10.BackColor = System.Drawing.Color.Transparent;
            Appearance10.BackColor2 = System.Drawing.Color.Transparent;
            Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal;
            this.Grd_mvto_ItemPAC.DisplayLayout.Appearance = Appearance10;
            this.Grd_mvto_ItemPAC.DisplayLayout.InterBandSpacing = 10;
            Appearance2.BackColor = System.Drawing.Color.PowderBlue;
            Appearance2.BackColor2 = System.Drawing.Color.PowderBlue;
            this.Grd_mvto_ItemPAC.DisplayLayout.Override.ActiveCellAppearance = Appearance2;
            Appearance3.BackColor = System.Drawing.Color.Transparent;
            this.Grd_mvto_ItemPAC.DisplayLayout.Override.CardAreaAppearance = Appearance3;
            Appearance4.BackColor = System.Drawing.Color.Transparent;
            Appearance4.BackColor2 = System.Drawing.Color.Transparent;
            Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance4.ForeColor = System.Drawing.Color.Black;
            Appearance4.TextHAlignAsString = "Center";
            Appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.Grd_mvto_ItemPAC.DisplayLayout.Override.HeaderAppearance = Appearance4;
            Appearance5.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Grd_mvto_ItemPAC.DisplayLayout.Override.RowAppearance = Appearance5;
            Appearance6.BackColor = System.Drawing.Color.PapayaWhip;
            Appearance6.BackColor2 = System.Drawing.Color.PapayaWhip;
            Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.Grd_mvto_ItemPAC.DisplayLayout.Override.RowSelectorAppearance = Appearance6;
            this.Grd_mvto_ItemPAC.DisplayLayout.Override.RowSelectorWidth = 12;
            this.Grd_mvto_ItemPAC.DisplayLayout.Override.RowSpacingBefore = 2;
            Appearance7.BackColor = System.Drawing.Color.PapayaWhip;
            Appearance7.BackColor2 = System.Drawing.Color.PapayaWhip;
            Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance7.ForeColor = System.Drawing.Color.Black;
            this.Grd_mvto_ItemPAC.DisplayLayout.Override.SelectedRowAppearance = Appearance7;
            this.Grd_mvto_ItemPAC.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.Grd_mvto_ItemPAC.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.Grd_mvto_ItemPAC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_mvto_ItemPAC.Location = new System.Drawing.Point(22, 28);
            this.Grd_mvto_ItemPAC.Name = "Grd_mvto_ItemPAC";
            this.Grd_mvto_ItemPAC.Size = new System.Drawing.Size(931, 320);
            this.Grd_mvto_ItemPAC.TabIndex = 52;
            this.Grd_mvto_ItemPAC.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.Grd_mvto_ItemPAC_InitializeLayout);
            this.Grd_mvto_ItemPAC.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.Grd_mvto_ItemPAC_ClickCellButton);
            this.Grd_mvto_ItemPAC.AfterSelectChange += new Infragistics.Win.UltraWinGrid.AfterSelectChangeEventHandler(this.Grd_mvto_ItemPAC_AfterSelectChange);
            this.Grd_mvto_ItemPAC.DoubleClickCell += new Infragistics.Win.UltraWinGrid.DoubleClickCellEventHandler(this.Grd_mvto_ItemPAC_DoubleClickCell);
            // 
            // Menu_Opciones
            // 
            this.Menu_Opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_AperturaCierre_paso,
            this.Btn_Separador01,
            this.Btn_Gantt});
            this.Menu_Opciones.Name = "contextMenuStrip1";
            this.Menu_Opciones.Size = new System.Drawing.Size(201, 54);
            // 
            // Btn_AperturaCierre_paso
            // 
            this.Btn_AperturaCierre_paso.Image = global::WINlogistica.Properties.Resources.ListaPendiente32;
            this.Btn_AperturaCierre_paso.Name = "Btn_AperturaCierre_paso";
            this.Btn_AperturaCierre_paso.Size = new System.Drawing.Size(200, 22);
            this.Btn_AperturaCierre_paso.Text = "Apertura/Cierre de Paso";
            this.Btn_AperturaCierre_paso.Click += new System.EventHandler(this.Btn_AperturaCierre_paso_Click);
            // 
            // Btn_Separador01
            // 
            this.Btn_Separador01.Name = "Btn_Separador01";
            this.Btn_Separador01.Size = new System.Drawing.Size(197, 6);
            // 
            // Btn_Gantt
            // 
            this.Btn_Gantt.Image = global::WINlogistica.Properties.Resources.ReporteCeco32;
            this.Btn_Gantt.Name = "Btn_Gantt";
            this.Btn_Gantt.Size = new System.Drawing.Size(200, 22);
            this.Btn_Gantt.Text = "Gantt";
            this.Btn_Gantt.Click += new System.EventHandler(this.Btn_Gantt_Click);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Exportar});
            this.ToolStrip1.Location = new System.Drawing.Point(22, 3);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(931, 25);
            this.ToolStrip1.TabIndex = 47;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // tsb_Exportar
            // 
            this.tsb_Exportar.Image = global::WINlogistica.Properties.Resources.Excel;
            this.tsb_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Exportar.Name = "tsb_Exportar";
            this.tsb_Exportar.Size = new System.Drawing.Size(71, 22);
            this.tsb_Exportar.Text = "Exportar";
            this.tsb_Exportar.Click += new System.EventHandler(this.tsb_Exportar_Click);
            // 
            // UltraGroupBox2
            // 
            this.UltraGroupBox2.Controls.Add(this.ultraLabel1);
            this.UltraGroupBox2.Controls.Add(this.Txt_DesProcesoLogistico);
            this.UltraGroupBox2.Controls.Add(this.Txt_CodProcesoLogistico);
            this.UltraGroupBox2.Controls.Add(this.UltraLabel5);
            this.UltraGroupBox2.Controls.Add(this.Cbo_PeriodoProceso);
            this.UltraGroupBox2.Controls.Add(this.Btn_Mostrar);
            this.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.UltraGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.UltraGroupBox2.Location = new System.Drawing.Point(1, 0);
            this.UltraGroupBox2.Name = "UltraGroupBox2";
            this.UltraGroupBox2.Size = new System.Drawing.Size(956, 53);
            this.UltraGroupBox2.TabIndex = 3;
            this.UltraGroupBox2.Text = "1. Filtro";
            this.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Txt_DesProcesoLogistico
            // 
            this.Txt_DesProcesoLogistico.anchoColumnasAyuda = "150,70";
            this.Txt_DesProcesoLogistico.DatoAnterior = "";
            this.Txt_DesProcesoLogistico.EligevariosElementos = false;
            this.Txt_DesProcesoLogistico.Enabled = false;
            this.Txt_DesProcesoLogistico.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_DesProcesoLogistico.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_DesProcesoLogistico.exigirCampoLleno = false;
            this.Txt_DesProcesoLogistico.InputMask = "";
            this.Txt_DesProcesoLogistico.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_DesProcesoLogistico.Location = new System.Drawing.Point(462, 19);
            this.Txt_DesProcesoLogistico.LongitudTexto = 200;
            this.Txt_DesProcesoLogistico.mensajeExisteDatoSP = "";
            this.Txt_DesProcesoLogistico.mensajeNoExisteDatoSP = "";
            this.Txt_DesProcesoLogistico.Name = "Txt_DesProcesoLogistico";
            this.Txt_DesProcesoLogistico.nombreDS = null;
            this.Txt_DesProcesoLogistico.nombreExisteDatoSP = "";
            this.Txt_DesProcesoLogistico.nombreNoExisteDatoSP = "";
            this.Txt_DesProcesoLogistico.nombreSP = "";
            this.Txt_DesProcesoLogistico.parametrosExisteDatoSP = "";
            this.Txt_DesProcesoLogistico.parametrosNoExisteDatoSP = "";
            this.Txt_DesProcesoLogistico.parametrosSP = "";
            this.Txt_DesProcesoLogistico.PosicionCampo = 1;
            this.Txt_DesProcesoLogistico.PosicionCampoTexto = 1;
            this.Txt_DesProcesoLogistico.PosicionValue = 1;
            this.Txt_DesProcesoLogistico.resaltarCampoOmitido = false;
            this.Txt_DesProcesoLogistico.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_DesProcesoLogistico.Size = new System.Drawing.Size(376, 21);
            this.Txt_DesProcesoLogistico.TabIndex = 101;
            this.Txt_DesProcesoLogistico.tipoAyuda = gnUserControl.gnTextBox.Ayuda.SinAyudaInicial;
            this.Txt_DesProcesoLogistico.tipoDato = gnUserControl.gnTextBox.Tipo.Ninguno;
            this.Txt_DesProcesoLogistico.tipoDatoC = gnUserControl.gnTextBox.TipoC.Ninguno;
            this.Txt_DesProcesoLogistico.tipoextraccion = gnUserControl.gnTextBox.TipoExtra.StoredProcedure;
            this.Txt_DesProcesoLogistico.valorDevueltoVarios = "";
            this.Txt_DesProcesoLogistico.ValorDigitado = "";
            // 
            // Txt_CodProcesoLogistico
            // 
            this.Txt_CodProcesoLogistico.anchoColumnasAyuda = "70,500";
            this.Txt_CodProcesoLogistico.DatoAnterior = "";
            this.Txt_CodProcesoLogistico.EligevariosElementos = false;
            this.Txt_CodProcesoLogistico.Enabled = false;
            this.Txt_CodProcesoLogistico.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_CodProcesoLogistico.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_CodProcesoLogistico.exigirCampoLleno = false;
            this.Txt_CodProcesoLogistico.InputMask = "";
            this.Txt_CodProcesoLogistico.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_CodProcesoLogistico.Location = new System.Drawing.Point(347, 19);
            this.Txt_CodProcesoLogistico.LongitudTexto = 200;
            this.Txt_CodProcesoLogistico.mensajeExisteDatoSP = "";
            this.Txt_CodProcesoLogistico.mensajeNoExisteDatoSP = "";
            this.Txt_CodProcesoLogistico.Name = "Txt_CodProcesoLogistico";
            this.Txt_CodProcesoLogistico.nombreDS = null;
            this.Txt_CodProcesoLogistico.nombreExisteDatoSP = "";
            this.Txt_CodProcesoLogistico.nombreNoExisteDatoSP = "";
            this.Txt_CodProcesoLogistico.nombreSP = "";
            this.Txt_CodProcesoLogistico.parametrosExisteDatoSP = "";
            this.Txt_CodProcesoLogistico.parametrosNoExisteDatoSP = "";
            this.Txt_CodProcesoLogistico.parametrosSP = "";
            this.Txt_CodProcesoLogistico.PosicionCampo = 0;
            this.Txt_CodProcesoLogistico.PosicionCampoTexto = 1;
            this.Txt_CodProcesoLogistico.PosicionValue = 0;
            this.Txt_CodProcesoLogistico.resaltarCampoOmitido = false;
            this.Txt_CodProcesoLogistico.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_CodProcesoLogistico.Size = new System.Drawing.Size(109, 21);
            this.Txt_CodProcesoLogistico.TabIndex = 100;
            this.Txt_CodProcesoLogistico.tipoAyuda = gnUserControl.gnTextBox.Ayuda.ConAyudaInicial;
            this.Txt_CodProcesoLogistico.tipoDato = gnUserControl.gnTextBox.Tipo.Ninguno;
            this.Txt_CodProcesoLogistico.tipoDatoC = gnUserControl.gnTextBox.TipoC.Ninguno;
            this.Txt_CodProcesoLogistico.tipoextraccion = gnUserControl.gnTextBox.TipoExtra.DataSet;
            this.Txt_CodProcesoLogistico.valorDevueltoVarios = "";
            this.Txt_CodProcesoLogistico.ValorDigitado = "";
            this.Txt_CodProcesoLogistico.Leave += new System.EventHandler(this.Txt_CodOperadorLogistico_Leave);
            // 
            // UltraLabel5
            // 
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.UltraLabel5.Appearance = appearance2;
            this.UltraLabel5.AutoSize = true;
            this.UltraLabel5.Location = new System.Drawing.Point(241, 19);
            this.UltraLabel5.Name = "UltraLabel5";
            this.UltraLabel5.Size = new System.Drawing.Size(97, 14);
            this.UltraLabel5.TabIndex = 99;
            this.UltraLabel5.Text = "Proceso Logistico:";
            // 
            // Btn_Mostrar
            // 
            this.Btn_Mostrar.Location = new System.Drawing.Point(877, 19);
            this.Btn_Mostrar.Name = "Btn_Mostrar";
            this.Btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Mostrar.TabIndex = 94;
            this.Btn_Mostrar.Text = "&Mostrar";
            this.Btn_Mostrar.UseVisualStyleBackColor = true;
            this.Btn_Mostrar.Click += new System.EventHandler(this.Btn_Mostrar_Click);
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
            // Cbo_PeriodoProceso
            // 
            this.Cbo_PeriodoProceso.BackColor = System.Drawing.Color.White;
            this.Cbo_PeriodoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_PeriodoProceso.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_PeriodoProceso.FormattingEnabled = true;
            this.Cbo_PeriodoProceso.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_PeriodoProceso.Location = new System.Drawing.Point(110, 19);
            this.Cbo_PeriodoProceso.Name = "Cbo_PeriodoProceso";
            this.Cbo_PeriodoProceso.nombreDS = null;
            this.Cbo_PeriodoProceso.nombreSP = "Logistica.spp_cbo_mvto_PAC_Cabecera_AñoProceso";
            this.Cbo_PeriodoProceso.parametrosSP = "";
            this.Cbo_PeriodoProceso.resaltarCampoOmitido = false;
            this.Cbo_PeriodoProceso.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_PeriodoProceso.Size = new System.Drawing.Size(104, 21);
            this.Cbo_PeriodoProceso.TabIndex = 96;
            this.Cbo_PeriodoProceso.tipoConsumo = gnUserControl.gnComboBox.Tipo.StoredProcedure;
            this.Cbo_PeriodoProceso.SelectedIndexChanged += new System.EventHandler(this.Cbo_PeriodoProceso_SelectedIndexChanged);
            // 
            // ultraLabel1
            // 
            appearance1.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel1.Appearance = appearance1;
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(35, 19);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(72, 14);
            this.ultraLabel1.TabIndex = 102;
            this.ultraLabel1.Text = "Año Proceso:";
            // 
            // Frm_ControlItemPAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 405);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "Frm_ControlItemPAC";
            this.Text = "Reasignación para un proceso logistico";
            this.Load += new System.EventHandler(this.Frm_ControlItemPAC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).EndInit();
            this.UltraGroupBox3.ResumeLayout(false);
            this.UltraGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_mvto_ItemPAC)).EndInit();
            this.Menu_Opciones.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).EndInit();
            this.UltraGroupBox2.ResumeLayout(false);
            this.UltraGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DesProcesoLogistico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CodProcesoLogistico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox3;
        internal Infragistics.Win.UltraWinGrid.UltraGrid Grd_mvto_ItemPAC;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton tsb_Exportar;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox2;
        internal gnUserControl.gnTextBox Txt_DesProcesoLogistico;
        internal gnUserControl.gnTextBox Txt_CodProcesoLogistico;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel5;
        internal System.Windows.Forms.Button Btn_Mostrar;
        internal System.Windows.Forms.SaveFileDialog SaveDocumento;
        internal Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter UltraGridExcelExporter1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip Menu_Opciones;
        private System.Windows.Forms.ToolStripMenuItem Btn_AperturaCierre_paso;
        private System.Windows.Forms.ToolStripSeparator Btn_Separador01;
        private System.Windows.Forms.ToolStripMenuItem Btn_Gantt;
        internal Infragistics.Win.Misc.UltraLabel ultraLabel1;
        internal gnUserControl.gnComboBox Cbo_PeriodoProceso;
    }
}