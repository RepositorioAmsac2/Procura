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
    public partial class Frm_ListaContratos : Form
    {
        private bool blnMuestraFormato = false;
        private DataSet DS_Proyecto = new DataSet();
        private DataSet DS_Proveedor = new DataSet();
        private WINlogistica.Framework FS = new WINlogistica.Framework();
        private Service.Data sdl = new Service.Data();

        public Frm_ListaContratos()
        {
            //SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            //SplashScreenManager.Default.SetWaitFormDescription("Cargando Tablas...");
            InitializeComponent();

            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                DS_Proyecto = sdl.Ayuda_Proyecto(MyStuff.CodigoEmpresa,
                                                     1
                                                   );
                DS_Proveedor = sdl.ayuda_Proveedor( MyStuff.CodigoEmpresa);

                this.Txt_CodProyecto.nombreDS = DS_Proyecto;
                this.Txt_CodProveedor.nombreDS = DS_Proveedor;
            }

            //SplashScreenManager.CloseForm();

        }

  
        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";
            string strCodProyecto = Convert.ToString(this.Txt_CodProyecto.Value);
            string strCodProveedor = Convert.ToString(this.Txt_CodProveedor.Value);
            try
            {

                if (String.IsNullOrEmpty(Convert.ToString(this.Txt_CodProyecto.Value)) == true & 
                    String.IsNullOrEmpty(Convert.ToString(this.Txt_CodProveedor.Value)) == true
                   )
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar un Proyecto o un Proveedor o una parte del objeto de Contratación";
                }

              
                if (blnVerifica == false)
                {
                    MessageBox.Show(strMensaje,
                                    "Error", MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Error
                               );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return blnVerifica;
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
                    DT = sdl.reporte_Contrato( strCodCompañia,
                                              strPeriodoInicial,
                                              strPeriodoFinal,
                                              strCodProveedor,
                                              strCodProyecto,
                                              intEstadoContrato
                                            ).Tables[0];
                }


                this.Grd_mvto_Mayor_FuenteFinanciamiento.DataSource = DT;
                if (blnMuestraFormato == false)
                {
                    this.FormatoGrid();
                    this.blnMuestraFormato = true;
                }
                this.AdicionaImagenesGrilla();

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

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("MontoTotal"))
                {
                    oBand.Summaries.Add("Sum_MontoTotal", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["MontoTotal"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_MontoTotal"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_MontoTotal"].Appearance.TextHAlign = HAlign.Right;
                }

                if (oBand.Columns.Exists("fImporteConformidad"))
                {
                    oBand.Summaries.Add("Sum_fImporteConformidad", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImporteConformidad"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImporteConformidad"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fImporteConformidad"].Appearance.TextHAlign = HAlign.Right;
                }

                if (oBand.Columns.Exists("fSaldo"))
                {
                    oBand.Summaries.Add("Sum_fSaldo", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fSaldo"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fSaldo"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fSaldo"].Appearance.TextHAlign = HAlign.Right;
                }
            }

            this.Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default


            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Bands)
            {
                foreach (Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn in oBand.Columns)
                {
                    if (oColumn.DataType.ToString() == "System.Double")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "#,###,###,###,###.00";
                    }

                    if (oColumn.DataType.ToString() == "System.Decimal")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "#,###,###,###,###.00";
                    }
                }
            }

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Bands[0];

            oBand0.Columns[0].Header.Caption = "Proveedor";
            oBand0.Columns[0].Width = 80;
            oBand0.Columns[1].Header.Caption = "Nombre del Proveedor";
            oBand0.Columns[1].Width = 200;
            oBand0.Columns[2].Header.Caption = "Contrato";
            oBand0.Columns[2].Width = 90;
            oBand0.Columns[3].Header.Caption = "Descripción";
            oBand0.Columns[3].Width = 510;
            oBand0.Columns[4].Header.Caption = "Fecha";
            oBand0.Columns[4].Width = 80;
            oBand0.Columns[5].Header.Caption = "Importe";
            oBand0.Columns[5].Width = 100;
            oBand0.Columns[6].Header.Caption = "Conformidad";
            oBand0.Columns[6].Width = 100;
            oBand0.Columns[7].Header.Caption = "Saldo";
            oBand0.Columns[7].Width = 100;

            oBand0.Columns[8].Hidden = true;
            oBand0.Columns[9].Hidden = true;

        }
        #endregion

        private void AdicionaImagenesGrilla()
        {

            UltraGridBand band = this.Grd_mvto_Mayor_FuenteFinanciamiento.DisplayLayout.Bands[0];

            foreach (UltraGridRow row in band.GetRowEnumerator(GridRowType.DataRow))
            {
                RefrescarCeldaGrilla(row);
            }

        }

        private void RefrescarCeldaGrilla(Infragistics.Win.UltraWinGrid.UltraGridRow oRow)
        {
            if (Convert.ToDouble(oRow.Cells[6].Value) > 0)  // Si e altero el monto inicial del contrato
            {
                oRow.Cells[6].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                oRow.Cells[6].Appearance.Image = this.imageList2.Images[0];
                oRow.Cells[6].ButtonAppearance.Image = this.imageList2.Images[0];
                oRow.Cells[6].ButtonAppearance.TextHAlign = HAlign.Right;
            }
            if (Convert.ToBoolean(oRow.Cells[8].Value) == true)  // Si e altero el monto inicial del contrato
            {
                oRow.Cells[3].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                oRow.Cells[3].Appearance.Image = this.imageList2.Images[0];
                oRow.Cells[3].ButtonAppearance.Image = this.imageList2.Images[0];
                oRow.Cells[3].ButtonAppearance.TextHAlign = HAlign.Right;
            }
            if (Convert.ToBoolean(oRow.Cells[9].Value) == true ) // si se altero la fecha de inicio
            {
                oRow.Cells[4].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                oRow.Cells[4].Appearance.Image = this.imageList2.Images[0];
                oRow.Cells[4].ButtonAppearance.Image = this.imageList2.Images[0];
                oRow.Cells[4].ButtonAppearance.TextHAlign = HAlign.Right;
            }

        }

 
        private void Btn_Listar_Click(object sender, EventArgs e)
        {
            this.Exportar();
        }

        private void Exportar()
        {
            string strFile = "";
            if (this.SaveDocumento.ShowDialog() == DialogResult.OK)
            {
                strFile = this.SaveDocumento.FileName;
                DateTime start;
                TimeSpan timespan;

                start = DateTime.Now;

                try
                {
                    timespan = DateTime.Now.Subtract(start);

                    this.UltraGridExcelExporter1.Export(this.Grd_mvto_Mayor_FuenteFinanciamiento, strFile);

                }
                catch
                {
                    MessageBox.Show("Error", "Error");
                }
            }
        }

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

        private void Grd_mvto_Mayor_FuenteFinanciamiento_ClickCellButton(object sender, CellEventArgs e)
        {
            string strNroContrato = "";
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_mvto_Mayor_FuenteFinanciamiento.ActiveRow;
            switch (e.Cell.Column.Index)
            {
                case 6: //Conformidades
                    if (Convert.ToDouble(oRow.Cells[6].Value) > 0)
                    {
                        strNroContrato = Convert.ToString(oRow.Cells[2].Value);
                        WINlogistica.Frm_ListaConformidades frm = new WINlogistica.Frm_ListaConformidades();
                        frm.ShowMe(MyStuff.CodigoEmpresa,
                                    strNroContrato
                                    );
                    }
                    break;

                case 5: //Monto total del contrato
                    if (Convert.ToBoolean(oRow.Cells[8].Value) == true)
                    {
                        strNroContrato = Convert.ToString(oRow.Cells[2].Value);
                        WINlogistica.Frm_ListaConformidades frm = new WINlogistica.Frm_ListaConformidades();
                        frm.ShowMe(MyStuff.CodigoEmpresa,
                                    strNroContrato
                                    );
                    }
                    break;
                case 4:
                    if (Convert.ToBoolean(oRow.Cells[9].Value) == true)
                    {
                        strNroContrato = Convert.ToString(oRow.Cells[2].Value);
                    }
                    break;
            }
        }

        private void Frm_ListaContratos_Load(object sender, EventArgs e)
        {

        }
    }
}
