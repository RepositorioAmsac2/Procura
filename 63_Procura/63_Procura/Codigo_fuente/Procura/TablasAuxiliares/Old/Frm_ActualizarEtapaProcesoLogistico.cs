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
        private string CentroCostoCodigo = "";
        private SRsafnet.SAFnetEClient objWCF = new SRsafnet.SAFnetEClient();

        private DataSet DS_CentroGestor = new DataSet();
        private DataSet DS_CentroBeneficio = new DataSet();
        private DataSet DS_Gerencia = new DataSet();
        private DataSet DS_UnidadEconomica = new DataSet();

        private WINformulacion.Framework FS = new WINformulacion.Framework();

        private Service.Data objDATA = new Service.Data();
        public Model.CentroCosto centrocostoanterior = new Model.CentroCosto();
        public Boolean blnGrabar = false;
        public Boolean EsNuevo = false;
        public Boolean IngresoDatos = false;
        public Frm_ActualizarEtapaProcesoLogistico()
        {
            InitializeComponent();
        }
        public void ShowMe(string _EmpresaCodigo,
                            string _CentroCostoCodigo,
                            Boolean _EsNuevo,
                            Model.CentroCosto centrocostoactual
                           )
        {
            EmpresaCodigo = _EmpresaCodigo;
            CentroCostoCodigo = _CentroCostoCodigo;
            EsNuevo = _EsNuevo;

            this.CargaTablasAuxiliares();

            if (EsNuevo == true)
            {
                this.pintarDatosCentroCosto(new Model.CentroCosto());
                this.Text = "Agregar un nuevo centro de costo";
            }

            else
            {
                this.Text = "Modificar datos del centro de costo";
                this.Btn_Grabar.Enabled = false;


                if (centrocostoactual.IidCeCo != 0)
                {
                    centrocostoanterior = centrocostoactual;
                }
                else
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        centrocostoanterior = objWCF.Recupera_CentroCosto_Codigo(EmpresaCodigo,
                                                            CentroCostoCodigo
                                                            );
                    }
                    else
                    {
                        centrocostoanterior = objDATA.Recupera_CentroCosto_Codigo(EmpresaCodigo,
                                                            CentroCostoCodigo
                                                            );
                    }

                }

                this.pintarDatosCentroCosto(centrocostoanterior);
            }

        }

        public void pintarDatosCentroCosto(Model.CentroCosto obj)
        {
            this.Txt_CodCentroCosto.Value = obj.CcodCeCo;
            this.Txt_NomCentroCosto.Value = obj.VnomCeCo;
            this.Txt_CodCentroGestor.Value = obj.CcodCeGe;
            this.Txt_NomCentroGestor.Value = obj.VnomCeGe;
            this.Txt_CodCentroBeneficio.Value = obj.CcodCeBe;
            this.Txt_NomCentroBeneficio.Value = obj.VnomCeBe;
            this.Txt_CodGerencia.Value = obj.CcodGerencia;
            this.Txt_NomGerencia.Value = obj.VnomGerencia;
            this.Txt_CodUnidadEconomica.Value = obj.CcodUnidadEconomica;
            this.Txt_NomUnidadEconomica.Value = obj.VnomUnidadEconomica;
        }
        public void CargaTablasAuxiliares()
        {
            if (MyStuff.UsaWCF == true)
            {
                DS_CentroGestor = objWCF.Ayuda_CentroGestor(MyStuff.CodigoEmpresa);
                DS_CentroBeneficio = objWCF.Ayuda_CentroBeneficio(MyStuff.CodigoEmpresa);
                DS_Gerencia = objWCF.Ayuda_Gerencia_HojaTrabajo(MyStuff.CodigoEmpresa);
                DS_UnidadEconomica = objWCF.Ayuda_UnidadEconomica(MyStuff.CodigoEmpresa);
            }
            else
            {
                DS_CentroGestor = objDATA.Ayuda_CentroGestor(MyStuff.CodigoEmpresa);
                DS_CentroBeneficio = objDATA.Ayuda_CentroBeneficio(MyStuff.CodigoEmpresa);
                DS_Gerencia = objDATA.Ayuda_Gerencia_HojaTrabajo(MyStuff.CodigoEmpresa);
                DS_UnidadEconomica = objDATA.Ayuda_UnidadEconomica(MyStuff.CodigoEmpresa);
            }
            this.Txt_CodCentroGestor.nombreDS = DS_CentroGestor;
            this.Txt_CodCentroBeneficio.nombreDS = DS_CentroBeneficio;
            this.Txt_CodGerencia.nombreDS = DS_Gerencia;
            this.Txt_CodUnidadEconomica.nombreDS  = DS_UnidadEconomica;

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

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_CodCentroCosto.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el Código del Centro de costo";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NomCentroCosto.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el Nombre del CentroCosto";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NomCentroGestor.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la descripción Centro Gestor";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NomCentroBeneficio.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la descripción Centro Beneficio";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NomGerencia.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la descripción de la Gerencia";
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NomUnidadEconomica.Value)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar la descripción de la Unidad Económica";
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
                    this.pintarDatosCentroCosto(new Model.CentroCosto());
                    this.Txt_CodCentroCosto.Focus();
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


        private Model.CentroCosto LLenaObjetoCentroCosto()
        {
            Model.CentroCosto MP = new Model.CentroCosto();

            if (EsNuevo == false) MP.IidCeCo = centrocostoanterior.IidCeCo;
            MP.CcodCeCo = Convert.ToString(this.Txt_CodCentroCosto.Value);
            MP.VnomCeCo = Convert.ToString(this.Txt_NomCentroCosto.Value);
            MP.CcodCeGe = Convert.ToString(this.Txt_CodCentroGestor.Value);
            MP.VnomCeGe = Convert.ToString(this.Txt_NomCentroGestor.Value);
            MP.CcodCeBe = Convert.ToString(this.Txt_CodCentroBeneficio.Value);
            MP.CcodGerencia = Convert.ToString(this.Txt_CodGerencia.Value);
            MP.CcodUnidadEconomica = Convert.ToString(this.Txt_CodUnidadEconomica.Value);

            return MP;
        }
        private bool Grabar()
        {
            bool blnGrabo = false;

            var centrocosto = LLenaObjetoCentroCosto();

            //'
            //' -- Grabar en el inventario
            //'

            int intIdCentroCosto = 0;

            if (this.EsNuevo)
            {
                if (MyStuff.UsaWCF == true)
                {
                    intIdCentroCosto = objWCF.Graba_CentroCosto(centrocosto);
                }
                else
                {
                    intIdCentroCosto = objDATA.Graba_CentroCosto(centrocosto);
                }
            }
            else
            {
                if (MyStuff.UsaWCF == true)
                {
                    intIdCentroCosto = objWCF.Modifica_CentroCosto(centrocosto);
                }
                else
                {
                    intIdCentroCosto = objDATA.Modifica_CentroCosto(centrocosto);
                }
            }


            if (intIdCentroCosto > 0)
            {
                blnGrabo = true;
                IngresoDatos = false;
                centrocosto.IidCeCo = intIdCentroCosto;
                centrocostoanterior = centrocosto;
            }
            return blnGrabo;
        }

        private void Btn_ListaProyecto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (HaModificadoValor())
            {
                this.IngresoDatos = true;
                centrocostoanterior = LLenaObjetoCentroCosto();
            }
            this.Close();
        }


        private Boolean HaModificadoValor()
        {
            var centrocosto = LLenaObjetoCentroCosto();
            Boolean HaModificado = false;
            Type t = centrocosto.GetType();
            PropertyInfo[] props = t.GetProperties();
            foreach (var prop in props)
            {
                string valoractual = Convert.ToString(prop.GetValue(centrocosto));
                string valoranterior = Convert.ToString(prop.GetValue(centrocostoanterior));

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
                    this.pintarDatosCentroCosto(centrocostoanterior);
                }

            }
            else
                this.pintarDatosCentroCosto(centrocostoanterior);
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_CodCentroGestor_Leave(object sender, EventArgs e)
        {
            this.Txt_NomCentroGestor.Value = FS.TraerDescripcion_DataTable(DS_CentroGestor.Tables[0],
                                        0,
                                        1,
                                        Convert.ToString(this.Txt_CodCentroGestor.Value)
                                        );

        }

        private void Txt_CodCentroBeneficio_Leave(object sender, EventArgs e)
        {
            this.Txt_NomCentroBeneficio.Value = FS.TraerDescripcion_DataTable(DS_CentroBeneficio.Tables[0],
                                                    0,
                                                    1,
                                                    Convert.ToString(this.Txt_CodCentroBeneficio.Value)
                                                    );

        }

        private void Txt_CodGerencia_Leave(object sender, EventArgs e)
        {
            this.Txt_NomGerencia.Value = FS.TraerDescripcion_DataTable(DS_Gerencia.Tables[0],
                                        0,
                                        1,
                                        Convert.ToString(this.Txt_CodGerencia.Value)
                                        );

        }

        private void Txt_CodUnidadEconomica_Leave(object sender, EventArgs e)
        {
            this.Txt_NomUnidadEconomica.Value = FS.TraerDescripcion_DataTable(DS_UnidadEconomica.Tables[0],
                                        0,
                                        1,
                                        Convert.ToString(this.Txt_CodUnidadEconomica.Value)
                                        );

        }
    }
}