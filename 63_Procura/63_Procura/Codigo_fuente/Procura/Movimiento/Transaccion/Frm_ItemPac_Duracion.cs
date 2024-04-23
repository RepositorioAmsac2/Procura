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
    public partial class Frm_ItemPac_Duracion : Form
    {

        private Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();
        private Service.Data sdl = new Service.Data();
        private Model.ProcesoLogistico_Duracion MPDD = new Model.ProcesoLogistico_Duracion();
        private Model.ProcesoLogistico_Eliminado MPDE = new Model.ProcesoLogistico_Eliminado();

        private DataSet dsGrilla = new DataSet();
        private int intIdPac_Duracion = 0;
        private Boolean blnPintarFormato = true;
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public Frm_ItemPac_Duracion()
        {
            InitializeComponent();
        }

        private void Frm_ItemPac_Duracion_Load(object sender, EventArgs e)
        {

             Model.ProcesoLogistico_Cabecera MPC = new Model.ProcesoLogistico_Cabecera();
            
            if (MyStuff.UsaWCF == true)
            {
                MPC = objWCF.Recupera_Pac_Cabecera_Id();
            }
            else
            {
                MPC = sdl.Recupera_ProcesoLogistico_Cabecera_Id();
            }
            
            if (MPC.iIdProcesoLogistico_Cabecera != 0)
            {
                this.txt_AñoProceso.Value = MPC.cAñoProceso;
                this.txt_Version.Value = MPC.cVersion;
            }
            
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {

            int intIdPac_Detalle = MPD.iIdProcesoLogistico_Detalle;
            if (intIdPac_Detalle != 0)
            {
                this.grp_Duracion.Visible = true;

                Model.TipoProceso MTP = new Model.TipoProceso();

                if (MyStuff.UsaWCF == true)
                {
                    MTP = objWCF.Recupera_TipoProceso_Codigo(MPD.cCodTipoProceso);
                }
                else
                {
                    MTP = sdl.Recupera_TipoProceso_Codigo(MPD.cCodTipoProceso);
                }

                if (MyStuff.UsaWCF == true)
                {
                    this.cbo_codPasoActoPrevio.CargaDT(objWCF.Combo_Paso(MTP.cCodTipoPlantilla).Tables[0]);
                }
                else
                {
                    this.cbo_codPasoActoPrevio.CargaDT(sdl.Combo_Paso(MTP.cCodTipoPlantilla).Tables[0]);
                }

                if (MyStuff.UsaWCF == true)
                {
                    dsGrilla = objWCF.Lista_Pac_Duracion(MPD.cAñoProceso,
                                                    MPD.cVersion,
                                                    MPD.cNumProcedimiento
                                                 );
                }
                else
                {
                    dsGrilla = sdl.Lista_ProcesoLogistico_Duracion(MPD.cAñoProceso,
                                                    MPD.cVersion,
                                                    MPD.cNumProcedimiento
                                                 );
                }
                
                if (dsGrilla.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow oRow in dsGrilla.Tables[0].Rows)
                    {

                        MPDD.IidProcesoLogistico_Duracion = Convert.ToInt32(oRow["iIdProcesoLogistico_Duracion"]);
                        MPDD.CnumProcedimiento = Convert.ToString(oRow["CnumProcedimiento"]);
                        MPDD.CcodPaso = Convert.ToString(oRow["cCodPaso"]);
                        MPDD.Iduracion = Convert.ToInt32(oRow["iDuracion"]);
                        MPDD.IdiaEmail = Convert.ToInt32(oRow["iDiaEmail"]);
                        MPDD.ItipoDuracion = Convert.ToInt32(oRow["iTipoDuracion"]);
                        MPDD.CcodEstadoDuracionPaso = Convert.ToString(oRow["cCodEstadoDuracionPaso"]);
                        MPDD.Iorden = Convert.ToInt32(oRow["iOrden"]);

                        mostrarDocumento(MPDD);

                        intIdPac_Duracion = MPDD.IidProcesoLogistico_Duracion;
                        break;
                    }
                }
                else
                {
                    AccionBotones(true, true, true, true, true);
                    mostrarDocumento(new Model.ProcesoLogistico_Duracion());
                }
                this.grd_mvto_DocumntoComite.DataSource = dsGrilla;
                if (blnPintarFormato == true)
                {
                    this.FormataGrid();
                    blnPintarFormato = false;
                }

            }
            else
            {
                this.grp_Duracion.Visible = false;
            }


        }


        private void mostrarDocumento(Model.ProcesoLogistico_Duracion obj)
        {
            this.cbo_codPasoActoPrevio.SelectedValue = obj.CcodPaso;
            this.nud_Duracion.Value = obj.Iduracion;
            this.nud_DiaEmail.Value = obj.IdiaEmail;
            this.Nud_Orden.Value = obj.Iorden;
            if (intIdPac_Duracion == 0)
            {
                this.Nud_Orden.Enabled = false;
            }
            else
            {
                this.Nud_Orden.Enabled = true;
            }
            if (obj.ItipoDuracion == 1)
            {
                this.opt_Habiles.Checked = true;
                this.opt_Calendario.Checked = false;
            }
            else
            {
                this.opt_Habiles.Checked = false;
                this.opt_Calendario.Checked = true;
            }
        }

        private void AccionBotones(bool blnNuevo,
            bool blnGrabar,
            bool blnDesHacer,
            bool blnEliminar,
            bool blnListar
            )
            {
            this.btn_Nuevo.Enabled = blnNuevo;
            this.btn_Grabar.Enabled = blnGrabar;
            this.btn_DesHacer.Enabled = blnDesHacer;
            this.btn_Eliminar.Enabled = blnEliminar;
            this.Btn_Listar.Enabled = blnListar;
        }

        private void FormataGrid()
        {
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.grd_mvto_DocumntoComite.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("iDuracion"))
                {
                    oBand.Summaries.Add("iDuracion", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["iDuracion"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["iDuracion"].DisplayFormat = "{0:###}";
                    oBand.Summaries["iDuracion"].Appearance.TextHAlign = HAlign.Right;
                }
            }
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default


            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.grd_mvto_DocumntoComite.DisplayLayout.Bands)
            {
                foreach (Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn in oBand.Columns)
                {
                    if (oColumn.DataType.ToString() == "System.Int32")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "###";
                    }
                }
            }


            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.grd_mvto_DocumntoComite.DisplayLayout.Bands[0];
            oBand0.Columns[2].Header.Caption = "Paso";
            oBand0.Columns[2].Width = 53;
            oBand0.Columns[3].Header.Caption = "Descripción";
            oBand0.Columns[3].Width = 250;
            oBand0.Columns[4].Header.Caption = "Duracion (dias)";
            oBand0.Columns[4].Width = 90;
            oBand0.Columns[5].Header.Caption = "Dias Email (dias)";
            oBand0.Columns[5].Width = 90;
            oBand0.Columns[7].Header.Caption = "Tipo ( dias )";
            oBand0.Columns[7].Width = 90;

            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[1].Hidden = true;
            oBand0.Columns[6].Hidden = true;
            oBand0.Columns[8].Hidden = true;
            oBand0.Columns[9].Hidden = true;
        }

        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";
            try
            {

                if (String.IsNullOrEmpty( Convert.ToString( this.cbo_codPasoActoPrevio.SelectedValue)) )
                {
                    blnVerifica = false;
                    strMensaje = "Debe Elegir el paso";
                }
                if (this.nud_Duracion.Value == 0)
                {
                    if (Convert.ToString(this.cbo_codPasoActoPrevio.SelectedValue).Trim() != "00")
                    {
                        blnVerifica = false;
                        strMensaje = "Debe anotar la duración del paso";
                    }
                }

                if (this.nud_DiaEmail.Value == 0)
                {
                    if (Convert.ToString(this.cbo_codPasoActoPrevio.SelectedValue).Trim() != "00")
                    {
                        blnVerifica = false;
                        strMensaje = "Debe Elegir el dia de alerta";
                    }
                }

                if ((this.opt_Habiles.Checked == false & this.opt_Calendario.Checked == false))
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

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            if (VerificaIngresoMovimiento())
            {
                if (btn_Nuevo.Enabled == false)
                {
                    MPDD.IidProcesoLogistico_Duracion = 0;
                }
                MPDD.CnumProcedimiento = MPD.cNumProcedimiento;
                MPDD.CcodPaso = Convert.ToString(this.cbo_codPasoActoPrevio.SelectedValue);
                MPDD.Iduracion = Convert.ToInt32( this.nud_Duracion.Value );
                MPDD.IdiaEmail = Convert.ToInt32( this.nud_DiaEmail.Value );
                if (opt_Habiles.Checked)
                {
                    MPDD.ItipoDuracion = 1;
                }
                else
                {
                    MPDD.ItipoDuracion = 2;
                }
                if (intIdPac_Duracion == 0)
                {
                    MPDD.CcodEstadoDuracionPaso = "1";
                    MPDD.Iorden = 0;
                    if (MyStuff.UsaWCF == true)
                    {
                        MPDD = objWCF.Graba_Pac_Duracion(MPDD);
                    }
                    else
                    {
                        MPDD = sdl.Graba_ProcesoLogistico_Duracion(MPDD);
                    }
                    

                    RegistroMovConceptos();
                }
                else
                {
                    MPDD.Iorden = Convert.ToInt32( this.Nud_Orden.Value );
                    if (MyStuff.UsaWCF == true)
                    {
                        intIdPac_Duracion = objWCF.Modifica_Pac_Duracion(MPDD);
                    }
                    else
                    {
                        intIdPac_Duracion = sdl.Modifica_ProcesoLogistico_Duracion(MPDD);
                    }
                    

                    PintarDatosRegistro();
                }
                if (intIdPac_Duracion == 0)
                {
                   MessageBox.Show("Error: No se grabaron los datos");
                }
                else
                {
                    intIdPac_Duracion = MPDD.IidProcesoLogistico_Duracion;
                    AccionBotones(true, true, true, true, true);
                }

            }
        }

        private void grd_mvto_DocumntoComite_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            e.Layout.Override.FilterUIType = FilterUIType.FilterRow;
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

        private void grd_mvto_DocumntoComite_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            if (dsGrilla.Tables[0].Rows.Count > 0)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.grd_mvto_DocumntoComite.ActiveRow;
                if (oRow == null)
                {
                }
                else
                {
                    if (Convert.ToInt32(oRow.Cells[0].Value) != 0)
                    {
                        MPDD.IidProcesoLogistico_Duracion = Convert.ToInt32(oRow.Cells[0].Value);
                        MPDD.CnumProcedimiento = Convert.ToString(oRow.Cells[1].Value);
                        MPDD.CcodPaso = Convert.ToString(oRow.Cells[2].Value);
                        MPDD.Iduracion = Convert.ToInt32(oRow.Cells[4].Value);
                        MPDD.IdiaEmail = Convert.ToInt32(oRow.Cells[5].Value);
                        MPDD.ItipoDuracion = Convert.ToInt32(oRow.Cells[6].Text);
                        MPDD.CcodEstadoDuracionPaso = Convert.ToString(oRow.Cells[8].Value);
                        MPDD.Iorden = Convert.ToInt32(oRow.Cells[9].Value);

                        intIdPac_Duracion = MPDD.IidProcesoLogistico_Duracion;
                        mostrarDocumento(MPDD);
                    }
                }
            }
        }

        private void PintarDatosRegistro()
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = grd_mvto_DocumntoComite.ActiveRow;
            oRow.Cells[0].Value = MPDD.IidProcesoLogistico_Duracion;
            oRow.Cells[1].Value = MPDD.CnumProcedimiento;
            oRow.Cells[2].Value = MPDD.CcodPaso;
            oRow.Cells[3].Value = Convert.ToString(this.cbo_codPasoActoPrevio.Text);
            oRow.Cells[4].Value = MPDD.Iduracion;
            oRow.Cells[5].Value = MPDD.IdiaEmail;
            oRow.Cells[6].Value = MPDD.ItipoDuracion;
            if (MPDD.ItipoDuracion == 1)
            {
                oRow.Cells[7].Value = "Hab";
            }
            else
            {
                oRow.Cells[7].Value = "Cal";
            }
            oRow.Cells[8].Value = MPDD.CcodEstadoDuracionPaso;
            oRow.Cells[9].Value = MPDD.Iorden;
        }

        private void RegistroMovConceptos()
        {
            grd_mvto_DocumntoComite.DisplayLayout.Bands[0].AddNew();
            PintarDatosRegistro();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            intIdPac_Duracion = 0;
            mostrarDocumento(new Model.ProcesoLogistico_Duracion() );
            AccionBotones(false, true, true, false, false);
            this.nud_Duracion.Focus();
        }

        private void btn_DesHacer_Click(object sender, EventArgs e)
        {
            mostrarDocumento(MPDD);
            if (MPDD.CcodPaso.TrimEnd() == "")
            {
                intIdPac_Duracion = 0;
                AccionBotones(false, true, true, false, false);
            }
            else
            {
                intIdPac_Duracion = MPDD.IidProcesoLogistico_Duracion;
                AccionBotones(true, true, true, true, true);
            }
            this.nud_Duracion.Focus();
        }

        private void Txt_NumProcedimiento_Leave(object sender, EventArgs e)
        {
            if (Convert.ToString(this.Txt_NumProcedimiento.Text).Trim() != "")
            {
                string strNumProcedimiento = Convert.ToString(this.Txt_NumProcedimiento.Text);
                if (strNumProcedimiento.Substring(0, 1).Trim() != "")
                {
                    string strAñoProceso = Convert.ToString(this.txt_AñoProceso.Value);
                    string strVersion = Convert.ToString(this.txt_Version.Value);
                    if (MyStuff.UsaWCF == true)
                    {
                        MPD = objWCF.Recupera_Pac_Detalle_Codigo(strNumProcedimiento);
                    }
                    else
                    {
                        MPD = sdl.Recupera_ProcesoLogistico_Detalle_Codigo(strNumProcedimiento);
                    }
                    

                    if (MPD.cNumProcedimiento.Trim() != "")
                    {
                        this.grp_Duracion.Visible = false;
                        this.MostrarDatos(MPD);


                        if (MPD.iIdProcesoLogistico_Eliminado != 0)
                        {
                            int intEliminado = MPD.iIdProcesoLogistico_Eliminado;
                            if (MyStuff.UsaWCF == true)
                            {
                                MPDE = objWCF.Recupera_Pac_Eliminado(intEliminado);
                            }
                            else
                            {
                                MPDE = sdl.Recupera_ProcesoLogistico_Eliminado(intEliminado);
                            }
                            
                            MessageBox.Show("Aviso: El Item ha sido Incluido" + (char)(13) + (char)(13) +
                                               "Fecha          : " + Convert.ToString(MPDE.dFecEliminado) + (char)(13) +
                                               "Motivo         : " + Convert.ToString(MPDE.tMotEliminado) + (char)(13) +
                                               "Incluido    por: " + Convert.ToString(MPDE.vApeEmpleado)
                                           );
                            this.Close();
                        }
                        else
                        {
                            this.btn_Mostrar.Enabled = true;
                        }
                    }
                    else
                    {
                       MessageBox.Show("Error: El código ingresado NO Existe");
                    }

                }
            }
            else
            {
                this.MostrarDatos(new Model.ProcesoLogistico_Detalle());
                this.btn_Mostrar.Enabled = false;
                this.grp_Duracion.Visible = false;
            }
        }

        private void MostrarDatos(Model.ProcesoLogistico_Detalle MPD)
        {
            this.edt_Descripcion.Value = MPD.tDesContratacion;
            this.txt_DesObjetoContratacion.Value = MPD.vDesObjetoContratacion;
            this.txt_DesTipoProceso.Text = MPD.vDesTipoProceso;
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

                    this.UltraGridExcelExporter1.Export(this.grd_mvto_DocumntoComite, strFile);

                }
                catch
                {
                    MessageBox.Show("Error", "Error");
                }
            }
        }
    }
}
