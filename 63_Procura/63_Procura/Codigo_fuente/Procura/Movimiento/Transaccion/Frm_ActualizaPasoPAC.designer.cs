namespace WINlogistica
{
    partial class Frm_ActualizaPasoPAC
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
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance Appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance Appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ActualizaPasoPAC));
            this.ultraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.grp_Catalogo = new Infragistics.Win.Misc.UltraGroupBox();
            this.Grd_mvto_Pac_Detalle_Paso = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tsb_Exportar = new System.Windows.Forms.ToolStripButton();
            this.UltraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.Txt_AñoProceso = new gnUserControl.gnTextBox();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.Txt_CodPAC = new gnUserControl.gnTextBox();
            this.Txt_PrecioEstimado = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.Edt_PAC = new gnUserControl.gnEditBox();
            this.UltraLabel10 = new Infragistics.Win.Misc.UltraLabel();
            this.UltraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SaveDocumento = new System.Windows.Forms.SaveFileDialog();
            this.UltraGridExcelExporter1 = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).BeginInit();
            this.ultraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_Catalogo)).BeginInit();
            this.grp_Catalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_mvto_Pac_Detalle_Paso)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).BeginInit();
            this.UltraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_AñoProceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CodPAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edt_PAC)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGroupBox1
            // 
            this.ultraGroupBox1.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.ultraGroupBox1.Controls.Add(this.grp_Catalogo);
            this.ultraGroupBox1.Controls.Add(this.UltraGroupBox3);
            this.ultraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ultraGroupBox1.Name = "ultraGroupBox1";
            this.ultraGroupBox1.Size = new System.Drawing.Size(1184, 540);
            this.ultraGroupBox1.TabIndex = 1;
            this.ultraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // grp_Catalogo
            // 
            this.grp_Catalogo.Controls.Add(this.Grd_mvto_Pac_Detalle_Paso);
            this.grp_Catalogo.Controls.Add(this.ToolStrip1);
            this.grp_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Catalogo.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.grp_Catalogo.Location = new System.Drawing.Point(1, 94);
            this.grp_Catalogo.Name = "grp_Catalogo";
            this.grp_Catalogo.Size = new System.Drawing.Size(1182, 445);
            this.grp_Catalogo.TabIndex = 3;
            this.grp_Catalogo.Text = "2. Lista de Etapas del Proceso";
            this.grp_Catalogo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Grd_mvto_Pac_Detalle_Paso
            // 
            Appearance10.BackColor = System.Drawing.Color.Transparent;
            Appearance10.BackColor2 = System.Drawing.Color.Transparent;
            Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.BackwardDiagonal;
            this.Grd_mvto_Pac_Detalle_Paso.DisplayLayout.Appearance = Appearance10;
            this.Grd_mvto_Pac_Detalle_Paso.DisplayLayout.InterBandSpacing = 10;
            Appearance2.BackColor = System.Drawing.Color.PowderBlue;
            Appearance2.BackColor2 = System.Drawing.Color.PowderBlue;
            this.Grd_mvto_Pac_Detalle_Paso.DisplayLayout.Override.ActiveCellAppearance = Appearance2;
            Appearance3.BackColor = System.Drawing.Color.Transparent;
            this.Grd_mvto_Pac_Detalle_Paso.DisplayLayout.Override.CardAreaAppearance = Appearance3;
            Appearance4.BackColor = System.Drawing.Color.Transparent;
            Appearance4.BackColor2 = System.Drawing.Color.Transparent;
            Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance4.ForeColor = System.Drawing.Color.Black;
            Appearance4.TextHAlignAsString = "Center";
            Appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.Grd_mvto_Pac_Detalle_Paso.DisplayLayout.Override.HeaderAppearance = Appearance4;
            Appearance5.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Grd_mvto_Pac_Detalle_Paso.DisplayLayout.Override.RowAppearance = Appearance5;
            Appearance6.BackColor = System.Drawing.Color.PapayaWhip;
            Appearance6.BackColor2 = System.Drawing.Color.PapayaWhip;
            Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.Grd_mvto_Pac_Detalle_Paso.DisplayLayout.Override.RowSelectorAppearance = Appearance6;
            this.Grd_mvto_Pac_Detalle_Paso.DisplayLayout.Override.RowSelectorWidth = 12;
            this.Grd_mvto_Pac_Detalle_Paso.DisplayLayout.Override.RowSpacingBefore = 2;
            Appearance7.BackColor = System.Drawing.Color.PapayaWhip;
            Appearance7.BackColor2 = System.Drawing.Color.PapayaWhip;
            Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            Appearance7.ForeColor = System.Drawing.Color.Black;
            this.Grd_mvto_Pac_Detalle_Paso.DisplayLayout.Override.SelectedRowAppearance = Appearance7;
            this.Grd_mvto_Pac_Detalle_Paso.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(131)))));
            this.Grd_mvto_Pac_Detalle_Paso.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.Grd_mvto_Pac_Detalle_Paso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_mvto_Pac_Detalle_Paso.Location = new System.Drawing.Point(22, 28);
            this.Grd_mvto_Pac_Detalle_Paso.Name = "Grd_mvto_Pac_Detalle_Paso";
            this.Grd_mvto_Pac_Detalle_Paso.Size = new System.Drawing.Size(1157, 414);
            this.Grd_mvto_Pac_Detalle_Paso.TabIndex = 53;
            this.Grd_mvto_Pac_Detalle_Paso.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.Grd_mvto_Pac_Detalle_Paso_InitializeLayout);
            this.Grd_mvto_Pac_Detalle_Paso.ClickCellButton += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.Grd_mvto_Pac_Detalle_Paso_ClickCellButton);
            this.Grd_mvto_Pac_Detalle_Paso.AfterSelectChange += new Infragistics.Win.UltraWinGrid.AfterSelectChangeEventHandler(this.Grd_mvto_Pac_Detalle_Paso_AfterSelectChange);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsb_Exportar});
            this.ToolStrip1.Location = new System.Drawing.Point(22, 3);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1157, 25);
            this.ToolStrip1.TabIndex = 44;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // Tsb_Exportar
            // 
            this.Tsb_Exportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Exportar.Name = "Tsb_Exportar";
            this.Tsb_Exportar.Size = new System.Drawing.Size(55, 22);
            this.Tsb_Exportar.Text = "Exportar";
            this.Tsb_Exportar.Click += new System.EventHandler(this.Tsb_Exportar_Click);
            // 
            // UltraGroupBox3
            // 
            this.UltraGroupBox3.Controls.Add(this.Txt_AñoProceso);
            this.UltraGroupBox3.Controls.Add(this.ultraLabel3);
            this.UltraGroupBox3.Controls.Add(this.ultraLabel2);
            this.UltraGroupBox3.Controls.Add(this.Txt_CodPAC);
            this.UltraGroupBox3.Controls.Add(this.Txt_PrecioEstimado);
            this.UltraGroupBox3.Controls.Add(this.Edt_PAC);
            this.UltraGroupBox3.Controls.Add(this.UltraLabel10);
            this.UltraGroupBox3.Controls.Add(this.UltraLabel1);
            this.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.UltraGroupBox3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.UltraGroupBox3.Location = new System.Drawing.Point(1, 0);
            this.UltraGroupBox3.Name = "UltraGroupBox3";
            this.UltraGroupBox3.Size = new System.Drawing.Size(1182, 94);
            this.UltraGroupBox3.TabIndex = 2;
            this.UltraGroupBox3.Text = "1. Proceso";
            this.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Txt_AñoProceso
            // 
            this.Txt_AñoProceso.anchoColumnasAyuda = "70,500";
            this.Txt_AñoProceso.DatoAnterior = "";
            this.Txt_AñoProceso.EligevariosElementos = false;
            this.Txt_AñoProceso.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_AñoProceso.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_AñoProceso.exigirCampoLleno = false;
            this.Txt_AñoProceso.InputMask = "";
            this.Txt_AñoProceso.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_AñoProceso.Location = new System.Drawing.Point(166, 14);
            this.Txt_AñoProceso.LongitudTexto = 200;
            this.Txt_AñoProceso.mensajeExisteDatoSP = "";
            this.Txt_AñoProceso.mensajeNoExisteDatoSP = "";
            this.Txt_AñoProceso.Name = "Txt_AñoProceso";
            this.Txt_AñoProceso.nombreDS = null;
            this.Txt_AñoProceso.nombreExisteDatoSP = "";
            this.Txt_AñoProceso.nombreNoExisteDatoSP = "";
            this.Txt_AñoProceso.nombreSP = "";
            this.Txt_AñoProceso.parametrosExisteDatoSP = "";
            this.Txt_AñoProceso.parametrosNoExisteDatoSP = "";
            this.Txt_AñoProceso.parametrosSP = "";
            this.Txt_AñoProceso.PosicionCampo = 0;
            this.Txt_AñoProceso.PosicionCampoTexto = 1;
            this.Txt_AñoProceso.PosicionValue = 0;
            this.Txt_AñoProceso.ReadOnly = true;
            this.Txt_AñoProceso.resaltarCampoOmitido = false;
            this.Txt_AñoProceso.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_AñoProceso.Size = new System.Drawing.Size(55, 21);
            this.Txt_AñoProceso.TabIndex = 99;
            this.Txt_AñoProceso.tipoAyuda = gnUserControl.gnTextBox.Ayuda.ConAyudaInicial;
            this.Txt_AñoProceso.tipoDato = gnUserControl.gnTextBox.Tipo.Ninguno;
            this.Txt_AñoProceso.tipoDatoC = gnUserControl.gnTextBox.TipoC.Ninguno;
            this.Txt_AñoProceso.tipoextraccion = gnUserControl.gnTextBox.TipoExtra.DataSet;
            this.Txt_AñoProceso.valorDevueltoVarios = "";
            this.Txt_AñoProceso.ValorDigitado = "";
            // 
            // ultraLabel3
            // 
            Appearance8.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel3.Appearance = Appearance8;
            this.ultraLabel3.AutoSize = true;
            this.ultraLabel3.Location = new System.Drawing.Point(88, 16);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(72, 14);
            this.ultraLabel3.TabIndex = 98;
            this.ultraLabel3.Text = "Año Proceso:";
            // 
            // ultraLabel2
            // 
            Appearance9.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel2.Appearance = Appearance9;
            this.ultraLabel2.AutoSize = true;
            this.ultraLabel2.Location = new System.Drawing.Point(74, 69);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(90, 14);
            this.ultraLabel2.TabIndex = 97;
            this.ultraLabel2.Text = "Precio Estimado:";
            // 
            // Txt_CodPAC
            // 
            this.Txt_CodPAC.anchoColumnasAyuda = "70,500";
            this.Txt_CodPAC.DatoAnterior = "";
            this.Txt_CodPAC.EligevariosElementos = false;
            this.Txt_CodPAC.enabledFocusColor = System.Drawing.Color.Lavender;
            this.Txt_CodPAC.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.Txt_CodPAC.exigirCampoLleno = false;
            this.Txt_CodPAC.InputMask = "";
            this.Txt_CodPAC.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_CodPAC.Location = new System.Drawing.Point(164, 39);
            this.Txt_CodPAC.LongitudTexto = 200;
            this.Txt_CodPAC.mensajeExisteDatoSP = "";
            this.Txt_CodPAC.mensajeNoExisteDatoSP = "";
            this.Txt_CodPAC.Name = "Txt_CodPAC";
            this.Txt_CodPAC.nombreDS = null;
            this.Txt_CodPAC.nombreExisteDatoSP = "";
            this.Txt_CodPAC.nombreNoExisteDatoSP = "";
            this.Txt_CodPAC.nombreSP = "";
            this.Txt_CodPAC.parametrosExisteDatoSP = "";
            this.Txt_CodPAC.parametrosNoExisteDatoSP = "";
            this.Txt_CodPAC.parametrosSP = "";
            this.Txt_CodPAC.PosicionCampo = 0;
            this.Txt_CodPAC.PosicionCampoTexto = 1;
            this.Txt_CodPAC.PosicionValue = 0;
            this.Txt_CodPAC.ReadOnly = true;
            this.Txt_CodPAC.resaltarCampoOmitido = false;
            this.Txt_CodPAC.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_CodPAC.Size = new System.Drawing.Size(145, 21);
            this.Txt_CodPAC.TabIndex = 96;
            this.Txt_CodPAC.tipoAyuda = gnUserControl.gnTextBox.Ayuda.ConAyudaInicial;
            this.Txt_CodPAC.tipoDato = gnUserControl.gnTextBox.Tipo.Ninguno;
            this.Txt_CodPAC.tipoDatoC = gnUserControl.gnTextBox.TipoC.Ninguno;
            this.Txt_CodPAC.tipoextraccion = gnUserControl.gnTextBox.TipoExtra.DataSet;
            this.Txt_CodPAC.valorDevueltoVarios = "";
            this.Txt_CodPAC.ValorDigitado = "";
            // 
            // Txt_PrecioEstimado
            // 
            this.Txt_PrecioEstimado.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.Txt_PrecioEstimado.InputMask = "{double:-9.2}";
            this.Txt_PrecioEstimado.Location = new System.Drawing.Point(166, 66);
            this.Txt_PrecioEstimado.Name = "Txt_PrecioEstimado";
            this.Txt_PrecioEstimado.ReadOnly = true;
            this.Txt_PrecioEstimado.Size = new System.Drawing.Size(145, 20);
            this.Txt_PrecioEstimado.TabIndex = 94;
            this.Txt_PrecioEstimado.Text = "UltraMaskedEdit1";
            // 
            // Edt_PAC
            // 
            this.Edt_PAC.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Edt_PAC.exigirCampoLleno = false;
            this.Edt_PAC.KeyDownUp = "";
            this.Edt_PAC.leaveFocusColor = System.Drawing.Color.White;
            this.Edt_PAC.Location = new System.Drawing.Point(403, 14);
            this.Edt_PAC.Multiline = true;
            this.Edt_PAC.Name = "Edt_PAC";
            this.Edt_PAC.ReadOnly = true;
            this.Edt_PAC.resaltarCampoOmitido = false;
            this.Edt_PAC.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Edt_PAC.Size = new System.Drawing.Size(763, 69);
            this.Edt_PAC.TabIndex = 92;
            this.Edt_PAC.tipoDatoC = gnUserControl.gnEditBox.TipoC.Ninguno;
            // 
            // UltraLabel10
            // 
            appearance1.BackColor = System.Drawing.Color.Transparent;
            this.UltraLabel10.Appearance = appearance1;
            this.UltraLabel10.AutoSize = true;
            this.UltraLabel10.Location = new System.Drawing.Point(334, 14);
            this.UltraLabel10.Name = "UltraLabel10";
            this.UltraLabel10.Size = new System.Drawing.Size(67, 14);
            this.UltraLabel10.TabIndex = 93;
            this.UltraLabel10.Text = "Descripción:";
            // 
            // UltraLabel1
            // 
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.UltraLabel1.Appearance = appearance2;
            this.UltraLabel1.AutoSize = true;
            this.UltraLabel1.Location = new System.Drawing.Point(41, 41);
            this.UltraLabel1.Name = "UltraLabel1";
            this.UltraLabel1.Size = new System.Drawing.Size(121, 14);
            this.UltraLabel1.TabIndex = 91;
            this.UltraLabel1.Text = "Tipo de Procedimiento:";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Signoexclamacion_cabecera.png");
            this.imageList2.Images.SetKeyName(1, "campana_cabecera.png");
            this.imageList2.Images.SetKeyName(2, "email_respondido.png");
            this.imageList2.Images.SetKeyName(3, "Adjuntar_cabecera.png");
            this.imageList2.Images.SetKeyName(4, "Seguimiento_Detalle.png");
            this.imageList2.Images.SetKeyName(5, "Leido.png");
            this.imageList2.Images.SetKeyName(6, "esfera_ambar.png");
            this.imageList2.Images.SetKeyName(7, "esfera_roja.jpg");
            this.imageList2.Images.SetKeyName(8, "esfera_verde.png");
            this.imageList2.Images.SetKeyName(9, "Pasos.png");
            this.imageList2.Images.SetKeyName(10, "Formularios.png");
            this.imageList2.Images.SetKeyName(11, "flecha-arriba.png");
            this.imageList2.Images.SetKeyName(12, "flecha-hacia-abajo.png");
            // 
            // SaveDocumento
            // 
            this.SaveDocumento.DefaultExt = "XLS";
            this.SaveDocumento.Filter = "Excel (*.xls)|*.xls";
            this.SaveDocumento.RestoreDirectory = true;
            // 
            // Frm_ActualizaPasoPAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 540);
            this.Controls.Add(this.ultraGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ActualizaPasoPAC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Pasos Proceso";
            this.Load += new System.EventHandler(this.Frm_ActualizaPasoPAC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraGroupBox1)).EndInit();
            this.ultraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grp_Catalogo)).EndInit();
            this.grp_Catalogo.ResumeLayout(false);
            this.grp_Catalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_mvto_Pac_Detalle_Paso)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).EndInit();
            this.UltraGroupBox3.ResumeLayout(false);
            this.UltraGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_AñoProceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_CodPAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edt_PAC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraGroupBox ultraGroupBox1;
        internal Infragistics.Win.Misc.UltraGroupBox grp_Catalogo;
        internal Infragistics.Win.UltraWinGrid.UltraGrid Grd_mvto_Pac_Detalle_Paso;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton Tsb_Exportar;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox3;
        internal gnUserControl.gnTextBox Txt_CodPAC;
        internal Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit Txt_PrecioEstimado;
        internal gnUserControl.gnEditBox Edt_PAC;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel10;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel1;
        internal Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private System.Windows.Forms.ImageList imageList2;
        internal System.Windows.Forms.SaveFileDialog SaveDocumento;
        internal Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter UltraGridExcelExporter1;
        internal gnUserControl.gnTextBox Txt_AñoProceso;
        internal Infragistics.Win.Misc.UltraLabel ultraLabel3;
    }
}