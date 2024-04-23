using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Infragistics.Win.UltraWinGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraSplashScreen;

namespace WINlogistica
{
    public partial class Frm_EnlazaRequerimiento_CreaProceso_Detalle : DevExpress.XtraEditors.XtraForm
    {
        public List<string> arrFormulacion = new List<string>();
        public Boolean blnEligio = false;
        DataSet DS_Formulacion = new DataSet();
        private string strNumRequerimiento = "";
        private string strDesProceso = "";

        private string strPaso = "";
        private string strCodCentroGestor = "";
        private string strEsUnProceso = "";
        private string strCodPac = "";
        private string strCodEmpleado = "";

        private Service.Data sdl = new Service.Data();


        public Frm_EnlazaRequerimiento_CreaProceso_Detalle()
        {
            InitializeComponent();
        }

        public void ShowMe(string cNumRequerimiento,
                            string vDesProceso,
                            string cPaso,
                            string cCodCentroGestor,
                            string cEsUnProceso,
                            string cCodPac,
                            string cCodEmpleado
                           )
        {
            strNumRequerimiento = cNumRequerimiento;
            strDesProceso = vDesProceso;

            strPaso = cPaso;
            strCodCentroGestor = cCodCentroGestor;
            strEsUnProceso = cEsUnProceso;
            strCodPac = cCodPac;
            strCodEmpleado = cCodEmpleado;
        SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("trayendo detalle de requerimiento...");

            this.Text = "Detalle de requerimiento: " + strNumRequerimiento;

            DS_Formulacion = sdl.lista_ProcesoLogistico_CreaProceso_Detalle(strNumRequerimiento);
            this.Grd_Formulacion.DataSource = DS_Formulacion.Tables[0];
            FormatoGrid();
            SplashScreenManager.CloseForm();
            this.ShowDialog();
        }

        private void FormatoGrid()
        {
            // Por Seleccionar
            this.Grd_Ayuda.OptionsBehavior.Editable = true;
            this.Grd_Ayuda.OptionsFind.AlwaysVisible = true;
            this.Grd_Ayuda.OptionsView.ColumnAutoWidth = false;

            // Formatear columnas de la grilla
            GridColumn colPase = this.Grd_Ayuda.Columns["Pase"];
            colPase.Caption = "?";
            colPase.Fixed = FixedStyle.Left;
            colPase.Width = 20;
            GridColumn colOrden = this.Grd_Ayuda.Columns["Codigo"];
            colPase.Caption = "Orden";
            colPase.Fixed = FixedStyle.Left;
            colPase.Width = 20;

            GridColumn colCodigo = this.Grd_Ayuda.Columns["LineaFormulacion"];
            colCodigo.Fixed = FixedStyle.Left;
            colCodigo.Width = 300;
            colCodigo.AppearanceCell.BackColor = Color.LightGreen;
            colCodigo.AppearanceCell.ForeColor = Color.Black;

            GridColumn colImporte = this.Grd_Ayuda.Columns["Importe"];
            colImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            colImporte.DisplayFormat.FormatString = "###,###,###.00";
            //colImporte.AppearanceCell.BackColor2 = Color.DarkBlue;
            colImporte.AppearanceCell.BackColor = Color.LightGreen;
            colImporte.AppearanceCell.ForeColor = Color.Black;
            colImporte.Fixed = FixedStyle.Right;

            GridColumn colClasificador = this.Grd_Ayuda.Columns["Clasificador"];
            colClasificador.Width = 250;
            GridColumn colProyecto = this.Grd_Ayuda.Columns["Proyecto"];
            colProyecto.Width = 350;
            GridColumn colComponente = this.Grd_Ayuda.Columns["Componente"];
            colComponente.Width = 220;
            GridColumn colClaseGasto = this.Grd_Ayuda.Columns["ClaseGasto"];
            colClaseGasto.Width = 110;
            GridColumn colFuenteFinanciamiento = this.Grd_Ayuda.Columns["FuenteFinanciamiento"];
            colFuenteFinanciamiento.Width = 200;
            GridColumn colCentroGestor = this.Grd_Ayuda.Columns["CentroGestor"];
            colCentroGestor.Width = 250;
            GridColumn colCentroCosto = this.Grd_Ayuda.Columns["CentroCosto"];
            colCentroCosto.Width = 250;
            GridColumn colPosicionPresupuestal = this.Grd_Ayuda.Columns["PosicionPresupuestal"];
            colPosicionPresupuestal.Width = 300;
        }


