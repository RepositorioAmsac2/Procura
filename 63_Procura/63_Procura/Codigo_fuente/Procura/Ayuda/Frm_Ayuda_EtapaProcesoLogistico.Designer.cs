namespace WINlogistica
{
    partial class Frm_Ayuda_EtapaProcesoLogistico
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
            this.grd_buscados = new DevExpress.XtraGrid.GridControl();
            this.Grd_Ayuda = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd_buscados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Ayuda)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_buscados
            // 
            this.grd_buscados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_buscados.Location = new System.Drawing.Point(0, 0);
            this.grd_buscados.MainView = this.Grd_Ayuda;
            this.grd_buscados.Name = "grd_buscados";
            this.grd_buscados.Size = new System.Drawing.Size(624, 507);
            this.grd_buscados.TabIndex = 53;
            this.grd_buscados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Grd_Ayuda});
            this.grd_buscados.DoubleClick += new System.EventHandler(this.grd_buscados_DoubleClick);
            // 
            // Grd_Ayuda
            // 
            this.Grd_Ayuda.GridControl = this.grd_buscados;
            this.Grd_Ayuda.Name = "Grd_Ayuda";
            this.Grd_Ayuda.OptionsView.ShowGroupPanel = false;
            this.Grd_Ayuda.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.Grd_Ayuda_ShowingEditor);
            // 
            // Frm_AyudaHojaTrabajo_CentroCosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 507);
            this.Controls.Add(this.grd_buscados);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AyudaHojaTrabajo_CentroCosto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AyudaGeneral";
            this.Load += new System.EventHandler(this.Frm_AyudaHojaTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_buscados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Ayuda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl grd_buscados;
        private DevExpress.XtraGrid.Views.Grid.GridView Grd_Ayuda;
    }
}