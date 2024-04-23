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
    public partial class Frm_AsignaDependenciaOperadorLogistico_D : Form
    {
        private Infragistics.Win.UltraWinGrid.UltraGrid m_Grid;
        private string strCodEmpleado = "";
        private int intIdEmpleado = 0;

        private Model.OperadorLogistico MOL = new Model.OperadorLogistico();
        private Service.Data sdl = new Service.Data();

        private Model.Empleado ME = new Model.Empleado();
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public Frm_AsignaDependenciaOperadorLogistico_D()
        {
            InitializeComponent();
        }

        public void ShowMe( string cCodEmpleado, 
                            string strCodDependencia, 
                            string strApeDependencia, 
                            string strCodCentroGestor, 
                            string strDesCentroGestor, 
                            string strEmail,
                            int iIdEmpleado,
                            Infragistics.Win.UltraWinGrid.UltraGrid Grid
                          )
        {
         
            strCodEmpleado = cCodEmpleado;
            intIdEmpleado = iIdEmpleado;
            if (strCodEmpleado.TrimEnd() != "")
            {
                this.Txt_CodDependencia.Value = strCodDependencia;
                this.Txt_ApeDependencia.Value = strApeDependencia;
                this.Txt_CodCentroGestor.Value = strCodCentroGestor;
                this.Txt_DesCentroGestor.Value = strDesCentroGestor;
                this.Txt_Email.Value = strEmail;
                this.btn_Modificar.Enabled = true;
            }
            if (MyStuff.UsaWCF == true)
            {
                this.Txt_CodDependencia.nombreDS = objWCF.Ayuda_Empleado_Jefatura();
            }
            else
            {
                this.Txt_CodDependencia.nombreDS = sdl.Ayuda_Empleado_Jefatura();
            }
            

            m_Grid = Grid;

            this.ShowDialog();

        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (VerificaIngresoMovimiento() == true)
            {
                MOL.iIdEmpleado = intIdEmpleado;
                MOL.cCodEmpleado = strCodEmpleado;
                MOL.cCodDependencia = Convert.ToString( this.Txt_CodDependencia.Value );
                MOL.cCodCentroGestor = Convert.ToString(this.Txt_CodCentroGestor.Value);
                MOL.vEmail = Convert.ToString(this.Txt_Email.Value);

                if ( intIdEmpleado == 0)
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        intIdEmpleado = objWCF.Graba_OperadorLogistico(MOL);
                    }
                    else
                    {
                        intIdEmpleado = sdl.Graba_OperadorLogistico(MOL);
                    }
                    
                    if(intIdEmpleado != 0)
                    {
                        MessageBox.Show("OK: Los datos se registraron correctamente");
                        this.PintarDatosRegistro(intIdEmpleado);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error: Los datos NO se registraron");
                    }

                        
                }
                else
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        intIdEmpleado = objWCF.Modifica_OperadorLogistico(MOL);
                    }
                    else
                    {
                        intIdEmpleado = sdl.Modifica_OperadorLogistico(MOL);
                    }
                    
                    if (intIdEmpleado != 0)
                    {
                        MessageBox.Show("OK: Los datos se modificaron correctamente");
                        this.PintarDatosRegistro(intIdEmpleado);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error: Los datos NO se modificaron");
                        intIdEmpleado = MOL.iIdEmpleado;
                    }
                }
            }
        }

        private void Txt_CodDependencia_Leave(object sender, EventArgs e)
        {
            this.btn_Modificar.Enabled = false;

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_CodDependencia.Value)))
            {
                return;
            }

            string strCodDependencia = Convert.ToString( this.Txt_CodDependencia.Value );
            if (MyStuff.UsaWCF == true)
            {
                ME = objWCF.Recupera_Empleado_Codigo(Convert.ToString(this.Txt_CodDependencia.Value));
            }
            else
            {
                ME = sdl.Recupera_Empleado_Codigo(Convert.ToString(this.Txt_CodDependencia.Value));
            }
            
            
            if (Convert.ToString(ME.CCodPersonal).TrimEnd() != "")
            {
                this.Txt_ApeDependencia.Value = ME.VApePersonal;
                this.Txt_CodCentroGestor.Value = ME.CCodCentroGestor;
                this.Txt_DesCentroGestor.Value = ME.VNomCentroGestor;
                this.btn_Modificar.Enabled = true;
            }
            else
            {
                this.Txt_ApeDependencia.Value = "";
                this.Txt_ApeDependencia.Value = "";
                this.Txt_CodCentroGestor.Value = "";
                this.Txt_DesCentroGestor.Value = "";
            }
        }

        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";

            try
            {
                if ( string.IsNullOrEmpty( Convert.ToString( this.Txt_CodDependencia.Value ) ) )
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar El Código de la Jefatura";
                }

                if ( string.IsNullOrEmpty( Convert.ToString(  this.Txt_CodCentroGestor.Value ) ) )
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar El Código del Centro Gestor";
                }

                if ( string.IsNullOrEmpty( Convert.ToString( this.Txt_Email.Value ) ) )
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar E-Mail del Empleado";
                }

                if (blnVerifica == false)
                {
                   
                        MessageBox.Show(strMensaje,
                                        "Error", MessageBoxButtons.OKCancel,
                                        MessageBoxIcon.Error
                                   );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            return blnVerifica;
        }

        private void RegistroMovimiento(int intId)
        {
            m_Grid.DisplayLayout.Bands[0].AddNew();
            PintarDatosRegistro(intId);
        }

        private void PintarDatosRegistro(int intId)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = m_Grid.ActiveRow;
            oRow.Cells[0].Value = this.Txt_CodDependencia.Value;
            oRow.Cells[1].Value = this.Txt_ApeDependencia.Value;
            oRow.Cells[4].Value = this.Txt_CodCentroGestor.Value;
            oRow.Cells[5].Value = this.Txt_DesCentroGestor.Value;
            oRow.Cells[6].Value = this.Txt_Email.Value;
            oRow.Cells[7].Value = intId;
        }

        private void Frm_AsignaDependenciaOperadorLogistico_D_Load(object sender, EventArgs e)
        {

        }
    }
}
