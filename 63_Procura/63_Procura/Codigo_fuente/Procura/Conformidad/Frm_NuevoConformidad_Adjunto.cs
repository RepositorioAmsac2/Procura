using System;
using System.Data;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win;
using System.Collections.Generic;

namespace WINlogistica
{
    public partial class Frm_NuevoConformidad_Adjunto : Form
    {
        private int intIdConformidadAdjunto = 0;
        private Service.Data sdl = new Service.Data();
        private Model.ConformidadAdjunto objMOG = new Model.ConformidadAdjunto();
        public DataTable tblAdjuntos = new DataTable();
        private DataTable tblAdjuntosTMP = new DataTable();
        public bool blnEligio = false;
        private string strCodTipoArchivo="";
        private bool blnActivaComboTipoObservacion = false;

        Framework f = new Framework();
        public Frm_NuevoConformidad_Adjunto()
        {
            InitializeComponent();
        }

        public void Showme(List<Model.ConformidadAdjunto> _lista,
                            string cCodTipoArchivo,
                            bool bActivaComboTipoObservacion
                          )
        {
            blnActivaComboTipoObservacion = bActivaComboTipoObservacion;
            strCodTipoArchivo = cCodTipoArchivo;

            if (blnActivaComboTipoObservacion == true)
            {
                this.Lbl_TipoInformacion.Visible = true;
                this.Cbo_CodTipoObservacion.Visible = true;
                this.Cbo_CodTipoObservacion.CargaDT(sdl.combo_TipoObservacion_Adjunto(strCodTipoArchivo).Tables[0]);
            }

            this.CreaTablaAdjuntosTMP();
            foreach ( Model.ConformidadAdjunto obj in _lista )
            {
                this.LlenarFilasTablaAdjuntosTMP(obj.IidConformidadAdjunto,
                                               obj.CcodCompañia,
                                               obj.CnroConformidad,
                                               obj.CcodTipoArchivo,
                                               obj.TAdjunto,
                                               obj.TObservacion,
                                               obj.CcodTipoObservacion,
                                               obj.VdesTipoObservacion
                                             );
            }

            this.Text = "Adjuntar Archivo ( " +
                        strCodTipoArchivo.TrimEnd() + " )";

            this.Grd_ListaOtrosGastos.DataSource = null;
            this.Grd_ListaOtrosGastos.DataSource = tblAdjuntosTMP;
            FormatoGrid();
            if (tblAdjuntosTMP.Rows.Count == 0)
            {
                this.semaforoBotones(false, true);
            }


            if (tblAdjuntosTMP.Rows.Count > 0)
            {
                foreach ( DataRow row in tblAdjuntosTMP.Rows )
                {
                    objMOG.IidConformidadAdjunto = Convert.ToInt32( row["IidConformidadAdjunto"] );
                    objMOG.CcodCompañia = Convert.ToString( row["CcodCompañia"] );
                    objMOG.CnroConformidad = Convert.ToString(row["CnroConformidad"]);
                    objMOG.CcodTipoArchivo = Convert.ToString(row["CcodTipoArchivo"]);
                    objMOG.TAdjunto = Convert.ToString(row["TAdjunto"]);
                    objMOG.TObservacion = Convert.ToString(row["TObservacion"]);
                    objMOG.CcodTipoObservacion = Convert.ToString(row["CcodTipoObservacion"]);
                    objMOG.VdesTipoObservacion = Convert.ToString(row["VdesTipoObservacion"]);
                    this.mostrarOtrosGastos(objMOG);

                    break;
                }
            }
            else
            {
                objMOG = new Model.ConformidadAdjunto();
                mostrarOtrosGastos(objMOG);
            }

            ShowDialog();
        }


        private void LlenarFilasTablaAdjuntosTMP(int intIdConformidadAdjunto,
                                            string strCodCompañia,
                                            string strNroConformidad,
                                            string strCodTipoArchivo,
                                            string strAdjunto,
                                            string strObservacion,
                                            string strCodTipoObservacion,
                                            string strDesTipoObservacion
                                        )
        {

            DataRow OtrosGastosRow;
            OtrosGastosRow = tblAdjuntosTMP.NewRow();
            OtrosGastosRow["IidConformidadAdjunto"] = intIdConformidadAdjunto;
            OtrosGastosRow["cCodCompañia"] = strCodCompañia;
            OtrosGastosRow["cNroConformidad"] = strNroConformidad;
            OtrosGastosRow["CcodTipoArchivo"] = strCodTipoArchivo;
            OtrosGastosRow["TAdjunto"] = strAdjunto;
            OtrosGastosRow["TObservacion"] = strObservacion;
            OtrosGastosRow["CCodTipoObservacion"] = strCodTipoObservacion;
            OtrosGastosRow["VDesTipoObservacion"] = strDesTipoObservacion;


            tblAdjuntosTMP.Rows.Add(OtrosGastosRow);
        }

