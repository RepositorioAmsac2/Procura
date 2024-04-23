using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WINlogistica.Modulo;


namespace WINlogistica.Principal
{
    public partial class FM_MenuPrincipal : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private Service.Data objDATA = new Service.Data();

        string strLogUsuario = "";
        string strCodModulo = "";
        private string strCodempresa = "";
        private string strCodEmpleado = "";
        public FM_MenuPrincipal()
        {
            InitializeComponent();
        }

        public void ShowMe(string strCodUsuario,
                    string cCodModulo,
                    string cLogUsuario,
                    String cCodEmpleado,
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
            strCodEmpleado = cCodEmpleado;

            //if (ImagenMenu != null)
            //    this.IconOptions.Image = ByteToImage(ImagenMenu);

            MyStuff.AñoProceso = strAñoProceso;


            Model.Usuario_Empresa objMU = new Model.Usuario_Empresa();
            //jesusif (MyStuff.UsaWCF)
                //jesusobjMU = objWCF.Recupera_Usuario_Empresa_Codigo(strCodempresa, strLogUsuario);
            //jesuselse
                objMU = objDATA.Recupera_Usuario_Empresa_Codigo(strCodempresa, strCodEmpleado);

            MyStuff.Empresa = strNomEmpresa;
            MyStuff.NombreEmpresa = strNomEmpresa;
            MyStuff.CodigoEmpleado = strCodEmpleado;
            MyStuff.NombreEmpleado = objMU.Nombre;
            MyStuff.PeriodoProceso = strAñoProceso;
            MyStuff.CodigoCentroGestor = objMU.CcodCeGe;
            MyStuff.CodigoCentroCosto = objMU.CcodCeCo;
            MyStuff.NombreCentroCosto = objMU.VnomCeCo;
            MyStuff.NombreCentroGestor = objMU.VnomCeGe;
            this.Btn_Usuario.Caption = objMU.Nombre.TrimEnd() + " [" + MyStuff.CodigoCentroGestor.TrimEnd() + "]";

            string strUsuariosControTotal = "";

            if (MyStuff.UsaWCF == true)
            {
                //jesusstrCentroGestorTotal = objWCF.Recupera_ParametroFormulacion_Codigo(MyStuff.CodigoEmpresa, "150").vValParametro;
                //jesusstrCentroGestor_ManejaInversion = objWCF.Recupera_ParametroFormulacion_Codigo(MyStuff.CodigoEmpresa, "212").vValParametro;
            }
            else
            {
                strUsuariosControTotal = objDATA.Recupera_ParametroLogistica_Codigo("03").vValParametroLogistica.TrimEnd();
            }

            if (strUsuariosControTotal.IndexOf(strCodEmpleado.TrimEnd()) < 0)
            {
                //Habilitar - Deshabilitar Opciones
                this.Opc_PAC.Visible = false;
                this.Opc_Dashboard.Visible = false;
                this.Opc_DatosAuxiliares.Visible = false;
                this.Opc_Configuracion.Visible = false;
                this.Btn_Programacion.Visible = false;
                this.Btn_CurvaS_Procura.Visible = false;
                this.Btn_Gantt.Visible = false;

                //if ( strCentroGestor_ManejaInversion.IndexOf(MyStuff.CodigoCentroGestor.TrimEnd()) < 0)
                //    this.OPC_Fproyectoexterno.Visible = false;

            }
            else
                MyStuff.TieneControlTotal = true;



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

        private void Btn_GeneracioData_Dashboard_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Trayendo información...");

            if (!container.Controls.Contains(UC_HojaTrabajo_Dashboard.Instance))
            {
                container.Controls.Add(UC_HojaTrabajo_Dashboard.Instance);
                UC_HojaTrabajo_Dashboard.Instance.Dock = DockStyle.Fill;
                UC_HojaTrabajo_Dashboard.Instance.BringToFront();
            }
            UC_HojaTrabajo_Dashboard.Instance.BringToFront();
            SplashScreenManager.CloseForm();

        }

        private void Btn_TableroControl_Dashboard_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Trayendo formato del Dashboard...");

