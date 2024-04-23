namespace WINlogistica
{
    partial class Frm_ListaConsulta_PAC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListaConsulta_PAC));
            this.UltraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.UltraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Grd_mvto_ItemPAC = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tsb_Exportar = new System.Windows.Forms.ToolStripButton();
            this.UltraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Cbo_Version = new gnUserControl.gnComboBox();
            this.CLabel1 = new System.Windows.Forms.Label();
            this.Cbo_PeriodoProceso = new gnUserControl.gnComboBox();
            this.CLabel2 = new System.Windows.Forms.Label();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SaveDocumento = new System.Windows.Forms.SaveFileDialog();
            this.UltraGridExcelExporter1 = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox1)).BeginInit();
            this.UltraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).BeginInit();
            this.UltraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_mvto_ItemPAC)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).BeginInit();
            this.UltraGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UltraGroupBox1
            // 
            this.UltraGroupBox1.Controls.Add(this.UltraGroupBox3);
            this.UltraGroupBox1.Controls.Add(this.UltraGroupBox2);
            this.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.UltraGroupBox1.Name = "UltraGroupBox1";
            this.UltraGroupBox1.Size = new System.Drawing.Size(1029, 450);
            this.UltraGroupBox1.TabIndex = 1;
            this.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // UltraGroupBox3
            // 
            this.UltraGroupBox3.Controls.Add(this.Grd_mvto_ItemPAC);
            this.UltraGroupBox3.Controls.Add(this.ToolStrip1);
            this.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.UltraGroupBox3.Location = new System.Drawing.Point(3, 57);
            this.UltraGroupBox3.Name = "UltraGroupBox3";
            this.UltraGroupBox3.Size = new System.Drawing.Size(1023, 390);
            this.UltraGroupBox3.TabIndex = 47;
            this.UltraGroupBox3.Text = "2. Lista de Items del PAC";
            this.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Grd_mvto_ItemPAC
            // 
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
            this.Grd_mvto_ItemPAC.Size = new System.Drawing.Size(998, 359);
            this.Grd_mvto_ItemPAC.TabIndex = 52;
            this.Grd_mvto_ItemPAC.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.Grd_mvto_ItemPAC_InitializeLayout);
            this.Grd_mvto_ItemPAC.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.Grd_mvto_ItemPAC_ClickCellButton);
            this.Grd_mvto_ItemPAC.DoubleClickCell += new Infragistics.Win.UltraWinGrid.DoubleClickCellEventHandler(this.Grd_mvto_ItemPAC_DoubleClickCell);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsb_Exportar});
            this.ToolStrip1.Location = new System.Drawing.Point(22, 3);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(998, 25);
            this.ToolStrip1.TabIndex = 49;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // Tsb_Exportar
            // 
            this.Tsb_Exportar.Image = global::WINlogistica.Properties.Resources.Excel;
            this.Tsb_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Exportar.Name = "Tsb_Exportar";
            this.Tsb_Exportar.Size = new System.Drawing.Size(71, 22);
            this.Tsb_Exportar.Text = "Exportar";
            this.Tsb_Exportar.Click += new System.EventHandler(this.Tsb_Exportar_Click);
            // 
            // UltraGroupBox2
            // 
            this.UltraGroupBox2.Controls.Add(this.Cbo_Version);
            this.UltraGroupBox2.Controls.Add(this.CLabel1);
            this.UltraGroupBox2.Controls.Add(this.Cbo_PeriodoProceso);
            this.UltraGroupBox2.Controls.Add(this.CLabel2);
            this.UltraGroupBox2.Controls.Add(this.btn_Mostrar);
            this.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.UltraGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.UltraGroupBox2.Location = new System.Drawing.Point(3, 0);
            this.UltraGroupBox2.Name = "UltraGroupBox2";
            this.UltraGroupBox2.Size = new System.Drawing.Size(1023, 57);
            this.UltraGroupBox2.TabIndex = 46;
            this.UltraGroupBox2.Text = "1. Filtro";
            this.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Cbo_Version
            // 
            this.Cbo_Version.BackColor = System.Drawing.Color.White;
            this.Cbo_Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Version.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_Version.FormattingEnabled = true;
            this.Cbo_Version.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_Version.Location = new System.Drawing.Point(331, 22);
            this.Cbo_Version.Name = "Cbo_Version";
            this.Cbo_Version.nombreDS = null;
            this.Cbo_Version.nombreSP = "";
            this.Cbo_Version.parametrosSP = "";
            this.Cbo_Version.resaltarCampoOmitido = false;
            this.Cbo_Version.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_Version.Size = new System.Drawing.Size(128, 21);
            this.Cbo_Version.TabIndex = 33;
            this.Cbo_Version.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // CLabel1
            // 
            this.CLabel1.AutoSize = true;
            this.CLabel1.BackColor = System.Drawing.Color.Transparent;
            this.CLabel1.Location = new System.Drawing.Point(280, 25);
            this.CLabel1.Name = "CLabel1";
            this.CLabel1.Size = new System.Drawing.Size(45, 13);
            this.CLabel1.TabIndex = 32;
            this.CLabel1.Text = "Versión:";
            // 
            // Cbo_PeriodoProceso
            // 
            this.Cbo_PeriodoProceso.BackColor = System.Drawing.Color.White;
            this.Cbo_PeriodoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_PeriodoProceso.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_PeriodoProceso.FormattingEnabled = true;
            this.Cbo_PeriodoProceso.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_PeriodoProceso.Location = new System.Drawing.Point(127, 22);
            this.Cbo_PeriodoProceso.Name = "Cbo_PeriodoProceso";
            this.Cbo_PeriodoProceso.nombreDS = null;
            this.Cbo_PeriodoProceso.nombreSP = "";
            this.Cbo_PeriodoProceso.parametrosSP = "";
            this.Cbo_PeriodoProceso.resaltarCampoOmitido = false;
            this.Cbo_PeriodoProceso.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_PeriodoProceso.Size = new System.Drawing.Size(128, 21);
            this.Cbo_PeriodoProceso.TabIndex = 31;
            this.Cbo_PeriodoProceso.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // CLabel2
            // 
            this.CLabel2.AutoSize = true;
            this.CLabel2.BackColor = System.Drawing.Color.Transparent;
            this.CLabel2.Location = new System.Drawing.Point(36, 25);
            this.CLabel2.Name = "CLabel2";
            this.CLabel2.Size = new System.Drawing.Size(83, 13);
            this.CLabel2.TabIndex = 30;
            this.CLabel2.Text = "Año de Proceso";
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(796, 22);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Mostrar.TabIndex = 29;
            this.btn_Mostrar.Text = "&Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Silver;
            this.ImageList1.Images.SetKeyName(0, "newDocument.bmp");
            this.ImageList1.Images.SetKeyName(1, "mod_Documento.bmp");
            this.ImageList1.Images.SetKeyName(2, "del_Documento.bmp");
            // 
            // SaveDocumento
            // 
            this.SaveDocumento.DefaultExt = "XLS";
            this.SaveDocumento.Filter = "Excel (*.xls)|*.xls";
            this.SaveDocumento.RestoreDirectory = true;
            // 
            // Frm_ListaConsulta_PAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.UltraGroupBox1);
            this.Name = "Frm_ListaConsulta_PAC";
            this.Text = "Lista paraactualizar el PAC";
            this.Load += new System.EventHandler(this.Frm_ListaConsulta_PAC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox1)).EndInit();
            this.UltraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).EndInit();
            this.UltraGroupBox3.ResumeLayout(false);
            this.UltraGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_mvto_ItemPAC)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).EndInit();
            this.UltraGroupBox2.ResumeLayout(false);
            this.UltraGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox1;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox3;
        internal Infragistics.Win.UltraWinGrid.UltraGrid Grd_mvto_ItemPAC;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton Tsb_Exportar;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox2;
        internal gnUserControl.gnComboBox Cbo_Version;
        internal System.Windows.Forms.Label CLabel1;
        internal gnUserControl.gnComboBox Cbo_PeriodoProceso;
        internal System.Windows.Forms.Label CLabel2;
        internal System.Windows.Forms.Button btn_Mostrar;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.SaveFileDialog SaveDocumento;
        internal Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter UltraGridExcelExporter1;
    }
}