using System;
using System.Linq;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using Model;
namespace Repository
{
    public class ClaseDocumento
    {
        private string strConnection = "";
        public ClaseDocumento()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Viatico();

        }
        public Model.ClaseDocumento Recupera_ctrl_ClaseDocumento_Codigo(string strCodClaseDocumento )
        {
            DataTable dt = new DataTable();
            Model.ClaseDocumento obj = new Model.ClaseDocumento();

            dt = SqlHelper.ExecuteDataTable(strConnection, "General.spp_sel_ctrl_ClaseDocumento_Codigo", strCodClaseDocumento);

            if (dt.Rows.Count == 0)
            {
                obj.iIdClaseDocumento = 0;
                obj.cCodClaseDocumento = "";
                obj.vNomClaseDocumento = "";
                obj.iCodEstadoClaseDocumento = 0;

            }
            else
            {
                obj.iIdClaseDocumento = Convert.ToInt32(dt.Rows[0][0]);
                obj.cCodClaseDocumento = Convert.ToString(dt.Rows[0][1]);
                obj.vNomClaseDocumento = Convert.ToString(dt.Rows[0][2]);
                obj.iCodEstadoClaseDocumento = Convert.ToInt32(dt.Rows[0][3]);

            }

            return obj;

        }

        public Model.ClaseDocumento Recupera_ctrl_ClaseDocumento(int intIdDocumento )
        {
            DataTable dt = new DataTable();
            Model.ClaseDocumento obj = new Model.ClaseDocumento();

            dt = SqlHelper.ExecuteDataTable(strConnection, "General.spp_sel_ctrl_ClaseDocumento", intIdDocumento);

            if (dt.Rows.Count == 0)
            {
                obj.iIdClaseDocumento = 0;
                obj.cCodClaseDocumento = "";
                obj.vNomClaseDocumento = "";
                obj.iCodEstadoClaseDocumento = 0;

            }
            else
            {
                obj.iIdClaseDocumento = Convert.ToInt32(dt.Rows[0][0]);
                obj.cCodClaseDocumento = Convert.ToString(dt.Rows[0][1]);
                obj.vNomClaseDocumento = Convert.ToString(dt.Rows[0][2]);
                obj.iCodEstadoClaseDocumento = Convert.ToInt32(dt.Rows[0][3]);

            }

            return obj;

        }
        public DataSet Ayuda_ctrl_ClaseDocumento()
        {



            DataSet ds = new DataSet();

            ds = SqlHelper.ExecuteDataset(strConnection,
                                      "General.spp_help_ctrl_ClaseDocumento"
                                     );

            return ds;
        }

        public int Graba_ctrl_ClaseDocumento(Model.ClaseDocumento objClaseDocumento)
        {



            int intIdClaseDocumento;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "General.spp_ins_ctrl_ClaseDocumento",
                                            objClaseDocumento.cCodClaseDocumento,
                                            objClaseDocumento.vNomClaseDocumento,
                                            objClaseDocumento.iCodEstadoClaseDocumento
                                         );

                intIdClaseDocumento = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            catch (Exception e)
            {
                e.ToString();
                intIdClaseDocumento = 0;
            }

            return intIdClaseDocumento;
        }

        public int Modifica_ctrl_ClaseDocumento(Model.ClaseDocumento objClaseDocumento)
        {



            int intIdClaseDocumento;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "General.spp_upd_ctrl_ClaseDocumento",
                                            objClaseDocumento.iIdClaseDocumento,
                                            objClaseDocumento.cCodClaseDocumento,
                                            objClaseDocumento.vNomClaseDocumento,
                                            objClaseDocumento.iCodEstadoClaseDocumento
                                         );

                intIdClaseDocumento = objClaseDocumento.iIdClaseDocumento;
            }
            catch (Exception e)
            {
                e.ToString();
                intIdClaseDocumento = 0;
            }

            return intIdClaseDocumento;
        }

        public bool Elimina_ctrl_ClaseDocumento(int intIdClaseDocumento)
        {



            bool blnResult;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "General.spp_del_ctrl_ClaseDocumento",
                                            intIdClaseDocumento
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

        public DataTable Lista_ctrl_ClaseDocumento()
        {



            DataTable dt = new DataTable();

            dt = SqlHelper.ExecuteDataTable(strConnection,
                                      "General.spp_lst_ctrl_ClaseDocumento"
                                     );

            return dt;
        }

    }
}
