using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WINlogistica.Modulo;

namespace WINlogistica.Principal
{
    public partial class FM_Principal : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private Service.Data objDATA = new Service.Data();

        string strLogUsuario = "";
        string strCodModulo = "";
        private string strCodempresa = "";
#pragma warning disable CS0414 // El campo 'FM_Principal.strCodEmpleado' está asignado pero su valor nunca se usa
        private string strCodEmpleado = "";
#pragma warning restore CS0414 // El campo 'FM_Principal.strCodEmpleado' está asignado pero su valor nunca se usa
        public FM_Principal()
        {
            InitializeComponent();
        }

        public void ShowMe(string strCodUsuario,
                    string cCodModulo,
                    string cLogUsuario,
                    string cCodEmpresa,
                    string strNomEmpresa,
                    string strAñoProceso,
                    byte[] ImagenMenu
                  )
        {

            MyStuff.CodigoUsuario = strCodUsuario;
            strCodempresa = cCodEmpresa;
            strCodModulo = cCodModulo;
            strLogUsuario = cLogUsuario;

            if (ImagenMenu != null)
                this.IconOptions.Image = ByteToImage(ImagenMenu);

            //Model.Usuario objMU = new Model.Usuario();

            //Model.Empleado objME = new Model.Empleado();

            //if (MyStuff.UsaWCF == true)
            //{
            //    objMU = objWCF.Recupera_Usuario_Codigo(strCodempresa, strLogUsuario);
            //}
            //else
            //{
            //    objMU = objDATA.Recupera_Usuario_Codigo(strCodempresa, strLogUsuario);
            //}

            //strCodEmpleado = objMU.cCodEmpleado;

            //if (MyStuff.UsaWCF == true)
            //{
            //    objME = objWCF.Recupera_Empleado_Codigo(objMU.cCodEmpleado);
            //}
            //else
            //{
            //    objME = objDATA.Recupera_Empleado_Codigo(objMU.cCodEmpleado);
            //}


            //MyStuff.CodigoEmpleado = strCodEmpleado;
            MyStuff.AñoProceso = strAñoProceso;
            //MyStuff.DigitoCentroGestor = objME.Idigito;
            //MyStuff.CodigoCentroGestorSuperior = objME.CCodCentroGestor;
            //MyStuff.NombreEmpresa = strNomEmpresa;

            //Model.ParametroGestion MPG = new Model.ParametroGestion();

            //MyStuff.NombreEmpleado = objMU.vDesEmpleado;
            //MyStuff.PeriodoProceso = strAñoProceso;
            //MyStuff.CodigoCentroGestor = objME.CCodCentroGestor;
            //MyStuff.CodigoCentroCosto = objME.CCodCentroCosto;
            //MyStuff.NombreCentroCosto = objME.VNomCentroCosto;
            //MyStuff.NombreCentroGestor = objME.VNomCentroGestor;

            //this.Btn_Usuario.Caption = objMU.vDesEmpleado.TrimEnd() + " [" + MyStuff.CodigoCentroGestor.TrimEnd() + "]";



            Model.Usuario_Empresa objMU = new Model.Usuario_Empresa();
            //jesusif (MyStuff.UsaWCF)
                //jesusobjMU = objWCF.Recupera_Usuario_Empresa_Codigo(strCodempresa, strLogUsuario);
            //jesuselse
                objMU = objDATA.Recupera_Usuario_Empresa_Codigo(strCodempresa, strLogUsuario);

            MyStuff.Empresa = strNomEmpresa;
            MyStuff.NombreEmpresa = strNomEmpresa;
            MyStuff.NombreEmpleado = objMU.Nombre;
            MyStuff.PeriodoProceso = strAñoProceso;
            MyStuff.CodigoCentroGestor = objMU.CcodCeGe;
            MyStuff.CodigoCentroCosto = objMU.CcodCeCo;
            MyStuff.NombreCentroCosto = objMU.VnomCeCo;
            MyStuff.NombreCentroGestor = objMU.VnomCeGe;
            this.Btn_Usuario.Caption = objMU.Nombre.TrimEnd() + " [" + MyStuff.CodigoCentroGestor.TrimEnd() + "]";

            string strCentroGestorTotal = "";
            string strCentroGestor_ManejaInversion = "";

            if (MyStuff.UsaWCF == true)
            {
                //jesusstrCentroGestorTotal = objWCF.Recupera_ParametroFormulacion_Codigo(MyStuff.CodigoEmpresa, "150").vValParametro;
                //jesusstrCentroGestor_ManejaInversion = objWCF.Recupera_ParametroFormulacion_Codigo(MyStuff.CodigoEmpresa, "212").vValParametro;
            }
            else
            {
                strCentroGestorTotal = objDATA.Recupera_ParametroFormulacion_Codigo(MyStuff.CodigoEmpresa, "150").vValParametro;
                strCentroGestor_ManejaInversion = objDATA.Recupera_ParametroFormulacion_Codigo(MyStuff.CodigoEmpresa, "212").vValParametro;
            }

            if (MyStuff.CodigoCentroGestor.TrimEnd() != strCentroGestorTotal.TrimEnd())
            {
                //Habilitar - Deshabilitar Opciones
                //this.Opc_Dashboard.Visible = false;
                //this.Opc_Configuracion_HojaTrabajo.Visible = false;
                //this.Opc_Utilitario_HojaTrabajo.Visible = false;
                //this.Reportes_HojaTrabajo.Visible = false;
                //this.Formatos_HojaTrabajo.Visible = false;
                //this.Opc_EjecucionPresupuestal.Visible = false;
                //this.Opc_DatosAuxiliares.Visible = false;
                //this.Opc_Configuracion.Visible = false;
                //this.Opc_ImportarFormatos_HojaTrabajo.Visible = false;
                //this.Opc_Procesos_Modificacion_HojaTrabajo.Visible = false;
                //this.Opc_Modificacion.Visible = false;

                //if ( strCentroGestor_ManejaInversion.IndexOf(MyStuff.CodigoCentroGestor.TrimEnd()) < 0)
                //    this.OPC_Fproyectoexterno.Visible = false;

            }
            //else
            //    MyStuff.TieneControlTotal = true;



            this.Show();
        }

        Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }


        private void Btn_Usuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            FM_Usuario frm = new FM_Usuario();
            frm.ShowMe();
        }

        private void FM_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Esta por finalizar el acceso a la aplicacion, realmente desea salir ? ",
                                        "Salir", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question
                                    ) == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {

        }

        private void Opc_Configuracion_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Trayendo datos de la empresa...");

            if (!container.Controls.Contains(UC_ActualizaEmpresa.Instance))
            {
                container.Controls.Add(UC_ActualizaEmpresa.Instance);
                UC_ActualizaEmpresa.Instance.Dock = DockStyle.Fill;
                UC_ActualizaEmpresa.Instance.BringToFront();
            }
            UC_ActualizaEmpresa.Instance.BringToFront();
            SplashScreenManager.CloseForm();
        }

        private void accordionControlElement25_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Trayendo procesos de contratación...");

            if (!container.Controls.Contains(UC_ControlProcesoLogistico.Instance))
            {
                container.Controls.Add(UC_ControlProcesoLogistico.Instance);
                UC_ControlProcesoLogistico.Instance.Dock = DockStyle.Fill;
                UC_ControlProcesoLogistico.Instance.BringToFront();
            }
            UC_ActualizaEmpresa.Instance.BringToFront();
            SplashScreenManager.CloseForm();
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Trayendo procesos de contratación...");

            if (!container.Controls.Contains(UC_Lista_PAC.Instance))
            {
                container.Controls.Add(UC_Lista_PAC.Instance);
                UC_Lista_PAC.Instance.Dock = DockStyle.Fill;
                UC_Lista_PAC.Instance.BringToFront();
            }
            UC_Lista_PAC.Instance.BringToFront();
            SplashScreenManager.CloseForm();
        }
    }
}
