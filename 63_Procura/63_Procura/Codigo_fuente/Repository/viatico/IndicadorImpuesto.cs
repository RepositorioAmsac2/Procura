using System;
using System.Linq;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Repository
{
    public class IndicadorImpuesto
    {
        private string strConnection = "";
        public IndicadorImpuesto()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Viatico();

        }
        public Model.IndicadorImpuesto Recupera_ctrl_IndicadorImpuesto_Codigo(string strCodIndicadorImpuesto)
        {
            DataTable dt = new DataTable();
            Model.IndicadorImpuesto obj = new Model.IndicadorImpuesto();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Viatico.spp_sel_ctrl_IndicadorImpuesto_Codigo", strCodIndicadorImpuesto);

            if (dt.Rows.Count == 0)
            {
                obj.iIdIndicadorImpuesto = 0;
                obj.cCodIndicadorImpuesto = "";
                obj.vNomIndicadorImpuesto = "";

            }
            else
            {
                obj.iIdIndicadorImpuesto = Convert.ToInt32(dt.Rows[0][0]);
                obj.cCodIndicadorImpuesto = Convert.ToString(dt.Rows[0][1]);
                obj.vNomIndicadorImpuesto = Convert.ToString(dt.Rows[0][2]);

            }

            return obj;

        }

        public Model.IndicadorImpuesto Recupera_ctrl_IndicadorImpuesto(int intIdIndicadorImpuesto)
        {
            DataTable dt = new DataTable();
            Model.IndicadorImpuesto obj = new Model.IndicadorImpuesto();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Viatico.spp_sel_ctrl_IndicadorImpuesto", intIdIndicadorImpuesto);

            if (dt.Rows.Count == 0)
            {
                obj.iIdIndicadorImpuesto = 0;
                obj.cCodIndicadorImpuesto = "";
                obj.vNomIndicadorImpuesto = "";

            }
            else
            {
                obj.iIdIndicadorImpuesto = Convert.ToInt32(dt.Rows[0][0]);
                obj.cCodIndicadorImpuesto = Convert.ToString(dt.Rows[0][1]);
                obj.vNomIndicadorImpuesto = Convert.ToString(dt.Rows[0][2]);
            }

            return obj;

        }

        public DataSet Ayuda_ctrl_IndicadorImpuesto()
        {



            DataSet ds = new DataSet();

            ds = SqlHelper.ExecuteDataset(strConnection,
                                      "Viatico.spp_help_ctrl_IndicadorImpuesto"
                                     );

            return ds;
        }

        public DataSet Combo_ctrl_IndicadorImpuesto()
        {



            DataSet ds = new DataSet();

            ds = SqlHelper.ExecuteDataset(strConnection,
                                      "Viatico.spp_cbo_ctrl_IndicadorImpuesto"
                                     );

            return ds;
        }

        public int Graba_ctrl_IndicadorImpuesto(Model.IndicadorImpuesto objIndicadorImpuesto)
        {



            int intIdIndicadorImpuesto;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Viatico.spp_ins_ctrl_IndicadorImpuesto",
                                            objIndicadorImpuesto.cCodIndicadorImpuesto,
                                            objIndicadorImpuesto.vNomIndicadorImpuesto
                                         );

                intIdIndicadorImpuesto = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            catch (Exception e)
            {
                e.ToString();
                intIdIndicadorImpuesto = 0;
            }

            return intIdIndicadorImpuesto;
        }

        public int Modifica_ctrl_IndicadorImpuesto(Model.IndicadorImpuesto objIndicadorImpuesto)
        {



            int intIdIndicadorImpuesto;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Vatico.spp_upd_ctrl_IndicadorImpuesto",
                                            objIndicadorImpuesto.iIdIndicadorImpuesto,
                                            objIndicadorImpuesto.cCodIndicadorImpuesto,
                                            objIndicadorImpuesto.vNomIndicadorImpuesto
                                         );

                intIdIndicadorImpuesto = objIndicadorImpuesto.iIdIndicadorImpuesto;
            }
            catch (Exception e)
            {
                e.ToString();
                intIdIndicadorImpuesto = 0;
            }

            return intIdIndicadorImpuesto;
        }

        public bool Elimina_ctrl_IndicadorImpuesto(int intIdIndicadorImpuesto)
        {



            bool blnResult;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Viatico.spp_del_ctrl_IndicadorImpuesto",
                                            intIdIndicadorImpuesto
                                         );

                blnResult = true;
            }
            catch (Exception e)
            {
                e.ToString();
                blnResult = false;
            }

            return blnResult;
        }

        public DataTable Lista_ctrl_IndicadorImpuesto()
        {



            DataTable dt = new DataTable();

            dt = SqlHelper.ExecuteDataTable(strConnection,
                                      "Viatico.spp_lst_ctrl_IndicadorImpuesto"
                                     );

            return dt;
        }
    }
}
