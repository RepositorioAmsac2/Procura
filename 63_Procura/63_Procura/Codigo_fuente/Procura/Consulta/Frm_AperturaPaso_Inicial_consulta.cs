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
    public partial class Frm_AperturaPaso_Inicial_consulta : Form
    {
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        Service.Data sdl = new Service.Data();
        public Frm_AperturaPaso_Inicial_consulta()
        {
            InitializeComponent();
        }

        public void ShowMe(string strNumProcedimiento,
                            int intIdPac_Detalle_Paso_Apertura
                          )
            {
            Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();
            if (MyStuff.UsaWCF == true)
            {
                MPD = objWCF.Recupera_Pac_Detalle_Codigo(strNumProcedimiento);
            }
            else
            {
                MPD = sdl.Recupera_ProcesoLogistico_Detalle_Codigo(strNumProcedimiento);
            }
            

            this.txt_AñoProceso.Value = MPD.cAñoProceso;
            this.txt_Version.Value = MPD.cVersion;
            this.Txt_NumProcedimiento.Text = MPD.cNumProcedimiento;
            this.edt_PAC.Value = MPD.tDesContratacion;
            this.txt_PrecioEstimado.Value = String.Format("{0:0,0.00}", MPD.fPrecioEstimado);

            Model.ProcesoLogistico_Paso_Apertura MPPA = new Model.ProcesoLogistico_Paso_Apertura();

            Model.ProcesoLogistico_Paso MPP = new Model.ProcesoLogistico_Paso();
            if (MyStuff.UsaWCF == true)
            {
                MPPA = objWCF.Recupera_Pac_Paso_Apertura(intIdPac_Detalle_Paso_Apertura);
                MPP = objWCF.Recupera_Pac_Paso(MPPA.iIdProcesoLogistico_Paso);
            }
            else
            {
                MPPA = sdl.Recupera_ProcesoLogistico_Paso_Apertura(intIdPac_Detalle_Paso_Apertura);
                MPP = sdl.Recupera_ProcesoLogistico_Paso(MPPA.iIdProcesoLogistico_Paso);
            }
            

            if (MPP.iIdProcesoLogistico_Paso > 0)
            {
                this.txt_CodPaso.Value = MPP.iIdPaso;

                Model.Paso MP = new Model.Paso();

                if (MyStuff.UsaWCF == true)
                {
                }
                else
                {
                    MP = sdl.Recupera_Paso(MPP.iIdPaso) ;
                }
                

                this.txt_DesPaso.Value = MP.vDesPaso;
                this.dtp_FecInicio.Value = MPP.dFecInicio;
                this.dtp_FecFinal.Value = MPP.dFecFinal;
                this.dtp_Apertura.Value = MPPA.dFecApertura;
                this.edt_Nota.Value = MPPA.tNota;
            }
            this.ShowDialog();
        }

        private void Frm_AperturaPaso_Inicial_consulta_Load(object sender, EventArgs e)
        {

        }
    }
}
