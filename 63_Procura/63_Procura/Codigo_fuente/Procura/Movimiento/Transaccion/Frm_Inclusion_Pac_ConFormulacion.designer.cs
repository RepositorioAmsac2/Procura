namespace WINlogistica
{
    partial class Frm_Inclusion_Pac_ConFormulacion
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
            Infragistics.Win.Appearance Appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance14 = new Infragistics.Win.Appearance();
            this.UltraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.grd_mvto_Activo = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.cbo_EntidadConvocante = new gnUserControl.gnComboBox();
            this.cbo_FuenteFinanciamiento = new gnUserControl.gnComboBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.cbo_TipoAdquisicion = new gnUserControl.gnComboBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.cbo_ModalidadSeleccion = new gnUserControl.gnComboBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.edt_Descripcion = new gnUserControl.gnEditBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.dtp_FechaPrevista = new gnUserControl.gnDateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.cbo_ObjetoContratacion = new gnUserControl.gnComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_TipoProceso = new gnUserControl.gnComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UltraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Txt_NumProcedimiento = new gnUserControl.gnMaskedTextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.txt_Version = new gnUserControl.gnTextBox_Simple();
            this.txt_AñoProceso = new gnUserControl.gnTextBox_Simple();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Grabar = new System.Windows.Forms.ToolStripButton();
            this.tsb_Grabar_Salir = new System.Windows.Forms.ToolStripButton();
            this.Mnu_LineaFormulacion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_AgregarRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_EliminarRegistro = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).BeginInit();
            this.UltraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_mvto_Activo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Descripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_FechaPrevista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).BeginInit();
            this.UltraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Version)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AñoProceso)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.Mnu_LineaFormulacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // UltraGroupBox3
            // 
            this.UltraGroupBox3.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.UltraGroupBox3.Controls.Add(this.grd_mvto_Activo);
            this.UltraGroupBox3.Controls.Add(this.ultraGroupBox1);
            this.UltraGroupBox3.Controls.Add(this.UltraGroupBox2);
            this.UltraGroupBox3.Controls.Add(this.ToolStrip1);
            this.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox3.Location = new System.Drawing.Point(0, 0);
            this.UltraGroupBox3.Name = "UltraGroupBox3";
            this.UltraGroupBox3.Size = new System.Drawing.Size(734, 488);
            this.UltraGroupBox3.TabIndex = 50;
            this.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // grd_mvto_Activo
            // 
            this.grd_mvto_Activo.ContextMenuStrip = this.Mnu_LineaFormulacion;
            Appearance1.BackColor = System.Drawing.Color.Transparent;
            Appearance1.BackColor2 = System.Drawing.Color.Transparent;
            Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal;
            this.grd_mvto_Activo.DisplayLayout.Appearance = Appearance1;
            this.grd_mvto_Activo.DisplayLayout.InterBandSpacing = 10;
            Appearance8.BackColor = System.Drawing.Color.PowderBlue;
            Appearance8.BackColor2 = System.Drawing.Color.PowderBlue;
            this.grd_mvto_Activo.DisplayLayout.Override.ActiveCellAppearance = Appearance8;
            appearance3.BackColor = System.Drawing.Color.Transparent;
            this.grd_mvto_Activo.DisplayLayout.Override.CardAreaAppearance = appearance3;
            Appearance11.BackColor = System.Drawing.Color.Transparent;
            Appearance11.BackColor2 = System.Drawing.Color.Transparent;
            Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance11.ForeColor = System.Drawing.Color.Black;
            Appearance11.TextHAlignAsString = "Center";
            Appearance11.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.grd_mvto_Activo.DisplayLayout.Override.HeaderAppearance = Appearance11;
            Appearance12.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.grd_mvto_Activo.DisplayLayout.Override.RowAppearance = Appearance12;
            Appearance13.BackColor = System.Drawing.Color.PapayaWhip;
            Appearance13.BackColor2 = System.Drawing.Color.PapayaWhip;
            Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.grd_mvto_Activo.DisplayLayout.Override.RowSelectorAppearance = Appearance13;
            this.grd_mvto_Activo.DisplayLayout.Override.RowSelectorWidth = 12;
            this.grd_mvto_Activo.DisplayLayout.Override.RowSpacingBefore = 2;
            Appearance14.BackColor = System.Drawing.Color.PapayaWhip;
            Appearance14.BackColor2 = System.Drawing.Color.PapayaWhip;
            Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance14.ForeColor = System.Drawing.Color.Black;
            this.grd_mvto_Activo.DisplayLayout.Override.SelectedRowAppearance = Appearance14;
            this.grd_mvto_Activo.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.grd_mvto_Activo.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.grd_mvto_Activo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_mvto_Activo.Location = new System.Drawing.Point(1, 317);
            this.grd_mvto_Activo.Name = "grd_mvto_Activo";
            this.grd_mvto_Activo.Size = new System.Drawing.Size(732, 170);
            this.grd_mvto_Activo.TabIndex = 603;
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.Controls.Add(this.cbo_EntidadConvocante);
            this.ultraGroupBox1.Controls.Add(this.cbo_FuenteFinanciamiento);
            this.ultraGroupBox1.Controls.Add(this.Label16);
            this.ultraGroupBox1.Controls.Add(this.Label9);
            this.ultraGroupBox1.Controls.Add(this.cbo_TipoAdquisicion);
            this.ultraGroupBox1.Controls.Add(this.Label11);
            this.ultraGroupBox1.Controls.Add(this.cbo_ModalidadSeleccion);
            this.ultraGroupBox1.Controls.Add(this.Label12);
            this.ultraGroupBox1.Controls.Add(this.edt_Descripcion);
            this.ultraGroupBox1.Controls.Add(this.Label10);
            this.ultraGroupBox1.Controls.Add(this.dtp_FechaPrevista);
            this.ultraGroupBox1.Controls.Add(this.Label4);
            this.ultraGroupBox1.Controls.Add(this.cbo_ObjetoContratacion);
            this.ultraGroupBox1.Controls.Add(this.label6);
            this.ultraGroupBox1.Controls.Add(this.cbo_TipoProceso);
            this.ultraGroupBox1.Controls.Add(this.label7);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.ultraGroupBox1.Location = new System.Drawing.Point(1, 64);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(732, 253);
            this.ultraGroupBox1.TabIndex = 602;
            this.ultraGroupBox1.Text = "Datos generales de la Adquisición";
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // cbo_EntidadConvocante
            // 
            this.cbo_EntidadConvocante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_EntidadConvocante.Enabled = false;
            this.cbo_EntidadConvocante.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.cbo_EntidadConvocante.FormattingEnabled = true;
            this.cbo_EntidadConvocante.leaveFocusColor = System.Drawing.Color.White;
            this.cbo_EntidadConvocante.Location = new System.Drawing.Point(208, 170);
            this.cbo_EntidadConvocante.Name = "cbo_EntidadConvocante";
            this.cbo_EntidadConvocante.nombreDS = null;
            this.cbo_EntidadConvocante.nombreSP = "";
            this.cbo_EntidadConvocante.parametrosSP = "";
            this.cbo_EntidadConvocante.resaltarCampoOmitido = false;
            this.cbo_EntidadConvocante.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.cbo_EntidadConvocante.Size = new System.Drawing.Size(327, 21);
            this.cbo_EntidadConvocante.TabIndex = 672;
            this.cbo_EntidadConvocante.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // cbo_FuenteFinanciamiento
            // 
            this.cbo_FuenteFinanciamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_FuenteFinanciamiento.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.cbo_FuenteFinanciamiento.FormattingEnabled = true;
            this.cbo_FuenteFinanciamiento.leaveFocusColor = System.Drawing.Color.White;
            this.cbo_FuenteFinanciamiento.Location = new System.Drawing.Point(208, 222);
            this.cbo_FuenteFinanciamiento.Name = "cbo_FuenteFinanciamiento";
            this.cbo_FuenteFinanciamiento.nombreDS = null;
            this.cbo_FuenteFinanciamiento.nombreSP = "";
            this.cbo_FuenteFinanciamiento.parametrosSP = "";
            this.cbo_FuenteFinanciamiento.resaltarCampoOmitido = false;
            this.cbo_FuenteFinanciamiento.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.cbo_FuenteFinanciamiento.Size = new System.Drawing.Size(327, 21);
            this.cbo_FuenteFinanciamiento.TabIndex = 677;
            this.cbo_FuenteFinanciamiento.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.Location = new System.Drawing.Point(99, 174);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(107, 13);
            this.Label16.TabIndex = 684;
            this.Label16.Text = "Entidad Convocante:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Location = new System.Drawing.Point(74, 224);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(132, 13);
            this.Label9.TabIndex = 680;
            this.Label9.Text = "Fuente de Financiamiento:";
            // 
            // cbo_TipoAdquisicion
            // 
            this.cbo_TipoAdquisicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TipoAdquisicion.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.cbo_TipoAdquisicion.FormattingEnabled = true;
            this.cbo_TipoAdquisicion.leaveFocusColor = System.Drawing.Color.White;
            this.cbo_TipoAdquisicion.Location = new System.Drawing.Point(208, 145);
            this.cbo_TipoAdquisicion.Name = "cbo_TipoAdquisicion";
            this.cbo_TipoAdquisicion.nombreDS = null;
            this.cbo_TipoAdquisicion.nombreSP = "";
            this.cbo_TipoAdquisicion.parametrosSP = "";
            this.cbo_TipoAdquisicion.resaltarCampoOmitido = false;
            this.cbo_TipoAdquisicion.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.cbo_TipoAdquisicion.Size = new System.Drawing.Size(327, 21);
            this.cbo_TipoAdquisicion.TabIndex = 671;
            this.cbo_TipoAdquisicion.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Location = new System.Drawing.Point(65, 148);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(141, 13);
            this.Label11.TabIndex = 682;
            this.Label11.Text = "Tipo de compra o selección:";
            // 
            // cbo_ModalidadSeleccion
            // 
            this.cbo_ModalidadSeleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ModalidadSeleccion.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.cbo_ModalidadSeleccion.FormattingEnabled = true;
            this.cbo_ModalidadSeleccion.leaveFocusColor = System.Drawing.Color.White;
            this.cbo_ModalidadSeleccion.Location = new System.Drawing.Point(208, 195);
            this.cbo_ModalidadSeleccion.Name = "cbo_ModalidadSeleccion";
            this.cbo_ModalidadSeleccion.nombreDS = null;
            this.cbo_ModalidadSeleccion.nombreSP = "";
            this.cbo_ModalidadSeleccion.parametrosSP = "";
            this.cbo_ModalidadSeleccion.resaltarCampoOmitido = false;
            this.cbo_ModalidadSeleccion.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.cbo_ModalidadSeleccion.Size = new System.Drawing.Size(327, 21);
            this.cbo_ModalidadSeleccion.TabIndex = 673;
            this.cbo_ModalidadSeleccion.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Location = new System.Drawing.Point(81, 198);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(125, 13);
            this.Label12.TabIndex = 683;
            this.Label12.Text = "Modalidad de  selección:";
            // 
            // edt_Descripcion
            // 
            this.edt_Descripcion.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.edt_Descripcion.exigirCampoLleno = false;
            this.edt_Descripcion.KeyDownUp = "";
            this.edt_Descripcion.leaveFocusColor = System.Drawing.Color.White;
            this.edt_Descripcion.Location = new System.Drawing.Point(208, 60);
            this.edt_Descripcion.Multiline = true;
            this.edt_Descripcion.Name = "edt_Descripcion";
            this.edt_Descripcion.resaltarCampoOmitido = false;
            this.edt_Descripcion.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.edt_Descripcion.Size = new System.Drawing.Size(513, 54);
            this.edt_Descripcion.TabIndex = 6;
            this.edt_Descripcion.tipoDatoC = gnUserControl.gnEditBox.TipoC.Ninguno;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Location = new System.Drawing.Point(37, 122);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(171, 13);
            this.Label10.TabIndex = 662;
            this.Label10.Text = "Fecha prevista de la convocatoria:";
            // 
            // dtp_FechaPrevista
            // 
            this.dtp_FechaPrevista.DateTime = new System.DateTime(2013, 12, 18, 0, 0, 0, 0);
            this.dtp_FechaPrevista.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.dtp_FechaPrevista.exigirCampoLleno = false;
            this.dtp_FechaPrevista.KeyDownUp = "";
            this.dtp_FechaPrevista.leaveFocusColor = System.Drawing.Color.White;
            this.dtp_FechaPrevista.Location = new System.Drawing.Point(208, 118);
            this.dtp_FechaPrevista.Name = "dtp_FechaPrevista";
            this.dtp_FechaPrevista.resaltarCampoOmitido = false;
            this.dtp_FechaPrevista.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.dtp_FechaPrevista.Size = new System.Drawing.Size(128, 21);
            this.dtp_FechaPrevista.TabIndex = 8;
            this.dtp_FechaPrevista.Value = new System.DateTime(2013, 12, 18, 0, 0, 0, 0);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Location = new System.Drawing.Point(104, 63);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(104, 39);
            this.Label4.TabIndex = 648;
            this.Label4.Text = "Descripción del Bien\r\nServicio u Obra a \r\nContratar:\r\n";
            // 
            // cbo_ObjetoContratacion
            // 
            this.cbo_ObjetoContratacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ObjetoContratacion.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.cbo_ObjetoContratacion.FormattingEnabled = true;
            this.cbo_ObjetoContratacion.leaveFocusColor = System.Drawing.Color.White;
            this.cbo_ObjetoContratacion.Location = new System.Drawing.Point(208, 36);
            this.cbo_ObjetoContratacion.Name = "cbo_ObjetoContratacion";
            this.cbo_ObjetoContratacion.nombreDS = null;
            this.cbo_ObjetoContratacion.nombreSP = "";
            this.cbo_ObjetoContratacion.parametrosSP = "";
            this.cbo_ObjetoContratacion.resaltarCampoOmitido = false;
            this.cbo_ObjetoContratacion.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.cbo_ObjetoContratacion.Size = new System.Drawing.Size(327, 21);
            this.cbo_ObjetoContratacion.TabIndex = 5;
            this.cbo_ObjetoContratacion.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(89, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 643;
            this.label6.Text = "Objeto de Contratación:";
            // 
            // cbo_TipoProceso
            // 
            this.cbo_TipoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TipoProceso.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.cbo_TipoProceso.FormattingEnabled = true;
            this.cbo_TipoProceso.leaveFocusColor = System.Drawing.Color.White;
            this.cbo_TipoProceso.Location = new System.Drawing.Point(208, 11);
            this.cbo_TipoProceso.Name = "cbo_TipoProceso";
            this.cbo_TipoProceso.nombreDS = null;
            this.cbo_TipoProceso.nombreSP = "";
            this.cbo_TipoProceso.parametrosSP = "";
            this.cbo_TipoProceso.resaltarCampoOmitido = false;
            this.cbo_TipoProceso.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.cbo_TipoProceso.Size = new System.Drawing.Size(327, 21);
            this.cbo_TipoProceso.TabIndex = 2;
            this.cbo_TipoProceso.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(120, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 640;
            this.label7.Text = "Tipo de Proceso:";
            // 
            // UltraGroupBox2
            // 
            this.UltraGroupBox2.Controls.Add(this.Txt_NumProcedimiento);
            this.UltraGroupBox2.Controls.Add(this.Label17);
            this.UltraGroupBox2.Controls.Add(this.txt_Version);
            this.UltraGroupBox2.Controls.Add(this.txt_AñoProceso);
            this.UltraGroupBox2.Controls.Add(this.Label15);
            this.UltraGroupBox2.Controls.Add(this.Label13);
            this.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.UltraGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.UltraGroupBox2.Location = new System.Drawing.Point(1, 25);
            this.UltraGroupBox2.Name = "UltraGroupBox2";
            this.UltraGroupBox2.Size = new System.Drawing.Size(732, 39);
            this.UltraGroupBox2.TabIndex = 0;
            this.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Txt_NumProcedimiento
            // 
            this.Txt_NumProcedimiento.enabledFocusColor = System.Drawing.Color.Gainsboro;
            this.Txt_NumProcedimiento.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Txt_NumProcedimiento.exigirCampoLleno = false;
            this.Txt_NumProcedimiento.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_NumProcedimiento.Location = new System.Drawing.Point(596, 11);
            this.Txt_NumProcedimiento.Mask = ">LL-999-9999->LL";
            this.Txt_NumProcedimiento.Name = "Txt_NumProcedimiento";
            this.Txt_NumProcedimiento.resaltarCampoOmitido = false;
            this.Txt_NumProcedimiento.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_NumProcedimiento.Size = new System.Drawing.Size(125, 20);
            this.Txt_NumProcedimiento.TabIndex = 3;
            this.Txt_NumProcedimiento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.Txt_NumProcedimiento.Leave += new System.EventHandler(this.Txt_NumProcedimiento_Leave);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.Location = new System.Drawing.Point(477, 14);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(116, 13);
            this.Label17.TabIndex = 673;
            this.Label17.Text = "Tipo de Procedimiento:";
            // 
            // txt_Version
            // 
            this.txt_Version.Enabled = false;
            this.txt_Version.enabledFocusColor = System.Drawing.Color.Lavender;
            this.txt_Version.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.txt_Version.exigirCampoLleno = false;
            this.txt_Version.leaveFocusColor = System.Drawing.Color.White;
            this.txt_Version.Location = new System.Drawing.Point(223, 10);
            this.txt_Version.LongitudTexto = 200;
            this.txt_Version.Name = "txt_Version";
            this.txt_Version.resaltarCampoOmitido = false;
            this.txt_Version.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.txt_Version.Size = new System.Drawing.Size(55, 21);
            this.txt_Version.TabIndex = 1;
            this.txt_Version.tipoDato = gnUserControl.gnTextBox_Simple.Tipo.Ninguno;
            this.txt_Version.tipoDatoC = gnUserControl.gnTextBox_Simple.TipoC.Ninguno;
            // 
            // txt_AñoProceso
            // 
            this.txt_AñoProceso.Enabled = false;
            this.txt_AñoProceso.enabledFocusColor = System.Drawing.Color.Lavender;
            this.txt_AñoProceso.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.txt_AñoProceso.exigirCampoLleno = false;
            this.txt_AñoProceso.leaveFocusColor = System.Drawing.Color.White;
            this.txt_AñoProceso.Location = new System.Drawing.Point(104, 10);
            this.txt_AñoProceso.LongitudTexto = 200;
            this.txt_AñoProceso.Name = "txt_AñoProceso";
            this.txt_AñoProceso.resaltarCampoOmitido = false;
            this.txt_AñoProceso.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.txt_AñoProceso.Size = new System.Drawing.Size(55, 21);
            this.txt_AñoProceso.TabIndex = 0;
            this.txt_AñoProceso.tipoDato = gnUserControl.gnTextBox_Simple.Tipo.Ninguno;
            this.txt_AñoProceso.tipoDatoC = gnUserControl.gnTextBox_Simple.TipoC.Ninguno;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.BackColor = System.Drawing.Color.Transparent;
            this.Label15.Location = new System.Drawing.Point(174, 13);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(45, 13);
            this.Label15.TabIndex = 669;
            this.Label15.Text = "Versión:";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Location = new System.Drawing.Point(17, 13);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(86, 13);
            this.Label13.TabIndex = 668;
            this.Label13.Text = "Año de Proceso:";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Nuevo,
            this.ToolStripSeparator1,
            this.tsb_Grabar,
            this.tsb_Grabar_Salir});
            this.ToolStrip1.Location = new System.Drawing.Point(1, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(732, 25);
            this.ToolStrip1.TabIndex = 601;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // tsb_Nuevo
            // 
            this.tsb_Nuevo.Enabled = false;
            this.tsb_Nuevo.Image = global::WINlogistica.Properties.Resources.mod_Documento1;
            this.tsb_Nuevo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsb_Nuevo.Name = "tsb_Nuevo";
            this.tsb_Nuevo.Size = new System.Drawing.Size(62, 22);
            this.tsb_Nuevo.Text = "&Nuevo";
            this.tsb_Nuevo.Click += new System.EventHandler(this.tsb_Nuevo_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_Grabar
            // 
            this.tsb_Grabar.Image = global::WINlogistica.Properties.Resources.grabaRegistro;
            this.tsb_Grabar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsb_Grabar.Name = "tsb_Grabar";
            this.tsb_Grabar.Size = new System.Drawing.Size(62, 22);
            this.tsb_Grabar.Text = "&Grabar";
            this.tsb_Grabar.Click += new System.EventHandler(this.tsb_Grabar_Click);
            // 
            // tsb_Grabar_Salir
            // 
            this.tsb_Grabar_Salir.Image = global::WINlogistica.Properties.Resources.grabar_salir;
            this.tsb_Grabar_Salir.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsb_Grabar_Salir.Name = "tsb_Grabar_Salir";
            this.tsb_Grabar_Salir.Size = new System.Drawing.Size(96, 22);
            this.tsb_Grabar_Salir.Text = "Grabar y Salir";
            this.tsb_Grabar_Salir.Click += new System.EventHandler(this.tsb_Grabar_Salir_Click);
            // 
            // Mnu_LineaFormulacion
            // 
            this.Mnu_LineaFormulacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_AgregarRegistro,
            this.ToolStripMenuItem1,
            this.TSMI_EliminarRegistro});
            this.Mnu_LineaFormulacion.Name = "Mnu_UsoSuministro";
            this.Mnu_LineaFormulacion.Size = new System.Drawing.Size(218, 76);
            // 
            // TSMI_AgregarRegistro
            // 
            this.TSMI_AgregarRegistro.Name = "TSMI_AgregarRegistro";
            this.TSMI_AgregarRegistro.Size = new System.Drawing.Size(217, 22);
            this.TSMI_AgregarRegistro.Text = "Agregar Linea Formulación";
            this.TSMI_AgregarRegistro.Click += new System.EventHandler(this.TSMI_AgregarRegistro_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(214, 6);
            // 
            // TSMI_EliminarRegistro
            // 
            this.TSMI_EliminarRegistro.Name = "TSMI_EliminarRegistro";
            this.TSMI_EliminarRegistro.Size = new System.Drawing.Size(217, 22);
            this.TSMI_EliminarRegistro.Text = "Quitar Linea Formulación";
            // 
            // Frm_Inclusion_Pac_ConFormulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 488);
            this.Controls.Add(this.UltraGroupBox3);
            this.Name = "Frm_Inclusion_Pac_ConFormulacion";
            this.Text = "Inclusión de Item del PAC";
            this.Load += new System.EventHandler(this.Frm_Inclusion_Pac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).EndInit();
            this.UltraGroupBox3.ResumeLayout(false);
            this.UltraGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_mvto_Activo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Descripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_FechaPrevista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).EndInit();
            this.UltraGroupBox2.ResumeLayout(false);
            this.UltraGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Version)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AñoProceso)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.Mnu_LineaFormulacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox3;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton tsb_Nuevo;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton tsb_Grabar;
        internal System.Windows.Forms.ToolStripButton tsb_Grabar_Salir;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox2;
        internal gnUserControl.gnMaskedTextBox Txt_NumProcedimiento;
        internal System.Windows.Forms.Label Label17;
        internal gnUserControl.gnTextBox_Simple txt_Version;
        internal gnUserControl.gnTextBox_Simple txt_AñoProceso;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.ContextMenuStrip Mnu_LineaFormulacion;
        internal System.Windows.Forms.ToolStripMenuItem TSMI_AgregarRegistro;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem TSMI_EliminarRegistro;
        internal Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        internal gnUserControl.gnEditBox edt_Descripcion;
        internal System.Windows.Forms.Label Label10;
        internal gnUserControl.gnDateTimePicker dtp_FechaPrevista;
        internal System.Windows.Forms.Label Label4;
        internal gnUserControl.gnComboBox cbo_ObjetoContratacion;
        internal System.Windows.Forms.Label label6;
        internal gnUserControl.gnComboBox cbo_TipoProceso;
        internal System.Windows.Forms.Label label7;
        internal gnUserControl.gnComboBox cbo_EntidadConvocante;
        internal gnUserControl.gnComboBox cbo_FuenteFinanciamiento;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label9;
        internal gnUserControl.gnComboBox cbo_TipoAdquisicion;
        internal System.Windows.Forms.Label Label11;
        internal gnUserControl.gnComboBox cbo_ModalidadSeleccion;
        internal System.Windows.Forms.Label Label12;
        internal Infragistics.Win.UltraWinGrid.UltraGrid grd_mvto_Activo;
    }
}