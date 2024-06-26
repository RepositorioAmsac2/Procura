﻿using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infragistics.Win;
using System.IO;

namespace WINlogistica
{
    public partial class Frm_Formulacion : DevExpress.XtraEditors.XtraForm
    {
        public bool blnEligio = false;
        public string strCodTipoGasto = "";
        public string strNomTipoGasto = "";
        public string strCodFuenteFinanciamiento = "";
        public string strNomFuenteFinanciamiento = "";
        public string strCodCentroCosto = "";
		public string strNomCentroCosto = "";
        public string strCodProyecto = "";
        public string strNomProyecto = "";
        public string strCodComponente = "";
        public string strNomComponente = "";
        public string strCodClasificacion = "";
        public string strNomClasificacion = "";
        public string strCodPosPre = "";
        public string strNomPosPre = "";
        public string strCodLogistica = "";
        public string strDescripcion = "";
        public double dblImporte = 0;
        private string  strTipoMovimiento = "";

        //private WINLogistica.Framework FS = new WINLogistica.Framework();
        Service.Data sdl = new Service.Data();

        public string strCodCentroGestor = "";
        private DataSet DS_CentroGestor = new DataSet();
        private Boolean blnMuestraGrid = true;

        //private SRLogistica.WCFLogisticaEClient objWCF = new SRLogistica.WCFLogisticaEClient();
        private string strCodClasificacion_D = string.Empty;
        public Frm_Formulacion()
        {
            InitializeComponent();
        }

        public bool blnMostrarFormato = true;
        public DataTable DT_Logistica = new DataTable();
        
        public void Showme( string strCodEmpresa,
                            string strAñoProceso)
        {
            this.Grd_Buscados.DataSource = sdl.Ayuda_Formulacion_Logistica("000000",
                                                                          strAñoProceso,
                                                                          "",
                                                                          "",
                                                                          ""
                                                                         ).Tables[0];

            ShowDialog();
        }
       
 
        private void FormatoGrid()
        {
            Grd_Buscados.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            Grd_Buscados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;

            foreach (Infragistics.Win.UltraWinGrid.UltraGridBand oBand in this.Grd_Buscados.DisplayLayout.Bands)
            {
                foreach (Infragistics.Win.UltraWinGrid.UltraGridColumn oColumn in oBand.Columns)
                {
                    if (oColumn.DataType.ToString() == "System.Double")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "#,###,###,###,###.00";
                    }

                    if (oColumn.DataType.ToString() == "System.Decimal")
                    {
                        oColumn.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right;
                        oColumn.Format = "#,###,###,###,###.00";
                    }
                }
            }

            Infragistics.Win.UltraWinGrid.UltraGridBand oBandPantalla;
            oBandPantalla = Grd_Buscados.DisplayLayout.Bands[0];

            //oBandPantalla.Columns[1].Header.Caption = "Clase Gasto";
            //oBandPantalla.Columns[1].Width = 110;
            oBandPantalla.Columns[3].Header.Caption = "F.Financiamiento";
            oBandPantalla.Columns[3].Width = 145;
            oBandPantalla.Columns[5].Header.Caption = "C.Costo";
            oBandPantalla.Columns[5].Width = 150;
            oBandPantalla.Columns[7].Header.Caption = "Proyecto";
            oBandPantalla.Columns[7].Width = 150;
            oBandPantalla.Columns[9].Header.Caption = "Componente";
            oBandPantalla.Columns[9].Width = 120;
            oBandPantalla.Columns[11].Header.Caption = "Clasificador";
            oBandPantalla.Columns[11].Width = 150;
            oBandPantalla.Columns[13].Header.Caption = "Posición Presupuestal";
            oBandPantalla.Columns[13].Width = 150;
            oBandPantalla.Columns[15].Header.Caption = "Descripción";
            oBandPantalla.Columns[15].Width = 150;
            oBandPantalla.Columns[16].Header.Caption = "Disponible";
            oBandPantalla.Columns[16].Width = 100;

            oBandPantalla.Columns[0].Hidden = true;
            oBandPantalla.Columns[1].Hidden = true;
            oBandPantalla.Columns[2].Hidden = true;
            oBandPantalla.Columns[4].Hidden = true;
            oBandPantalla.Columns[6].Hidden = true;
            oBandPantalla.Columns[8].Hidden = true;
            oBandPantalla.Columns[10].Hidden = true;
            oBandPantalla.Columns[12].Hidden = true;
            oBandPantalla.Columns[14].Hidden = true;
        }

         
        private void Aceptar()
        {
            Infragistics.Win.UltraWinGrid.UltraGridRow oRow;
            oRow = this.Grd_Buscados.ActiveRow;
            strCodTipoGasto = Convert.ToString(oRow.Cells[0].Value); 
            strNomTipoGasto = Convert.ToString(oRow.Cells[1].Value); 
            strCodFuenteFinanciamiento = Convert.ToString(oRow.Cells[2].Value); 
            strNomFuenteFinanciamiento = Convert.ToString(oRow.Cells[3].Value); 
            strCodCentroCosto = Convert.ToString(oRow.Cells[4].Value); 
            strNomCentroCosto = Convert.ToString(oRow.Cells[5].Value); 
            strCodProyecto = Convert.ToString(oRow.Cells[6].Value); 
            strNomProyecto = Convert.ToString(oRow.Cells[7].Value); 
            strCodComponente = Convert.ToString(oRow.Cells[8].Value); 
            strNomComponente = Convert.ToString(oRow.Cells[9].Value); 
            strCodClasificacion = Convert.ToString(oRow.Cells[10].Value); 
            strNomClasificacion = Convert.ToString(oRow.Cells[11].Value); 
            strCodPosPre = Convert.ToString(oRow.Cells[12].Value); 
            strNomPosPre = Convert.ToString(oRow.Cells[13].Value);
            strCodLogistica = Convert.ToString(oRow.Cells[14].Value);
            strDescripcion = Convert.ToString(oRow.Cells[15].Value); 
            dblImporte = Convert.ToDouble(oRow.Cells[16].Value); 
            blnEligio = true;
            this.Close();
        }

    


        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Aceptar();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.blnEligio = false;
            Close();
        }

        private void Grd_Buscados_ClickCellButton(object sender, CellEventArgs e)
        {
            this.Btn_Aceptar.Enabled = true;
        }

   
        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {

        }

        private void Grd_Buscados_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            e.Layout.Override.FilterUIType = FilterUIType.FilterRow;

            FilterOperatorDropDownItems val = FilterOperatorDropDownItems.Contains;
            Grd_Buscados.DisplayLayout.Override.FilterOperatorDropDownItems = val;

            FilterOperatorDefaultValue val1 = FilterOperatorDefaultValue.Contains;
            Grd_Buscados.DisplayLayout.Override.FilterOperatorDefaultValue = val1;

            Grd_Buscados.DisplayLayout.ScrollStyle = ScrollStyle.Immediate;
            Grd_Buscados.DisplayLayout.Scrollbars = Scrollbars.Both;
            Grd_Buscados.DisplayLayout.ColumnScrollbarSmallChange = 100;
            Grd_Buscados.DisplayLayout.UseScrollWindow = UseScrollWindow.None;
            //Grd_Buscados.DisplayLayout.UseFixedHeaders = true;
        }

        private void Grd_Buscados_DoubleClickCell(object sender, DoubleClickCellEventArgs e)
        {
            this.Aceptar();
        }

        private void Grd_Buscados_Click(object sender, EventArgs e)
        {
            this.Btn_Aceptar.Enabled = true;
        }
    }
}
