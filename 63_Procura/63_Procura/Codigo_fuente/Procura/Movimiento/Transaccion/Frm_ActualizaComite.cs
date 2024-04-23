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
    public partial class Frm_ActualizaComite : Form
    {
        Model.Comite_Resolucion MCR = new Model.Comite_Resolucion();
        Service.Data sdl = new Service.Data();

        Model.Comite MC = new Model.Comite();

        Model.ProcesoLogistico_Detalle MPD = new Model.ProcesoLogistico_Detalle();

        DataTable dtGrilla = new DataTable();
        bool blnPintarGrilla = true;
        int intIdComite = 0;

        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();


        public Frm_ActualizaComite()
        {
            InitializeComponent();
        }

        private void mostrarDocumento(Model.Comite obj)
        {
            this.txt_NumProcedimiento.Text = Convert.ToString(obj.cNumProcedimiento);
            this.Edt_Pac.Value = Convert.ToString(obj.tDesContratacion);
            this.cbo_CodTipoComite.SelectedValue = Convert.ToString(obj.cCodTipoComite);
        }

        private void PintarDatosRegistro()
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = grd_mvto_DocumntoComite.ActiveRow;

            oRow.Cells[0].Value = MC.iIdComite;
            oRow.Cells[1].Value = MC.iIdDocumentoComite;
            oRow.Cells[2].Value = MC.cNumProcedimiento;
            oRow.Cells[3].Value = MC.tDesContratacion;
            oRow.Cells[4].Value = MC.cCodTipoComite;
            oRow.Cells[5].Value = Convert.ToString(this.cbo_CodTipoComite.Text);
            oRow.Cells[6].Value = MC.iIntegrante;
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
            
            this.btn_Nuevo.Enabled = blnNuevo;
            this.btn_Grabar.Enabled = blnGrabar;
            this.btn_DesHacer.Enabled = blnDesHacer;
            this.btn_Eliminar.Enabled = blnEliminar;
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

                    MC.iIdComite = Convert.ToInt32(oRow.Cells[0].Text);
                    MC.iIdDocumentoComite = Convert.ToInt32(oRow.Cells[1].Text);
                    MC.cNumProcedimiento = Convert.ToString(oRow.Cells[2].Text);
                    MC.tDesContratacion = Convert.ToString(oRow.Cells[3].Text);
                    MC.cCodTipoComite = Convert.ToString(oRow.Cells[4].Text);
                    MC.vDesTipoComite = Convert.ToString(oRow.Cells[5].Text);
                    MC.iIntegrante = Convert.ToInt32(oRow.Cells[6].Text);

                    mostrarDocumento(MC);
                }
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            intIdComite = 0;
            mostrarDocumento(new Model.Comite());
            AccionBotones(false, true, true, false, false);
            this.txt_NumProcedimiento.Focus();
        }

        private void btn_DesHacer_Click(object sender, EventArgs e)
        {
            mostrarDocumento(MC);
            if (MCR.cCodTipoDocumento.Trim() == "")
            {
                intIdComite = 0;
                AccionBotones(false, true, true, false, false);
            }
            else
            {
                intIdComite = MC.iIdComite;
                AccionBotones(true, true, true, true, true);
            }
            this.txt_NumProcedimiento.Focus();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult intEliminaRegistro = MessageBox.Show("Desea Eliminar el Registro",
                                                                "Advertencia", MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Exclamation
                                                               );


            if (intEliminaRegistro == DialogResult.Yes)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.grd_mvto_DocumntoComite.ActiveRow;
                bool blnResultado;

                if (MyStuff.UsaWCF == true)
                {
                    blnResultado = objWCF.Elimina_Comite(MC.iIdComite);
                }
                else
                {
                    blnResultado = sdl.Elimina_Comite(MC.iIdComite);
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
                        intIdComite = MC.iIdComite;

                        MC.iIdComite = Convert.ToInt32(oRow.Cells[0].Text);
                        MC.iIdDocumentoComite = Convert.ToInt32(oRow.Cells[1].Text);
                        MC.cNumProcedimiento = Convert.ToString(oRow.Cells[2].Text);
                        MC.tDesContratacion = Convert.ToString(oRow.Cells[3].Text);
                        MC.cCodTipoComite = Convert.ToString(oRow.Cells[4].Text);
                        MC.vDesTipoComite = Convert.ToString(oRow.Cells[5].Text);
                        MC.iIntegrante = Convert.ToInt32(oRow.Cells[6].Text);

                        mostrarDocumento(MC);
                        AccionBotones(true, true, true, true, true);
                    }
                    else
                    {
                        intIdComite = 0;
                        mostrarDocumento(new Model.Comite());
                        AccionBotones(false, true, true, false, false);
                        this.txt_NumProcedimiento.Focus();
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
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.grd_mvto_DocumntoComite.DisplayLayout.Bands[0];

            oBand0.Columns[2].Header.Caption = "Procedimiento";
            oBand0.Columns[2].Width = 120;
            oBand0.Columns[3].Header.Caption = "Item del PAC";
            oBand0.Columns[3].Width = 250;
            oBand0.Columns[5].Header.Caption = "Tipo";
            oBand0.Columns[5].Width = 120;
            oBand0.Columns[6].Header.Caption = "Integrantes";
            oBand0.Columns[6].Width = 80;

            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[1].Hidden = true;
            oBand0.Columns[4].Hidden = true;
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

                if (String.IsNullOrEmpty(this.txt_NumProcedimiento.Text))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Tipo de Procedimiento";
                }

                if (String.IsNullOrEmpty( Convert.ToString( this.cbo_CodTipoComite.SelectedValue)) )
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Tipo del Comite";
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
                    MC.iIdComite = 0;
                }
                int intIdDocumentoComite = Convert.ToInt32(this.cbo_NumDocumento.SelectedValue);
                MC.iIdDocumentoComite = intIdDocumentoComite;
                MC.tDesContratacion = MPD.tDesContratacion;
                MC.cNumProcedimiento = MPD.cNumProcedimiento;
                MC.cCodTipoComite = Convert.ToString(this.cbo_CodTipoComite.SelectedValue);
                if (intIdComite == 0)
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        intIdComite = objWCF.Graba_Comite(MC);
                    }
                    else
                    {
                        intIdComite = sdl.Graba_Comite(MC);
                    }
                    

                    MC.iIdComite = intIdComite;
                    RegistroMovConceptos();
                    Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                    oRow = this.grd_mvto_DocumntoComite.ActiveRow;
                    RefrescarCeldaGrilla(oRow);
                }
                else
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        intIdComite = objWCF.Modifica_Comite(MC);
                    }
                    else
                    {
                        intIdComite = sdl.Modifica_Comite(MC);
                    }
                    

                    PintarDatosRegistro();
                }
                if (intIdComite == 0)
                {
                    MessageBox.Show("Error: No se grabaron los datos");
                }
                else
                {
                    MessageBox.Show("OK: Los datos se actualiza´ron correctamente");
                    intIdComite = MCR.iIdDocumentoComite;
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

        private void cbo_PerProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbo_PerProceso.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                string strAñoProceso = Convert.ToString(this.cbo_PerProceso.SelectedValue);
                if (MyStuff.UsaWCF == true)
                {
                    this.cbo_NumDocumento.CargaDT(objWCF.combo_Comite_Resolucion_NumDocumento(strAñoProceso).Tables[0]);
                }
                else
                {
                    this.cbo_NumDocumento.CargaDT(sdl.combo_Comite_Resolucion_NumDocumento(strAñoProceso).Tables[0]);
                }
                
            }
        }

        private void AdicionaImagenesGrilla()
        {
            //Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow oRow in this.grd_mvto_DocumntoComite.Rows)
            {
                RefrescarCeldaGrilla(oRow);
            }
        }
        private void RefrescarCeldaGrilla(Infragistics.Win.UltraWinGrid.UltraGridRow oRow)
        {
            oRow.Cells[6].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button;
            oRow.Cells[6].Appearance.Image = imageList1.Images[0];
            oRow.Cells[6].ButtonAppearance.Image = imageList1.Images[0];
            oRow.Cells[6].ButtonAppearance.TextHAlign = HAlign.Right;
        }

        private void grd_mvto_DocumntoComite_ClickCellButton(object sender, CellEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.grd_mvto_DocumntoComite.ActiveRow;
            if (e.Cell.Column.Index == 6)
            {
                Frm_ActualizaComite_Integrante frm = new Frm_ActualizaComite_Integrante();
                frm.ShowMe(Convert.ToInt32(oRow.Cells[0].Value),
                           Convert.ToInt32(oRow.Cells[6].Value),
                            grd_mvto_DocumntoComite
                          );
                oRow.Cells[6].Value = frm.intIntegrantes;
            }
        }

        private void Frm_ActualizaComite_Load(object sender, EventArgs e)
        {
            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                this.cbo_PerProceso.CargaDT(sdl.Combo_Comite_Resolucion_AñoProceso().Tables[0]);
            }
            
            string strAñoProceso = "";
            if (String.IsNullOrEmpty( Convert.ToString( this.cbo_PerProceso.SelectedValue)) )
            {
                strAñoProceso = MyStuff.AñoProceso;
            }
            else
            {
                strAñoProceso = Convert.ToString(this.cbo_PerProceso.SelectedValue);
            }
            if (MyStuff.UsaWCF == true)
            {
                this.cbo_NumDocumento.CargaDT(objWCF.combo_Comite_Resolucion_NumDocumento(strAñoProceso).Tables[0]);
                this.cbo_CodTipoComite.CargaDT(objWCF.Combo_TipoComite().Tables[0]);
            }
            else
            {
                this.cbo_NumDocumento.CargaDT(sdl.combo_Comite_Resolucion_NumDocumento(strAñoProceso).Tables[0]);
                this.cbo_CodTipoComite.CargaDT(sdl.Combo_TipoComite().Tables[0]);
            }
            
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            string strAñoProceso = Convert.ToString(this.cbo_PerProceso.SelectedValue);
            int intIdDocumentoComite = Convert.ToInt32(this.cbo_NumDocumento.SelectedValue);

            if (strAñoProceso.Trim() == "0")
            {
               MessageBox.Show("Debe Elegir un Periodo de Proceso");
            }
            else if (intIdDocumentoComite == 0)
            {
               MessageBox.Show("Debe Elegir un Documento");
            }
            else
            {
                if (MyStuff.UsaWCF == true)
                {
                    MCR = objWCF.Recupera_Comite_Resolucion(intIdDocumentoComite);
                }
                else
                {
                    MCR = sdl.Recupera_Comite_Resolucion(intIdDocumentoComite);
                }
                
                if (MCR.iIdDocumentoComite != 0)
                {
                    this.grp_Catalogo.Visible = true;
                    this.dtp_FecDocumento.Value = MCR.dFecDocumento;
                    //--
                    //---- Pintar Grilla
                    //--

                    if (MyStuff.UsaWCF == true)
                    {
                        dtGrilla = objWCF.Lista_Comite(MCR.iIdDocumentoComite).Tables[0];
                    }
                    else
                    {
                        dtGrilla = sdl.Lista_Comite(MCR.iIdDocumentoComite).Tables[0];
                    }
                    

                    if (dtGrilla.Rows.Count > 0)
                    {
                        foreach (DataRow oRow in dtGrilla.Rows)
                        {
                            MC.iIdComite = Convert.ToInt32(oRow["iIdComite"]);
                            MC.iIdDocumentoComite = Convert.ToInt32(oRow["iIdDocumentoComite"]);
                            MC.cNumProcedimiento = Convert.ToString(oRow["cNumProcedimiento"]);
                            MC.tDesContratacion = Convert.ToString(oRow["tDesContratacion"]);
                            MC.cCodTipoComite = Convert.ToString(oRow["cCodTipoComite"]);
                            MC.vDesTipoComite = Convert.ToString(oRow["vDesTipoComite"]);
                            MC.cCodEstadoComite = Convert.ToString(oRow["cCodEstadoComite"]);
                            MC.iIntegrante = Convert.ToInt32(oRow["Integrante"]);

                            intIdComite = MC.iIdComite;
                            mostrarDocumento(MC);
                            break;
                        }
                    }
                    else
                    {
                        mostrarDocumento(new Model.Comite() );
                        AccionBotones(true, true, true, true, true);
                    }
                    this.grd_mvto_DocumntoComite.DataSource = dtGrilla;
                    if (blnPintarGrilla == true)
                    {
                        blnPintarGrilla = false;
                        pintarGrilla();
                    }
                    AdicionaImagenesGrilla();
                    this.txt_NumProcedimiento.Focus();
                }
                else
                {
                    this.grp_Catalogo.Visible = false;
                }

            }
        }

        private void txt_NumProcedimiento_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txt_NumProcedimiento.Text))
            {
                this.Edt_Pac.Value = "";
            }
            else
            {
                string strNumProcedimiento = Convert.ToString(this.txt_NumProcedimiento.Text);
                string strAñoProceso = Convert.ToString(this.cbo_PerProceso.SelectedValue);
                if (MyStuff.UsaWCF == true)
                {
                    MPD = objWCF.Recupera_Pac_Detalle_Codigo(strNumProcedimiento);
                }
                else
                {
                    MPD = sdl.Recupera_ProcesoLogistico_Detalle_Codigo(strNumProcedimiento);
                }
                

                if (MPD.cNumProcedimiento.TrimEnd() == "")
                {
                    this.txt_NumProcedimiento.Text = "";
                    this.Edt_Pac.Value = "";
                }
                else
                {
                    this.txt_NumProcedimiento.Text = MPD.cNumProcedimiento;
                    this.Edt_Pac.Value = MPD.tDesContratacion;
                }
            }
        }
    }
}
