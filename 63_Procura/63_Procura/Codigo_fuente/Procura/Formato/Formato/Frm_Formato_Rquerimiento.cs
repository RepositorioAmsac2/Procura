using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINlogistica
{
    public partial class Frm_Formato_Rquerimiento : Form
    {
        //private SRgestionE.WCFgestionEClient objWCF = new SRgestionE.WCFgestionEClient();
        Service.Data sdl = new Service.Data();
        public Frm_Formato_Rquerimiento()
        {
            InitializeComponent();
        }

        public void ShowMe( string strNumRequerimiento, Boolean blnEsPasajeAereo )
        {
            DataSet DS_Requerimiento = new DataSet();

            if (MyStuff.UsaWCF == true)
            {
                //DS_Requerimiento = objWCF.Formato_Requerimiento(strNumRequerimiento);
            }
            else
            {
                DS_Requerimiento = sdl.Formato_Requerimiento(strNumRequerimiento);
            }

            Model.ParametroGestion MPG = new Model.ParametroGestion();

            if (Convert.ToString(DS_Requerimiento.Tables[0].Rows[0][6]).TrimEnd() == "B")
            {
                Formato.CrystalReport.CR_Requerimiento_Bien_Otro crpt = new Formato.CrystalReport.CR_Requerimiento_Bien_Otro();
                crpt.Database.Tables["Requerimiento_Cabecera"].SetDataSource(DS_Requerimiento.Tables[0]);
                crpt.Database.Tables["Requerimiento_Detalle"].SetDataSource(DS_Requerimiento.Tables[1]);
                crpt.Database.Tables["Paso_Requerimiento"].SetDataSource(DS_Requerimiento.Tables[2]);
                Crv_Requerimiento.ReportSource = null;
                Crv_Requerimiento.ReportSource = crpt;
            }
            else
            {
                if (blnEsPasajeAereo == false)
                {
                    Formato.CrystalReport.CR_Requerimiento_Servicio_Otro crpt = new Formato.CrystalReport.CR_Requerimiento_Servicio_Otro();
                    crpt.Database.Tables["Requerimiento_Cabecera"].SetDataSource(DS_Requerimiento.Tables[0]);
                    crpt.Database.Tables["Requerimiento_Detalle"].SetDataSource(DS_Requerimiento.Tables[1]);
                    crpt.Database.Tables["Paso_Requerimiento"].SetDataSource(DS_Requerimiento.Tables[2]);
                    Crv_Requerimiento.ReportSource = null;
                    Crv_Requerimiento.ReportSource = crpt;
                }
                else
                {
                    Formato.CrystalReport.CR_Requerimiento_Servicio_Pasaje crpt = new Formato.CrystalReport.CR_Requerimiento_Servicio_Pasaje();
                    crpt.Database.Tables["Requerimiento_Cabecera"].SetDataSource(DS_Requerimiento.Tables[0]);
                    crpt.Database.Tables["Requerimiento_Detalle"].SetDataSource(DS_Requerimiento.Tables[1]);
                    crpt.Database.Tables["Paso_Requerimiento"].SetDataSource(DS_Requerimiento.Tables[2]);
                    Crv_Requerimiento.ReportSource = null;
                    Crv_Requerimiento.ReportSource = crpt;
                }


            }


            this.ShowDialog();
        }

        private void Frm_Formato_Rquerimiento_Load(object sender, EventArgs e)
        {

        }
    }
}
