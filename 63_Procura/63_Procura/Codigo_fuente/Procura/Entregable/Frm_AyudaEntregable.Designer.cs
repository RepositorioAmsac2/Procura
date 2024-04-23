namespace WINlogistica
{
    partial class Frm_AyudaEntregable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AyudaEntregable));
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Grd_Entregables = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.CMS_Entregable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Btn_NuevoEntregable = new System.Windows.Forms.ToolStripMenuItem();
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Btn_Adicionales = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
            this.Txt_MontoTotal = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.Edt_DesContrato = new gnUserControl.gnEditBox();
            this.Txt_numContrato = new gnUserControl.gnTextBox_Simple();
            this.Btn_Busqueda = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Entregables)).BeginInit();
            this.CMS_Entregable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_MontoTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edt_DesContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_numContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.ultraGroupBox1.Controls.Add(this.Grd_Entregables);
            this.ultraGroupBox1.Controls.Add(this.ultraGroupBox2);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(1075, 339);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Grd_Entregables
            // 
            this.Grd_Entregables.ContextMenuStrip = this.CMS_Entregable;
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
            this.Grd_Entregables.Location = new System.Drawing.Point(1, 65);
            this.Grd_Entregables.Name = "Grd_Entregables";
            this.Grd_Entregables.Size = new System.Drawing.Size(1073, 273);
            this.Grd_Entregables.TabIndex = 41;
            this.Grd_Entregables.DoubleClick += new System.EventHandler(this.Grd_Entregables_DoubleClick);
            // 
            // CMS_Entregable
            // 
            this.CMS_Entregable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_NuevoEntregable});
            this.CMS_Entregable.Name = "CMS_Entregable";
            this.CMS_Entregable.Size = new System.Drawing.Size(169, 26);
            // 
            // Btn_NuevoEntregable
            // 
            this.Btn_NuevoEntregable.Name = "Btn_NuevoEntregable";
            this.Btn_NuevoEntregable.Size = new System.Drawing.Size(168, 22);
            this.Btn_NuevoEntregable.Text = "Nuevo Entregable";
            // 
            // ultraGroupBox2
            // 
            this.ultraGroupBox2.Controls.Add(this.Btn_Adicionales);
            this.ultraGroupBox2.Controls.Add(this.Txt_MontoTotal);
            this.ultraGroupBox2.Controls.Add(this.label2);
            this.ultraGroupBox2.Controls.Add(this.Edt_DesContrato);
            this.ultraGroupBox2.Controls.Add(this.Txt_numContrato);
            this.ultraGroupBox2.Controls.Add(this.Btn_Busqueda);
            this.ultraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraGroupBox2.Location = new System.Drawing.Point(1, 0);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(1073, 65);
            this.ultraGroupBox2.TabIndex = 0;
            this.ultraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Btn_Adicionales
            // 
            this.Btn_Adicionales.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Adicionales.BorderShadowColor = System.Drawing.Color.Empty;
            this.Btn_Adicionales.Image = ((object)(resources.GetObject("Btn_Adicionales.Image")));
            this.Btn_Adicionales.Location = new System.Drawing.Point(902, 19);
            this.Btn_Adicionales.Name = "Btn_Adicionales";
            this.Btn_Adicionales.Size = new System.Drawing.Size(18, 21);
            this.Btn_Adicionales.TabIndex = 76;
            this.Btn_Adicionales.Visible = false;
            this.Btn_Adicionales.Click += new System.EventHandler(this.Btn_Ajuste_B_Click);
            // 
            // Txt_MontoTotal
            // 
            this.Txt_MontoTotal.Enabled = false;
            this.Txt_MontoTotal.Location = new System.Drawing.Point(923, 20);
            this.Txt_MontoTotal.Name = "Txt_MontoTotal";
            this.Txt_MontoTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.Txt_MontoTotal.Size = new System.Drawing.Size(143, 21);
            this.Txt_MontoTotal.TabIndex = 11;
            this.Txt_MontoTotal.ValueChanged += new System.EventHandler(this.ultraNumericEditor1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(830, 21);
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
            this.Edt_DesContrato.Location = new System.Drawing.Point(265, 23);
            this.Edt_DesContrato.Multiline = true;
            this.Edt_DesContrato.Name = "Edt_DesContrato";
            this.Edt_DesContrato.resaltarCampoOmitido = false;
            this.Edt_DesContrato.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Edt_DesContrato.Size = new System.Drawing.Size(454, 21);
            this.Edt_DesContrato.TabIndex = 4;
            this.Edt_DesContrato.tipoDatoC = gnUserControl.gnEditBox.TipoC.Ninguno;
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
            this.Txt_numContrato.Text = "CNT-2020-0001";
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
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Siguiente.png");
            // 
            // Frm_AyudaEntregable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 339);
            this.Controls.Add(this.ultraGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AyudaEntregable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Entregable";
            this.Load += new System.EventHandler(this.Frm_NuevoEntregable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Entregables)).EndInit();
            this.CMS_Entregable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            this.ultraGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_MontoTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edt_DesContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_numContrato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        private gnUserControl.gnTextBox_Simple Txt_numContrato;
        private Infragistics.Win.UltraWinGrid.UltraGrid Grd_Entregables;
        private gnUserControl.gnEditBox Edt_DesContrato;
        private System.Windows.Forms.ContextMenuStrip CMS_Entregable;
        private System.Windows.Forms.ToolStripMenuItem Btn_NuevoEntregable;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor Txt_MontoTotal;
        internal Infragistics.Win.UltraWinEditors.UltraPictureBox Btn_Adicionales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Busqueda;
        private System.Windows.Forms.ImageList imageList1;
    }
}