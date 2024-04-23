using System;
using System.Linq;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Repository
{
   public class ParametroViatico
    {
        private string strConnection = "";
        public ParametroViatico()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Viatico();

        }
        public Model.ParametroViatico Recupera_ctrl_ParametroViatico(string strCodParametroViatico )
        {
            DataTable dt = new DataTable();
            Model.ParametroViatico obj = new Model.ParametroViatico();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Viatico.spp_sel_ctrl_ParametroViatico", strCodParametroViatico);

            if (dt.Rows.Count == 0)
            {
                obj.iIdParametro = 0;
                obj.cCodParametro = "";
                obj.vDesParametro = "";
                obj.vValParametro = "";

            }
            else
            {
                obj.iIdParametro = Convert.ToInt32(dt.Rows[0][0]);
                obj.cCodParametro = Convert.ToString(dt.Rows[0][1]);
                obj.vDesParametro = Convert.ToString(dt.Rows[0][2]);
                obj.vValParametro = Convert.ToString(dt.Rows[0][3]);

            }

            return obj;

        }
    }
}
