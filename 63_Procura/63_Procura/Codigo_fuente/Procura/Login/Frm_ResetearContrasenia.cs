using System;
using System.Windows.Forms;
namespace WINlogistica
{
    public partial class Frm_ResetearContrasenia : DevExpress.XtraEditors.XtraForm
    {
        private Service.Data objDATA = new Service.Data();
        //private SRsafnet.SAFnetEClient objWCF = new SRsafnet.SAFnetEClient();
        private string strCodEmpresa = "";
        private string strUsuario = "";
        public Frm_ResetearContrasenia()
        {
            InitializeComponent();
        }

        public void ShowMe(string cCodEmpresa,
                            string cUsuario
                          )
        {
            strCodEmpresa = cCodEmpresa;
            strUsuario = cUsuario;
            this.ShowDialog();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(this.txtNuevaContrasenia.EditValue)))
                MessageBox.Show("Debe ingresar una contraseña nueva");
            else
            {
                if (string.IsNullOrEmpty(Convert.ToString(this.txtRepiteNuevaContrasenia.EditValue)))
                    MessageBox.Show("Debe ingresar una contraseña repetida");
                else
                {
                    string strNuevoContraseña = Convert.ToString(this.txtNuevaContrasenia.EditValue).TrimEnd();
                    string strNuevoContraseñaRepetido = Convert.ToString(this.txtRepiteNuevaContrasenia.EditValue).TrimEnd();

                    if (strNuevoContraseña != strNuevoContraseñaRepetido)
                        MessageBox.Show("Las contraseñas no coinciden");
                    else
                    {
                        Model.Usuario oUsuarioReseteaContrasenia = new Model.Usuario();
                        string strLogUsuario = strUsuario.ToUpper();//FN.Framework.Funciones.FN_CifradoDato.encripta(this.txtUsuario.Text.Trim().ToUpper(), this.txtUsuario.Text.Trim().Length); ;
                                                                                     //jesusstring strCodEmpresa = objData.Recupera_ParametroFormulacion_Codigo("817").vValParametro.TrimEnd();
                        oUsuarioReseteaContrasenia = objDATA.Recupera_Usuario_Codigo(strCodEmpresa, strLogUsuario);
                        System.Collections.ArrayList arrValoresEncriptado = FN.Framework.Funciones.FN_RecoveryData.Encripta_Contraseña(this.txtNuevaContrasenia.Text.Trim().ToUpper());
                        oUsuarioReseteaContrasenia.cCodEmpresa = strCodEmpresa;
                        oUsuarioReseteaContrasenia.tClaUsuario = ((string)arrValoresEncriptado[0]).Trim(); ;
                        oUsuarioReseteaContrasenia.tPasUsuario = ((string)arrValoresEncriptado[1]).Trim(); ;
                        oUsuarioReseteaContrasenia.tVecUsuario = ((string)arrValoresEncriptado[2]).Trim(); ;

                        bool resultado = false;

                        if (MyStuff.UsaWCF)
                        {
                            //jesusresultado = objDATA.Modifica_Usuario(oUsuarioReseteaContrasenia);
                        }
                        else
                            resultado = objDATA.Modifica_Usuario(oUsuarioReseteaContrasenia);

                        if (resultado)
                        {
                            DialogResult dialogResult = MessageBox.Show("Reseteo de Contrasela exitoso",
                                                "Reseteo Contraseña",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                            if (dialogResult == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                    }

                }
            }
        }
    }
}
