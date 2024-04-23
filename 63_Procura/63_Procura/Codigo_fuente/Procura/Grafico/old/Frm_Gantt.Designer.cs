namespace WINlogistica
{
    partial class Frm_Gantt
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
            Infragistics.UltraChart.Resources.Appearance.PaintElement paintElement1 = new Infragistics.UltraChart.Resources.Appearance.PaintElement();
            Infragistics.UltraChart.Resources.Appearance.PaintElement paintElement2 = new Infragistics.UltraChart.Resources.Appearance.PaintElement();
            Infragistics.UltraChart.Resources.Appearance.PaintElement paintElement3 = new Infragistics.UltraChart.Resources.Appearance.PaintElement();
            Infragistics.UltraChart.Resources.Appearance.PaintElement paintElement4 = new Infragistics.UltraChart.Resources.Appearance.PaintElement();
            Infragistics.UltraChart.Resources.Appearance.PaintElement paintElement5 = new Infragistics.UltraChart.Resources.Appearance.PaintElement();
            Infragistics.UltraChart.Resources.Appearance.PaintElement paintElement6 = new Infragistics.UltraChart.Resources.Appearance.PaintElement();
            Infragistics.UltraChart.Resources.Appearance.GanttChartAppearance ganttChartAppearance1 = new Infragistics.UltraChart.Resources.Appearance.GanttChartAppearance();
            Infragistics.UltraChart.Resources.Appearance.PaintElement paintElement7 = new Infragistics.UltraChart.Resources.Appearance.PaintElement();
            Infragistics.UltraChart.Resources.Appearance.PaintElement paintElement8 = new Infragistics.UltraChart.Resources.Appearance.PaintElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Gantt));
            this.UltraGroupBox1 = new Infragistics.Win.Misc.UltraGroupBox();
            this.UltraGroupBox3 = new Infragistics.Win.Misc.UltraGroupBox();
            this.ultraChart1 = new Infragistics.Win.UltraWinChart.UltraChart();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbo_TipoImagen = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Salvar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_SalvarTransparencia = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Imprimir = new System.Windows.Forms.ToolStripButton();
            this.Grp_Filtro = new Infragistics.Win.Misc.UltraGroupBox();
            this.Txt_NumProcedimiento = new gnUserControl.gnMaskedTextBox();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.edt_Descripcion = new gnUserControl.gnTextBox();
            this.CLabel3 = new GUID.wclControles.cLabel();
            this.cbo_Version = new gnUserControl.gnComboBox();
            this.CLabel1 = new GUID.wclControles.cLabel();
            this.cbo_PeriodoProceso = new gnUserControl.gnComboBox();
            this.CLabel2 = new GUID.wclControles.cLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ultraPrintPreviewDialog1 = new Infragistics.Win.Printing.UltraPrintPreviewDialog(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox1)).BeginInit();
            this.UltraGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).BeginInit();
            this.UltraGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraChart1)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_Filtro)).BeginInit();
            this.Grp_Filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Descripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // UltraGroupBox1
            // 
            this.UltraGroupBox1.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None;
            this.UltraGroupBox1.Controls.Add(this.UltraGroupBox3);
            this.UltraGroupBox1.Controls.Add(this.Grp_Filtro);
            this.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.UltraGroupBox1.Name = "UltraGroupBox1";
            this.UltraGroupBox1.Size = new System.Drawing.Size(1201, 597);
            this.UltraGroupBox1.TabIndex = 1;
            this.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // UltraGroupBox3
            // 
            this.UltraGroupBox3.Controls.Add(this.ultraChart1);
            this.UltraGroupBox3.Controls.Add(this.ToolStrip1);
            this.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UltraGroupBox3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.UltraGroupBox3.Location = new System.Drawing.Point(1, 73);
            this.UltraGroupBox3.Name = "UltraGroupBox3";
            this.UltraGroupBox3.Size = new System.Drawing.Size(1199, 523);
            this.UltraGroupBox3.TabIndex = 1;
            this.UltraGroupBox3.Text = "2. Grafico";
            this.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
