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
    public partial class Frm_ActualizaComite_Integrante_Reemplazo : Form
    {
        Model.ProcesoLogistico_Cabecera MPC = new Model.ProcesoLogistico_Cabecera();
        Service.Data sdl = new Service.Data();

        Model.Empleado ME = new Model.Empleado();

        Model.Comite_Integrante MCI = new Model.Comite_Integrante();

        Model.Comite_Integrante_Reemplazo MCIR = new Model.Comite_Integrante_Reemplazo();
        private DataTable dt_IntegranteComite = new DataTable();
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();

        public Frm_ActualizaComite_Integrante_Reemplazo()
        {
            InitializeComponent();
        }

        private void Frm_ActualizaComite_Integrante_Reemplazo_Load(object sender, EventArgs e)
        {
            if (MyStuff.UsaWCF == true)
            {
                MPC = objWCF.Recupera_Pac_Cabecera_Id();
            }
            else
            {
                MPC = sdl.Recupera_ProcesoLogistico_Cabecera_Id();
            }
            

            this.txt_AñoProceso.Value = MPC.cAñoProceso;

            if (MyStuff.UsaWCF == true)
            {
                this.txt_CodIntegrante.nombreDS = objWCF.Ayuda_Comite_Integrante(MPC.cAñoProceso);
                this.txt_CodReemplazo.nombreDS = objWCF.Ayuda_Empleado();
                this.cbo_EstadoComiteIntegrante.CargaDT(objWCF.Combo_EstadoComiteIntegrante(1).Tables[0]);
                this.cbo_CodEstadoReemplazoComite.CargaDT(objWCF.Combo_EstadoComite_Integrante_Reemplazo().Tables[0]);
            }
            else
            {
                this.txt_CodIntegrante.nombreDS = sdl.Ayuda_Comite_Integrante(MPC.cAñoProceso);
                this.txt_CodReemplazo.nombreDS = sdl.Ayuda_Empleado();
                this.cbo_EstadoComiteIntegrante.CargaDT(sdl.Combo_EstadoComiteIntegrante(1).Tables[0]);
                this.cbo_CodEstadoReemplazoComite.CargaDT(sdl.Combo_EstadoComite_Integrante_Reemplazo().Tables[0]);
            }

        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty( Convert.ToString( this.txt_ApeIntegrante.Value ) ) )
            {
                MessageBox.Show("Debe Ingresar el Código del Integrante" + (char)(13) + "que desea reemplazar");
                this.Grp_Catalogo.Visible = false;
                this.Grp_Reemplazo.Visible = false;
                this.btn_Grabar.Visible = false;
            }
            else
            {
                string strAñoProceso = Convert.ToString(this.txt_AñoProceso.Value);
                string strCodIntegrante = Convert.ToString(this.txt_CodIntegrante.Value);
                if (MyStuff.UsaWCF == true)
                {
                    dt_IntegranteComite = objWCF.Lista_Comite_Integrante_Pac(strAñoProceso, strCodIntegrante).Tables[0];
                }
                else
                {
                    dt_IntegranteComite = sdl.Lista_Comite_Integrante_Pac(strAñoProceso, strCodIntegrante).Tables[0];
                }

                this.grd_mvto_ListaComite.DataSource = dt_IntegranteComite;
                FormatoGrid();
                this.Grp_Catalogo.Visible = true;
                this.Grp_Reemplazo.Visible = true;
                this.btn_Grabar.Visible = true;
            }
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

            this.grd_mvto_ListaComite.DisplayLayout.ScrollStyle = ScrollStyle.Immediate;
            this.grd_mvto_ListaComite.DisplayLayout.Scrollbars = Scrollbars.Both;
            this.grd_mvto_ListaComite.DisplayLayout.ColumnScrollbarSmallChange = 100;
            this.grd_mvto_ListaComite.DisplayLayout.UseScrollWindow = UseScrollWindow.None;

            this.grd_mvto_ListaComite.DisplayLayout.UseFixedHeaders = true;

            this.grd_mvto_ListaComite.DisplayLayout.ScrollBarLook.MinMaxButtonsVisible = true;

            this.grd_mvto_ListaComite.DisplayLayout.ScrollBarLook.ScrollBarArrowStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarArrowStyle.BothAtRightBottom;
            this.grd_mvto_ListaComite.DisplayLayout.ScrollBarLook.Appearance.BackGradientStyle = GradientStyle.Vertical;
        }

        private void FormatoGrid()
        {
            //Me.grd_mvto_ListaComite.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False
            //Me.grd_mvto_ListaComite.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.grd_mvto_ListaComite.DisplayLayout.Bands[0];

            oBand0.Columns[1].Header.Fixed = true;
            oBand0.Columns[2].Header.Caption = "...";
            oBand0.Columns[2].Width = 30;
            oBand0.Columns[2].Header.ToolTipText = "Debe Marcar o Desmarcar el Item del PAC que su control sera reemplazado por otro Integrante!!!";
            oBand0.Columns[3].Header.Caption = "Tipo";
            oBand0.Columns[3].Width = 100;
            oBand0.Columns[4].Header.Caption = "Cargo Integrante";
            oBand0.Columns[4].Width = 100;
            oBand0.Columns[5].Header.Caption = "PAC";
            oBand0.Columns[5].Width = 100;
            oBand0.Columns[6].Header.Caption = "Descripción del PAC";
            oBand0.Columns[6].Width = 430;
            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[1].Hidden = true;
        }

        private void grd_mvto_ListaComite_CellChange(object sender, CellEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.grd_mvto_ListaComite.ActiveRow;
            if (e.Cell.Column.Index == 2)
            {
                if (Convert.ToBoolean(oRow.Cells[2].Value) == false)
                {
                    oRow.Cells[2].Value = true;
                }
                else
                {
                    oRow.Cells[2].Value = false;
                }
            }
        }

        private void verIntegrante()
        {
            if (this.txt_CodIntegrante.Value == null)
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
                    ME = sdl.Recupera_Empleado_Codigo(Convert.ToString(this.txt_CodIntegrante.Value).Trim());
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

        private void txt_CodReemplazo_Leave(object sender, EventArgs e)
        {
            verReemplazo();
        }

        private void verReemplazo()
        {
            if (this.txt_CodReemplazo.Value == null)
            {
                this.txt_ApeReemplazo.Value = "";
            }
            else
            {
                if (MyStuff.UsaWCF == true)
                {
                    ME = objWCF.Recupera_Empleado_Codigo(Convert.ToString(this.txt_CodReemplazo.Value).Trim());
                }
                else
                {
                    ME = sdl.Recupera_Empleado_Codigo(Convert.ToString(this.txt_CodReemplazo.Value).Trim());
                }
                

                if (ME.VApePersonal.Trim() == "")
                {
                    this.txt_ApeReemplazo.Value = "";
                }
                else
                {
                    this.txt_ApeReemplazo.Value = ME.VApePersonal;
                }

            }

        }

        private void txt_CodIntegrante_Leave(object sender, EventArgs e)
        {
            verIntegrante();
        }

        private bool VerificaIngresoMovimiento()
        {
            bool blnVerifica = true;
            string strMensaje = "";

            try
            {
                if (String.IsNullOrEmpty( Convert.ToString( this.txt_ApeIntegrante.Value)))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar El Código del Integrante";
                }

                if (String.IsNullOrEmpty(Convert.ToString(this.txt_ApeReemplazo.Value)))
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

            //UltraGridRow row;
            foreach (UltraGridRow row in this.grd_mvto_ListaComite.Rows)
            {
                if (Convert.ToBoolean(row.Cells[2].Value) == true)
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
                MCIR.iIdComite_Integrante = 0;
                MCIR.cCodEstadoReemplazoComite = Convert.ToString(this.cbo_EstadoComiteIntegrante.SelectedValue);
                MCIR.cCodEstadoComiteIntegrante = Convert.ToString(this.cbo_CodEstadoReemplazoComite.SelectedValue);
                MCIR.cCodReemplazo = Convert.ToString(this.txt_CodReemplazo.Value);
                MCIR.dFecInicio = Convert.ToDateTime(this.dtp_FecInicio.Value);
                MCIR.dFecFinal = Convert.ToDateTime(this.dtp_FecFinal.Value);

                //UltraGridRow row;
                int intIdComite_Reemplazo = 0;

                foreach (UltraGridRow  row in this.grd_mvto_ListaComite.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[2].Value) == true)
                    {
                        //'--- Grabar
                        MCIR.iIdComite_Integrante = Convert.ToInt32(row.Cells[1].Value);

                        if (MyStuff.UsaWCF == true)
                        {
                            intIdComite_Reemplazo = objWCF.Graba_Comite_Integrante_Reemplazo(MCIR);
                        }
                        else
                        {
                            intIdComite_Reemplazo = sdl.Graba_Comite_Integrante_Reemplazo(MCIR);
                        }
                        

                        if ( intIdComite_Reemplazo == 0 )
                        {
                            break;
                        }
                    }
                }
                if ( intIdComite_Reemplazo == 0 )
                {
                    MessageBox.Show("Hubo un error en la Grabación de información");
                }
                else
                {
                    MessageBox.Show("Integrante: " + Convert.ToString(this.txt_ApeIntegrante.Value) + (char)(13) +
                    "Reemplazo : " + Convert.ToString(this.txt_ApeReemplazo.Value)
                       );
                    this.Close();
                }
            }
        }
    }
}
