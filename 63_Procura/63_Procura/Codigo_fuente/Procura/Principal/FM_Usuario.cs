using System;

namespace WINlogistica.Principal
{
    public partial class FM_Usuario : DevExpress.XtraEditors.XtraForm
    {
        public FM_Usuario()
        {
            InitializeComponent();
        }

        public void ShowMe()
        {
            this.Lbl_Empresa.Text = MyStuff.NombreEmpresa;
            this.Lbl_Empleado.Text = MyStuff.NombreEmpleado;
            this.Lbl_Periodo.Text = MyStuff.PeriodoProceso;
            this.Lbl_CentroCosto.Text = MyStuff.CodigoCentroCosto.TrimEnd() + "- "  +
                                        MyStuff.NombreCentroCosto;
            this.Lbl_CentroGestor.Text = MyStuff.CodigoCentroGestor.TrimEnd() + "- " +
                                            MyStuff.NombreCentroGestor;

            this.ToggleSwitch.IsOn = MyStuff.UsaWCF;

            this.ShowDialog();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_CambioContraseña_Click(object sender, EventArgs e)
        {
            Frm_ResetearContrasenia frm = new Frm_ResetearContrasenia();
            frm.ShowMe(MyStuff.CodigoEmpresa,
                        MyStuff.CodigoUsuario
                        );
        }

        private void ToggleSwitch_EditValueChanged(object sender, EventArgs e)
        {
            if (this.ToggleSwitch.IsOn == true)
                MyStuff.UsaWCF = true;
            else
                MyStuff.UsaWCF = false;
        }
    }
}