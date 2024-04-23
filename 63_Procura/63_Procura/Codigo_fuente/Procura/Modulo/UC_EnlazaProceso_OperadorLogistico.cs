﻿using DevExpress.XtraGrid.Columns;
using DevExpress.XtraSplashScreen;
using System;
using System.Data;
using System.Windows.Forms;

namespace WINlogistica.Modulo
{
    public partial class UC_EnlazaProceso_OperadorLogistico : DevExpress.XtraEditors.XtraUserControl
    {
        private WINlogistica.Framework FS = new WINlogistica.Framework();
        //private SRsafnet.SAFnetEClient objWCF = new SRsafnet.SAFnetEClient();
        private Service.Data objDATA = new Service.Data();

        private DataSet DS_OperadorLogistico = new DataSet();
        private DataSet DS_movimiento = new DataSet();

        Model.ParametroLogistica MPL = new Model.ParametroLogistica();
        Model.ProcesoLogistico_OperadorLogistico MPDOL = new Model.ProcesoLogistico_OperadorLogistico();

        private static UC_EnlazaProceso_OperadorLogistico _instance;
        public static UC_EnlazaProceso_OperadorLogistico Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_EnlazaProceso_OperadorLogistico();
                return _instance;
            }
        }
        public UC_EnlazaProceso_OperadorLogistico()
        {
            InitializeComponent();
            this.IniciaTablas(true);
        }

        private void IniciaTablas(bool CargaCGestor)
        {
            if (MyStuff.CodigoEmpleado.TrimEnd() == "")
            {
                MyStuff.CodigoEmpleado = "XX";
            }

            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                MPL = objDATA.Recupera_ParametroLogistica_Codigo(MyStuff.CodigoEmpleado.TrimEnd());
            }

            if (MPL.vValParametroLogistica.TrimEnd() == "")
            {
                if (MyStuff.UsaWCF == true)
                {
                    //jesus
                }
                else
                {
                    MPL = objDATA.Recupera_ParametroLogistica_Codigo("12");
                }

                if (MPL.vValParametroLogistica.TrimEnd() != "")
                {
                    MyStuff.CodigoJefatura = MPL.vValParametroLogistica;
                }
            }
            else
            {
                MyStuff.CodigoJefatura = MyStuff.CodigoEmpleado;
            }
            if (MyStuff.UsaWCF == true)
            {
                //jesus
            }
            else
            {
                DS_OperadorLogistico = objDATA.Ayuda_OperadorLogistico_Jefatura(MyStuff.CodigoJefatura);
            }
            this.Txt_CodOperadorLogistico.nombreDS = DS_OperadorLogistico;
        }

        private void Btn_AdicionarElegidos_Click(object sender, EventArgs e)
        {
            if (Items_PorSeleccionar())
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                SplashScreenManager.Default.SetWaitFormDescription("Trasladando Procedimientos...");


                Boolean blnGraba = false;

                for (int i = 0; i < Grd_PorSelecconar_A.RowCount; i++)
                {
                    if (Convert.ToBoolean(Grd_PorSelecconar_A.GetDataRow(i)[0]) == true)
                    {
                        MPDOL.cAñoProceso = MyStuff.AñoProceso;
                        MPDOL.cCodProcesoLogistico = Convert.ToString(Grd_PorSelecconar_A.GetDataRow(i)[1]);
                        MPDOL.cCodOperadorLogistico = Convert.ToString(this.Txt_CodOperadorLogistico.Value);

                        objDATA.Graba_ProcesoLogistico_OperadorLogistico(MPDOL);
                        blnGraba = true;
                    }
                }
                SplashScreenManager.CloseForm();
                if (blnGraba == true)
                {
                    PintarDatos();
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un Número de Proceso Logistico");
            }
        }

        private Boolean Items_PorSeleccionar()
        {
            Boolean blnResult = false;
            for (int i = 0; i < Grd_PorSelecconar_A.RowCount; i++)
            {
                if (Convert.ToBoolean(Grd_PorSelecconar_A.GetDataRow(i)[0]) == true)
                {
                    blnResult = true;
                }
            }
            return blnResult;
        }

        private Boolean Items_Seleccionados()
        {
            Boolean blnResult = false;
            for (int i = 0; i < Grd_Selecconados_A.RowCount; i++)
            {
                if (Convert.ToBoolean(Grd_Selecconados_A.GetDataRow(i)[0]) == true)
                {
                    blnResult = true;
                }
            }
            return blnResult;
        }


        private void Btn_QuitarElegidos_Click(object sender, EventArgs e)
        {
            if (Items_Seleccionados())
            {
                SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
                SplashScreenManager.Default.SetWaitFormDescription("Quitando Procedimientos...");

                int intIdOperadorLogistico = 0;
                Boolean blnElimina = false;

                for (int i = 0; i < Grd_Selecconados_A.RowCount; i++)
                {
                    if (Convert.ToBoolean(Grd_Selecconados_A.GetDataRow(i)[0]) == true)
                    {
                        intIdOperadorLogistico = Convert.ToInt32(Grd_Selecconados_A.GetDataRow(i)[3]);
                        objDATA.Elimina_ProcesoLogistico_OperadorLogistico(intIdOperadorLogistico);
                        blnElimina = true;
                    }
                }
                SplashScreenManager.CloseForm();
                if (blnElimina == true)
                {
                    PintarDatos();
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un número de Proceso Logistico");
            }
        }

        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(this.Txt_ApeOperadorLogistico.Value)))
            {
                MessageBox.Show("Debe Elegir un Operador Logistico",
                                 "Advertencia",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation
                                );
            }
            else
            {
                PintarDatos();
            }
        }

        private void PintarDatos()
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true);
            SplashScreenManager.Default.SetWaitFormDescription("Trayendo información...");

            //Debe pintar los proyectos por elegir
            if (MyStuff.UsaWCF == true)
            {

            }
            else
            {

                DS_movimiento = objDATA.Lista_ProcesoLogistico_OperadorLogistico(MyStuff.CodigoEmpresa,
                                                                            MyStuff.AñoProceso,
                                                                            Convert.ToString(this.Txt_CodOperadorLogistico.Value)
                                                                          );
            }

            this.grd_porseleccionar.DataSource = DS_movimiento.Tables[0];
            this.grd_porseleccionados.DataSource = DS_movimiento.Tables[1];

            PintarFormato();

            SplashScreenManager.CloseForm();
        }

        private void PintarFormato()
        {
            // Por Seleccionar
            this.Grd_PorSelecconar_A.OptionsBehavior.Editable = true;
            this.Grd_PorSelecconar_A.OptionsFind.AlwaysVisible = true;
            this.Grd_PorSelecconar_A.OptionsView.ColumnAutoWidth = false;
            this.Grd_PorSelecconar_A.Columns["iIdProcesoLogistico_OperadorLogistico"].Visible = false;
            this.Grd_PorSelecconar_A.Columns["cCodOperadorLogistico"].Visible = false;
            // Formatear columnas de la grilla
            GridColumn colPaseA = this.Grd_PorSelecconar_A.Columns["Pase"];
            colPaseA.Caption = "?";
            colPaseA.Fixed = FixedStyle.Left;
            colPaseA.Width = 20;

            GridColumn colLineaA = this.Grd_PorSelecconar_A.Columns["cCodProcesoLogistico"];
            colLineaA.Fixed = FixedStyle.Left;
            colLineaA.Width = 100;

            GridColumn colNombreA = this.Grd_PorSelecconar_A.Columns["tDesContratacion"];
            colNombreA.Fixed = FixedStyle.Left;
            colNombreA.Width = 440;

            // Por Seleccionados
            this.Grd_Selecconados_A.OptionsBehavior.Editable = true;
            this.Grd_Selecconados_A.OptionsFind.AlwaysVisible = true;
            this.Grd_Selecconados_A.OptionsView.ColumnAutoWidth = false;
            this.Grd_Selecconados_A.Columns["iIdProcesoLogistico_OperadorLogistico"].Visible = false;
            this.Grd_Selecconados_A.Columns["cCodOperadorLogistico"].Visible = false;


            // Formatear columnas de la grilla
            GridColumn colPaseB = this.Grd_Selecconados_A.Columns["Pase"];
            colPaseB.Caption = "?";
            colPaseB.Fixed = FixedStyle.Left;
            colPaseB.Width = 20;

            GridColumn colCodigoB = this.Grd_Selecconados_A.Columns["cCodProcesoLogistico"];
            colCodigoB.Fixed = FixedStyle.Left;
            colCodigoB.Width = 100;

            GridColumn colNombreB = this.Grd_Selecconados_A.Columns["tDesContratacion"];
            colNombreB.Fixed = FixedStyle.Left;
            colNombreB.Width = 440;
        }

        private void OptModificacion_CheckedChanged(object sender, EventArgs e)
        {
            this.IniciaTablas(false);
        }

        private void OptFormulacion_CheckedChanged(object sender, EventArgs e)
        {
            this.IniciaTablas(false);
        }

        

        private void Txt_CodOperadorLogistico_Leave(object sender, EventArgs e)
        {
            this.Txt_ApeOperadorLogistico.Value = FS.TraerDescripcion_DataTable(DS_OperadorLogistico.Tables[0],
                                                                            0,
                                                                            1,
                                                                            Convert.ToString(this.Txt_CodOperadorLogistico.Value)
                                                                            );

        }
    }
}
