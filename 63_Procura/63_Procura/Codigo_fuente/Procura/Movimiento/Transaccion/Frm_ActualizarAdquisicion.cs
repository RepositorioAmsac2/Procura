using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraSplashScreen;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace WINlogistica
{
    public partial class Frm_ActualizarAdquisicion : DevExpress.XtraEditors.XtraForm
    {
        private string EmpresaCodigo = "";
        private string AdquisicionCodigo = "";
        //private SRsafnet.SAFnetEClient objWCF = new SRsafnet.SAFnetEClient();
        private Service.Data objDATA = new Service.Data();
        public Model.ProcesoAdquisicion adquisicionanterior = new Model.ProcesoAdquisicion();
        public Boolean blnGrabar = false;
        public Boolean EsNuevo = false;
        public Boolean IngresoDatos = false;

        string strAñoProceso = "";
        string strPeriodoProceso = "";
        string strCodCentroCosto = "";
        public Boolean LlamadaDesdeHojaTrabajo = false;
        public Frm_ActualizarAdquisicion()
        {
            InitializeComponent();
        }
        public void ShowMe(string _EmpresaCodigo,
                            string _AdquisicionCodigo,
                            Boolean _EsNuevo,
                            Model.ProcesoAdquisicion adquisicionactual,
                            string cAñoProceso = "",
                            string cPeriodoProceso = ""
                           )
        {
            EmpresaCodigo = _EmpresaCodigo;
            AdquisicionCodigo = _AdquisicionCodigo;

            strAñoProceso = cAñoProceso;
            strPeriodoProceso = cPeriodoProceso;
            EsNuevo = _EsNuevo;

             

            this.CargaTablasAuxiliares();

            if (EsNuevo == true )
            {
                this.pintarDatosAdquisicion(new Model.ProcesoAdquisicion());
                this.Text = "Agregar un nuevo adquisicion";

            }

            else
            {
                this.Text = "Modificar datos del adquisicion";
                this.Btn_Grabar.Enabled = false;


                if (adquisicionactual.iIdProcesoAdquisicion != 0)
                {
                    adquisicionanterior = adquisicionactual;
                }
                else
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        //jesus
                    }
                    else
                    {
                        //erroradquisicionanterior = objDATA.Recupera_ProcesoAdquisicion(EmpresaCodigo,
                        //                                    AdquisicionCodigo
                        //                                    );
                    }

                }

                this.pintarDatosAdquisicion(adquisicionanterior);

                //errorif (VisualizaAdquisicion == true)
                //{
                //    this.Btn_Grabar.Enabled = false;
                //    this.Btn_ListaAdquisicion.Enabled = false;
                //    this.Btn_ValorInicial.Enabled = false;

                //    //this.Btn_Grabar_Salir.Enabled = false;
                //    //this.Btn_AdicionarElegidos.Enabled = false;
                //    //this.Btn_AdicionarElegidos_ff.Enabled = false;
                //    //this.Btn_QuitarElegidos.Enabled = false;
                //    //this.Btn_QuitarElegidos_ff.Enabled = false;
                //}
            }

        }
        
        public void pintarDatosAdquisicion(Model.ProcesoAdquisicion obj)
        {
            if (obj.iIdProcesoAdquisicion != 0)
            {
                this.Edt_NomAdquisicion.EditValue = obj.tDesContratacion;
                this.Txt_Justificacion.EditValue = obj.tObjetivo;
                this.Cbo_TipoProceso.SelectedValue = obj.cCodTipoProceso;
                this.Txt_NumProcedimiento.Text = obj.cNumProcedimiento;
                this.Cbo_ObjetoContratacion.SelectedValue = obj.cCodObjetoContratacion;
                this.Cbo_TipoAdquisicion.SelectedValue = obj.cCodTipoAdquisicion;
                this.Cbo_EntidadConvocante.SelectedValue = obj.cCodEntidadEncargadaConvocante;
                this.Cbo_ModalidadSeleccion.SelectedValue = obj.cCodModalidadSeleccion;
                this.Dtp_FechaPrevista.Value = obj.dFechaPrevista;
            }
            else
            {
                this.Edt_NomAdquisicion.EditValue = "";
                this.Txt_Justificacion.EditValue = "";
                this.Txt_NumProcedimiento.Text = "";
                this.Dtp_FechaPrevista.Value = DateTime.Now;

            }
        }
        public void CargaTablasAuxiliares()
        {
            if (MyStuff.UsaWCF == true)
            {
                //jesus
            }
            else
            {
                this.Cbo_TipoProceso.CargaDT(objDATA.Combo_TipoProceso().Tables[0]);

                this.Cbo_ObjetoContratacion.CargaDT(objDATA.Combo_ObjetoContratacion( (string)this.Cbo_TipoProceso.SelectedValue).Tables[0]);

                this.Cbo_TipoAdquisicion.CargaDT(objDATA.Combo_TipoAdquisicion().Tables[0]);

                this.Cbo_EntidadConvocante.CargaDT(objDATA.Combo_EntidadEncargadaConvocante().Tables[0]);

                this.Cbo_EntidadConvocante.SelectedValue = objDATA.Recupera_ParametroLogistica_Codigo("20").vValParametroLogistica.TrimEnd(); ;

                this.Cbo_ModalidadSeleccion.CargaDT(objDATA.Combo_ModalidadSeleccion().Tables[0]);

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
                    XtraMessageBoxArgs argumentos = new XtraMessageBoxArgs();
                    argumentos.Caption = "Advertencia";
                    argumentos.Text = "Desea ingresar Fuentes de financiamiento y Componentes ?";
                    argumentos.Buttons = new DialogResult[] { DialogResult.Yes, DialogResult.No };
                    argumentos.Icon = System.Drawing.SystemIcons.Question; // <-- Mucho más simple

                    if (EsNuevo)
                    {
                        if (XtraMessageBox.Show(argumentos) == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.AdquisicionCodigo = adquisicionanterior.cCodProcesoAdquisicion;
                            this.EsNuevo = false;
                            this.Btn_Grabar.Enabled = false;
                            this.Btn_Grabar_Salir.Enabled = true;
                        }
                        else
                            this.Close();
                    }
                    else
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


            //if (string.IsNullOrEmpty(Convert.ToString(this.Txt_CodAdquisicion.EditValue)))
            //{
            //    blnVerifica = false;
            //    strMensaje = "Debe ingresar el Código del Adquisicion";
            //}

            if (string.IsNullOrEmpty(Convert.ToString(this.Edt_NomAdquisicion.EditValue)))
            {
                blnVerifica = false;
                strMensaje = "Debe ingresar el Nombre del Adquisicion";
            }

            //if (string.IsNullOrEmpty(Convert.ToString(this.Txt_NomCortoAdquisicion.EditValue)))
            //{
            //    blnVerifica = false;
            //    strMensaje = "Debe ingresar la descripción Corta del Adquisicion";
            //}

            //if (string.IsNullOrEmpty(Convert.ToString(this.Txt_CodClaseOrden.EditValue)))
            //{
            //    blnVerifica = false;
            //    strMensaje = "Debe ingresar la clase de orden del Adquisicion";
            //}

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
                    if (EsNuevo) 
                    {
                        this.blnGrabar = true;
                        this.Btn_Grabar.Enabled = true;
                        this.Btn_Grabar_Salir.Enabled = true;
                        this.pintarDatosAdquisicion(new Model.ProcesoAdquisicion());
                        this.Edt_NomAdquisicion.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Los Datos se actualizaron correctamente");
                        this.blnGrabar = true;
                        this.pintarDatosAdquisicion(new Model.ProcesoAdquisicion());
                        this.Edt_NomAdquisicion.Focus();
                    }
                }
                else
                {
                    if (EsNuevo) MessageBox.Show("Error en la insercción de datos");
                    else MessageBox.Show("Error en la modificación de datos");
                }
            }
        }


        private Model.ProcesoAdquisicion LLenaObjetoAdquisicion()
        {
            Model.ProcesoAdquisicion MP = new Model.ProcesoAdquisicion();

            if (EsNuevo == false) MP.iIdProcesoAdquisicion = adquisicionanterior.iIdProcesoAdquisicion;


            return MP;
        }
        private bool Grabar()
        {
            bool blnGrabo = false;

            var adquisicion = LLenaObjetoAdquisicion();

            //'
            //' -- Grabar en el inventario
            //'

            Model.ProcesoAdquisicion MP = new Model.ProcesoAdquisicion();

            if (this.EsNuevo)
            {
                if (MyStuff.UsaWCF == true)
                {
                    //jesus
                }
                else
                {
                    //MP = objDATA.Graba_ProcesoAdquisicion(adquisicion);
                }
            }
            else
            {
                if (MyStuff.UsaWCF == true)
                {
                    //jesus
                }
                else
                {
                    //MP = objDATA.Modifica_Adquisicion(adquisicion);
                }
            }


            if ( MP.iIdProcesoAdquisicion > 0)
            {
                blnGrabo = true;
                IngresoDatos = false;
                adquisicion.iIdProcesoAdquisicion = MP.iIdProcesoAdquisicion;
                adquisicion.cCodProcesoAdquisicion = MP.cCodProcesoAdquisicion;
                adquisicionanterior = adquisicion;
            }
            return blnGrabo;
        }

        private void Btn_ListaAdquisicion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (HaModificadoValor())
            {
                this.IngresoDatos = true;
                adquisicionanterior = LLenaObjetoAdquisicion();
            }
            this.Close();
        }


        private Boolean HaModificadoValor()
        {
            var adquisicion = LLenaObjetoAdquisicion();
            Boolean HaModificado = false;
            Type t = adquisicion.GetType();
            PropertyInfo[] props = t.GetProperties();
            foreach (var prop in props)
            {
                string valoractual = Convert.ToString(prop.GetValue(adquisicion));
                string valoranterior = Convert.ToString(prop.GetValue(adquisicionanterior));

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
                    this.pintarDatosAdquisicion(adquisicionanterior);
                }

            }
            else
                this.pintarDatosAdquisicion(adquisicionanterior);
        }

        private void Btn_Descripcion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_BorrarImagen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

    }
}