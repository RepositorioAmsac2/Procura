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
            Infragistics.Win.Appearance Appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ControlItemPAC));
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
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.Txt_ApeOperadorLogistico = new gnUserControl.gnTextBox();
            this.Txt_CodOperadorLogistico = new gnUserControl.gnTextBox();
            this.UltraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.Cbo_Version = new gnUserControl.gnComboBox();
            this.Cbo_PeriodoProceso = new gnUserControl.gnComboBox();
            this.Btn_Mostrar = new System.Windows.Forms.Button();
            this.SaveDocumento = new System.Windows.Forms.SaveFileDialog();
            this.UltraGridExcelExporter1 = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).BeginInit();
            this.UltraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_mvto_ItemPAC)).BeginInit();
            this.Menu_Opciones.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).BeginInit();
            this.UltraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ApeOperadorLogistico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CodOperadorLogistico)).BeginInit();
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
            this.UltraGroupBox3.Location = new System.Drawing.Point(1, 64);
            this.UltraGroupBox3.Name = "UltraGroupBox3";
            this.UltraGroupBox3.Size = new System.Drawing.Size(956, 340);
            this.UltraGroupBox3.TabIndex = 4;
            this.UltraGroupBox3.Text = "2. Lista de Items del PAC asignados";
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
            this.Grd_mvto_ItemPAC.Size = new System.Drawing.Size(931, 309);
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
            this.UltraGroupBox2.Controls.Add(this.ultraLabel2);
            this.UltraGroupBox2.Controls.Add(this.ultraLabel1);
            this.UltraGroupBox2.Controls.Add(this.Txt_ApeOperadorLogistico);
            this.UltraGroupBox2.Controls.Add(this.Txt_CodOperadorLogistico);
            this.UltraGroupBox2.Controls.Add(this.UltraLabel5);
            this.UltraGroupBox2.Controls.Add(this.Cbo_Version);
            this.UltraGroupBox2.Controls.Add(this.Cbo_PeriodoProceso);
            this.UltraGroupBox2.Controls.Add(this.Btn_Mostrar);
            this.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.UltraGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.UltraGroupBox2.Location = new System.Drawing.Point(1, 0);
            this.UltraGroupBox2.Name = "UltraGroupBox2";
            this.UltraGroupBox2.Size = new System.Drawing.Size(956, 64);
            this.UltraGroupBox2.TabIndex = 3;
            this.UltraGroupBox2.Text = "1. Filtro";
            this.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // ultraLabel2
            // 
            Appearance1.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel2.Appearance = Appearance1;
            this.ultraLabel2.AutoSize = true;
            this.ultraLabel2.Location = new System.Drawing.Point(223, 24);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(46, 14);
            this.ultraLabel2.TabIndex = 103;
            this.ultraLabel2.Text = "Versión:";
            // 
            // ultraLabel1
            // 
            appearance1.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel1.Appearance = appearance1;
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(35, 24);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(72, 14);
            this.ultraLabel1.TabIndex = 102;
            this.ultraLabel1.Text = "Año Proceso:";
            // 
            // Txt_ApeOperadorLogistico
            // 
            this.Txt_ApeOperadorLogistico.anchoColumnasAyuda = "150,70";
            this.Txt_ApeOperadorLogistico.DatoAnterior = "";
            this.Txt_ApeOperadorLogistico.EligevariosElementos = false;
            this.Txt_ApeOperadorLogistico.Enabled = false;
            this.Txt_ApeOperadorLogistico.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_ApeOperadorLogistico.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_ApeOperadorLogistico.exigirCampoLleno = false;
            this.Txt_ApeOperadorLogistico.InputMask = "";
            this.Txt_ApeOperadorLogistico.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_ApeOperadorLogistico.Location = new System.Drawing.Point(610, 21);
            this.Txt_ApeOperadorLogistico.LongitudTexto = 200;
            this.Txt_ApeOperadorLogistico.mensajeExisteDatoSP = "";
            this.Txt_ApeOperadorLogistico.mensajeNoExisteDatoSP = "";
            this.Txt_ApeOperadorLogistico.Name = "Txt_ApeOperadorLogistico";
            this.Txt_ApeOperadorLogistico.nombreDS = null;
            this.Txt_ApeOperadorLogistico.nombreExisteDatoSP = "";
            this.Txt_ApeOperadorLogistico.nombreNoExisteDatoSP = "";
            this.Txt_ApeOperadorLogistico.nombreSP = "";
            this.Txt_ApeOperadorLogistico.parametrosExisteDatoSP = "";
            this.Txt_ApeOperadorLogistico.parametrosNoExisteDatoSP = "";
            this.Txt_ApeOperadorLogistico.parametrosSP = "";
            this.Txt_ApeOperadorLogistico.PosicionCampo = 1;
            this.Txt_ApeOperadorLogistico.PosicionCampoTexto = 1;
            this.Txt_ApeOperadorLogistico.PosicionValue = 1;
            this.Txt_ApeOperadorLogistico.resaltarCampoOmitido = false;
            this.Txt_ApeOperadorLogistico.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_ApeOperadorLogistico.Size = new System.Drawing.Size(240, 21);
            this.Txt_ApeOperadorLogistico.TabIndex = 101;
            this.Txt_ApeOperadorLogistico.tipoAyuda = gnUserControl.gnTextBox.Ayuda.SinAyudaInicial;
            this.Txt_ApeOperadorLogistico.tipoDato = gnUserControl.gnTextBox.Tipo.Ninguno;
            this.Txt_ApeOperadorLogistico.tipoDatoC = gnUserControl.gnTextBox.TipoC.Ninguno;
            this.Txt_ApeOperadorLogistico.tipoextraccion = gnUserControl.gnTextBox.TipoExtra.StoredProcedure;
            this.Txt_ApeOperadorLogistico.valorDevueltoVarios = "";
            this.Txt_ApeOperadorLogistico.ValorDigitado = "";
            // 
            // Txt_CodOperadorLogistico
            // 
            this.Txt_CodOperadorLogistico.anchoColumnasAyuda = "70,500";
            this.Txt_CodOperadorLogistico.DatoAnterior = "";
            this.Txt_CodOperadorLogistico.EligevariosElementos = false;
            this.Txt_CodOperadorLogistico.Enabled = false;
            this.Txt_CodOperadorLogistico.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_CodOperadorLogistico.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_CodOperadorLogistico.exigirCampoLleno = false;
            this.Txt_CodOperadorLogistico.InputMask = "";
            this.Txt_CodOperadorLogistico.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_CodOperadorLogistico.Location = new System.Drawing.Point(459, 21);
            this.Txt_CodOperadorLogistico.LongitudTexto = 200;
            this.Txt_CodOperadorLogistico.mensajeExisteDatoSP = "";
            this.Txt_CodOperadorLogistico.mensajeNoExisteDatoSP = "";
            this.Txt_CodOperadorLogistico.Name = "Txt_CodOperadorLogistico";
            this.Txt_CodOperadorLogistico.nombreDS = null;
            this.Txt_CodOperadorLogistico.nombreExisteDatoSP = "";
            this.Txt_CodOperadorLogistico.nombreNoExisteDatoSP = "";
            this.Txt_CodOperadorLogistico.nombreSP = "";
            this.Txt_CodOperadorLogistico.parametrosExisteDatoSP = "";
            this.Txt_CodOperadorLogistico.parametrosNoExisteDatoSP = "";
            this.Txt_CodOperadorLogistico.parametrosSP = "";
            this.Txt_CodOperadorLogistico.PosicionCampo = 0;
            this.Txt_CodOperadorLogistico.PosicionCampoTexto = 1;
            this.Txt_CodOperadorLogistico.PosicionValue = 0;
            this.Txt_CodOperadorLogistico.resaltarCampoOmitido = false;
            this.Txt_CodOperadorLogistico.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_CodOperadorLogistico.Size = new System.Drawing.Size(145, 21);
            this.Txt_CodOperadorLogistico.TabIndex = 100;
            this.Txt_CodOperadorLogistico.tipoAyuda = gnUserControl.gnTextBox.Ayuda.ConAyudaInicial;
            this.Txt_CodOperadorLogistico.tipoDato = gnUserControl.gnTextBox.Tipo.Ninguno;
            this.Txt_CodOperadorLogistico.tipoDatoC = gnUserControl.gnTextBox.TipoC.Ninguno;
            this.Txt_CodOperadorLogistico.tipoextraccion = gnUserControl.gnTextBox.TipoExtra.DataSet;
            this.Txt_CodOperadorLogistico.valorDevueltoVarios = "";
            this.Txt_CodOperadorLogistico.ValorDigitado = "";
            this.Txt_CodOperadorLogistico.Leave += new System.EventHandler(this.Txt_CodOperadorLogistico_Leave);
            // 
            // UltraLabel5
            // 
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.UltraLabel5.Appearance = appearance2;
            this.UltraLabel5.AutoSize = true;
            this.UltraLabel5.Location = new System.Drawing.Point(353, 24);
            this.UltraLabel5.Name = "UltraLabel5";
            this.UltraLabel5.Size = new System.Drawing.Size(103, 14);
            this.UltraLabel5.TabIndex = 99;
            this.UltraLabel5.Text = "Operador Logistico:";
            // 
            // Cbo_Version
            // 
            this.Cbo_Version.BackColor = System.Drawing.Color.White;
            this.Cbo_Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Version.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_Version.FormattingEnabled = true;
            this.Cbo_Version.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_Version.Location = new System.Drawing.Point(272, 21);
            this.Cbo_Version.Name = "Cbo_Version";
            this.Cbo_Version.nombreDS = null;
            this.Cbo_Version.nombreSP = "Logistica.spp_cbo_mvto_PAC_Cabecera_Version";
            this.Cbo_Version.parametrosSP = "";
            this.Cbo_Version.resaltarCampoOmitido = false;
            this.Cbo_Version.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_Version.Size = new System.Drawing.Size(73, 21);
            this.Cbo_Version.TabIndex = 98;
            this.Cbo_Version.tipoConsumo = gnUserControl.gnComboBox.Tipo.StoredProcedure;
            // 
            // Cbo_PeriodoProceso
            // 
            this.Cbo_PeriodoProceso.BackColor = System.Drawing.Color.White;
            this.Cbo_PeriodoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_PeriodoProceso.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_PeriodoProceso.FormattingEnabled = true;
            this.Cbo_PeriodoProceso.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_PeriodoProceso.Location = new System.Drawing.Point(110, 21);
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
            // Frm_ControlItemPAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 405);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "Frm_ControlItemPAC";
            this.Text = "Control de Item del PAC";
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
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ApeOperadorLogistico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CodOperadorLogistico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox3;
        internal Infragistics.Win.UltraWinGrid.UltraGrid Grd_mvto_ItemPAC;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton tsb_Exportar;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox2;
        internal Infragistics.Win.Misc.UltraLabel ultraLabel2;
        internal Infragistics.Win.Misc.UltraLabel ultraLabel1;
        internal gnUserControl.gnTextBox Txt_ApeOperadorLogistico;
        internal gnUserControl.gnTextBox Txt_CodOperadorLogistico;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel5;
        internal gnUserControl.gnComboBox Cbo_Version;
        internal gnUserControl.gnComboBox Cbo_PeriodoProceso;
        internal System.Windows.Forms.Button Btn_Mostrar;
        internal System.Windows.Forms.SaveFileDialog SaveDocumento;
        internal Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter UltraGridExcelExporter1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip Menu_Opciones;
        private System.Windows.Forms.ToolStripMenuItem Btn_AperturaCierre_paso;
        private System.Windows.Forms.ToolStripSeparator Btn_Separador01;
        private System.Windows.Forms.ToolStripMenuItem Btn_Gantt;
    }
}