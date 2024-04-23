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
    public partial class Frm_NuevoGarantia_D : Form
    {
        private string strCodCompañia = "";
        private string strNroContrato = "";
        public bool blnActualiza = false;
        private Infragistics.Win.UltraWinGrid.UltraGrid m_Grid;
        private Model.ContratoGarantia MEC = new Model.ContratoGarantia();
        private Model.ParametroLogistica MPL = new Model.ParametroLogistica();
        private Service.Data sl = new Service.Data();
        private DataSet DS_EntidadFinanciera = new DataSet();
        private WINlogistica.Framework FS = new WINlogistica.Framework();

        public Frm_NuevoGarantia_D()
        {
            InitializeComponent();
        }

        public void ShowMe( string cCodCompañia,
                            string cNroContrato,
                            Infragistics.Win.UltraWinGrid.UltraGrid Grid
                          )
        {
            strCodCompañia = cCodCompañia;
            strNroContrato = cNroContrato;
            m_Grid = Grid;


            this.Cbo_CodTipoGarantia.CargaDS(sl.combo_TipoGarantia());
            this.Cbo_ClaseGarantia.CargaDS(sl.combo_ClaseGarantia());

            DS_EntidadFinanciera = sl.ayuda_EntidadFinanciera(strCodCompañia);

            this.Txt_CodEntidadFinanciera.nombreDS = DS_EntidadFinanciera;

            // Datos Iniciales
            this.BlanqueoData();
            this.ShowDialog();
        }

        private void RegistroMovimiento()
        {
            try
            {
                m_Grid.DisplayLayout.Bands[0].AddNew();
                PintarDatosRegistro();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void PintarDatosRegistro()
        {
            try
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = m_Grid.ActiveRow;


                oRow.Cells[0].Value = MEC.iIdContrato_Garantia;
                oRow.Cells[1].Value = MEC.cNroGarantia;
                oRow.Cells[2].Value = Convert.ToString( MEC.tDesGarantia);
                oRow.Cells[3].Value = MEC.dFecGarantia;
                oRow.Cells[4].Value = MEC.cCodTipoGarantia;
                oRow.Cells[5].Value = Convert.ToString(this.Cbo_CodTipoGarantia.Text); ;
                oRow.Cells[6].Value = MEC.cCodClaseGarantia;
                oRow.Cells[7].Value = Convert.ToString(this.Cbo_ClaseGarantia.Text);
                if (MEC.cCodTipoGarantia.TrimEnd() == "03")
                {
                    oRow.Cells[8].Value = "";
                    oRow.Cells[9].Value = "";
                }
                else
                {
                    oRow.Cells[8].Value = Convert.ToString(this.Txt_CodEntidadFinanciera.Value);
                    oRow.Cells[9].Value = Convert.ToString(this.Txt_nomEntidadFinanciera.Value);
                }
                
                oRow.Cells[10].Value = MEC.fMontoTotal;
                oRow.Cells[11].Value = MEC.dFecInicio;
                oRow.Cells[12].Value = MEC.dFecFinal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void Frm_NuevoEntregable_D_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Grabar_Salir_Click(object sender, EventArgs e)
        {
            if (Grabar() == true)
            {
                blnActualiza = true;
                this.Close();
            }
        }

        private Boolean Grabar()
        {
            Boolean blnGrabo = false;

            if (VerificaIngresoMovimiento() == true)
            {
                try
                {
                    MEC.cCodCompañia = strCodCompañia;
                    MEC.cNroContrato = strNroContrato;
                    MEC.tDesGarantia = Convert.ToString(this.Edt_DesGarantia.Value);
                    MEC.cCodTipoGarantia = Convert.ToString(this.Cbo_CodTipoGarantia.SelectedValue);
                    MEC.cCodClaseGarantia = Convert.ToString(this.Cbo_ClaseGarantia.SelectedValue);
                    MEC.cCodEntidadFinanciera = Convert.ToString(this.Txt_CodEntidadFinanciera.Value);
                    MEC.fMontoTotal = Convert.ToDouble(this.Txt_MontoTotal.Value);

                    Model.ContratoGarantia obj = new Model.ContratoGarantia();
                    Service.Data SL = new Service.Data();
                    obj = SL.graba_ContratoGarantia(MEC);

                    MEC.iIdContrato_Garantia = obj.iIdContrato_Garantia;
                    MEC.cNroGarantia = obj.cNroGarantia;
                    RegistroMovimiento();
                    MessageBox.Show("Se ha Generado correctamente la garantía Nro. " +
                                    "\n\n" +
                                    obj.cNroGarantia,
                                    "Generación de Garantía"
                                    );

                    blnGrabo = true;
                    this.BlanqueoData();

                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR: La garantía NO fue agregado");
                    throw;
                }


            }
            return blnGrabo;
        }

        private void BlanqueoData()
        {
            this.Txt_NroGarantia.Value = "";
            this.Edt_DesGarantia.Value = "";
            this.Dtp_FecGarantia.Value = DateTime.Now;
            this.Cbo_CodTipoGarantia.SelectedValue = "";
            this.Cbo_ClaseGarantia.SelectedValue = "";
            this.Txt_CodEntidadFinanciera.Value = "";
            this.Txt_nomEntidadFinanciera.Value = "";
            this.Txt_MontoTotal.Value = 0.0;
            this.Dtp_FecInicio.Value =  DateTime.Now;
            this.Dtp_FecFinal.Value =  DateTime.Now;
        }
        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";

            if (string.IsNullOrEmpty(Convert.ToString(this.Edt_DesGarantia.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la descripción de la garantía";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Cbo_CodTipoGarantia.SelectedValue)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el tipo de garantía";
            }

            if ( string.IsNullOrEmpty( Convert.ToString(this.Cbo_ClaseGarantia.SelectedValue) ) )
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la clase de garantía";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_nomEntidadFinanciera.Text)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la entidad financiera";
            }


            if (Convert.ToDouble(this.Txt_MontoTotal.Value) == 0)
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el monto total";
            }

            if (blnVerifica == false)
            {
                MessageBox.Show(strMensaje,
                                "Error", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Error
                           );
            }
            return blnVerifica;
        }

        private void Btn_Grabar_Click(object sender, EventArgs e)
        {
            if (Grabar() == true)
            {
                blnActualiza = true;
                this.Edt_DesGarantia.Focus();
            }
        }

        private void Txt_CodEntidadFinanciera_Leave(object sender, EventArgs e)
        {
            this.Txt_nomEntidadFinanciera.Value = this.TraeEntidadFinanciera(Convert.ToString(this.Txt_CodEntidadFinanciera.Value)
                                      );
        }
        private string TraeEntidadFinanciera(string strCodEntidadFinanciera)
        {
            return FS.TraerDescripcion_DataTable(DS_EntidadFinanciera.Tables[0],
                                                                       0,
                                                                       1,
                                                                       strCodEntidadFinanciera
                                                                     );

        }

        private void Cbo_CodTipoGarantia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( Convert.ToString( this.Cbo_CodTipoGarantia.SelectedValue ).TrimEnd() == "03")
            {
                this.Txt_CodEntidadFinanciera.Value = "00";
                this.Txt_nomEntidadFinanciera.Value = "Sin Entidad Financiera";
                this.Lbl_EntidadFinanciera.Visible = false;
                this.Txt_CodEntidadFinanciera.Visible = false;
                this.Txt_nomEntidadFinanciera.Visible = false;
            }
            else
            {
                if ( Convert.ToString(  this.Txt_CodEntidadFinanciera.Value ).TrimEnd() == "00")
                {
                    this.Txt_CodEntidadFinanciera.Value = "";
                    this.Txt_nomEntidadFinanciera.Value = "";
                }
                this.Lbl_EntidadFinanciera.Visible = true;
                this.Txt_CodEntidadFinanciera.Visible = true;
                this.Txt_nomEntidadFinanciera.Visible = true;
            }
        }
    }
}
