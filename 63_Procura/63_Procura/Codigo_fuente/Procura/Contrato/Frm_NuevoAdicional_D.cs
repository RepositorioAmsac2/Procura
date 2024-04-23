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
    public partial class Frm_NuevoAdicional_D : Form
    {
        private string strCodCompañia = "";
        private string strNroContrato = "";
        public bool blnActualiza = false;
        private Infragistics.Win.UltraWinGrid.UltraGrid m_Grid;
        private Model.adenda MEC = new Model.adenda();
	    private WINlogistica.Framework FS = new WINlogistica.Framework();
        private DataSet DS_Entregable = new DataSet();

        public Frm_NuevoAdicional_D()
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

            Service.Data sl = new Service.Data();
            this.Cbo_TipoAdicional.CargaDS(sl.combo_TipoAdicional());
            DS_Entregable = sl.lista_ContratoEntregable(strCodCompañia,
                                                                            strNroContrato
                                                                         );
            this.Txt_NroEntregable.nombreDS = DS_Entregable;

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


                oRow.Cells[0].Value = MEC.iIdAdenda;
                oRow.Cells[1].Value = MEC.cNroAdenda;
                oRow.Cells[2].Value = Convert.ToString( MEC.tDesAdenda);
                oRow.Cells[3].Value = MEC.dFecAdenda;
                oRow.Cells[4].Value = MEC.cCodTipoAdenda;
                oRow.Cells[5].Value = MEC.vDesTipoAdenda;
                oRow.Cells[6].Value = MEC.cNroEntregable;
                oRow.Cells[7].Value = MEC.iDias;
                oRow.Cells[8].Value = MEC.fImporte;
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
                    MEC.cCodCompañia = strCodCompañia;
                    MEC.cNroContrato = strNroContrato;
                    MEC.tDesAdenda = Convert.ToString(this.Edt_DesAdenda.Value);
                    MEC.iDias = Convert.ToInt32(this.Txt_Dias.Value);
                    MEC.cCodTipoAdenda = Convert.ToString( this.Cbo_TipoAdicional.SelectedValue );
                    MEC.vDesTipoAdenda = Convert.ToString(this.Cbo_TipoAdicional.Text);
                    if (MEC.cCodTipoAdenda.TrimEnd() == "01")
                    {
                        MEC.cNroEntregable = Convert.ToString(this.Txt_NroEntregable.Value);
                        MEC.fImporte = 0.0;
                    }
                    else
                    {
                        MEC.cNroEntregable = "00";
                        MEC.fImporte = Convert.ToDouble(this.Txt_Factor.Value);
                    }
                    Model.adenda obj = new Model.adenda();
                    obj = SL.insertar_ContratoAdicional(MEC);

                    MEC.iIdAdenda = obj.iIdAdenda;
                    MEC.cNroAdenda = obj.cNroAdenda;
                    RegistroMovimiento();
                    MessageBox.Show("Se ha Generado correctamente el adicional Nro. " +
                                    "\n\n" +
                                    obj.cNroAdenda,
                                    "Generación de Adicional"
                );

                    blnGrabo = true;
                    this.BlanqueoData();

                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR: El adicional NO fue agregado");
                    throw;
                }


            }
            return blnGrabo;
        }

        private void BlanqueoData()
        {
            this.Txt_NroAdenda.Value = "";
            this.Edt_DesAdenda.Value = "";
            this.Opt_TipoDuracion.CheckedIndex = 0;
            this.Txt_Dias.Value = 0;
            this.Txt_NroEntregable.Value = "";
            this.Edt_DesEntrgable.Value = "";
            this.Txt_Factor.Value = 0.0;
        }
        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";

            if (string.IsNullOrEmpty(Convert.ToString(this.Edt_DesAdenda.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la descripción del adicinal";
            }

            if (Convert.ToString(this.Cbo_TipoAdicional.SelectedValue).TrimEnd() == "01")
            {
                if (Convert.ToDouble(this.Txt_Dias.Value) == 0)
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar la cantidad de dias";
                }

                if ( string.IsNullOrEmpty( Convert.ToString( this.Edt_DesEntrgable.Value ) ) )
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Número de entregable";
                }
            }
            else
            {
                if (Convert.ToDouble(this.Txt_Factor.Value) == 0 )
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el importe del adicional";
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
                this.Edt_DesAdenda.Focus();
            }
        }

        private void Txt_NroEntregable_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_TipoAdicional_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty( Convert.ToString( this.Cbo_TipoAdicional.SelectedValue ) ) == false )
            {
                string strCodTipoAdicional = Convert.ToString(this.Cbo_TipoAdicional.SelectedValue);
                if ( strCodTipoAdicional.TrimEnd() == "01")
                {
                    this.Lbl_Entregable.Visible = true;
                    this.Txt_NroEntregable.Visible = true;
                    this.Edt_DesEntrgable.Visible = true;
                    this.Lbl_Duracion.Visible = true;
                    this.Opt_TipoDuracion.Visible = true;
                    this.Lbl_Dias.Visible = true;
                    this.Txt_Dias.Visible = true;
                    this.Txt_Factor.Visible = false;
                    this.Lbl_Factor.Visible = false;
                }
                else
                {
                    if (strCodTipoAdicional.TrimEnd() == "02")
                    {
                        this.Lbl_Entregable.Visible = false;
                        this.Txt_NroEntregable.Visible = false;
                        this.Edt_DesEntrgable.Visible = false;
                        this.Lbl_Duracion.Visible = false;
                        this.Opt_TipoDuracion.Visible = false;
                        this.Lbl_Dias.Visible = false;
                        this.Txt_Dias.Visible = false;
                        this.Txt_Factor.Visible = true;
                        this.Lbl_Factor.Visible = true;
                    }
                }
            }
        }

        private void Txt_NroEntregable_Leave(object sender, EventArgs e)
        {
            this.BuscarEntregable(Convert.ToString(this.Txt_NroEntregable.Value)
                     );
        }

        private void BuscarEntregable(string strNroEntregable)
        {
            this.Edt_DesEntrgable.Value = FS.TraerDescripcion_DataTable(DS_Entregable.Tables[0],
                                                                                   0,
                                                                                   1,
                                                                                   strNroEntregable
                                                                                 );

        }

    }
}
