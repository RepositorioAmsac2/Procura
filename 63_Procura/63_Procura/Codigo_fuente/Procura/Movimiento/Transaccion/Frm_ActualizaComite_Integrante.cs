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
    public partial class Frm_ActualizaComite_Integrante : Form
    {
        Service.Data sdl = new Service.Data();
        Model.Comite_Integrante MCI = new Model.Comite_Integrante();
        Service.Data SE = new Service.Data();
        Model.Empleado ME = new Model.Empleado();

        private DataTable dtGrilla = new DataTable();
        private bool blnPintarGrilla = true;
        private int intIdComite_Integrante = 0;
        private int intIdComite = 0;
        private Infragistics.Win.UltraWinGrid.UltraGrid m_Grid;
        public int intIntegrantes = 0;
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public Frm_ActualizaComite_Integrante()
        {
            InitializeComponent();
        }

        public void ShowMe( int iIdComite,
                            int iIntegrantes,
                            Infragistics.Win.UltraWinGrid.UltraGrid Grid
                          )
        {

            this.m_Grid = Grid;
            intIdComite = iIdComite;
            intIntegrantes = iIntegrantes;
            if (MyStuff.UsaWCF == true)
            {
                this.cbo_CodTipoIntegrante.CargaDT(objWCF.Combo_TipoIntegrante().Tables[0]);
                this.cbo_CodCargoComite.CargaDT(objWCF.Combo_CargoComite().Tables[0]);
                this.cbo_CodCondicionComite.CargaDT(objWCF.Combo_CondicionComite().Tables[0]);
                this.txt_CodIntegrante.nombreDS = objWCF.Ayuda_Empleado();
            }
            else
            {
                this.cbo_CodTipoIntegrante.CargaDT(sdl.Combo_TipoIntegrante().Tables[0]);
                this.cbo_CodCargoComite.CargaDT(sdl.Combo_CargoComite().Tables[0]);
                this.cbo_CodCondicionComite.CargaDT(sdl.Combo_CondicionComite().Tables[0]);
                this.txt_CodIntegrante.nombreDS = SE.Ayuda_Empleado();
            }
            
            if (MyStuff.UsaWCF == true)
            {
                dtGrilla = objWCF.Lista_Comite_Integrante(intIdComite).Tables[0];
            }
            else
            {
                dtGrilla = sdl.Lista_Comite_Integrante(intIdComite).Tables[0];
            }
            
            
            if (dtGrilla.Rows.Count > 0)
            {
                foreach (DataRow oRow in dtGrilla.Rows)
                {
                    MCI.iIdComite_Integrante = Convert.ToInt32(oRow["iIdComite_Integrante"]);
                    MCI.iIdComite = intIdComite;
                    MCI.cCodTipoIntegrante = Convert.ToString(oRow["cCodTipoIntegrante"]);
                    MCI.cCodIntegrante = Convert.ToString(oRow["cCodIntegrante"]);
                    MCI.cCodCargoComite = Convert.ToString(oRow["cCodCargoComite"]);
                    MCI.cCodCondicionComite = Convert.ToString(oRow["cCodCondicionComite"]);
                    MCI.bFirmaActa = Convert.ToBoolean(oRow["bFirmaActa"]);
                    MCI.cCodEstadoComiteIntegrante = Convert.ToString(oRow["cCodEstadoComiteIntegrante"]);
                    intIdComite_Integrante = MCI.iIdComite_Integrante;
                    mostrarDocumento(MCI);
                    break;
                }
            }
            else
            {
                AccionBotones(false, true, true, false, false);
                this.txt_CodIntegrante.Focus();
            }
            this.grd_mvto_DocumntoComite.DataSource = dtGrilla;
            pintarGrilla();
            this.ShowDialog();

        }

        private void mostrarDocumento( Model.Comite_Integrante obj)
        {
            if (Convert.ToString(obj.cCodTipoIntegrante).Trim() == "")
            {
                this.cbo_CodTipoIntegrante.SelectedIndex = 0;
            }
            else
            {
                this.cbo_CodTipoIntegrante.SelectedValue = Convert.ToString(obj.cCodTipoIntegrante);
            }

            this.txt_CodIntegrante.Value = Convert.ToString(obj.cCodIntegrante);
            verIntegrante();
            this.cbo_CodCargoComite.SelectedValue = Convert.ToString(obj.cCodCargoComite);
            this.cbo_CodCondicionComite.SelectedValue = Convert.ToString(obj.cCodCondicionComite);
            this.chk_FirmaActa.Checked = Convert.ToBoolean(obj.bFirmaActa);
        }

        private void PintarDatosRegistro()
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = grd_mvto_DocumntoComite.ActiveRow;
            oRow.Cells[0].Value = MCI.iIdComite_Integrante;
            oRow.Cells[1].Value = MCI.iIdComite;
            oRow.Cells[2].Value = MCI.cCodTipoIntegrante;
            oRow.Cells[3].Value = Convert.ToString(this.cbo_CodTipoIntegrante.Text);
            oRow.Cells[4].Value = MCI.cCodIntegrante;
            oRow.Cells[5].Value = Convert.ToString(this.txt_ApeIntegrante.Value);
            oRow.Cells[6].Value = MCI.cCodCargoComite;
            oRow.Cells[7].Value = Convert.ToString(this.cbo_CodCargoComite.Text);
            oRow.Cells[8].Value = MCI.cCodCondicionComite;
            oRow.Cells[9].Value = Convert.ToString(this.cbo_CodCondicionComite.Text);
            oRow.Cells[10].Value = MCI.bFirmaActa;
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
            this.btn_Listar.Enabled = blnListar;
        }

        private void grd_mvto_DocumntoComite_AfterSelectChange(object sender, Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs e)
        {
            if (dtGrilla.Rows.Count > 0)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.grd_mvto_DocumntoComite.ActiveRow;
                if ((oRow.Cells[0].Text).Trim() != "")
                {
                    MCI.iIdComite_Integrante = Convert.ToInt32(oRow.Cells[0].Text);
                    MCI.iIdComite = Convert.ToInt32(oRow.Cells[1].Text);
                    MCI.cCodTipoIntegrante = Convert.ToString(oRow.Cells[2].Text);
                    MCI.cCodIntegrante = Convert.ToString(oRow.Cells[4].Text);
                    MCI.cCodCargoComite = Convert.ToString(oRow.Cells[6].Text);
                    MCI.cCodCondicionComite = Convert.ToString(oRow.Cells[8].Text);
                    MCI.bFirmaActa = Convert.ToBoolean(oRow.Cells[10].Text);
                    mostrarDocumento(MCI);
                }
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            intIdComite_Integrante = 0;
            mostrarDocumento(new Model.Comite_Integrante());
            AccionBotones(false, true, true, false, false);
            this.txt_CodIntegrante.Focus();
        }

        private void btn_DesHacer_Click(object sender, EventArgs e)
        {
            mostrarDocumento(MCI);
            if (MCI.cCodTipoIntegrante.Trim() == "")
            {
                intIdComite_Integrante = 0;
                AccionBotones(false, true, true, false, false);
            }
            else
            {
                intIdComite_Integrante = MCI.iIdComite_Integrante;
                AccionBotones(true, true, true, true, true);
            }
            this.txt_CodIntegrante.Focus();
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
                intIntegrantes = intIntegrantes - 1;
                if (MyStuff.UsaWCF == true)
                {
                    blnResultado = objWCF.Elimina_Comite_Integrante(MCI.iIdComite_Integrante);
                }
                else
                {
                    blnResultado = sdl.Elimina_Comite_Integrante(MCI.iIdComite_Integrante);
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
                        intIdComite_Integrante = MCI.iIdComite_Integrante;
                        MCI.iIdComite_Integrante = Convert.ToInt32(oRow.Cells[0].Text);
                        MCI.iIdComite = Convert.ToInt32(oRow.Cells[1].Text);
                        MCI.cCodTipoIntegrante = Convert.ToString(oRow.Cells[2].Text);
                        MCI.cCodIntegrante = Convert.ToString(oRow.Cells[4].Text);
                        MCI.cCodCargoComite = Convert.ToString(oRow.Cells[6].Text);
                        MCI.cCodCondicionComite = Convert.ToString(oRow.Cells[8].Text);
                        MCI.bFirmaActa = Convert.ToBoolean(oRow.Cells[10].Text);
                        mostrarDocumento(MCI);
                        AccionBotones(true, true, true, true, true);
                    }
                    else
                    {
                        intIdComite_Integrante = 0;
                        mostrarDocumento(new Model.Comite_Integrante());
                        AccionBotones(false, true, true, false, false);
                        this.txt_CodIntegrante.Focus();
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
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.grd_mvto_DocumntoComite.DisplayLayout.Bands[0];

            oBand0.Columns[5].Header.Caption = "Integrante";
            oBand0.Columns[5].Width = 250;
            oBand0.Columns[7].Header.Caption = "Cargo";
            oBand0.Columns[7].Width = 120;
            oBand0.Columns[9].Header.Caption = "Condición";
            oBand0.Columns[9].Width = 120;
            oBand0.Columns[10].Header.Caption = "Firma Acta";
            oBand0.Columns[10].Width = 80;
            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[1].Hidden = true;
            oBand0.Columns[2].Hidden = true;
            oBand0.Columns[3].Hidden = true;
            oBand0.Columns[4].Hidden = true;
            oBand0.Columns[6].Hidden = true;
            oBand0.Columns[8].Hidden = true;
            oBand0.Columns[11].Hidden = true;
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
        }

        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";
            try
            {

                if ( string.IsNullOrEmpty( Convert.ToString( this.txt_ApeIntegrante.Value ) ) )
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar un Integrante";
                }

                if (string.IsNullOrEmpty(Convert.ToString(this.cbo_CodTipoIntegrante.SelectedValue )))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Tipo de Integrante";
                }

                if (string.IsNullOrEmpty(Convert.ToString(this.cbo_CodCargoComite.SelectedValue )))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Cargo del Integrante";
                }

                if (string.IsNullOrEmpty(Convert.ToString(this.cbo_CodCondicionComite.SelectedValue )))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar la Condición del Integrante";
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
              MessageBox.Show (ex.Message.ToString());
            }
            return blnVerifica;
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            if (VerificaIngresoMovimiento())
            {
                if (btn_Nuevo.Enabled == false)
                {
                    MCI.iIdComite_Integrante = 0;
                }
                MCI.iIdComite = intIdComite;
                MCI.cCodTipoIntegrante = Convert.ToString(this.cbo_CodTipoIntegrante.SelectedValue);
                MCI.cCodIntegrante = Convert.ToString(this.txt_CodIntegrante.Value);
                MCI.cCodCargoComite = Convert.ToString(this.cbo_CodCargoComite.SelectedValue);
                MCI.cCodCondicionComite = Convert.ToString(this.cbo_CodCondicionComite.SelectedValue);
                MCI.bFirmaActa = this.chk_FirmaActa.Checked;

                if (intIdComite_Integrante == 0)
                {
                    intIntegrantes = intIntegrantes + 1;
                    if (MyStuff.UsaWCF == true)
                    {
                        intIdComite_Integrante = objWCF.Graba_Comite_Integrante(MCI);
                    }
                    else
                    {
                        intIdComite_Integrante = sdl.Graba_Comite_Integrante(MCI);
                    }
                    

                    MCI.iIdComite_Integrante = intIdComite_Integrante;
                    RegistroMovConceptos();
                }
                else
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        intIdComite_Integrante = objWCF.Modifica_Comite_Integrante(MCI);
                    }
                    else
                    {
                        intIdComite_Integrante = sdl.Modifica_Comite_Integrante(MCI);
                    }
                    

                    PintarDatosRegistro();
                }
                if (intIdComite_Integrante == 0)
                {
                    MessageBox.Show("Error: No se grabaron los datos");
                }
                else
                {
                    MessageBox.Show("OK: Los datos se actualiza´ron correctamente");
                    intIdComite_Integrante = MCI.iIdComite_Integrante;
                    AccionBotones(true, true, true, true, true);
                }

            }
        }

        private void btn_Listar_Click(object sender, EventArgs e)
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
        private void verIntegrante()
        {
            if ( string.IsNullOrEmpty( Convert.ToString( this.txt_CodIntegrante.Value ) ))
            {
                this.txt_ApeIntegrante.Value = "";
            }
            else
            {
                if (MyStuff.UsaWCF == true)
                {
                    ME = objWCF.Recupera_Empleado_Codigo(Convert.ToString(this.txt_CodIntegrante.Value).Trim());
                }
                else
                {
                    ME = SE.Recupera_Empleado_Codigo(Convert.ToString(this.txt_CodIntegrante.Value).Trim());
                }
                
                if (ME.VApePersonal.Trim() == "")
                {
                    this.txt_ApeIntegrante.Value = "";
                }
                else
                {
                    this.txt_ApeIntegrante.Value = ME.VApePersonal;
                }

            }

        }

        private void txt_CodIntegrante_Leave(object sender, EventArgs e)
        {
            this.verIntegrante();
        }

        private void Frm_ActualizaComite_Integrante_Load(object sender, EventArgs e)
        {

        }

        private void Frm_ActualizaComite_Integrante_FormClosing(object sender, FormClosingEventArgs e)
        {
            intIntegrantes = grd_mvto_DocumntoComite.Rows.Count;
        }
    }
}
