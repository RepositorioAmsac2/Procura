namespace WINlogistica
{
    partial class Frm_ConsultaDuracionPAC
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
            Infragistics.Win.Appearance Appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance7 = new Infragistics.Win.Appearance();
            this.grp_Catalogo = new Infragistics.Win.Misc.UltraGroupBox();
            this.grd_mvto_DocumntoComite = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Exportar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grp_Catalogo)).BeginInit();
            this.grp_Catalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_mvto_DocumntoComite)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Catalogo
            // 
            this.grp_Catalogo.Controls.Add(this.grd_mvto_DocumntoComite);
            this.grp_Catalogo.Controls.Add(this.ToolStrip1);
            this.grp_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Catalogo.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.grp_Catalogo.Location = new System.Drawing.Point(0, 0);
            this.grp_Catalogo.Name = "grp_Catalogo";
            this.grp_Catalogo.Size = new System.Drawing.Size(702, 450);
            this.grp_Catalogo.TabIndex = 2;
            this.grp_Catalogo.Text = "2. Lista de Pasos del PAC";
            this.grp_Catalogo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // grd_mvto_DocumntoComite
            // 
            Appearance10.BackColor = System.Drawing.Color.Transparent;
            Appearance10.BackColor2 = System.Drawing.Color.Transparent;
            Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal;
            this.grd_mvto_DocumntoComite.DisplayLayout.Appearance = Appearance10;
            this.grd_mvto_DocumntoComite.DisplayLayout.InterBandSpacing = 10;
            Appearance2.BackColor = System.Drawing.Color.PowderBlue;
            Appearance2.BackColor2 = System.Drawing.Color.PowderBlue;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.ActiveCellAppearance = Appearance2;
            Appearance3.BackColor = System.Drawing.Color.Transparent;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.CardAreaAppearance = Appearance3;
            Appearance4.BackColor = System.Drawing.Color.Transparent;
            Appearance4.BackColor2 = System.Drawing.Color.Transparent;
            Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance4.ForeColor = System.Drawing.Color.Black;
            Appearance4.TextHAlignAsString = "Center";
            Appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.HeaderAppearance = Appearance4;
            Appearance5.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.RowAppearance = Appearance5;
            Appearance6.BackColor = System.Drawing.Color.PapayaWhip;
            Appearance6.BackColor2 = System.Drawing.Color.PapayaWhip;
            Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.RowSelectorAppearance = Appearance6;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.RowSelectorWidth = 12;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.RowSpacingBefore = 2;
            Appearance7.BackColor = System.Drawing.Color.PapayaWhip;
            Appearance7.BackColor2 = System.Drawing.Color.PapayaWhip;
            Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance7.ForeColor = System.Drawing.Color.Black;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.SelectedRowAppearance = Appearance7;
            this.grd_mvto_DocumntoComite.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.grd_mvto_DocumntoComite.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.grd_mvto_DocumntoComite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_mvto_DocumntoComite.Location = new System.Drawing.Point(22, 28);
            this.grd_mvto_DocumntoComite.Name = "grd_mvto_DocumntoComite";
            this.grd_mvto_DocumntoComite.Size = new System.Drawing.Size(677, 419);
            this.grd_mvto_DocumntoComite.TabIndex = 54;
            this.grd_mvto_DocumntoComite.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.grd_mvto_DocumntoComite_InitializeLayout);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Exportar});
            this.ToolStrip1.Location = new System.Drawing.Point(22, 3);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(677, 25);
            this.ToolStrip1.TabIndex = 45;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // tsb_Exportar
            // 
            this.tsb_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Exportar.Name = "tsb_Exportar";
            this.tsb_Exportar.Size = new System.Drawing.Size(54, 22);
            this.tsb_Exportar.Text = "Exportar";
            // 
            // Frm_ConsultaDuracionPAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.grp_Catalogo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ConsultaDuracionPAC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duración de pasos";
            this.Load += new System.EventHandler(this.Frm_ConsultaDuracionPAC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grp_Catalogo)).EndInit();
            this.grp_Catalogo.ResumeLayout(false);
            this.grp_Catalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_mvto_DocumntoComite)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Infragistics.Win.Misc.UltraGroupBox grp_Catalogo;
        internal Infragistics.Win.UltraWinGrid.UltraGrid grd_mvto_DocumntoComite;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton tsb_Exportar;
    }
}