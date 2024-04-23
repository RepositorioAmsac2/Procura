using System;
using System.Data;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win;
using System.Collections.Generic;

namespace WINlogistica
{
    public partial class Frm_NuevoConformidad_Penalidad_Adjunto : Form
    {
        private int intIdConformidadAdjunto = 0;
        private Model.ConformidadAdjunto objMOG = new Model.ConformidadAdjunto();
        public DataTable tblAdjuntos = new DataTable();
        private DataTable tblAdjuntosTMP = new DataTable();
        public bool blnEligio = false;
        private string strCodTipoArchivo="";

        Framework f = new Framework();
        public Frm_NuevoConformidad_Penalidad_Adjunto()
        {
            InitializeComponent();
        }

        public void Showme(List<Model.ConformidadAdjunto> _lista,
                            string cCodTipoArchivo
                          )
        {
            this.CreaTablaAdjuntosTMP();
            foreach ( Model.ConformidadAdjunto obj in _lista )
            {
                this.LlenarFilasTablaAdjuntosTMP(obj.IidConformidadAdjunto,
                                               obj.CcodCompañia,
                                               obj.CnroConformidad,
                                               obj.CcodTipoArchivo,
                                               obj.TArchivoOrigen,
                                               obj.TArchivoDestino,
                                               obj.VnombreArchivo
                                             );
            }

            strCodTipoArchivo = cCodTipoArchivo;
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
                    objMOG.TArchivoOrigen = Convert.ToString(row["TArchivoOrigen"]);
                    objMOG.TArchivoDestino = Convert.ToString(row["TArchivoDestino"]);
                    objMOG.VnombreArchivo = Convert.ToString(row["VnombreArchivo"]);
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
                                            string strArchivoOrigen,
                                            string strArchivoDestino,
                                            string strNombreArchivo
                                        )
        {

            DataRow OtrosGastosRow;
            OtrosGastosRow = tblAdjuntosTMP.NewRow();
            OtrosGastosRow["IidConformidadAdjunto"] = intIdConformidadAdjunto;
            OtrosGastosRow["cCodCompañia"] = strCodCompañia;
            OtrosGastosRow["cNroConformidad"] = strNroConformidad;
            OtrosGastosRow["CcodTipoArchivo"] = strCodTipoArchivo;
            OtrosGastosRow["TArchivoOrigen"] = strArchivoOrigen;
            OtrosGastosRow["TArchivoDestino"] = strArchivoDestino;
            OtrosGastosRow["VnombreArchivo"] = strNombreArchivo;



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

            col = new DataColumn("TArchivoOrigen", typeof(string));
            tblAdjuntosTMP.Columns.Add(col);

            col = new DataColumn("TArchivoDestino", typeof(string));
            tblAdjuntosTMP.Columns.Add(col);

            col = new DataColumn("VnombreArchivo", typeof(string));
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

            col = new DataColumn("TArchivoOrigen", typeof(string));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("TArchivoDestino", typeof(string));
            tblAdjuntos.Columns.Add(col);

            col = new DataColumn("VnombreArchivo", typeof(string));
            tblAdjuntos.Columns.Add(col);

        }


        private void LlenarFilasTablaAdjuntos(   int intIdConformidadAdjunto,
                                                    string strCodCompañia,
                                                    string strNroConformidad,
                                                    string strCodTipoArchivo,
                                                    string strArchivoOrigen,
                                                    string strArchivoDestino,
                                                    string strNombreArchivo
                                                )
        {

            DataRow OtrosGastosRow;
            OtrosGastosRow = tblAdjuntos.NewRow();
            OtrosGastosRow["IidConformidadAdjunto"] = intIdConformidadAdjunto;
            OtrosGastosRow["cCodCompañia"] = strCodCompañia;
            OtrosGastosRow["cNroConformidad"] = strNroConformidad;
            OtrosGastosRow["CcodTipoArchivo"] = strCodTipoArchivo;
            OtrosGastosRow["TArchivoOrigen"] = strArchivoOrigen;
            OtrosGastosRow["TArchivoDestino"] = strArchivoDestino;
            OtrosGastosRow["VnombreArchivo"] = strNombreArchivo;



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
            this.edt_ArchivoOrigen.Value = obj.TArchivoOrigen;
            this.edt_ArchivoDestino.Value = obj.TArchivoDestino;
            this.txt_DescripcionArchivo.Value = obj.VnombreArchivo;
        }