//			'UltraChart' properties's serialization: Since 'ChartType' changes the way axes look,
//			'ChartType' must be persisted ahead of any Axes change made in design time.
//		
            this.ultraChart1.ChartType = Infragistics.UltraChart.Shared.Styles.ChartType.GanttChart;
            // 
            // ultraChart1
            // 
            this.ultraChart1.Axis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            paintElement1.ElementType = Infragistics.UltraChart.Shared.Styles.PaintElementType.None;
            paintElement1.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.ultraChart1.Axis.PE = paintElement1;
            this.ultraChart1.Axis.X.Extent = 50;
            this.ultraChart1.Axis.X.Labels.Font = new System.Drawing.Font("Verdana", 6F);
            this.ultraChart1.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL:dd-MM-yy>";
            this.ultraChart1.Axis.X.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing;
            this.ultraChart1.Axis.X.Labels.SeriesLabels.FormatString = "";
            this.ultraChart1.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart1.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing;
            this.ultraChart1.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.X.LineEndCapStyle = Infragistics.UltraChart.Shared.Styles.LineCapStyle.Flat;
            this.ultraChart1.Axis.X.LineThickness = 1;
            this.ultraChart1.Axis.X.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.X.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.X.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.X.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.X.StripLines.Interval = 1;
            this.ultraChart1.Axis.X.TickmarkInterval = 7D;
            this.ultraChart1.Axis.X.TickmarkIntervalType = Infragistics.UltraChart.Shared.Styles.AxisIntervalType.Days;
            this.ultraChart1.Axis.X.TickmarkPercentage = 7D;
            this.ultraChart1.Axis.X.Visible = true;
            this.ultraChart1.Axis.X2.Labels.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.ultraChart1.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL:dd-MM-yy>";
            this.ultraChart1.Axis.X2.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing;
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.FormatString = "";
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.X2.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.X2.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.X2.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.X2.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.X2.Visible = false;
            this.ultraChart1.Axis.Y.Extent = 210;
            this.ultraChart1.Axis.Y.Labels.Font = new System.Drawing.Font("Verdana", 5F);
            this.ultraChart1.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart1.Axis.Y.Labels.ItemFormatString = "<ITEM_LABEL>";
            this.ultraChart1.Axis.Y.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 6F);
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing;
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Y.LineEndCapStyle = Infragistics.UltraChart.Shared.Styles.LineCapStyle.Flat;
            this.ultraChart1.Axis.Y.LineThickness = 1;
            this.ultraChart1.Axis.Y.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Y.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.Y.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Y.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.Y.Visible = true;
            this.ultraChart1.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart1.Axis.Y2.Labels.ItemFormatString = "<ITEM_LABEL>";
            this.ultraChart1.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing;
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Y2.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Y2.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.Y2.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Y2.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.Y2.Visible = false;
            this.ultraChart1.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.Z.Labels.ItemFormatString = "";
            this.ultraChart1.Axis.Z.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Z.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Z.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.Z.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Z.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.Z.Visible = false;
            this.ultraChart1.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.Z2.Labels.ItemFormatString = "";
            this.ultraChart1.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Z2.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Z2.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.Z2.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Z2.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.Z2.Visible = false;
            this.ultraChart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ultraChart1.Border.CornerRadius = 5;
            this.ultraChart1.ColorModel.AlphaLevel = ((byte)(150));
            this.ultraChart1.ColorModel.ModelStyle = Infragistics.UltraChart.Shared.Styles.ColorModels.CustomSkin;
            paintElement2.ElementType = Infragistics.UltraChart.Shared.Styles.PaintElementType.Gradient;
            paintElement2.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(162)))), ((int)(((byte)(36)))));
            paintElement2.FillGradientStyle = Infragistics.UltraChart.Shared.Styles.GradientStyle.Horizontal;
            paintElement2.FillStopColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(244)))), ((int)(((byte)(17)))));
            paintElement2.Stroke = System.Drawing.Color.Transparent;
            paintElement3.ElementType = Infragistics.UltraChart.Shared.Styles.PaintElementType.Gradient;
            paintElement3.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            paintElement3.FillGradientStyle = Infragistics.UltraChart.Shared.Styles.GradientStyle.Horizontal;
            paintElement3.FillStopColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            paintElement3.Stroke = System.Drawing.Color.Transparent;
            paintElement4.ElementType = Infragistics.UltraChart.Shared.Styles.PaintElementType.Gradient;
            paintElement4.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            paintElement4.FillGradientStyle = Infragistics.UltraChart.Shared.Styles.GradientStyle.Horizontal;
            paintElement4.FillStopColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(117)))), ((int)(((byte)(16)))));
            paintElement4.Stroke = System.Drawing.Color.Transparent;
            paintElement5.ElementType = Infragistics.UltraChart.Shared.Styles.PaintElementType.Gradient;
            paintElement5.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(190)))), ((int)(((byte)(2)))));
            paintElement5.FillGradientStyle = Infragistics.UltraChart.Shared.Styles.GradientStyle.Horizontal;
            paintElement5.FillStopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(81)))));
            paintElement5.Stroke = System.Drawing.Color.Transparent;
            paintElement6.ElementType = Infragistics.UltraChart.Shared.Styles.PaintElementType.Gradient;
            paintElement6.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(122)))), ((int)(((byte)(10)))));
            paintElement6.FillGradientStyle = Infragistics.UltraChart.Shared.Styles.GradientStyle.Horizontal;
            paintElement6.FillStopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(66)))));
            paintElement6.Stroke = System.Drawing.Color.Transparent;
            this.ultraChart1.ColorModel.Skin.PEs.AddRange(new Infragistics.UltraChart.Resources.Appearance.PaintElement[] {
            paintElement2,
            paintElement3,
            paintElement4,
            paintElement5,
            paintElement6});
            this.ultraChart1.Data.EmptyStyle.LineStyle.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dash;
            this.ultraChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraChart1.ForeColor = System.Drawing.SystemColors.ControlText;
            paintElement7.Fill = System.Drawing.Color.Red;
            ganttChartAppearance1.CompletePercentagesPE = paintElement7;
            paintElement8.Fill = System.Drawing.Color.White;
            ganttChartAppearance1.EmptyPercentagesPE = paintElement8;
            ganttChartAppearance1.LinkLineStyle.EndStyle = Infragistics.UltraChart.Shared.Styles.LineCapStyle.ArrowAnchor;
            ganttChartAppearance1.OwnersLabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ultraChart1.GanttChart = ganttChartAppearance1;
            this.ultraChart1.Location = new System.Drawing.Point(22, 28);
            this.ultraChart1.Name = "ultraChart1";
            this.ultraChart1.Size = new System.Drawing.Size(1174, 492);
            this.ultraChart1.TabIndex = 5;
            this.ultraChart1.TitleTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.ultraChart1.TitleTop.HorizontalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.TitleTop.Text = "Gantt";
            this.ultraChart1.Tooltips.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ultraChart1.Tooltips.HighlightFillColor = System.Drawing.Color.DimGray;
            this.ultraChart1.Tooltips.HighlightOutlineColor = System.Drawing.Color.DarkGray;
            this.ultraChart1.Visible = false;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbo_TipoImagen,
            this.ToolStripSeparator1,
            this.btn_Salvar,
            this.ToolStripSeparator2,
            this.btn_SalvarTransparencia,
            this.ToolStripSeparator3,
            this.btn_Imprimir});
            this.ToolStrip1.Location = new System.Drawing.Point(22, 3);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1174, 25);
            this.ToolStrip1.TabIndex = 0;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // cbo_TipoImagen
            // 
            this.cbo_TipoImagen.Name = "cbo_TipoImagen";
            this.cbo_TipoImagen.Size = new System.Drawing.Size(121, 25);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.AccessibleDescription = "C";
            this.btn_Salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(42, 22);
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.AccessibleDescription = "C";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_SalvarTransparencia
            // 
            this.btn_SalvarTransparencia.AccessibleDescription = "C";
            this.btn_SalvarTransparencia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SalvarTransparencia.Name = "btn_SalvarTransparencia";
            this.btn_SalvarTransparencia.Size = new System.Drawing.Size(166, 22);
            this.btn_SalvarTransparencia.Text = "Salvar PNG con transparencia";
            this.btn_SalvarTransparencia.Click += new System.EventHandler(this.btn_SalvarTransparencia_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.AccessibleDescription = "C";
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.AccessibleDescription = "C";
            this.btn_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(57, 22);
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // Grp_Filtro
            // 
            this.Grp_Filtro.Controls.Add(this.Txt_NumProcedimiento);
            this.Grp_Filtro.Controls.Add(this.btn_Mostrar);
            this.Grp_Filtro.Controls.Add(this.edt_Descripcion);
            this.Grp_Filtro.Controls.Add(this.CLabel3);
            this.Grp_Filtro.Controls.Add(this.cbo_Version);
            this.Grp_Filtro.Controls.Add(this.CLabel1);
            this.Grp_Filtro.Controls.Add(this.cbo_PeriodoProceso);
            this.Grp_Filtro.Controls.Add(this.CLabel2);
            this.Grp_Filtro.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grp_Filtro.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder;
            this.Grp_Filtro.Location = new System.Drawing.Point(1, 0);
            this.Grp_Filtro.Name = "Grp_Filtro";
            this.Grp_Filtro.Size = new System.Drawing.Size(1199, 73);
            this.Grp_Filtro.TabIndex = 0;
            this.Grp_Filtro.Text = "1. Filtro";
            this.Grp_Filtro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007;
            // 
            // Txt_NumProcedimiento
            // 
            this.Txt_NumProcedimiento.enabledFocusColor = System.Drawing.Color.Gainsboro;
            this.Txt_NumProcedimiento.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.Txt_NumProcedimiento.exigirCampoLleno = false;
            this.Txt_NumProcedimiento.leaveFocusColor = System.Drawing.Color.White;
            this.Txt_NumProcedimiento.Location = new System.Drawing.Point(126, 43);
            this.Txt_NumProcedimiento.Mask = ">LL-999-9999->LL";
            this.Txt_NumProcedimiento.Name = "Txt_NumProcedimiento";
            this.Txt_NumProcedimiento.resaltarCampoOmitido = false;
            this.Txt_NumProcedimiento.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.Txt_NumProcedimiento.Size = new System.Drawing.Size(128, 20);
            this.Txt_NumProcedimiento.TabIndex = 2;
            this.Txt_NumProcedimiento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.Txt_NumProcedimiento.Leave += new System.EventHandler(this.Txt_NumProcedimiento_Leave);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(722, 41);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Mostrar.TabIndex = 4;
            this.btn_Mostrar.Text = "&Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // edt_Descripcion
            // 
            this.edt_Descripcion.anchoColumnasAyuda = "150,70";
            this.edt_Descripcion.DatoAnterior = "";
            this.edt_Descripcion.EligevariosElementos = false;
            this.edt_Descripcion.Enabled = false;
            this.edt_Descripcion.enabledFocusColor = System.Drawing.Color.Lavender;
            this.edt_Descripcion.enterFocusColor = System.Drawing.Color.PapayaWhip;
            this.edt_Descripcion.exigirCampoLleno = false;
            this.edt_Descripcion.InputMask = "";
            this.edt_Descripcion.leaveFocusColor = System.Drawing.Color.White;
            this.edt_Descripcion.Location = new System.Drawing.Point(282, 42);
            this.edt_Descripcion.LongitudTexto = 200;
            this.edt_Descripcion.mensajeExisteDatoSP = "";
            this.edt_Descripcion.mensajeNoExisteDatoSP = "";
            this.edt_Descripcion.Name = "edt_Descripcion";
            this.edt_Descripcion.nombreDS = null;
            this.edt_Descripcion.nombreExisteDatoSP = "";
            this.edt_Descripcion.nombreNoExisteDatoSP = "";
            this.edt_Descripcion.nombreSP = "";
            this.edt_Descripcion.parametrosExisteDatoSP = "";
            this.edt_Descripcion.parametrosNoExisteDatoSP = "";
            this.edt_Descripcion.parametrosSP = "";
            this.edt_Descripcion.PosicionCampo = 1;
            this.edt_Descripcion.PosicionCampoTexto = 1;
            this.edt_Descripcion.PosicionValue = 1;
            this.edt_Descripcion.resaltarCampoOmitido = false;
            this.edt_Descripcion.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.edt_Descripcion.Size = new System.Drawing.Size(422, 21);
            this.edt_Descripcion.TabIndex = 3;
            this.edt_Descripcion.tipoAyuda = gnUserControl.gnTextBox.Ayuda.SinAyudaInicial;
            this.edt_Descripcion.tipoDato = gnUserControl.gnTextBox.Tipo.Ninguno;
            this.edt_Descripcion.tipoDatoC = gnUserControl.gnTextBox.TipoC.Ninguno;
            this.edt_Descripcion.tipoextraccion = gnUserControl.gnTextBox.TipoExtra.StoredProcedure;
            this.edt_Descripcion.valorDevueltoVarios = "";
            this.edt_Descripcion.ValorDigitado = "";
            // 
            // CLabel3
            // 
            this.CLabel3.AutoSize = true;
            this.CLabel3.BackColor = System.Drawing.Color.Transparent;
            this.CLabel3.Location = new System.Drawing.Point(24, 47);
            this.CLabel3.Name = "CLabel3";
            this.CLabel3.Size = new System.Drawing.Size(101, 13);
            this.CLabel3.TabIndex = 35;
            this.CLabel3.Text = "Tipo Procedimiento:";
            // 
            // cbo_Version
            // 
            this.cbo_Version.BackColor = System.Drawing.Color.White;
            this.cbo_Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Version.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.cbo_Version.FormattingEnabled = true;
            this.cbo_Version.leaveFocusColor = System.Drawing.Color.White;
            this.cbo_Version.Location = new System.Drawing.Point(330, 12);
            this.cbo_Version.Name = "cbo_Version";
            this.cbo_Version.nombreDS = null;
            this.cbo_Version.nombreSP = "";
            this.cbo_Version.parametrosSP = "";
            this.cbo_Version.resaltarCampoOmitido = false;
            this.cbo_Version.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.cbo_Version.Size = new System.Drawing.Size(128, 21);
            this.cbo_Version.TabIndex = 1;
            this.cbo_Version.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // CLabel1
            // 
            this.CLabel1.AutoSize = true;
            this.CLabel1.BackColor = System.Drawing.Color.Transparent;
            this.CLabel1.Location = new System.Drawing.Point(279, 15);
            this.CLabel1.Name = "CLabel1";
            this.CLabel1.Size = new System.Drawing.Size(45, 13);
            this.CLabel1.TabIndex = 33;
            this.CLabel1.Text = "Versión:";
            // 
            // cbo_PeriodoProceso
            // 
            this.cbo_PeriodoProceso.BackColor = System.Drawing.Color.White;
            this.cbo_PeriodoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_PeriodoProceso.enterFocusColor = System.Drawing.Color.LemonChiffon;
            this.cbo_PeriodoProceso.FormattingEnabled = true;
            this.cbo_PeriodoProceso.leaveFocusColor = System.Drawing.Color.White;
            this.cbo_PeriodoProceso.Location = new System.Drawing.Point(126, 14);
            this.cbo_PeriodoProceso.Name = "cbo_PeriodoProceso";
            this.cbo_PeriodoProceso.nombreDS = null;
            this.cbo_PeriodoProceso.nombreSP = "";
            this.cbo_PeriodoProceso.parametrosSP = "";
            this.cbo_PeriodoProceso.resaltarCampoOmitido = false;
            this.cbo_PeriodoProceso.resaltarCampoOmitidoColor = System.Drawing.Color.LightCoral;
            this.cbo_PeriodoProceso.Size = new System.Drawing.Size(128, 21);
            this.cbo_PeriodoProceso.TabIndex = 0;
            this.cbo_PeriodoProceso.tipoConsumo = gnUserControl.gnComboBox.Tipo.DataSet;
            // 
            // CLabel2
            // 
            this.CLabel2.AutoSize = true;
            this.CLabel2.BackColor = System.Drawing.Color.Transparent;
            this.CLabel2.Location = new System.Drawing.Point(37, 17);
            this.CLabel2.Name = "CLabel2";
            this.CLabel2.Size = new System.Drawing.Size(86, 13);
            this.CLabel2.TabIndex = 31;
            this.CLabel2.Text = "Año de Proceso:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "chart_gray_bg.jpg");
            // 
            // ultraPrintPreviewDialog1
            // 
            this.ultraPrintPreviewDialog1.Name = "ultraPrintPreviewDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "doc1";
            // 
            // Frm_AvanceItemPac_Gantt_Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 597);
            this.Controls.Add(this.UltraGroupBox1);
            this.Name = "Frm_AvanceItemPac_Gantt_Grafico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gantt";
            this.Load += new System.EventHandler(this.Frm_AvanceItemPac_Gantt_Grafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox1)).EndInit();
            this.UltraGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UltraGroupBox3)).EndInit();
            this.UltraGroupBox3.ResumeLayout(false);
            this.UltraGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraChart1)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_Filtro)).EndInit();
            this.Grp_Filtro.ResumeLayout(false);
            this.Grp_Filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Descripcion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox1;
        internal Infragistics.Win.Misc.UltraGroupBox UltraGroupBox3;
        private Infragistics.Win.UltraWinChart.UltraChart ultraChart1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripComboBox cbo_TipoImagen;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton btn_Salvar;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton btn_SalvarTransparencia;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripButton btn_Imprimir;
        internal Infragistics.Win.Misc.UltraGroupBox Grp_Filtro;
        internal gnUserControl.gnMaskedTextBox Txt_NumProcedimiento;
        internal System.Windows.Forms.Button btn_Mostrar;
        internal gnUserControl.gnTextBox edt_Descripcion;
        internal GUID.wclControles.cLabel CLabel3;
        internal gnUserControl.gnComboBox cbo_Version;
        internal GUID.wclControles.cLabel CLabel1;
        internal gnUserControl.gnComboBox cbo_PeriodoProceso;
        internal GUID.wclControles.cLabel CLabel2;
        private System.Windows.Forms.ImageList imageList1;
        private Infragistics.Win.Printing.UltraPrintPreviewDialog ultraPrintPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}