        private void CreaTablaAdjuntosTMP()
        {
            tblAdjuntosTMP = new DataTable("AdjuntosTMP");
            DataColumn col;

            col = new DataColumn("IidConformidadAdjunto", typeof(int));
            tblAdjuntosTMP.Columns.Add(col);

            col = new DataColumn("cCodCompañia", typeof(string));
            tblAdjuntosTMP.Columns.Add(col);

            col = new DataColumn("cNroConformidad", typeof(string));
            tblAdjuntosTMP.Columns.Add(col);

            col = new DataColumn("CcodTipoArchivo", typeof(string));
            tblAdjuntosTMP.Columns.Add(col);

            col = new DataColumn("TAdjunto", typeof(string));
            tblAdjuntosTMP.Columns.Add(col);

            col = new DataColumn("TObservacion", typeof(string));
            tblAdjuntosTMP.Columns.Add(col);

            col = new DataColumn("CCodTipoObservacion", typeof(string));
            tblAdjuntosTMP.Columns.Add(col);

            col = new DataColumn("VDesTipoObservacion", typeof(string));
            tblAdjuntosTMP.Columns.Add(col);

        }

        private void CreaTablaAdjuntos()
        {
            tblAdjuntos = new DataTable("Adjuntos");
            DataColumn col;

            col = new DataColumn("IidConformidadAdjunto", typeof(int));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("cCodCompañia", typeof(string));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("cNroConformidad", typeof(string));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("CcodTipoArchivo", typeof(string));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("TAdjunto", typeof(string));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("TObservacion", typeof(string));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("CCodTipoObservacion", typeof(string));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("VDesTipoObservacion", typeof(string));
            tblAdjuntos.Columns.Add(col);

        }


        private void LlenarFilasTablaAdjuntos(   int intIdConformidadAdjunto,
                                                    string strCodCompañia,
                                                    string strNroConformidad,
                                                    string strCodTipoArchivo,
                                                    string strAdjunto,
                                                    string strObservacion,
                                                    string strCodTipoObservacion,
                                                    string strDesTipoObservacion
                                                )
        {

            DataRow OtrosGastosRow;
            OtrosGastosRow = tblAdjuntos.NewRow();
            OtrosGastosRow["IidConformidadAdjunto"] = intIdConformidadAdjunto;
            OtrosGastosRow["cCodCompañia"] = strCodCompañia;
            OtrosGastosRow["cNroConformidad"] = strNroConformidad;
            OtrosGastosRow["CcodTipoArchivo"] = strCodTipoArchivo;
            OtrosGastosRow["TAdjunto"] = strAdjunto;
            OtrosGastosRow["TObservacion"] = strObservacion;
            OtrosGastosRow["CCodTipoObservacion"] = strCodTipoObservacion;
            OtrosGastosRow["VDesTipoObservacion"] = strDesTipoObservacion;


            tblAdjuntos.Rows.Add(OtrosGastosRow);
        }
        private void semaforoBotones(Boolean accionOne, Boolean accionTwo)
        {

            Btn_Nuevo.Enabled = accionOne;
            Btn_Grabar.Enabled = accionTwo;
            if (this.Grd_ListaOtrosGastos.Rows.Count == 0)
            {
                this.Btn_DesHacer.Enabled = accionOne;
            }
            else
            {
                this.Btn_DesHacer.Enabled = accionTwo;
            }

            this.Btn_Eliminar.Enabled = accionOne;
            //this.Btn_Listar.Enabled = accionOne;

        }
        private void mostrarOtrosGastos(Model.ConformidadAdjunto obj)
        {
            this.edt_ArchivoOrigen.Value = obj.TAdjunto;
            this.edt_Observacion.Value = obj.TObservacion;
            this.Cbo_CodTipoObservacion.SelectedValue = obj.CcodTipoObservacion;
        }


        #region "Grilla"

