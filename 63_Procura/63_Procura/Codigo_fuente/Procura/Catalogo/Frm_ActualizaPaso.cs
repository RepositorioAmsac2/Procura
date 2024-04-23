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
    public partial class Frm_ActualizaPaso : Form
    {
        Service.Data sdl = new Service.Data();
        Model.TipoPaso MTP = new Model.TipoPaso();

        Model.Paso MP = new Model.Paso();
        DataTable dtGrilla = new DataTable();
        private bool blnPintarGrilla = true;
        private int intIdPaso = 0;
        private DataTable DT_TipoPlantillaPaso = new DataTable();
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public Frm_ActualizaPaso()
        {
            InitializeComponent();
        }

        private void Frm_ActualizaPaso_Load(object sender, EventArgs e)
        {
            if (MyStuff.UsaWCF == true)
            {

            }
            else
            {
                DT_TipoPlantillaPaso = sdl.Combo_TipoPlantilla().Tables[0];
            }
            this.cbo_CodTipoPlantilla.CargaDT(DT_TipoPlantillaPaso);
        }

        private void mostrarDocumento( Model.Paso obj)
        {
            this.txt_CodPaso.Text = Convert.ToString(obj.cCodPaso);
            this.txt_DesPaso.Value = Convert.ToString(obj.vDesPaso);
            this.cbo_CodTipoPaso.SelectedValue = Convert.ToString(obj.cCodTipoPaso);
            this.txt_Formulario.Value = Convert.ToString(obj.vFormulario);
            if ( string.IsNullOrEmpty(  Convert.ToString( obj.cCodPaso ).TrimEnd() ) == false)
            {
                AccionBotones(true, true, true, true, false);
            }
            else
            {
                AccionBotones(false, true, true, false, false);
            }
            //this.cbo_CodTipoPlantilla.SelectedValue = Convert.ToString(obj.cCodTipoPlantilla);
        }

        private void PintarDatosRegistro()
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = grd_mvto_DocumntoComite.ActiveRow;
            oRow.Cells[0].Value = MP.iIdPaso;
            oRow.Cells[1].Value = MP.cCodPaso;
            oRow.Cells[2].Value = MP.vDesPaso;
            oRow.Cells[3].Value = MP.cCodTipoPaso;
            oRow.Cells[4].Value = MP.vDesTipoPaso;
            oRow.Cells[5].Value = MP.vFormulario;
            oRow.Cells[6].Value = MP.cCodTipoPlantilla;
        }
        private void RegistroMovConceptos()
        {
            grd_mvto_DocumntoComite.DisplayLayout.Bands[0].AddNew();
            PintarDatosRegistro();
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
            this.btn_Listar.Enabled = blnListar;
        }


        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            intIdPaso = 0;
            mostrarDocumento(new Model.Paso() );
            AccionBotones(false, true, true, false, false);
            this.txt_CodPaso.Focus();
        }

        private void btn_DesHacer_Click(object sender, EventArgs e)
        {
            mostrarDocumento(MP);
            if (MP.cCodTipoPaso.Trim() == "")
            {
                intIdPaso = 0;
                AccionBotones(false, true, true, false, false);
            }
            else
            {
                intIdPaso = MP.iIdPaso;
                AccionBotones(true, true, true, true, true);
            }
            this.txt_CodPaso.Focus();
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
                    blnResultado = objWCF.Elimina_Paso(MP.iIdPaso);
                }
                else
                {
                    blnResultado = sdl.Elimina_Paso(MP.iIdPaso);
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
                        intIdPaso = MP.iIdPaso;
                        MP.iIdPaso = Convert.ToInt32(oRow.Cells[0].Text);
                        MP.cCodPaso = Convert.ToString(oRow.Cells[1].Text);
                        MP.vDesPaso = Convert.ToString(oRow.Cells[2].Text);
                        MP.cCodTipoPaso = Convert.ToString(oRow.Cells[3].Text);
                        MP.vDesTipoPaso = Convert.ToString(oRow.Cells[4].Text);
                        MP.vFormulario = Convert.ToString(oRow.Cells[5].Text);
                        MP.cCodTipoPlantilla = Convert.ToString(oRow.Cells[6].Text);
                        mostrarDocumento(MP);
                        AccionBotones(true, true, true, true, true);
                    }
                    else
                    {
                        intIdPaso = 0;
                        mostrarDocumento(new Model.Paso());
                        AccionBotones(false, true, true, false, false);
                        this.txt_CodPaso.Focus();
                    }

                }
            }
        }

        private void pintarGrilla()
        {
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.grd_mvto_DocumntoComite.DisplayLayout.Bands[0];

            oBand0.Columns[1].Header.Caption = "Paso";
            oBand0.Columns[1].Width = 80;
            oBand0.Columns[2].Header.Caption = "Descripción";
            oBand0.Columns[2].Width = 550;
            oBand0.Columns[4].Header.Caption = "Tipo Paso";
            oBand0.Columns[4].Width = 140;
            oBand0.Columns[5].Header.Caption = "Formulario";
            oBand0.Columns[5].Width = 140;
            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[3].Hidden = true;
            oBand0.Columns[6].Hidden = true;
        }


        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";
            try
            {

                if ( string.IsNullOrEmpty( Convert.ToString(  this.txt_CodPaso.Value )))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Código del Paso";
                }

                if (string.IsNullOrEmpty(Convert.ToString(this.txt_DesPaso.Value )))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar la Descripción del Paso";
                }

                if (string.IsNullOrEmpty(Convert.ToString(this.cbo_CodTipoPaso.SelectedValue )))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Tipo del Paso";
                }

                if (string.IsNullOrEmpty(Convert.ToString(this.cbo_CodTipoPlantilla.SelectedValue)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Tipo del Plantilla";
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
                    MP.iIdPaso = 0;
                }
                MP.cCodPaso = Convert.ToString(this.txt_CodPaso.Value);
                MP.vDesPaso = Convert.ToString( this.txt_DesPaso.Value );
                MP.cCodTipoPaso = Convert.ToString(this.cbo_CodTipoPaso.SelectedValue);
                MP.vDesTipoPaso = Convert.ToString(this.cbo_CodTipoPaso.Text);
                MP.vFormulario = Convert.ToString(this.txt_Formulario.Value);
                MP.cCodTipoPlantilla = Convert.ToString(this.cbo_CodTipoPlantilla.SelectedValue);
                if (intIdPaso == 0)
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        intIdPaso = objWCF.Graba_Paso(MP);
                    }
                    else
                    {
                        intIdPaso = sdl.Graba_Paso(MP);
                    }
                    
                    MP.iIdPaso = intIdPaso;
                    RegistroMovConceptos();
                }
                else
                {
                    if (MyStuff.UsaWCF == true)
                    {
                        intIdPaso = objWCF.Modifica_Paso(MP);
                    }
                    else
                    {
                        intIdPaso = sdl.Modifica_Paso(MP);
                    }
                    
                    PintarDatosRegistro();
                }
                if (intIdPaso == 0)
                {
                    MessageBox.Show("Error: No se grabaron los datos");
                }
                else
                {
                    intIdPaso = MP.iIdPaso;
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

        private void cbo_CodTipoPlantilla_Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strCodTipoPlantillaPaso = "X";

            if (string.IsNullOrEmpty(Convert.ToString(this.cbo_CodTipoPlantilla.SelectedValue)) == false)
            {
                strCodTipoPlantillaPaso = Convert.ToString(this.cbo_CodTipoPlantilla.SelectedValue);
            }
            

            if (MyStuff.UsaWCF == true)
            {
                this.cbo_CodTipoPaso.CargaDT(objWCF.Combo_TipoPaso().Tables[0]);
                dtGrilla = objWCF.Lista_Paso(strCodTipoPlantillaPaso).Tables[0];
            }
            else
            {
                this.cbo_CodTipoPaso.CargaDT(sdl.Combo_TipoPaso().Tables[0]);
                dtGrilla = sdl.Lista_Paso(strCodTipoPlantillaPaso).Tables[0];
            }

            if (dtGrilla.Rows.Count > 0)
            {
                foreach (DataRow oRow in dtGrilla.Rows)
                {
                    MP.iIdPaso = Convert.ToInt32(oRow["iIdPaso"]);
                    MP.cCodPaso = Convert.ToString(oRow["cCodPaso"]);
                    MP.vDesPaso = Convert.ToString(oRow["vDesPaso"]);
                    MP.cCodTipoPaso = Convert.ToString(oRow["cCodTipoPaso"]);
                    MP.vDesTipoPaso = Convert.ToString(oRow["vDesTipoPaso"]);
                    MP.vFormulario = Convert.ToString(oRow["vFormulario"]);
                    MP.cCodTipoPlantilla = Convert.ToString(oRow["cCodTipoPlantilla"]);
                    intIdPaso = MP.iIdPaso;
                    mostrarDocumento(MP);
                    break;
                }
            }
            else
            {
                AccionBotones(true, true, true, true, true);
                this.txt_CodPaso.Focus();
            }
            this.grd_mvto_DocumntoComite.DataSource = dtGrilla;
            if (blnPintarGrilla == true)
            {
                blnPintarGrilla = false;
                pintarGrilla();
            }
            
        }

        private void grd_mvto_DocumntoComite_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            //e.Layout.Override.FilterUIType = FilterUIType.FilterRow;

            FilterOperatorDropDownItems val = FilterOperatorDropDownItems.Contains;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.FilterOperatorDropDownItems = val;

            FilterOperatorDefaultValue val1 = FilterOperatorDefaultValue.Contains;
            this.grd_mvto_DocumntoComite.DisplayLayout.Override.FilterOperatorDefaultValue = val1;

            this.grd_mvto_DocumntoComite.DisplayLayout.ScrollStyle = ScrollStyle.Immediate;
            this.grd_mvto_DocumntoComite.DisplayLayout.Scrollbars = Scrollbars.Both;
            this.grd_mvto_DocumntoComite.DisplayLayout.ColumnScrollbarSmallChange = 100;
            this.grd_mvto_DocumntoComite.DisplayLayout.UseScrollWindow = UseScrollWindow.None;
            //Grd_Buscados.DisplayLayout.UseFixedHeaders = true;
        }

        private void grd_mvto_DocumntoComite_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            if (dtGrilla.Rows.Count > 0)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.grd_mvto_DocumntoComite.ActiveRow;
                if ((oRow.Cells[0].Text).Trim() != "")
                {
                    MP.iIdPaso = Convert.ToInt32(oRow.Cells[0].Text);
                    MP.cCodPaso = Convert.ToString(oRow.Cells[1].Text);
                    MP.vDesPaso = Convert.ToString(oRow.Cells[2].Text);
                    MP.cCodTipoPaso = Convert.ToString(oRow.Cells[3].Text);
                    MP.vDesTipoPaso = Convert.ToString(oRow.Cells[4].Text);
                    MP.vFormulario = Convert.ToString(oRow.Cells[5].Text);
                    MP.cCodTipoPlantilla = Convert.ToString(oRow.Cells[6].Text);
                    intIdPaso = MP.iIdPaso;
                    mostrarDocumento(MP);
                }
            }

        }

        private void Btn_PlantillaPaso_Click(object sender, EventArgs e)
        {
            WINlogistica.Frm_TipoPlantillaPaso frm = new WINlogistica.Frm_TipoPlantillaPaso();
            frm.ShowDialog();
            if (frm.blnActualizo == true)
            {
                string strCodTipoPlantilla = Convert.ToString( this.cbo_CodTipoPlantilla.SelectedValue );

                DT_TipoPlantillaPaso = sdl.Combo_TipoPlantilla().Tables[0];
                this.cbo_CodTipoPlantilla.CargaDT(DT_TipoPlantillaPaso);
                this.cbo_CodTipoPlantilla.SelectedValue = strCodTipoPlantilla;

            }
        }
    }
}
