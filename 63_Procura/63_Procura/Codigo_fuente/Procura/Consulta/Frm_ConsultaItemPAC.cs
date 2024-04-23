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
    public partial class Frm_ConsultaItemPAC : Form
    {
        private Service.Data SPD = new Service.Data();

        private Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();
        Infragistics.Win.UltraWinGrid.UltraGrid m_Grid;

        private int intIdPac_Detalle = 0;
        private bool blnActualizaAdjunto = false;
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public Frm_ConsultaItemPAC()
        {
            InitializeComponent();
        }

        public void ShowMe(int iIdPac_Detalle,
                           Infragistics.Win.UltraWinGrid.UltraGrid Grid,
                           bool bActualizaAdjunto = false
                          )
        {
               
            blnActualizaAdjunto = bActualizaAdjunto;
            intIdPac_Detalle = iIdPac_Detalle;
            if (MyStuff.UsaWCF == true)
            {
                MPD = objWCF.Recupera_Pac_Detalle(intIdPac_Detalle);
            }
            else
            {
                MPD = SPD.Recupera_ProcesoLogistico_Detalle(intIdPac_Detalle);
            }
            

            this.MostrarDatos(MPD);

            m_Grid = Grid;

            this.ShowDialog();

        }

        private void MostrarDatos( Model.ProcesoLogistico_Detalle  obj )
        {
            this.Txt_AñoProceso.Value = obj.cAñoProceso;
            this.Txt_Version.Value = obj.cVersion;
            this.Txt_NumProcedimiento.Text = obj.cNumProcedimiento;
            this.Txt_CodPac.Text = obj.cCodProcesoLogistico;
            this.Txt_TipoProceso.Value = obj.vDesTipoProceso;
            this.Txt_ObjetoContratacion.Value = obj.vDesObjetoContratacion;
            this.Edt_Descripcion.Value = obj.tDesContratacion;
            this.Txt_UnidadMedida.Value = obj.vDesUnidadMedida;
            this.Txt_Cantidad.Value = String.Format("{0:0}", obj.fCantidad);
            this.Txt_PrecioEstimado.Value = Convert.ToDecimal( obj.fPrecioEstimado );
            this.Txt_TipoMoneda.Value = obj.vNomTipoMoneda;
            this.Txt_FuenteFinanciamiento.Value = obj.vDesTipoFuenteFinanciamiento;
            this.Dtp_FechaPrevista.Value = obj.dFechaPrevista;
            this.Txt_TipoAdquisicion.Value = obj.vDesTipoAdquisicion;
            this.Txt_ModalidadSeleccion.Value = obj.vDesModalidadSeleccion;
            this.Txt_CodCentro.Value = obj.cCodCentro;
            this.Txt_DesCentro.Value = obj.vNomCentro;
            this.Txt_CodCentroGestor.Value = obj.cCodCentroGestor;
            this.Txt_NomCentroGestor.Value = obj.vNomCentroGestor;
            this.Edt_Obervacion.Value = obj.tObservacion;
        }

        private void Btn_PasosProceso_Click(object sender, EventArgs e)
        {
            if (blnActualizaAdjunto == true)
            {
                Frm_ActualizaPasoPAC frm = new Frm_ActualizaPasoPAC();
                frm.ShowMe(MPD.cNumProcedimiento, 0);
            }
            else
            {
                Frm_ConsultaPasoPAC frm = new Frm_ConsultaPasoPAC();
                frm.ShowMe(MPD.cNumProcedimiento);
            }
        }

        private void Btn_Comite_Click(object sender, EventArgs e)
        {
            WINlogistica.Frm_ConsultaComite frm = new WINlogistica.Frm_ConsultaComite();
            frm.ShowMe(MPD.cNumProcedimiento);
        }

        private void Btn_Adjuntos_Click(object sender, EventArgs e)
        {
            if (blnActualizaAdjunto == true)
            {
                WINlogistica.Frm_Pac_Adjunto frm = new WINlogistica.Frm_Pac_Adjunto();

                frm.ShowMe(MPD.cNumProcedimiento );

            }
            else
            {
                WINlogistica.Frm_ConsultaPac_Adjunto frm = new WINlogistica.Frm_ConsultaPac_Adjunto();

                frm.ShowMe(MPD.cNumProcedimiento);

            }
        }

        private void Btn_Duracion_Click(object sender, EventArgs e)
        {
            WINlogistica.Frm_ConsultaDuracionPAC frm = new WINlogistica.Frm_ConsultaDuracionPAC();
            frm.ShowMe(MPD.cAñoProceso, MPD.cVersion, MPD.cNumProcedimiento);
        }

        private void Frm_ConsultaItemPAC_Load(object sender, EventArgs e)
        {

        }
    }
}
