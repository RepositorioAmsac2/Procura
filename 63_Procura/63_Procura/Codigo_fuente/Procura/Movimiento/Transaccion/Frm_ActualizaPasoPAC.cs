using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win;

namespace WINlogistica
{
    public partial class Frm_ActualizaPasoPAC : Form
    {
        private Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();
        private Service.Data sdl = new Service.Data();

        private Model.ProcesoLogistico_Paso MPDP = new Model.ProcesoLogistico_Paso();

        DataTable dtGrilla = new DataTable();
        bool blnPintarGrilla = true;
        int intIdPac_paso = 0;
        string strNumProcedimiento = "";
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public Frm_ActualizaPasoPAC()
        {
            InitializeComponent();
        }

        public void ShowMe( string cNumProcedimiento,
                           int intExcluido
                          )
        {
            //Me.m_Grid = Grid
            //strNumProcedimiento = iIdPac_Detalle;
            strNumProcedimiento = cNumProcedimiento;
            if (MyStuff.UsaWCF == true)
            {
                MPD = objWCF.Recupera_Pac_Detalle_Codigo(strNumProcedimiento);
            }
            else
            {
                MPD = sdl.Recupera_ProcesoLogistico_Detalle_Codigo(strNumProcedimiento);
            }

            this.Txt_AñoProceso.Value = MPD.cAñoProceso;

            this.Txt_CodPAC.Value = MPD.cNumProcedimiento;
            this.Edt_PAC.Value = MPD.tDesContratacion;
            this.Txt_PrecioEstimado.Value = MPD.fPrecioEstimado;
            if (MyStuff.UsaWCF == true)
            {
                //jesusdtGrilla = objWCF.Lista_Pac_Paso(MPD.cAñoProceso, MPD.cNumProcedimiento).Tables[0];
            }
            else
            {
                dtGrilla = sdl.Lista_ProcesoLogistico_Paso(MPD.cAñoProceso, MPD.cNumProcedimiento).Tables[0];
            }
            

            this.Grd_mvto_Pac_Detalle_Paso.DataSource = dtGrilla;
            pintarGrilla();
            if (intExcluido == 0)
                AdicionaImagenesGrilla();
        }

