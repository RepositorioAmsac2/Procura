using DevExpress.XtraGrid.Columns;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace WINlogistica
{
    public partial class Frm_AyudaHojaGeneral : DevExpress.XtraEditors.XtraForm
    {

        public string strValorDevueltoTexto = "";
        public string strValorDevuelto = "";
        public Boolean blnEligio = false;

        public Frm_AyudaHojaGeneral()
        {
            InitializeComponent();
        }

        public void ShowMe(DataSet nombreDS,
                           string strTextoAyuda,
                           int intLinea
                          )
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("ayuda " + strTextoAyuda + "...");

            this.Text = strTextoAyuda.TrimEnd() + " para la Linea: " + Convert.ToString(intLinea);

            this.grd_buscados.DataSource = nombreDS.Tables[0];

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
            GridColumn colCodigo = this.Grd_Ayuda.Columns["Codigo"];
            colCodigo.Fixed = FixedStyle.Left;
            GridColumn colNombre = this.Grd_Ayuda.Columns["Descripcion"];
            colNombre.Fixed = FixedStyle.Left;
            colNombre.Width = 500;
        }

        private void grd_buscados_DoubleClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(this.Grd_Ayuda.GetFocusedRowCellValue("Codigo"))) == false)
            {
                blnEligio = true;
                strValorDevuelto = this.Grd_Ayuda.GetFocusedRowCellValue("Codigo").ToString().TrimEnd();
                strValorDevueltoTexto = this.Grd_Ayuda.GetFocusedRowCellValue("Descripcion").ToString().TrimEnd();
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