namespace WINlogistica
{
    partial class Frm_FirmaConformidad
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
            Infragistics.Win.Appearance Appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinScrollBar.ScrollBarLook scrollBarLook1 = new Infragistics.Win.UltraWinScrollBar.ScrollBarLook();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FirmaConformidad));
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.UltraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Grd_Buscados = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.Crv_Requerimiento = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ultraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Btn_Descartar = new Infragistics.Win.Misc.UltraButton();
            this.Btn_FirmaDigital = new Infragistics.Win.Misc.UltraButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).BeginInit();
            this.UltraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Buscados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).BeginInit();
            this.ultraGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // UltraGroupBox2
            // 
            this.UltraGroupBox2.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.UltraGroupBox2.Controls.Add(this.splitContainer1);
            this.UltraGroupBox2.Controls.Add(this.toolStrip1);
            this.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.UltraGroupBox2.Name = "UltraGroupBox2";
            this.UltraGroupBox2.Size = new System.Drawing.Size(1237, 524);
            this.UltraGroupBox2.TabIndex = 9;
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
            this.splitContainer1.Panel2.Controls.Add(this.ultraGroupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1235, 498);
            this.splitContainer1.SplitterDistance = 462;
            this.splitContainer1.TabIndex = 33;
            // 
            // Grd_Buscados
            // 
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
            this.Grd_Buscados.Size = new System.Drawing.Size(458, 494);
            this.Grd_Buscados.TabIndex = 55;
            // 
            // Crv_Requerimiento
            // 
            this.Crv_Requerimiento.ActiveViewIndex = -1;
            this.Crv_Requerimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crv_Requerimiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crv_Requerimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crv_Requerimiento.Location = new System.Drawing.Point(0, 0);
            this.Crv_Requerimiento.Name = "Crv_Requerimiento";
            this.Crv_Requerimiento.ShowGroupTreeButton = false;
            this.Crv_Requerimiento.Size = new System.Drawing.Size(765, 444);
            this.Crv_Requerimiento.TabIndex = 17;
            this.Crv_Requerimiento.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.Crv_Requerimiento.Visible = false;
            // 
            // ultraGroupBox3
            // 
            this.ultraGroupBox3.Controls.Add(this.Btn_Descartar);
            this.ultraGroupBox3.Controls.Add(this.Btn_FirmaDigital);
            this.ultraGroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraGroupBox3.Location = new System.Drawing.Point(0, 444);
            this.ultraGroupBox3.Name = "ultraGroupBox3";
            this.ultraGroupBox3.Size = new System.Drawing.Size(765, 50);
            this.ultraGroupBox3.TabIndex = 2;
            this.ultraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Btn_Descartar
            // 
            this.Btn_Descartar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            appearance1.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance1.Image = ((object)(resources.GetObject("appearance1.Image")));
            appearance1.ImageHAlign = Infragistics.Win.HAlign.Left;
            this.Btn_Descartar.Appearance = appearance1;
            this.Btn_Descartar.Location = new System.Drawing.Point(6, 12);
            this.Btn_Descartar.Name = "Btn_Descartar";
            this.Btn_Descartar.Size = new System.Drawing.Size(119, 27);
            this.Btn_Descartar.TabIndex = 8;
            this.Btn_Descartar.Text = "Descartar";
            this.Btn_Descartar.Visible = false;
            // 
            // Btn_FirmaDigital
            // 
            this.Btn_FirmaDigital.Anchor = System.Windows.Forms.AnchorStyles.Right;
            appearance2.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance2.Image = ((object)(resources.GetObject("appearance2.Image")));
            appearance2.ImageHAlign = Infragistics.Win.HAlign.Right;
            this.Btn_FirmaDigital.Appearance = appearance2;
            this.Btn_FirmaDigital.Location = new System.Drawing.Point(637, 12);
            this.Btn_FirmaDigital.Name = "Btn_FirmaDigital";
            this.Btn_FirmaDigital.Size = new System.Drawing.Size(119, 27);
            this.Btn_FirmaDigital.TabIndex = 7;
            this.Btn_FirmaDigital.Text = "Autorizar";
            this.Btn_FirmaDigital.Visible = false;
            this.Btn_FirmaDigital.Click += new System.EventHandler(this.Btn_FirmaDigital_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Location = new System.Drawing.Point(1, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1235, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Frm_FirmaConformidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 524);
            this.Controls.Add(this.UltraGroupBox2);
            this.Name = "Frm_FirmaConformidad";
            this.Text = "Lista Conformidades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_FirmaConformidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox2)).EndInit();
            this.UltraGroupBox2.ResumeLayout(false);
            this.UltraGroupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Buscados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox3)).EndInit();
            this.ultraGroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal Infragistics.Win.UltraWinGrid.UltraGrid Grd_Buscados;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer Crv_Requerimiento;
        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox3;
        internal Infragistics.Win.Misc.UltraButton Btn_Descartar;
        internal Infragistics.Win.Misc.UltraButton Btn_FirmaDigital;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}