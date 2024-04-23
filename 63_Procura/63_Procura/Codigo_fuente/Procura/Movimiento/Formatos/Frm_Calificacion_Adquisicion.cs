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
    public partial class Frm_Calificacion_Adquisicion : Form
    {
        public Frm_Calificacion_Adquisicion()
        {
            InitializeComponent();
        }
        private DataTable tblComiteEvaluacion;
        private void Btn_Grabar_Click(object sender, EventArgs e)
        {

        }

        #region "Evaluación y Calificación"
        private void CreaTablaRendicionImpuestos()
        {
            tblComiteEvaluacion = new DataTable("tblComiteEvaluacion");
            DataColumn col;

            //col = new DataColumn("iIdSolicitudViatico_Rendicion_Impuesto", typeof(int));
            //tblRendicionImpuesto.Columns.Add(col);

            //col = new DataColumn("iIdSolicitudViatico_Rendicion", typeof(int));
            //tblRendicionImpuesto.Columns.Add(col);

            //col = new DataColumn("cCodSolicitud", typeof(string));
            //tblRendicionImpuesto.Columns.Add(col);

            //col = new DataColumn("cCodIndicadorImpuesto", typeof(string));
            //tblRendicionImpuesto.Columns.Add(col);

            //col = new DataColumn("vNomIndicadorImpuesto", typeof(string));
            //tblRendicionImpuesto.Columns.Add(col);

            //col = new DataColumn("dImpuesto", typeof(double));
            //tblRendicionImpuesto.Columns.Add(col);

            //col = new DataColumn("cCodIndicadorImpuesto_Ant", typeof(string));
            //tblRendicionImpuesto.Columns.Add(col);

            //col = new DataColumn("dImpuesto_Ant", typeof(double));
            //tblRendicionImpuesto.Columns.Add(col);
        }

        private void LlenarFilasTablaRendicionImpuesto(int intIdSolicitudViatico_Rendicion_Impuesto,
                                                    int intIdSolicitudViatico_Rendicion,
                                                    string strCodSolicitud,
                                                    string strCodIndicadorImpuesto,
                                                    string strNomIndicadorImpuesto,
                                                    double dblImpuesto,
                                                    string strCodIndicadorImpuesto_Ant,
                                                    double dblImpuesto_Ant
                                                )
        {

            DataRow OtrosGastosRow;
            //OtrosGastosRow = tblRendicionImpuesto.NewRow();
            //OtrosGastosRow["iIdSolicitudViatico_Rendicion_Impuesto"] = intIdSolicitudViatico_Rendicion_Impuesto;
            //OtrosGastosRow["iIdSolicitudViatico_Rendicion"] = intIdSolicitudViatico_Rendicion;
            //OtrosGastosRow["cCodSolicitud"] = strCodSolicitud;
            //OtrosGastosRow["cCodIndicadorImpuesto"] = strCodIndicadorImpuesto;
            //OtrosGastosRow["vNomIndicadorImpuesto"] = strNomIndicadorImpuesto;
            //OtrosGastosRow["dImpuesto"] = dblImpuesto;
            //OtrosGastosRow["cCodIndicadorImpuesto_Ant"] = strCodIndicadorImpuesto_Ant;
            //OtrosGastosRow["dImpuesto_Ant"] = dblImpuesto_Ant;

            //tblRendicionImpuesto.Rows.Add(OtrosGastosRow);
        }

        #endregion


    }
}
