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
            this.Grp_Filtro.Visible = false;
            this.Grp_Filtro.Size = new System.Drawing.Size(0, 0);
            this.MostrarGrafico(strDescripcion,
                                strAñoProceso,
                                strVersion,
                                strNumProcedimiento
                                );
            this.ShowDialog();
        }
        private void Frm_AvanceItemPac_Gantt_Grafico_Load(object sender, EventArgs e)
        {
            if (blnActivarLoad == true)
            {
                this.cbo_TipoImagen.Items.Add("Png");
                this.cbo_TipoImagen.Items.Add("Bmp");
                this.cbo_TipoImagen.Items.Add("Jpeg");
                this.cbo_TipoImagen.Items.Add("Gif");

                this.cbo_TipoImagen.SelectedIndex = 0;

                Model.ProcesoLogistico_Version MPV = new Model.ProcesoLogistico_Version();
                if (MyStuff.UsaWCF == true)
                {
                }
                else
                {
                    this.cbo_PeriodoProceso.CargaDT(sdl.Combo_AñoProceso_Logistica().Tables[0]);
                }

                string strAñoProceso = Convert.ToString(this.cbo_PeriodoProceso.SelectedValue);
                if (MyStuff.UsaWCF == true)
                {
                    this.cbo_Version.CargaDT(objWCF.Combo_Version_Logistica(strAñoProceso).Tables[0]);
                }
                else
                {
                    this.cbo_Version.CargaDT(sdl.Combo_Version_Logistica(strAñoProceso).Tables[0]);
                }

            }
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
        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            string strAñoProceso = Convert.ToString(this.cbo_PeriodoProceso.SelectedValue);
            string strVersion = Convert.ToString(this.cbo_Version.SelectedValue);
            string strNumProcedimiento = Convert.ToString(this.Txt_NumProcedimiento.Text);
            this.MostrarGrafico( Convert.ToString( this.edt_Descripcion.Value ),
                                 strAñoProceso,
                                 strVersion,
                                 strNumProcedimiento
                                );
        }

        private void btn_SalvarTransparencia_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = "untitled1.png";
            this.saveFileDialog1.Filter = "PNG (*.png)|*.png";

            //Save the image with a transparent background
            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                //Save the image with a transparent background
                System.Drawing.Bitmap myBm = ((Bitmap)this.ultraChart1.Image.Clone());
                myBm.MakeTransparent(System.Drawing.Color.White);
                myBm.Save(this.saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
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

        private void Txt_NumProcedimiento_Leave(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(  Convert.ToString( this.Txt_NumProcedimiento.Text ) ) )
            {
                MessageBox.Show("Debe Elegir un Tipo de Procedimiento");
            }
            else
            {
                verNumeroProcedimiento(Convert.ToString(this.Txt_NumProcedimiento.Text));
                
            }
        }

        private void verNumeroProcedimiento(string strNumProcedimiento )
        {
            if (string.IsNullOrEmpty(strNumProcedimiento))
            {
                MessageBox.Show("El Tipo de Procedimiento NO debe estar vacio");
                return;
            }
            Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();

            Model.ProcesoLogistico_Eliminado MPDE = new Model.ProcesoLogistico_Eliminado();
            if (MyStuff.UsaWCF == true)
            {
                MPD = objWCF.Recupera_Pac_Detalle_Codigo(strNumProcedimiento);
            }
            else
            {
                MPD = sdl.Recupera_ProcesoLogistico_Detalle_Codigo(strNumProcedimiento);
            }
            
            if (MPD.iIdProcesoLogistico_Detalle == 0)
            {
                MessageBox.Show("El Tipo de Procedimiento NO Existe");
                return;
            }

            this.edt_Descripcion.Value = MPD.tDesContratacion;

            if (MPD.iIdProcesoLogistico_Eliminado != 0)
            {
                if(MyStuff.UsaWCF == true)
                {
                    MPDE = objWCF.Recupera_Pac_Eliminado(MPD.iIdProcesoLogistico_Eliminado);
                }
                else
                {
                    MPDE = sdl.Recupera_ProcesoLogistico_Eliminado(MPD.iIdProcesoLogistico_Eliminado);
                }
                
                MessageBox.Show("Error: El Item ha sido Excluido" + (char)(13) +
                "Fecha        : " + Convert.ToString(MPDE.dFecEliminado) + (char)(13) +
                "Documento    : " + Convert.ToString(MPDE.vDesTipoDocumento) + (char)(13) +
                "Motivo       : " + Convert.ToString(MPDE.vDesTipoMotivo) + (char)(13) +
                "Nota         : " + Convert.ToString(MPDE.tMotEliminado) + (char)(13) +
                "Excluido  por: " + Convert.ToString(MPDE.vApeEmpleado)
                       );
                this.Close();
            }
        }
    }
}
