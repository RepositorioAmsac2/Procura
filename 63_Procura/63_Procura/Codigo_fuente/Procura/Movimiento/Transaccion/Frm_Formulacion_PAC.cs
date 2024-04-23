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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data;
using DevExpress.XtraSplashScreen;

namespace WINlogistica
{
    public partial class Frm_Formulacion_PAC : DevExpress.XtraEditors.XtraForm
    {
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        Service.Data sdl = new Service.Data();
        public DataTable DT_Formulacion_Origen = new DataTable();
        public string strCodFormulacion = "";
        public bool blnEligio = false;
        public Frm_Formulacion_PAC()
        {
            InitializeComponent();
        }

        public void ShowMe(string strCodCompañia,
                            string strAñoProceso,
                            string strLineasElegidas
                          )
        {
            //SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            //SplashScreenManager.Default.SetWaitFormDescription("Trayendo la formulación...");
            if (MyStuff.UsaWCF == true)
            {
                DT_Formulacion_Origen = objWCF.Elige_Formulacion_General(strCodCompañia,
                                                                        strAñoProceso,
                                                                        strLineasElegidas
                                                                   ).Tables[0];
            }
            else
            {
                DT_Formulacion_Origen = sdl.Elige_Formulacion_General(strCodCompañia,
                                                                     strAñoProceso,
                                                                     strLineasElegidas
                                                                   ).Tables[0];
            }

            this.Grd_General.DataSource = DT_Formulacion_Origen;
            this.FormatoGrid();

            //SplashScreenManager.CloseForm();

            ShowDialog();
        }



        private void FormatoGrid()
        {
            
            this.Grd_Ayuda.OptionsFind.AlwaysVisible = true;
            this.Grd_Ayuda.OptionsView.ColumnAutoWidth = false;
            this.Grd_Ayuda.Columns["cCodFormulacion"].Visible = false;

            // Formatear columnas de la grilla
            GridColumn colElige = this.Grd_Ayuda.Columns["Elige"];
            colElige.Width = 20;

            GridColumn colFormulacion = this.Grd_Ayuda.Columns["LineaFormulacion"];
            colFormulacion.Fixed = FixedStyle.Left;
            colFormulacion.Width = 400;
            //colFormulacion.AppearanceCell.BackColor2 = Color.DarkBlue;
            colFormulacion.AppearanceCell.BackColor = Color.LightGreen;
            colFormulacion.AppearanceCell.ForeColor = Color.Black;

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
            GridColumn colCentroCosto = this.Grd_Ayuda.Columns["CentroCosto"];
            colCentroCosto.Width = 250;
            GridColumn colPosicionPresupuestal = this.Grd_Ayuda.Columns["PosicionPresupuestal"];
            colPosicionPresupuestal.Width = 300;
        }

        private void Grd_Ayuda_Load(object sender, EventArgs e)
        {

        }

        private void Grd_Ayuda_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void Btn_LineaElegida_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(this.Grd_Ayuda.GetFocusedRowCellValue("LineaFormulacion"))) == false)
            {
                String message = "Ha elegido la linea: " + this.Grd_Ayuda.GetFocusedRowCellValue("LineaFormulacion").ToString()
                                                         + "\r"
                                                         + "Con el Importe de: "
                                                         + string.Format("{0:0,0.00}", this.Grd_Ayuda.GetFocusedRowCellValue("Importe")).TrimEnd()
                                                         + "\r"
                                                         + "\r"
                                                         + "Confirma la Elección?";
                String caption = "Elección de Linea de Formulación";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                System.Windows.Forms.DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(this, message, caption, buttons, icon);
                if (result == DialogResult.Yes)
                {
                    blnEligio = true;
                    strCodFormulacion = this.Grd_Ayuda.GetFocusedRowCellValue("cCodFormulacion").ToString();
                    this.Close();
                }
            }
        }
    }
}