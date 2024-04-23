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
    public partial class Frm_AperturaProceso_Inicial_Consulta : Form
    {
        Service.Data sdl = new Service.Data();
        Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();
        

        Model.ProcesoLogistico_Paso_Apertura MPDPA = new Model.ProcesoLogistico_Paso_Apertura();

        Model.ProcesoLogistico_Paso MPDP = new Model.ProcesoLogistico_Paso();

        Model.Paso MP = new Model.Paso();
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public Frm_AperturaProceso_Inicial_Consulta()
        {
            InitializeComponent();
        }

        public void ShowMe( string strNumProcedimiento,
                            int intIdPac_Paso_Apertura
                          )
            {
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
            this.txt_CodPac.Value = MPD.cCodProcesoLogistico;
            this.edt_PAC.Value = MPD.tDesContratacion;
            this.txt_PrecioEstimado.Value = String.Format("{0:0,0.00}", MPD.fPrecioEstimado);

            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                MPDPA = sdl.Recupera_ProcesoLogistico_Paso_Apertura(intIdPac_Paso_Apertura);
                MPDP = sdl.Recupera_ProcesoLogistico_Paso(MPDPA.iIdProcesoLogistico_Paso);
            }
            

            if (MPDPA.iIdProcesoLogistico_Paso > 0)
            {
                this.txt_CodPaso.Value = MPDP.iIdPaso;
                if (MyStuff.UsaWCF == true)
                {
                }
                else
                {
                    MP = sdl.Recupera_Paso( MPDP.iIdPaso
                                                 );
                }
                
                this.txt_DesPaso.Value = MP.vDesPaso;
                this.dtp_FecInicio.Value = MPDP.dFecInicio;
                this.dtp_FecFinal.Value = MPDP.dFecFinal;
                this.dtp_Apertura.Value = MPDPA.dFecApertura;
                this.edt_Nota.Value = MPDPA.tNota;
            }
            this.ShowDialog();
        }

        private void Frm_AperturaProceso_Inicial_Consulta_Load(object sender, EventArgs e)
        {

        }
    }
}
