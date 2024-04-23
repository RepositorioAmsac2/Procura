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
    public partial class Frm_FirmaConformidad : Form
    {
        private DataSet DS_ListaConformidad = new DataSet();
        private string strCodCentro_Gestor = MyStuff.CodigoCentroGestor;
        private Boolean blnMuestraFormato = true;
        private string strCodAdministradorContrato = "";
        Service.Data SL = new Service.Data();

        public Frm_FirmaConformidad()
        {
            InitializeComponent();
        }

        private void FormatoGrid()
        {
            //Infragistics.Win.UltraWinGrid.UltraGridBand oBand;
            //Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn;
            this.Grd_Buscados.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_Buscados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Buscados.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("fImporteConformidad"))
                {
                    oBand.Summaries.Add("Sum_fImporteConformidad", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImporteConformidad"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImporteConformidad"].DisplayFormat = "{0:#,###,###,###,###.00}";
                    oBand.Summaries["Sum_fImporteConformidad"].Appearance.TextHAlign = HAlign.Right;
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

            oBand0.Columns[0].Header.Caption = "Contrato";
            oBand0.Columns[0].Width = 100;
            oBand0.Columns[1].Header.Caption = "Descripción del contrato";
            oBand0.Columns[1].Width = 40;
            oBand0.Columns[2].Header.Caption = "Conformidad";
            oBand0.Columns[2].Width = 100;
            oBand0.Columns[3].Header.Caption = "Fecha";
            oBand0.Columns[3].Width = 80;
            oBand0.Columns[4].Header.Caption = "Importe";
            oBand0.Columns[4].Width = 110;

            //oBand0.Columns[1].Hidden = true;
            oBand0.Columns[5].Hidden = true;
            oBand0.Columns[6].Hidden = true;
        }
        private void MostrarConformidad(    string strCodCompañia,
                                            string strNroContrato,
                                            string strNroConformidad,
                                            string strPaso
                                       )
        {
            DataSet DS_Conformidad = new DataSet();
            
            this.Crv_Requerimiento.Visible = true;
            if (strPaso.TrimEnd() == "02")
            {
                this.Btn_Descartar.Visible = true;
            }
            
            this.Btn_FirmaDigital.Visible = true;

            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                DS_Conformidad = SL.formato_ContratoConformidad_Formato(strCodCompañia,
                                                                         strNroContrato,
                                                                         strNroConformidad
                                                                       );
            }
            if (DS_Conformidad.Tables[0].Rows.Count > 0)
            {
              
              Formato.CrystalReport.Rpt_Conformidad  crpt = new Formato.CrystalReport.Rpt_Conformidad();
                crpt.Database.Tables["Orden"].SetDataSource(DS_Conformidad.Tables[0]);
                crpt.Database.Tables["Conformidad"].SetDataSource(DS_Conformidad.Tables[1]);
                crpt.Database.Tables["ConformidadProceso"].SetDataSource(DS_Conformidad.Tables[2]);
                crpt.Database.Tables["ConformidadDetalle"].SetDataSource(DS_Conformidad.Tables[3]);
                crpt.Database.Tables["Paso_Conformidad"].SetDataSource(DS_Conformidad.Tables[4]);

                //crpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat,
                //                  "");

                Crv_Requerimiento.ReportSource = null;
                Crv_Requerimiento.ReportSource = crpt;
            }
            //SplashScreenManager.CloseForm();
        }
        private void OcultarRequerimiento()
        {
            this.Crv_Requerimiento.Visible = false;
 
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
            if (string.IsNullOrEmpty(Convert.ToString(oRow.Cells[2].Value)) == false)
            {
                this.Btn_Descartar.Visible = true;
                this.Btn_FirmaDigital.Visible = true;
                string strNroContrato = Convert.ToString(oRow.Cells[0].Value);
                string strNroConformidad = Convert.ToString(oRow.Cells[2].Value);
                string strPaso = Convert.ToString(oRow.Cells[6].Value);
                //this.Btn_Adjunto.Text = "Ver Adjunto: " + Convert.ToString(oRow.Cells[13].Value);

                this.MostrarConformidad(MyStuff.CodigoEmpresa,
                                        strNroContrato,
                                        strNroConformidad,
                                        strPaso
                                        );

            }

        }
        private void Btn_Descartar_Click(object sender, EventArgs e)
        {

        }

        private void Frm_FirmaConformidad_Load(object sender, EventArgs e)
        {
            strCodAdministradorContrato = MyStuff.CodigoEmpleado;

            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                DS_ListaConformidad = SL.lista_ContratoConformidad_Formato(MyStuff.CodigoEmpresa,
                                                                           strCodAdministradorContrato,
                                                                           MyStuff.CodigoCentroGestor
                                                                         );
            }
            this.Grd_Buscados.DataSource = DS_ListaConformidad;
            if (blnMuestraFormato == true)
            {
                blnMuestraFormato = false;
                this.FormatoGrid();
            }

            if (DS_ListaConformidad.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow oRow in DS_ListaConformidad.Tables[0].Rows)
                {
                    string strNroContrato = Convert.ToString(oRow["cNroContrato"]);
                    string strNroConformidad = Convert.ToString(oRow["cNroConformidad"]);
                    string strPaso = Convert.ToString(oRow["cPaso"]);
                    //this.Btn_Adjunto.Text = "Ver Adjunto: " + Convert.ToString(oRow["tarchivoDestino"]);
                    this.MostrarConformidad(MyStuff.CodigoEmpresa,
                                            strNroContrato,
                                            strNroConformidad,
                                            strPaso
                                          );
                    break;
                }
            }
            else
            {
                this.OcultarRequerimiento();
            }

        }

        private void Btn_FirmaDigital_Click(object sender, EventArgs e)
        {
            Boolean blnResult = false;
            DialogResult result;
            result = MessageBox.Show("Desea firmar la conformidad",
                                                                "Advertencia", MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Exclamation
                                                               );

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.Grd_Buscados.ActiveRow;

                string strCodCompañia = MyStuff.CodigoEmpresa;
                string strNroContrato = Convert.ToString(oRow.Cells[0].Value);
                string strNroConformidad = Convert.ToString(oRow.Cells[2].Value);
                string strCodCentroGestor = MyStuff.CodigoCentroGestor;
                string strCodEmpleado = MyStuff.CodigoEmpleado;


                if (MyStuff.UsaWCF == true)
                {
                }
                else
                {
                    blnResult = SL.firma_Conformidad(strCodCompañia,
                                                     strCodCentroGestor,
                                                     strNroConformidad,
                                                     strCodEmpleado
                                                    );
                }

                if (blnResult == true)
                {
                    oRow.Delete(false);
                    if (Grd_Buscados.Rows.Count > 0)
                    {
                        oRow = this.Grd_Buscados.ActiveRow;
                        if (oRow == null)
                        {
                            oRow = this.Grd_Buscados.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First);
                        }

                        this.MostrarConformidad( strCodCompañia,
                                                 strNroContrato,
                                                 strNroConformidad,
                                                 Convert.ToString(oRow.Cells[6].Value)
                                                  );
                    }
                    else
                    {
                        this.Btn_FirmaDigital.Enabled = false;
                        this.OcultarRequerimiento();

                    }
                }

            }
        }
    }
}
