using DevExpress.XtraEditors;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace WINlogistica
{
    public partial class Frm_ActualizarParametro : DevExpress.XtraEditors.XtraForm
    {
        private string EmpresaCodigo = "";
        private string ParametroCodigo = "";
        //private SRsafnet.SAFnetEClient objWCF = new SRsafnet.SAFnetEClient();

        private WINlogistica.Framework FS = new WINlogistica.Framework();

        private Service.Data objDATA = new Service.Data();
        public Model.ParametroLogistica parametroanterior = new Model.ParametroLogistica();
        public Boolean blnGrabar = false;
        public Boolean EsNuevo = false;
        public Boolean IngresoDatos = false;
        public Frm_ActualizarParametro()
        {
            InitializeComponent();
        }
        public void ShowMe(string _EmpresaCodigo,
                            string _ParametroCodigo,
                            Boolean _EsNuevo,
                            Model.ParametroLogistica parametroactual
                           )
        {
            EmpresaCodigo = _EmpresaCodigo;
            ParametroCodigo = _ParametroCodigo;
            EsNuevo = _EsNuevo;

            this.CargaTablasAuxiliares();

            if (EsNuevo == true)
            {
                this.pintarDatosParametro(new Model.ParametroLogistica());
                this.Text = "Agregar un nuevo parametro";
            }

            else
            {
                this.Text = "Modificar datos del parametro";
                this.Btn_Grabar.Enabled = false;


                if (parametroactual.iIdParametroLogistica != 0)
                {
                    parametroanterior = parametroactual;
                }
                else
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        //jesus
                    }
                    else
                    {
                        parametroanterior = objDATA.Recupera_ParametroLogistica_Codigo(ParametroCodigo
                                                            );
                    }

                }

                this.pintarDatosParametro(parametroanterior);
            }

        }

        public void pintarDatosParametro(Model.ParametroLogistica obj)
        {
            this.Txt_CodParametro.Value = obj.cCodParametroLogistica;
            this.Txt_NomParametro.Value = obj.vDesParametroLogistica;
            this.Txt_ValParametro.Value = obj.vValParametroLogistica;
        }
        public void CargaTablasAuxiliares()
        {
            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
            }
        }


        private void Btn_Grabar_Salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.VerificaIngresoMovimiento() == true)
            {
                if (Grabar() == true)
                {
                    MessageBox.Show("Los Datos se grabaron correctamente");
                    this.blnGrabar = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error en la insercción de datos");
                }
            }
        }

        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_CodParametro.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el Código del Parametro";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NomParametro.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el Nombre del Parametro";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_ValParametro.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el valor del Parametro";
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


        private void Btn_Grabar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Btn_Grabar.Enabled = false;
            this.Btn_Grabar_Salir.Enabled = false;
            if (this.VerificaIngresoMovimiento() == true)
            {
                if (Grabar() == true)
                {
                    if (EsNuevo) MessageBox.Show("Los Datos se grabaron correctamente");
                    else
                        MessageBox.Show("Los Datos se actuaizaron correctamente");

                    this.blnGrabar = true;
                    this.pintarDatosParametro(new Model.ParametroLogistica());
                    this.Txt_CodParametro.Focus();
                }
                else
                {
                    if (EsNuevo) MessageBox.Show("Error en la insercción de datos");
                    else MessageBox.Show("Error en la modificación de datos");
                }

            }
            this.Btn_Grabar.Enabled = true;
            this.Btn_Grabar_Salir.Enabled = true;
        }


        private Model.ParametroLogistica LLenaObjetoParametro()
        {
            Model.ParametroLogistica MP = new Model.ParametroLogistica();

            if (EsNuevo == false) MP.iIdParametroLogistica = parametroanterior.iIdParametroLogistica;
            //MP.cCodEmpresaLogistica = MyStuff.CodigoEmpresa;
            MP.cCodParametroLogistica = Convert.ToString(this.Txt_CodParametro.Value);
            MP.vDesParametroLogistica = Convert.ToString(this.Txt_NomParametro.Value);
            MP.vValParametroLogistica = Convert.ToString(this.Txt_ValParametro.Value);

            return MP;
        }
        private bool Grabar()
        {
            bool blnGrabo = false;

            var parametro = LLenaObjetoParametro();

            //'
            //' -- Grabar en el inventario
            //'

            int intIdParametro = 0;

            if (this.EsNuevo)
            {
                if (MyStuff.UsaWCF == true)
                {
                    //intIdParametro = objWCF.Graba_ParametroFormulacion(parametro);
                }
                else
                {
                    intIdParametro = objDATA.Graba_ParametroLogistica(parametro);
                }
            }
            else
            {
                if (MyStuff.UsaWCF == true)
                {
                    //intIdParametro = objWCF.Modifica_ParametroFormulacion(parametro);
                }
                else
                {
                    intIdParametro = objDATA.Modifica_ParametroLogistica(parametro);
                }
            }


            if (intIdParametro > 0)
            {
                blnGrabo = true;
                IngresoDatos = false;
                parametro.iIdParametroLogistica = intIdParametro;
                parametroanterior = parametro;
            }
            return blnGrabo;
        }

        private void Btn_ListaProyecto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (HaModificadoValor())
            {
                this.IngresoDatos = true;
                parametroanterior = LLenaObjetoParametro();
            }
            this.Close();
        }


        private Boolean HaModificadoValor()
        {
            var parametro = LLenaObjetoParametro();
            Boolean HaModificado = false;
            Type t = parametro.GetType();
            PropertyInfo[] props = t.GetProperties();
            foreach (var prop in props)
            {
                string valoractual = Convert.ToString(prop.GetValue(parametro));
                string valoranterior = Convert.ToString(prop.GetValue(parametroanterior));

                if (valoractual.TrimEnd() != valoranterior.TrimEnd())
                {
                    HaModificado = true;
                    break;
                }
            }
            return HaModificado;
        }



        private void Btn_Salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (HaModificadoValor())
            {
                XtraMessageBoxArgs argumentos = new XtraMessageBoxArgs();
                argumentos.Caption = "Advertencia";
                argumentos.Text = "Ha hecho modificaciones a la informacion, de todas maneras desea salir?";
                argumentos.Buttons = new DialogResult[] { DialogResult.Yes, DialogResult.No };
                argumentos.Icon = System.Drawing.SystemIcons.Question; // <-- Mucho más simple
                if (XtraMessageBox.Show(argumentos) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }

            }
            else
                this.Close();
        }

        private void Btn_ValorInicial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (HaModificadoValor())
            {
                XtraMessageBoxArgs argumentos = new XtraMessageBoxArgs();
                argumentos.Caption = "Advertencia";
                argumentos.Text = "Ha hecho modificaciones a la informacion, de todas maneras desea traer valores iniciales?";
                argumentos.Buttons = new DialogResult[] { DialogResult.Yes, DialogResult.No };
                argumentos.Icon = System.Drawing.SystemIcons.Question; // <-- Mucho más simple
                if (XtraMessageBox.Show(argumentos) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.pintarDatosParametro(parametroanterior);
                }

            }
            else
                this.pintarDatosParametro(parametroanterior);
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}