        private void FormatoGrid()
        {


            this.Grd_ListaOtrosGastos.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;

            this.Grd_ListaOtrosGastos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_ListaOtrosGastos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            Infragistics.Win.UltraWinGrid.UltraGridBand oBandPantalla;
            oBandPantalla = this.Grd_ListaOtrosGastos.DisplayLayout.Bands[0];

            oBandPantalla.Columns[4].Header.Caption = "Adjunto";
            oBandPantalla.Columns[4].Width = 200;
            oBandPantalla.Columns[5].Header.Caption = "Observacion";
            oBandPantalla.Columns[5].Width = 200;
            oBandPantalla.Columns[7].Header.Caption = "Tipo Obervación";
            oBandPantalla.Columns[7].Width = 200;

            oBandPantalla.Columns[0].Hidden = true;
            oBandPantalla.Columns[1].Hidden = true;
            oBandPantalla.Columns[2].Hidden = true;
            oBandPantalla.Columns[3].Hidden = true;
            oBandPantalla.Columns[6].Hidden = true;
        }
        #endregion
        private void Frm_SolicitudViatico_OtrosGastos_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
            // -- Aqui colocaremos las lineas de salida
            //
            if (this.Grd_ListaOtrosGastos.Rows.Count > 0)
            {
                this.CreaTablaAdjuntos();
                this.blnEligio = true;
                int intIdConformidadAdjunto = 0;
                string strCodCompañia = "";
                string strNroConformidad = "";
                string strAdjunto = "";
                string strObservacion = "";
                string strCodTipoObservacion = "";
                string strDesTipoObservacion = "";

                foreach (UltraGridRow row in this.Grd_ListaOtrosGastos.Rows)
                {

                    intIdConformidadAdjunto = 0;
                    strCodCompañia = "";
                    strNroConformidad = "";
                    strAdjunto = Convert.ToString(row.Cells[4].Value);
                    strObservacion = Convert.ToString(row.Cells[5].Value);
                    strCodTipoObservacion = Convert.ToString(row.Cells[6].Value);
                    strDesTipoObservacion = Convert.ToString(row.Cells[7].Value);

                    this.LlenarFilasTablaAdjuntos(intIdConformidadAdjunto,
                                                    strCodCompañia,
                                                    strNroConformidad,
                                                    strCodTipoArchivo,
                                                    strAdjunto,
                                                    strObservacion,
                                                    strCodTipoObservacion,
                                                    strDesTipoObservacion
                                                    );
                }
            }
        }

