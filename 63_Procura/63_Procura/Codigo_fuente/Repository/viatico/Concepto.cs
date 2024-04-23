using System;
using System.Linq;
using System.Data;
using Model;
using Microsoft.ApplicationBlocks.Data;
namespace Repository
{
    public class Concepto
    {
        private string strConnection = "";
        public Concepto()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Viatico();

        }
        public Model.Concepto Recupera_msto_Concepto_Codigo(string strCodConcepto)
        {
            DataTable dt = new DataTable();
            Model.Concepto obj = new Model.Concepto();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Viatico.spp_sel_msto_Concepto_Codigo", strCodConcepto);

            if (dt.Rows.Count == 0)
            {
                obj.idConcepto = 0;
                obj.cCodConcepto = "";
                obj.vNomConcepto = "";
                obj.cCodTipoConcepto = "";

            }
            else
            {
                obj.idConcepto = Convert.ToInt32(dt.Rows[0][0]);
                obj.cCodConcepto = Convert.ToString(dt.Rows[0][1]);
                obj.vNomConcepto = Convert.ToString(dt.Rows[0][2]);
                obj.cCodTipoConcepto = Convert.ToString(dt.Rows[0][3]);

            }

            return obj;

        }

        public Model.Concepto Recupera_msto_Concepto(int intIdConcepto)
        {
            DataTable dt = new DataTable();
            Model.Concepto obj = new Model.Concepto();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Viatico.spp_sel_msto_Concepto", intIdConcepto);

            if (dt.Rows.Count == 0)
            {
                obj.idConcepto = 0;
                obj.cCodConcepto = "";
                obj.vNomConcepto = "";
                obj.cCodTipoConcepto = "";

            }
            else
            {
                obj.idConcepto = Convert.ToInt32(dt.Rows[0][0]);
                obj.cCodConcepto = Convert.ToString(dt.Rows[0][1]);
                obj.vNomConcepto = Convert.ToString(dt.Rows[0][2]);
                obj.cCodTipoConcepto = Convert.ToString(dt.Rows[0][3]);

            }

            return obj;

        }

        public DataSet Ayuda_msto_Concepto( string strCodTipoConcepto)
        {



            DataSet ds = new DataSet();

            ds = SqlHelper.ExecuteDataset(strConnection,
                                      "Viatico.spp_help_msto_Concepto",
                                      strCodTipoConcepto
                                     );

            return ds;
        }

        public int Graba_msto_Concepto(Model.Concepto objConcepto)
        {



            int intIdConcepto;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Viatico.spp_ins_msto_Concepto",
                                            objConcepto.cCodConcepto,
                                            objConcepto.vNomConcepto,
                                            objConcepto.cCodTipoConcepto
                                         );

                intIdConcepto = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            catch (Exception e)
            {
                e.ToString();
                intIdConcepto = 0;
            }

            return intIdConcepto;
        }

        public int Modifica_msto_Concepto(Model.Concepto objConcepto)
        {



            int intIdConcepto;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Vatico.spp_upd_msto_Concepto",
                                            objConcepto.idConcepto,
                                            objConcepto.cCodConcepto,
                                            objConcepto.vNomConcepto,
                                            objConcepto.cCodTipoConcepto
                                         );

                intIdConcepto = objConcepto.idConcepto;
            }
            catch (Exception e)
            {
                e.ToString();
                intIdConcepto = 0;
            }

            return intIdConcepto;
        }

        public bool Elimina_msto_Concepto(int intIdConcepto)
        {



            bool blnResult;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Viatico.spp_del_msto_Concepto",
                                            intIdConcepto
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

        public DataTable Lista_msto_Concepto()
        {



            DataTable dt = new DataTable();

            dt = SqlHelper.ExecuteDataTable(strConnection,
                                      "Viatico.spp_lst_msto_Concepto"
                                     );

            return dt;
        }
    }
}
