using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
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
    public partial class Frm_NuevoInicioActividad : Form
    {
        private bool blnMuestaFromato = true;
        private String strFecInicioActividad = "";
        public Frm_NuevoInicioActividad()
        {
            InitializeComponent();
        }

        private void FormatoGrid()
        {
            //Infragistics.Win.UltraWinGrid.UltraGridBand oBand;
            //Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn;
            this.Grd_Entregables.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_Entregables.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.Grd_Entregables.DisplayLayout.Bands[0];
            oBand0 = this.Grd_Entregables.DisplayLayout.Bands[0];
            oBand0.Columns[1].Header.Caption = "F.Inicio";
            oBand0.Columns[1].Width = 100;
            oBand0.Columns[2].Header.Caption = "Nota";
            oBand0.Columns[2].Width = 500;

            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[3].Hidden = true;
        }

        

        private void ultraNumericEditor1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Ajuste_B_Click(object sender, EventArgs e)
        {

        }

        private void Frm_NuevoEntregable_Load(object sender, EventArgs e)
        {

        }

        private void Btn_NuevoAdicional_Click(object sender, EventArgs e)
        {
            string strCodCompañia = MyStuff.CodigoEmpresa;
            string strNroContrato = Convert.ToString(this.Txt_numContrato.Value);

            WINlogistica.Frm_NuevoInicioActividad_D frm = new WINlogistica.Frm_NuevoInicioActividad_D();
            frm.ShowMe(strCodCompañia,
                        strNroContrato,
                        Grd_Entregables
                      );

        }

        private void Dtp_FecInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Txt_DesTipoAdquisicion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Busqueda_Click(object sender, EventArgs e)
        {
            WINlogistica.Frm_Ayuda_Contrato frm = new WINlogistica.Frm_Ayuda_Contrato();
            frm.ShowMe(MyStuff.CodigoEmpresa);
            if (frm.blnEligio == true)
            {
                this.Txt_numContrato.Value = frm.strCodContrato;
                string strCodCompañia = MyStuff.CodigoEmpresa;
                string strNumeroContrato = Convert.ToString(this.Txt_numContrato.Value);
                Service.Data SL = new Service.Data();
                Model.ContratoCabecera MCC = new Model.ContratoCabecera();
                MCC = SL.recupera_Contrato(strCodCompañia,
                                                      strNumeroContrato
                                                    );

                this.Edt_DesContrato.Value = MCC.TDesContrato;
                this.Txt_MontoTotal.Value = MCC.FprecioUnitario_Local + MCC.Fimpuesto_Local;
                this.Dtp_FecInicio.Value = MCC.DFecSuscripcionContrato;
                this.Txt_DesTipoAdquisicion.Value = MCC.VDesObjetoContratacion;
                strFecInicioActividad = Convert.ToString(MCC.DFecSuscripcionContrato);

                if (MCC.bTieneMontosAdicionales == true)
                {
                    this.Btn_Adicionales.Visible = true;
                }
                else
                {
                    this.Btn_Adicionales.Visible = false;
                }

                this.Grd_Entregables.DataSource = SL.lista_ContratoInicioActividad(strCodCompañia,
                                                                                strNumeroContrato
                                                                             );
                if (blnMuestaFromato == true)
                {
                    blnMuestaFromato = false;
                    this.FormatoGrid();
                }

            }
        }
    }
}
