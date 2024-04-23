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
    public partial class Frm_NuevoInicioActividad_D : Form
    {
        private string strCodCompañia = "";
        private string strNroContrato = "";
        public bool blnActualiza = false;
        private Infragistics.Win.UltraWinGrid.UltraGrid m_Grid;
        private Model.ContratoInicioActividad MEC = new Model.ContratoInicioActividad();
        private Model.ParametroLogistica MPL = new Model.ParametroLogistica();
        private Service.Data sl = new Service.Data();

        public Frm_NuevoInicioActividad_D()
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


                oRow.Cells[0].Value = MEC.IidContrato_InicioActividad;
                oRow.Cells[1].Value = MEC.dFecInicio;
                oRow.Cells[2].Value = Convert.ToString( MEC.tNota);
                oRow.Cells[3].Value = Convert.ToBoolean(MEC.bActivo);
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
                    MEC.dFecInicio = Convert.ToDateTime(this.Dtp_FecInicio.Value);
                    MEC.tNota = Convert.ToString(this.Edt_DesGarantia.Value);

                    Model.ContratoInicioActividad obj = new Model.ContratoInicioActividad();
                    Service.Data SL = new Service.Data();
                    obj = SL.graba_ContratoInicioActividad(MEC);

                    MEC.IidContrato_InicioActividad = obj.IidContrato_InicioActividad;
                    RegistroMovimiento();
                    MessageBox.Show("OK: El inicio de actividad fue agregado correctamente");
                    blnGrabo = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR: El inicio de actividad NO fue agregado");
                    throw;
                }


            }
            return blnGrabo;
        }

        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";

            if (string.IsNullOrEmpty(Convert.ToString(this.Edt_DesGarantia.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar una nota sobre el Inicio de actividad";
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
    }
}
