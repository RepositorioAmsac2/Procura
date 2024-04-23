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
    
    public partial class Frm_ActualizaComite_Resolucion : Form
    {
        Model.Comite_Resolucion MCR = new Model.Comite_Resolucion();
        Model.TipoDocumento_Pac MTDP = new Model.TipoDocumento_Pac();
        Service.Data sdl = new Service.Data();

        DataTable dtGrilla = new DataTable();
        bool blnPintarGrilla = true;
        int intIdDocumentoComite = 0;
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        public Frm_ActualizaComite_Resolucion()
        {
            InitializeComponent();
        }

        private void mostrarDocumento( Model.Comite_Resolucion obj)
        {
            this.txt_Periodo.Text = Convert.ToString(obj.cPerProceso);
            this.dtp_FecDocumento.Value = Convert.ToDateTime(obj.dFecDocumento);
            this.cbo_CodTipoDocumento.SelectedValue = Convert.ToString(obj.cCodTipoDocumento);
            this.txt_NumDocumento.Value = Convert.ToString(obj.cNumDocumento);
            this.edt_Nota.Value = Convert.ToString(obj.tNota);
        }

        private void PintarDatosRegistro()
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = grd_mvto_DocumntoComite.ActiveRow;
            oRow.Cells[0].Value = MCR.iIdDocumentoComite;
            oRow.Cells[1].Value = MCR.cPerProceso;
            oRow.Cells[2].Value = MCR.dFecDocumento;
            oRow.Cells[3].Value = MCR.cCodTipoDocumento;
            oRow.Cells[4].Value = Convert.ToString(this.cbo_CodTipoDocumento.Text);
            oRow.Cells[5].Value = MCR.cNumDocumento;
            oRow.Cells[6].Value = MCR.tNota;
        }
        private void RegistroMovConceptos()
        {
            grd_mvto_DocumntoComite.DisplayLayout.Bands[0].AddNew();
            PintarDatosRegistro();
        }


        private void AccionBotones( bool blnNuevo,
                                    bool blnGrabar,
                                    bool blnDesHacer,
                                    bool blnEliminar,
                                    bool blnListar
                                  )
        {
            
            this.Btn_Nuevo.Enabled = blnNuevo;
            this.Btn_Grabar.Enabled = blnGrabar;
            this.Btn_DesHacer.Enabled = blnDesHacer;
            this.Btn_Eliminar.Enabled = blnEliminar;
            this.Btn_Listar.Enabled = blnListar;
        }

        private void grd_mvto_DocumntoComite_AfterSelectChange(object sender, Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs e)
        {
            if (dtGrilla.Rows.Count > 0)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.grd_mvto_DocumntoComite.ActiveRow;
                if ((oRow.Cells[0].Text).Trim() != "")
                {
                    MCR.iIdDocumentoComite = Convert.ToInt32(oRow.Cells[0].Text);
                    MCR.cPerProceso = Convert.ToString(oRow.Cells[1].Text);
                    MCR.dFecDocumento = Convert.ToDateTime(oRow.Cells[2].Text);
                    MCR.cCodTipoDocumento = Convert.ToString(oRow.Cells[3].Text);
                    MCR.cNumDocumento = Convert.ToString(oRow.Cells[5].Text);
                    MCR.tNota = Convert.ToString(oRow.Cells[6].Text);

                    intIdDocumentoComite = MCR.iIdDocumentoComite;
                    mostrarDocumento(MCR);
                }
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            intIdDocumentoComite = 0;
            mostrarDocumento(new Model.Comite_Resolucion());
            AccionBotones(false, true, true, false, false);
            this.txt_Periodo.Focus();
        }

        private void Btn_DesHacer_Click(object sender, EventArgs e)
        {
            mostrarDocumento(MCR);
            if (MCR.cCodTipoDocumento.Trim() == "")
            {
                intIdDocumentoComite = 0;
                AccionBotones(false, true, true, false, false);
            }
            else
            {
                intIdDocumentoComite = MCR.iIdDocumentoComite;
                AccionBotones(true, true, true, true, true);
            }
            this.txt_Periodo.Focus();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult intEliminaRegistro = MessageBox.Show(  "Desea Eliminar el Registro",
                                                                "Advertencia", MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Exclamation
                                                               );
            if (intEliminaRegistro == DialogResult.OK)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.grd_mvto_DocumntoComite.ActiveRow;
                bool blnResultado;

                if (MyStuff.UsaWCF == true)
                {
                    blnResultado = objWCF.Elimina_Comite_Resolucion(MCR.iIdDocumentoComite);
                }
                else
                {
                    blnResultado = sdl.Elimina_Comite_Resolucion(MCR.iIdDocumentoComite);
                }
                

                if (blnResultado == false)
                {
                    MessageBox.Show("Error: No se pudo eliminar el registro");
                }
                else
                {
                    oRow.Delete(false);

                    if (grd_mvto_DocumntoComite.Rows.Count > 0)
                    {
                        oRow = this.grd_mvto_DocumntoComite.ActiveRow;
                        if (oRow == null)
                        {
                            oRow = this.grd_mvto_DocumntoComite.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First);
                        }
                        intIdDocumentoComite = MCR.iIdDocumentoComite;
                        MCR.iIdDocumentoComite = Convert.ToInt32(oRow.Cells[0].Text);
                        MCR.cPerProceso = Convert.ToString(oRow.Cells[1].Text);
                        MCR.dFecDocumento = Convert.ToDateTime(oRow.Cells[2].Text);
                        MCR.cCodTipoDocumento = Convert.ToString(oRow.Cells[3].Text);
                        MCR.cNumDocumento = Convert.ToString(oRow.Cells[5].Text);
                        MCR.tNota = Convert.ToString(oRow.Cells[6].Text);
                        mostrarDocumento(MCR);
                        AccionBotones(true, true, true, true, true);
                    }
                    else
                    {
                        intIdDocumentoComite = 0;
                        mostrarDocumento(new Model.Comite_Resolucion());
                        AccionBotones(false, true, true, false, false);
                        this.txt_Periodo.Focus();
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
            //Infragistics.Win.UltraWinGrid.UltraGridBand oBand;
            //Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand  oBand in this.grd_mvto_DocumntoComite.DisplayLayout.Bands)
            {
                if (oBand.Columns.Exists("fImporte"))
                {
                    oBand.Summaries.Add("Sum_fImporte", Infragistics.Win.UltraWinGrid.SummaryType.Sum, oBand.Columns["fImporte"], Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn);
                    oBand.Summaries["Sum_fImporte"].DisplayFormat = "{0:#,###,###.00}";
                    oBand.Summaries["Sum_fImporte"].Appearance.TextHAlign = HAlign.Right;
                }
            }
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default


            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.grd_mvto_DocumntoComite.DisplayLayout.Bands)
            {
                foreach (Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn in oBand.Columns)
                {
                    if (oColumn.DataType.ToString() == "System.Double")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "#,###,###.00";
                    }
                    if (oColumn.DataType.ToString() == "System.Int32")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "#,###,###";
                    }
                }
            }

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.grd_mvto_DocumntoComite.DisplayLayout.Bands[0];

            oBand0.Columns[1].Header.Caption = "Periodo";
            oBand0.Columns[1].Width = 40;
            oBand0.Columns[2].Header.Caption = "Fecha";
            oBand0.Columns[2].Width = 80;
            oBand0.Columns[4].Header.Caption = "Tipo Documento";
            oBand0.Columns[4].Width = 140;
            oBand0.Columns[5].Header.Caption = "Número";
            oBand0.Columns[5].Width = 100;
            oBand0.Columns[6].Header.Caption = "Nota";
            oBand0.Columns[6].Width = 245;
            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[3].Hidden = true;
            oBand0.Columns[7].Hidden = true;
        }

        private void grd_mvto_DocumntoComite_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
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

            this.grd_mvto_DocumntoComite.DisplayLayout.ScrollStyle = ScrollStyle.Immediate;
            this.grd_mvto_DocumntoComite.DisplayLayout.Scrollbars = Scrollbars.Both;
            this.grd_mvto_DocumntoComite.DisplayLayout.ColumnScrollbarSmallChange = 100;
            this.grd_mvto_DocumntoComite.DisplayLayout.UseScrollWindow = UseScrollWindow.None;
            this.grd_mvto_DocumntoComite.DisplayLayout.UseFixedHeaders = true;

            this.grd_mvto_DocumntoComite.DisplayLayout.ScrollBarLook.MinMaxButtonsVisible = true;

            this.grd_mvto_DocumntoComite.DisplayLayout.ScrollBarLook.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.BothAtRightBottom;
            //Me.grd_mvto_Indicador.DisplayLayout.ScrollBarLook.Appearance.BackColor = Color.PapayaWhip
            //Me.grd_mvto_Indicador.DisplayLayout.ScrollBarLook.Appearance.BackColor2 = Color.SkyBlue
            this.grd_mvto_DocumntoComite.DisplayLayout.ScrollBarLook.Appearance.BackGradientStyle = GradientStyle.Vertical;
            //Me.grd_mvto_Indicador.DisplayLayout.ScrollBarLook.ButtonAppearance.BackColor = Color.Blue
            //Me.grd_mvto_Indicador.DisplayLayout.ScrollBarLook.ButtonAppearance.ForeColor = Color.LightYellow
        }

        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";
            try
            {

                if (String.IsNullOrEmpty(this.txt_Periodo.Text))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Periodo del Documento";
                }

                if (String.IsNullOrEmpty( Convert.ToString(  this.cbo_CodTipoDocumento.SelectedValue)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Tipo del Documento";
                }

                if (String.IsNullOrEmpty(Convert.ToString(this.txt_NumDocumento.Value)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Número del Documento";
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
                    MCR.iIdDocumentoComite = 0;
                }
                MCR.cPerProceso = Convert.ToString(this.txt_Periodo.Text);
                MCR.dFecDocumento = Convert.ToDateTime( this.dtp_FecDocumento.Value );
                MCR.cCodTipoDocumento = Convert.ToString(this.cbo_CodTipoDocumento.SelectedValue);
                MCR.cNumDocumento = Convert.ToString(this.txt_NumDocumento.Value);
                MCR.tNota = Convert.ToString(this.edt_Nota.Value);
                if (intIdDocumentoComite == 0)
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        intIdDocumentoComite = objWCF.Graba_Comite_Resolucion(MCR);
                    }
                    else
                    {
                        intIdDocumentoComite = sdl.Graba_Comite_Resolucion(MCR);
                    }

                    MCR.iIdDocumentoComite = intIdDocumentoComite;
                    RegistroMovConceptos();
                }
                else
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        intIdDocumentoComite = objWCF.Modifica_Comite_Resolucion(MCR);
                    }
                    else
                    {
                        intIdDocumentoComite = sdl.Modifica_Comite_Resolucion(MCR);
                    }
                    
                    PintarDatosRegistro();
                }

                if (intIdDocumentoComite == 0)
                {
                    MessageBox.Show("Error: No se grabaron los datos");
                }
                else
                {
                    MessageBox.Show("OK: Los datos se actualiza´ron correctamente");
                    intIdDocumentoComite = MCR.iIdDocumentoComite;
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
                    this.UltraGridExcelExporter1.Export(this.grd_mvto_DocumntoComite, strFile);
                }
                catch 
                {
                    MessageBox.Show("Error", "Error");
                }
            }
        }

        private void Frm_ActualizaComite_Resolucion_Load(object sender, EventArgs e)
        {

            if (MyStuff.UsaWCF == true)
            {
                this.cbo_CodTipoDocumento.CargaDT(objWCF.Combo_TipoDocumento_Pac().Tables[0]);
                dtGrilla = objWCF.Lista_Comite_Resolucion().Tables[0];
            }
            else
            {
                this.cbo_CodTipoDocumento.CargaDT(sdl.Combo_TipoDocumento_ProcesoLogistico().Tables[0]);
                dtGrilla = sdl.Lista_Comite_Resolucion().Tables[0];
            }
            

            if (dtGrilla.Rows.Count > 0)
            {
                foreach (DataRow oRow in dtGrilla.Rows)
                {
                    MCR.iIdDocumentoComite = Convert.ToInt32(oRow["iIdDocumentoComite"]);
                    MCR.cPerProceso = Convert.ToString(oRow["cPerProceso"]);
                    MCR.cCodTipoDocumento = Convert.ToString(oRow["cCodTipoDocumento"]);
                    MCR.dFecDocumento = Convert.ToDateTime(oRow["dFecDocumento"]);
                    MCR.cCodTipoDocumento = Convert.ToString(oRow["cCodTipoDocumento"]);
                    MCR.cNumDocumento = Convert.ToString(oRow["cNumDocumento"]);
                    MCR.tNota = Convert.ToString(oRow["tNota"]);
                    MCR.bEstado = Convert.ToBoolean(oRow["bEstado"]);
                    intIdDocumentoComite = MCR.iIdDocumentoComite;
                    mostrarDocumento(MCR);
                    break;
                }
            }
            else
            {
                AccionBotones(true, true, true, true, true);
                this.txt_Periodo.Focus();
            }
            this.grd_mvto_DocumntoComite.DataSource = dtGrilla;
            pintarGrilla();
        }
    }
}