            if (!container.Controls.Contains(Dashboard.Instance))
            {
                container.Controls.Add(Dashboard.Instance);
                Dashboard.Instance.Dock = DockStyle.Fill;
                Dashboard.Instance.BringToFront();
            }
            Dashboard.Instance.BringToFront();
            SplashScreenManager.CloseForm();

        }

        private void Btn_Empresa_Click(object sender, EventArgs e)
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

        private void Btn_CurvaS_Reporte_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Trayendo procesos de contratación...");

            if (!container.Controls.Contains(UC_Grafico_CurvaS_Reporte.Instance))
            {
                container.Controls.Add(UC_Grafico_CurvaS_Reporte.Instance);
                UC_Grafico_CurvaS_Reporte.Instance.Dock = DockStyle.Fill;
                UC_Grafico_CurvaS_Reporte.Instance.BringToFront();
            }
            UC_Grafico_CurvaS_Reporte.Instance.BringToFront();
            SplashScreenManager.CloseForm();
        }

        private void Btn_CurvaS_Procura_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Trayendo lista del PAC...");

            if (!container.Controls.Contains(UC_Grafico_CurvaS_Procura.Instance))
            {
                container.Controls.Add(UC_Grafico_CurvaS_Procura.Instance);
                UC_Grafico_CurvaS_Procura.Instance.Dock = DockStyle.Fill;
                UC_Grafico_CurvaS_Procura.Instance.BringToFront();
            }
            UC_Grafico_CurvaS_Procura.Instance.BringToFront();
            SplashScreenManager.CloseForm();

        }

        private void Btn_ListaProcesoCOntratacion_Click(object sender, EventArgs e)
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

        private void Btn_Enlazar_Proceso_Operador_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Cargando formato de enlace...");

            if (!container.Controls.Contains(UC_EnlazaProceso_OperadorLogistico.Instance))
            {
                container.Controls.Add(UC_EnlazaProceso_OperadorLogistico.Instance);
                UC_EnlazaProceso_OperadorLogistico.Instance.Dock = DockStyle.Fill;
                UC_EnlazaProceso_OperadorLogistico.Instance.BringToFront();
            }
            UC_EnlazaProceso_OperadorLogistico.Instance.BringToFront();
            SplashScreenManager.CloseForm();
        }

        private void Btn_ControlItemPAC_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Cargando lista PAC...");

            if (!container.Controls.Contains(UC_Seguimiento_PAC.Instance))
            {
                container.Controls.Add(UC_Seguimiento_PAC.Instance);
                UC_Seguimiento_PAC.Instance.Dock = DockStyle.Fill;
                UC_Seguimiento_PAC.Instance.BringToFront();
            }
            UC_Seguimiento_PAC.Instance.BringToFront();
            SplashScreenManager.CloseForm();
        }

        private void Btn_Programacion_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Cargando formato de programación...");

            if (!container.Controls.Contains(UC_Programacion_CurvaS.Instance))
            {
                container.Controls.Add(UC_Programacion_CurvaS.Instance);
                UC_Programacion_CurvaS.Instance.Dock = DockStyle.Fill;
                UC_Programacion_CurvaS.Instance.BringToFront();
            }
            UC_Programacion_CurvaS.Instance.BringToFront();
            SplashScreenManager.CloseForm();
        }

        private void Btn_VistaDashboard_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Cargando vista de dashboard...");

            if (!container.Controls.Contains(UC_Vista_Dashboard.Instance))
            {
                container.Controls.Add(UC_Vista_Dashboard.Instance);
                UC_Vista_Dashboard.Instance.Dock = DockStyle.Fill;
                UC_Vista_Dashboard.Instance.BringToFront();
            }
            UC_Vista_Dashboard.Instance.BringToFront();
            SplashScreenManager.CloseForm();
        }

        private void Btn_ProcesosPorArea_Click(object sender, EventArgs e)
        {
            //SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            //SplashScreenManager.Default.SetWaitFormDescription("Cargando dashboard por areas...");

            //if (!container.Controls.Contains(UC_Dashboard_Area.Instance))
            //{
            //    container.Controls.Add(UC_Dashboard_Area.Instance);
            //    UC_Dashboard_Area.Instance.Dock = DockStyle.Fill;
            //    UC_Dashboard_Area.Instance.BringToFront();
            //}
            //UC_Dashboard_Area.Instance.BringToFront();
            //SplashScreenManager.CloseForm();

            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Cargando dashboard por areas...");

            if (!container.Controls.Contains(UC_ProcesoLogistico_Dashboard.Instance))
            {
                container.Controls.Add(UC_ProcesoLogistico_Dashboard.Instance);
                UC_ProcesoLogistico_Dashboard.Instance.Dock = DockStyle.Fill;
                UC_ProcesoLogistico_Dashboard.Instance.BringToFront();
            }
            UC_ProcesoLogistico_Dashboard.Instance.BringToFront();
            SplashScreenManager.CloseForm();
        }

        private void Btn_EstudioMercado_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Cargando lista...");

            if (!container.Controls.Contains(UC_Lista_EstudioMerdado.Instance))
            {
                container.Controls.Add(UC_Lista_EstudioMerdado.Instance);
                UC_Lista_EstudioMerdado.Instance.Dock = DockStyle.Fill;
                UC_Lista_EstudioMerdado.Instance.BringToFront();
            }
            UC_Lista_EstudioMerdado.Instance.BringToFront();
            SplashScreenManager.CloseForm();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Cargando lista items PAC...");

            if (!container.Controls.Contains(UC_Grafico_Gantt_Reporte.Instance))
            {
                container.Controls.Add(UC_Grafico_Gantt_Reporte.Instance);
                UC_Grafico_Gantt_Reporte.Instance.Dock = DockStyle.Fill;
                UC_Grafico_Gantt_Reporte.Instance.BringToFront();
            }
            UC_Grafico_Gantt_Reporte.Instance.BringToFront();
            SplashScreenManager.CloseForm();
        }

        private void accordionControlElement18_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Cargando lista parametros...");

            if (!container.Controls.Contains(UC_Lista_Parametro.Instance))
            {
                container.Controls.Add(UC_Lista_Parametro.Instance);
                UC_Lista_Parametro.Instance.Dock = DockStyle.Fill;
                UC_Lista_Parametro.Instance.BringToFront();
            }
            UC_Lista_Parametro.Instance.BringToFront();
            SplashScreenManager.CloseForm();
        }

        private void Btn_AperturaEtapaSeguimiento_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Cargando lista del PAC...");

            if (!container.Controls.Contains(UC_AperuraEtapa_Seguimiento_PAC.Instance))
            {
                container.Controls.Add(UC_AperuraEtapa_Seguimiento_PAC.Instance);
                UC_AperuraEtapa_Seguimiento_PAC.Instance.Dock = DockStyle.Fill;
                UC_AperuraEtapa_Seguimiento_PAC.Instance.BringToFront();
            }
            UC_AperuraEtapa_Seguimiento_PAC.Instance.BringToFront();
            SplashScreenManager.CloseForm();
        }

        private void accordionControlElement20_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Cargando formato de etapas...");

            if (!container.Controls.Contains(UC_Actualiza_TipoProceso_Duracion.Instance))
            {
                container.Controls.Add(UC_Actualiza_TipoProceso_Duracion.Instance);
                UC_Actualiza_TipoProceso_Duracion.Instance.Dock = DockStyle.Fill;
                UC_Actualiza_TipoProceso_Duracion.Instance.BringToFront();
            }
            UC_Actualiza_TipoProceso_Duracion.Instance.BringToFront();
            SplashScreenManager.CloseForm();
        }

        private void accordionControlElement19_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Cargando formato de etapas...");

            if (!container.Controls.Contains(UC_Lista_EtapaProcesoLogistico.Instance))
            {
                container.Controls.Add(UC_Lista_EtapaProcesoLogistico.Instance);
                UC_Lista_EtapaProcesoLogistico.Instance.Dock = DockStyle.Fill;
                UC_Lista_EtapaProcesoLogistico.Instance.BringToFront();
            }
            UC_Lista_EtapaProcesoLogistico.Instance.BringToFront();
            SplashScreenManager.CloseForm();
        }
    }
}
