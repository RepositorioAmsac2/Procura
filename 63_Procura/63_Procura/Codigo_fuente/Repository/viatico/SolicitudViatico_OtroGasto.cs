using System;
using System.Linq;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Repository
{
    public class SolicitudViatico_OtroGasto
    {
        private string strConnection = "";
        public SolicitudViatico_OtroGasto()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Viatico();

        }
        public Model.SolicitudViatico_OtroGasto Recupera_SolicitudViatico_OtroGasto(int intIdSolicitudViatico_OtroGasto  )
        {
            DataTable dt = new DataTable();
            Model.SolicitudViatico_OtroGasto obj = new Model.SolicitudViatico_OtroGasto();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Viatico.spp_sel_mvto_SolicitudViatico_OtroGasto", intIdSolicitudViatico_OtroGasto);

            if (dt.Rows.Count == 0)
            {

                obj.iIdSolicitudViatico_OtroGasto  = 0;
                obj.cCodPersonal  = "";
                obj.cCodSolicitud  = "";
                obj.cCodConcepto  = "";
                obj.vNomConcepto  = "";
                obj.dMonto  = 0.0;
                obj.dfechaRegistro  = DateTime.Today;

    }
            else
            {
                obj.iIdSolicitudViatico_OtroGasto = Convert.ToInt32(dt.Rows[0][0]);
                obj.cCodPersonal = Convert.ToString(dt.Rows[0][1]);
                obj.cCodSolicitud = Convert.ToString(dt.Rows[0][2]);
                obj.cCodConcepto = Convert.ToString(dt.Rows[0][3]);
                obj.vNomConcepto = Convert.ToString(dt.Rows[0][4]);
                obj.dMonto = Convert.ToDouble(dt.Rows[0][5]);
                obj.dfechaRegistro = Convert.ToDateTime(dt.Rows[0][6]);
            }

            return obj;

        }

        public int Graba_SolicitudViatico_OtroGasto(Model.SolicitudViatico_OtroGasto obj )
        {

            int intIdSolicitudViatico_OtroGasto;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Viatico.spp_ins_mvto_SolicitudViatico_OtroGasto",
                                            obj.cCodPersonal,
                                            obj.cCodSolicitud,
                                            obj.cCodConcepto,
                                            obj.dMonto
                                         );

                intIdSolicitudViatico_OtroGasto = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            catch (Exception e)
            {
                e.ToString();
                intIdSolicitudViatico_OtroGasto = 0;
            }

            return intIdSolicitudViatico_OtroGasto;
        }

        public int Modifica_SolicitudViatico_OtroGasto(Model.SolicitudViatico_OtroGasto obj )
        {

            int intIdSolicitudViatico_OtroGasto;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Viatico.spp_upd_mvto_SolicitudViatico_OtroGasto",
                                            obj.iIdSolicitudViatico_OtroGasto,
                                            obj.cCodPersonal,
                                            obj.cCodSolicitud,
                                            obj.cCodConcepto,
                                            obj.dMonto

                                         );

                intIdSolicitudViatico_OtroGasto = obj.iIdSolicitudViatico_OtroGasto;
            }
            catch (Exception e)
            {
                e.ToString();
                intIdSolicitudViatico_OtroGasto = 0;
            }

            return intIdSolicitudViatico_OtroGasto;
        }

        public bool Elimina_SolicitudViatico_OtroGasto(int intIdSolicitudViatico_OtroGasto )
        {



            bool blnResult;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Viatico.spp_del_mvto_SolicitudViatico_OtroGasto",
                                            intIdSolicitudViatico_OtroGasto
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

        public DataTable Lista_SolicitudViatico_OtroGasto(string strCodSolicitud )
        {



            DataTable dt = new DataTable();

            dt = SqlHelper.ExecuteDataTable(strConnection,
                                      "Viatico.spp_lst_mvto_SolicitudViatico_OtroGasto",
                                      strCodSolicitud
                                     );

            return dt;
        }

    }
}
