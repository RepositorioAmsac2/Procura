using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win;
using System.IO;

namespace WINlogistica
{
    public partial class Frm_Pac_Paso_Adjunto : Form
    {
        Model.ProcesoLogistico_Paso_Adjunto MPPA = new Model.ProcesoLogistico_Paso_Adjunto();
        Service.Data sdl = new Service.Data();

        private string strNumProcedimiento = "";
        private int intIdPaso = 0;
        int intIdAdjunto = 0;
        DataTable dtGrilla = new DataTable();
        string strRuta = "";
        bool blnPintarGrilla = true;
        Infragistics.Win.UltraWinGrid.UltraGrid m_Grid;
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        public Frm_Pac_Paso_Adjunto()
        {
            InitializeComponent();
        }

        public void ShowMe(string cNumProcedimiento,
                            int iIdPaso,
                            Infragistics.Win.UltraWinGrid.UltraGrid Grid
                          )
         {

            this.m_Grid = Grid;

            strNumProcedimiento = cNumProcedimiento;
            intIdPaso = iIdPaso;
            if (MyStuff.UsaWCF == true)
            {
                //jesusdtGrilla = objWCF.Lista_Pac_Paso_Adjunto(strNumProcedimiento, strCodPaso).Tables[0];
            }
            else
            {
                dtGrilla = sdl.Lista_ProcesoLogistico_Paso_Adjunto(strNumProcedimiento, intIdPaso).Tables[0];
            }
            
            
            this.Grd_Adjunto.DataSource = dtGrilla;

            if (dtGrilla.Rows.Count > 0)
            {
                foreach (DataRow oRow in dtGrilla.Rows)
                {
                    MPPA.IidAdjunto = Convert.ToInt32(oRow["iIdAdjunto"]);
                    MPPA.CnumProcedimiento = Convert.ToString(oRow["CnumProcedimiento"]);
                    MPPA.IidPaso = Convert.ToInt32(oRow["IidPaso"]);
                    MPPA.VarchivoOriginal = Convert.ToString(oRow["vArchivoOriginal"]);
                    MPPA.VarchivoActual = Convert.ToString(oRow["vArchivoActual"]);
                    MPPA.Vnombre = Convert.ToString(oRow["vNombre"]);
                    MPPA.CcodEmpleado = Convert.ToString(oRow["cCodEmpleado"]);
                    MPPA.CcodEstadoAdjunto = Convert.ToString(oRow["cCodEstadoAdjunto"]);
                    MPPA.DfechaCreacion = Convert.ToDateTime(oRow["dFechaCreacion"]);
                    MPPA.Tnota = Convert.ToString(oRow["Tnota"]);

                    intIdAdjunto = MPPA.IidAdjunto;

                    MostrarDocumento(MPPA);
                    break;
                }
            }
            else
            {
                AccionBotones(true, true, true, true, true, true);
                this.edt_ArchivoOrigen.Focus();
            }
            pintarGrilla();
            this.ShowDialog();
        }

