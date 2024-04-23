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
    public partial class Frm_TipoProceso_Duracion : Form
    {

        Service.Data sdl = new Service.Data();
        Model.TipoProceso_Duracion MTPD = new Model.TipoProceso_Duracion();
        Model.TipoProceso MTP = new Model.TipoProceso();

        Model.ObjetoContratacion MOC = new Model.ObjetoContratacion();

        Model.Paso MP = new Model.Paso();

        DataTable dtGrilla = new DataTable();
        bool blnPintarGrilla = true;
        int intIdTipoProceso_Duracion = 0;
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        public Frm_TipoProceso_Duracion()
        {
            InitializeComponent();
        }

        private void mostrarDocumento( Model.TipoProceso_Duracion obj)
        {
            this.Cbo_codPasoActoPrevio.SelectedValue = obj.iIdPaso;
            this.Nud_Duracion.Value = obj.iDuracion;
            this.Nud_DiaEmail.Value = obj.iDiaEmail;
            this.Nud_Orden.Value = obj.iOrden;
            if (intIdTipoProceso_Duracion == 0)
            {
                this.Nud_Orden.Enabled = false;
            }
            else
            {
                this.Nud_Orden.Enabled = true;
            }
            if (obj.iTipoDuracion == 1)
            {
                this.Opt_Habiles.Checked = true;
                this.Opt_Calendario.Checked = false;
            }
            else
            {
                this.Opt_Habiles.Checked = false;
                this.Opt_Calendario.Checked = true;
            }
        }
        private void PintarDatosRegistro()
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = Grd_mvto_TipoProceso.ActiveRow;
            oRow.Cells[0].Value = MTPD.iIdTipoProceso_Duracion;
            oRow.Cells[1].Value = MTPD.cAñoProceso;
            oRow.Cells[2].Value = MTPD.cCodTipoProceso;
            oRow.Cells[3].Value = MTPD.cCodObjetoContratacion;
            oRow.Cells[4].Value = MTPD.iIdPaso;
            oRow.Cells[5].Value = Convert.ToString(this.Cbo_codPasoActoPrevio.Text);
            oRow.Cells[6].Value = MTPD.iDuracion;
            oRow.Cells[7].Value = MTPD.iDiaEmail;
            oRow.Cells[8].Value = MTPD.iTipoDuracion;
            if (MTPD.iTipoDuracion == 1)
            {
                oRow.Cells[9].Value = "Hab";
            }
            else
            {
                oRow.Cells[9].Value = "Cal";
            }
            oRow.Cells[10].Value = MTPD.cCodEstadoDuracionPaso;
            oRow.Cells[11].Value = MTPD.iOrden;
        }
        private void RegistroMovConceptos()
        {
            Grd_mvto_TipoProceso.DisplayLayout.Bands[0].AddNew();
            PintarDatosRegistro();
        }


        private void AccionBotones(bool blnNuevo,
                                    bool blnGrabar,
                                    bool blnDesHacer,
                                    bool blnEliminar,
                                    bool blnListar )
            {
            this.Btn_Nuevo.Enabled = blnNuevo;
            this.Btn_Grabar.Enabled = blnGrabar;
            this.Btn_DesHacer.Enabled = blnDesHacer;
            this.Btn_Eliminar.Enabled = blnEliminar;
            this.Btn_Listar.Enabled = blnListar;
        }

        private void Grd_mvto_TipoProceso_AfterSelectChange(object sender, Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs e)
        {
            if (dtGrilla.Rows.Count > 0)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.Grd_mvto_TipoProceso.ActiveRow;
                if (oRow == null)
                {
                }
                else
                {
                    if (Convert.ToInt32(oRow.Cells[0].Value) != 0)
                    {
                        MTPD.iIdTipoProceso_Duracion = Convert.ToInt32(oRow.Cells[0].Value);
                        MTPD.cAñoProceso = Convert.ToString(oRow.Cells[1].Value);
                        MTPD.cCodTipoProceso = Convert.ToString(oRow.Cells[2].Value);
                        MTPD.cCodObjetoContratacion = Convert.ToString(oRow.Cells[3].Value);
                        MTPD.iIdPaso = Convert.ToInt32(oRow.Cells[4].Value);
                        MTPD.iDuracion = Convert.ToInt32(oRow.Cells[6].Value);
                        MTPD.iDiaEmail = Convert.ToInt32(oRow.Cells[7].Value);
                        MTPD.iTipoDuracion = Convert.ToInt32(oRow.Cells[8].Text);
                        MTPD.cCodEstadoDuracionPaso = Convert.ToString(oRow.Cells[10].Value);
                        MTPD.iOrden = Convert.ToInt32(oRow.Cells[11].Value);
                        intIdTipoProceso_Duracion = MTPD.iIdTipoProceso_Duracion;
                        mostrarDocumento(MTPD);
                    }
                }
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            intIdTipoProceso_Duracion = 0;
            mostrarDocumento(new Model.TipoProceso_Duracion());
            AccionBotones(false, true, true, false, false);
            this.Nud_Duracion.Focus();
        }

        private void Btn_DesHacer_Click(object sender, EventArgs e)
        {
            mostrarDocumento(MTPD);
            if (MTPD.iIdPaso == 0)
            {
                intIdTipoProceso_Duracion = 0;
                AccionBotones(false, true, true, false, false);
            }
            else
            {
                intIdTipoProceso_Duracion = MTPD.iIdTipoProceso_Duracion;
                AccionBotones(true, true, true, true, true);
            }
            this.Nud_Duracion.Focus();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult intEliminaRegistro = MessageBox.Show(  "Desea Eliminar el Registro",
                                                                "Advertencia", MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Exclamation
                                                               );


            if (intEliminaRegistro == DialogResult.Yes)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.Grd_mvto_TipoProceso.ActiveRow;
                bool blnResultado;
                if (MyStuff.UsaWCF == true)
                {
                    blnResultado = objWCF.Elimina_TipoProceso_Duracion(MTPD.iIdTipoProceso_Duracion);
                }
                else
                {
                    blnResultado = sdl.Elimina_TipoProceso_Duracion(MTPD.iIdTipoProceso_Duracion);
                }
                
                if (blnResultado == false)
                {
                    MessageBox.Show("Error: No se pudo eliminar el registro");
                }
                else
                {
                    oRow.Delete(false);

                    if (Grd_mvto_TipoProceso.Rows.Count > 0)
                    {
                        oRow = this.Grd_mvto_TipoProceso.ActiveRow;
                        if (oRow == null)
                        {
                            oRow = this.Grd_mvto_TipoProceso.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First);
                        }

                        MTPD.iIdTipoProceso_Duracion = Convert.ToInt32(oRow.Cells[0].Value);
                        MTPD.cAñoProceso = Convert.ToString(oRow.Cells[1].Value);
                        MTPD.cCodTipoProceso = Convert.ToString(oRow.Cells[2].Value);
                        MTPD.cCodObjetoContratacion = Convert.ToString(oRow.Cells[3].Value);
                        MTPD.iIdPaso = Convert.ToInt32(oRow.Cells[4].Value);
                        MTPD.iDuracion = Convert.ToInt32(oRow.Cells[6].Value);
                        MTPD.iDiaEmail = Convert.ToInt32(oRow.Cells[7].Value);
                        MTPD.iTipoDuracion = Convert.ToInt32(oRow.Cells[8].Value);
                        MTPD.cCodEstadoDuracionPaso = Convert.ToString(oRow.Cells[10].Value);
                        MTPD.iOrden = Convert.ToInt32(oRow.Cells[11].Value);

                        intIdTipoProceso_Duracion = MTPD.iIdTipoProceso_Duracion;
                        mostrarDocumento(MTPD);
                        AccionBotones(true, true, true, true, true);
                    }
                    else
                    {
                        intIdTipoProceso_Duracion = 0;
                        mostrarDocumento(new Model.TipoProceso_Duracion());
                        AccionBotones(false, true, true, false, false);
                        this.Nud_Duracion.Focus();
                    }

                }
            }
            //If dsGrilla.Tables(0).Rows.Count = 0 Then
            //    AccionBotones(True, False, False, False, False)
            //Else
            //End If
        }

        private void pintarGrilla()
        {
            //Me.grd_mvto_concepto.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False ''Infragistics.Win.DefaultableBoolean.Default

            //Infragistics.Win.UltraWinGrid.UltraGridBand oBand;
            //Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn;
            this.Grd_mvto_TipoProceso.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.Grd_mvto_TipoProceso.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_mvto_TipoProceso.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("iDuracion"))
                {
                    oBand.Summaries.Add("iDuracion", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["iDuracion"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["iDuracion"].DisplayFormat = "{0:###}";
                    oBand.Summaries["iDuracion"].Appearance.TextHAlign = HAlign.Right;
                }
            }
            this.Grd_mvto_TipoProceso.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default


            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand  oBand in this.Grd_mvto_TipoProceso.DisplayLayout.Bands)
            {
                foreach (Infragistics.Win.UltraWinGrid.UltraGridColumn  oColumn in oBand.Columns)
                {
                    if (oColumn.DataType.ToString() == "System.Int32")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "###";
                    }
                }
            }


            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.Grd_mvto_TipoProceso.DisplayLayout.Bands[0];
            oBand0.Columns[4].Header.Caption = "Paso";
            oBand0.Columns[4].Width = 53;
            oBand0.Columns[5].Header.Caption = "Descripción";
            oBand0.Columns[5].Width = 400;
            oBand0.Columns[6].Header.Caption = "Duracion (dias)";
            oBand0.Columns[6].Width = 90;
            oBand0.Columns[7].Header.Caption = "Dias Email (dias)";
            oBand0.Columns[7].Width = 90;
            oBand0.Columns[9].Header.Caption = "Tipo ( dias )";
            oBand0.Columns[9].Width = 90;

            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[1].Hidden = true;
            oBand0.Columns[2].Hidden = true;
            oBand0.Columns[3].Hidden = true;
            oBand0.Columns[4].Hidden = true;
            oBand0.Columns[8].Hidden = true;
            oBand0.Columns[10].Hidden = true;
            oBand0.Columns[11].Hidden = true;
        }

        private void Grd_mvto_TipoProceso_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            //e.Layout.Override.FilterUIType = FilterUIType.FilterRow;

            FilterOperatorDropDownItems val = FilterOperatorDropDownItems.Contains;
            this.Grd_mvto_TipoProceso.DisplayLayout.Override.FilterOperatorDropDownItems = val;

            FilterOperatorDefaultValue val1 = FilterOperatorDefaultValue.Contains;
            this.Grd_mvto_TipoProceso.DisplayLayout.Override.FilterOperatorDefaultValue = val1;

            this.Grd_mvto_TipoProceso.DisplayLayout.ScrollStyle = ScrollStyle.Immediate;
            this.Grd_mvto_TipoProceso.DisplayLayout.Scrollbars = Scrollbars.Both;
            this.Grd_mvto_TipoProceso.DisplayLayout.ColumnScrollbarSmallChange = 100;
            this.Grd_mvto_TipoProceso.DisplayLayout.UseScrollWindow = UseScrollWindow.None;
            //Grd_Buscados.DisplayLayout.UseFixedHeaders = true;
        }

        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";
            try
            {

                if (String.IsNullOrEmpty( Convert.ToString(  this.Cbo_codPasoActoPrevio.SelectedValue)) )
                {
                    blnVerifica = false;
                    strMensaje = "Debe Elegir el paso";
                }
                if (this.Nud_Duracion.Value == 0)
                {
                    if (Convert.ToString(this.Cbo_codPasoActoPrevio.SelectedValue).Trim() != "00")
                    {
                        blnVerifica = false;
                        strMensaje = "Debe anotar la duración del paso";
                    }
                }

                if (this.Nud_DiaEmail.Value == 0)
                {
                    if (Convert.ToString(this.Cbo_codPasoActoPrevio.SelectedValue).Trim() != "00")
                    {
                        blnVerifica = false;
                        strMensaje = "Debe Elegir el dia de alerta";
                    }
                }

                if ((this.Opt_Habiles.Checked == false & this.Opt_Calendario.Checked == false))
                {
                    blnVerifica = false;
                    strMensaje = "Debe Elegir el Tipo de Duración";
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

        private void Btn_Grabar_Click(object sender, EventArgs e)
        {
            if (VerificaIngresoMovimiento())
            {
                if (Btn_Nuevo.Enabled == false)
                {
                    MTPD.iIdTipoProceso_Duracion = 0;
                }
                MTPD.cCodTipoProceso = Convert.ToString(this.Cbo_TipoProceso.SelectedValue);
                MTPD.cCodObjetoContratacion = Convert.ToString(this.Cbo_ObjetoContratacion.SelectedValue);
                MTPD.cAñoProceso = Convert.ToString(this.Cbo_PeriodoProceso.SelectedValue);
                MTPD.iIdPaso = Convert.ToInt32(this.Cbo_codPasoActoPrevio.SelectedValue);
                MTPD.iDuracion = Convert.ToInt32( this.Nud_Duracion.Value );
                MTPD.iDiaEmail = Convert.ToInt32( this.Nud_DiaEmail.Value );

                if (Opt_Habiles.Checked)
                {
                    MTPD.iTipoDuracion = 1;
                }
                else
                {
                    MTPD.iTipoDuracion = 2;
                }
                if (intIdTipoProceso_Duracion == 0)
                {
                    MTPD.cCodEstadoDuracionPaso = "1";
                    MTPD.iOrden = 0;
                    int[] intResult = new int[2];
                    if (MyStuff.UsaWCF == true)
                    {
                        intResult = objWCF.Graba_TipoProceso_Duracion(MTPD);
                    }
                    else
                    {
                        intResult = sdl.Graba_TipoProceso_Duracion(MTPD);
                    }
                    
                    intIdTipoProceso_Duracion = intResult[0];
                    MTPD.iIdTipoProceso_Duracion = intIdTipoProceso_Duracion;
                    MTPD.iOrden = intResult[1];
                    RegistroMovConceptos();
                }
                else
                {
                    MTPD.iOrden = Convert.ToInt32( this.Nud_Orden.Value );
                    if (MyStuff.UsaWCF == true)
                    {
                        intIdTipoProceso_Duracion = objWCF.Modifica_TipoProceso_Duracion(MTPD);
                    }
                    else
                    {
                        intIdTipoProceso_Duracion = sdl.Modifica_TipoProceso_Duracion(MTPD);
                    }
                    
                    PintarDatosRegistro();
                }
                if (intIdTipoProceso_Duracion == 0)
                {
                   MessageBox.Show("Error: No se grabaron los datos");
                }
                else
                {
                    MessageBox.Show("OK: Los datos se actualiza´ron correctamente");
                    intIdTipoProceso_Duracion = MTPD.iIdTipoProceso_Duracion;
                    AccionBotones(true, true, true, true, true);
                }

            }
        }

        private void Btn_Listar_Click(object sender, EventArgs e)
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
                    this.UltraGridExcelExporter1.Export(this.Grd_mvto_TipoProceso, strFile);
                }
                catch 
                {
                    MessageBox.Show("Error", "Error");
                }
            }
        }

        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
            string strAñoProceso = Convert.ToString(this.Cbo_PeriodoProceso.SelectedValue);
            string strCodTipoProceso = Convert.ToString(this.Cbo_TipoProceso.SelectedValue);
            string strCodObjetoContratacion = Convert.ToString(this.Cbo_ObjetoContratacion.SelectedValue);
            if ( string.IsNullOrEmpty( strCodObjetoContratacion ) == false )
            {
                this.grp_Catalogo.Visible = true;

                Model.TipoProceso MTP = new Model.TipoProceso();

                if (MyStuff.UsaWCF == true)
                {
                    MTP = objWCF.Recupera_TipoProceso_Codigo(strCodTipoProceso);
                }
                else
                {
                    MTP = sdl.Recupera_TipoProceso_Codigo(strCodTipoProceso);
                }

                    if (MyStuff.UsaWCF == true)
                {
                }
                else
                {
                    //this.Cbo_ObjetoContratacion.CargaDT(sdl.Combo_ObjetoContratacion(strCodTipoProceso).Tables[0]);
                    this.Cbo_codPasoActoPrevio.CargaDT(sdl.Combo_Paso(MTP.cCodTipoPlantilla).Tables[0]);
                }

                if (MyStuff.UsaWCF == true)
                {
                    dtGrilla = objWCF.Lista_TipoProceso_Duracion(strAñoProceso, strCodTipoProceso, strCodObjetoContratacion).Tables[0];
                }
                else
                {
                    dtGrilla = sdl.Lista_TipoProceso_Duracion(strAñoProceso, strCodTipoProceso, strCodObjetoContratacion).Tables[0];
                }
                
                if (dtGrilla.Rows.Count > 0)
                {
                    foreach (DataRow oRow in dtGrilla.Rows)
                    {

                        MTPD.iIdTipoProceso_Duracion = Convert.ToInt32(oRow["iIdTipoProceso_Duracion"]);
                        MTPD.cAñoProceso = Convert.ToString(oRow["cAñoProceso"]);
                        MTPD.cCodTipoProceso = Convert.ToString(oRow["cCodTipoProceso"]);
                        MTPD.cCodObjetoContratacion = Convert.ToString(oRow["cCodObjetoContratacion"]);
                        MTPD.iIdPaso = Convert.ToInt32(oRow["iIdPaso"]);
                        MTPD.iDuracion = Convert.ToInt32(oRow["iDuracion"]);
                        MTPD.iDiaEmail = Convert.ToInt32(oRow["iDiaEmail"]);
                        MTPD.iTipoDuracion = Convert.ToInt32(oRow["iTipoDuracion"]);
                        MTPD.cCodEstadoDuracionPaso = Convert.ToString(oRow["cCodEstadoDuracionPaso"]);
                        MTPD.iOrden = Convert.ToInt32(oRow["iOrden"]);

                        mostrarDocumento(MTPD);
                        intIdTipoProceso_Duracion = MTPD.iIdTipoProceso_Duracion;
                        break;
                    }
                }
                else
                {
                    AccionBotones(true, true, true, true, true);
                    mostrarDocumento(new Model.TipoProceso_Duracion());
                }
                this.Grd_mvto_TipoProceso.DataSource = dtGrilla;
                if (blnPintarGrilla == true)
                {
                    pintarGrilla();
                    blnPintarGrilla = false;
                }

            }
            else
            {
                this.grp_Catalogo.Visible = false;
            }
        }

        private void Frm_TipoProceso_Duracion_Load(object sender, EventArgs e)
        {
            if (MyStuff.UsaWCF == true)
            {
                this.Cbo_PeriodoProceso.CargaDT(objWCF.Combo_PeriodoProceso().Tables[0]);
                this.Cbo_TipoProceso.CargaDT(objWCF.Combo_TipoProceso().Tables[0]);
            }
            else
            {
                this.Cbo_PeriodoProceso.CargaDT(sdl.Combo_PeriodoProceso().Tables[0]);
                this.Cbo_TipoProceso.CargaDT(sdl.Combo_TipoProceso().Tables[0]);
            }
            
        }

        private void Cbo_TipoProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Cbo_TipoProceso.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                string strCodTipoProceso = Convert.ToString(this.Cbo_TipoProceso.SelectedValue);
                if (MyStuff.UsaWCF == true)
                {
                    this.Cbo_ObjetoContratacion.CargaDT(objWCF.Combo_ObjetoContratacion(strCodTipoProceso).Tables[0]);
                }
                else
                {
                    this.Cbo_ObjetoContratacion.CargaDT(sdl.Combo_ObjetoContratacion(strCodTipoProceso).Tables[0]);
                }
                
            }
        }

        private void ultraGroupBox2_Click(object sender, EventArgs e)
        {

        }


        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cbo_ObjetoContratacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
