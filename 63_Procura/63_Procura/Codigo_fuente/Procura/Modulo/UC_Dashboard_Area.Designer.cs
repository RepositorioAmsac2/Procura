
namespace WINlogistica.Modulo
{
    partial class UC_Dashboard_Area
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.dashboardViewer = new DevExpress.DashboardWin.DashboardViewer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // dashboardViewer
            // 
            this.dashboardViewer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.dashboardViewer.Appearance.Options.UseBackColor = true;
            this.dashboardViewer.AsyncMode = true;
            this.dashboardViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardViewer.Location = new System.Drawing.Point(0, 0);
            this.dashboardViewer.Name = "dashboardViewer";
            this.dashboardViewer.Size = new System.Drawing.Size(731, 408);
            this.dashboardViewer.TabIndex = 3;
            // 
            // UC_Dashboard_Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dashboardViewer);
            this.Name = "UC_Dashboard_Area";
            this.Size = new System.Drawing.Size(731, 408);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.DashboardWin.DashboardViewer dashboardViewer;
    }
}
