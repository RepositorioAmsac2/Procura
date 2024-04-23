using System;
using System.Data;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win;

namespace WINlogistica
{
    public partial class Frm_NuevoConformidad_CambiaValor : Form
    {
        public double dblValor = 0;
        public bool blnActializo = false;
        public Frm_NuevoConformidad_CambiaValor()
        {
            InitializeComponent();
        }

        public void Showme( double fValor
                          )
        {
            dblValor = fValor;
            this.Txt_Importe.Value = dblValor;
            this.Txt_Importe.Focus();
            ShowDialog();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            blnActializo = true;
            dblValor = Convert.ToDouble(this.Txt_Importe.Value);
            this.Close();
        }
    }
}
