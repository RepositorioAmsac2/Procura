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
    public partial class Frm_CambiaEstadoPAC : Form
    {
        Model.ProcesoLogistico_Cabecera MPC = new Model.ProcesoLogistico_Cabecera();
        Service.Data sdl = new Service.Data();

        Model.ProcesoLogistico_Paso MPDP = new Model.ProcesoLogistico_Paso();

        Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();

        private Model.ProcesoLogistico_Eliminado MPDE = new Model.ProcesoLogistico_Eliminado();

        Model.ProcesoLogistico_Paso_CambioEstado MPDPCE = new Model.ProcesoLogistico_Paso_CambioEstado();

        int intIdPac_Detalle = 0;
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        public Frm_CambiaEstadoPAC()
        {
            InitializeComponent();
        }

        private bool verCodPac()
        {

            bool blnResult = false;
            if (Convert.ToString(this.Txt_NumProcedimiento.Text).Trim() != "")
            {
                string strPeriodoProceso = Convert.ToString(this.Txt_AñoProceso.Value);
                string strVersion = Convert.ToString(this.Txt_Version.Value);
                string strCodPac = Convert.ToString(this.Txt_NumProcedimiento.Text);
                if (MyStuff.UsaWCF == true)
                {
                    MPD = objWCF.Recupera_Pac_Detalle_Codigo(strCodPac);
                }
                else
                {
                    MPD = sdl.Recupera_ProcesoLogistico_Detalle_Codigo(strCodPac);
                }
                
                if (MPD.iIdProcesoLogistico_Eliminado != 0)
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        MPDE = objWCF.Recupera_Pac_Eliminado(MPD.iIdProcesoLogistico_Eliminado);
                    }
                    else
                    {
                        MPDE = sdl.Recupera_ProcesoLogistico_Eliminado(MPD.iIdProcesoLogistico_Eliminado);
                    }
                    
                    MessageBox.Show("Error: El Item ha sido Excluido" + (char)(13) +
                    "Fecha        : " + Convert.ToString(MPDE.dFecEliminado) + (char)(13) +
                    "Documento    : " + Convert.ToString(MPDE.vDesTipoDocumento) + (char)(13) +
                    "Motivo       : " + Convert.ToString(MPDE.vDesTipoMotivo) + (char)(13) +
                    "Nota         : " + Convert.ToString(MPDE.tMotEliminado) + (char)(13) +
                    "Excluido  por: " + Convert.ToString(MPDE.vApeEmpleado)
                           );
                    this.Close();
                }
                else
                {
                    this.Edt_Pac.Value = MPD.tDesContratacion;
                    this.Txt_PrecioEstimado.Value = MPD.fPrecioEstimado;
                    blnResult = true;
                }
                    
            }
            else
            {
                this.Edt_Pac.Value = "";
                this.Txt_PrecioEstimado.Value = "0";
            }
            return blnResult;
        }


        private void Tsb_Grabar_Salir_Click(object sender, EventArgs e)
        {
            MPDPCE.cNumProcedimiento = Convert.ToString( this.Txt_NumProcedimiento.Text );
            MPDPCE.cCodPaso_Actual = Convert.ToString(this.Txt_CodPasoActual.Value);
            MPDPCE.cCodPaso_Inicial = Convert.ToString(this.Cbo_CodPasoInicial.SelectedValue);
            MPDPCE.cCodPaso_Final = Convert.ToString(this.Cbo_CodPasoFinal.SelectedValue);
            MPDPCE.cCodEstadoPaso = Convert.ToString(this.Cbo_CodEstadoPaso.SelectedValue);
            MPDPCE.tNota = Convert.ToString(this.Edt_Nota.Value);

            int intIdPac_Detalle_Estado = 0;
            if (MyStuff.UsaWCF == true)
            {
                intIdPac_Detalle_Estado = objWCF.Graba_Pac_Paso_CambioEstado(MPDPCE);
            }
            else
            {
                intIdPac_Detalle_Estado = sdl.Graba_ProcesoLogistico_Paso_CambioEstado(MPDPCE);
            }
            

            if (intIdPac_Detalle_Estado != 0)
            {
                MessageBox.Show("Ok: El Estado del Item del Pac se cambio Correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR: El Estado del Item del Pac No pudo Modificarse");
            }
        }

        private void Frm_CambiaEstadoPAC_Load(object sender, EventArgs e)
        {
            if (MyStuff.UsaWCF == true)
            {
                MPC = objWCF.Recupera_Pac_Cabecera_Id();
            }
            else
            {
                MPC = sdl.Recupera_ProcesoLogistico_Cabecera_Id();
            }
            
            if (MPC.iIdProcesoLogistico_Cabecera != 0)
            {
                this.Txt_AñoProceso.Value = MPC.cAñoProceso;
                this.Txt_Version.Value = MPC.cVersion;
                if (MyStuff.UsaWCF == true)
                {
                    this.Cbo_CodEstadoPaso.CargaDT(objWCF.Combo_EstadoAperturaPaso().Tables[0]);
                }
                else
                {
                    this.Cbo_CodEstadoPaso.CargaDT(sdl.Combo_EstadoAperturaPaso().Tables[0]);
                }

            }
           
        }

        private void Btn_HallarItemPAC_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty( Convert.ToString( this.Txt_NumProcedimiento.Text )) )
            {
                MessageBox.Show("El Tipo de Procedimiento NO Existe");
                this.Grp_CambioEstado.Visible = false;
            }
            else
            {
                if (verCodPac() == true)
                {
                    DataSet ds = new DataSet();
                    if (MyStuff.UsaWCF == true)
                    {
                        ds = objWCF.Recupera_Pac_Paso_CambiaEstado(MPD.cNumProcedimiento);
                    }
                    else
                    {
                        ds = sdl.Recupera_ProcesoLogistico_Paso_CambiaEstado(MPD.cNumProcedimiento);
                    }
                    
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        this.Txt_CodPasoActual.Value = Convert.ToString(ds.Tables[0].Rows[0]["cCodPaso"]);
                        this.Txt_DesPasoActual.Value = Convert.ToString(ds.Tables[0].Rows[0]["vDesPaso"]);

                        this.Cbo_CodPasoInicial.CargaDT(ds.Tables[2]);
                        this.Cbo_CodPasoFinal.CargaDT(ds.Tables[1]);
                        this.Grp_CambioEstado.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("El Item del Paso no Contiene ningún Paso");
                        this.Grp_CambioEstado.Visible = false;
                    }
                }
            }
        }
    }
}
