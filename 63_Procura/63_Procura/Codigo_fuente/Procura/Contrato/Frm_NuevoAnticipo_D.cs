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
    public partial class Frm_NuevoAnticipo_D : Form
    {
        private string strCodCompañia = "";
        private string strNroContrato = "";
        public bool blnActualiza = false;
        private Infragistics.Win.UltraWinGrid.UltraGrid m_Grid;
        private Model.ContratoAnticipo MEC = new Model.ContratoAnticipo();
        private Model.ParametroLogistica MPL = new Model.ParametroLogistica();
        Model.TipoDocumento MTD = new Model.TipoDocumento();
        private Service.Data sl = new Service.Data();
        private Model.TipoImpuesto MTI = new Model.TipoImpuesto();
        private int intTipoDocumento_Inicial = 0;
        private string strTipoAnticipo_Inicial = "";
        private string strTipoImpuesto_Inicial = "";
        private Boolean blnEmpiezaProceso = false;
        private WINlogistica.Framework FS = new WINlogistica.Framework();
        private DataSet DS_Garantia = new DataSet();

        public Frm_NuevoAnticipo_D()
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

            this.Cbo_TipoDocumento.CargaDS(sl.combo_TipoDocumento(true));
            this.Cbo_CodTipoAnticipo.CargaDS(sl.combo_TipoAnticipo());
            DS_Garantia = sl.ayuda_ContratoGarantia(strCodCompañia,
                                                    strNroContrato
                                                   );

            this.Txt_NroGarantia.nombreDS = DS_Garantia;

            // Datos Iniciales
            strTipoImpuesto_Inicial = sl.Recupera_ParametroLogistica_Codigo("101").vValParametroLogistica;
            intTipoDocumento_Inicial = Convert.ToInt32( sl.Recupera_ParametroLogistica_Codigo("102").vValParametroLogistica );
            strTipoAnticipo_Inicial = sl.Recupera_ParametroLogistica_Codigo("103").vValParametroLogistica;
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


                oRow.Cells[0].Value = MEC.iIdContrato_Anticipo;
                oRow.Cells[1].Value = MEC.cNroAnticipo;
                oRow.Cells[2].Value = Convert.ToString( MEC.tDesAnticipo);
                oRow.Cells[3].Value = MEC.dFecAnticipo;
                oRow.Cells[4].Value = MEC.cCodTipoAnticipo;
                oRow.Cells[5].Value = Convert.ToString(this.Cbo_CodTipoAnticipo.Text); ;
                oRow.Cells[6].Value = MEC.iTipoDocumento;
                oRow.Cells[7].Value = Convert.ToString( this.Cbo_TipoDocumento.Text );
                oRow.Cells[8].Value = MEC.cSerDocumento.TrimEnd() + "-" + MEC.cNroDocumento;
                oRow.Cells[9].Value = MEC.dFecDocumento;
                oRow.Cells[10].Value = MEC.fBaseImponible;
                oRow.Cells[11].Value = MEC.cCodTipoImpuesto;
                oRow.Cells[12].Value = MEC.fImpuesto;
                oRow.Cells[13].Value = MEC.fMontoTotal;
                oRow.Cells[14].Value = MEC.cSerDocumento;
                oRow.Cells[15].Value = MEC.cNroDocumento;
                oRow.Cells[16].Value = MEC.cNrogarantia;

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
                    MEC.tDesAnticipo = Convert.ToString(this.Edt_DesAnticipo.Value);
                    MEC.cNrogarantia = Convert.ToString(this.Txt_NroGarantia.Value);
                    MEC.cCodTipoAnticipo = Convert.ToString(this.Cbo_CodTipoAnticipo.SelectedValue);
                    MEC.dFecDocumento = Convert.ToDateTime(this.Dtp_FecDocumento.Value);
                    MEC.cSerDocumento = Convert.ToString(this.Txt_SerDocumento.Text);
                    MEC.cNroDocumento = Convert.ToString(this.Txt_NroDocumento.Text);
                    MEC.iTipoDocumento = Convert.ToInt32(this.Cbo_TipoDocumento.SelectedValue);
                    MEC.fBaseImponible = Convert.ToDouble(this.Txt_BaseImponible.Value);
                    MEC.cCodTipoImpuesto = MTD.cCodTipoImpuesto;
                    MEC.fImpuesto = Convert.ToDouble(this.Txt_Impuesto.Value);
                    MEC.fMontoTotal = Convert.ToDouble(this.Txt_MontoTotal.Value);

                    Model.ContratoAnticipo obj = new Model.ContratoAnticipo();
                    obj = SL.insertar_ContratoAnticipo(MEC);

                    MEC.iIdContrato_Anticipo = obj.iIdContrato_Anticipo;
                    MEC.cNroAnticipo = obj.cNroAnticipo;
                    RegistroMovimiento();
                    MessageBox.Show("Se ha Generado correctamente el adelanto Nro. " +
                                        "\n\n" +
                                        obj.cNroAnticipo,
                                        "Generación de Adelanto"
                                        );

                    blnGrabo = true;
                    this.BlanqueoData();

                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR: El anticipo NO fue agregado");
                    throw;
                }
            }
            return blnGrabo;
        }

        private void BlanqueoData()
        {
            this.Txt_NroAnticipo.Value = "";
            this.Edt_DesAnticipo.Value = "";
            this.Txt_NroGarantia.Value = "";
            this.Txt_DesGarantia.Value = "";
            this.Cbo_TipoDocumento.SelectedValue = intTipoDocumento_Inicial;
            this.Cbo_CodTipoAnticipo.SelectedValue = strTipoAnticipo_Inicial;
            this.Txt_SerDocumento.Text = "";
            this.Txt_NroDocumento.Text = "";
            this.Txt_BaseImponible.Value = 0.0;
            this.Txt_Impuesto.Value = 0.0;
            this.Txt_MontoTotal.Value = 0.0;
        }
        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";

            if (string.IsNullOrEmpty(Convert.ToString(this.Edt_DesAnticipo.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la descripción del anticipo";
            }

            if ( string.IsNullOrEmpty( Convert.ToString(this.Cbo_TipoDocumento.SelectedValue) ) )
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el tipo de documento";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_SerDocumento.Text)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la serie del documento";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_DesGarantia.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la garantía que avale el anticipo";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NroDocumento.Text)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el número del documento";
            }

            if ( Convert.ToDouble( this.Txt_BaseImponible.Value ) == 0)
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la Base imponible";
            }

            if (Convert.ToDouble(this.Txt_Impuesto.Value) == 0)
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el impuesto";
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
                this.Edt_DesAnticipo.Focus();
            }
        }

        private void Txt_NroEntregable_ValueChanged(object sender, EventArgs e)
        {

        }


        private void Txt_BaseImponible_Leave(object sender, EventArgs e)
        {
            this.Txt_Impuesto.Value = Convert.ToDouble(this.Txt_BaseImponible.Value) * (MTI.fFactor / 100);
            this.Txt_MontoTotal.Value = Convert.ToDouble(this.Txt_BaseImponible.Value ) +
                                          Convert.ToDouble(this.Txt_Impuesto.Value);
                                        
        }

        private void Cbo_TipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blnEmpiezaProceso == true)
            {
                int intTipoDocumento = Convert.ToInt32(this.Cbo_TipoDocumento.SelectedValue);
                MTD = sl.recupera_TipoDocumento_Codigo(intTipoDocumento);
                MTI = sl.recupera_TipoImpuesto_Codigo(MTD.cCodTipoImpuesto);
                if (MTD.iLongitudSerie == 0)
                {
                    this.Txt_SerDocumento.Visible = false;

                }
            }
            blnEmpiezaProceso = true;
        }

        private void Txt_NroGarantia_Leave(object sender, EventArgs e)
        {
            this.Txt_DesGarantia.Value = Busca_Garantia( Convert.ToString( this.Txt_NroGarantia.Value ));
        }

        private string Busca_Garantia(string strNroGarantia )
        {
            return FS.TraerDescripcion_DataTable(DS_Garantia.Tables[0],
                                                                       0,
                                                                       1,
                                                                       strNroGarantia
                                                                     );

        }

        private void Txt_SerDocumento_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_SerDocumento.Text)) == false)
            {
                this.Txt_SerDocumento.Text = Convert.ToString(this.Txt_SerDocumento.Text).TrimEnd().PadLeft(MTD.iLongitudSerie, '0');
            }

        }

        private void Txt_NroDocumento_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NroDocumento.Text)) == false)
            {
                this.Txt_NroDocumento.Text = Convert.ToString(this.Txt_NroDocumento.Text).TrimEnd().PadLeft(MTD.iLongitudDocumento, '0');
            }

        }
    }
}
