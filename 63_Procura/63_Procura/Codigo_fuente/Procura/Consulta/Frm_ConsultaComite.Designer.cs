namespace WINlogistica
{
    partial class Frm_ConsultaComite
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
            this.UltraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.grd_mvto_DocumntoComite = new Infragistics.Win.UltraWinGrid.UltraGrid();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox1)).BeginInit();
            this.UltraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_mvto_DocumntoComite)).BeginInit();
            this.SuspendLayout();
            // 
            // UltraGroupBox1
            // 
            this.UltraGroupBox1.Controls.Add(this.grd_mvto_DocumntoComite);
            this.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.UltraGroupBox1.Name = "UltraGroupBox1";
            this.UltraGroupBox1.Size = new System.Drawing.Size(608, 302);
            this.UltraGroupBox1.TabIndex = 1;
            this.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
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
            this.grd_mvto_DocumntoComite.Location = new System.Drawing.Point(3, 0);
            this.grd_mvto_DocumntoComite.Name = "grd_mvto_DocumntoComite";
            this.grd_mvto_DocumntoComite.Size = new System.Drawing.Size(602, 299);
            this.grd_mvto_DocumntoComite.TabIndex = 52;
            this.grd_mvto_DocumntoComite.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.grd_mvto_DocumntoComite_InitializeLayout);
            // 
            // Frm_ConsultaComite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 302);
            this.Controls.Add(this.UltraGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ConsultaComite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comite";
            this.Load += new System.EventHandler(this.Frm_ConsultaComite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox1)).EndInit();
            this.UltraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_mvto_DocumntoComite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox1;
        internal Infragistics.Win.UltraWinGrid.UltraGrid grd_mvto_DocumntoComite;
    }
}