        private void Grd_Ayuda_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void Frm_AyudaHojaTrabajo_Load(object sender, EventArgs e)
        {

        }

        private Boolean Items_PorSeleccionar()
        {
            Boolean blnResult = false;

            foreach(DataRow row in DS_Formulacion.Tables[0].Rows)
            {
                if (Convert.ToBoolean(row["Pase"]) == true)
                {
                    blnResult = true;
                }
            }

            //for (int i = 0; i < Grd_Ayuda.RowCount; i++)
            //{
            //    if (Convert.ToBoolean(Grd_Ayuda.GetDataRow(i)["Pase"]) == true)
            //    {
            //        blnResult = true;
            //    }
            //}
            return blnResult;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (Items_PorSeleccionar())
            {
                string strNumProcedimiento = "";
                int intIdRequerimiento_Detalle = 0;

                double dblFormulacion = 0.0;
                foreach (DataRow row in DS_Formulacion.Tables[0].Rows)
                {
                    if (Convert.ToBoolean(row["Pase"]) == true)
                    {
                        dblFormulacion = dblFormulacion + Convert.ToDouble(row["Importe"]);
                    }
                }

                WINlogistica.Frm_EnlazaRequerimiento_CreaProceso_Numero frm = new WINlogistica.Frm_EnlazaRequerimiento_CreaProceso_Numero();
                frm.ShowMe(strNumRequerimiento,
                            strDesProceso,
                            dblFormulacion,
                            strPaso,
                            strCodCentroGestor,
                            strEsUnProceso,
                            strCodPac,
                            strCodEmpleado
                            );

                if ( string.IsNullOrEmpty( frm.strNumProcedimiento ) == false)
                {
                    SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                    SplashScreenManager.Default.SetWaitFormDescription("Creando Proceso...");

                    strNumProcedimiento = frm.strNumProcedimiento;
                    foreach (DataRow row in DS_Formulacion.Tables[0].Rows)
                    {
                        if (Convert.ToBoolean(row["Pase"]) == true)
                        {
                            intIdRequerimiento_Detalle = Convert.ToInt32(row["iIdRequerimiento_Detalle"]);
                            sdl.graba_ProcesoLogistico_Requerimiento_LineaFormulacion(strNumRequerimiento,
                                                                                      strNumProcedimiento,
                                                                                      intIdRequerimiento_Detalle
                                                                                     );
                        }
                    }
                    SplashScreenManager.CloseForm();

                }
                blnEligio = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe elegir una linea de formulación");
            }

        }

        private void Btn_MostrarSuma_Click(object sender, EventArgs e)
        {
            double dblFormulacion = 0.0;
            foreach (DataRow row in DS_Formulacion.Tables[0].Rows)
            {
                if (Convert.ToBoolean(row["Pase"]) == true)
                {
                    dblFormulacion = dblFormulacion + Convert.ToDouble(row["Importe"]);
                    //arrFormulacion.Add(strCodLineaFormulacion);
                }
            }

            if (dblFormulacion > 0 )
            {
                String s = String.Format("El total procesado es: {0:C2}",
                         dblFormulacion);
                MessageBox.Show(s,
                                "Sumatoria"
                                );
            }
            else
            {
                MessageBox.Show("Debe elefir una linea de formulación", "Advertencia");
            }
        }
    }
}