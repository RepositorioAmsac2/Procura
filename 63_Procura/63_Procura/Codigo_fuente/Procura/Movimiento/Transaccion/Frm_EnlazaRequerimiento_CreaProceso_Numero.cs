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
    public partial class Frm_EnlazaRequerimiento_CreaProceso_Numero : Form
    {
        private WINlogistica.Framework FS = new WINlogistica.Framework();
        private DataSet DS_AdministradorContrato = new DataSet();
        private Service.Data sdl = new Service.Data();

        public string strNumProcedimiento = "";
        private string strNumRequerimiento = "";
        private string strDesProceso = "";
        private double dblImporte = 0;

        private string strPaso = "";
        private string strCodCentroGestor = "";
        private string strEsUnProceso = "";
        private string strCodPac = "";
        private string strCodEmpleado = "";

        public Frm_EnlazaRequerimiento_CreaProceso_Numero()
        {
            InitializeComponent();
        }

        public void ShowMe( string cNumRequerimiento,
                        string vDesProceso,
                        double fImporte,
                        string cPaso,
                        string cCodCentroGestor,
                        string cEsUnProceso,
                        string cCodPac,
                        string cCodEmpleado
                      )
        {
            strNumRequerimiento = cNumRequerimiento;
            strDesProceso = vDesProceso;
            dblImporte = fImporte;

            strPaso = cPaso;
            strCodCentroGestor = cCodCentroGestor;
            strEsUnProceso = cEsUnProceso;
            strCodPac = cCodPac;
            strCodEmpleado = cCodEmpleado;

            this.Edt_DesProceso.Value = strDesProceso;
            this.Txt_Importe.Value = Convert.ToDouble( fImporte );

            DS_AdministradorContrato = sdl.Ayuda_Empleado();
            this.Txt_CodAdministradorContrato.nombreDS = DS_AdministradorContrato;
            this.Cbo_TipoProceso.CargaDT(sdl.Combo_TipoProceso().Tables[0]);
            this.ShowDialog();



        }

        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
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

                string strCodTipoProceso = Convert.ToString(this.Cbo_TipoProceso.SelectedValue);
                string strCodObjetoContratacion = Convert.ToString(this.Cbo_ObjetoContratacion.SelectedValue);
                string strCodAdministradorContrato = Convert.ToString(this.Txt_CodAdministradorContrato.Value);
                int intDiasPlazo = 0;

                strNumProcedimiento = sdl.graba_ProcesoLogistico_Requerimiento(strNumRequerimiento,
                                                                                strCodTipoProceso,
                                                                                strCodObjetoContratacion,
                                                                                strCodAdministradorContrato,
                                                                                intDiasPlazo,
                                                                                strPaso,
                                                                                strCodCentroGestor,
                                                                                strEsUnProceso,
                                                                                strCodPac,
                                                                                strCodEmpleado
                                                                              );
                blnGrabo = true;
            }
            return blnGrabo;
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


            if (string.IsNullOrEmpty(Convert.ToString(this.Cbo_TipoProceso.SelectedValue)))
            {
                blnVerifica = false;
                strMensaje = "Debe elegir un tipo de proceso";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Cbo_ObjetoContratacion.SelectedValue)))
            {
                blnVerifica = false;
                strMensaje = "Debe elegir un objeto de contratacion";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NomAdministradorContrato.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe elegir un administrador de contrato";
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


        private void Txt_CodAdministradorContrato_Leave(object sender, EventArgs e)
        {
          this.Txt_NomAdministradorContrato.Value =   this.Busca_AdministradorContrato(Convert.ToString(this.Txt_CodAdministradorContrato.Value)
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

        private void Frm_EnlazaRequerimiento_CreaProceso_Numero_Load(object sender, EventArgs e)
        {

        }

        private void Cbo_TipoProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Cbo_TipoProceso.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                string strCodTipoProceso = Convert.ToString(this.Cbo_TipoProceso.SelectedValue);
                if (MyStuff.UsaWCF == true)
                {
                }
                else
                {
                    this.Cbo_ObjetoContratacion.CargaDT(sdl.Combo_ObjetoContratacion(strCodTipoProceso).Tables[0]);
                }

            }

        }
    }
}
