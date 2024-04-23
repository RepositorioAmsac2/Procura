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
    public partial class Frm_Pac_Adjunto : Form
    {
        Model.ProcesoLogistico_Adjunto MPPA = new Model.ProcesoLogistico_Adjunto();
        Service.Data sdl = new Service.Data();
        Framework sf = new Framework();
        private string strNumProcedimiento = "";
        int intIdAdjunto = 0;
        DataTable dtGrilla = new DataTable();
        string strRuta = "";
        bool blnPintarGrilla = true;
        Infragistics.Win.UltraWinGrid.UltraGrid m_Grid;
        private SRsafnetE.WCFsafnetEClient objWCF = new SRsafnetE.WCFsafnetEClient();
        public Frm_Pac_Adjunto()
        {
            InitializeComponent();
        }

        public void ShowMe(string cNumProcedimiento)
         {

            strNumProcedimiento = cNumProcedimiento;
            if (MyStuff.UsaWCF == true)
            {
                dtGrilla = objWCF.Lista_Pac_Adjunto(strNumProcedimiento).Tables[0];
            }
            else
            {
                dtGrilla = sdl.Lista_ProcesoLogistico_Adjunto(strNumProcedimiento).Tables[0];
            }
            
            
            this.Grd_Adjunto.DataSource = dtGrilla;

            if (dtGrilla.Rows.Count > 0)
            {
                foreach (DataRow oRow in dtGrilla.Rows)
                {
                    MPPA.IidAdjunto = Convert.ToInt32(oRow["iIdAdjunto"]);
                    MPPA.CnumProcedimiento = Convert.ToString(oRow["CnumProcedimiento"]);
                    MPPA.VarchivoOriginal = Convert.ToString(oRow["vArchivoOriginal"]);
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

        private void MostrarDocumento(Model.ProcesoLogistico_Adjunto obj)
        {
            this.edt_ArchivoOrigen.Value = Convert.ToString(obj.VarchivoOriginal);
            this.Edt_Nota.Value = Convert.ToString(obj.Tnota);
            SemaforoArchivoDestino(obj.VarchivoOriginal);
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
            oRow.Cells[2].Value = MPPA.VarchivoOriginal;
            oRow.Cells[3].Value = MPPA.DfechaCreacion;
            oRow.Cells[4].Value = MPPA.CcodEmpleado;
            oRow.Cells[5].Value = MPPA.CcodEstadoAdjunto;
            oRow.Cells[6].Value = MPPA.Tnota;
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
                    MPPA.VarchivoOriginal = Convert.ToString(oRow.Cells[2].Value);
                    MPPA.DfechaCreacion = Convert.ToDateTime(oRow.Cells[3].Value);
                    MPPA.CcodEmpleado = Convert.ToString(oRow.Cells[4].Value);
                    MPPA.CcodEstadoAdjunto = Convert.ToString(oRow.Cells[5].Value);
                    MPPA.Tnota = Convert.ToString(oRow.Cells[6].Value);

                    MostrarDocumento(MPPA);
                }
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            intIdAdjunto = 0;
            MostrarDocumento(new Model.ProcesoLogistico_Adjunto());
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
                    blnResultado = objWCF.Elimina_Pac_Adjunto(MPPA.IidAdjunto);
                }
                else
                {
                    blnResultado = sdl.Elimina_ProcesoLogistico_Adjunto(MPPA.IidAdjunto);
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
                        MPPA.VarchivoOriginal = Convert.ToString(oRow.Cells[2].Value);
                        MPPA.DfechaCreacion = Convert.ToDateTime(oRow.Cells[3].Value);
                        MPPA.CcodEmpleado = Convert.ToString(oRow.Cells[4].Value);
                        MPPA.CcodEstadoAdjunto = Convert.ToString(oRow.Cells[5].Value);
                        MPPA.Tnota = Convert.ToString(oRow.Cells[6].Value);

                        MostrarDocumento(MPPA);
                        AccionBotones(true, true, true, true, true, true);
                    }
                    else
                    {
                        intIdAdjunto = 0;
                        MostrarDocumento(new Model.ProcesoLogistico_Adjunto());
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

            oBand0.Columns[2].Header.Caption = "Nombre del Archivo";
            oBand0.Columns[2].Width = 425;
            oBand0.Columns[3].Header.Caption = "Creado";
            oBand0.Columns[3].Width = 100;

            oBand0.Columns[0].Hidden = true;
            oBand0.Columns[1].Hidden = true;
            oBand0.Columns[4].Hidden = true;
            oBand0.Columns[5].Hidden = true;
            oBand0.Columns[6].Hidden = true;
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
                MPPA.VarchivoOriginal = Convert.ToString(this.edt_ArchivoOrigen.Value);
                MPPA.CcodEmpleado = MyStuff.CodigoEmpleado;
                MPPA.Tnota = Convert.ToString(this.Edt_Nota.Value);
                if (MyStuff.UsaWCF == true)
                {
                }
                else
                {
                    intIdAdjunto = sdl.Graba_ProcesoLogistico_Adjunto(MPPA);
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
                this.AdjuntarArchivo(MPPA);
                this.SemaforoArchivoDestino(MPPA.VarchivoOriginal);
                AccionBotones(true, true, true, true, true, true);
            }
        }

        private void Archivos()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                //InitialDirectory = @"D:\",
                Title = "Elegir Adjunto",

                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "pdf",
                Filter = "Todos los archivos (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true

            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.edt_ArchivoOrigen.Text = @openFileDialog1.FileName;
            }
        }


        private string NombreArchivo(string strArchivoDestino)
        {
            string strNombreArchivo = strArchivoDestino;
            string strExtension = strNombreArchivo;

            while (strExtension.IndexOf(".") != -1)
            {
                strExtension = strExtension.Substring(strExtension.IndexOf(".") + 1);
            }
            string strBusquedaExtension = "." + strExtension.TrimEnd();
            strNombreArchivo = strNombreArchivo.Replace(strBusquedaExtension, "");
            string strVersionAmterior = "_" + traeVersion(strNombreArchivo, true);
            string strVersion = traeVersion(strNombreArchivo, false);
            int intLongitudArchivo = strNombreArchivo.Length - 1;
            strNombreArchivo = strNombreArchivo.Replace(strVersionAmterior, "");
            strArchivoDestino = strNombreArchivo +
                                "_" +
                                strVersion.TrimEnd() +
                                "." +
                                strExtension;
            return strArchivoDestino;
        }

        private string traeVersion(string strArchivo,
                            Boolean blnVersionAnterior
                           )
        {
            strArchivo = strArchivo.TrimEnd();
            int intLongitud = strArchivo.Length - 1;
            int intLongitudReal = intLongitud;
            string strVersion = "";

            while (intLongitud > 0)
            {
                if (strArchivo.Substring(intLongitud, 1) == "v")
                {
                    break;
                }
                intLongitud--;
            }
            strVersion = strArchivo.Substring(intLongitud + 1, (intLongitudReal - intLongitud));
            if (blnVersionAnterior == true)
            {
                strVersion = "v" + strVersion;
            }
            else
            {
                strVersion = "v" +
                         Convert.ToString(Convert.ToInt32(strVersion) + 1);
            }



            return strVersion;
        }

        private void AdjuntarArchivo(Model.ProcesoLogistico_Adjunto obj)
        {
            string strArchivoCarga = obj.CnumProcedimiento.TrimEnd() + "_" +
                                     this.NombreArchivo(Convert.ToString(this.edt_ArchivoOrigen.Value)
                                                       );

            ftp ftpClient = new ftp("ftp://ftpsafnet.amsac.pe/", @"activosmineros\admin.app1", "Amsac..2023");
            ftpClient.upload(strArchivoCarga,
                             Convert.ToString(this.edt_ArchivoOrigen.Value)
                            );
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
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = Grd_Adjunto.ActiveRow;
            sf.DownLoadArchivo(Convert.ToString(oRow.Cells[2].Value));
        }

        private void btn_ArchivoOrigen_Click(object sender, EventArgs e)
        {
            this.Archivos();
        }

        private void Frm_Pac_Adjunto_Load(object sender, EventArgs e)
        {

        }
    }
}
