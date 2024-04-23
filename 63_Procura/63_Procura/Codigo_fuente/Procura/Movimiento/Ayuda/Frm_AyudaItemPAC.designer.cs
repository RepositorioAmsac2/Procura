namespace WINlogistica
{
    partial class Frm_AyudaItemPAC
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
            Infragistics.Win.Appearance Appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance14 = new Infragistics.Win.Appearance();
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraGroupBox2 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Chk_MarcarTodos = new System.Windows.Forms.CheckBox();
            this.Grd_buscados = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.Btn_Filtrar = new System.Windows.Forms.Button();
            this.TxtTexto = new System.Windows.Forms.TextBox();
            this.CmdAceptar = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).BeginInit();
            this.ultraGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_buscados)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.ultraGroupBox1.Controls.Add(this.ultraGroupBox2);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(621, 338);
            this.ultraGroupBox1.TabIndex = 0;
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // ultraGroupBox2
            // 
            this.ultraGroupBox2.Controls.Add(this.Chk_MarcarTodos);
            this.ultraGroupBox2.Controls.Add(this.Grd_buscados);
            this.ultraGroupBox2.Controls.Add(this.Btn_Filtrar);
            this.ultraGroupBox2.Controls.Add(this.TxtTexto);
            this.ultraGroupBox2.Controls.Add(this.CmdAceptar);
            this.ultraGroupBox2.Controls.Add(this.Label2);
            this.ultraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox2.Location = new System.Drawing.Point(1, 0);
            this.ultraGroupBox2.Name = "ultraGroupBox2";
            this.ultraGroupBox2.Size = new System.Drawing.Size(619, 337);
            this.ultraGroupBox2.TabIndex = 1;
            this.ultraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Chk_MarcarTodos
            // 
            this.Chk_MarcarTodos.AutoSize = true;
            this.Chk_MarcarTodos.BackColor = System.Drawing.Color.Transparent;
            this.Chk_MarcarTodos.Location = new System.Drawing.Point(7, 306);
            this.Chk_MarcarTodos.Name = "Chk_MarcarTodos";
            this.Chk_MarcarTodos.Size = new System.Drawing.Size(92, 17);
            this.Chk_MarcarTodos.TabIndex = 50;
            this.Chk_MarcarTodos.Text = "Marcar Todos";
            this.Chk_MarcarTodos.UseVisualStyleBackColor = false;
            this.Chk_MarcarTodos.CheckedChanged += new System.EventHandler(this.Chk_MarcarTodos_CheckedChanged);
            // 
            // Grd_buscados
            // 
            Appearance1.BackColor = System.Drawing.Color.Transparent;
            Appearance1.BackColor2 = System.Drawing.Color.Transparent;
            Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal;
            this.Grd_buscados.DisplayLayout.Appearance = Appearance1;
            this.Grd_buscados.DisplayLayout.InterBandSpacing = 10;
            Appearance8.BackColor = System.Drawing.Color.PowderBlue;
            Appearance8.BackColor2 = System.Drawing.Color.PowderBlue;
            this.Grd_buscados.DisplayLayout.Override.ActiveCellAppearance = Appearance8;
            Appearance10.BackColor = System.Drawing.Color.Transparent;
            this.Grd_buscados.DisplayLayout.Override.CardAreaAppearance = Appearance10;
            Appearance11.BackColor = System.Drawing.Color.Transparent;
            Appearance11.BackColor2 = System.Drawing.Color.Transparent;
            Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance11.ForeColor = System.Drawing.Color.Black;
            Appearance11.TextHAlignAsString = "Center";
            Appearance11.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.Grd_buscados.DisplayLayout.Override.HeaderAppearance = Appearance11;
            Appearance12.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Grd_buscados.DisplayLayout.Override.RowAppearance = Appearance12;
            Appearance13.BackColor = System.Drawing.Color.PapayaWhip;
            Appearance13.BackColor2 = System.Drawing.Color.PapayaWhip;
            Appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.Grd_buscados.DisplayLayout.Override.RowSelectorAppearance = Appearance13;
            this.Grd_buscados.DisplayLayout.Override.RowSelectorWidth = 12;
            this.Grd_buscados.DisplayLayout.Override.RowSpacingBefore = 2;
            Appearance14.BackColor = System.Drawing.Color.PapayaWhip;
            Appearance14.BackColor2 = System.Drawing.Color.PapayaWhip;
            Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance14.ForeColor = System.Drawing.Color.Black;
            this.Grd_buscados.DisplayLayout.Override.SelectedRowAppearance = Appearance14;
            this.Grd_buscados.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.Grd_buscados.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.Grd_buscados.Location = new System.Drawing.Point(7, 47);
            this.Grd_buscados.Name = "Grd_buscados";
            this.Grd_buscados.Size = new System.Drawing.Size(603, 249);
            this.Grd_buscados.TabIndex = 49;
            this.Grd_buscados.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.Grd_buscados_InitializeLayout);
            this.Grd_buscados.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.Grd_buscados_CellChange);
            // 
            // Btn_Filtrar
            // 
            this.Btn_Filtrar.Location = new System.Drawing.Point(579, 17);
            this.Btn_Filtrar.Name = "Btn_Filtrar";
            this.Btn_Filtrar.Size = new System.Drawing.Size(32, 23);
            this.Btn_Filtrar.TabIndex = 48;
            this.Btn_Filtrar.Text = "Ir...";
            this.Btn_Filtrar.UseVisualStyleBackColor = true;
            // 
            // TxtTexto
            // 
            this.TxtTexto.Location = new System.Drawing.Point(98, 18);
            this.TxtTexto.Name = "TxtTexto";
            this.TxtTexto.Size = new System.Drawing.Size(472, 20);
            this.TxtTexto.TabIndex = 44;
            // 
            // CmdAceptar
            // 
            this.CmdAceptar.Enabled = false;
            this.CmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdAceptar.Location = new System.Drawing.Point(492, 302);
            this.CmdAceptar.Name = "CmdAceptar";
            this.CmdAceptar.Size = new System.Drawing.Size(120, 23);
            this.CmdAceptar.TabIndex = 45;
            this.CmdAceptar.Text = "&Aceptar";
            this.CmdAceptar.Click += new System.EventHandler(this.CmdAceptar_Click);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(11, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 23);
            this.Label2.TabIndex = 47;
            this.Label2.Text = "Filtrar Datos:";
            // 
            // Frm_AyudaItemPAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 338);
            this.Controls.Add(this.ultraGroupBox1);
            this.Name = "Frm_AyudaItemPAC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayuda";
            this.Load += new System.EventHandler(this.Frm_AyudaItemPAC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox2)).EndInit();
            this.ultraGroupBox2.ResumeLayout(false);
            this.ultraGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_buscados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        internal Infragistics.Win.Misc.UltraGroupBox ultraGroupBox2;
        internal System.Windows.Forms.CheckBox Chk_MarcarTodos;
        internal Infragistics.Win.UltraWinGrid.UltraGrid Grd_buscados;
        internal System.Windows.Forms.Button Btn_Filtrar;
        internal System.Windows.Forms.TextBox TxtTexto;
        internal System.Windows.Forms.Button CmdAceptar;
        internal System.Windows.Forms.Label Label2;
    }
}