namespace WINlogistica
{
    partial class Frm_EnlazaRequerimiento_CreaProceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EnlazaRequerimiento_CreaProceso));
            this.UltraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Grd_Buscados = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Btn_PantallaTotal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Adjunto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_DetalleRequerimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Exportar = new System.Windows.Forms.ToolStripButton();
            this.TimerLista = new System.Windows.Forms.Timer(this.components);
            this.SaveDocumento = new System.Windows.Forms.SaveFileDialog();
            this.UltraGridExcelExporter1 = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).BeginInit();
            this.UltraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Buscados)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UltraGroupBox2
            // 
            this.UltraGroupBox2.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.UltraGroupBox2.Controls.Add(this.Grd_Buscados);
            this.UltraGroupBox2.Controls.Add(this.ToolStrip1);
            this.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.UltraGroupBox2.Name = "UltraGroupBox2";
            this.UltraGroupBox2.Size = new System.Drawing.Size(1138, 352);
            this.UltraGroupBox2.TabIndex = 8;
            this.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
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
            this.Grd_Buscados.Location = new System.Drawing.Point(1, 25);
            this.Grd_Buscados.Name = "Grd_Buscados";
            this.Grd_Buscados.Size = new System.Drawing.Size(1136, 326);
            this.Grd_Buscados.TabIndex = 55;
            this.Grd_Buscados.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.Grd_Buscados_InitializeLayout);
            this.Grd_Buscados.AfterSelectChange += new Infragistics.Win.UltraWinGrid.AfterSelectChangeEventHandler(this.Grd_Buscados_AfterSelectChange);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_PantallaTotal,
            this.toolStripMenuItem1,
            this.Btn_Adjunto,
            this.toolStripMenuItem2,
            this.Btn_DetalleRequerimiento});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(272, 104);
            // 
            // Btn_PantallaTotal
            // 
            this.Btn_PantallaTotal.Name = "Btn_PantallaTotal";
            this.Btn_PantallaTotal.Size = new System.Drawing.Size(271, 22);
            this.Btn_PantallaTotal.Text = "Ver Requerimiento en toda la pantalla";
            this.Btn_PantallaTotal.Click += new System.EventHandler(this.Btn_PantallaTotal_Click);
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
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(268, 6);
            // 
            // Btn_DetalleRequerimiento
            // 
            this.Btn_DetalleRequerimiento.Name = "Btn_DetalleRequerimiento";
            this.Btn_DetalleRequerimiento.Size = new System.Drawing.Size(271, 22);
            this.Btn_DetalleRequerimiento.Text = "Ver Detalle de requerimiento";
            this.Btn_DetalleRequerimiento.Click += new System.EventHandler(this.Btn_DetalleRequerimiento_Click);
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
            // Frm_EnlazaRequerimiento_CreaProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 352);
            this.Controls.Add(this.UltraGroupBox2);
            this.Name = "Frm_EnlazaRequerimiento_CreaProceso";
            this.Text = "Asignar número de proceso al requerimiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_FirmaRequerimiento_FormClosing);
            this.Load += new System.EventHandler(this.Frm_FirmaRequerimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).EndInit();
            this.UltraGroupBox2.ResumeLayout(false);
            this.UltraGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Buscados)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        internal Infragistics.Win.UltraWinGrid.UltraGrid Grd_Buscados;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Btn_Adjunto;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Btn_DetalleRequerimiento;
    }
}