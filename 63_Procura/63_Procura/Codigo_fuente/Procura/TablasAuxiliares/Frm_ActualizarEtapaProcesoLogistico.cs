using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace WINlogistica
{
    public partial class Frm_ActualizarEtapaProcesoLogistico : DevExpress.XtraEditors.XtraForm
    {
        private string EmpresaCodigo = "";
        private int PasoCodigo = 0;

        private DataSet DS_TipoPaso = new DataSet();
        private DataSet DS_TipoPlantilla = new DataSet();

        private WINlogistica.Framework FS = new WINlogistica.Framework();

        private Service.Data objDATA = new Service.Data();
        public Model.Paso pasoanterior = new Model.Paso();
        public Boolean blnGrabar = false;
        public Boolean EsNuevo = false;
        public Boolean IngresoDatos = false;
        public Frm_ActualizarEtapaProcesoLogistico()
        {
            InitializeComponent();
        }
        public void ShowMe(string _EmpresaCodigo,
                            int _PasoCodigo,
                            Boolean _EsNuevo,
                            Model.Paso pasoactual
                           )
        {
            EmpresaCodigo = _EmpresaCodigo;
            PasoCodigo = _PasoCodigo;
            EsNuevo = _EsNuevo;

            this.CargaTablasAuxiliares();

            if (EsNuevo == true)
            {
                this.pintarDatosPaso(new Model.Paso());
                this.Text = "Agregar un nuevo centro de costo";
            }

            else
            {
                this.Text = "Modificar datos del centro de costo";
                this.Btn_Grabar.Enabled = false;


                if (pasoactual.iIdPaso != 0)
                {
                    pasoanterior = pasoactual;
                }
                else
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        //jesus
                    }
                    else
                    {
                        pasoanterior = objDATA.Recupera_Paso(PasoCodigo );
                    }

                }

                this.pintarDatosPaso(pasoanterior);
            }

        }

        public void pintarDatosPaso(Model.Paso obj)
        {
            this.Txt_CodPaso.Value = obj.cCodPaso;
            this.Txt_NomPaso.Value = obj.vDesPaso;
            this.Txt_CodTipoPaso.Value = obj.cCodTipoPaso;
            this.Txt_NomTipoPaso.Value = obj.vDesTipoPaso;
            this.Txt_CodTipoPlantilla.Value = obj.cCodTipoPlantilla;
            this.Txt_NomTipoPlantilla.Value = obj.vDesTipoPlantilla;
            this.Txt_Formulario.Value = obj.vFormulario;
        }
        public void CargaTablasAuxiliares()
        {
            if (MyStuff.UsaWCF == true)
            {
                //jesus
            }
            else
            {
                DS_TipoPaso = objDATA.Ayuda_TipoPaso();
                DS_TipoPlantilla = objDATA.Ayuda_TipoPlantilla();
            }
            this.Txt_CodTipoPaso.nombreDS = DS_TipoPaso;
            this.Txt_CodTipoPlantilla.nombreDS = DS_TipoPlantilla;

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

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_CodPaso.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el Código de la etapa";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NomPaso.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el Nombre de la Etapa";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NomTipoPaso.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la descripción del tipo de etapa";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NomTipoPlantilla.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la descripción del tipo de plantilla";
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
                    this.pintarDatosPaso(new Model.Paso());
                    this.Txt_CodPaso.Focus();
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


        private Model.Paso LLenaObjetoPaso()
        {
            Model.Paso MP = new Model.Paso();

            if (EsNuevo == false) MP.iIdPaso = pasoanterior.iIdPaso;
            MP.cCodPaso = Convert.ToString(this.Txt_CodPaso.Value);
            MP.vDesPaso = Convert.ToString(this.Txt_NomPaso.Value);
            MP.cCodTipoPaso = Convert.ToString(this.Txt_CodTipoPaso.Value);
            MP.vDesTipoPaso = Convert.ToString(this.Txt_NomTipoPaso.Value);
            MP.cCodTipoPlantilla = Convert.ToString(this.Txt_CodTipoPlantilla.Value);
            MP.vDesTipoPlantilla = Convert.ToString(this.Txt_NomTipoPlantilla.Value);
            MP.vFormulario = Convert.ToString(this.Txt_Formulario.Value);

            return MP;
        }
        private bool Grabar()
        {
            bool blnGrabo = false;

            var paso = LLenaObjetoPaso();

            //'
            //' -- Grabar en el inventario
            //'

            int intIdPaso = 0;

            if (this.EsNuevo)
            {
                if (MyStuff.UsaWCF == true)
                {
                    //intIdPaso = objWCF.Graba_Paso(paso);
                }
                else
                {
                    intIdPaso = objDATA.Graba_Paso(paso);
                }
            }
            else
            {
                if (MyStuff.UsaWCF == true)
                {
                    //intIdPaso = objWCF.Modifica_Paso(paso);
                }
                else
                {
                    intIdPaso = objDATA.Modifica_Paso(paso);
                }
            }


            if (intIdPaso > 0)
            {
                blnGrabo = true;
                IngresoDatos = false;
                paso.iIdPaso = intIdPaso;
                pasoanterior = paso;
            }
            return blnGrabo;
        }

        private void Btn_ListaProyecto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (HaModificadoValor())
            {
                this.IngresoDatos = true;
                pasoanterior = LLenaObjetoPaso();
            }
            this.Close();
        }


        private Boolean HaModificadoValor()
        {
            var paso = LLenaObjetoPaso();
            Boolean HaModificado = false;
            Type t = paso.GetType();
            PropertyInfo[] props = t.GetProperties();
            foreach (var prop in props)
            {
                string valoractual = Convert.ToString(prop.GetValue(paso));
                string valoranterior = Convert.ToString(prop.GetValue(pasoanterior));

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
                    this.pintarDatosPaso(pasoanterior);
                }

            }
            else
                this.pintarDatosPaso(pasoanterior);
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Txt_CodTipoPaso_Leave(object sender, EventArgs e)
        {
            this.Txt_NomTipoPaso.Value = FS.TraerDescripcion_DataTable(DS_TipoPaso.Tables[0],
                            0,
                            1,
                            Convert.ToString(this.Txt_CodTipoPaso.Value)
                            );

        }

        private void Txt_CodTipoPlantilla_Leave(object sender, EventArgs e)
        {
            this.Txt_NomTipoPlantilla.Value = FS.TraerDescripcion_DataTable(DS_TipoPlantilla.Tables[0],
                                        0,
                                        1,
                                        Convert.ToString(this.Txt_CodTipoPlantilla.Value)
                                        );

        }
    }
}