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
    public partial class Frm_TipoProceso : Form
    {
        Service.Data sdl = new Service.Data();
        Model.TipoProceso MTP = new Model.TipoProceso();
        DataTable dtGrilla = new DataTable();
        private bool blnPintarGrilla = true;
        private int intIdTipoProceso = 0;
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public Frm_TipoProceso()
        {
            InitializeComponent();
        }

        

        private void mostrarDocumento( Model.TipoProceso obj)
        {
            this.txt_CodTipoProceso.Text = Convert.ToString(obj.cCodTipoProceso);
            this.txt_DesTipoProceso.Value = Convert.ToString(obj.vDesTipoProceso);
            this.txt_Sigla.Value = Convert.ToString(obj.cSigla);
            this.cbo_CodTipoPlantilla.SelectedValue = Convert.ToString(obj.cCodTipoPlantilla);
        }

        private void PintarDatosRegistro()
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = grd_mvto_DocumntoComite.ActiveRow;
            oRow.Cells[0].Value = MTP.iIdTipoProceso;
            oRow.Cells[1].Value = MTP.cCodTipoProceso;
            oRow.Cells[2].Value = MTP.vDesTipoProceso;
            oRow.Cells[3].Value = MTP.cSigla;
            oRow.Cells[4].Value = MTP.cCodTipoPlantilla;
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
            intIdTipoProceso = 0;
            mostrarDocumento(new Model.TipoProceso() );
            AccionBotones(false, true, true, false, false);
            this.txt_CodTipoProceso.Focus();
        }

        private void btn_DesHacer_Click(object sender, EventArgs e)
        {
            mostrarDocumento(MTP);
            if (MTP.cCodTipoProceso.Trim() == "")
            {
                intIdTipoProceso = 0;
                AccionBotones(false, true, true, false, false);
            }
            else
            {
                intIdTipoProceso = MTP.iIdTipoProceso;
                AccionBotones(true, true, true, true, true);
            }
            this.txt_CodTipoProceso.Focus();
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
                    blnResultado = objWCF.Elimina_TipoProceso(MTP.iIdTipoProceso);
                }
                else
                {
                    blnResultado = sdl.Elimina_TipoProceso(MTP.iIdTipoProceso);
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
                        intIdTipoProceso = MTP.iIdTipoProceso;
                        MTP.iIdTipoProceso = Convert.ToInt32(oRow.Cells[0].Text);
                        MTP.cCodTipoProceso = Convert.ToString(oRow.Cells[1].Text);
                        MTP.vDesTipoProceso = Convert.ToString(oRow.Cells[2].Text);
                        MTP.cSigla = Convert.ToString(oRow.Cells[3].Text);
                        MTP.cCodTipoPlantilla = Convert.ToString(oRow.Cells[4].Text);
                        mostrarDocumento(MTP);
                        AccionBotones(true, true, true, true, true);
                    }
                    else
                    {
                        intIdTipoProceso = 0;
                        mostrarDocumento(new Model.TipoProceso());
                        AccionBotones(false, true, true, false, false);
                        this.txt_CodTipoProceso.Focus();
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

            oBand0.Columns[1].Header.Caption = "TipoProceso";
            oBand0.Columns[1].Width = 80;
            oBand0.Columns[2].Header.Caption = "Descripción";
            oBand0.Columns[2].Width = 250;
            oBand0.Columns[3].Header.Caption = "Sigla";
            oBand0.Columns[3].Width = 50;
            oBand0.Columns[4].Header.Caption = "Plantilla";
            oBand0.Columns[4].Width = 140;
            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[4].Hidden = true;
        }


        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";
            try
            {

                if ( string.IsNullOrEmpty( Convert.ToString(  this.txt_CodTipoProceso.Value )))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Código del TipoProceso";
                }

                if (string.IsNullOrEmpty(Convert.ToString(this.txt_DesTipoProceso.Value )))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar la Descripción del TipoProceso";
                }

                if (string.IsNullOrEmpty(Convert.ToString(this.cbo_CodTipoPlantilla.SelectedValue )))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Tipo del TipoProceso";
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
                    MTP.iIdTipoProceso = 0;
                }
                MTP.cCodTipoProceso = Convert.ToString(this.txt_CodTipoProceso.Value);
                MTP.vDesTipoProceso = Convert.ToString( this.txt_DesTipoProceso.Value );
                MTP.cSigla = Convert.ToString(this.txt_Sigla.Value);
                MTP.cCodTipoPlantilla = Convert.ToString(this.cbo_CodTipoPlantilla.SelectedValue);
                if (intIdTipoProceso == 0)
                {
                    if (MyStuff.UsaWCF == true)
                    {
                    }
                    else
                    {
                        intIdTipoProceso = sdl.Graba_TipoProceso(MTP);
                    }
                    
                    MTP.iIdTipoProceso = intIdTipoProceso;
                    RegistroMovConceptos();
                }
                else
                {
                    if (MyStuff.UsaWCF == true)
                    {
                    }
                    else
                    {
                        intIdTipoProceso = sdl.Modifica_TipoProceso(MTP);
                    }
                    
                    PintarDatosRegistro();
                }
                if (intIdTipoProceso == 0)
                {
                    MessageBox.Show("Error: No se grabaron los datos");
                }
                else
                {
                    intIdTipoProceso = MTP.iIdTipoProceso;
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

        private void Frm_TipoProceso_Load(object sender, EventArgs e)
        {
            DataTable DT_TipoPlantillaTipoProceso = new DataTable();
            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                DT_TipoPlantillaTipoProceso = sdl.Combo_TipoPlantilla().Tables[0];
            }
            this.cbo_CodTipoPlantilla.CargaDT(DT_TipoPlantillaTipoProceso);

            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                dtGrilla = sdl.Lista_TipoProceso().Tables[0];
            }

            if (dtGrilla.Rows.Count > 0)
            {
                foreach (DataRow oRow in dtGrilla.Rows)
                {
                    MTP.iIdTipoProceso = Convert.ToInt32(oRow["iIdTipoProceso"]);
                    MTP.cCodTipoProceso = Convert.ToString(oRow["cCodTipoProceso"]);
                    MTP.vDesTipoProceso = Convert.ToString(oRow["vDesTipoProceso"]);
                    MTP.cCodTipoPlantilla = Convert.ToString(oRow["cCodTipoPlantilla"]);
                    intIdTipoProceso = MTP.iIdTipoProceso;
                    mostrarDocumento(MTP);
                    break;
                }
            }
            else
            {
                AccionBotones(true, true, true, true, true);
                this.txt_CodTipoProceso.Focus();
            }
            this.grd_mvto_DocumntoComite.DataSource = dtGrilla;
            if (blnPintarGrilla == true)
            {
                blnPintarGrilla = false;
                pintarGrilla();
            }

        }

        private void grd_mvto_DocumntoComite_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            if (dtGrilla.Rows.Count > 0)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.grd_mvto_DocumntoComite.ActiveRow;
                if ((oRow.Cells[0].Text).Trim() != "")
                {
                    MTP.iIdTipoProceso = Convert.ToInt32(oRow.Cells[0].Text);
                    MTP.cCodTipoProceso = Convert.ToString(oRow.Cells[1].Text);
                    MTP.vDesTipoProceso = Convert.ToString(oRow.Cells[2].Text);
                    MTP.cSigla = Convert.ToString(oRow.Cells[3].Text);
                    MTP.cCodTipoPlantilla = Convert.ToString(oRow.Cells[4].Text);
                    intIdTipoProceso = MTP.iIdTipoProceso;
                    mostrarDocumento(MTP);
                }
            }

        }

        private void Btn_TablasAuxiliares_Click(object sender, EventArgs e)
        {

        }

        private void Btn_TipoPlantilla_Click(object sender, EventArgs e)
        {
            WINlogistica.Frm_TipoPlantillaPaso frm = new WINlogistica.Frm_TipoPlantillaPaso();
            frm.ShowDialog();
            if (frm.blnActualizo == true)
            {
                string strCodTipoPlantilla = Convert.ToString(this.cbo_CodTipoPlantilla.SelectedValue);
                this.cbo_CodTipoPlantilla.CargaDT(sdl.Combo_TipoPlantilla().Tables[0]);
                this.cbo_CodTipoPlantilla.SelectedValue = strCodTipoPlantilla;
            }
        }
    }
}
