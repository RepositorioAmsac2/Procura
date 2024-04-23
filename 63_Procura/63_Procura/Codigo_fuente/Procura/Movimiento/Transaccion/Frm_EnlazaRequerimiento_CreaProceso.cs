using DevExpress.XtraSplashScreen;
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
    public partial class Frm_EnlazaRequerimiento_CreaProceso : Form
    {
        //private SRgestionE.WCFgestionEClient objWCF = new SRgestionE.WCFgestionEClient();
        private DataSet DS_ListaRequerimiento = new DataSet();
        private string strCodCentro_Gestor = MyStuff.CodigoCentroGestor;
        private Boolean blnMuestraFormato = true;
        private WINlogistica.Framework FS = new WINlogistica.Framework();
        private DataSet DS_OperadorLogistico = new DataSet();
        Service.Data sdl = new Service.Data();
        Model.ParametroLogistica MPL = new Model.ParametroLogistica();

        public Frm_EnlazaRequerimiento_CreaProceso()
        {
            InitializeComponent();
        }

        private void Frm_FirmaRequerimiento_Load(object sender, EventArgs e)
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
                MPL = sdl.Recupera_ParametroLogistica_Codigo(MyStuff.CodigoEmpleado.TrimEnd());
            }

            if (MPL.vValParametroLogistica.TrimEnd() == "")
            {
                if (MyStuff.UsaWCF == true)
                {
                }
                else
                {
                    MPL = sdl.Recupera_ParametroLogistica_Codigo("12");
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
            this.VerRequerimiento("1");
            this.TimerLista.Enabled = true;
        }

        private void VerRequerimiento(string strCodEstado )

        {

            Service.Data sdl = new Service.Data();
            if (MyStuff.UsaWCF == true)
            {
                
            }
            else
            {
                DS_ListaRequerimiento = sdl.lista_ProcesoLogistico_CreaProceso(MyStuff.CodigoEmpleado);
            }
            this.Grd_Buscados.DataSource = DS_ListaRequerimiento;
            if (blnMuestraFormato == true)
            {
                blnMuestraFormato = false;
                this.FormatoGrid();
            }
            MostrarIconoGrilla();


        }

        private void FormatoGrid()
        {
            //Infragistics.Win.UltraWinGrid.UltraGridBand oBand;
            //Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn;
            this.Grd_Buscados.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_Buscados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Buscados.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("fImporte"))
                {
                    oBand.Summaries.Add("Sum_fImporte", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImporte"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImporte"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fImporte"].Appearance.TextHAlign = HAlign.Right;
                }
                if (oBand.Columns.Exists("fImpuesto"))
                {
                    oBand.Summaries.Add("Sum_fImpuesto", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImpuesto"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImpuesto"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fImpuesto"].Appearance.TextHAlign = HAlign.Right;
                }
                if (oBand.Columns.Exists("fTotal"))
                {
                    oBand.Summaries.Add("Sum_fTotal", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fTotal"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fTotal"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fTotal"].Appearance.TextHAlign = HAlign.Right;
                }
            }

            this.Grd_Buscados.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Buscados.DisplayLayout.Bands)
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
            oBand0 = this.Grd_Buscados.DisplayLayout.Bands[0];

            oBand0.Columns[0].Header.Caption = "?";
            oBand0.Columns[0].Width = 20;
            oBand0.Columns[1].Header.Caption = "Requerimiento";
            oBand0.Columns[1].Width = 100;
            oBand0.Columns[2].Header.Caption = "Fecha";
            oBand0.Columns[2].Width = 80;
            oBand0.Columns[2].CellActivation = Activation.NoEdit;
            oBand0.Columns[3].Header.Caption = "Importe";
            oBand0.Columns[3].Width = 110;
            oBand0.Columns[4].Header.Caption = "Impuesto";
            oBand0.Columns[4].Width = 110;
            oBand0.Columns[5].Header.Caption = "Ttotal";
            oBand0.Columns[5].Width = 110;
            oBand0.Columns[8].Header.Caption = "Tipo Adquisición";
            oBand0.Columns[8].Width = 110;
            oBand0.Columns[9].Header.Caption = "Detalle de Adquisición";
            oBand0.Columns[9].Width = 550;

            oBand0.Columns[6].Hidden = true;
            oBand0.Columns[7].Hidden = true;
            oBand0.Columns[10].Hidden = true;
            oBand0.Columns[11].Hidden = true;
            oBand0.Columns[12].Hidden = true;
            oBand0.Columns[13].Hidden = true;
            oBand0.Columns[14].Hidden = true;

        }

     
        private void TimerLista_Tick(object sender, EventArgs e)
        {
            int intTotalFilas = DS_ListaRequerimiento.Tables[0].Rows.Count;

            Service.Data sdl = new Service.Data();
            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                DS_ListaRequerimiento = sdl.lista_ProcesoLogistico_CreaProceso(MyStuff.CodigoEmpleado);
            }

            if (intTotalFilas != DS_ListaRequerimiento.Tables[0].Rows.Count)
            {
                this.Grd_Buscados.DataSource = DS_ListaRequerimiento;
                if (blnMuestraFormato == true)
                {
                    blnMuestraFormato = false;
                    this.FormatoGrid();
                }

                MostrarIconoGrilla();

             }

        }

        private void MostrarIconoGrilla()
        {
            //Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow oRow in this.Grd_Buscados.Rows)
            {
                //oRow.Cells(8).Appearance.TextHAlign = HAlign.Right
                if (Convert.ToInt32(oRow.Cells[11].Value) != 0)
                {
                    oRow.Cells[0].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                    oRow.Cells[0].Appearance.Image = this.imageList1.Images[1];
                    oRow.Cells[0].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                    oRow.Cells[0].ButtonAppearance.Image = this.imageList1.Images[1];
                }

                if (Convert.ToString(oRow.Cells[13].Value) == "SI")
                {
                    oRow.Appearance.BackColor = Color.Blue;
                    oRow.Appearance.ForeColor = Color.White;
                }


                

            }
        }

        private void Frm_FirmaRequerimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                TimerLista.Enabled = false;
            }
        }

        private void btn_Exportar_Click(object sender, EventArgs e)
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

                    this.UltraGridExcelExporter1.Export(this.Grd_Buscados, strFile);

                }
                catch
                {
                    MessageBox.Show("Error", "Error");
                }
            }
        }

        private void Btn_PantallaTotal_Click(object sender, EventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_Buscados.ActiveRow;
            string strNumRequerimiento = Convert.ToString(oRow.Cells[1].Value);
            string strNomTipoAdquisicion = Convert.ToString(oRow.Cells[6].Value);
            Boolean blnEsPasajeAereo = Convert.ToBoolean(oRow.Cells[10].Value);
            WINlogistica.Frm_Formato_Rquerimiento frm = new WINlogistica.Frm_Formato_Rquerimiento();
            frm.ShowMe(strNumRequerimiento,blnEsPasajeAereo);
        }

        private void Grd_Buscados_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            e.Layout.Override.FilterUIType = FilterUIType.FilterRow;

            FilterOperatorDropDownItems val = FilterOperatorDropDownItems.Contains;
            Grd_Buscados.DisplayLayout.Override.FilterOperatorDropDownItems = val;

            FilterOperatorDefaultValue val1 = FilterOperatorDefaultValue.Contains;
            Grd_Buscados.DisplayLayout.Override.FilterOperatorDefaultValue = val1;

            Grd_Buscados.DisplayLayout.ScrollStyle = ScrollStyle.Immediate;
            Grd_Buscados.DisplayLayout.Scrollbars = Scrollbars.Both;
            Grd_Buscados.DisplayLayout.ColumnScrollbarSmallChange = 100;
            Grd_Buscados.DisplayLayout.UseScrollWindow = UseScrollWindow.None;
            this.Grd_Buscados.UseOsThemes = DefaultableBoolean.False;

        }

        private void Grd_Buscados_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_Buscados.ActiveRow;
            if (string.IsNullOrEmpty(Convert.ToString(oRow.Cells[1].Value)) == false)
            {
                string strNumRequerimiento = Convert.ToString(oRow.Cells[1].Value);
                string strNomTipoAdquisicion = Convert.ToString(oRow.Cells[8].Value);
                string strPaso = Convert.ToString(oRow.Cells[6].Value);
                Boolean blnEsPasajeAereo = Convert.ToBoolean(oRow.Cells[10].Value);
                this.Btn_Adjunto.Text = "Ver Adjunto: " + Convert.ToString(oRow.Cells[12].Value);
            }
        }

        private void btnAdjuntoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = Grd_Buscados.ActiveRow;
            string strNumDocumento = Convert.ToString(oRow.Cells[12].Value);
            if (string.IsNullOrEmpty(strNumDocumento) == false)
            {
                Model.TerminoReferencia MTR = new Model.TerminoReferencia();
                MTR = sdl.Recupera_TerminoReferencia(MyStuff.CodigoEmpresa,
                                                      strNumDocumento
                                                    );
                if (string.IsNullOrEmpty(MTR.vAdjunto) == false)
                {
                    WINlogistica.Framework sf = new WINlogistica.Framework();
                    sf.DownLoadArchivo(MTR.vAdjunto);
                }
            }
        }

        private void Btn_DetalleRequerimiento_Click(object sender, EventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_Buscados.ActiveRow;
            if (string.IsNullOrEmpty(Convert.ToString(oRow.Cells[1].Value)) == false)
            {
                string strNumRequerimiento = Convert.ToString(oRow.Cells[1].Value);
                string strDesProceso = Convert.ToString(oRow.Cells[9].Value);

                string strPaso = Convert.ToString(oRow.Cells[6].Value);
                string strCodCentroGestor = Convert.ToString(oRow.Cells[7].Value);
                string strEsUnProceso = Convert.ToString(oRow.Cells[13].Value);
                string strCodPac = Convert.ToString(oRow.Cells[14].Value);
                string strCodEmpleado = MyStuff.CodigoEmpleado;

                WINlogistica.Frm_EnlazaRequerimiento_CreaProceso_Detalle frm = new WINlogistica.Frm_EnlazaRequerimiento_CreaProceso_Detalle();
                frm.ShowMe(strNumRequerimiento,
                           strDesProceso,
                           strPaso,
                           strCodCentroGestor,
                           strEsUnProceso,
                           strCodPac,
                           strCodEmpleado
                           );
            }

        }
    }
}
