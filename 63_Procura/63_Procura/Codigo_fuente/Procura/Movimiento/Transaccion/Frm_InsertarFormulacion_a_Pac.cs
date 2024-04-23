using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINlogistica.Movimiento.Transaccion
{
    public partial class Frm_InsertarFormulacion_a_Pac : Form
    {
        public Frm_InsertarFormulacion_a_Pac()
        {
            InitializeComponent();
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            string strCodCompañia = "000000";
            string strAñoProceso = MyStuff.AñoProceso;

            WINlogistica.Frm_Formulacion frm = new WINlogistica.Frm_Formulacion();

            frm.Showme(strCodCompañia,
                        strAñoProceso
                      );
            if (frm.blnEligio == true)
            {
                this.Txt_CodFuenteFinanciamiento.Value = frm.strCodFuenteFinanciamiento;
                this.Txt_NomFuenteFinanciamiento.Value = frm.strNomFuenteFinanciamiento;
                this.Txt_CodCentroCosto.Value = frm.strCodCentroCosto;
                this.Txt_NomCentroCosto.Value = frm.strNomCentroCosto;
                this.Txt_CodProyecto.Value = frm.strCodProyecto;
                this.Txt_NomProyecto.Value = frm.strNomProyecto;

                this.Txt_CodPosicionPresupuestal.Value = frm.strCodPosPre;
                this.Txt_NomPosicionPresupuestal.Value = frm.strNomPosPre;
                this.Txt_CodClasificacion.Value = frm.strCodClasificacion;
                this.Txt_NomClasificacion.Value = frm.strNomClasificacion;
                this.Txt_CodTipoGasto.Value = frm.strCodTipoGasto;
                this.Txt_NomTipoGasto.Value = frm.strNomTipoGasto;
                //this.Txt_CodFormulacion.Value = frm.strCodFormulacion;
                this.Txt_DesFormulacion.Value = frm.strDescripcion;

                this.Txt_Formulacion.Value = frm.dblImporte;

            }
        }
    }
}
