namespace WINlogistica
{
    partial class Frm_TipoProceso_Duracion
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
            Infragistics.Win.Appearance Appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance10 = new Infragistics.Win.Appearance();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.grp_Catalogo = new Infragistics.Win.Misc.UltraGroupBox();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Grd_mvto_TipoProceso = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Btn_Listar = new System.Windows.Forms.ToolStripButton();
            this.CLabel6 = new System.Windows.Forms.Label();
            this.Nud_Orden = new System.Windows.Forms.NumericUpDown();
            this.CLabel4 = new System.Windows.Forms.Label();
            this.CLabel5 = new System.Windows.Forms.Label();
            this.Nud_DiaEmail = new System.Windows.Forms.NumericUpDown();
            this.Opt_Calendario = new System.Windows.Forms.RadioButton();
            this.Opt_Habiles = new System.Windows.Forms.RadioButton();
            this.CLabel3 = new System.Windows.Forms.Label();
            this.CLabel2 = new System.Windows.Forms.Label();
            this.CLabel1 = new System.Windows.Forms.Label();
            this.Nud_Duracion = new System.Windows.Forms.NumericUpDown();
            this.Cbo_codPasoActoPrevio = new gnUserControl.gnComboBox();
            this.CLabel16 = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Btn_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.Btn_Grabar = new System.Windows.Forms.ToolStripButton();
            this.Btn_DesHacer = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Cbo_PeriodoProceso = new gnUserControl.gnComboBox();
            this.UltraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.Cbo_TipoProceso = new gnUserControl.gnComboBox();
            this.Cbo_ObjetoContratacion = new gnUserControl.gnComboBox();
            this.Btn_Mostrar = new System.Windows.Forms.Button();
            this.UltraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.UltraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.cms_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MnuI_TrasladarItemPAC = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDocumento = new System.Windows.Forms.SaveFileDialog();
            this.UltraGridExcelExporter1 = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_Catalogo)).BeginInit();
            this.grp_Catalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_mvto_TipoProceso)).BeginInit();
            this.ToolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Orden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_DiaEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Duracion)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            this.cms_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.ultraGroupBox1.Controls.Add(this.grp_Catalogo);
            this.ultraGroupBox1.Controls.Add(this.ultraGroupBox2);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(1295, 523);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // grp_Catalogo
            // 
            this.grp_Catalogo.Controls.Add(this.SplitContainer1);
            this.grp_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Catalogo.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.grp_Catalogo.Location = new System.Drawing.Point(1, 86);
            this.grp_Catalogo.Name = "grp_Catalogo";
            this.grp_Catalogo.Size = new System.Drawing.Size(1293, 436);
            this.grp_Catalogo.TabIndex = 6;
            this.grp_Catalogo.Text = "2. Lista de pasos por tipos de proceso";
            this.grp_Catalogo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            this.grp_Catalogo.Visible = false;
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(22, 3);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.Grd_mvto_TipoProceso);
            this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip2);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.CLabel6);
            this.SplitContainer1.Panel2.Controls.Add(this.Nud_Orden);
            this.SplitContainer1.Panel2.Controls.Add(this.CLabel4);
            this.SplitContainer1.Panel2.Controls.Add(this.CLabel5);
            this.SplitContainer1.Panel2.Controls.Add(this.Nud_DiaEmail);
            this.SplitContainer1.Panel2.Controls.Add(this.Opt_Calendario);
            this.SplitContainer1.Panel2.Controls.Add(this.Opt_Habiles);
            this.SplitContainer1.Panel2.Controls.Add(this.CLabel3);
            this.SplitContainer1.Panel2.Controls.Add(this.CLabel2);
            this.SplitContainer1.Panel2.Controls.Add(this.CLabel1);
            this.SplitContainer1.Panel2.Controls.Add(this.Nud_Duracion);
            this.SplitContainer1.Panel2.Controls.Add(this.Cbo_codPasoActoPrevio);
            this.SplitContainer1.Panel2.Controls.Add(this.CLabel16);
            this.SplitContainer1.Panel2.Controls.Add(this.ToolStrip1);
            this.SplitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel2_Paint);
            this.SplitContainer1.Size = new System.Drawing.Size(1268, 430);
            this.SplitContainer1.SplitterDistance = 735;
            this.SplitContainer1.TabIndex = 5;
            // 
            // Grd_mvto_TipoProceso
            // 
            Appearance7.BackColor = System.Drawing.Color.Transparent;
            this.Grd_mvto_TipoProceso.DisplayLayout.Appearance = Appearance7;
            this.Grd_mvto_TipoProceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_mvto_TipoProceso.Location = new System.Drawing.Point(0, 25);
            this.Grd_mvto_TipoProceso.Name = "Grd_mvto_TipoProceso";
            this.Grd_mvto_TipoProceso.Size = new System.Drawing.Size(731, 401);
            this.Grd_mvto_TipoProceso.TabIndex = 52;
            this.Grd_mvto_TipoProceso.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.Grd_mvto_TipoProceso_InitializeLayout);
            this.Grd_mvto_TipoProceso.AfterSelectChange += new Infragistics.Win.UltraWinGrid.AfterSelectChangeEventHandler(this.Grd_mvto_TipoProceso_AfterSelectChange);
            // 
            // ToolStrip2
            // 
            this.ToolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Listar});
            this.ToolStrip2.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.Size = new System.Drawing.Size(731, 25);
            this.ToolStrip2.TabIndex = 6;
            this.ToolStrip2.Text = "ToolStrip2";
            // 
            // Btn_Listar
            // 
            this.Btn_Listar.Image = global::WINlogistica.Properties.Resources.Excel;
            this.Btn_Listar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Btn_Listar.Name = "Btn_Listar";
            this.Btn_Listar.Size = new System.Drawing.Size(55, 22);
            this.Btn_Listar.Text = "Listar";
            this.Btn_Listar.Click += new System.EventHandler(this.Btn_Listar_Click);
            // 
            // CLabel6
            // 
            this.CLabel6.AutoSize = true;
            this.CLabel6.BackColor = System.Drawing.Color.Transparent;
            this.CLabel6.Enabled = false;
            this.CLabel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CLabel6.Location = new System.Drawing.Point(35, 281);
            this.CLabel6.Name = "CLabel6";
            this.CLabel6.Size = new System.Drawing.Size(39, 13);
            this.CLabel6.TabIndex = 245;
            this.CLabel6.Text = "Orden:";
            // 
            // Nud_Orden
            // 
            this.Nud_Orden.Location = new System.Drawing.Point(35, 297);
            this.Nud_Orden.Name = "Nud_Orden";
            this.Nud_Orden.Size = new System.Drawing.Size(55, 20);
            this.Nud_Orden.TabIndex = 5;
            // 
            // CLabel4
            // 
            this.CLabel4.AutoSize = true;
            this.CLabel4.BackColor = System.Drawing.Color.Transparent;
            this.CLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CLabel4.Location = new System.Drawing.Point(35, 162);
            this.CLabel4.Name = "CLabel4";
            this.CLabel4.Size = new System.Drawing.Size(72, 13);
            this.CLabel4.TabIndex = 244;
            this.CLabel4.Text = "Enviar alerta :";
            // 
            // CLabel5
            // 
            this.CLabel5.AutoSize = true;
            this.CLabel5.BackColor = System.Drawing.Color.Transparent;
            this.CLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CLabel5.Location = new System.Drawing.Point(133, 180);
            this.CLabel5.Name = "CLabel5";
            this.CLabel5.Size = new System.Drawing.Size(250, 13);
            this.CLabel5.TabIndex = 243;
            this.CLabel5.Text = "dias antes del termino del paso o hasta el mismo dia";
            // 
            // Nud_DiaEmail
            // 
            this.Nud_DiaEmail.Location = new System.Drawing.Point(35, 178);
            this.Nud_DiaEmail.Name = "Nud_DiaEmail";
            this.Nud_DiaEmail.Size = new System.Drawing.Size(89, 20);
            this.Nud_DiaEmail.TabIndex = 2;
            // 
            // Opt_Calendario
            // 
            this.Opt_Calendario.AutoSize = true;
            this.Opt_Calendario.BackColor = System.Drawing.Color.Transparent;
            this.Opt_Calendario.Location = new System.Drawing.Point(133, 241);
            this.Opt_Calendario.Name = "Opt_Calendario";
            this.Opt_Calendario.Size = new System.Drawing.Size(99, 17);
            this.Opt_Calendario.TabIndex = 4;
            this.Opt_Calendario.TabStop = true;
            this.Opt_Calendario.Text = "Dias Calendario";
            this.Opt_Calendario.UseVisualStyleBackColor = false;
            // 
            // Opt_Habiles
            // 
            this.Opt_Habiles.AutoSize = true;
            this.Opt_Habiles.BackColor = System.Drawing.Color.Transparent;
            this.Opt_Habiles.Location = new System.Drawing.Point(35, 241);
            this.Opt_Habiles.Name = "Opt_Habiles";
            this.Opt_Habiles.Size = new System.Drawing.Size(84, 17);
            this.Opt_Habiles.TabIndex = 3;
            this.Opt_Habiles.TabStop = true;
            this.Opt_Habiles.Text = "Dias Habiles";
            this.Opt_Habiles.UseVisualStyleBackColor = false;
            // 
            // CLabel3
            // 
            this.CLabel3.AutoSize = true;
            this.CLabel3.BackColor = System.Drawing.Color.Transparent;
            this.CLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CLabel3.Location = new System.Drawing.Point(35, 221);
            this.CLabel3.Name = "CLabel3";
            this.CLabel3.Size = new System.Drawing.Size(82, 13);
            this.CLabel3.TabIndex = 241;
            this.CLabel3.Text = "Tipo de Control:";
            // 
            // CLabel2
            // 
            this.CLabel2.AutoSize = true;
            this.CLabel2.BackColor = System.Drawing.Color.Transparent;
            this.CLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CLabel2.Location = new System.Drawing.Point(35, 101);
            this.CLabel2.Name = "CLabel2";
            this.CLabel2.Size = new System.Drawing.Size(96, 13);
            this.CLabel2.TabIndex = 240;
            this.CLabel2.Text = "Duración del paso:";
            // 
            // CLabel1
            // 
            this.CLabel1.AutoSize = true;
            this.CLabel1.BackColor = System.Drawing.Color.Transparent;
            this.CLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CLabel1.Location = new System.Drawing.Point(124, 121);
            this.CLabel1.Name = "CLabel1";
            this.CLabel1.Size = new System.Drawing.Size(26, 13);
            this.CLabel1.TabIndex = 239;
            this.CLabel1.Text = "dias";
            // 
            // Nud_Duracion
            // 
            this.Nud_Duracion.Location = new System.Drawing.Point(35, 117);
            this.Nud_Duracion.Name = "Nud_Duracion";
            this.Nud_Duracion.Size = new System.Drawing.Size(88, 20);
            this.Nud_Duracion.TabIndex = 1;
            // 
            // Cbo_codPasoActoPrevio
            // 
            this.Cbo_codPasoActoPrevio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_codPasoActoPrevio.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_codPasoActoPrevio.FormattingEnabled = true;
            this.Cbo_codPasoActoPrevio.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_codPasoActoPrevio.Location = new System.Drawing.Point(35, 66);
            this.Cbo_codPasoActoPrevio.Name = "Cbo_codPasoActoPrevio";
            this.Cbo_codPasoActoPrevio.nombreDS = null;
            this.Cbo_codPasoActoPrevio.nombreSP = "Logistica.spp_cbo_ctrl_PasoActoPrevio";
            this.Cbo_codPasoActoPrevio.parametrosSP = "";
            this.Cbo_codPasoActoPrevio.resaltarCampoOmitido = false;
            this.Cbo_codPasoActoPrevio.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_codPasoActoPrevio.Size = new System.Drawing.Size(475, 21);
            this.Cbo_codPasoActoPrevio.TabIndex = 0;
            this.Cbo_codPasoActoPrevio.tipoConsumo = gnUserControl.gnComboBox.Tipo.StoredProcedure;
            // 
            // CLabel16
            // 
            this.CLabel16.AutoSize = true;
            this.CLabel16.BackColor = System.Drawing.Color.Transparent;
            this.CLabel16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CLabel16.Location = new System.Drawing.Point(35, 50);
            this.CLabel16.Name = "CLabel16";
            this.CLabel16.Size = new System.Drawing.Size(92, 13);
            this.CLabel16.TabIndex = 238;
            this.CLabel16.Text = "Paso Acto Previo:";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Nuevo,
            this.Btn_Grabar,
            this.Btn_DesHacer,
            this.ToolStripSeparator1,
            this.Btn_Eliminar});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(525, 25);
            this.ToolStrip1.TabIndex = 6;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Image = global::WINlogistica.Properties.Resources.edit_find;
            this.Btn_Nuevo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(62, 22);
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Grabar
            // 
            this.Btn_Grabar.Image = global::WINlogistica.Properties.Resources.grabaRegistro;
            this.Btn_Grabar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Btn_Grabar.Name = "Btn_Grabar";
            this.Btn_Grabar.Size = new System.Drawing.Size(62, 22);
            this.Btn_Grabar.Text = "Grabar";
            this.Btn_Grabar.Click += new System.EventHandler(this.Btn_Grabar_Click);
            // 
            // Btn_DesHacer
            // 
            this.Btn_DesHacer.Image = global::WINlogistica.Properties.Resources.mod_Documento;
            this.Btn_DesHacer.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Btn_DesHacer.Name = "Btn_DesHacer";
            this.Btn_DesHacer.Size = new System.Drawing.Size(75, 22);
            this.Btn_DesHacer.Text = "Deshacer";
            this.Btn_DesHacer.Click += new System.EventHandler(this.Btn_DesHacer_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Image = global::WINlogistica.Properties.Resources.del_Documento;
            this.Btn_Eliminar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(70, 22);
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // ultraGroupBox2
            // 
            this.ultraGroupBox2.Controls.Add(this.Cbo_PeriodoProceso);
            this.ultraGroupBox2.Controls.Add(this.UltraLabel1);
            this.ultraGroupBox2.Controls.Add(this.Cbo_TipoProceso);
            this.ultraGroupBox2.Controls.Add(this.Cbo_ObjetoContratacion);
            this.ultraGroupBox2.Controls.Add(this.Btn_Mostrar);
            this.ultraGroupBox2.Controls.Add(this.UltraLabel6);
            this.ultraGroupBox2.Controls.Add(this.UltraLabel5);
            this.ultraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.ultraGroupBox2.Location = new System.Drawing.Point(1, 0);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(1293, 86);
            this.ultraGroupBox2.TabIndex = 5;
            this.ultraGroupBox2.Text = "1. Filtro";
            this.ultraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            this.ultraGroupBox2.Click += new System.EventHandler(this.ultraGroupBox2_Click);
            // 
            // Cbo_PeriodoProceso
            // 
            this.Cbo_PeriodoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_PeriodoProceso.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_PeriodoProceso.FormattingEnabled = true;
            this.Cbo_PeriodoProceso.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_PeriodoProceso.Location = new System.Drawing.Point(171, 12);
            this.Cbo_PeriodoProceso.Name = "Cbo_PeriodoProceso";
            this.Cbo_PeriodoProceso.nombreDS = null;
            this.Cbo_PeriodoProceso.nombreSP = "";
            this.Cbo_PeriodoProceso.parametrosSP = "";
            this.Cbo_PeriodoProceso.resaltarCampoOmitido = false;
            this.Cbo_PeriodoProceso.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_PeriodoProceso.Size = new System.Drawing.Size(145, 21);
            this.Cbo_PeriodoProceso.TabIndex = 0;
            this.Cbo_PeriodoProceso.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // UltraLabel1
            // 
            Appearance8.BackColor = System.Drawing.Color.Transparent;
            this.UltraLabel1.Appearance = Appearance8;
            this.UltraLabel1.AutoSize = true;
            this.UltraLabel1.Location = new System.Drawing.Point(122, 15);
            this.UltraLabel1.Name = "UltraLabel1";
            this.UltraLabel1.Size = new System.Drawing.Size(46, 14);
            this.UltraLabel1.TabIndex = 94;
            this.UltraLabel1.Text = "Periodo:";
            // 
            // Cbo_TipoProceso
            // 
            this.Cbo_TipoProceso.BackColor = System.Drawing.Color.White;
            this.Cbo_TipoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_TipoProceso.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_TipoProceso.FormattingEnabled = true;
            this.Cbo_TipoProceso.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_TipoProceso.Location = new System.Drawing.Point(171, 35);
            this.Cbo_TipoProceso.Name = "Cbo_TipoProceso";
            this.Cbo_TipoProceso.nombreDS = null;
            this.Cbo_TipoProceso.nombreSP = "Logistica.spp_cbo_ctrl_TipoProceso";
            this.Cbo_TipoProceso.parametrosSP = "";
            this.Cbo_TipoProceso.resaltarCampoOmitido = false;
            this.Cbo_TipoProceso.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_TipoProceso.Size = new System.Drawing.Size(242, 21);
            this.Cbo_TipoProceso.TabIndex = 1;
            this.Cbo_TipoProceso.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            this.Cbo_TipoProceso.SelectedIndexChanged += new System.EventHandler(this.Cbo_TipoProceso_SelectedIndexChanged);
            // 
            // Cbo_ObjetoContratacion
            // 
            this.Cbo_ObjetoContratacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_ObjetoContratacion.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_ObjetoContratacion.FormattingEnabled = true;
            this.Cbo_ObjetoContratacion.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_ObjetoContratacion.Location = new System.Drawing.Point(171, 58);
            this.Cbo_ObjetoContratacion.Name = "Cbo_ObjetoContratacion";
            this.Cbo_ObjetoContratacion.nombreDS = null;
            this.Cbo_ObjetoContratacion.nombreSP = "Logistica.spp_cbo_ctrl_ObjetoContratacion";
            this.Cbo_ObjetoContratacion.parametrosSP = "";
            this.Cbo_ObjetoContratacion.resaltarCampoOmitido = false;
            this.Cbo_ObjetoContratacion.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_ObjetoContratacion.Size = new System.Drawing.Size(242, 21);
            this.Cbo_ObjetoContratacion.TabIndex = 2;
            this.Cbo_ObjetoContratacion.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            this.Cbo_ObjetoContratacion.SelectedIndexChanged += new System.EventHandler(this.Cbo_ObjetoContratacion_SelectedIndexChanged);
            // 
            // Btn_Mostrar
            // 
            this.Btn_Mostrar.Location = new System.Drawing.Point(925, 60);
            this.Btn_Mostrar.Name = "Btn_Mostrar";
            this.Btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Mostrar.TabIndex = 91;
            this.Btn_Mostrar.Text = "Mostrar";
            this.Btn_Mostrar.UseVisualStyleBackColor = true;
            this.Btn_Mostrar.Click += new System.EventHandler(this.Btn_Mostrar_Click);
            // 
            // UltraLabel6
            // 
            Appearance1.BackColor = System.Drawing.Color.Transparent;
            this.UltraLabel6.Appearance = Appearance1;
            this.UltraLabel6.AutoSize = true;
            this.UltraLabel6.Location = new System.Drawing.Point(78, 38);
            this.UltraLabel6.Name = "UltraLabel6";
            this.UltraLabel6.Size = new System.Drawing.Size(90, 14);
            this.UltraLabel6.TabIndex = 81;
            this.UltraLabel6.Text = "Tipo de Proceso:";
            // 
            // UltraLabel5
            // 
            Appearance10.BackColor = System.Drawing.Color.Transparent;
            this.UltraLabel5.Appearance = Appearance10;
            this.UltraLabel5.AutoSize = true;
            this.UltraLabel5.Location = new System.Drawing.Point(44, 60);
            this.UltraLabel5.Name = "UltraLabel5";
            this.UltraLabel5.Size = new System.Drawing.Size(124, 14);
            this.UltraLabel5.TabIndex = 78;
            this.UltraLabel5.Text = "Objeto de Contratacion:";
            // 
            // cms_Menu
            // 
            this.cms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuI_TrasladarItemPAC});
            this.cms_Menu.Name = "cms_Menu";
            this.cms_Menu.Size = new System.Drawing.Size(173, 26);
            // 
            // MnuI_TrasladarItemPAC
            // 
            this.MnuI_TrasladarItemPAC.Name = "MnuI_TrasladarItemPAC";
            this.MnuI_TrasladarItemPAC.Size = new System.Drawing.Size(172, 22);
            this.MnuI_TrasladarItemPAC.Text = "Trasladar Item PAC";
            // 
            // SaveDocumento
            // 
            this.SaveDocumento.DefaultExt = "XLS";
            this.SaveDocumento.Filter = "Excel (*.xls)|*.xls";
            this.SaveDocumento.RestoreDirectory = true;
            // 
            // Frm_TipoProceso_Duracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 523);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "Frm_TipoProceso_Duracion";
            this.Text = "Duración de pasos de los Tipos de Proceso";
            this.Load += new System.EventHandler(this.Frm_TipoProceso_Duracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grp_Catalogo)).EndInit();
            this.grp_Catalogo.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_mvto_TipoProceso)).EndInit();
            this.ToolStrip2.ResumeLayout(false);
            this.ToolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Orden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_DiaEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Duracion)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            this.ultraGroupBox2.PerformLayout();
            this.cms_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        internal Infragistics.Win.Misc.UltraGroupBox grp_Catalogo;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal Infragistics.Win.UltraWinGrid.UltraGrid Grd_mvto_TipoProceso;
        internal System.Windows.Forms.ToolStrip ToolStrip2;
        internal System.Windows.Forms.ToolStripButton Btn_Listar;
        internal System.Windows.Forms.Label CLabel6;
        internal System.Windows.Forms.NumericUpDown Nud_Orden;
        internal System.Windows.Forms.Label CLabel4;
        internal System.Windows.Forms.Label CLabel5;
        internal System.Windows.Forms.NumericUpDown Nud_DiaEmail;
        internal System.Windows.Forms.RadioButton Opt_Calendario;
        internal System.Windows.Forms.RadioButton Opt_Habiles;
        internal System.Windows.Forms.Label CLabel3;
        internal System.Windows.Forms.Label CLabel2;
        internal System.Windows.Forms.Label CLabel1;
        internal System.Windows.Forms.NumericUpDown Nud_Duracion;
        internal gnUserControl.gnComboBox Cbo_codPasoActoPrevio;
        internal System.Windows.Forms.Label CLabel16;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton Btn_Nuevo;
        internal System.Windows.Forms.ToolStripButton Btn_Grabar;
        internal System.Windows.Forms.ToolStripButton Btn_DesHacer;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton Btn_Eliminar;
        internal Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        internal gnUserControl.gnComboBox Cbo_PeriodoProceso;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel1;
        internal gnUserControl.gnComboBox Cbo_TipoProceso;
        internal gnUserControl.gnComboBox Cbo_ObjetoContratacion;
        internal System.Windows.Forms.Button Btn_Mostrar;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel6;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel5;
        internal System.Windows.Forms.ContextMenuStrip cms_Menu;
        internal System.Windows.Forms.ToolStripMenuItem MnuI_TrasladarItemPAC;
        internal System.Windows.Forms.SaveFileDialog SaveDocumento;
        internal Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter UltraGridExcelExporter1;
    }
}