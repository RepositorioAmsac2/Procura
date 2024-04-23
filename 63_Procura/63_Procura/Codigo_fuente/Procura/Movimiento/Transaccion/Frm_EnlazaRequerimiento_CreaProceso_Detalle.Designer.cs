namespace WINlogistica
{
    partial class Frm_EnlazaRequerimiento_CreaProceso_Detalle
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
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Grd_Formulacion = new DevExpress.XtraGrid.GridControl();
            this.Grd_Ayuda = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Btn_MostrarSuma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Formulacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Ayuda)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Location = new System.Drawing.Point(888, 471);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(114, 23);
            this.Btn_Aceptar.TabIndex = 54;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Location = new System.Drawing.Point(768, 472);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(114, 23);
            this.Btn_cancelar.TabIndex = 55;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Grd_Formulacion
            // 
            this.Grd_Formulacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grd_Formulacion.Location = new System.Drawing.Point(0, 0);
            this.Grd_Formulacion.MainView = this.Grd_Ayuda;
            this.Grd_Formulacion.Name = "Grd_Formulacion";
            this.Grd_Formulacion.Size = new System.Drawing.Size(1219, 465);
            this.Grd_Formulacion.TabIndex = 119;
            this.Grd_Formulacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Grd_Ayuda});
            // 
            // Grd_Ayuda
            // 
            this.Grd_Ayuda.GridControl = this.Grd_Formulacion;
            this.Grd_Ayuda.Name = "Grd_Ayuda";
            // 
            // Btn_MostrarSuma
            // 
            this.Btn_MostrarSuma.Location = new System.Drawing.Point(12, 472);
            this.Btn_MostrarSuma.Name = "Btn_MostrarSuma";
            this.Btn_MostrarSuma.Size = new System.Drawing.Size(114, 23);
            this.Btn_MostrarSuma.TabIndex = 120;
            this.Btn_MostrarSuma.Text = "Ver Sumatoria";
            this.Btn_MostrarSuma.UseVisualStyleBackColor = true;
            this.Btn_MostrarSuma.Click += new System.EventHandler(this.Btn_MostrarSuma_Click);
            // 
            // Frm_AyudaHojaTrabajo_Formulacion_Pac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 507);
            this.Controls.Add(this.Btn_MostrarSuma);
            this.Controls.Add(this.Grd_Formulacion);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AyudaHojaTrabajo_Formulacion_Pac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AyudaGeneral";
            this.Load += new System.EventHandler(this.Frm_AyudaHojaTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Formulacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Ayuda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_cancelar;
        private DevExpress.XtraGrid.GridControl Grd_Formulacion;
        private DevExpress.XtraGrid.Views.Grid.GridView Grd_Ayuda;
        private System.Windows.Forms.Button Btn_MostrarSuma;
    }
}