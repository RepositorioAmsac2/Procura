namespace WINlogistica
{
    partial class Frm_TipoPlantillaPaso
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
            Infragistics.Win.Appearance Appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance27 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TipoPlantillaPaso));
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grp_Catalogo = new Infragistics.Win.Misc.UltraGroupBox();
            this.grd_mvto_DocumntoComite = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Listar = new System.Windows.Forms.ToolStripButton();
            this.UltraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.txt_DesTipoPlantilla = new gnUserControl.gnTextBox_Simple();
            this.txt_CodTipoPlantilla = new gnUserControl.gnTextBox_Simple();
            this.UltraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.UltraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_Grabar = new System.Windows.Forms.ToolStripButton();
            this.btn_DesHacer = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.SaveDocumento = new System.Windows.Forms.SaveFileDialog();
            this.UltraGridExcelExporter1 = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_Catalogo)).BeginInit();
            this.grp_Catalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_mvto_DocumntoComite)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).BeginInit();
            this.UltraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DesTipoPlantilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CodTipoPlantilla)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.ultraGroupBox1.Controls.Add(this.splitContainer1);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(926, 232);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(1, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grp_Catalogo);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.UltraGroupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.ToolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(924, 231);
            this.splitContainer1.SplitterDistance = 428;
            this.splitContainer1.TabIndex = 0;
            // 
            // grp_Catalogo
            // 
            this.grp_Catalogo.Controls.Add(this.grd_mvto_DocumntoComite);
            this.grp_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Catalogo.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.grp_Catalogo.Location = new System.Drawing.Point(0, 25);
            this.grp_Catalogo.Name = "grp_Catalogo";
            this.grp_Catalogo.Size = new System.Drawing.Size(424, 202);
            this.grp_Catalogo.TabIndex = 8;
            this.grp_Catalogo.Text = "2. Lista de Tipo de plantilla";
            this.grp_Catalogo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // grd_mvto_DocumntoComite
            // 
            Appearance1.BackColor = System.Drawing.Color.Transparent;
            this.grd_mvto_DocumntoComite.DisplayLayout.Appearance = Appearance1;
            this.grd_mvto_DocumntoComite.DisplayLayout.InterBandSpacing = 10;
            Appearance2.BackColor = System.Drawing.Color.Transparent;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.CardAreaAppearance = Appearance2;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None;
            Appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            Appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance3.ForeColor = System.Drawing.Color.Black;
            Appearance3.TextHAlignAsString = "Left";
            Appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.HeaderAppearance = Appearance3;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            Appearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.RowAppearance = Appearance4;
            Appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            Appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.RowSelectorAppearance = Appearance5;
            Appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            Appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance6.ForeColor = System.Drawing.Color.Black;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.SelectedRowAppearance = Appearance6;
            this.grd_mvto_DocumntoComite.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.grd_mvto_DocumntoComite.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.grd_mvto_DocumntoComite.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.grd_mvto_DocumntoComite.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.grd_mvto_DocumntoComite.DisplayLayout.UseFixedHeaders = true;
            this.grd_mvto_DocumntoComite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_mvto_DocumntoComite.Location = new System.Drawing.Point(22, 3);
            this.grd_mvto_DocumntoComite.Name = "grd_mvto_DocumntoComite";
            this.grd_mvto_DocumntoComite.Size = new System.Drawing.Size(399, 196);
            this.grd_mvto_DocumntoComite.TabIndex = 89;
            this.grd_mvto_DocumntoComite.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.grd_mvto_DocumntoComite_InitializeLayout);
            this.grd_mvto_DocumntoComite.AfterSelectChange += new Infragistics.Win.UltraWinGrid.AfterSelectChangeEventHandler(this.grd_mvto_DocumntoComite_AfterSelectChange);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btn_Listar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(424, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Listar
            // 
            this.btn_Listar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(39, 22);
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // UltraGroupBox3
            // 
            this.UltraGroupBox3.Controls.Add(this.txt_DesTipoPlantilla);
            this.UltraGroupBox3.Controls.Add(this.txt_CodTipoPlantilla);
            this.UltraGroupBox3.Controls.Add(this.UltraLabel6);
            this.UltraGroupBox3.Controls.Add(this.UltraLabel5);
            this.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.UltraGroupBox3.Location = new System.Drawing.Point(0, 25);
            this.UltraGroupBox3.Name = "UltraGroupBox3";
            this.UltraGroupBox3.Size = new System.Drawing.Size(488, 202);
            this.UltraGroupBox3.TabIndex = 0;
            this.UltraGroupBox3.Text = "1. Datos del tipo de plantilla";
            this.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // txt_DesTipoPlantilla
            // 
            this.txt_DesTipoPlantilla.enabledFocusColor = System.Drawing.Color.Lavender;
            this.txt_DesTipoPlantilla.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.txt_DesTipoPlantilla.exigirCampoLleno = false;
            this.txt_DesTipoPlantilla.leaveFocusColor = System.Drawing.Color.White;
            this.txt_DesTipoPlantilla.Location = new System.Drawing.Point(47, 91);
            this.txt_DesTipoPlantilla.LongitudTexto = 200;
            this.txt_DesTipoPlantilla.Multiline = true;
            this.txt_DesTipoPlantilla.Name = "txt_DesTipoPlantilla";
            this.txt_DesTipoPlantilla.resaltarCampoOmitido = false;
            this.txt_DesTipoPlantilla.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.txt_DesTipoPlantilla.Size = new System.Drawing.Size(344, 22);
            this.txt_DesTipoPlantilla.TabIndex = 1;
            this.txt_DesTipoPlantilla.tipoDato = gnUserControl.gnTextBox_Simple.Tipo.Ninguno;
            this.txt_DesTipoPlantilla.tipoDatoC = gnUserControl.gnTextBox_Simple.TipoC.Ninguno;
            // 
            // txt_CodTipoPlantilla
            // 
            this.txt_CodTipoPlantilla.enabledFocusColor = System.Drawing.Color.Lavender;
            this.txt_CodTipoPlantilla.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.txt_CodTipoPlantilla.exigirCampoLleno = false;
            this.txt_CodTipoPlantilla.leaveFocusColor = System.Drawing.Color.White;
            this.txt_CodTipoPlantilla.Location = new System.Drawing.Point(47, 44);
            this.txt_CodTipoPlantilla.LongitudTexto = 200;
            this.txt_CodTipoPlantilla.Name = "txt_CodTipoPlantilla";
            this.txt_CodTipoPlantilla.resaltarCampoOmitido = false;
            this.txt_CodTipoPlantilla.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.txt_CodTipoPlantilla.Size = new System.Drawing.Size(75, 21);
            this.txt_CodTipoPlantilla.TabIndex = 0;
            this.txt_CodTipoPlantilla.tipoDato = gnUserControl.gnTextBox_Simple.Tipo.Ninguno;
            this.txt_CodTipoPlantilla.tipoDatoC = gnUserControl.gnTextBox_Simple.TipoC.Ninguno;
            // 
            // UltraLabel6
            // 
            Appearance8.BackColor = System.Drawing.Color.Transparent;
            this.UltraLabel6.Appearance = Appearance8;
            this.UltraLabel6.AutoSize = true;
            this.UltraLabel6.Location = new System.Drawing.Point(47, 24);
            this.UltraLabel6.Name = "UltraLabel6";
            this.UltraLabel6.Size = new System.Drawing.Size(43, 14);
            this.UltraLabel6.TabIndex = 0;
            this.UltraLabel6.Text = "Código:";
            // 
            // UltraLabel5
            // 
            Appearance27.BackColor = System.Drawing.Color.Transparent;
            this.UltraLabel5.Appearance = Appearance27;
            this.UltraLabel5.AutoSize = true;
            this.UltraLabel5.Location = new System.Drawing.Point(47, 71);
            this.UltraLabel5.Name = "UltraLabel5";
            this.UltraLabel5.Size = new System.Drawing.Size(67, 14);
            this.UltraLabel5.TabIndex = 78;
            this.UltraLabel5.Text = "Descripción:";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Nuevo,
            this.btn_Grabar,
            this.btn_DesHacer,
            this.ToolStripSeparator1,
            this.btn_Eliminar});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(488, 25);
            this.ToolStrip1.TabIndex = 5;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.Image")));
            this.btn_Nuevo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(62, 22);
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Grabar.Image")));
            this.btn_Grabar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(62, 22);
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // btn_DesHacer
            // 
            this.btn_DesHacer.Image = ((System.Drawing.Image)(resources.GetObject("btn_DesHacer.Image")));
            this.btn_DesHacer.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btn_DesHacer.Name = "btn_DesHacer";
            this.btn_DesHacer.Size = new System.Drawing.Size(75, 22);
            this.btn_DesHacer.Text = "Deshacer";
            this.btn_DesHacer.Click += new System.EventHandler(this.btn_DesHacer_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(70, 22);
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // SaveDocumento
            // 
            this.SaveDocumento.DefaultExt = "XLS";
            this.SaveDocumento.Filter = "Excel (*.xls)|*.xls";
            this.SaveDocumento.RestoreDirectory = true;
            // 
            // Frm_TipoPlantillaPaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 232);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "Frm_TipoPlantillaPaso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Tipo de Plantilla del paso";
            this.Load += new System.EventHandler(this.Frm_TipoPlantillaPaso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grp_Catalogo)).EndInit();
            this.grp_Catalogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_mvto_DocumntoComite)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).EndInit();
            this.UltraGroupBox3.ResumeLayout(false);
            this.UltraGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DesTipoPlantilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CodTipoPlantilla)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal Infragistics.Win.Misc.UltraGroupBox grp_Catalogo;
        internal System.Windows.Forms.ToolStrip toolStrip2;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton btn_Listar;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox3;
        internal gnUserControl.gnTextBox_Simple txt_DesTipoPlantilla;
        internal gnUserControl.gnTextBox_Simple txt_CodTipoPlantilla;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel6;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel5;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btn_Nuevo;
        internal System.Windows.Forms.ToolStripButton btn_Grabar;
        internal System.Windows.Forms.ToolStripButton btn_DesHacer;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton btn_Eliminar;
        internal System.Windows.Forms.SaveFileDialog SaveDocumento;
        internal Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter UltraGridExcelExporter1;
        internal Infragistics.Win.UltraWinGrid.UltraGrid grd_mvto_DocumntoComite;
    }
}