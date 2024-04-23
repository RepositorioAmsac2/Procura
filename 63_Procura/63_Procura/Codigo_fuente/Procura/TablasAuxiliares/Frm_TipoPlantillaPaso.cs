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
    public partial class Frm_TipoPlantillaPaso : Form
    {
        Service.Data sdl = new Service.Data();
        Model.TipoPlantillaPaso MTP = new Model.TipoPlantillaPaso();
        DataTable dtGrilla = new DataTable();
        private bool blnPintarGrilla = true;
        private int intIdTipoPlantillaPaso = 0;
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        public Boolean blnActualizo = false;

        public Frm_TipoPlantillaPaso()
        {
            InitializeComponent();
        }

        

        private void mostrarDocumento( Model.TipoPlantillaPaso obj)
        {
            this.txt_CodTipoPlantilla.Text = Convert.ToString(obj.cCodTipoPlantilla);
            this.txt_DesTipoPlantilla.Value = Convert.ToString(obj.vDesTipoPlantilla);
        }

        private void PintarDatosRegistro()
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = grd_mvto_DocumntoComite.ActiveRow;
            oRow.Cells[0].Value = MTP.iIdTipoPlantilla;
            oRow.Cells[1].Value = MTP.cCodTipoPlantilla;
            oRow.Cells[2].Value = MTP.vDesTipoPlantilla;
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
            intIdTipoPlantillaPaso = 0;
            mostrarDocumento(new Model.TipoPlantillaPaso() );
            AccionBotones(false, true, true, false, false);
            this.txt_CodTipoPlantilla.Focus();
        }

        private void btn_DesHacer_Click(object sender, EventArgs e)
        {
            mostrarDocumento(MTP);
            if (MTP.cCodTipoPlantilla.Trim() == "")
            {
                intIdTipoPlantillaPaso = 0;
                AccionBotones(false, true, true, false, false);
            }
            else
            {
                intIdTipoPlantillaPaso = MTP.iIdTipoPlantilla;
                AccionBotones(true, true, true, true, true);
            }
            this.txt_CodTipoPlantilla.Focus();
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

                bool blnResultado = false;
                if (MyStuff.UsaWCF == true)
                {
                }
                else
                {
                    blnResultado = sdl.Elimina_TipoPlantilla(MTP.iIdTipoPlantilla);
                }
                
                if (blnResultado == false)
                {
                    MessageBox.Show("Error: No se pudo eliminar el registro");
                }
                else
                {
                    blnActualizo = true;
                    oRow.Delete(false);

                    if (grd_mvto_DocumntoComite.Rows.Count > 0)
                    {
                        oRow = this.grd_mvto_DocumntoComite.ActiveRow;
                        if (oRow == null)
                        {
                            oRow = this.grd_mvto_DocumntoComite.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First);
                        }
                        intIdTipoPlantillaPaso = MTP.iIdTipoPlantilla;
                        MTP.iIdTipoPlantilla = Convert.ToInt32(oRow.Cells[0].Text);
                        MTP.cCodTipoPlantilla = Convert.ToString(oRow.Cells[1].Text);
                        MTP.vDesTipoPlantilla = Convert.ToString(oRow.Cells[2].Text);
                        mostrarDocumento(MTP);
                        AccionBotones(true, true, true, true, true);
                    }
                    else
                    {
                        intIdTipoPlantillaPaso = 0;
                        mostrarDocumento(new Model.TipoPlantillaPaso());
                        AccionBotones(false, true, true, false, false);
                        this.txt_CodTipoPlantilla.Focus();
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

            oBand0.Columns[1].Header.Caption = "Tipo Plantilla";
            oBand0.Columns[1].Width = 80;
            oBand0.Columns[2].Header.Caption = "Descripción";
            oBand0.Columns[2].Width = 250;
            oBand0.Columns[0].Hidden = true;
        }


        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";
            try
            {

                if ( string.IsNullOrEmpty( Convert.ToString(  this.txt_CodTipoPlantilla.Value )))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Código del TipoPlantilla";
                }

                if (string.IsNullOrEmpty(Convert.ToString(this.txt_DesTipoPlantilla.Value )))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar la Descripción del TipoPlantilla";
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
                    MTP.iIdTipoPlantilla = 0;
                }
                MTP.cCodTipoPlantilla = Convert.ToString(this.txt_CodTipoPlantilla.Value);
                MTP.vDesTipoPlantilla = Convert.ToString( this.txt_DesTipoPlantilla.Value );
                if (intIdTipoPlantillaPaso == 0)
                {
                    if (MyStuff.UsaWCF == true)
                    {
                    }
                    else
                    {
                        intIdTipoPlantillaPaso = sdl.Graba_TipoPlantilla(MTP);
                    }
                    blnActualizo = true;
                    MTP.iIdTipoPlantilla = intIdTipoPlantillaPaso;
                    RegistroMovConceptos();
                }
                else
                {
                    if (MyStuff.UsaWCF == true)
                    {
                    }
                    else
                    {
                        intIdTipoPlantillaPaso = sdl.Modifica_TipoPlantilla(MTP);
                    }
                    blnActualizo = true;
                    PintarDatosRegistro();
                }
                if (intIdTipoPlantillaPaso == 0)
                {
                    MessageBox.Show("Error: No se grabaron los datos");
                }
                else
                {
                    intIdTipoPlantillaPaso = MTP.iIdTipoPlantilla;
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

        private void grd_mvto_DocumntoComite_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            if (dtGrilla.Rows.Count > 0)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.grd_mvto_DocumntoComite.ActiveRow;
                if ((oRow.Cells[0].Text).Trim() != "")
                {
                    MTP.iIdTipoPlantilla = Convert.ToInt32(oRow.Cells[0].Text);
                    MTP.cCodTipoPlantilla = Convert.ToString(oRow.Cells[1].Text);
                    MTP.vDesTipoPlantilla = Convert.ToString(oRow.Cells[2].Text);
                    intIdTipoPlantillaPaso = MTP.iIdTipoPlantilla;
                    mostrarDocumento(MTP);
                }
            }

        }

        private void Frm_TipoPlantillaPaso_Load(object sender, EventArgs e)
        {
            if (MyStuff.UsaWCF == true)
            {
            }
            else
            {
                dtGrilla = sdl.Lista_TipoPlantilla().Tables[0];
            }

            if (dtGrilla.Rows.Count > 0)
            {
                foreach (DataRow oRow in dtGrilla.Rows)
                {
                    MTP.iIdTipoPlantilla = Convert.ToInt32(oRow["iIdTipoPlantilla"]);
                    MTP.cCodTipoPlantilla = Convert.ToString(oRow["cCodTipoPlantilla"]);
                    MTP.vDesTipoPlantilla = Convert.ToString(oRow["vDesTipoPlantilla"]);
                    intIdTipoPlantillaPaso = MTP.iIdTipoPlantilla;
                    mostrarDocumento(MTP);
                    break;
                }
            }
            else
            {
                AccionBotones(true, true, true, true, true);
                this.txt_CodTipoPlantilla.Focus();
            }
            this.grd_mvto_DocumntoComite.DataSource = dtGrilla;
            if (blnPintarGrilla == true)
            {
                blnPintarGrilla = false;
                pintarGrilla();
            }

        }
    }
}
