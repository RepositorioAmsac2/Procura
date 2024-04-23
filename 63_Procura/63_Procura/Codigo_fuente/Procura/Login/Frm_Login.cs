using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using WINlogistica.Principal;


namespace WINlogistica
{
    public partial class Frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public SymmetricAlgorithm mCSP;
        Model.Usuario objMUsuario = new Model.Usuario();

        //private SRsafnet.SAFnetEClient objWCF = new SRsafnet.SAFnetEClient();
        private Service.Data objDATA = new Service.Data();
        Model.Empresa_Login EL = new Model.Empresa_Login();
        

        public Frm_Login()
        {
            InitializeComponent();
        }

        #region Overrides

        #endregion


        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_Usuario.EditValue)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el correo electronico";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_Contraseña.EditValue)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la contraseña";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Cbo_Empresa.EditValue)))
            {
                blnVerifica = false;
                strMensaje = "Debe elegir la empresa";
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


        private void Btn_Acceso_Click(object sender, EventArgs e)
        {


            if (VerificaIngresoMovimiento())
            {

                string strLogUsuario = "";
                string strUsuario = Convert.ToString(this.Txt_Usuario.Text).TrimEnd().ToUpper();
                string strContraseña = Convert.ToString(this.Txt_Contraseña.Text).TrimEnd().ToUpper();
                string strAñoProceso = Convert.ToString(this.Txt_Periodo.EditValue);
                string strCodEmpresa = Convert.ToString(this.Cbo_Empresa.EditValue);
                string strNomEmpresa = Convert.ToString(this.Cbo_Empresa.Text);

                if (strContraseña != "" & strUsuario != "")
                {
                    strLogUsuario = strUsuario; // FN.Framework.Funciones.FN_CifradoDato.encripta(strUsuario, strUsuario.Length);
                    Model.Usuario objMU = new Model.Usuario();

                    if (MyStuff.UsaWCF == true)
                    {
                        //objMU = objWCF.Recupera_Usuario_Codigo(strCodEmpresa, strLogUsuario);
                    }
                    else
                    {
                        objMU = objDATA.Recupera_Usuario_Codigo(strCodEmpresa, strLogUsuario);
                    }



                    if (objMU.tPasUsuario.TrimEnd() != "")
                    {
                        string strClave = "";
                        strClave =  FN.Framework.Funciones.FN_RecoveryData.Desencripta_Contraseña(objMU.tPasUsuario.TrimEnd(),
                                                               objMU.tClaUsuario.Trim(),
                                                               objMU.tVecUsuario
                                                          );

                        if (strClave.TrimEnd().ToUpper() != strContraseña)
                        {
                            MessageBox.Show("La contraseña no corresponde al Usuario");
                            this.Txt_Contraseña.Focus();
                        }
                        else
                        {

                            if (this.ToggleSwitch.IsOn == true)
                            {
                                WINlogistica.Properties.Settings.Default.User = Convert.ToString(this.Txt_Usuario.EditValue).TrimEnd();
                                WINlogistica.Properties.Settings.Default.Password = Convert.ToString(this.Txt_Contraseña.EditValue).TrimEnd();
                            }
                            else
                            {
                                WINlogistica.Properties.Settings.Default.User = "";
                                WINlogistica.Properties.Settings.Default.Password = "";
                            }
                            WINlogistica.Properties.Settings.Default.Save();

                            //SplashScreenManager.ShowForm(typeof(Movimiento.WaitForm1));
                            FM_MenuPrincipal frm = new FM_MenuPrincipal();

                            frm.ShowMe(strUsuario, 
                                        "232", 
                                        strLogUsuario, 
                                        objMU.cCodEmpleado,
                                        strCodEmpresa, 
                                        strNomEmpresa, 
                                        strAñoProceso,
                                        EL.Pimg_LogoMenu
                                        );
                            //SplashScreenManager.CloseForm();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Usuario No esta Registrado");
                        this.Txt_Usuario.Focus();
                    }
                }


            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_CorreoElectronico_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

            try
            {

                DataTable dt = new DataTable();
                DataTable dtE = new DataTable();

                if (MyStuff.UsaWCF == true)
                {
                    //jesusdt = objWCF.Combo_PeriodoProceso_DataTable().Tables[0];
                }
                else
                {
                    dt = objDATA.Combo_PeriodoProceso_DataTable().Tables[0];
                }


                if (dt.Rows.Count > 0)
                {
                    this.Txt_Periodo.Properties.DataSource = dt;
                    this.Txt_Periodo.Properties.DisplayMember = "cPeriodo";
                    this.Txt_Periodo.Properties.ValueMember = "cValor";
                    this.Txt_Periodo.ItemIndex = 0;
                }

                if (MyStuff.UsaWCF == true)
                {
                    //jesusdtE = objWCF.Combo_Empresa_DataTable().Tables[0];
                }
                else
                {
                    dtE = objDATA.Combo_Empresa_DataTable().Tables[0];
                }

                if (dtE.Rows.Count > 0)
                {
                    this.Cbo_Empresa.Properties.DataSource = dtE;
                    this.Cbo_Empresa.Properties.DisplayMember = "vNomEmpresa";
                    this.Cbo_Empresa.Properties.ValueMember = "cCodEmpresa";
                    this.Cbo_Empresa.ItemIndex = 0;

                    var strCodEmpresa = Convert.ToString(dtE.Rows[0][0]);

                    if (MyStuff.UsaWCF == true)
                    {
                        //jesusEL = objWCF.Recupera_Empresa_Login(strCodEmpresa);
                    }
                    else
                        EL = objDATA.Recupera_Empresa_Login(strCodEmpresa);

                    if (EL.Pimg_LogoCentro != null)
                        this.Img_Centro.Image =  ByteToImage(EL.Pimg_LogoCentro );
                    if (EL.Pimg_LogoIzquierdo != null)
                       this.Img_Izquierdo.Image = ByteToImage(EL.Pimg_LogoIzquierdo);
                }

                if (string.IsNullOrEmpty(WINlogistica.Properties.Settings.Default.User.TrimEnd()))
                {
                    this.ToggleSwitch.IsOn = false;
                }
                else
                {
                    this.ToggleSwitch.IsOn = true;
                    this.Txt_Usuario.EditValue = WINlogistica.Properties.Settings.Default.User.TrimEnd();
                    this.Txt_Contraseña.EditValue = WINlogistica.Properties.Settings.Default.Password.TrimEnd();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (string.IsNullOrEmpty(WINlogistica.Properties.Settings.Default.User.TrimEnd()))
            {
                this.ToggleSwitch.IsOn = false;
            }
            else
            {
                this.ToggleSwitch.IsOn = true;
                this.Txt_Usuario.EditValue = WINlogistica.Properties.Settings.Default.User.TrimEnd();
                this.Txt_Contraseña.EditValue = WINlogistica.Properties.Settings.Default.Password.TrimEnd();
            }
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

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Img_Izquierdo_Click(object sender, EventArgs e)
        {

        }
    }
}