using DevExpress.XtraGrid.Columns;
using DevExpress.XtraSplashScreen;
using System;
using System.ComponentModel;

namespace WINlogistica
{
    public partial class Frm_Ayuda_EtapaProcesoLogistico : DevExpress.XtraEditors.XtraForm
    {

        private Service.Data objDATA = new Service.Data();

        public string strDesPaso = "";
        public string strCodPaso = "";
        public int intIdPaso = 0;
        public Boolean blnEligio = false;

        public Frm_Ayuda_EtapaProcesoLogistico()
        {
            InitializeComponent();
        }

        public void ShowMe(int intLinea,
                            string strCodTipoPlantilla
                          )
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("Trayendo etapa proceso logistico");
            this.Text = "Lista de etapa de proceso logistico para la linea: " + Convert.ToString(intLinea + 1);

            if (MyStuff.UsaWCF)
            {
                //this.grd_buscados.DataSource = objWCF.Ayuda_CentroCosto_Total(MyStuff.CodigoEmpresa).Tables[0];
            }
            else
            {
                this.grd_buscados.DataSource = objDATA.Ayuda_Paso_ID(strCodTipoPlantilla).Tables[0];
            }

            FormatoGrid();
            this.ShowDialog();
            SplashScreenManager.CloseForm();
        }

        private void FormatoGrid()
        {
            this.Grd_Ayuda.OptionsBehavior.Editable = false;
            this.Grd_Ayuda.OptionsFind.AlwaysVisible = true;
            this.Grd_Ayuda.OptionsView.ColumnAutoWidth = false;

            // Formatear columnas de la grilla
            GridColumn colCodigo = this.Grd_Ayuda.Columns[0];
            colCodigo.Caption = "Código";
            colCodigo.Fixed = FixedStyle.Left;
            colCodigo.Width = 100;
            GridColumn colNombre = this.Grd_Ayuda.Columns[1];
            colNombre.Caption = "Etapa";
            colNombre.Fixed = FixedStyle.Left;
            colNombre.Width = 400;
            GridColumn colCGestor = this.Grd_Ayuda.Columns[2];
            colCGestor.Caption = "ID";
            colCGestor.Fixed = FixedStyle.Left;
            colCGestor.Width = 100;
            colCGestor.Visible = false;
        }

        private void grd_buscados_DoubleClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(this.Grd_Ayuda.GetFocusedRowCellValue("cCodPaso"))) == false)
            {
                blnEligio = true;
                intIdPaso = Convert.ToInt32( this.Grd_Ayuda.GetFocusedRowCellValue("iIdPaso") );
                strCodPaso = this.Grd_Ayuda.GetFocusedRowCellValue("cCodPaso").ToString().TrimEnd();
                strDesPaso = this.Grd_Ayuda.GetFocusedRowCellValue("vDesPaso").ToString().TrimEnd();


                this.Close();
            }
        }

        private void Grd_Ayuda_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void Frm_AyudaHojaTrabajo_Load(object sender, EventArgs e)
        {

        }
    }


}