        private void MostrarDocumento(Model.ProcesoLogistico_Paso_Adjunto obj)
        {
            this.edt_ArchivoOrigen.Value = Convert.ToString(obj.VarchivoOriginal);
            this.edt_ArchivoDestino.Value = Convert.ToString(obj.VarchivoActual);
            this.txt_DescripcionArchivo.Value = Convert.ToString(obj.Vnombre);
            this.Edt_Nota.Value = Convert.ToString(obj.Tnota);
            SemaforoArchivoDestino(obj.VarchivoActual);
        }
        private void SemaforoArchivoDestino(string strDestino)
        {
            if (strDestino.Trim() != "")
            {
                this.lbl_ArchivoOrigen.Visible = true;
                this.btn_ArchivoOrigen.Visible = false;
                this.TSB_Separator.Visible = true;
                this.Btn_Visualizar.Visible = true;
            }
            else
            {
                this.lbl_ArchivoOrigen.Visible = false;
                this.btn_ArchivoOrigen.Visible = true;
                this.TSB_Separator.Visible = false;
                this.Btn_Visualizar.Visible = false;
            }
        }
        private void PintarDatosRegistro()
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = Grd_Adjunto.ActiveRow;
            oRow.Cells[0].Value = MPPA.IidAdjunto;
            oRow.Cells[1].Value = MPPA.CnumProcedimiento;
            oRow.Cells[2].Value = MPPA.IidPaso;
            oRow.Cells[3].Value = MPPA.VarchivoOriginal;
            oRow.Cells[4].Value = MPPA.VarchivoActual;
            oRow.Cells[5].Value = MPPA.Vnombre;
            oRow.Cells[6].Value = MPPA.DfechaCreacion;
            oRow.Cells[7].Value = MPPA.CcodEmpleado;
            oRow.Cells[8].Value = MPPA.CcodEstadoAdjunto;
            oRow.Cells[9].Value = MPPA.Tnota;
        }
        private void RegistroMovConceptos()
        {
            Grd_Adjunto.DisplayLayout.Bands[0].AddNew();
            PintarDatosRegistro();
        }


