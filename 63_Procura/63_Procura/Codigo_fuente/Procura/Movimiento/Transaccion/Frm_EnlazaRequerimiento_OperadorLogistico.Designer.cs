namespace WINlogistica
{
    partial class Frm_EnlazaRequerimiento_OperadorLogistico
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
            Infragistics.Win.Appearance Appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinScrollBar.ScrollBarLook scrollBarLook1 = new Infragistics.Win.UltraWinScrollBar.ScrollBarLook();
            Infragistics.Win.Appearance Appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EnlazaRequerimiento_OperadorLogistico));
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.UltraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Grd_Buscados = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Btn_PantallaTotal = new System.Windows.Forms.ToolStripMenuItem();
            this.Crv_Requerimiento = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.UltraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Txt_ApeOperadorLogistico = new gnUserControl.gnTextBox();
            this.Txt_CodOperadorLogistico = new gnUserControl.gnTextBox();
            this.Lbl_OperadorLogistico = new Infragistics.Win.Misc.UltraLabel();
            this.Btn_Descartar = new Infragistics.Win.Misc.UltraButton();
            this.Btn_FirmaDigital = new Infragistics.Win.Misc.UltraButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Lbl_CentroGestor = new System.Windows.Forms.ToolStripStatusLabel();
            this.Txt_CodigoCentroGestorREQ = new System.Windows.Forms.ToolStripStatusLabel();
            this.Txt_NombreCentroGestorREQ = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Exportar = new System.Windows.Forms.ToolStripButton();
            this.TimerLista = new System.Windows.Forms.Timer(this.components);
            this.SaveDocumento = new System.Windows.Forms.SaveFileDialog();
            this.UltraGridExcelExporter1 = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Adjunto = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).BeginInit();
            this.UltraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Buscados)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox1)).BeginInit();
            this.UltraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ApeOperadorLogistico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CodOperadorLogistico)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UltraGroupBox2
            // 
            this.UltraGroupBox2.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.UltraGroupBox2.Controls.Add(this.splitContainer1);
            this.UltraGroupBox2.Controls.Add(this.statusStrip1);
            this.UltraGroupBox2.Controls.Add(this.ToolStrip1);
            this.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.UltraGroupBox2.Name = "UltraGroupBox2";
            this.UltraGroupBox2.Size = new System.Drawing.Size(1138, 487);
            this.UltraGroupBox2.TabIndex = 8;
            this.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(1, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Grd_Buscados);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Crv_Requerimiento);
            this.splitContainer1.Panel2.Controls.Add(this.UltraGroupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1136, 439);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 26;
            // 
            // Grd_Buscados
            // 
            this.Grd_Buscados.ContextMenuStrip = this.contextMenuStrip1;
            Appearance1.BackColor = System.Drawing.Color.Transparent;
            this.Grd_Buscados.DisplayLayout.Appearance = Appearance1;
            this.Grd_Buscados.DisplayLayout.InterBandSpacing = 10;
            Appearance2.BackColor = System.Drawing.Color.Transparent;
            this.Grd_Buscados.DisplayLayout.Override.CardAreaAppearance = Appearance2;
            this.Grd_Buscados.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            Appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            Appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance3.ForeColor = System.Drawing.Color.Black;
            Appearance3.TextHAlignAsString = "Left";
            Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.Grd_Buscados.DisplayLayout.Override.HeaderAppearance = Appearance3;
            this.Grd_Buscados.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            Appearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.Grd_Buscados.DisplayLayout.Override.RowAppearance = Appearance4;
            Appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            Appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.Grd_Buscados.DisplayLayout.Override.RowSelectorAppearance = Appearance5;
            Appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            Appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance6.ForeColor = System.Drawing.Color.Black;
            this.Grd_Buscados.DisplayLayout.Override.SelectedRowAppearance = Appearance6;
            this.Grd_Buscados.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.Grd_Buscados.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            scrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.BothAtRightBottom;
            scrollBarLook1.ShowMinMaxButtons = Infragistics.Win.DefaultableBoolean.True;
            this.Grd_Buscados.DisplayLayout.ScrollBarLook = scrollBarLook1;
            this.Grd_Buscados.DisplayLayout.UseFixedHeaders = true;
            this.Grd_Buscados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_Buscados.Location = new System.Drawing.Point(0, 0);
            this.Grd_Buscados.Name = "Grd_Buscados";
            this.Grd_Buscados.Size = new System.Drawing.Size(376, 435);
            this.Grd_Buscados.TabIndex = 55;
            this.Grd_Buscados.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.Grd_Buscados_InitializeLayout);
            this.Grd_Buscados.AfterSelectChange += new Infragistics.Win.UltraWinGrid.AfterSelectChangeEventHandler(this.Grd_Buscados_AfterSelectChange);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_PantallaTotal,
            this.toolStripMenuItem1,
            this.Btn_Adjunto});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(272, 54);
            // 
            // Btn_PantallaTotal
            // 
            this.Btn_PantallaTotal.Name = "Btn_PantallaTotal";
            this.Btn_PantallaTotal.Size = new System.Drawing.Size(271, 22);
            this.Btn_PantallaTotal.Text = "Ver Requerimiento en toda la pantalla";
            this.Btn_PantallaTotal.Click += new System.EventHandler(this.Btn_PantallaTotal_Click);
            // 
            // Crv_Requerimiento
            // 
            this.Crv_Requerimiento.ActiveViewIndex = -1;
            this.Crv_Requerimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crv_Requerimiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crv_Requerimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crv_Requerimiento.Location = new System.Drawing.Point(0, 0);
            this.Crv_Requerimiento.Name = "Crv_Requerimiento";
            this.Crv_Requerimiento.ShowExportButton = false;
            this.Crv_Requerimiento.ShowGroupTreeButton = false;
            this.Crv_Requerimiento.ShowPrintButton = false;
            this.Crv_Requerimiento.Size = new System.Drawing.Size(748, 391);
            this.Crv_Requerimiento.TabIndex = 16;
            this.Crv_Requerimiento.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.Crv_Requerimiento.Visible = false;
            // 
            // UltraGroupBox1
            // 
            this.UltraGroupBox1.Controls.Add(this.Txt_ApeOperadorLogistico);
            this.UltraGroupBox1.Controls.Add(this.Txt_CodOperadorLogistico);
            this.UltraGroupBox1.Controls.Add(this.Lbl_OperadorLogistico);
            this.UltraGroupBox1.Controls.Add(this.Btn_Descartar);
            this.UltraGroupBox1.Controls.Add(this.Btn_FirmaDigital);
            this.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UltraGroupBox1.Location = new System.Drawing.Point(0, 391);
            this.UltraGroupBox1.Name = "UltraGroupBox1";
            this.UltraGroupBox1.Size = new System.Drawing.Size(748, 44);
            this.UltraGroupBox1.TabIndex = 15;
            this.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
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
            this.Txt_ApeOperadorLogistico.Location = new System.Drawing.Point(203, 12);
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
            this.Txt_ApeOperadorLogistico.Size = new System.Drawing.Size(290, 21);
            this.Txt_ApeOperadorLogistico.TabIndex = 141;
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
            this.Txt_CodOperadorLogistico.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_CodOperadorLogistico.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_CodOperadorLogistico.exigirCampoLleno = false;
            this.Txt_CodOperadorLogistico.InputMask = "";
            this.Txt_CodOperadorLogistico.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_CodOperadorLogistico.Location = new System.Drawing.Point(115, 11);
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
            this.Txt_CodOperadorLogistico.Size = new System.Drawing.Size(82, 21);
            this.Txt_CodOperadorLogistico.TabIndex = 139;
            this.Txt_CodOperadorLogistico.tipoAyuda = gnUserControl.gnTextBox.Ayuda.ConAyudaInicial;
            this.Txt_CodOperadorLogistico.tipoDato = gnUserControl.gnTextBox.Tipo.Ninguno;
            this.Txt_CodOperadorLogistico.tipoDatoC = gnUserControl.gnTextBox.TipoC.Ninguno;
            this.Txt_CodOperadorLogistico.tipoextraccion = gnUserControl.gnTextBox.TipoExtra.DataSet;
            this.Txt_CodOperadorLogistico.valorDevueltoVarios = "";
            this.Txt_CodOperadorLogistico.ValorDigitado = "";
            this.Txt_CodOperadorLogistico.Leave += new System.EventHandler(this.Txt_CodOperadorLogistico_Leave);
            // 
            // Lbl_OperadorLogistico
            // 
            Appearance10.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_OperadorLogistico.Appearance = Appearance10;
            this.Lbl_OperadorLogistico.AutoSize = true;
            this.Lbl_OperadorLogistico.Location = new System.Drawing.Point(9, 12);
            this.Lbl_OperadorLogistico.Name = "Lbl_OperadorLogistico";
            this.Lbl_OperadorLogistico.Size = new System.Drawing.Size(103, 14);
            this.Lbl_OperadorLogistico.TabIndex = 140;
            this.Lbl_OperadorLogistico.Text = "Operador Logistico:";
            // 
            // Btn_Descartar
            // 
            this.Btn_Descartar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            appearance1.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance1.Image = ((object)(resources.GetObject("appearance1.Image")));
            appearance1.ImageHAlign = Infragistics.Win.HAlign.Left;
            this.Btn_Descartar.Appearance = appearance1;
            this.Btn_Descartar.Location = new System.Drawing.Point(499, 9);
            this.Btn_Descartar.Name = "Btn_Descartar";
            this.Btn_Descartar.Size = new System.Drawing.Size(119, 27);
            this.Btn_Descartar.TabIndex = 6;
            this.Btn_Descartar.Text = "Descartar";
            this.Btn_Descartar.Visible = false;
            this.Btn_Descartar.Click += new System.EventHandler(this.Btn_Descartar_Click);
            // 
            // Btn_FirmaDigital
            // 
            this.Btn_FirmaDigital.Anchor = System.Windows.Forms.AnchorStyles.Right;
            appearance2.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance2.Image = ((object)(resources.GetObject("appearance2.Image")));
            appearance2.ImageHAlign = Infragistics.Win.HAlign.Right;
            this.Btn_FirmaDigital.Appearance = appearance2;
            this.Btn_FirmaDigital.Location = new System.Drawing.Point(623, 9);
            this.Btn_FirmaDigital.Name = "Btn_FirmaDigital";
            this.Btn_FirmaDigital.Size = new System.Drawing.Size(119, 27);
            this.Btn_FirmaDigital.TabIndex = 5;
            this.Btn_FirmaDigital.Text = "Asignar";
            this.Btn_FirmaDigital.Visible = false;
            this.Btn_FirmaDigital.Click += new System.EventHandler(this.Btn_FirmaDigital_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lbl_CentroGestor,
            this.Txt_CodigoCentroGestorREQ,
            this.Txt_NombreCentroGestorREQ});
            this.statusStrip1.Location = new System.Drawing.Point(1, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1136, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Lbl_CentroGestor
            // 
            this.Lbl_CentroGestor.Name = "Lbl_CentroGestor";
            this.Lbl_CentroGestor.Size = new System.Drawing.Size(83, 17);
            this.Lbl_CentroGestor.Text = "Centro Gestor:";
            // 
            // Txt_CodigoCentroGestorREQ
            // 
            this.Txt_CodigoCentroGestorREQ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Txt_CodigoCentroGestorREQ.Name = "Txt_CodigoCentroGestorREQ";
            this.Txt_CodigoCentroGestorREQ.Size = new System.Drawing.Size(0, 17);
            // 
            // Txt_NombreCentroGestorREQ
            // 
            this.Txt_NombreCentroGestorREQ.Name = "Txt_NombreCentroGestorREQ";
            this.Txt_NombreCentroGestorREQ.Size = new System.Drawing.Size(0, 17);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Exportar});
            this.ToolStrip1.Location = new System.Drawing.Point(1, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1136, 25);
            this.ToolStrip1.TabIndex = 1;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(55, 22);
            this.btn_Exportar.Text = "Exportar";
            this.btn_Exportar.Click += new System.EventHandler(this.btn_Exportar_Click);
            // 
            // TimerLista
            // 
            this.TimerLista.Interval = 30000;
            this.TimerLista.Tick += new System.EventHandler(this.TimerLista_Tick);
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
            this.imageList1.Images.SetKeyName(0, "esfera_ambar.png");
            this.imageList1.Images.SetKeyName(1, "esfera_roja.jpg");
            this.imageList1.Images.SetKeyName(2, "esfera_verde.png");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(268, 6);
            // 
            // Btn_Adjunto
            // 
            this.Btn_Adjunto.Name = "Btn_Adjunto";
            this.Btn_Adjunto.Size = new System.Drawing.Size(271, 22);
            this.Btn_Adjunto.Text = "Ver Adjunto";
            this.Btn_Adjunto.Click += new System.EventHandler(this.btnAdjuntoToolStripMenuItem_Click);
            // 
            // Frm_EnlazaRequerimiento_OperadorLogistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 487);
            this.Controls.Add(this.UltraGroupBox2);
            this.Name = "Frm_EnlazaRequerimiento_OperadorLogistico";
            this.Text = "Asignar Requerimiento a Operador Logistico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_FirmaRequerimiento_FormClosing);
            this.Load += new System.EventHandler(this.Frm_FirmaRequerimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).EndInit();
            this.UltraGroupBox2.ResumeLayout(false);
            this.UltraGroupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Buscados)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox1)).EndInit();
            this.UltraGroupBox1.ResumeLayout(false);
            this.UltraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ApeOperadorLogistico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CodOperadorLogistico)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox2;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btn_Exportar;
        private System.Windows.Forms.Timer TimerLista;
        internal System.Windows.Forms.SaveFileDialog SaveDocumento;
        internal Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter UltraGridExcelExporter1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Btn_PantallaTotal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_CentroGestor;
        private System.Windows.Forms.ToolStripStatusLabel Txt_CodigoCentroGestorREQ;
        private System.Windows.Forms.ToolStripStatusLabel Txt_NombreCentroGestorREQ;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal Infragistics.Win.UltraWinGrid.UltraGrid Grd_Buscados;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer Crv_Requerimiento;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox1;
        internal Infragistics.Win.Misc.UltraButton Btn_Descartar;
        internal Infragistics.Win.Misc.UltraButton Btn_FirmaDigital;
        internal gnUserControl.gnTextBox Txt_ApeOperadorLogistico;
        internal gnUserControl.gnTextBox Txt_CodOperadorLogistico;
        internal Infragistics.Win.Misc.UltraLabel Lbl_OperadorLogistico;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Btn_Adjunto;
    }
}