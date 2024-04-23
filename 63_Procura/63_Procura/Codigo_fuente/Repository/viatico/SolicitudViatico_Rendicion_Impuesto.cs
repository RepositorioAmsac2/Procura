using System;
using System.Linq;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Repository
{
    public class SolicitudViatico_Rendicion_Impuesto
    {
        private string strConnection = "";
        public SolicitudViatico_Rendicion_Impuesto()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Viatico();

        }
        public Model.SolicitudViatico_Rendicion_Impuesto Recupera_SolicitudViatico_Rendicion_Impuesto(int intIdSolicitudViatico_Rendicion_Impuesto)
        {
            DataTable dt = new DataTable();
            Model.SolicitudViatico_Rendicion_Impuesto obj = new Model.SolicitudViatico_Rendicion_Impuesto();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Viatico.spp_sel_mvto_SolicitudViatico_Rendicion_Impuesto", intIdSolicitudViatico_Rendicion_Impuesto);

            if (dt.Rows.Count == 0)
            {

                obj.iIdSolicitudViatico_Rendicion_Impuesto = 0;
                obj.iIdSolicitudViatico_Rendicion = 0;
                obj.cCodSolicitud = "";
                obj.cCodIndicadorImpuesto = "";
                obj.vNomIndicadorImpuesto = "";
                obj.dImpuesto = 0.0;
            }
            else
            {
                obj.iIdSolicitudViatico_Rendicion_Impuesto = Convert.ToInt32(dt.Rows[0][0]);
                obj.iIdSolicitudViatico_Rendicion = Convert.ToInt32(dt.Rows[0][1]);
                obj.cCodSolicitud = Convert.ToString(dt.Rows[0][2]);
                obj.cCodIndicadorImpuesto = Convert.ToString(dt.Rows[0][3]);
                obj.vNomIndicadorImpuesto = Convert.ToString(dt.Rows[0][4]);
                obj.dImpuesto = Convert.ToDouble(dt.Rows[0][5]);
            }

            return obj;

        }

        public int Graba_SolicitudViatico_Rendicion_Impuesto(Model.SolicitudViatico_Rendicion_Impuesto obj)
        {

            int intIdSolicitudViatico_Rendicion_Impuesto;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Viatico.spp_ins_mvto_SolicitudViatico_Rendicion_Impuesto",
                                            obj.iIdSolicitudViatico_Rendicion,
                                            obj.cCodSolicitud,
                                            obj.cCodIndicadorImpuesto,
                                            obj.dImpuesto
                                         );

                intIdSolicitudViatico_Rendicion_Impuesto = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            catch (Exception e)
            {
                e.ToString();
                intIdSolicitudViatico_Rendicion_Impuesto = 0;
            }

            return intIdSolicitudViatico_Rendicion_Impuesto;
        }

        public int Modifica_SolicitudViatico_Rendicion_Impuesto(Model.SolicitudViatico_Rendicion_Impuesto obj)
        {

            int intIdSolicitudViatico_Rendicion_Impuesto;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Viatico.spp_upd_mvto_SolicitudViatico_Rendicion_Impuesto",
                                            obj.iIdSolicitudViatico_Rendicion_Impuesto,
                                            obj.iIdSolicitudViatico_Rendicion,
                                            obj.cCodSolicitud,
                                            obj.cCodIndicadorImpuesto,
                                            obj.dImpuesto

                                         );

                intIdSolicitudViatico_Rendicion_Impuesto = obj.iIdSolicitudViatico_Rendicion_Impuesto;
            }
            catch (Exception e)
            {
                e.ToString();
                intIdSolicitudViatico_Rendicion_Impuesto = 0;
            }

            return intIdSolicitudViatico_Rendicion_Impuesto;
        }

        public bool Elimina_SolicitudViatico_Rendicion_Impuesto(int intIdSolicitudViatico_Rendicion_Impuesto)
        {



            bool blnResult;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Viatico.spp_del_mvto_SolicitudViatico_Rendicion_Impuesto",
                                            intIdSolicitudViatico_Rendicion_Impuesto
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

        public DataTable Lista_SolicitudViatico_Rendicion_Impuesto(int intIdSolicitudViatico_Rendicion)
        {

            DataTable dt = new DataTable();

            dt = SqlHelper.ExecuteDataTable(strConnection,
                                      "Viatico.spp_lst_mvto_SolicitudViatico_Rendicion_Impuesto",
                                      intIdSolicitudViatico_Rendicion
                                     );

            return dt;
        }
    }
}
