namespace WINlogistica
{
    partial class Frm_Formulacion_PAC
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
            this.Grd_General = new DevExpress.XtraGrid.GridControl();
            this.Grd_Ayuda = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Btn_LineaElegida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_General)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Ayuda)).BeginInit();
            this.SuspendLayout();
            // 
            // Grd_General
            // 
            this.Grd_General.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grd_General.Location = new System.Drawing.Point(0, 0);
            this.Grd_General.MainView = this.Grd_Ayuda;
            this.Grd_General.Name = "Grd_General";
            this.Grd_General.Size = new System.Drawing.Size(1137, 453);
            this.Grd_General.TabIndex = 0;
            this.Grd_General.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Grd_Ayuda});
            this.Grd_General.Load += new System.EventHandler(this.Grd_Ayuda_Load);
            // 
            // Grd_Ayuda
            // 
            this.Grd_Ayuda.GridControl = this.Grd_General;
            this.Grd_Ayuda.Name = "Grd_Ayuda";
            this.Grd_Ayuda.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.Grd_Ayuda_ShowingEditor);
            // 
            // Btn_LineaElegida
            // 
            this.Btn_LineaElegida.Location = new System.Drawing.Point(925, 459);
            this.Btn_LineaElegida.Name = "Btn_LineaElegida";
            this.Btn_LineaElegida.Size = new System.Drawing.Size(200, 23);
            this.Btn_LineaElegida.TabIndex = 1;
            this.Btn_LineaElegida.Text = "Trasladar las lineas elegidas";
            this.Btn_LineaElegida.UseVisualStyleBackColor = true;
            this.Btn_LineaElegida.Click += new System.EventHandler(this.Btn_LineaElegida_Click);
            // 
            // Frm_Formulacion_PAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 497);
            this.Controls.Add(this.Btn_LineaElegida);
            this.Controls.Add(this.Grd_General);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Formulacion_PAC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elegir linea de Formulación";
            ((System.ComponentModel.ISupportInitialize)(this.Grd_General)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Ayuda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grd_General;
        private DevExpress.XtraGrid.Views.Grid.GridView Grd_Ayuda;
        private System.Windows.Forms.Button Btn_LineaElegida;
    }
}