        #region "Grilla"

        private void FormatoGrid()
        {


            this.Grd_ListaOtrosGastos.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;

            this.Grd_ListaOtrosGastos.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.Grd_ListaOtrosGastos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            Infragistics.Win.UltraWinGrid.UltraGridBand oBandPantalla;
            oBandPantalla = this.Grd_ListaOtrosGastos.DisplayLayout.Bands[0];

            oBandPantalla.Columns[4].Header.Caption = "Origen";
            oBandPantalla.Columns[4].Width = 200;
            oBandPantalla.Columns[5].Header.Caption = "Destino";
            oBandPantalla.Columns[5].Width = 200;
            oBandPantalla.Columns[6].Header.Caption = "Nombre";
            oBandPantalla.Columns[6].Width = 200;

            oBandPantalla.Columns[0].Hidden = true;
            oBandPantalla.Columns[1].Hidden = true;
            oBandPantalla.Columns[2].Hidden = true;
            oBandPantalla.Columns[3].Hidden = true;
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
                string strArchivoOrigen = "";
                string strArchivoDestino = "";
                string strNombreArchivo = "";

                foreach (UltraGridRow row in this.Grd_ListaOtrosGastos.Rows)
                {

                    intIdConformidadAdjunto = 0;
                    strCodCompañia = "";
                    strNroConformidad = "";
                    strArchivoOrigen = Convert.ToString(row.Cells[4].Value);
                    strArchivoDestino = Convert.ToString(row.Cells[5].Value);
                    strNombreArchivo = Convert.ToString(row.Cells[6].Value);

                    this.LlenarFilasTablaAdjuntos(intIdConformidadAdjunto,
                                                    strCodCompañia,
                                                    strNroConformidad,
                                                    strCodTipoArchivo,
                                                    strArchivoOrigen,
                                                    strArchivoDestino,
                                                    strNombreArchivo
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
                strMensajeError = "Debe ingresar el archivo origen";
                blnResult = false;
            }

            if (string.IsNullOrEmpty(Convert.ToString(this.txt_DescripcionArchivo.Value)))
            {
                strMensajeError = "Debe ingresar el nombre del archivo";
                blnResult = false;
            }

            if (strMensajeError.TrimEnd() != "")
            {
                MessageBox.Show(strMensajeError);
            }

            return blnResult;
        }

        private void GrabarOtrosGastos()
        {
            if (this.VerificaDatos())
            {
                //objMOG.cCodConcepto = Convert.ToString(this.Txt_CodConcepto.Value);
                //objMOG.dMonto = Convert.ToDouble(this.Txt_Importe.Value);



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
                oRow.Cells[5].Value = Convert.ToString(this.edt_ArchivoDestino.Value);
                oRow.Cells[6].Value = Convert.ToString(this.txt_DescripcionArchivo.Value);
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
                this.GrabarOtrosGastos();
                this.AdjuntarArchivo( Convert.ToString( this.edt_ArchivoOrigen.Value ),
                                      Convert.ToString( this.edt_ArchivoDestino.Value )
                                    );
                this.semaforoBotones(true, true);
            }
        }

        private void AdjuntarArchivo(string strArchivoOrigen,
                                     string strArchivoDestino
                                    )
        {
            string strArchivoCarga = strArchivoDestino;

            ftp ftpClient = new ftp("ftp://ftpsafnet.amsac.pe/", @"activosmineros\admin.app1", "Amsac.0202");
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
                this.edt_ArchivoDestino.Value = strCodTipoArchivo.TrimEnd() + "_" +
                                                f.NombreArchivo(@openFileDialog1.FileName);
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
            objMOG.TArchivoOrigen = Convert.ToString(oRow.Cells[4].Text);
            objMOG.TArchivoDestino = Convert.ToString(oRow.Cells[5].Value);
            objMOG.VnombreArchivo = Convert.ToString(oRow.Cells[6].Value);
            this.mostrarOtrosGastos(objMOG);

        }
    }
}