        private void AccionBotones(bool blnNuevo,
                                    bool blnGrabar,
                                    bool blnDesHacer,
                                    bool blnEliminar,
                                    bool blnVisualizar,
                                    bool blnListar
                                    )
        {
            this.Btn_Nuevo.Enabled = blnNuevo;
            this.Btn_Grabar.Enabled = blnGrabar;
            this.Btn_DesHacer.Enabled = blnDesHacer;
            this.Btn_Eliminar.Enabled = blnEliminar;
            this.Btn_Visualizar.Enabled = blnVisualizar;
            this.Btn_Listar.Enabled = blnListar;
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
                    this.UltraGridExcelExporter1.Export(this.Grd_Adjunto, strFile);
                }
                catch
                {
                    MessageBox.Show("Error", "Error");
                }
            }
        }

        private void Grd_Adjunto_AfterSelectChange(object sender, Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs e)
        {
            if (dtGrilla.Rows.Count > 0)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = Grd_Adjunto.ActiveRow;

                if ((oRow.Cells[0].Text).Trim() != "")
                {
                    MPPA.IidAdjunto = Convert.ToInt32(oRow.Cells[0].Value);
                    MPPA.CnumProcedimiento = Convert.ToString(oRow.Cells[1].Value);
                    MPPA.IidPaso = Convert.ToInt32(oRow.Cells[2].Value);
                    MPPA.VarchivoOriginal = Convert.ToString(oRow.Cells[3].Value);
                    MPPA.VarchivoActual = Convert.ToString(oRow.Cells[4].Value);
                    MPPA.Vnombre = Convert.ToString(oRow.Cells[5].Value);
                    MPPA.DfechaCreacion = Convert.ToDateTime(oRow.Cells[6].Value);
                    MPPA.CcodEmpleado = Convert.ToString(oRow.Cells[7].Value);
                    MPPA.CcodEstadoAdjunto = Convert.ToString(oRow.Cells[8].Value);
                    MPPA.Tnota = Convert.ToString(oRow.Cells[9].Value);

                    MostrarDocumento(MPPA);
                }
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            intIdAdjunto = 0;
            MostrarDocumento(new Model.ProcesoLogistico_Paso_Adjunto());
            AccionBotones(false, true, true, false, false, false);
            this.edt_ArchivoOrigen.Focus();
        }

        private void Btn_DesHacer_Click(object sender, EventArgs e)
        {
            MostrarDocumento(MPPA);
            if (MPPA.CcodEmpleado.Trim() == "")
            {
                intIdAdjunto = 0;
                AccionBotones(false, true, true, false, false, false);
            }
            else
            {
                intIdAdjunto = MPPA.IidAdjunto;
                AccionBotones(true, true, true, true, true, true);
            }
            this.edt_ArchivoOrigen.Focus();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult intEliminaRegistro = MessageBox.Show("Desea Eliminar el Registro",
                                                                "Advertencia", MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Exclamation
                                                               );


            if (intEliminaRegistro == DialogResult.Yes)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = Grd_Adjunto.ActiveRow;
                bool blnResultado;
                if (MyStuff.UsaWCF == true)
                {
                    blnResultado = objWCF.Elimina_Pac_Paso_Adjunto(MPPA.IidAdjunto);
                }
                else
                {
                    blnResultado = sdl.Elimina_ProcesoLogistico_Paso_Adjunto(MPPA.IidAdjunto);
                }
                

                if (blnResultado == false)
                {
                    MessageBox.Show("Error: No se pudo eliminar el registro");
                }
                else
                {
                    oRow.Delete(false);

                    if (Grd_Adjunto.Rows.Count > 0)
                    {
                        oRow = this.Grd_Adjunto.ActiveRow;
                        if (oRow == null)
                        {
                            oRow = this.Grd_Adjunto.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.First);
                        }
                        intIdAdjunto = MPPA.IidAdjunto;

                        MPPA.IidAdjunto = Convert.ToInt32(oRow.Cells[0].Value);
                        MPPA.CnumProcedimiento = Convert.ToString(oRow.Cells[1].Value);
                        MPPA.IidPaso = Convert.ToInt32(oRow.Cells[2].Value);
                        MPPA.VarchivoOriginal = Convert.ToString(oRow.Cells[3].Value);
                        MPPA.VarchivoActual = Convert.ToString(oRow.Cells[4].Value);
                        MPPA.Vnombre = Convert.ToString(oRow.Cells[5].Value);
                        MPPA.DfechaCreacion = Convert.ToDateTime(oRow.Cells[6].Value);
                        MPPA.CcodEmpleado = Convert.ToString(oRow.Cells[7].Value);
                        MPPA.CcodEstadoAdjunto = Convert.ToString(oRow.Cells[8].Value);
                        MPPA.Tnota = Convert.ToString(oRow.Cells[9].Value);

                        MostrarDocumento(MPPA);
                        AccionBotones(true, true, true, true, true, true);
                    }
                    else
                    {
                        intIdAdjunto = 0;
                        MostrarDocumento(new Model.ProcesoLogistico_Paso_Adjunto());
                        AccionBotones(false, true, true, false, false, false);
                        this.edt_ArchivoOrigen.Focus();
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
            this.Grd_Adjunto.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_Adjunto.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.Grd_Adjunto.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False; //'Infragistics.Win.DefaultableBoolean.Default

            Infragistics.Win.UltraWinGrid.UltraGridBand oBand0;
            oBand0 = this.Grd_Adjunto.DisplayLayout.Bands[0];

            oBand0.Columns[5].Header.Caption = "Nombre del Archivo";
            oBand0.Columns[5].Width = 425;
            oBand0.Columns[6].Header.Caption = "Creado";
            oBand0.Columns[6].Width = 100;

            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[1].Hidden = true;
            oBand0.Columns[2].Hidden = true;
            oBand0.Columns[3].Hidden = true;
            oBand0.Columns[4].Hidden = true;
            oBand0.Columns[7].Hidden = true;
            oBand0.Columns[8].Hidden = true;
            oBand0.Columns[9].Hidden = true;
        }

        private void Grd_Adjunto_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
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

                if ( string.IsNullOrEmpty( Convert.ToString( this.edt_ArchivoOrigen.Value )) )
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el archivo Origen";
                }

                if (string.IsNullOrEmpty(Convert.ToString( this.edt_ArchivoDestino.Value )))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Archivo Destino";
                }

                if (string.IsNullOrEmpty(Convert.ToString(this.txt_DescripcionArchivo.Value )))
                {
                    blnVerifica = false;
                    strMensaje = "Debe ingresar el Nombre del Archivo";
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

        private void Btn_Grabar_Click(object sender, EventArgs e)
        {
            if (VerificaIngresoMovimiento())
            {
                if (Btn_Nuevo.Enabled == false)
                {
                    MPPA.IidAdjunto = 0;
                }

                MPPA.CnumProcedimiento = strNumProcedimiento;
                MPPA.IidPaso = intIdPaso;
                MPPA.VarchivoOriginal = Convert.ToString(this.edt_ArchivoOrigen.Value);
                MPPA.VarchivoActual = Convert.ToString(this.edt_ArchivoDestino.Value);
                MPPA.Vnombre = Convert.ToString(this.txt_DescripcionArchivo.Value);
                MPPA.CcodEmpleado = MyStuff.CodigoEmpleado;
                MPPA.Tnota = Convert.ToString(this.Edt_Nota.Value);
                if (MyStuff.UsaWCF == true)
                {
                    intIdAdjunto = objWCF.Graba_Pac_Paso_Adjunto(MPPA);
                }
                else
                {
                    intIdAdjunto = sdl.Graba_ProcesoLogistico_Paso_Adjunto(MPPA);
                }
                

                MPPA.IidAdjunto = intIdAdjunto;
                RegistroMovConceptos();
            }

            if (intIdAdjunto == 0)
            {
                MessageBox.Show("Error: No se grabaron los datos");
            }
            else
            {
                intIdAdjunto = MPPA.IidAdjunto;
                this.GrabaImagen();
                this.SemaforoArchivoDestino(MPPA.VarchivoActual);
                AccionBotones(true, true, true, true, true, true);
            }
        }

        private void Archivos()
        {
            //string strArchivoOrigen = "";
            //var strRutaInicial = Environment.CurrentDirectory();
            //strRutaInicial = strRutaInicial.Substring(0, strRutaInicial.IndexOf(@"\"));
            //this.OpenFileDialog1.InitialDirectory = strRutaInicial;
            if (this.OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.edt_ArchivoOrigen.Text = this.OpenFileDialog1.FileName;
                this.edt_ArchivoDestino.Text = MyStuff.RutaServidor.TrimEnd() + @"\" +
                                                strRuta.Trim() + @"\" +
                                                NombreArchivo(this.OpenFileDialog1.FileName.Trim());
            }
        }
  

        private object NombreArchivo(string strArchivoDestino)
        {
            while (strArchivoDestino.IndexOf(@"\") != -1)
            {
                strArchivoDestino = strArchivoDestino.Substring(strArchivoDestino.IndexOf(@"\") + 1);
            }
            return strArchivoDestino;
        }

        private void GrabaImagen()
        {
            string strRutaActual = MyStuff.RutaServidor.TrimEnd() + @"\" + strRuta.Trim();
            if (!Directory.Exists(strRutaActual))
            {
                Directory.CreateDirectory(strRutaActual);
            }

            if (this.verificaArchivo(this.edt_ArchivoDestino.Text.Trim()))
            {
                File.Copy(this.edt_ArchivoOrigen.Text.Trim(), this.edt_ArchivoDestino.Text.Trim());
            }
        }
        private bool verificaArchivo(string strArchivo)
        {
            bool blnverifica = true;
            if (System.IO.File.Exists(strArchivo))
            {
                DialogResult oDlgRes;
                oDlgRes = MessageBox.Show("El Archivo Ya Existe, Desea Reemplazarlo?",
                                            "Advertencia", 
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                                         );

                if (oDlgRes == DialogResult.Yes)
                {
                    System.IO.File.Delete(strArchivo );
                    blnverifica = true;
                }
            }
            return blnverifica;
        }

        private void Btn_Visualizar_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process proceso = new System.Diagnostics.Process();

                proceso.StartInfo.FileName = Convert.ToString(this.edt_ArchivoDestino.Value);
                proceso.Start();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Frm_Adjunto_Load(object sender, EventArgs e)
        {

        }

        private void btn_ArchivoOrigen_Click(object sender, EventArgs e)
        {
            this.Archivos();
        }
    }
}
