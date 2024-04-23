using DevExpress.XtraGrid.Columns;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace WINlogistica
{
    public partial class FFrm_AyudaHojaGeneral : DevExpress.XtraEditors.XtraForm
    {


        public string strValorDevueltoTexto = "";
        public string strValorDevuelto = "";
        public string strValorDevueltoVarios = "";
        public string strCodClaseGasto = "";
        public string strNomClaseGasto = "";
        public string strCodClasificador = "";
        public string strNomClasificador = "";



        int intAnchoCodigo = 70;
#pragma warning disable CS0414 // El campo 'Frm_AyudaHojaTrabajo.intPosicionCampoTexto' está asignado pero su valor nunca se usa
        int intPosicionCampoTexto = 1;
#pragma warning restore CS0414 // El campo 'Frm_AyudaHojaTrabajo.intPosicionCampoTexto' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'Frm_AyudaHojaTrabajo.intPosicionValue' está asignado pero su valor nunca se usa
        int intPosicionValue = 1;
#pragma warning restore CS0414 // El campo 'Frm_AyudaHojaTrabajo.intPosicionValue' está asignado pero su valor nunca se usa
        public Boolean blnEligio = false;
        bool blnAuxiliar = false;

        public Frm_AyudaHojaGeneral()
        {
            InitializeComponent();
        }

        public void ShowMe(DataSet nombreDS,
                           string strCodClaseGasto,
                           string strCodFuenteFinanciamiento,
                           string strCodProyecto,
                           string strCodCentroGestor,
                           int intTipoAyuda,
                           string strTextoAyuda,
                           int intLinea,
                           bool bAuxiliar = false
                          )
        {
            blnAuxiliar = bAuxiliar;
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("ayuda " + strTextoAyuda + "...");

            this.Text = strTextoAyuda.TrimEnd() + " para la Linea: " + Convert.ToString(intLinea);
            intPosicionCampoTexto = 1;
            intPosicionValue = 0;
            if (intTipoAyuda == 5)
            {
                intAnchoCodigo = 100;
            }
            DataTable nombreDT = new DataTable();
            List<Datos> _lista = new List<Datos>();
            switch (intTipoAyuda)
            {
                case 1:
                    _lista =
                        (from order in nombreDS.Tables[0].AsEnumerable()
                             //where order.Field<string>("cCodProyecto").TrimEnd() == strCodProyecto.TrimEnd()
                         orderby order.Field<string>("cCodClaseGasto")
                         select new Datos
                         {
                             Codigo = order.Field<string>("cCodClaseGasto"),
                             Nombre = order.Field<string>("vNomClaseGasto")
                         }
                        ).ToList();
                    break;
                case 3:
                    _lista =
                        (from order in nombreDS.Tables[0].AsEnumerable()
                             //where order.Field<string>("cCodProyecto").TrimEnd() == strCodProyecto.TrimEnd()
                         orderby order.Field<string>("cCodPosPre")
                         select new Datos
                         {
                             Codigo = order.Field<string>("cCodPosPre"),
                             Nombre = order.Field<string>("vNomPosPre"),
                             Auxiliar = order.Field<string>("vNomClaseGasto"),
                             cCodClaseGasto = order.Field<string>("cCodClaseGasto"),
                             cCodClasificador = order.Field<string>("cCodClasificador"),
                             vNomClasificador = order.Field<string>("vNomClasificador")
                         }
                        ).ToList();
                    break;
                case 4:
                    if (strCodCentroGestor.TrimEnd() == "03")
                    {
                        _lista =
                            (from order in nombreDS.Tables[0].AsEnumerable()
                             orderby order.Field<string>("cCodFuenteFinanciamiento")
                             select new Datos
                             {
                                 Codigo = order.Field<string>("cCodFuenteFinanciamiento"),
                                 Nombre = order.Field<string>("vNomFuenteFinanciamiento")
                             }
                            ).ToList();
                    }
                    else
                    {

                        if (string.IsNullOrEmpty(strCodClaseGasto) == true)
                        {
                            if (strCodCentroGestor.TrimEnd() == "2")
                            {
                                strCodClaseGasto = "01";
                            }
                            else
                            {
                                strCodClaseGasto = "02";
                            }

                        }

                        _lista =
                        (from order in nombreDS.Tables[0].AsEnumerable()
                         where order.Field<string>("cCodProyecto").TrimEnd() == strCodProyecto.TrimEnd()
                               && order.Field<string>("cCodClaseGasto").TrimEnd() == strCodClaseGasto.TrimEnd()
                         orderby order.Field<string>("cCodFuenteFinanciamiento")
                         select new Datos
                         {
                             Codigo = order.Field<string>("cCodFuenteFinanciamiento"),
                             Nombre = order.Field<string>("vNomFuenteFinanciamiento")
                         }
                        ).ToList();
                    }


                    //nombreDT = nombreDS.Tables[0].AsEnumerable().Where(row => row.Field<String>("cCodProyecto") == strCodProyecto).CopyToDataTable();
                    break;
                case 5:
                    if (string.IsNullOrEmpty(strCodFuenteFinanciamiento) == true)
                    {
                        strCodFuenteFinanciamiento = "99";
                    }
                    _lista =
                        (from order in nombreDS.Tables[0].AsEnumerable()
                         where order.Field<string>("cCodFuenteFinanciamiento").TrimEnd() == strCodFuenteFinanciamiento.TrimEnd()
                         orderby order.Field<string>("cCodProyecto")
                         select new Datos
                         {
                             Codigo = order.Field<string>("cCodProyecto"),
                             Nombre = order.Field<string>("vNomProyecto")
                         }
                        ).ToList();
                    //_lista =
                    //    (from order in nombreDS.Tables[0].AsEnumerable()
                    //        where order.Field<string>("cCodFuenteFinanciamiento").TrimEnd() == strCodFuenteFinanciamiento.TrimEnd()
                    //              && order.Field<string>("cCodClaseGasto").TrimEnd() == strCodClaseGasto.TrimEnd()
                    //     orderby order.Field<string>("cCodProyecto")
                    //        select new Datos
                    //        {
                    //            Codigo = order.Field<string>("cCodProyecto"),
                    //            Nombre = order.Field<string>("vNomProyecto")
                    //        }
                    //    ).ToList();
                    break;
                case 6:

                    if (string.IsNullOrEmpty(strCodProyecto) == true)
                    {
                        strCodProyecto = "99999999999";
                    }
                    _lista =
                        (from order in nombreDS.Tables[0].AsEnumerable()
                         where order.Field<string>("cCodProyecto").TrimEnd() == strCodProyecto.TrimEnd()
                         orderby order.Field<string>("cCodComponente")
                         select new Datos
                         {
                             Codigo = order.Field<string>("cCodComponente"),
                             Nombre = order.Field<string>("vNomComponente")
                         }
                        ).ToList();
                    break;
                case 7:
                    _lista =
                        (from order in nombreDS.Tables[0].AsEnumerable()
                         orderby order.Field<string>("CentroGestor")
                         select new Datos
                         {
                             Codigo = order.Field<string>("CentroGestor"),
                             Nombre = order.Field<string>("Nombre")
                         }
                        ).ToList();
                    break;
                case 8:
                    if (strCodCentroGestor.TrimEnd() == "03")
                    {
                        _lista =
                        (from order in nombreDS.Tables[0].AsEnumerable()
                         orderby order.Field<string>("cCodCeCo")
                         select new Datos
                         {
                             Codigo = order.Field<string>("cCodCeCo"),
                             Nombre = order.Field<string>("vNomCeCo")
                         }
                        ).ToList();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(strCodCentroGestor) == true)
                        {
                            strCodCentroGestor = "99";
                        }
                        _lista =
                        (from order in nombreDS.Tables[0].AsEnumerable()
                         where order.Field<string>("cCodCege").TrimEnd() == strCodCentroGestor.TrimEnd()
                         orderby order.Field<string>("cCodCeCo")
                         select new Datos
                         {
                             Codigo = order.Field<string>("cCodCeCo"),
                             Nombre = order.Field<string>("vNomCeCo")
                         }
                        ).ToList();
                    }

                    break;
            }

            this.grd_buscados.DataSource = _lista;
            if (_lista.Count <= 0)
            {

            }

            FormatoGrid();
            this.ShowDialog();
            SplashScreenManager.CloseForm();
        }

        private void FormatoGrid()
        {
            this.Grd_Ayuda.OptionsBehavior.Editable = false;
            this.Grd_Ayuda.OptionsFind.AlwaysVisible = true;
            this.Grd_Ayuda.OptionsView.ColumnAutoWidth = false;

            // Formatear columnas de la grilla
            GridColumn colCodigo = this.Grd_Ayuda.Columns["Codigo"];
            colCodigo.Fixed = FixedStyle.Left;
            colCodigo.Width = intAnchoCodigo;
            if (blnAuxiliar)
            {
                GridColumn colNombre = this.Grd_Ayuda.Columns["Nombre"];
                colNombre.Fixed = FixedStyle.Left;
                colNombre.Width = 400;
                GridColumn colAuxiliar = this.Grd_Ayuda.Columns["Auxiliar"];
                colAuxiliar.Fixed = FixedStyle.Left;
                colAuxiliar.Width = 100;
            }
            else
            {
                GridColumn colNombre = this.Grd_Ayuda.Columns["Nombre"];
                colNombre.Fixed = FixedStyle.Left;
                colNombre.Width = 500;
            }

        }

        private void grd_buscados_DoubleClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(this.Grd_Ayuda.GetFocusedRowCellValue("Codigo"))) == false)
            {
                blnEligio = true;
                strValorDevuelto = this.Grd_Ayuda.GetFocusedRowCellValue("Codigo").ToString().TrimEnd();
                strValorDevueltoTexto = this.Grd_Ayuda.GetFocusedRowCellValue("Nombre").ToString().TrimEnd();
                if (blnAuxiliar)
                {
                    strCodClaseGasto = this.Grd_Ayuda.GetFocusedRowCellValue("cCodClaseGasto").ToString().TrimEnd();
                    strNomClaseGasto = this.Grd_Ayuda.GetFocusedRowCellValue("Auxiliar").ToString().TrimEnd();
                    strCodClasificador = this.Grd_Ayuda.GetFocusedRowCellValue("cCodClasificador").ToString().TrimEnd();
                    strNomClasificador = this.Grd_Ayuda.GetFocusedRowCellValue("vNomClasificador").ToString().TrimEnd();
                }

                this.Close();
            }
        }

        private void Grd_Ayuda_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void Frm_AyudaHojaTrabajo_Load(object sender, EventArgs e)
        {

        }
    }

    public class Datos
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Auxiliar { get; set; }
        public string cCodClaseGasto { get; set; }
        public string cCodClasificador { get; set; }
        public string vNomClasificador { get; set; }
    }

}