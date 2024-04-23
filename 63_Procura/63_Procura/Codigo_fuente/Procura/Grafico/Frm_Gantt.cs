using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINlogistica
{
    public partial class Frm_Gantt: Form
    {
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        Service.Data sdl = new Service.Data();
        private Boolean blnActivarLoad = true;
        public Frm_Gantt()
        {
            InitializeComponent();
        }

        public void ShowMe( string strDescripcion,
                            string strAñoProceso,
                            string strVersion,
                            string strNumProcedimiento
                          )
        {
            this.cbo_TipoImagen.Items.Add("Png");
            this.cbo_TipoImagen.Items.Add("Bmp");
            this.cbo_TipoImagen.Items.Add("Jpeg");
            this.cbo_TipoImagen.Items.Add("Gif");
            this.blnActivarLoad = true;
            this.MostrarGrafico(strDescripcion,
                                strAñoProceso,
                                strVersion,
                                strNumProcedimiento
                                );
            this.ShowDialog();
        }
        private void Frm_AvanceItemPac_Gantt_Grafico_Load(object sender, EventArgs e)
        {
            
        }

        private void MostrarGrafico( string strDescripcion,
                                     string strAñoProceso,
                                     string strVersion,
                                     string strNumProcedimiento
                                    )
        {
            if (strDescripcion != null)
            {
                ultraChart1.Visible = true;
                DataTable dt = new DataTable();
                if (MyStuff.UsaWCF == true)
                {
                    dt = objWCF.Reporte_Pac_Paso_Gantt(strAñoProceso,
                                                strVersion,
                                                strNumProcedimiento
                                                    ).Tables[0];
                }
                else
                {
                    dt = sdl.Reporte_Pac_Paso_Gantt(strAñoProceso,
                                                strVersion,
                                                strNumProcedimiento
                                                    ).Tables[0];
                }


                this.ultraChart1.Data.DataSource = dt;
                this.ultraChart1.Data.DataBind();
                this.ultraChart1.BackgroundImage = imageList1.Images[0];

                this.ultraChart1.TitleTop.Text = strNumProcedimiento.TrimEnd() + "- " + strDescripcion.TrimEnd();
                this.ultraChart1.GanttChart.ShowCompletePercentages = true;
                this.ultraChart1.GanttChart.ShowLinks = true;
                //Me.ultraChart1.GanttChart.ShowOwners = True

                this.ultraChart1.GanttChart.ItemSpacing = Convert.ToInt32(1);
                this.ultraChart1.GanttChart.SeriesSpacing = Convert.ToInt32(1);

                //System.Drawing.Image.FromFile(Config.ImagePath + "/chart_gray_bg.jpg")

            }
            else
            {
                MessageBox.Show("Debe Elegir el Tipo de Procedimiento");
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = "untitled1." + this.cbo_TipoImagen.SelectedItem.ToString().ToLower();
            this.saveFileDialog1.Filter = this.cbo_TipoImagen.SelectedItem.ToString() + " (*." + this.cbo_TipoImagen.SelectedItem.ToString().ToLower() + ")|*." + this.cbo_TipoImagen.SelectedItem.ToString().ToLower();

            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                System.Reflection.PropertyInfo pi = typeof(System.Drawing.Imaging.ImageFormat).GetProperty(this.cbo_TipoImagen.SelectedItem.ToString());

            }
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            this.ultraPrintPreviewDialog1.Document = ultraChart1.PrintDocument;
            if (this.ultraPrintPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                this.ultraPrintPreviewDialog1.Document.Print();
            }
        }

    }
}
