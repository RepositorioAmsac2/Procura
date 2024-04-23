using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINlogistica
{
    public partial class Frm_Ayuda_Contrato : Form
    {
        private bool blnMuestraFormato = false;
        private DataSet DS_Proyecto = new DataSet();
        private DataSet DS_Proveedor = new DataSet();
        private WINlogistica.Framework FS = new WINlogistica.Framework();
        private Service.Data sl = new Service.Data();
        public bool blnEligio = false;
        public string strCodContrato = "";
        public Frm_Ayuda_Contrato()
        {
            InitializeComponent();
        }
        public void ShowMe(string strCodCompañia)
        {
            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                DS_Proyecto = sl.Ayuda_Proyecto(strCodCompañia,
                                                     1
                                                   );
                DS_Proveedor = sl.ayuda_Proveedor(strCodCompañia);

                this.Txt_CodProyecto.nombreDS = DS_Proyecto;
                this.Txt_CodProveedor.nombreDS = DS_Proveedor;
            }

            this.ShowDialog();
        }
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            //if ( this.VerificaIngresoMovimiento())
            {
                //SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
                //SplashScreenManager.Default.SetWaitFormDescription("Recopilando informaciòn...");


                string strCodCompañia = MyStuff.CodigoEmpresa; ;
                string strCodProyecto = Convert.ToString(this.Txt_CodProyecto.Value);
                string strCodProveedor = Convert.ToString(this.Txt_CodProveedor.Value);
                string strPeriodoInicial = "";
                string strPeriodoFinal = "";
                int intEstadoContrato = 2;

                if (this.Opt_Pagado.Checked == true)
                {
                    intEstadoContrato = 0;
                }
                else
                    if (this.Opt_Pendiente.Checked == true)
                {
                    intEstadoContrato = 1;
                }
                else
                {
                    intEstadoContrato = 2;
                }

                if (this.Chk_Periodo.Checked == true)
                {
                    strPeriodoInicial = "";
                    strPeriodoFinal = "";
                }
                else
                {
                    strPeriodoInicial = Convert.ToString(this.Txt_PeriodoInicial.Text);
                    strPeriodoFinal = Convert.ToString(this.Txt_PeriodoFinal.Text);
                }

                DataTable DT = new DataTable();
                if (MyStuff.UsaWCF == true)
                {
                }
                else
                {
                    DT = sl.ayuda_Contrato( strCodCompañia,
                                              strPeriodoInicial,
                                              strPeriodoFinal,
                                              strCodProveedor,
                                              strCodProyecto,
                                              intEstadoContrato
                                            ).Tables[0];
                }


                this.Grd_mvto_Mayor_FuenteFinanciamiento.DataSource = DT;
                this.FormatoGrid();

                //SplashScreenManager.CloseForm();
            }
            
        }

        #region "Formato"
        private void FormatoGrid()
        {
            //Infragistics.Win.UltraWinGrid.UltraGridBand oBand;
            //Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn;
            this.Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Bands[0];

            oBand0.Columns[0].Header.Caption = "Proveedor";
            oBand0.Columns[0].Width = 100;
            oBand0.Columns[1].Header.Caption = "Nombre del Proveedor";
            oBand0.Columns[1].Width = 200;
            oBand0.Columns[2].Header.Caption = "Contrato";
            oBand0.Columns[2].Width = 110;
            oBand0.Columns[3].Header.Caption = "Descripción";
            oBand0.Columns[3].Width = 565;
        }
        #endregion
        private void Chk_Periodo_CheckedChanged(object sender, EventArgs e)
        {
            this.Txt_PeriodoInicial.Enabled = Chk_Periodo.Checked;
            this.Txt_PeriodoFinal.Enabled = Chk_Periodo.Checked;
        }
        private void Txt_CodProyecto_Leave(object sender, EventArgs e)
        {
            this.Txt_NomProyecto.Value = FS.TraerDescripcion_DataTable(DS_Proyecto.Tables[0],
                                                                                   0,
                                                                                   1,
                                                                                   Convert.ToString(this.Txt_CodProyecto.Value)
                                                                                 );
        }
        private void Grd_mvto_Mayor_FuenteFinanciamiento_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            e.Layout.Override.FilterUIType = FilterUIType.FilterRow;

            FilterOperatorDropDownItems val = FilterOperatorDropDownItems.Contains;
            Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Override.FilterOperatorDropDownItems = val;

            FilterOperatorDefaultValue val1 = FilterOperatorDefaultValue.Contains;
            Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Override.FilterOperatorDefaultValue = val1;

            Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.ScrollStyle = ScrollStyle.Immediate;
            Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Scrollbars = Scrollbars.Both;
            Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.ColumnScrollbarSmallChange = 100;
            Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.UseScrollWindow = UseScrollWindow.None;
            // Turn off UseOsThemes to allow display of raw column header 
            this.Grd_mvto_Mayor_FuenteFinanciamiento.UseOsThemes = DefaultableBoolean.False;
        }
        private void Txt_CodProveedor_Leave(object sender, EventArgs e)
        {
            this.Txt_NomProveedor.Value = FS.TraerDescripcion_DataTable(DS_Proveedor.Tables[0],
                                                                       0,
                                                                       1,
                                                                       Convert.ToString(this.Txt_CodProveedor.Value)
                                                                     );

        }

        private void Txt_CodProyecto_Leave_1(object sender, EventArgs e)
        {
            this.Txt_NomProyecto.Value = FS.TraerDescripcion_DataTable(DS_Proyecto.Tables[0],
                                                                       0,
                                                                       1,
                                                                       Convert.ToString(this.Txt_CodProyecto.Value)
                                                                     );

        }


        private void Frm_ListaContratos_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Aceptar();
        }
        private void Aceptar()
        {
            blnEligio = true;
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = Grd_mvto_Mayor_FuenteFinanciamiento.ActiveRow;
            strCodContrato = Convert.ToString(oRow.Cells[2].Value);
            this.Close();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.blnEligio = false;
            Close();
        }

        private void Grd_mvto_Mayor_FuenteFinanciamiento_DoubleClickCell(object sender, DoubleClickCellEventArgs e)
        {
            this.Aceptar();
        }

        private void Grd_mvto_Mayor_FuenteFinanciamiento_ClickCellButton_1(object sender, CellEventArgs e)
        {
            this.Btn_Aceptar.Enabled = true;
        }
    }
}
