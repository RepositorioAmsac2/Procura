using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGantt;
using DevExpress.LookAndFeel;

namespace WINlogistica
{
    public partial class Form_Gantt : DevExpress.XtraEditors.XtraForm
    {
        //private SRsafnet.SAFnetEClient objWCF = new SRsafnet.SAFnetEClient();
        private Service.Data objDATA = new Service.Data();
        private DateTime dateFecInicial = DateTime.Now;

        List<Model.Gantt> LG = new List<Model.Gantt>();
        private DataSet DS_Gantt;
        private Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();

        public Form_Gantt()
        {
            InitializeComponent();
        }

        public void ShowMe(string strNumProcedimiento)
        {
            if (MyStuff.UsaWCF == true)
            {
                //jesus
            }
            else
            {
                DS_Gantt = objDATA.Reporte_Pac_Paso_Gantt(strNumProcedimiento);
                MPD = objDATA.Recupera_ProcesoLogistico_Detalle_Codigo(strNumProcedimiento);
            }

            Color striplineColor = Color.FromArgb(109, 39, 57);
            Color striplineColorx = Color.FromArgb(78, 100, 37);
            ganttControl1.OptionsView.CriticalPathHighlightMode = DevExpress.XtraGantt.CriticalPathHighlightMode.Single;
            ganttControl1.Appearance.CriticalPathTask.BackColor = striplineColor;
            ganttControl1.Appearance.CriticalPathDependency.BackColor = striplineColorx;
            ganttControl1.AppearancePrint.CriticalPathDependency.BackColor = striplineColorx;
            ganttControl1.AppearancePrint.CriticalPathTask.BackColor = striplineColor;

            ganttControl1.TreeListMappings.KeyFieldName = "iCodTipoPaso";
            ganttControl1.TreeListMappings.ParentFieldName = "iIdPaso";
            //ganttControl1.ChartMappings.TextFieldName = "vDescripcionTipoPaso";
            ganttControl1.ChartMappings.TextFieldName = "vDesPaso";
            ganttControl1.ChartMappings.StartDateFieldName = "dFecInicio";
            ganttControl1.ChartMappings.FinishDateFieldName = "dFecFinal";
            ganttControl1.ChartMappings.BaselineStartDateFieldName = "dFecInicio";
            ganttControl1.ChartMappings.BaselineFinishDateFieldName = "dFecFinal";
            ganttControl1.ChartMappings.PredecessorsFieldName = "iPredecesora";
            ganttControl1.ChartMappings.ProgressFieldName = "iCompletado";

            ganttControl1.OptionsView.ShowBaselines = true;
            ganttControl1.DataSource = DS_Gantt.Tables[0];
            ganttControl1.ExpandAll();

            dateFecInicial = Convert.ToDateTime(DS_Gantt.Tables[1].Rows[0][0]);

        }

        private void Form_Gantt_Load(object sender, EventArgs e)
        {
        }

        
        private void ganttControl1_CustomDrawTimescaleColumn(object sender, DevExpress.XtraGantt.CustomDrawTimescaleColumnEventArgs e)
        {
            //DateTime date1 = new DateTime(2023, 2, 12, 8, 30, 52);
            DateTime date1 = new DateTime();
            date1 = dateFecInicial;

            GanttTimescaleColumn column = e.Column;
            if (column.StartDate <= date1 && column.FinishDate >= date1)
            {
                e.DrawBackground();
                float x = (float)e.GetPosition(date1); float width = 4;
                RectangleF deadLineRect = new RectangleF(x, column.Bounds.Y, width, column.Bounds.Height);
                e.Cache.FillRectangle(DXSkinColors.FillColors.Danger, deadLineRect);
                e.DrawHeader();
                e.Handled = true;
            }
        }
        HashSet<int> tasks = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        private void ganttControl1_CustomDrawTask(object sender, CustomDrawTaskEventArgs e)
        {
            int taskId = Convert.ToInt32(e.Node.GetValue("iIdPaso"));
            if (tasks.Contains(taskId))
            {
                e.Appearance.BackColor = DXSkinColors.FillColors.Warning;
                e.Appearance.ProgressColor = DXSkinColors.FillColors.Warning;
            }
        }
        HashSet<int> criticalPathIds = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

        private void ganttControl1_CustomTaskDisplayText(object sender, CustomTaskDisplayTextEventArgs e)
        {
            int taskId = Convert.ToInt32(e.Node.GetValue("iIdPaso"));
            if (criticalPathIds.Contains(taskId))
            {
                e.InsideText = "Alta";
            }
            else
            {
                //e.RightText = string.Empty;
                e.InsideText = "Baja";
            }
        }

        private void ganttControl1_TaskPopupMenuShowing(object sender, GanttTaskPopupMenuShowingEventArgs e)
        {
            try
            {
                if (e.Node == null)
                {
                    XtraMessageBox.Show("Seleccione Item", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    e.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Detalle", (ss, ee) => { XtraMessageBox.Show(e.Node.GetText(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information); }));
                }
            }
            catch (Exception)
            {
            }
        }

        private void ganttControl1_TaskToolTipShowing(object sender, GanttTaskToolTipShowingEventArgs e)
        {
            try
            {
                e.Text = e.Node.GetText();
            }
            catch (Exception)
            {
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}