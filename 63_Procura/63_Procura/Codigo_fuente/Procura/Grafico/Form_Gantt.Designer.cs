﻿namespace WINlogistica
{
    partial class Form_Gantt
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
            this.ganttControl1 = new DevExpress.XtraGantt.GanttControl();
            this.treeListColumnvDesPaso = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumndFecInicio = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumndFecFinal = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumnvRecurso = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ganttAllowResizeBarCheckItem1 = new DevExpress.XtraGantt.Ribbon.GanttAllowResizeBarCheckItem();
            this.ganttPanelVisibilityBarSubItem1 = new DevExpress.XtraGantt.Ribbon.GanttPanelVisibilityBarSubItem();
            this.ganttPanelVisibilityDefaultBarCheckItem1 = new DevExpress.XtraGantt.Ribbon.GanttPanelVisibilityDefaultBarCheckItem();
            this.ganttPanelVisibilityBothBarCheckItem1 = new DevExpress.XtraGantt.Ribbon.GanttPanelVisibilityBothBarCheckItem();
            this.ganttPanelVisibilityChartBarCheckItem1 = new DevExpress.XtraGantt.Ribbon.GanttPanelVisibilityChartBarCheckItem();
            this.ganttPanelVisibilityTreeBarCheckItem1 = new DevExpress.XtraGantt.Ribbon.GanttPanelVisibilityTreeBarCheckItem();
            this.ganttFixedPanelBarSubItem1 = new DevExpress.XtraGantt.Ribbon.GanttFixedPanelBarSubItem();
            this.ganttFixedPanelDefaultBarCheckItem1 = new DevExpress.XtraGantt.Ribbon.GanttFixedPanelDefaultBarCheckItem();
            this.ganttFixedPanelNoneBarCheckItem1 = new DevExpress.XtraGantt.Ribbon.GanttFixedPanelNoneBarCheckItem();
            this.ganttFixedPanelChartBarCheckItem1 = new DevExpress.XtraGantt.Ribbon.GanttFixedPanelChartBarCheckItem();
            this.ganttFixedPanelTreeBarCheckItem1 = new DevExpress.XtraGantt.Ribbon.GanttFixedPanelTreeBarCheckItem();
            this.ganttViewRibbonPage1 = new DevExpress.XtraGantt.Ribbon.GanttViewRibbonPage();
            this.ganttSplitViewRibbonPageGroup1 = new DevExpress.XtraGantt.Ribbon.GanttSplitViewRibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ganttBarController1 = new DevExpress.XtraGantt.Ribbon.GanttBarController();
            ((System.ComponentModel.ISupportInitialize)(this.ganttControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganttBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // ganttControl1
            // 
            this.ganttControl1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumnvDesPaso,
            this.treeListColumndFecInicio,
            this.treeListColumndFecFinal,
            this.treeListColumnvRecurso});
            this.ganttControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ganttControl1.Location = new System.Drawing.Point(0, 150);
            this.ganttControl1.Name = "ganttControl1";
            this.ganttControl1.Size = new System.Drawing.Size(921, 335);
            this.ganttControl1.SplitterPosition = 386;
            this.ganttControl1.TabIndex = 0;
            this.ganttControl1.ToolTipController = this.toolTipController1;
            this.ganttControl1.TreeListMappings.KeyFieldName = "iCodTipoPaso";
            this.ganttControl1.TreeListMappings.ParentFieldName = "iIdPaso";
            this.ganttControl1.CustomDrawTimescaleColumn += new DevExpress.XtraGantt.CustomDrawTimescaleColumnEventHandler(this.ganttControl1_CustomDrawTimescaleColumn);
            this.ganttControl1.CustomDrawTask += new DevExpress.XtraGantt.CustomDrawTaskEventHandler(this.ganttControl1_CustomDrawTask);
            this.ganttControl1.CustomTaskDisplayText += new DevExpress.XtraGantt.CustomTaskDisplayTextEventHandler(this.ganttControl1_CustomTaskDisplayText);
            this.ganttControl1.TaskToolTipShowing += new DevExpress.XtraGantt.GanttTaskToolTipShowingEventHandler(this.ganttControl1_TaskToolTipShowing);
            this.ganttControl1.TaskPopupMenuShowing += new DevExpress.XtraGantt.GanttTaskPopupMenuShowingEventHandler(this.ganttControl1_TaskPopupMenuShowing);
            // 
            // treeListColumnvDesPaso
            // 
            this.treeListColumnvDesPaso.Caption = "Actividad";
            this.treeListColumnvDesPaso.FieldName = "vDesPaso";
            this.treeListColumnvDesPaso.Name = "treeListColumnvDesPaso";
            this.treeListColumnvDesPaso.Visible = true;
            this.treeListColumnvDesPaso.VisibleIndex = 0;
            this.treeListColumnvDesPaso.Width = 197;
            // 
            // treeListColumndFecInicio
            // 
            this.treeListColumndFecInicio.Caption = "Fecha de Inicio";
            this.treeListColumndFecInicio.FieldName = "dFecInicio";
            this.treeListColumndFecInicio.Name = "treeListColumndFecInicio";
            this.treeListColumndFecInicio.Visible = true;
            this.treeListColumndFecInicio.VisibleIndex = 1;
            this.treeListColumndFecInicio.Width = 83;
            // 
            // treeListColumndFecFinal
            // 
            this.treeListColumndFecFinal.Caption = "Fecha de Culminación";
            this.treeListColumndFecFinal.FieldName = "dFecFinal";
            this.treeListColumndFecFinal.Name = "treeListColumndFecFinal";
            this.treeListColumndFecFinal.Visible = true;
            this.treeListColumndFecFinal.VisibleIndex = 2;
            this.treeListColumndFecFinal.Width = 102;
            // 
            // treeListColumnvRecurso
            // 
            this.treeListColumnvRecurso.Caption = "Recursos";
            this.treeListColumnvRecurso.FieldName = "vRecurso";
            this.treeListColumnvRecurso.Name = "treeListColumnvRecurso";
            this.treeListColumnvRecurso.Visible = true;
            this.treeListColumnvRecurso.VisibleIndex = 3;
            this.treeListColumnvRecurso.Width = 43;
            // 
            // toolTipController1
            // 
            this.toolTipController1.Rounded = true;
            this.toolTipController1.ShowBeak = true;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AutoHideEmptyItems = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.ganttAllowResizeBarCheckItem1,
            this.ganttPanelVisibilityBarSubItem1,
            this.ganttPanelVisibilityDefaultBarCheckItem1,
            this.ganttPanelVisibilityBothBarCheckItem1,
            this.ganttPanelVisibilityChartBarCheckItem1,
            this.ganttPanelVisibilityTreeBarCheckItem1,
            this.ganttFixedPanelBarSubItem1,
            this.ganttFixedPanelDefaultBarCheckItem1,
            this.ganttFixedPanelNoneBarCheckItem1,
            this.ganttFixedPanelChartBarCheckItem1,
            this.ganttFixedPanelTreeBarCheckItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ganttViewRibbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(921, 150);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // ganttAllowResizeBarCheckItem1
            // 
            this.ganttAllowResizeBarCheckItem1.Id = 1;
            this.ganttAllowResizeBarCheckItem1.Name = "ganttAllowResizeBarCheckItem1";
            // 
            // ganttPanelVisibilityBarSubItem1
            // 
            this.ganttPanelVisibilityBarSubItem1.Id = 2;
            this.ganttPanelVisibilityBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ganttPanelVisibilityDefaultBarCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.ganttPanelVisibilityBothBarCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.ganttPanelVisibilityChartBarCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.ganttPanelVisibilityTreeBarCheckItem1)});
            this.ganttPanelVisibilityBarSubItem1.Name = "ganttPanelVisibilityBarSubItem1";
            // 
            // ganttPanelVisibilityDefaultBarCheckItem1
            // 
            this.ganttPanelVisibilityDefaultBarCheckItem1.Id = 3;
            this.ganttPanelVisibilityDefaultBarCheckItem1.Name = "ganttPanelVisibilityDefaultBarCheckItem1";
            // 
            // ganttPanelVisibilityBothBarCheckItem1
            // 
            this.ganttPanelVisibilityBothBarCheckItem1.Id = 4;
            this.ganttPanelVisibilityBothBarCheckItem1.Name = "ganttPanelVisibilityBothBarCheckItem1";
            // 
            // ganttPanelVisibilityChartBarCheckItem1
            // 
            this.ganttPanelVisibilityChartBarCheckItem1.Id = 5;
            this.ganttPanelVisibilityChartBarCheckItem1.Name = "ganttPanelVisibilityChartBarCheckItem1";
            // 
            // ganttPanelVisibilityTreeBarCheckItem1
            // 
            this.ganttPanelVisibilityTreeBarCheckItem1.Id = 6;
            this.ganttPanelVisibilityTreeBarCheckItem1.Name = "ganttPanelVisibilityTreeBarCheckItem1";
            // 
            // ganttFixedPanelBarSubItem1
            // 
            this.ganttFixedPanelBarSubItem1.Id = 7;
            this.ganttFixedPanelBarSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ganttFixedPanelDefaultBarCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.ganttFixedPanelNoneBarCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.ganttFixedPanelChartBarCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.ganttFixedPanelTreeBarCheckItem1)});
            this.ganttFixedPanelBarSubItem1.Name = "ganttFixedPanelBarSubItem1";
            // 
            // ganttFixedPanelDefaultBarCheckItem1
            // 
            this.ganttFixedPanelDefaultBarCheckItem1.Id = 8;
            this.ganttFixedPanelDefaultBarCheckItem1.Name = "ganttFixedPanelDefaultBarCheckItem1";
            // 
            // ganttFixedPanelNoneBarCheckItem1
            // 
            this.ganttFixedPanelNoneBarCheckItem1.Id = 9;
            this.ganttFixedPanelNoneBarCheckItem1.Name = "ganttFixedPanelNoneBarCheckItem1";
            // 
            // ganttFixedPanelChartBarCheckItem1
            // 
            this.ganttFixedPanelChartBarCheckItem1.Id = 10;
            this.ganttFixedPanelChartBarCheckItem1.Name = "ganttFixedPanelChartBarCheckItem1";
            // 
            // ganttFixedPanelTreeBarCheckItem1
            // 
            this.ganttFixedPanelTreeBarCheckItem1.Id = 11;
            this.ganttFixedPanelTreeBarCheckItem1.Name = "ganttFixedPanelTreeBarCheckItem1";
            // 
            // ganttViewRibbonPage1
            // 
            this.ganttViewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ganttSplitViewRibbonPageGroup1});
            this.ganttViewRibbonPage1.Name = "ganttViewRibbonPage1";
            // 
            // ganttSplitViewRibbonPageGroup1
            // 
            this.ganttSplitViewRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ganttSplitViewRibbonPageGroup1.ItemLinks.Add(this.ganttAllowResizeBarCheckItem1);
            this.ganttSplitViewRibbonPageGroup1.ItemLinks.Add(this.ganttPanelVisibilityBarSubItem1);
            this.ganttSplitViewRibbonPageGroup1.ItemLinks.Add(this.ganttFixedPanelBarSubItem1);
            this.ganttSplitViewRibbonPageGroup1.Name = "ganttSplitViewRibbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 485);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(921, 27);
            // 
            // ganttBarController1
            // 
            this.ganttBarController1.BarItems.Add(this.ganttAllowResizeBarCheckItem1);
            this.ganttBarController1.BarItems.Add(this.ganttPanelVisibilityDefaultBarCheckItem1);
            this.ganttBarController1.BarItems.Add(this.ganttPanelVisibilityBothBarCheckItem1);
            this.ganttBarController1.BarItems.Add(this.ganttPanelVisibilityChartBarCheckItem1);
            this.ganttBarController1.BarItems.Add(this.ganttPanelVisibilityTreeBarCheckItem1);
            this.ganttBarController1.BarItems.Add(this.ganttPanelVisibilityBarSubItem1);
            this.ganttBarController1.BarItems.Add(this.ganttFixedPanelDefaultBarCheckItem1);
            this.ganttBarController1.BarItems.Add(this.ganttFixedPanelNoneBarCheckItem1);
            this.ganttBarController1.BarItems.Add(this.ganttFixedPanelChartBarCheckItem1);
            this.ganttBarController1.BarItems.Add(this.ganttFixedPanelTreeBarCheckItem1);
            this.ganttBarController1.BarItems.Add(this.ganttFixedPanelBarSubItem1);
            this.ganttBarController1.Control = this.ganttControl1;
            // 
            // Form_Gantt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 512);
            this.Controls.Add(this.ganttControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.ShowIcon = false;
            this.MinimizeBox = false;
            this.Name = "Form_Gantt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gantt MS";
            this.Load += new System.EventHandler(this.Form_Gantt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ganttControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganttBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGantt.GanttControl ganttControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraGantt.Ribbon.GanttAllowResizeBarCheckItem ganttAllowResizeBarCheckItem1;
        private DevExpress.XtraGantt.Ribbon.GanttPanelVisibilityBarSubItem ganttPanelVisibilityBarSubItem1;
        private DevExpress.XtraGantt.Ribbon.GanttPanelVisibilityDefaultBarCheckItem ganttPanelVisibilityDefaultBarCheckItem1;
        private DevExpress.XtraGantt.Ribbon.GanttPanelVisibilityBothBarCheckItem ganttPanelVisibilityBothBarCheckItem1;
        private DevExpress.XtraGantt.Ribbon.GanttPanelVisibilityChartBarCheckItem ganttPanelVisibilityChartBarCheckItem1;
        private DevExpress.XtraGantt.Ribbon.GanttPanelVisibilityTreeBarCheckItem ganttPanelVisibilityTreeBarCheckItem1;
        private DevExpress.XtraGantt.Ribbon.GanttFixedPanelBarSubItem ganttFixedPanelBarSubItem1;
        private DevExpress.XtraGantt.Ribbon.GanttFixedPanelDefaultBarCheckItem ganttFixedPanelDefaultBarCheckItem1;
        private DevExpress.XtraGantt.Ribbon.GanttFixedPanelNoneBarCheckItem ganttFixedPanelNoneBarCheckItem1;
        private DevExpress.XtraGantt.Ribbon.GanttFixedPanelChartBarCheckItem ganttFixedPanelChartBarCheckItem1;
        private DevExpress.XtraGantt.Ribbon.GanttFixedPanelTreeBarCheckItem ganttFixedPanelTreeBarCheckItem1;
        private DevExpress.XtraGantt.Ribbon.GanttViewRibbonPage ganttViewRibbonPage1;
        private DevExpress.XtraGantt.Ribbon.GanttSplitViewRibbonPageGroup ganttSplitViewRibbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraGantt.Ribbon.GanttBarController ganttBarController1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnvDesPaso;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumndFecInicio;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumndFecFinal;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnvRecurso;
    }
}