        private bool VerificaDatos()
        {
            bool blnResult = true;
            string strMensajeError = "";

            if (string.IsNullOrEmpty( Convert.ToString( this.edt_ArchivoOrigen)))
            {
                strMensajeError = "Debe ingresar el archivo adjunto";
                blnResult = false;
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.edt_Observacion.Value)))
            {
                strMensajeError = "Debe ingresar el detalle de la observación";
                blnResult = false;
            }

            if (blnActivaComboTipoObservacion== true)
            {
                if (string.IsNullOrEmpty(Convert.ToString(this.Cbo_CodTipoObservacion.SelectedValue)))
                {
                    strMensajeError = "Debe ingresar el tipo de observación";
                    blnResult = false;
                }
            }

            if (strMensajeError.TrimEnd() != "")
            {
                MessageBox.Show(strMensajeError);
            }

            return blnResult;
        }

        private bool GrabarOtrosGastos()
        {
            bool blnGrabo = false;
            if (this.VerificaDatos())
            {
                //objMOG.cCodConcepto = Convert.ToString(this.Txt_CodConcepto.Value);
                //objMOG.dMonto = Convert.ToDouble(this.Txt_Importe.Value);

                blnGrabo = true;
            
                if (this.intIdConformidadAdjunto == 0)
                {
                    this.actualizarLineaOtrosGastos(true, true);
                }
                else
                {
                    this.actualizarLineaOtrosGastos(false, true);
                }
                this.blnEligio = true;

            }
            return blnGrabo;
        }

        private void actualizarLineaOtrosGastos(Boolean adiciona, Boolean pinta)
        {
            //UltraGridRow oRow = this.grd_mvto_Temas.GetRow(Infragistics.Win.UltraWinGrid.ChildRow.Last;
            //oRow.Expanded = true;

            //   Make the first row's first child the active row
            //oRow = oRow.GetChild(Infragistics.Win.UltraWinGrid.ChildRow.First);
            //if (oRow == null)
            //    return;

            if (adiciona == true)
            {
                this.Grd_ListaOtrosGastos.DisplayLayout.Bands[0].AddNew();
            }

            if (pinta == true)
            {
                Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
                oRow = this.Grd_ListaOtrosGastos.ActiveRow;
                //this.grd_mvto_Temas.ActiveRow = oRow;
                oRow.Cells[3].Value = strCodTipoArchivo;
                oRow.Cells[4].Value = Convert.ToString(this.edt_ArchivoOrigen.Text);
                oRow.Cells[5].Value = Convert.ToString(this.edt_Observacion.Value);
                if (blnActivaComboTipoObservacion == true)
                {
                    oRow.Cells[6].Value = Convert.ToString(this.Cbo_CodTipoObservacion.SelectedValue);
                    oRow.Cells[7].Value = Convert.ToString(this.Cbo_CodTipoObservacion.Text);
                }
                else
                {
                    oRow.Cells[6].Value = "";
                    oRow.Cells[7].Value = "";
                }
                
            }
        }
        private void eliminarOtrosGastos()
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_ListaOtrosGastos.ActiveRow;
            oRow.Delete(false);
            this.blnEligio = true;
        }


        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            intIdConformidadAdjunto = 0;
            Model.ConformidadAdjunto obj = new Model.ConformidadAdjunto();

            this.mostrarOtrosGastos(obj);

            semaforoBotones(false, true);
        }

        private void Btn_Grabar_Click(object sender, EventArgs e)
        {
            {
                if (this.GrabarOtrosGastos() )
                {
                    this.AdjuntarArchivo(Convert.ToString(this.edt_ArchivoOrigen.Value),
                                      strCodTipoArchivo.TrimEnd() + "_" +
                                      f.NombreArchivo(Convert.ToString(this.edt_ArchivoOrigen.Value))
                                    );
                    this.semaforoBotones(true, true);
                }
            }
        }

        private void AdjuntarArchivo(string strArchivoOrigen,
                                     string strArchivoDestino
                                    )
        {
            string strArchivoCarga = strArchivoDestino;

            ftp ftpClient = new ftp("ftp://ftpsafnet.amsac.pe/", @"activosmineros\admin.app1", "Amsac..2023");
            ftpClient.upload(strArchivoCarga,
                             strArchivoOrigen
                            );
        }


        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Desea Eliminar el Registro",
                                                                "Advertencia", MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Exclamation
                                                               );

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                eliminarOtrosGastos();
            }
        }

        private void Btn_DesHacer_Click(object sender, EventArgs e)
        {
            intIdConformidadAdjunto = objMOG.IidConformidadAdjunto;
            this.mostrarOtrosGastos(objMOG);
            this.semaforoBotones(true, false);
        }

        private void Frm_NuevoConformidad_Otros_Load(object sender, EventArgs e)
        {

        }


        private void btn_ArchivoOrigen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                //InitialDirectory = @"D:\",
                Title = "Elegir Adjunto",

                CheckFileExists = true,
                CheckPathExists = true,


                DefaultExt = "pdf",
                Filter = "Pdf (*.pdf)|*.PDF",

                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.edt_ArchivoOrigen.Value = @openFileDialog1.FileName;
            }

        }

        private void Grd_ListaOtrosGastos_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            //e.Layout.Override.FilterUIType = FilterUIType.FilterRow;

            //FilterOperatorDropDownItems val = FilterOperatorDropDownItems.Contains;
            //Grd_ListaOtrosGastos.DisplayLayout.Override.FilterOperatorDropDownItems = val;

            FilterOperatorDefaultValue val1 = FilterOperatorDefaultValue.Contains;
            Grd_ListaOtrosGastos.DisplayLayout.Override.FilterOperatorDefaultValue = val1;

            Grd_ListaOtrosGastos.DisplayLayout.ScrollStyle = ScrollStyle.Immediate;
            Grd_ListaOtrosGastos.DisplayLayout.Scrollbars = Scrollbars.Both;
            Grd_ListaOtrosGastos.DisplayLayout.ColumnScrollbarSmallChange = 100;
            Grd_ListaOtrosGastos.DisplayLayout.UseScrollWindow = UseScrollWindow.None;
            // Turn off UseOsThemes to allow display of raw column header 
            this.Grd_ListaOtrosGastos.UseOsThemes = DefaultableBoolean.False;

        }

        private void Grd_ListaOtrosGastos_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_ListaOtrosGastos.ActiveRow;

            //intIdConformidadAdjunto = Convert.ToInt32(oRow.Cells[0].Value);
            objMOG.CcodTipoArchivo = strCodTipoArchivo;
            objMOG.TAdjunto = Convert.ToString(oRow.Cells[4].Text);
            objMOG.TObservacion = Convert.ToString(oRow.Cells[5].Value);
            objMOG.CcodTipoObservacion = Convert.ToString(oRow.Cells[6].Value);
            this.mostrarOtrosGastos(objMOG);

        }
    }
}
