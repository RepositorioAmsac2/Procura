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
    public partial class Frm_ModificaContrato : Form
    {
        private WINlogistica.Framework FS = new WINlogistica.Framework();
        private DataSet DS_Proveedor = new DataSet();
        private DataSet DS_AdministradorContrato = new DataSet();
        private Model.ContratoCabecera MCC = new Model.ContratoCabecera();
        private Service.Data sl = new Service.Data();
        private bool blnMuestaFromato = true;
        private string strCodAdministradorContrato_Anterior = "";
        public Frm_ModificaContrato()
        {
            InitializeComponent();
        }
        private void Frm_NuevoContrato_Load(object sender, EventArgs e)
        {

            DS_Proveedor = sl.ayuda_Proveedor(MyStuff.CodigoEmpresa);

            DS_AdministradorContrato = sl.Ayuda_Empleado();
            this.Txt_CodAdministradorContrato.nombreDS = DS_AdministradorContrato;

            this.Txt_CodContratista.nombreDS = DS_Proveedor;
            this.Txt_CodDestinatarioPago.nombreDS = DS_Proveedor;
            this.Cbo_CodTipoMoneda.CargaDS(sl.Combo_TipoMoneda());
            this.Cbo_CodTipoContrato.CargaDS(sl.combo_TipoContrato());
        }   
        private void Btn_Grabar_Salir_Click(object sender, EventArgs e)
        {
            if (Grabar() == true)
            {
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
                    MCC.CCodCompañia = MyStuff.CodigoEmpresa;
                    MCC.CNroContrato = Convert.ToString( this.Txt_NroContrato.Value );
                    MCC.TDesContrato = Convert.ToString(this.Edt_DescripcionContrato.Value);
                    MCC.CCodObjetoContratacion = Convert.ToString(this.txt_CodObjetoContratacion.Value);
                    MCC.CcodTipoMoneda = Convert.ToString(this.Cbo_CodTipoMoneda.SelectedValue);
                    MCC.CCodTipoContrato = Convert.ToString(this.Cbo_CodTipoContrato.SelectedValue);

                    if (MCC.CcodTipoImpuesto.TrimEnd() == "00")
                    {
                        if (MCC.CcodTipoMoneda.TrimEnd() == "LO")
                        {
                            MCC.FprecioUnitario_Local = Convert.ToDouble(this.Txt_SubTotal.Value);
                            MCC.FprecioUnitario_Extranjero = 0;
                            MCC.Fimpuesto_Local = 0;
                            MCC.Fimpuesto_Extranjero = 0;
                        }
                        else
                        {
                            MCC.FprecioUnitario_Extranjero = Convert.ToDouble(this.Txt_SubTotal.Value);
                            MCC.FprecioUnitario_Local = 0;
                            MCC.Fimpuesto_Local = 0;
                            MCC.Fimpuesto_Extranjero = 0;
                        }
                    }
                    else
                    {
                        if (MCC.CcodTipoMoneda.TrimEnd() == "LO")
                        {
                            MCC.FprecioUnitario_Local = Convert.ToDouble(this.Txt_SubTotal.Value);
                            MCC.FprecioUnitario_Extranjero = 0;
                            MCC.Fimpuesto_Local = Convert.ToDouble(this.Txt_Impuesto.Value);
                            MCC.Fimpuesto_Extranjero = 0;
                        }
                        else
                        {
                            MCC.FprecioUnitario_Extranjero = Convert.ToDouble(this.Txt_SubTotal.Value);
                            MCC.FprecioUnitario_Local = 0;
                            MCC.Fimpuesto_Local = 0;
                            MCC.Fimpuesto_Extranjero = Convert.ToDouble(this.Txt_Impuesto.Value);
                        }
                    }


                    MCC.cCodContratista = Convert.ToString(this.Txt_CodContratista.Value);
                    MCC.cCodDestinatarioPago = Convert.ToString(this.Txt_CodDestinatarioPago.Value);
                    MCC.DFecSuscripcionContrato = Convert.ToDateTime(this.Dtp_FecSuscripcionContrato.Value);
                    MCC.DFecVigencia_Inicio = Convert.ToDateTime(this.Dtp_FecVigenciaInicial.Value);
                    MCC.DFecVigencia_Final = Convert.ToDateTime(this.Dtp_FecVigenciaFinal.Value);
                    MCC.CNroProceso = Convert.ToString(this.Txt_NroProceso.Value);
                    if (MCC.CCodTipoContrato.TrimEnd() == "01")
                    {
                        MCC.bSolicitaAnticipo = Convert.ToBoolean(this.Chk_PideAnticipo.Checked);
                        MCC.bRequiereRetencionGarantia = false;
                    }
                    else
                    {
                        MCC.bRequiereRetencionGarantia = Convert.ToBoolean(this.Chk_PideRetencionGarantia.Checked);
                        MCC.bSolicitaAnticipo = false;
                    }
                    MCC.bSeAplicaPenalidad = Convert.ToBoolean(this.Chk_SeAplicaPenalidad.Checked);

                    MCC.cCodAdministradorContrato = Convert.ToString(this.Txt_CodAdministradorContrato.Value);

                    Model.ContratoCabecera obj = new Model.ContratoCabecera();
                    Service.Data SL = new Service.Data();
                    obj = SL.modifica_Contrato(MCC,strCodAdministradorContrato_Anterior);

                    MCC.IidContrato = obj.IidContrato;
                    MCC.CNroContrato = obj.CNroContrato;
                    MessageBox.Show("OK: El contrato fue actualizado ",
                                    "Generación de Contrato"
                                   );
                    blnGrabo = true;

                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR: El contrato NO fue agregado");
                    throw;
                }


            }
            return blnGrabo;
        }

        private void BlanqueoData()
        {
            this.Txt_NroContrato.Value = "";
            this.Txt_NroProceso.Value = "";
            this.Edt_DesProceso.Value = "";
            this.Edt_DescripcionContrato.Value = "";
            this.txt_CodObjetoContratacion.Value = "";
            this.Txt_CodTipoProceso.Value = "";
            this.Txt_DesObjetoContratacion.Value = "";
            this.Txt_DesTipoProceso.Value = "";
            this.Cbo_CodTipoMoneda.SelectedValue = "";
            this.Cbo_CodTipoContrato.SelectedValue = "";
            this.Txt_CodContratista.Value = "";
            this.Txt_NomContratista.Value = "";
            this.Txt_CodDestinatarioPago.Value = "";
            this.Txt_NomDestinatarioPago.Value = "";
            this.Txt_SubTotal.Value = 0.0;
            this.Dtp_FecSuscripcionContrato.Value = DateTime.Now;
            this.Dtp_FecVigenciaInicial.Value = DateTime.Now;
            this.Dtp_FecVigenciaFinal.Value = DateTime.Now;
            this.Chk_PideAnticipo.Checked = false;
            this.Chk_PideRetencionGarantia.Checked = false;
            this.Chk_SeAplicaPenalidad.Checked = true;
            this.Txt_CodAdministradorContrato.Value = "";
            this.Txt_NomAdministradorContrato.Value = "";
        }
        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";

            if (string.IsNullOrEmpty(Convert.ToString(this.Edt_DesProceso.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el proceso de selección";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Edt_DescripcionContrato.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la descripción del contrato";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Cbo_CodTipoContrato.SelectedValue)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el tipo de contrato";
            }


            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NomContratista.Text)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el contratista";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NomDestinatarioPago.Text)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el destinatario de pago";
            }

            if (Convert.ToDouble(this.Txt_SubTotal.Value) == 0)
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

        private string Busca_Proveedor(string strCodProveedor)
        {
            return FS.TraerDescripcion_DataTable(DS_Proveedor.Tables[0],
                                                0,
                                                1,
                                                strCodProveedor
                                                );
        }

        private void PintarDatosProcesoseleccion( string strNroProceso)
        {
            Model.BuenaPro MBP = new Model.BuenaPro();
            MBP = sl.recupera_BuenaPro(MyStuff.CodigoEmpresa,
                                        strNroProceso
                                      );
            this.Edt_DesProceso.Value = MBP.tDesProceso;
            this.Txt_CodTipoProceso.Value = MBP.cCodTipoProceso;
            this.Txt_DesTipoProceso.Value = VerTipoProceso(MBP.cCodTipoProceso);
            this.txt_CodObjetoContratacion.Value = MBP.cCodObjetoContratacion;
            this.Txt_DesObjetoContratacion.Value = MBP.cCodObjetoContratacion;
        }

        private string VerTipoProceso(string strCodTipoProceso)
        {
            return sl.Recupera_TipoProceso_Codigo(strCodTipoProceso).vDesTipoProceso;
        }

        private string VerObjetoContratacion(string strCodObjetoContratacion)
        {
            return sl.Recupera_ObjetoContratacion_Codigo(strCodObjetoContratacion).vDesObjetoContratacion;
        }
        private void Txt_CodContratista_Leave(object sender, EventArgs e)
        {
            this.Txt_NomContratista.Value = Busca_Proveedor(Convert.ToString(this.Txt_CodContratista.Value));
        }


        private void Txt_CodDestinatarioPago_Leave(object sender, EventArgs e)
        {
            this.Txt_NomDestinatarioPago.Value = Busca_Proveedor(Convert.ToString(this.Txt_CodDestinatarioPago.Value));

        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
        }

        private void Btn_NroContrato_Click(object sender, EventArgs e)
        {
            WINlogistica.Frm_Ayuda_Contrato frm = new WINlogistica.Frm_Ayuda_Contrato();
            frm.ShowMe(MyStuff.CodigoEmpresa);
            if (frm.blnEligio == true)
            {
                this.Txt_NroContrato.Value = frm.strCodContrato;
                Model.ContratoCabecera MC = new Model.ContratoCabecera();
                string strContrato = Convert.ToString(this.Txt_NroContrato.Value);
                MC = sl.recupera_Contrato(MyStuff.CodigoEmpresa,
                                    strContrato
                                    );
                this.Txt_NroProceso.Value = MC.CNroProceso;
                this.PintarDatosProcesoseleccion(MC.CNroProceso);
                this.Txt_CodContratista.Value = MC.cCodContratista;
                this.Txt_CodTipoProceso.Value = MC.CCodTipoProceso;
                this.Txt_DesTipoProceso.Value = MC.VDesTipoProceso;
                this.txt_CodObjetoContratacion.Value = MC.CCodObjetoContratacion;
                this.Txt_DesObjetoContratacion.Value = MC.VDesObjetoContratacion;
                this.Txt_NomContratista.Value = this.Busca_Proveedor(MC.cCodContratista);
                this.Txt_CodDestinatarioPago.Value = MC.cCodDestinatarioPago;
                this.Txt_NomDestinatarioPago.Value = this.Busca_Proveedor(MC.cCodContratista);
                this.Edt_DescripcionContrato.Value = MC.TDesContrato;
                this.Cbo_CodTipoMoneda.SelectedValue = MC.CcodTipoMoneda;
                this.Cbo_CodTipoContrato.SelectedValue = MC.CCodTipoContrato;

                if (MC.CcodTipoImpuesto.TrimEnd() == "00")
                {
                    this.Txt_Impuesto.Value = 0;
                    if (MC.CcodTipoMoneda.TrimEnd() == "LO")
                    {
                        this.Txt_SubTotal.Value = MC.FprecioUnitario_Local;
                    }
                    else
                    {
                        this.Txt_SubTotal.Value = MC.FprecioUnitario_Extranjero;
                    }
                }
                else
                {
                    if (MC.CcodTipoMoneda.TrimEnd() == "LO")
                    {
                        this.Txt_SubTotal.Value = MC.FprecioUnitario_Local;
                        this.Txt_Impuesto.Value = MC.Fimpuesto_Local;
                    }
                    else
                    {
                        this.Txt_SubTotal.Value = MC.FprecioUnitario_Extranjero;
                        this.Txt_Impuesto.Value = MC.Fimpuesto_Extranjero;
                    }
                }
                this.Txt_Total.Value = Convert.ToDouble(this.Txt_SubTotal.Value) +
                                          Convert.ToDouble(this.Txt_Impuesto.Value);

                this.Dtp_FecSuscripcionContrato.Value = MC.DFecSuscripcionContrato;
                this.Dtp_FecVigenciaInicial.Value = MC.DFecVigencia_Inicio;
                this.Dtp_FecVigenciaFinal.Value = MC.DFecVigencia_Final;
                this.Chk_PideAnticipo.Checked = MC.bSolicitaAnticipo;
                this.Chk_SeAplicaPenalidad.Checked = MC.bSeAplicaPenalidad;
                this.Txt_CodAdministradorContrato.Value = MC.cCodAdministradorContrato;
                this.Txt_NomAdministradorContrato.Value = this.Busca_AdministradorContrato(MC.cCodAdministradorContrato);
                strCodAdministradorContrato_Anterior = MC.cCodAdministradorContrato;

                if (string.IsNullOrEmpty(MC.CNroContrato.TrimEnd()) == false)
                {
                    this.Tab_Contrato.Enabled = true;
                    this.Grp_ProcesoSeleccion.Enabled = true;
                }
                else
                {
                    this.Tab_Contrato.Enabled = true;
                    this.Grp_ProcesoSeleccion.Enabled = false;
                }


            }
        }

        private void Cbo_CodTipoContrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strCodTipoContrato = Convert.ToString(this.Cbo_CodTipoContrato.SelectedValue);
            if (strCodTipoContrato.TrimEnd() == "01")
            {
                this.Lbl_PideAnticipo.Visible = true;
                this.Chk_PideAnticipo.Visible = true;

                this.Lbl_PideRetencionGarantia.Visible = false;
                this.Chk_PideRetencionGarantia.Visible = false;
            }
            else
            {
                this.Lbl_PideAnticipo.Visible = false;
                this.Chk_PideAnticipo.Visible = false;

                this.Lbl_PideRetencionGarantia.Visible = true;
                this.Chk_PideRetencionGarantia.Visible = true;
            }

        }

        private void Txt_CodAdministradorContrato_Leave(object sender, EventArgs e)
        {
           this.Txt_NomAdministradorContrato.Value =  this.Busca_AdministradorContrato( Convert.ToString( this.Txt_CodAdministradorContrato.Value )
                                         );
        }

        private string Busca_AdministradorContrato(string strCodAdministradorContrato)
        {
            return FS.TraerDescripcion_DataTable(DS_AdministradorContrato.Tables[0],
                                                0,
                                                1,
                                                strCodAdministradorContrato
                                                );
        }

    }
}
