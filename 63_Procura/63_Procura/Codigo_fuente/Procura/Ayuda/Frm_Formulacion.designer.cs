namespace WINlogistica
{
    partial class Frm_Formulacion
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
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Formulacion));
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Grd_Buscados = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Btn_Mostrar = new System.Windows.Forms.Button();
            this.Cbo_AñoProceso = new gnUserControl.gnComboBox();
            this.Txt_CodCentroGestor = new gnUserControl.gnTextBox();
            this.Txt_NomCentroGestor = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.UltraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Buscados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CodCentroGestor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NomCentroGestor)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Enabled = false;
            this.Btn_Aceptar.Location = new System.Drawing.Point(1121, 431);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Aceptar.TabIndex = 112;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(1030, 431);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 114;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
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
            this.Grd_Buscados.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grd_Buscados.Location = new System.Drawing.Point(0, 94);
            this.Grd_Buscados.Name = "Grd_Buscados";
            this.Grd_Buscados.Size = new System.Drawing.Size(1220, 314);
            this.Grd_Buscados.TabIndex = 118;
            this.Grd_Buscados.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.Grd_Buscados_InitializeLayout);
            this.Grd_Buscados.DoubleClickCell += new Infragistics.Win.UltraWinGrid.DoubleClickCellEventHandler(this.Grd_Buscados_DoubleClickCell);
            this.Grd_Buscados.Click += new System.EventHandler(this.Grd_Buscados_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.groupControl2.Controls.Add(this.Btn_Mostrar);
            this.groupControl2.Controls.Add(this.Cbo_AñoProceso);
            this.groupControl2.Controls.Add(this.Txt_CodCentroGestor);
            this.groupControl2.Controls.Add(this.Txt_NomCentroGestor);
            this.groupControl2.Controls.Add(this.ultraLabel1);
            this.groupControl2.Controls.Add(this.UltraLabel2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1220, 94);
            this.groupControl2.TabIndex = 117;
            this.groupControl2.Text = "Filtro de Datos";
            // 
            // Btn_Mostrar
            // 
            this.Btn_Mostrar.Location = new System.Drawing.Point(584, 57);
            this.Btn_Mostrar.Name = "Btn_Mostrar";
            this.Btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Mostrar.TabIndex = 122;
            this.Btn_Mostrar.Text = "Mostrar";
            this.Btn_Mostrar.UseVisualStyleBackColor = true;
            this.Btn_Mostrar.Click += new System.EventHandler(this.Btn_Mostrar_Click);
            // 
            // Cbo_AñoProceso
            // 
            this.Cbo_AñoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_AñoProceso.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_AñoProceso.FormattingEnabled = true;
            this.Cbo_AñoProceso.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_AñoProceso.Location = new System.Drawing.Point(113, 35);
            this.Cbo_AñoProceso.Name = "Cbo_AñoProceso";
            this.Cbo_AñoProceso.nombreDS = null;
            this.Cbo_AñoProceso.nombreSP = "";
            this.Cbo_AñoProceso.parametrosSP = "";
            this.Cbo_AñoProceso.resaltarCampoOmitido = false;
            this.Cbo_AñoProceso.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_AñoProceso.Size = new System.Drawing.Size(129, 21);
            this.Cbo_AñoProceso.TabIndex = 121;
            this.Cbo_AñoProceso.tipoConsumo = gnUserControl.gnComboBox.Tipo.StoredProcedure;
            // 
            // Txt_CodCentroGestor
            // 
            this.Txt_CodCentroGestor.anchoColumnasAyuda = "70, 500";
            this.Txt_CodCentroGestor.DatoAnterior = "";
            this.Txt_CodCentroGestor.EligevariosElementos = false;
            this.Txt_CodCentroGestor.Enabled = false;
            this.Txt_CodCentroGestor.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_CodCentroGestor.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_CodCentroGestor.exigirCampoLleno = false;
            this.Txt_CodCentroGestor.InputMask = null;
            this.Txt_CodCentroGestor.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_CodCentroGestor.Location = new System.Drawing.Point(113, 57);
            this.Txt_CodCentroGestor.LongitudTexto = 200;
            this.Txt_CodCentroGestor.mensajeExisteDatoSP = "";
            this.Txt_CodCentroGestor.mensajeNoExisteDatoSP = "";
            this.Txt_CodCentroGestor.Name = "Txt_CodCentroGestor";
            this.Txt_CodCentroGestor.nombreDS = null;
            this.Txt_CodCentroGestor.nombreExisteDatoSP = "";
            this.Txt_CodCentroGestor.nombreNoExisteDatoSP = "";
            this.Txt_CodCentroGestor.nombreSP = "Formulacion.spp_help_msto_partida";
            this.Txt_CodCentroGestor.parametrosExisteDatoSP = "";
            this.Txt_CodCentroGestor.parametrosNoExisteDatoSP = "";
            this.Txt_CodCentroGestor.parametrosSP = null;
            this.Txt_CodCentroGestor.PosicionCampo = 0;
            this.Txt_CodCentroGestor.PosicionCampoTexto = 1;
            this.Txt_CodCentroGestor.PosicionValue = 0;
            this.Txt_CodCentroGestor.resaltarCampoOmitido = false;
            this.Txt_CodCentroGestor.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_CodCentroGestor.Size = new System.Drawing.Size(129, 22);
            this.Txt_CodCentroGestor.TabIndex = 118;
            this.Txt_CodCentroGestor.tipoAyuda = gnUserControl.gnTextBox.Ayuda.ConAyudaInicial;
            this.Txt_CodCentroGestor.tipoDato = gnUserControl.gnTextBox.Tipo.Numerico;
            this.Txt_CodCentroGestor.tipoDatoC = gnUserControl.gnTextBox.TipoC.Ninguno;
            this.Txt_CodCentroGestor.tipoextraccion = gnUserControl.gnTextBox.TipoExtra.DataSet;
            this.Txt_CodCentroGestor.valorDevueltoVarios = "";
            this.Txt_CodCentroGestor.ValorDigitado = "";
            // 
            // Txt_NomCentroGestor
            // 
            appearance19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Txt_NomCentroGestor.Appearance = appearance19;
            this.Txt_NomCentroGestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Txt_NomCentroGestor.Enabled = false;
            this.Txt_NomCentroGestor.Location = new System.Drawing.Point(250, 57);
            this.Txt_NomCentroGestor.Name = "Txt_NomCentroGestor";
            this.Txt_NomCentroGestor.Size = new System.Drawing.Size(328, 22);
            this.Txt_NomCentroGestor.TabIndex = 120;
            // 
            // ultraLabel1
            // 
            appearance10.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel1.Appearance = appearance10;
            this.ultraLabel1.AutoSize = true;
            this.ultraLabel1.Location = new System.Drawing.Point(20, 60);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(77, 15);
            this.ultraLabel1.TabIndex = 119;
            this.ultraLabel1.Text = "Centro Gestor:";
            // 
            // UltraLabel2
            // 
            appearance16.BackColor = System.Drawing.Color.Transparent;
            this.UltraLabel2.Appearance = appearance16;
            this.UltraLabel2.AutoSize = true;
            this.UltraLabel2.Location = new System.Drawing.Point(19, 35);
            this.UltraLabel2.Name = "UltraLabel2";
            this.UltraLabel2.Size = new System.Drawing.Size(27, 15);
            this.UltraLabel2.TabIndex = 117;
            this.UltraLabel2.Text = "Año:";
            // 
            // Frm_Formulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 491);
            this.ControlBox = false;
            this.Controls.Add(this.Grd_Buscados);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Formulacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Importe Formulado";
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Buscados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CodCentroGestor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NomCentroGestor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
        internal Infragistics.Win.UltraWinGrid.UltraGrid Grd_Buscados;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button Btn_Mostrar;
        private gnUserControl.gnComboBox Cbo_AñoProceso;
        internal gnUserControl.gnTextBox Txt_CodCentroGestor;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor Txt_NomCentroGestor;
        internal Infragistics.Win.Misc.UltraLabel ultraLabel1;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel2;
    }
}