        private void Tsb_Exportar_Click(object sender, EventArgs e)
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
                    this.UltraGridExcelExporter1.Export(this.Grd_mvto_Pac_Detalle_Paso, strFile);
                }
                catch 
                {
                    MessageBox.Show("Error", "Error");
                }
            }
        }

        private void Grd_mvto_Pac_Detalle_Paso_AfterSelectChange(object sender, Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs e)
        {
            if (dtGrilla.Rows.Count > 0)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.Grd_mvto_Pac_Detalle_Paso.ActiveRow;
                if ((oRow.Cells[0].Text).Trim() != "")
                {
                    MPDP.iIdProcesoLogistico_Paso = Convert.ToInt32(oRow.Cells[0].Value);
                    MPDP.cNumProcedimiento = Convert.ToString(oRow.Cells[1].Value);
                    MPDP.iIdPaso = Convert.ToInt32(oRow.Cells[4].Text);
                    if (Convert.ToString(oRow.Cells[7].Value).Trim() != "")
                    {
                        MPDP.dFecInicio = Convert.ToDateTime(oRow.Cells[7].Value);
                    }
                    if (Convert.ToString(oRow.Cells[8].Value).Trim() != "")
                    {
                        MPDP.dFecFinal = Convert.ToDateTime(oRow.Cells[8].Value);
                    }

                    //mostrarDocumento(objBEC_Comite)
                }
            }
        }

        private void pintarGrilla()
        {
            this.Grd_mvto_Pac_Detalle_Paso.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_mvto_Pac_Detalle_Paso.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.Grd_mvto_Pac_Detalle_Paso.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.Grd_mvto_Pac_Detalle_Paso.DisplayLayout.Bands[0];

            oBand0.Columns[2].Header.Caption = "";
            oBand0.Columns[2].Width = 20;
            oBand0.Columns[2].Header.Appearance.ImageBackgroundAlpha = Infragistics.Win.Alpha.Transparent;
            oBand0.Columns[2].Header.Appearance.Image = this.imageList2.Images[3];
            oBand0.Columns[2].Header.Appearance.ImageHAlign = HAlign.Right;

            oBand0.Columns[3].Header.Caption = "";
            oBand0.Columns[3].Width = 20;
            oBand0.Columns[3].Header.Appearance.ImageBackgroundAlpha = Infragistics.Win.Alpha.Transparent;
            oBand0.Columns[3].Header.Appearance.Image = this.imageList2.Images[10];
            oBand0.Columns[3].Header.Appearance.ImageHAlign = HAlign.Right;
            oBand0.Columns[5].Header.Caption = "Paso";
            oBand0.Columns[5].Width = 40;
            oBand0.Columns[6].Header.Caption = "Descripción";
            oBand0.Columns[6].Width = 400;
            oBand0.Columns[7].Header.Caption = "";
            oBand0.Columns[7].Width = 20;
            //oBand0.Columns[6].Header.Appearance.ImageBackgroundAlpha = Infragistics.Win.Alpha.Transparent;
            //oBand0.Columns[6].Header.Appearance.Image = this.imageList2.Images[10];
            //oBand0.Columns[6].Header.Appearance.ImageHAlign = HAlign.Right;
            oBand0.Columns[8].Header.Caption = "F.Inicio";
            oBand0.Columns[8].Width = 70;
            oBand0.Columns[9].Header.Caption = "F.Final";
            oBand0.Columns[9].Width = 70;
            oBand0.Columns[10].Header.Caption = "Apertura";
            oBand0.Columns[10].Width = 100;
            oBand0.Columns[11].Header.Caption = "Cierre";
            oBand0.Columns[11].Width = 100;
            oBand0.Columns[12].Header.Caption = "Nota";
            oBand0.Columns[12].Width = 300;
            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[1].Hidden = true;
            oBand0.Columns[4].Hidden = true;
            oBand0.Columns[13].Hidden = true;
            oBand0.Columns[14].Hidden = true;
            oBand0.Columns[15].Hidden = true;
        }

        private void Grd_mvto_Pac_Detalle_Paso_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            //e.Layout.Override.FilterUIType = FilterUIType.FilterRow
            e.Layout.Override.FilterEvaluationTrigger = FilterEvaluationTrigger.OnCellValueChange;
            e.Layout.Override.FilterOperatorLocation = FilterOperatorLocation.WithOperand;
            e.Layout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.StartsWith;
            e.Layout.Override.FilterClearButtonLocation = FilterClearButtonLocation.RowAndCell;
            e.Layout.Override.FilterRowAppearance.BackColor = Color.LightYellow;
            //e.Layout.Override.FilterRowPrompt = "Click here to filter data..."
            e.Layout.Override.FilterRowPromptAppearance.BackColorAlpha = Alpha.Opaque;
            e.Layout.Override.SpecialRowSeparator = SpecialRowSeparator.FilterRow;
            e.Layout.Override.SpecialRowSeparatorAppearance.BackColor = Color.FromArgb(233, 242, 199);
            e.Layout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
        }


        private void AdicionaImagenesGrilla()
        {
            int intRegistro = 0;
            //bool blnPintaImagen = true;
            //Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow  oRow in this.Grd_mvto_Pac_Detalle_Paso.Rows)
            {
                if (intRegistro == 0)
                {
                    if (Convert.ToString(oRow.Cells[10].Value).TrimEnd() == "" && Convert.ToString(oRow.Cells[11].Value).TrimEnd() == "")
                    {
                        break;
                    }
                    else
                    {
                        if (Convert.ToString(oRow.Cells[10].Value).TrimEnd() != "" && Convert.ToString(oRow.Cells[11].Value).TrimEnd() == "")
                        {
                            RefrescarCeldaGrilla(oRow);
                            break;
                        }
                        else
                        {
                            RefrescarCeldaGrilla(oRow);
                        }
                    }
                }
                else
                {
                    if (Convert.ToString(oRow.Cells[10].Text).Trim() == "" & Convert.ToString(oRow.Cells[11].Text).Trim() == "")
                    {
                        RefrescarCeldaGrilla(oRow);
                        break;
                    }
                    else
                    {
                        if (Convert.ToString(oRow.Cells[10].Text).Trim() != "" & Convert.ToString(oRow.Cells[11].Text).Trim() == "")
                        {
                            RefrescarCeldaGrilla(oRow);
                            break;
                        }
                        else
                        {
                            RefrescarCeldaGrilla(oRow);
                        }
                    }
                }
                intRegistro = intRegistro + 1;
            }
        }

        private void RefrescarCeldaGrilla(Infragistics.Win.UltraWinGrid.UltraGridRow oRow)
        {

            if ( string.IsNullOrEmpty(  Convert.ToString(oRow.Cells[10].Value).TrimEnd() ) )
            {
                oRow.Cells[10].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                oRow.Cells[10].Appearance.Image = this.imageList2.Images[7];
                oRow.Cells[10].ButtonAppearance.Image = this.imageList2.Images[7];
                oRow.Cells[10].ButtonAppearance.TextHAlign = HAlign.Right;
            }
            else
            {
                oRow.Cells[10].Appearance.Image = this.imageList2.Images[8];
            }
            oRow.Cells[10].ButtonAppearance.TextHAlign = HAlign.Right;

            if ( string.IsNullOrEmpty( Convert.ToString(oRow.Cells[10].Value).TrimEnd() ) == false )
            {
                oRow.Cells[2].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                oRow.Cells[3].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;

                oRow.Cells[2].Appearance.Image = this.imageList2.Images[3];
                oRow.Cells[2].ButtonAppearance.Image = this.imageList2.Images[3];
                oRow.Cells[2].ButtonAppearance.TextHAlign = HAlign.Right;

                oRow.Cells[3].Appearance.Image = this.imageList2.Images[10];
                oRow.Cells[3].ButtonAppearance.Image = this.imageList2.Images[10];
                oRow.Cells[3].ButtonAppearance.TextHAlign = HAlign.Right;

                if ( string.IsNullOrEmpty( Convert.ToString(oRow.Cells[11].Value).TrimEnd() ) )
                {
                    oRow.Cells[11].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
                    oRow.Cells[11].Appearance.Image = this.imageList2.Images[7];
                    oRow.Cells[11].ButtonAppearance.Image = this.imageList2.Images[7];
                }
                else
                {
                    oRow.Cells[11].Appearance.Image = this.imageList2.Images[8];
                }
                oRow.Cells[11].ButtonAppearance.TextHAlign = HAlign.Right;
            }
            if (Convert.ToInt32(oRow.Cells[15].Value ) != 0)
            {
                if (Convert.ToInt32(oRow.Cells[15].Value) > 0)
                    oRow.Cells[7].Appearance.Image = this.imageList2.Images[12];
                
                else
                    oRow.Cells[7].Appearance.Image = this.imageList2.Images[11];
            }
        }


        private void PintaUltimoRegistro(   DateTime DateFecFin,
                                            string strNota,
                                            Infragistics.Win.UltraWinGrid.UltraGridRow oRow 
                                        )
        { 
            oRow.Cells[11].Value = Convert.ToString(DateFecFin);
            //oRow.Cells[10].Style = null;
            oRow.Cells[11].Appearance.Image = imageList2.Images[8];
            oRow.Cells[11].ButtonAppearance.Image = imageList2.Images[8];

            oRow.Cells[12].Value = strNota;
        }

        private void PintaUltimoRegistro_Inicio(    int intIdPac_Paso,
                                                    DateTime DateFecIni,
                                                    string strNota,
                                                    DateTime dateFecInicio,
                                                    DateTime dateFecFinal,
                                                    Infragistics.Win.UltraWinGrid.UltraGridRow oRow
                                                )
            {

            oRow.Cells[0].Value = intIdPac_Paso;
            oRow.Cells[1].Value = strNumProcedimiento;
            oRow.Cells[8].Value = Convert.ToString(dateFecInicio);
            oRow.Cells[9].Value = Convert.ToString(dateFecFinal);
            oRow.Cells[10].Value = Convert.ToString(DateFecIni);

            oRow.Cells[10].Appearance.Image = imageList2.Images[8];
            oRow.Cells[10].ButtonAppearance.Image = imageList2.Images[8];
            //oRow.Cells[9].Style = null;

            oRow.Cells[11].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            oRow.Cells[11].Appearance.Image = imageList2.Images[7];
            oRow.Cells[11].ButtonAppearance.Image = imageList2.Images[7];
            oRow.Cells[11].ButtonAppearance.TextHAlign = HAlign.Right;

            oRow.Cells[12].Value = strNota;
        }

        private void Frm_ActualizaPasoPAC_Load(object sender, EventArgs e)
        {

        }

        private void Grd_mvto_Pac_Detalle_Paso_ClickCellButton(object sender, CellEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_mvto_Pac_Detalle_Paso.ActiveRow;
            intIdPac_paso = Convert.ToInt32(oRow.Cells[0].Value);
            int intIdPaso = Convert.ToInt32(oRow.Cells[5].Value);
            string strFormulario = Convert.ToString(oRow.Cells[14].Value);
            

            if (e.Cell.Column.Index == 2)
            { //Adjuntos
                WINlogistica.Frm_Pac_Paso_Adjunto frm = new WINlogistica.Frm_Pac_Paso_Adjunto();
                frm.ShowMe(MPD.cNumProcedimiento, intIdPaso, Grd_mvto_Pac_Detalle_Paso);

            }
            else if (e.Cell.Column.Index == 3)
            {
                //Dim frm As New frm_ActualizaComite_ItemPAC
                //frm.ShowMe(intIdComite,
                //            strCodComite,
                //            strCodTipoComite,
                //            strDesTipoComite,
                //            grd_mvto_DocumntoComite
                //              )
            }
            else if (e.Cell.Column.Index == 10)
            {
                Frm_ActualizaPaso_Apertura_Proceso frm = new Frm_ActualizaPaso_Apertura_Proceso();
                frm.ShowMe(intIdPac_paso,
                           Convert.ToString(this.Txt_AñoProceso.Value),
                           strNumProcedimiento,
                           intIdPaso,
                           strFormulario,
                           Grd_mvto_Pac_Detalle_Paso
                          );
                if (frm.blnGrabaPaso == true)
                {
                    PintaUltimoRegistro_Inicio(frm.intIdPac_Paso,
                                                frm.dateFecInicial,
                                                frm.strNota,
                                                frm.dateFecInicio,
                                                frm.dateFecFinal,
                                                oRow
                                              );
                    if (frm.blnCierreAutomatico == true)
                    {
                        PintaUltimoRegistro(frm.dateFecFinal, frm.strNota, oRow);
                    }
                }
            }
            else if (e.Cell.Column.Index == 11)
            {
                //Hallar el siguiente Paso
                int intIdPasoSiguiente = 0;
                string strFormularioSiguiente = "";
                int intIdProcesoLogistico_PasoSiguiente = 0;
                foreach (DataRow dr in dtGrilla.Rows)
                {
                    if (string.IsNullOrEmpty(Convert.ToString(dr["dFecApertura"])))
                    {
                        intIdPasoSiguiente = Convert.ToInt32(dr["iIdPaso"]);
                        strFormularioSiguiente = Convert.ToString(dr["vFormulario"]); ;
                        intIdProcesoLogistico_PasoSiguiente = Convert.ToInt32(dr["iIdProcesoLogistico_Paso"]); ;
                        break;
                    }
                }
                DateTime dateFecApertura = Convert.ToDateTime(oRow.Cells[9].Value);
                switch (strFormulario.TrimEnd())
                {
                    case "WINlogistica.Frm_Actualiza_Invitaciones":
                        WINlogistica.Frm_Actualiza_Invitaciones frmInvitacion = new WINlogistica.Frm_Actualiza_Invitaciones();
                        frmInvitacion.ShowMe(intIdPac_paso,
                                                MyStuff.CodigoEmpresa,
                                                Convert.ToString(this.Txt_AñoProceso.Value),
                                                dateFecApertura,
                                                strFormulario,
                                                MPD.cNumProcedimiento,
                                                MPD.tDesContratacion,
                                                Grd_mvto_Pac_Detalle_Paso,
                                                intIdPasoSiguiente,
                                                strFormularioSiguiente,
                                                intIdProcesoLogistico_PasoSiguiente
                                            );

                        if (frmInvitacion.blnGrabaPaso == true)
                        {
                            PintaUltimoRegistro(frmInvitacion.dateFecFinal, frmInvitacion.strNota, oRow);
                        }
                        break;
                    case "WINlogistica.Frm_Actualiza_Cotizaciones":
                        WINlogistica.Frm_Actualiza_Cotizaciones frmCotizacion = new WINlogistica.Frm_Actualiza_Cotizaciones();
                        frmCotizacion.ShowMe(intIdPac_paso,
                                                MyStuff.CodigoEmpresa,
                                                Convert.ToString(this.Txt_AñoProceso.Value),
                                                dateFecApertura,
                                                strFormulario,
                                                MPD.cNumProcedimiento,
                                                MPD.tDesContratacion,
                                                Grd_mvto_Pac_Detalle_Paso,
                                                intIdPasoSiguiente,
                                                strFormularioSiguiente,
                                                intIdProcesoLogistico_PasoSiguiente
                                            );

                        if (frmCotizacion.blnGrabaPaso == true)
                        {
                            PintaUltimoRegistro(frmCotizacion.dateFecFinal, frmCotizacion.strNota, oRow);
                        }
                        break;
                    case "WINlogistica.Frm_Actualiza_ValorEstimado":
                        WINlogistica.Frm_Actualiza_ValorEstimado frmValorEstimado = new WINlogistica.Frm_Actualiza_ValorEstimado();
                        frmValorEstimado.ShowMe(intIdPac_paso,
                                                MyStuff.CodigoEmpresa,
                                                Convert.ToString(this.Txt_AñoProceso.Value),
                                                dateFecApertura,
                                                strFormulario,
                                                MPD.cNumProcedimiento,
                                                MPD.tDesContratacion,
                                                Grd_mvto_Pac_Detalle_Paso,
                                                intIdPasoSiguiente,
                                                strFormularioSiguiente,
                                                intIdProcesoLogistico_PasoSiguiente
                                            );

                        if (frmValorEstimado.blnGrabaPaso == true)
                        {
                            PintaUltimoRegistro(frmValorEstimado.dateFecFinal, frmValorEstimado.strNota, oRow);
                        }
                        break;
                    case "WINlogistica.Frm_ProcesoLogistico_Contrato":
                        WINlogistica.Frm_ProcesoLogistico_Contrato frmGeneraOrden = new WINlogistica.Frm_ProcesoLogistico_Contrato();
                        frmGeneraOrden.ShowMe(intIdPac_paso,
                                                MyStuff.CodigoEmpresa,
                                                Convert.ToString(this.Txt_AñoProceso.Value),
                                                dateFecApertura,
                                                MPD.cNumProcedimiento
                                            );

                        if (frmGeneraOrden.blnGrabaPaso == true)
                        {
                            PintaUltimoRegistro(frmGeneraOrden.dateFecFinal, frmGeneraOrden.strNota, oRow);
                        }
                        break;
                    default:
                        Frm_ActualizaPaso_PAC_cierre frm = new Frm_ActualizaPaso_PAC_cierre();
                        frm.ShowMe(intIdPac_paso,
                                    MyStuff.CodigoEmpresa,
                                    Convert.ToString(this.Txt_AñoProceso.Value),
                                    dateFecApertura,
                                    strFormulario,
                                    MPD.cNumProcedimiento,
                                    MPD.tDesContratacion,
                                    Grd_mvto_Pac_Detalle_Paso,
                                    intIdPasoSiguiente,
                                    strFormularioSiguiente,
                                    intIdProcesoLogistico_PasoSiguiente
                                  ); 

                        if (frm.blnGrabaPaso == true)
                        {
                            PintaUltimoRegistro(frm.dateFecFinal, frm.strNota, oRow);
                        }
                        break;
                }

            }



                
        }
    }
}
