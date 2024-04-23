namespace WINlogistica
{
    partial class Frm_NuevoAnticipo
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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("", -1);
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinScrollBar.ScrollBarLook scrollBarLook1 = new Infragistics.Win.UltraWinScrollBar.ScrollBarLook();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NuevoAnticipo));
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Grd_Entregables = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.CMS_Adenda = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Btn_NuevoAdicional = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Btn_Adicionales = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
            this.Txt_MontoTotal = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.Txt_DesTipoAdquisicion = new gnUserControl.gnTextBox_Simple();
            this.label4 = new System.Windows.Forms.Label();
            this.Dtp_FecInicio = new gnUserControl.gnDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Edt_DesContrato = new gnUserControl.gnEditBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_numContrato = new gnUserControl.gnTextBox_Simple();
            this.Btn_Busqueda = new System.Windows.Forms.Button();
            this.Btn_Mostrar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Entregables)).BeginInit();
            this.CMS_Adenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_MontoTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DesTipoAdquisicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtp_FecInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edt_DesContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_numContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.ultraGroupBox1.Controls.Add(this.Grd_Entregables);
            this.ultraGroupBox1.Controls.Add(this.toolStrip1);
            this.ultraGroupBox1.Controls.Add(this.ultraGroupBox2);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(1181, 450);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Grd_Entregables
            // 
            this.Grd_Entregables.ContextMenuStrip = this.CMS_Adenda;
            this.Grd_Entregables.Cursor = System.Windows.Forms.Cursors.Default;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.Grd_Entregables.DisplayLayout.Appearance = appearance2;
            appearance3.ImageBackgroundAlpha = Infragistics.Win.Alpha.Transparent;
            ultraGridBand1.Header.Appearance = appearance3;
            this.Grd_Entregables.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.Grd_Entregables.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.Grd_Entregables.DisplayLayout.Override.CardAreaAppearance = appearance4;
            this.Grd_Entregables.DisplayLayout.Override.CellPadding = 3;
            appearance5.TextHAlignAsString = "Left";
            this.Grd_Entregables.DisplayLayout.Override.HeaderAppearance = appearance5;
            appearance6.BorderColor = System.Drawing.Color.LightGray;
            appearance6.TextVAlignAsString = "Middle";
            this.Grd_Entregables.DisplayLayout.Override.RowAppearance = appearance6;
            this.Grd_Entregables.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance7.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance7.BorderColor = System.Drawing.Color.Black;
            appearance7.ForeColor = System.Drawing.Color.Black;
            this.Grd_Entregables.DisplayLayout.Override.SelectedRowAppearance = appearance7;
            this.Grd_Entregables.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            scrollBarLook1.Appearance = appearance8;
            scrollBarLook1.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.BothAtRightBottom;
            scrollBarLook1.ShowMinMaxButtons = Infragistics.Win.DefaultableBoolean.True;
            this.Grd_Entregables.DisplayLayout.ScrollBarLook = scrollBarLook1;
            this.Grd_Entregables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_Entregables.Location = new System.Drawing.Point(1, 127);
            this.Grd_Entregables.Name = "Grd_Entregables";
            this.Grd_Entregables.Size = new System.Drawing.Size(1179, 322);
            this.Grd_Entregables.TabIndex = 41;
            // 
            // CMS_Adenda
            // 
            this.CMS_Adenda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_NuevoAdicional});
            this.CMS_Adenda.Name = "CMS_Entregable";
            this.CMS_Adenda.Size = new System.Drawing.Size(161, 26);
            // 
            // Btn_NuevoAdicional
            // 
            this.Btn_NuevoAdicional.Name = "Btn_NuevoAdicional";
            this.Btn_NuevoAdicional.Size = new System.Drawing.Size(160, 22);
            this.Btn_NuevoAdicional.Text = "Nuevo Adelanto";
            this.Btn_NuevoAdicional.Click += new System.EventHandler(this.Btn_NuevoAdicional_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Location = new System.Drawing.Point(1, 102);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1179, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ultraGroupBox2
            // 
            this.ultraGroupBox2.Controls.Add(this.Btn_Adicionales);
            this.ultraGroupBox2.Controls.Add(this.Txt_MontoTotal);
            this.ultraGroupBox2.Controls.Add(this.Txt_DesTipoAdquisicion);
            this.ultraGroupBox2.Controls.Add(this.label4);
            this.ultraGroupBox2.Controls.Add(this.Dtp_FecInicio);
            this.ultraGroupBox2.Controls.Add(this.label3);
            this.ultraGroupBox2.Controls.Add(this.label2);
            this.ultraGroupBox2.Controls.Add(this.Edt_DesContrato);
            this.ultraGroupBox2.Controls.Add(this.label1);
            this.ultraGroupBox2.Controls.Add(this.Txt_numContrato);
            this.ultraGroupBox2.Controls.Add(this.Btn_Busqueda);
            this.ultraGroupBox2.Controls.Add(this.Btn_Mostrar);
            this.ultraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraGroupBox2.Location = new System.Drawing.Point(1, 0);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(1179, 102);
            this.ultraGroupBox2.TabIndex = 0;
            this.ultraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Btn_Adicionales
            // 
            this.Btn_Adicionales.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Adicionales.BorderShadowColor = System.Drawing.Color.Empty;
            this.Btn_Adicionales.Image = ((object)(resources.GetObject("Btn_Adicionales.Image")));
            this.Btn_Adicionales.Location = new System.Drawing.Point(1004, 19);
            this.Btn_Adicionales.Name = "Btn_Adicionales";
            this.Btn_Adicionales.Size = new System.Drawing.Size(18, 21);
            this.Btn_Adicionales.TabIndex = 76;
            this.Btn_Adicionales.Visible = false;
            this.Btn_Adicionales.Click += new System.EventHandler(this.Btn_Ajuste_B_Click);
            // 
            // Txt_MontoTotal
            // 
            this.Txt_MontoTotal.Enabled = false;
            this.Txt_MontoTotal.Location = new System.Drawing.Point(1025, 20);
            this.Txt_MontoTotal.Name = "Txt_MontoTotal";
            this.Txt_MontoTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.Txt_MontoTotal.Size = new System.Drawing.Size(143, 21);
            this.Txt_MontoTotal.TabIndex = 11;
            this.Txt_MontoTotal.ValueChanged += new System.EventHandler(this.ultraNumericEditor1_ValueChanged);
            // 
            // Txt_DesTipoAdquisicion
            // 
            this.Txt_DesTipoAdquisicion.Enabled = false;
            this.Txt_DesTipoAdquisicion.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_DesTipoAdquisicion.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_DesTipoAdquisicion.exigirCampoLleno = false;
            this.Txt_DesTipoAdquisicion.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_DesTipoAdquisicion.Location = new System.Drawing.Point(1024, 67);
            this.Txt_DesTipoAdquisicion.LongitudTexto = 200;
            this.Txt_DesTipoAdquisicion.Name = "Txt_DesTipoAdquisicion";
            this.Txt_DesTipoAdquisicion.resaltarCampoOmitido = false;
            this.Txt_DesTipoAdquisicion.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_DesTipoAdquisicion.Size = new System.Drawing.Size(144, 21);
            this.Txt_DesTipoAdquisicion.TabIndex = 10;
            this.Txt_DesTipoAdquisicion.tipoDato = gnUserControl.gnTextBox_Simple.Tipo.Ninguno;
            this.Txt_DesTipoAdquisicion.tipoDatoC = gnUserControl.gnTextBox_Simple.TipoC.Ninguno;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(899, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de adquisición:";
            // 
            // Dtp_FecInicio
            // 
            this.Dtp_FecInicio.Enabled = false;
            this.Dtp_FecInicio.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Dtp_FecInicio.exigirCampoLleno = false;
            this.Dtp_FecInicio.KeyDownUp = "";
            this.Dtp_FecInicio.leaveFocusColor = System.Drawing.Color.White;
            this.Dtp_FecInicio.Location = new System.Drawing.Point(1024, 44);
            this.Dtp_FecInicio.Name = "Dtp_FecInicio";
            this.Dtp_FecInicio.resaltarCampoOmitido = false;
            this.Dtp_FecInicio.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Dtp_FecInicio.Size = new System.Drawing.Size(144, 21);
            this.Dtp_FecInicio.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(893, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inicio de actividades:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(932, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Importe total:";
            // 
            // Edt_DesContrato
            // 
            this.Edt_DesContrato.Enabled = false;
            this.Edt_DesContrato.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Edt_DesContrato.exigirCampoLleno = false;
            this.Edt_DesContrato.KeyDownUp = "";
            this.Edt_DesContrato.leaveFocusColor = System.Drawing.Color.White;
            this.Edt_DesContrato.Location = new System.Drawing.Point(142, 48);
            this.Edt_DesContrato.Multiline = true;
            this.Edt_DesContrato.Name = "Edt_DesContrato";
            this.Edt_DesContrato.resaltarCampoOmitido = false;
            this.Edt_DesContrato.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Edt_DesContrato.Size = new System.Drawing.Size(454, 44);
            this.Edt_DesContrato.TabIndex = 4;
            this.Edt_DesContrato.tipoDatoC = gnUserControl.gnEditBox.TipoC.Ninguno;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripción del contrato:";
            // 
            // Txt_numContrato
            // 
            this.Txt_numContrato.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_numContrato.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_numContrato.exigirCampoLleno = false;
            this.Txt_numContrato.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_numContrato.Location = new System.Drawing.Point(142, 23);
            this.Txt_numContrato.LongitudTexto = 200;
            this.Txt_numContrato.Name = "Txt_numContrato";
            this.Txt_numContrato.resaltarCampoOmitido = false;
            this.Txt_numContrato.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_numContrato.Size = new System.Drawing.Size(117, 21);
            this.Txt_numContrato.TabIndex = 2;
            this.Txt_numContrato.tipoDato = gnUserControl.gnTextBox_Simple.Tipo.Ninguno;
            this.Txt_numContrato.tipoDatoC = gnUserControl.gnTextBox_Simple.TipoC.Ninguno;
            // 
            // Btn_Busqueda
            // 
            this.Btn_Busqueda.Location = new System.Drawing.Point(17, 20);
            this.Btn_Busqueda.Name = "Btn_Busqueda";
            this.Btn_Busqueda.Size = new System.Drawing.Size(122, 23);
            this.Btn_Busqueda.TabIndex = 1;
            this.Btn_Busqueda.Text = "Contrato:";
            this.Btn_Busqueda.UseVisualStyleBackColor = true;
            this.Btn_Busqueda.Click += new System.EventHandler(this.Btn_Busqueda_Click);
            // 
            // Btn_Mostrar
            // 
            this.Btn_Mostrar.Location = new System.Drawing.Point(263, 22);
            this.Btn_Mostrar.Name = "Btn_Mostrar";
            this.Btn_Mostrar.Size = new System.Drawing.Size(32, 23);
            this.Btn_Mostrar.TabIndex = 0;
            this.Btn_Mostrar.Text = "Ir...";
            this.Btn_Mostrar.UseVisualStyleBackColor = true;
            this.Btn_Mostrar.Click += new System.EventHandler(this.Btn_Mostrar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Siguiente.png");
            // 
            // Frm_NuevoAnticipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 450);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "Frm_NuevoAnticipo";
            this.Text = "Nuevo Adelanto";
            this.Load += new System.EventHandler(this.Frm_NuevoEntregable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Entregables)).EndInit();
            this.CMS_Adenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            this.ultraGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_MontoTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_DesTipoAdquisicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtp_FecInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edt_DesContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_numContrato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        private gnUserControl.gnTextBox_Simple Txt_numContrato;
        private System.Windows.Forms.Button Btn_Mostrar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private Infragistics.Win.UltraWinGrid.UltraGrid Grd_Entregables;
        private gnUserControl.gnTextBox_Simple Txt_DesTipoAdquisicion;
        private System.Windows.Forms.Label label4;
        private gnUserControl.gnDateTimePicker Dtp_FecInicio;
        private System.Windows.Forms.Label label3;
        private gnUserControl.gnEditBox Edt_DesContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip CMS_Adenda;
        private System.Windows.Forms.ToolStripMenuItem Btn_NuevoAdicional;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor Txt_MontoTotal;
        internal Infragistics.Win.UltraWinEditors.UltraPictureBox Btn_Adicionales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Busqueda;
        private System.Windows.Forms.ImageList imageList1;
    }
}