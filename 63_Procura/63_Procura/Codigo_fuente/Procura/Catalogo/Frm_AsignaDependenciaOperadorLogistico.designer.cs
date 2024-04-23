namespace WINlogistica
{
    partial class Frm_AsignaDependenciaOperadorLogistico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AsignaDependenciaOperadorLogistico));
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.UltraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Grd_msto_OperadorLogistico = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.CMS_Dependencia = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_Modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_ExportarExcel = new System.Windows.Forms.ToolStripButton();
            this.SaveDocumento = new System.Windows.Forms.SaveFileDialog();
            this.UltraGridExcelExporter1 = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).BeginInit();
            this.UltraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_msto_OperadorLogistico)).BeginInit();
            this.CMS_Dependencia.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.ultraGroupBox1.Controls.Add(this.UltraGroupBox2);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(714, 363);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // UltraGroupBox2
            // 
            this.UltraGroupBox2.Controls.Add(this.Grd_msto_OperadorLogistico);
            this.UltraGroupBox2.Controls.Add(this.ToolStrip1);
            this.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.UltraGroupBox2.Location = new System.Drawing.Point(1, 0);
            this.UltraGroupBox2.Name = "UltraGroupBox2";
            this.UltraGroupBox2.Size = new System.Drawing.Size(712, 362);
            this.UltraGroupBox2.TabIndex = 1;
            this.UltraGroupBox2.Text = "1. Lista de Personal de Logistica";
            this.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Grd_msto_OperadorLogistico
            // 
            this.Grd_msto_OperadorLogistico.ContextMenuStrip = this.CMS_Dependencia;
            Appearance10.BackColor = System.Drawing.Color.Transparent;
            Appearance10.BackColor2 = System.Drawing.Color.Transparent;
            Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal;
            this.Grd_msto_OperadorLogistico.DisplayLayout.Appearance = Appearance10;
            this.Grd_msto_OperadorLogistico.DisplayLayout.InterBandSpacing = 10;
            Appearance2.BackColor = System.Drawing.Color.PowderBlue;
            Appearance2.BackColor2 = System.Drawing.Color.PowderBlue;
            this.Grd_msto_OperadorLogistico.DisplayLayout.Override.ActiveCellAppearance = Appearance2;
            Appearance3.BackColor = System.Drawing.Color.Transparent;
            this.Grd_msto_OperadorLogistico.DisplayLayout.Override.CardAreaAppearance = Appearance3;
            Appearance4.BackColor = System.Drawing.Color.Transparent;
            Appearance4.BackColor2 = System.Drawing.Color.Transparent;
            Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance4.ForeColor = System.Drawing.Color.Black;
            Appearance4.TextHAlignAsString = "Center";
            Appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.Grd_msto_OperadorLogistico.DisplayLayout.Override.HeaderAppearance = Appearance4;
            Appearance5.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Grd_msto_OperadorLogistico.DisplayLayout.Override.RowAppearance = Appearance5;
            Appearance6.BackColor = System.Drawing.Color.PapayaWhip;
            Appearance6.BackColor2 = System.Drawing.Color.PapayaWhip;
            Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.Grd_msto_OperadorLogistico.DisplayLayout.Override.RowSelectorAppearance = Appearance6;
            this.Grd_msto_OperadorLogistico.DisplayLayout.Override.RowSelectorWidth = 12;
            this.Grd_msto_OperadorLogistico.DisplayLayout.Override.RowSpacingBefore = 2;
            Appearance7.BackColor = System.Drawing.Color.PapayaWhip;
            Appearance7.BackColor2 = System.Drawing.Color.PapayaWhip;
            Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance7.ForeColor = System.Drawing.Color.Black;
            this.Grd_msto_OperadorLogistico.DisplayLayout.Override.SelectedRowAppearance = Appearance7;
            this.Grd_msto_OperadorLogistico.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.Grd_msto_OperadorLogistico.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.Grd_msto_OperadorLogistico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_msto_OperadorLogistico.Location = new System.Drawing.Point(22, 28);
            this.Grd_msto_OperadorLogistico.Name = "Grd_msto_OperadorLogistico";
            this.Grd_msto_OperadorLogistico.Size = new System.Drawing.Size(687, 331);
            this.Grd_msto_OperadorLogistico.TabIndex = 56;
            this.Grd_msto_OperadorLogistico.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.Grd_msto_OperadorLogistico_InitializeLayout);
            // 
            // CMS_Dependencia
            // 
            this.CMS_Dependencia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Modificar});
            this.CMS_Dependencia.Name = "CMS_Dependencia";
            this.CMS_Dependencia.Size = new System.Drawing.Size(126, 26);
            // 
            // TSMI_Modificar
            // 
            this.TSMI_Modificar.Name = "TSMI_Modificar";
            this.TSMI_Modificar.Size = new System.Drawing.Size(125, 22);
            this.TSMI_Modificar.Text = "Modificar";
            this.TSMI_Modificar.Click += new System.EventHandler(this.TSMI_Modificar_Click);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_ExportarExcel});
            this.ToolStrip1.Location = new System.Drawing.Point(22, 3);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(687, 25);
            this.ToolStrip1.TabIndex = 55;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // TSB_ExportarExcel
            // 
            this.TSB_ExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("TSB_ExportarExcel.Image")));
            this.TSB_ExportarExcel.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TSB_ExportarExcel.Name = "TSB_ExportarExcel";
            this.TSB_ExportarExcel.Size = new System.Drawing.Size(70, 22);
            this.TSB_ExportarExcel.Text = "Exportar";
            this.TSB_ExportarExcel.Click += new System.EventHandler(this.TSB_ExportarExcel_Click);
            // 
            // SaveDocumento
            // 
            this.SaveDocumento.DefaultExt = "XLS";
            this.SaveDocumento.Filter = "Excel (*.xls)|*.xls";
            this.SaveDocumento.RestoreDirectory = true;
            // 
            // Frm_AsignaDependenciaOperadorLogistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 363);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "Frm_AsignaDependenciaOperadorLogistico";
            this.Text = "Asignar Dependencia al Operador Logistico";
            this.Load += new System.EventHandler(this.Frm_AsignaDependenciaOperadorLogistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).EndInit();
            this.UltraGroupBox2.ResumeLayout(false);
            this.UltraGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_msto_OperadorLogistico)).EndInit();
            this.CMS_Dependencia.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox2;
        internal Infragistics.Win.UltraWinGrid.UltraGrid Grd_msto_OperadorLogistico;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton TSB_ExportarExcel;
        internal System.Windows.Forms.SaveFileDialog SaveDocumento;
        internal System.Windows.Forms.ContextMenuStrip CMS_Dependencia;
        internal System.Windows.Forms.ToolStripMenuItem TSMI_Modificar;
        internal Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter UltraGridExcelExporter1;
    }
}