namespace WINlogistica
{
    partial class Frm_TableroDashboard
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
            this.dashboardDesigner1 = new DevExpress.DashboardWin.DashboardDesigner();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDesigner1)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardDesigner1
            // 
            this.dashboardDesigner1.DataSourceWizard.AvailableDataSourceTypes = ((DevExpress.DashboardWin.DashboardDesignerDataSourceType)((((((DevExpress.DashboardWin.DashboardDesignerDataSourceType.Sql | DevExpress.DashboardWin.DashboardDesignerDataSourceType.Olap) 
            | DevExpress.DashboardWin.DashboardDesignerDataSourceType.Object) 
            | DevExpress.DashboardWin.DashboardDesignerDataSourceType.EF) 
            | DevExpress.DashboardWin.DashboardDesignerDataSourceType.Excel) 
            | DevExpress.DashboardWin.DashboardDesignerDataSourceType.Extract)));
            this.dashboardDesigner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardDesigner1.Location = new System.Drawing.Point(0, 0);
            this.dashboardDesigner1.Name = "dashboardDesigner1";
            this.dashboardDesigner1.Size = new System.Drawing.Size(950, 518);
            this.dashboardDesigner1.TabIndex = 0;
            this.dashboardDesigner1.DashboardSaving += new DevExpress.DashboardWin.DashboardSavingEventHandler(this.dashboardDesigner1_DashboardSaving);
            this.dashboardDesigner1.DashboardClosing += new DevExpress.DashboardWin.DashboardClosingEventHandler(this.dashboardDesigner1_DashboardClosing);
            // 
            // Frm_TableroDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 518);
            this.Controls.Add(this.dashboardDesigner1);
            this.Name = "Frm_TableroDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Designer";
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDesigner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DashboardWin.DashboardDesigner dashboardDesigner1;
    }
}

