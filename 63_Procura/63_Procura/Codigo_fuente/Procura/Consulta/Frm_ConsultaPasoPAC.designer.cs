namespace WINlogistica
{
    partial class Frm_ConsultaPasoPAC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsultaPasoPAC));
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Grd_mvto_Pac_Paso = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tsb_Exportar = new System.Windows.Forms.ToolStripButton();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SaveDocumento = new System.Windows.Forms.SaveFileDialog();
            this.UltraGridExcelExporter1 = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_mvto_Pac_Paso)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.ultraGroupBox1.Controls.Add(this.Grd_mvto_Pac_Paso);
            this.ultraGroupBox1.Controls.Add(this.ToolStrip1);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(897, 323);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Grd_mvto_Pac_Paso
            // 
            Appearance10.BackColor = System.Drawing.Color.Transparent;
            Appearance10.BackColor2 = System.Drawing.Color.Transparent;
            Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal;
            this.Grd_mvto_Pac_Paso.DisplayLayout.Appearance = Appearance10;
            this.Grd_mvto_Pac_Paso.DisplayLayout.InterBandSpacing = 10;
            Appearance2.BackColor = System.Drawing.Color.PowderBlue;
            Appearance2.BackColor2 = System.Drawing.Color.PowderBlue;
            this.Grd_mvto_Pac_Paso.DisplayLayout.Override.ActiveCellAppearance = Appearance2;
            Appearance3.BackColor = System.Drawing.Color.Transparent;
            this.Grd_mvto_Pac_Paso.DisplayLayout.Override.CardAreaAppearance = Appearance3;
            Appearance4.BackColor = System.Drawing.Color.Transparent;
            Appearance4.BackColor2 = System.Drawing.Color.Transparent;
            Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance4.ForeColor = System.Drawing.Color.Black;
            Appearance4.TextHAlignAsString = "Center";
            Appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.Grd_mvto_Pac_Paso.DisplayLayout.Override.HeaderAppearance = Appearance4;
            Appearance5.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Grd_mvto_Pac_Paso.DisplayLayout.Override.RowAppearance = Appearance5;
            Appearance6.BackColor = System.Drawing.Color.PapayaWhip;
            Appearance6.BackColor2 = System.Drawing.Color.PapayaWhip;
            Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.Grd_mvto_Pac_Paso.DisplayLayout.Override.RowSelectorAppearance = Appearance6;
            this.Grd_mvto_Pac_Paso.DisplayLayout.Override.RowSelectorWidth = 12;
            this.Grd_mvto_Pac_Paso.DisplayLayout.Override.RowSpacingBefore = 2;
            Appearance7.BackColor = System.Drawing.Color.PapayaWhip;
            Appearance7.BackColor2 = System.Drawing.Color.PapayaWhip;
            Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance7.ForeColor = System.Drawing.Color.Black;
            this.Grd_mvto_Pac_Paso.DisplayLayout.Override.SelectedRowAppearance = Appearance7;
            this.Grd_mvto_Pac_Paso.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.Grd_mvto_Pac_Paso.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.Grd_mvto_Pac_Paso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_mvto_Pac_Paso.Location = new System.Drawing.Point(1, 25);
            this.Grd_mvto_Pac_Paso.Name = "Grd_mvto_Pac_Paso";
            this.Grd_mvto_Pac_Paso.Size = new System.Drawing.Size(895, 297);
            this.Grd_mvto_Pac_Paso.TabIndex = 55;
            this.Grd_mvto_Pac_Paso.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.Grd_mvto_Pac_Paso_InitializeLayout);
            this.Grd_mvto_Pac_Paso.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.Grd_mvto_Pac_Paso_ClickCellButton);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsb_Exportar});
            this.ToolStrip1.Location = new System.Drawing.Point(1, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(895, 25);
            this.ToolStrip1.TabIndex = 46;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // Tsb_Exportar
            // 
            this.Tsb_Exportar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Tsb_Exportar.Name = "Tsb_Exportar";
            this.Tsb_Exportar.Size = new System.Drawing.Size(54, 22);
            this.Tsb_Exportar.Text = "Exportar";
            this.Tsb_Exportar.Click += new System.EventHandler(this.Tsb_Exportar_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Signoexclamacion_cabecera.png");
            this.imageList2.Images.SetKeyName(1, "campana_cabecera.png");
            this.imageList2.Images.SetKeyName(2, "email_respondido.png");
            this.imageList2.Images.SetKeyName(3, "Adjuntar_cabecera.png");
            this.imageList2.Images.SetKeyName(4, "Seguimiento_Detalle.png");
            this.imageList2.Images.SetKeyName(5, "Leido.png");
            // 
            // SaveDocumento
            // 
            this.SaveDocumento.DefaultExt = "XLS";
            this.SaveDocumento.Filter = "Excel (*.xls)|*.xls";
            this.SaveDocumento.RestoreDirectory = true;
            // 
            // Frm_ConsultaPasoPAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 323);
            this.Controls.Add(this.ultraGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ConsultaPasoPAC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasos del PAC";
            this.Load += new System.EventHandler(this.Frm_ConsultaPasoPAC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.ultraGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_mvto_Pac_Paso)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        internal Infragistics.Win.UltraWinGrid.UltraGrid Grd_mvto_Pac_Paso;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton Tsb_Exportar;
        private System.Windows.Forms.ImageList imageList2;
        internal System.Windows.Forms.SaveFileDialog SaveDocumento;
        internal Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter UltraGridExcelExporter1;
    }
}