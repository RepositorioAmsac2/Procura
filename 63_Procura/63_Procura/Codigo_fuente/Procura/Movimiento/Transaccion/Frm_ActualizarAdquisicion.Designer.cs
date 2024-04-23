
namespace WINlogistica
{
    partial class Frm_ActualizarAdquisicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ActualizarAdquisicion));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Btn_ListaProyecto = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_LocalizacionProyecto = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_BorrarImagen = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Grabar = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Grabar_Salir = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Salir = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_ValorInicial = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ubicacionGeograficaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Grp_DatosProyecto = new DevExpress.XtraEditors.GroupControl();
            this.Cbo_EntidadConvocante = new gnUserControl.gnComboBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Cbo_TipoAdquisicion = new gnUserControl.gnComboBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Cbo_ModalidadSeleccion = new gnUserControl.gnComboBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Dtp_FechaPrevista = new gnUserControl.gnDateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Btn_TipoProcedimientoAutomatico = new System.Windows.Forms.Button();
            this.Txt_NumProcedimiento = new gnUserControl.gnMaskedTextBox();
            this.Cbo_ObjetoContratacion = new gnUserControl.gnComboBox();
            this.Cbo_TipoProceso = new gnUserControl.gnComboBox();
            this.Txt_Justificacion = new DevExpress.XtraEditors.MemoEdit();
            this.Edt_NomAdquisicion = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.empresaContratanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.macroProyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionGeograficaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_DatosProyecto)).BeginInit();
            this.Grp_DatosProyecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtp_FechaPrevista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Justificacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edt_NomAdquisicion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaContratanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macroProyectoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.ribbonControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(947, 154);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.Btn_ListaProyecto,
            this.Btn_LocalizacionProyecto,
            this.Btn_BorrarImagen,
            this.Btn_Grabar,
            this.Btn_Grabar_Salir,
            this.Btn_Salir,
            this.Btn_ValorInicial});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(947, 150);
            // 
            // Btn_ListaProyecto
            // 
            this.Btn_ListaProyecto.Caption = "Lista de adquisiciones";
            this.Btn_ListaProyecto.Id = 1;
            this.Btn_ListaProyecto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ListaProyecto.ImageOptions.Image")));
            this.Btn_ListaProyecto.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_ListaProyecto.ImageOptions.LargeImage")));
            this.Btn_ListaProyecto.Name = "Btn_ListaProyecto";
            this.Btn_ListaProyecto.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // Btn_LocalizacionProyecto
            // 
            this.Btn_LocalizacionProyecto.Caption = "Mapa";
            this.Btn_LocalizacionProyecto.Id = 2;
            this.Btn_LocalizacionProyecto.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Btn_LocalizacionProyecto.ImageOptions.SvgImage")));
            this.Btn_LocalizacionProyecto.Name = "Btn_LocalizacionProyecto";
            this.Btn_LocalizacionProyecto.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // Btn_BorrarImagen
            // 
            this.Btn_BorrarImagen.Caption = "Borrar imagen";
            this.Btn_BorrarImagen.Id = 3;
            this.Btn_BorrarImagen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_BorrarImagen.ImageOptions.Image")));
            this.Btn_BorrarImagen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_BorrarImagen.ImageOptions.LargeImage")));
            this.Btn_BorrarImagen.Name = "Btn_BorrarImagen";
            this.Btn_BorrarImagen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.Btn_BorrarImagen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_BorrarImagen_ItemClick);
            // 
            // Btn_Grabar
            // 
            this.Btn_Grabar.Caption = "Grabar";
            this.Btn_Grabar.Id = 4;
            this.Btn_Grabar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Grabar.ImageOptions.Image")));
            this.Btn_Grabar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Grabar.ImageOptions.LargeImage")));
            this.Btn_Grabar.Name = "Btn_Grabar";
            this.Btn_Grabar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.Btn_Grabar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Grabar_ItemClick);
            // 
            // Btn_Grabar_Salir
            // 
            this.Btn_Grabar_Salir.Caption = "Grabar y salir";
            this.Btn_Grabar_Salir.Id = 5;
            this.Btn_Grabar_Salir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Grabar_Salir.ImageOptions.Image")));
            this.Btn_Grabar_Salir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Grabar_Salir.ImageOptions.LargeImage")));
            this.Btn_Grabar_Salir.Name = "Btn_Grabar_Salir";
            this.Btn_Grabar_Salir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.Btn_Grabar_Salir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Grabar_Salir_ItemClick);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Caption = "Salir";
            this.Btn_Salir.Id = 6;
            this.Btn_Salir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.ImageOptions.Image")));
            this.Btn_Salir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.ImageOptions.LargeImage")));
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.Btn_Salir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Salir_ItemClick);
            // 
            // Btn_ValorInicial
            // 
            this.Btn_ValorInicial.Caption = "Valores iniciales";
            this.Btn_ValorInicial.Id = 7;
            this.Btn_ValorInicial.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ValorInicial.ImageOptions.Image")));
            this.Btn_ValorInicial.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_ValorInicial.ImageOptions.LargeImage")));
            this.Btn_ValorInicial.Name = "Btn_ValorInicial";
            this.Btn_ValorInicial.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.Btn_ValorInicial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_ValorInicial_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Detalle adquisición";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_ListaProyecto);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Inicio";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.Btn_Grabar);
            this.ribbonPageGroup2.ItemLinks.Add(this.Btn_Grabar_Salir);
            this.ribbonPageGroup2.ItemLinks.Add(this.Btn_ValorInicial, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.Btn_Salir, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Principal";
            // 
            // ubicacionGeograficaBindingSource
            // 
            this.ubicacionGeograficaBindingSource.DataSource = typeof(Model.UbicacionGeografica);
            // 
            // Grp_DatosProyecto
            // 
            this.Grp_DatosProyecto.Controls.Add(this.Cbo_EntidadConvocante);
            this.Grp_DatosProyecto.Controls.Add(this.Label16);
            this.Grp_DatosProyecto.Controls.Add(this.Cbo_TipoAdquisicion);
            this.Grp_DatosProyecto.Controls.Add(this.Label11);
            this.Grp_DatosProyecto.Controls.Add(this.Cbo_ModalidadSeleccion);
            this.Grp_DatosProyecto.Controls.Add(this.Label12);
            this.Grp_DatosProyecto.Controls.Add(this.Dtp_FechaPrevista);
            this.Grp_DatosProyecto.Controls.Add(this.labelControl1);
            this.Grp_DatosProyecto.Controls.Add(this.Btn_TipoProcedimientoAutomatico);
            this.Grp_DatosProyecto.Controls.Add(this.Txt_NumProcedimiento);
            this.Grp_DatosProyecto.Controls.Add(this.Cbo_ObjetoContratacion);
            this.Grp_DatosProyecto.Controls.Add(this.Cbo_TipoProceso);
            this.Grp_DatosProyecto.Controls.Add(this.Txt_Justificacion);
            this.Grp_DatosProyecto.Controls.Add(this.Edt_NomAdquisicion);
            this.Grp_DatosProyecto.Controls.Add(this.labelControl8);
            this.Grp_DatosProyecto.Controls.Add(this.labelControl4);
            this.Grp_DatosProyecto.Controls.Add(this.labelControl3);
            this.Grp_DatosProyecto.Controls.Add(this.labelControl11);
            this.Grp_DatosProyecto.Controls.Add(this.labelControl18);
            this.Grp_DatosProyecto.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grp_DatosProyecto.Location = new System.Drawing.Point(0, 154);
            this.Grp_DatosProyecto.Name = "Grp_DatosProyecto";
            this.Grp_DatosProyecto.Size = new System.Drawing.Size(947, 296);
            this.Grp_DatosProyecto.TabIndex = 4;
            this.Grp_DatosProyecto.Text = "Datos de la adquisición";
            // 
            // Cbo_EntidadConvocante
            // 
            this.Cbo_EntidadConvocante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_EntidadConvocante.Enabled = false;
            this.Cbo_EntidadConvocante.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_EntidadConvocante.FormattingEnabled = true;
            this.Cbo_EntidadConvocante.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_EntidadConvocante.Location = new System.Drawing.Point(608, 144);
            this.Cbo_EntidadConvocante.Name = "Cbo_EntidadConvocante";
            this.Cbo_EntidadConvocante.nombreDS = null;
            this.Cbo_EntidadConvocante.nombreSP = "";
            this.Cbo_EntidadConvocante.parametrosSP = "";
            this.Cbo_EntidadConvocante.resaltarCampoOmitido = false;
            this.Cbo_EntidadConvocante.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_EntidadConvocante.Size = new System.Drawing.Size(327, 21);
            this.Cbo_EntidadConvocante.TabIndex = 682;
            this.Cbo_EntidadConvocante.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.Location = new System.Drawing.Point(496, 148);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(108, 13);
            this.Label16.TabIndex = 686;
            this.Label16.Text = "Entidad Convocante:";
            // 
            // Cbo_TipoAdquisicion
            // 
            this.Cbo_TipoAdquisicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_TipoAdquisicion.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_TipoAdquisicion.FormattingEnabled = true;
            this.Cbo_TipoAdquisicion.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_TipoAdquisicion.Location = new System.Drawing.Point(608, 118);
            this.Cbo_TipoAdquisicion.Name = "Cbo_TipoAdquisicion";
            this.Cbo_TipoAdquisicion.nombreDS = null;
            this.Cbo_TipoAdquisicion.nombreSP = "";
            this.Cbo_TipoAdquisicion.parametrosSP = "";
            this.Cbo_TipoAdquisicion.resaltarCampoOmitido = false;
            this.Cbo_TipoAdquisicion.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_TipoAdquisicion.Size = new System.Drawing.Size(327, 21);
            this.Cbo_TipoAdquisicion.TabIndex = 681;
            this.Cbo_TipoAdquisicion.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Location = new System.Drawing.Point(465, 121);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(139, 13);
            this.Label11.TabIndex = 684;
            this.Label11.Text = "Tipo de compra o selección:";
            // 
            // Cbo_ModalidadSeleccion
            // 
            this.Cbo_ModalidadSeleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_ModalidadSeleccion.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_ModalidadSeleccion.FormattingEnabled = true;
            this.Cbo_ModalidadSeleccion.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_ModalidadSeleccion.Location = new System.Drawing.Point(608, 170);
            this.Cbo_ModalidadSeleccion.Name = "Cbo_ModalidadSeleccion";
            this.Cbo_ModalidadSeleccion.nombreDS = null;
            this.Cbo_ModalidadSeleccion.nombreSP = "";
            this.Cbo_ModalidadSeleccion.parametrosSP = "";
            this.Cbo_ModalidadSeleccion.resaltarCampoOmitido = false;
            this.Cbo_ModalidadSeleccion.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_ModalidadSeleccion.Size = new System.Drawing.Size(327, 21);
            this.Cbo_ModalidadSeleccion.TabIndex = 683;
            this.Cbo_ModalidadSeleccion.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Location = new System.Drawing.Point(481, 172);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(123, 13);
            this.Label12.TabIndex = 685;
            this.Label12.Text = "Modalidad de  selección:";
            // 
            // Dtp_FechaPrevista
            // 
            this.Dtp_FechaPrevista.DateTime = new System.DateTime(2013, 12, 18, 0, 0, 0, 0);
            this.Dtp_FechaPrevista.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Dtp_FechaPrevista.exigirCampoLleno = false;
            this.Dtp_FechaPrevista.KeyDownUp = "";
            this.Dtp_FechaPrevista.leaveFocusColor = System.Drawing.Color.White;
            this.Dtp_FechaPrevista.Location = new System.Drawing.Point(608, 220);
            this.Dtp_FechaPrevista.Name = "Dtp_FechaPrevista";
            this.Dtp_FechaPrevista.resaltarCampoOmitido = false;
            this.Dtp_FechaPrevista.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Dtp_FechaPrevista.Size = new System.Drawing.Size(128, 22);
            this.Dtp_FechaPrevista.TabIndex = 680;
            this.Dtp_FechaPrevista.Value = new System.DateTime(2013, 12, 18, 0, 0, 0, 0);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(533, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 679;
            this.labelControl1.Text = "Procedimiento:";
            // 
            // Btn_TipoProcedimientoAutomatico
            // 
            this.Btn_TipoProcedimientoAutomatico.Location = new System.Drawing.Point(743, 61);
            this.Btn_TipoProcedimientoAutomatico.Name = "Btn_TipoProcedimientoAutomatico";
            this.Btn_TipoProcedimientoAutomatico.Size = new System.Drawing.Size(192, 21);
            this.Btn_TipoProcedimientoAutomatico.TabIndex = 678;
            this.Btn_TipoProcedimientoAutomatico.Text = "Tipo Procedimiento Automatico";
            this.Btn_TipoProcedimientoAutomatico.UseVisualStyleBackColor = true;
            // 
            // Txt_NumProcedimiento
            // 
            this.Txt_NumProcedimiento.enabledFocusColor = System.Drawing.Color.Gainsboro;
            this.Txt_NumProcedimiento.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Txt_NumProcedimiento.exigirCampoLleno = false;
            this.Txt_NumProcedimiento.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_NumProcedimiento.Location = new System.Drawing.Point(608, 62);
            this.Txt_NumProcedimiento.Mask = ">LL-999-9999->LL";
            this.Txt_NumProcedimiento.Name = "Txt_NumProcedimiento";
            this.Txt_NumProcedimiento.resaltarCampoOmitido = false;
            this.Txt_NumProcedimiento.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_NumProcedimiento.Size = new System.Drawing.Size(125, 21);
            this.Txt_NumProcedimiento.TabIndex = 676;
            this.Txt_NumProcedimiento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Cbo_ObjetoContratacion
            // 
            this.Cbo_ObjetoContratacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_ObjetoContratacion.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_ObjetoContratacion.FormattingEnabled = true;
            this.Cbo_ObjetoContratacion.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_ObjetoContratacion.Location = new System.Drawing.Point(608, 89);
            this.Cbo_ObjetoContratacion.Name = "Cbo_ObjetoContratacion";
            this.Cbo_ObjetoContratacion.nombreDS = null;
            this.Cbo_ObjetoContratacion.nombreSP = "";
            this.Cbo_ObjetoContratacion.parametrosSP = "";
            this.Cbo_ObjetoContratacion.resaltarCampoOmitido = false;
            this.Cbo_ObjetoContratacion.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_ObjetoContratacion.Size = new System.Drawing.Size(327, 21);
            this.Cbo_ObjetoContratacion.TabIndex = 677;
            this.Cbo_ObjetoContratacion.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // Cbo_TipoProceso
            // 
            this.Cbo_TipoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_TipoProceso.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Cbo_TipoProceso.FormattingEnabled = true;
            this.Cbo_TipoProceso.leaveFocusColor = System.Drawing.Color.White;
            this.Cbo_TipoProceso.Location = new System.Drawing.Point(608, 38);
            this.Cbo_TipoProceso.Name = "Cbo_TipoProceso";
            this.Cbo_TipoProceso.nombreDS = null;
            this.Cbo_TipoProceso.nombreSP = "";
            this.Cbo_TipoProceso.parametrosSP = "";
            this.Cbo_TipoProceso.resaltarCampoOmitido = false;
            this.Cbo_TipoProceso.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Cbo_TipoProceso.Size = new System.Drawing.Size(327, 21);
            this.Cbo_TipoProceso.TabIndex = 675;
            this.Cbo_TipoProceso.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // Txt_Justificacion
            // 
            this.Txt_Justificacion.Location = new System.Drawing.Point(12, 187);
            this.Txt_Justificacion.Name = "Txt_Justificacion";
            this.Txt_Justificacion.Size = new System.Drawing.Size(424, 55);
            this.Txt_Justificacion.TabIndex = 1;
            // 
            // Edt_NomAdquisicion
            // 
            this.Edt_NomAdquisicion.Location = new System.Drawing.Point(12, 44);
            this.Edt_NomAdquisicion.Name = "Edt_NomAdquisicion";
            this.Edt_NomAdquisicion.Size = new System.Drawing.Size(424, 107);
            this.Edt_NomAdquisicion.TabIndex = 0;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(524, 41);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(80, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Tipo de Proceso:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 168);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Justificación:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(203, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Descripción del bien o servicio a contratar:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(489, 92);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(115, 13);
            this.labelControl11.TabIndex = 9;
            this.labelControl11.Text = "Objeto de contratación:";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(529, 224);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(75, 13);
            this.labelControl18.TabIndex = 15;
            this.labelControl18.Text = "Fecha prevista:";
            this.labelControl18.Visible = false;
            // 
            // macroProyectoBindingSource
            // 
            this.macroProyectoBindingSource.DataSource = typeof(Model.MacroProyecto);
            // 
            // Frm_ActualizarAdquisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 454);
            this.Controls.Add(this.Grp_DatosProyecto);
            this.Controls.Add(this.sidePanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ActualizarAdquisicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Adquisicion";
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionGeograficaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_DatosProyecto)).EndInit();
            this.Grp_DatosProyecto.ResumeLayout(false);
            this.Grp_DatosProyecto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtp_FechaPrevista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Justificacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edt_NomAdquisicion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaContratanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macroProyectoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem Btn_ListaProyecto;
        private DevExpress.XtraBars.BarButtonItem Btn_LocalizacionProyecto;
        private DevExpress.XtraBars.BarButtonItem Btn_BorrarImagen;
        private DevExpress.XtraBars.BarButtonItem Btn_Grabar;
        private DevExpress.XtraBars.BarButtonItem Btn_Grabar_Salir;
        private DevExpress.XtraBars.BarButtonItem Btn_Salir;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.BindingSource ubicacionGeograficaBindingSource;
        private DevExpress.XtraEditors.GroupControl Grp_DatosProyecto;
        private DevExpress.XtraEditors.MemoEdit Edt_NomAdquisicion;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private System.Windows.Forms.BindingSource macroProyectoBindingSource;
        private System.Windows.Forms.BindingSource empresaContratanteBindingSource;
        private DevExpress.XtraBars.BarButtonItem Btn_ValorInicial;
        private DevExpress.XtraEditors.MemoEdit Txt_Justificacion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button Btn_TipoProcedimientoAutomatico;
        internal gnUserControl.gnMaskedTextBox Txt_NumProcedimiento;
        internal gnUserControl.gnComboBox Cbo_ObjetoContratacion;
        internal gnUserControl.gnComboBox Cbo_TipoProceso;
        internal gnUserControl.gnDateTimePicker Dtp_FechaPrevista;
        internal gnUserControl.gnComboBox Cbo_EntidadConvocante;
        internal System.Windows.Forms.Label Label16;
        internal gnUserControl.gnComboBox Cbo_TipoAdquisicion;
        internal System.Windows.Forms.Label Label11;
        internal gnUserControl.gnComboBox Cbo_ModalidadSeleccion;
        internal System.Windows.Forms.Label Label12;
    }
}