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
    public partial class Frm_NuevoEntregable_D : Form
    {
        private string strCodCompañia = "";
        private string strNroContrato = "";
        public bool blnActualiza = false;
        private double dblMontoTotal = 0.0;
        private Infragistics.Win.UltraWinGrid.UltraGrid m_Grid;
        private string strFecFinal = "";
        private Model.EntregableCabecera MEC = new Model.EntregableCabecera();

        public Frm_NuevoEntregable_D()
        {
            InitializeComponent();
        }

        public void ShowMe( string cCodCompañia,
                            string cNroContrato,
                            string cFecFinal,
                            double fMontoTotal,
                            Infragistics.Win.UltraWinGrid.UltraGrid Grid
                          )
        {
            strCodCompañia = cCodCompañia;
            strNroContrato = cNroContrato;
            strFecFinal = cFecFinal;
            dblMontoTotal = fMontoTotal;
            m_Grid = Grid;
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


                oRow.Cells[0].Value = MEC.IidEntregableCabecera;
                oRow.Cells[1].Value = MEC.CNroEntregable;
                oRow.Cells[2].Value = "";
                oRow.Cells[3].Value = Convert.ToString( MEC.TDesEntregable);
                oRow.Cells[4].Value = MEC.ITipoDuracion;
                oRow.Cells[5].Value = MEC.IDiasDuracion;
                oRow.Cells[6].Value = MEC.DFecInicio;
                oRow.Cells[7].Value = MEC.DFecFinal;
                oRow.Cells[8].Value = MEC.ITipoFactor;
                oRow.Cells[9].Value = MEC.FFactor;
                //MessageBox.Show(MEC.ITipoFactor.ToString());
                //MessageBox.Show(Convert.ToString(dblMontoTotal));
                //MessageBox.Show(MEC.FFactor.ToString());

                if (MEC.ITipoFactor == 0)
                {
                    oRow.Cells[10].Value = dblMontoTotal * (MEC.FFactor / 100.00);
                }
                else
                {
                    oRow.Cells[10].Value = MEC.FImporte;
                }
                    
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
                    Service.Data SL = new Service.Data();
                    MEC.DFecFinal = strFecFinal;
                    MEC.cCodCompañia = strCodCompañia;
                    MEC.cNroContrato = strNroContrato;
                    MEC.TDesEntregable = Convert.ToString(this.Edt_DesEntregable.Value);
                    MEC.ITipoDuracion = this.Opt_TipoDuracion.CheckedIndex;
                    MEC.IDiasDuracion = Convert.ToInt32(this.Txt_Dias.Value);
                    if (this.Opt_Tipofactor_Importe.Checked == true)
                    {
                        MEC.ITipoFactor = 1;
                    }
                    else
                    {
                        MEC.ITipoFactor = 0;
                    }
                    
                    if (MEC.ITipoFactor == 0)
                    {
                        MEC.FFactor = Convert.ToDouble(this.Txt_Factor.Value);
                        MEC.FImporte = 0.0;
                    }
                    else
                    {
                        MEC.FImporte = Convert.ToDouble(this.Txt_Factor.Value);
                        MEC.FFactor = 0.0;
                    }
                    //MessageBox.Show(MEC.DFecFinal);

                    Model.EntregableCabecera obj = new Model.EntregableCabecera();
                    obj = SL.insertar_EntregableCabecera(MEC);

                    MEC.IidEntregableCabecera = obj.IidEntregableCabecera;
                    MEC.CNroEntregable = obj.CNroEntregable;
                    MEC.DFecInicio = obj.DFecInicio;
                    MEC.DFecFinal = obj.DFecFinal;

                    this.Txt_NroEntregable.Value = MEC.CNroEntregable;
                    RegistroMovimiento();
                    MessageBox.Show("Se ha Generado correctamente el entregable Nro. " +
                                    "\n\n" +
                                    obj.CNroEntregable,
                                    "Generación de Entregable"
                );

                    blnGrabo = true;
                    this.BlanqueoData();

                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR: El entregable NO fue agregado");
                    throw;
                }


            }
            return blnGrabo;
        }

        private void BlanqueoData()
        {
            this.Txt_NroEntregable.Value = "";
            this.Edt_DesEntregable.Value = "";
            this.Opt_TipoDuracion.CheckedIndex = 0;
            this.Txt_Dias.Value = 0;
            this.Opt_Tipofactor_Porcentaje.Checked = true;
            this.Opt_Tipofactor_Importe.Checked = false;
            this.Txt_Factor.Value = 0.0;
        }
        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";

            if (string.IsNullOrEmpty(Convert.ToString(this.Edt_DesEntregable.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la descripción del entregable";
            }

            if (Convert.ToDouble(this.Txt_Dias.Value) == 0)
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la cantidad de dias";
            }

            if (Convert.ToDouble(this.Txt_Factor.Value) == 0)
            {
                if ( Opt_Tipofactor_Importe.Checked == true )
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el importe de pago";
                }
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
                this.Edt_DesEntregable.Focus();
            }
        }

        private void Opt_TipoDuracion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Opt_Tipofactor_Porcentaje_CheckedChanged(object sender, EventArgs e)
        {
            this.Lbl_Factor.Text = "Porcentaje:";
        }

        private void Opt_Tipofactor_Importe_CheckedChanged(object sender, EventArgs e)
        {
            this.Lbl_Factor.Text = "Importe:";
        }
    }
}
