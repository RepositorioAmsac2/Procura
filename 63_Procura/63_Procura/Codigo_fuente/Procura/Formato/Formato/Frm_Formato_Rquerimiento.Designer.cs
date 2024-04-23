namespace WINlogistica
{
    partial class Frm_Formato_Rquerimiento
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
            this.Crv_Requerimiento = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Crv_Requerimiento
            // 
            this.Crv_Requerimiento.ActiveViewIndex = -1;
            this.Crv_Requerimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crv_Requerimiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crv_Requerimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crv_Requerimiento.Location = new System.Drawing.Point(0, 0);
            this.Crv_Requerimiento.Name = "Crv_Requerimiento";
            this.Crv_Requerimiento.ShowCopyButton = false;
            this.Crv_Requerimiento.ShowGroupTreeButton = false;
            this.Crv_Requerimiento.ShowParameterPanelButton = false;
            this.Crv_Requerimiento.ShowRefreshButton = false;
            this.Crv_Requerimiento.Size = new System.Drawing.Size(800, 450);
            this.Crv_Requerimiento.TabIndex = 17;
            this.Crv_Requerimiento.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Frm_Formato_Rquerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Crv_Requerimiento);
            this.Name = "Frm_Formato_Rquerimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requerimiento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Formato_Rquerimiento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Crv_Requerimiento;
    }
}