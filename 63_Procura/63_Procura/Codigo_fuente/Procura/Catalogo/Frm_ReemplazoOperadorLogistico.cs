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

namespace WINlogistica.Catalogo
{
    public partial class Frm_ReemplazoOperadorLogistico : Form
    {
        private DataSet ds_OperadorLogistico = new DataSet();
        private WINlogistica.Framework FS = new WINlogistica.Framework();
        private DataSet DS_OperadorLogistico = new DataSet();
        private DataSet DS_OperadorLogistico_Reemplazo = new DataSet();
        private DataSet DS_Reemplazo = new DataSet();
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        Service.Data sdl = new Service.Data();
        public Frm_ReemplazoOperadorLogistico()
        {
            InitializeComponent();
        }

        private void btn_MOstrar_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty( Convert.ToString( this.txt_ApeOperadorLogistico.Value ) ) )
            {
                MessageBox.Show("Debe Ingresar el Código del Integrante" + (char)(13) + "que desea reemplazar");
                this.Grp_Catalogo.Visible = false;
                this.Grp_Reemplazo.Visible = false;
                this.btn_Grabar.Visible = false;
            }
            else
            {
                string strAñoProceso = Convert.ToString(this.txt_AñoProceso.Value);
                string strCodOperadorLogistico = Convert.ToString(this.txt_CodOperadorLogistico.Value);

                if (MyStuff.UsaWCF == true)
                {
                    ds_OperadorLogistico = objWCF.Lista_Pac_OperadorLogistico(strAñoProceso, strCodOperadorLogistico);
                    DS_OperadorLogistico_Reemplazo = objWCF.Ayuda_OperadorLogistico_Reemplazo(strCodOperadorLogistico);
                }
                else
                {
                    ds_OperadorLogistico = sdl.Lista_ProcesoLogistico_OperadorLogistico(strAñoProceso, strCodOperadorLogistico);
                    DS_OperadorLogistico_Reemplazo = sdl.Ayuda_OperadorLogistico_Reemplazo(strCodOperadorLogistico);
                }
                

                this.txt_CodReemplazo.nombreDS = DS_OperadorLogistico_Reemplazo;

                this.grd_mvto_ListaComite.DataSource = ds_OperadorLogistico;

                FormatoGrid();
                this.Grp_Catalogo.Visible = true;
                this.Grp_Reemplazo.Visible = true;
                this.btn_Grabar.Visible = true;
            }
        }

        private void FormatoGrid()
        {
            //Me.grd_mvto_ListaComite.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
            //Me.grd_mvto_ListaComite.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.grd_mvto_ListaComite.DisplayLayout.Bands[0];

            oBand0.Columns[1].Header.Caption = "...";
            oBand0.Columns[1].Width = 30;
            oBand0.Columns[1].Header.ToolTipText = "Debe Marcar o Desmarcar el Item del PAC que su control sera reemplazado por otro Integrante!!!";
            oBand0.Columns[3].Header.Caption = "Procedimiento";
            oBand0.Columns[3].Width = 100;
            oBand0.Columns[4].Header.Caption = "Descripción";
            oBand0.Columns[4].Width = 400;
            oBand0.Columns[5].Header.Caption = "Precio";
            oBand0.Columns[5].Width = 100;
            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[2].Hidden = true;
        }

        private void txt_CodOperadorLogistico_Leave(object sender, EventArgs e)
        {
            this.txt_ApeOperadorLogistico.Value = FS.TraerDescripcion_DataTable(ds_OperadorLogistico.Tables[0],
                                                                                   0,
                                                                                   1,
                                                                                   Convert.ToString(this.txt_CodOperadorLogistico.Value)
                                                                                 );
        }

        private void txt_CodReemplazo_Leave(object sender, EventArgs e)
        {
            this.txt_ApeReemplazo.Value = FS.TraerDescripcion_DataTable(DS_OperadorLogistico_Reemplazo.Tables[0],
                                                                                   0,
                                                                                   1,
                                                                                   Convert.ToString(this.txt_CodReemplazo.Value)
                                                                                 );
        }

        private void Frm_ReemplazoOperadorLogistico_Load(object sender, EventArgs e)
        {
            ds_OperadorLogistico = sdl.Ayuda_OperadorLogistico();
            this.txt_CodOperadorLogistico.nombreDS = ds_OperadorLogistico;

            this.cbo_EstadoOperadorLogistico.CargaDT(sdl.Combo_EstadoOperadorLogistico(1).Tables[0]);
            this.cbo_CodEstadoReemplazoOperadorLogistico.CargaDS(sdl.Combo_EstadoOperadorLogistico_Reemplazo());

        }

        private void grd_mvto_ListaComite_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
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

        private void grd_mvto_ListaComite_CellChange(object sender, CellEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.grd_mvto_ListaComite.ActiveRow;
            if (e.Cell.Column.Index == 1)
            {
                if (Convert.ToBoolean(oRow.Cells[1].Value) == false)
                {
                    oRow.Cells[1].Value = true;
                }
                else
                {
                    oRow.Cells[1].Value = false;
                }
            }
        }

        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";

            try
            {
                if (String.IsNullOrEmpty( Convert.ToString( this.txt_CodOperadorLogistico.Value)) )
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar El Código del Operador Logistico";
                }
                if (String.IsNullOrEmpty(Convert.ToString( this.txt_CodReemplazo.Value)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar El Código del Reemplazo";
                }

                if (this.verMarcas() == false)
                {
                    blnVerifica = false;
                    strMensaje = "Debe marcar en la Grilla un Item del PAC";
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

        private bool verMarcas()
        {
            bool blnResult = false;

            foreach (UltraGridRow  row in this.grd_mvto_ListaComite.Rows)
            {
                if (Convert.ToBoolean(row.Cells[1].Value) == true)
                {
                    blnResult = true;
                    break;
                }
            }
            return blnResult;
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            if (VerificaIngresoMovimiento())
            {
                int intIdPac_OperadorLogistico = 0;
                string strMotivoReemplazo = Convert.ToString(this.cbo_EstadoOperadorLogistico.SelectedValue);
                string strTipoReemplazo = Convert.ToString(this.cbo_CodEstadoReemplazoOperadorLogistico.SelectedValue);
                string strCodReemplazo = Convert.ToString(this.txt_CodReemplazo.Value);
                DateTime dateFecInicio = Convert.ToDateTime(this.dtp_FecInicio.Value);
                DateTime dateFecFinal = Convert.ToDateTime(this.dtp_FecFinal.Value);
                bool blnResult = false;

                foreach (UltraGridRow row in this.grd_mvto_ListaComite.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[1].Value) == true)
                    {
                        //'--- Grabar
                        intIdPac_OperadorLogistico = Convert.ToInt32(row.Cells[0].Value);
                        if (MyStuff.UsaWCF == true)
                        {
                            blnResult = objWCF.Graba_Pac_OperadorLogistico_Reemplazo(intIdPac_OperadorLogistico,
                                                                                          strTipoReemplazo,
                                                                                          strMotivoReemplazo,
                                                                                          strCodReemplazo,
                                                                                          dateFecInicio,
                                                                                          dateFecFinal
                                                                                      );
                        }
                        else
                        {
                            blnResult = sdl.Graba_ProcesoLogistico_OperadorLogistico_Reemplazo(intIdPac_OperadorLogistico,
                                                                                          strTipoReemplazo,
                                                                                          strMotivoReemplazo,
                                                                                          strCodReemplazo,
                                                                                          dateFecInicio,
                                                                                          dateFecFinal
                                                                                      );
                        }
                        
                    }
                }
                if (blnResult == false)
                {
                    MessageBox.Show("Error: Hubo un error en la Grabación de información");
                }
                else
                {
                    MessageBox.Show("Se Hizo el reemplazo correctamente" + (char)(13) +
                                     "Operador Logistico: " + Convert.ToString(this.txt_ApeOperadorLogistico.Value) + (char)(13) +
                                     "Reemplazo         : " + Convert.ToString(this.txt_ApeReemplazo.Value)
                       );
                    this.Close();
                }
            }
        }
    }
}
