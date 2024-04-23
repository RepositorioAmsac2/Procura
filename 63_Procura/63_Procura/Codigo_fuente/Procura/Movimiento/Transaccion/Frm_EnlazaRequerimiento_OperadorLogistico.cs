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
    public partial class Frm_EnlazaRequerimiento_OperadorLogistico : Form
    {
        //private SRgestionE.WCFgestionEClient objWCF = new SRgestionE.WCFgestionEClient();
        private DataSet DS_ListaRequerimiento = new DataSet();
        private string strCodCentro_Gestor = MyStuff.CodigoCentroGestor;
        private Boolean blnMuestraFormato = true;
        private WINlogistica.Framework FS = new WINlogistica.Framework();
        private DataSet DS_OperadorLogistico = new DataSet();
        Service.Data sdl = new Service.Data();
        Model.ParametroLogistica MPL = new Model.ParametroLogistica();

        public Frm_EnlazaRequerimiento_OperadorLogistico()
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
            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                DS_OperadorLogistico = sdl.Ayuda_OperadorLogistico_Jefatura(MyStuff.CodigoJefatura);
                this.Txt_CodOperadorLogistico.nombreDS = DS_OperadorLogistico;
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
                DS_ListaRequerimiento = sdl.lista_ProcesoLogistico_Aprobacion(strCodEstado);
            }
            this.Grd_Buscados.DataSource = DS_ListaRequerimiento;
            if (blnMuestraFormato == true)
            {
                blnMuestraFormato = false;
                this.FormatoGrid();
            }
            MostrarIconoGrilla();
            if (DS_ListaRequerimiento.Tables[0].Rows.Count > 0)
            {
                this.Lbl_OperadorLogistico.Visible = true;
                this.Txt_ApeOperadorLogistico.Visible = true;
                this.Txt_ApeOperadorLogistico.Visible = true;
                this.Btn_FirmaDigital.Enabled = true;
                foreach (DataRow oRow in DS_ListaRequerimiento.Tables[0].Rows)
                {
                    string strNumRequerimiento = Convert.ToString(oRow["cNumRequerimiento"]);
                    string strNomTipoAdquisicion = Convert.ToString(oRow["vNomTipoAdquisicion"]);
                    string strPaso = Convert.ToString(oRow["cPaso"]);
                    Boolean blnEsPasajeAereo = Convert.ToBoolean(oRow["bEsPasajeAereo"]);
                    this.MostrarRequerimiento(strNumRequerimiento, strNomTipoAdquisicion, strPaso, blnEsPasajeAereo);
                    break;
                }
            }
            else
            {
                this.OcultarRequerimiento();
            }


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
            oBand0.Columns[9].Width = 250;

            oBand0.Columns[6].Hidden = true;
            oBand0.Columns[7].Hidden = true;
            oBand0.Columns[10].Hidden = true;
            oBand0.Columns[11].Hidden = true;
            oBand0.Columns[12].Hidden = true;
            oBand0.Columns[13].Hidden = true;
            oBand0.Columns[14].Hidden = true;
        }

        private void MostrarRequerimiento( string strNumRequerimiento,
                                          string strNomTipoAdquisicion,
                                          string strPaso,
                                          Boolean blnEsPasajeAereo
                                         )
        {
            DataSet DS_Requerimiento = new DataSet();

            if (strPaso.TrimEnd() == "01")
            {
                this.Btn_Descartar.Visible = false;
            }
            else
            {
                this.Btn_Descartar.Visible = true;
            }
            this.Btn_FirmaDigital.Visible = true;
            this.Crv_Requerimiento.Visible = true;

            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                DS_Requerimiento = sdl.Formato_Requerimiento(strNumRequerimiento);
            }

            Model.ParametroGestion MPG = new Model.ParametroGestion();

            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                MPG = sdl.Recupera_ParametroGestion_Codigo("70");
            }
            if (strNomTipoAdquisicion.TrimEnd() == "Bien")
            {
                Formato.CrystalReport.CR_Requerimiento_Bien_Otro crpt = new Formato.CrystalReport.CR_Requerimiento_Bien_Otro();
                crpt.Database.Tables["Requerimiento_Cabecera"].SetDataSource(DS_Requerimiento.Tables[0]);
                crpt.Database.Tables["Requerimiento_Detalle"].SetDataSource(DS_Requerimiento.Tables[1]);
                crpt.Database.Tables["Paso_Requerimiento"].SetDataSource(DS_Requerimiento.Tables[2]);
                Crv_Requerimiento.ReportSource = null;
                Crv_Requerimiento.ReportSource = crpt;
            }
            else
            {
                if (blnEsPasajeAereo == false)
                {
                    Formato.CrystalReport.CR_Requerimiento_Servicio_Otro crpt = new Formato.CrystalReport.CR_Requerimiento_Servicio_Otro();
                    crpt.Database.Tables["Requerimiento_Cabecera"].SetDataSource(DS_Requerimiento.Tables[0]);
                    crpt.Database.Tables["Requerimiento_Detalle"].SetDataSource(DS_Requerimiento.Tables[1]);
                    crpt.Database.Tables["Paso_Requerimiento"].SetDataSource(DS_Requerimiento.Tables[2]);
                    Crv_Requerimiento.ReportSource = null;
                    Crv_Requerimiento.ReportSource = crpt;
                }
                else
                {
                    Formato.CrystalReport.CR_Requerimiento_Servicio_Pasaje crpt = new Formato.CrystalReport.CR_Requerimiento_Servicio_Pasaje();
                    crpt.Database.Tables["Requerimiento_Cabecera"].SetDataSource(DS_Requerimiento.Tables[0]);
                    crpt.Database.Tables["Requerimiento_Detalle"].SetDataSource(DS_Requerimiento.Tables[1]);
                    crpt.Database.Tables["Paso_Requerimiento"].SetDataSource(DS_Requerimiento.Tables[2]);
                    crpt.Database.Tables["Requerimiento_Cabecera_Pasaje"].SetDataSource(DS_Requerimiento.Tables[3]);
                    Crv_Requerimiento.ReportSource = null;
                    Crv_Requerimiento.ReportSource = crpt;
                }
            }

            //SplashScreenManager.CloseForm();
        }

        private void OcultarRequerimiento()
        {
            this.Lbl_OperadorLogistico.Visible = false;
            this.Txt_ApeOperadorLogistico.Visible = false;
            this.Txt_ApeOperadorLogistico.Visible = false;
            this.Crv_Requerimiento.Visible = false;
            this.Btn_Descartar.Visible = false;
            this.Btn_FirmaDigital.Visible = false;
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
                DS_ListaRequerimiento = sdl.lista_ProcesoLogistico_Aprobacion("1");
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

                if (DS_ListaRequerimiento.Tables[0].Rows.Count > 0)
                {
                    this.Lbl_OperadorLogistico.Visible = true;
                    this.Txt_ApeOperadorLogistico.Visible = true;
                    this.Txt_ApeOperadorLogistico.Visible = true;
                    foreach (DataRow oRow in DS_ListaRequerimiento.Tables[0].Rows)
                    {
                        string strNumRequerimiento = Convert.ToString(oRow["cNumRequerimiento"]);
                        string strNomTipoAdquisicion = Convert.ToString(oRow["vNomTipoAdquisicion"]);
                        string strPaso = Convert.ToString(oRow["cPaso"]);
                        Boolean blnEsPasajeAereo = Convert.ToBoolean(oRow["bEsPasajeAereo"]);
                        this.MostrarRequerimiento(strNumRequerimiento, strNomTipoAdquisicion, strPaso, blnEsPasajeAereo);
                        break;
                    }
                }
                else
                {
                    this.OcultarRequerimiento();
                }
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

       
        private void Btn_Descartar_Click(object sender, EventArgs e)
        {

            DialogResult result;
            result = MessageBox.Show("Desea descartar la asignación del Requerimiento",
                                                                "Advertencia", MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Exclamation
                                                               );

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                WINlogistica.Frm_RechazoRequerimiento frm = new WINlogistica.Frm_RechazoRequerimiento();
                frm.ShowMe("1");

                if (frm.blnDescarta == true)
                {
                    Boolean blnResult = false;
                    Service.Data sdl = new Service.Data();
                    Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                    oRow = this.Grd_Buscados.ActiveRow;
                    string strNumRequerimiento = Convert.ToString(oRow.Cells[1].Value);
                    string strPaso = Convert.ToString(oRow.Cells[6].Value);
                    string strCentroCosto_Gestor = Convert.ToString(oRow.Cells[7].Value);



                    if (MyStuff.UsaWCF == true)
                    {
                    }
                    else
                    {
                        blnResult = sdl.graba_procesoLogistico_Aprobacion_DescarteFirma(strNumRequerimiento,
                                                                            frm.strCodMotivoDescarte,
                                                                            frm.dtpFecDescarte,
                                                                            frm.strNotaDescarte,
                                                                            MyStuff.CodigoEmpleado
                                                                      );
                    }

                    if (blnResult == true)
                    {

                        if ( Convert.ToInt32( oRow.Cells[11].Value ) == 0)
                        {
                            oRow.Cells[0].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                            oRow.Cells[0].Appearance.Image = this.imageList1.Images[1];
                            oRow.Cells[0].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                            oRow.Cells[0].ButtonAppearance.Image = this.imageList1.Images[1];
                        }

                        oRow.Cells[11].Value = Convert.ToInt32(oRow.Cells[11].Value) + 1;
                        //oRow.Delete(false);
                        //if (Grd_Buscados.Rows.Count > 0)
                        //{
                        //    oRow = this.Grd_Buscados.ActiveRow;
                        //    if (oRow == null)
                        //    {
                        //        oRow = this.Grd_Buscados.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First);
                        //    }

                        //    this.MostrarRequerimiento(Convert.ToString(oRow.Cells[1].Value),
                        //                              Convert.ToString(oRow.Cells[8].Value),
                        //                              Convert.ToString(oRow.Cells[6].Value),
                        //                              Convert.ToBoolean(oRow.Cells[10].Value)
                        //                             );
                        //}
                        //else
                        //{
                        //    this.Btn_FirmaDigital.Enabled = false;
                        //    this.OcultarRequerimiento();

                        //}
                    }
                }
            }
        }

        private void Btn_FirmaDigital_Click(object sender, EventArgs e)
        {
            string strCodOperadorLogistico = Convert.ToString(this.Txt_CodOperadorLogistico.Value);
            if (string.IsNullOrEmpty(strCodOperadorLogistico))
            {
                MessageBox.Show("Debe elegir el Operador Logistico",
                                 "Advertencia",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation
                                );
                this.Txt_CodOperadorLogistico.Focus();
            }
            else
            {

                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.Grd_Buscados.ActiveRow;
                string EsUnProceso = Convert.ToString(oRow.Cells[13].Value);
                string strCodPac = Convert.ToString(oRow.Cells[14].Value);

               

                if (  string.IsNullOrEmpty( strCodPac.TrimEnd() ) && EsUnProceso.TrimEnd() == "SI" )
                {
                    MessageBox.Show("La linea de formulación no esta asociada a un PAC",
                                 "Advertencia",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation
                                );
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Desea asignar el Requerimiento a un operador logistico",
                                                                        "Advertencia", MessageBoxButtons.YesNo,
                                                                        MessageBoxIcon.Exclamation
                                                                       );

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Boolean blnResult = false;
                        Service.Data sdl = new Service.Data();
                        string strNumRequerimiento = Convert.ToString(oRow.Cells[1].Value);
                        string strPaso = Convert.ToString(oRow.Cells[6].Value);
                        string strCentroCosto_Gestor = Convert.ToString(oRow.Cells[8].Value);

                        if (MyStuff.UsaWCF == true)
                        {
                        }
                        else
                        {

                            blnResult = sdl.graba_procesoLogistico_Aprobacion_Firma(strCodCentro_Gestor,
                                                                            strPaso,
                                                                            strNumRequerimiento,
                                                                            MyStuff.CodigoEmpleado,
                                                                            strCodOperadorLogistico,
                                                                            EsUnProceso,
                                                                            strCodPac
                                                                          );
                        }

                        if (blnResult == true)
                        {
                            this.Txt_CodOperadorLogistico.Value = "";
                            this.Txt_ApeOperadorLogistico.Value = "";
                            oRow.Delete(false);
                            if (Grd_Buscados.Rows.Count > 0)
                            {
                                oRow = this.Grd_Buscados.ActiveRow;
                                if (oRow == null)
                                {
                                    oRow = this.Grd_Buscados.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First);
                                }

                                this.MostrarRequerimiento(Convert.ToString(oRow.Cells[1].Value),
                                                          Convert.ToString(oRow.Cells[8].Value),
                                                          Convert.ToString(oRow.Cells[6].Value),
                                                          Convert.ToBoolean(oRow.Cells[10].Value)
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
                this.MostrarRequerimiento(strNumRequerimiento, strNomTipoAdquisicion, strPaso, blnEsPasajeAereo);

            }
        }

        private void Txt_CodOperadorLogistico_Leave(object sender, EventArgs e)
        {
            this.Txt_ApeOperadorLogistico.Value = FS.TraerDescripcion_DataTable(DS_OperadorLogistico.Tables[0],
                                                                                        0,
                                                                                        1,
                                                                                        Convert.ToString(this.Txt_CodOperadorLogistico.Value)
                                                                                        );
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
    }
}
