using System;
using System.Linq;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Repository
{
    public class SolicitudViatico
    {
        private string strConnection = "";
        public SolicitudViatico()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Viatico();

        }
        public Model.SolicitudViatico Recupera_SolicitudViatico(string strCodSolicitud )
        {
            DataTable dt = new DataTable();
            Model.SolicitudViatico obj = new Model.SolicitudViatico();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Viatico.spp_sel_mvto_SolicitudViatico", strCodSolicitud);

            if (dt.Rows.Count == 0)
            {
                obj.cCodTipoSolicitud  = "";
                obj.cCodSolicitud = "";
                obj.cCodSolicitud_Ampliacion  = "";
                obj.cCodPersonal  = "";
                obj.cCodUbigeo = "";
                obj.vNomUbigeo  = "";
                obj.cCodTipoDestinoViaje  = "";
                obj.vNomTipoDestinoViaje  = "";
                obj.cCodEscalaViaje = "";
                obj.vNomEscalaViaje = "";
                obj.dFechaPartida = DateTime.Today;
                obj.cHoraPartida  = "";
                obj.dFechaRetorno  = DateTime.Today;
                obj.cHoraRetorno  = "";
                obj.cCodCentroCosto  = "";
                obj.vNomCentroCosto  = "";
                obj.cCodCentroBeneficio  = "";
                obj.vNomCentroBeneficio  = "";
                obj.ccodTipoMoneda  = "";
                obj.vNomTipoMoneda  = "";
                obj.fCantidadDias = 0;
                obj.fMontoDia  = 0;
                obj.fMontoSubTotal  = 0;
                obj.fMontoOtrosgastos  = 0;
                obj.fMontoTotal  = 0;
                obj.tMotivoViaje  = "";

    }
            else
            {
                obj.cCodTipoSolicitud = Convert.ToString(dt.Rows[0][0]);
                obj.cCodSolicitud = Convert.ToString(dt.Rows[0][1]);
                obj.cCodSolicitud_Ampliacion = Convert.ToString(dt.Rows[0][2]); 
                obj.cCodPersonal = Convert.ToString(dt.Rows[0][3]); 
                obj.cCodUbigeo = Convert.ToString(dt.Rows[0][4]); 
                obj.vNomUbigeo = Convert.ToString(dt.Rows[0][5]); 
                obj.cCodTipoDestinoViaje = Convert.ToString(dt.Rows[0][6]); 
                obj.vNomTipoDestinoViaje = Convert.ToString(dt.Rows[0][7]);
                obj.cCodEscalaViaje = Convert.ToString(dt.Rows[0][8]);
                obj.vNomEscalaViaje = Convert.ToString(dt.Rows[0][9]);
                obj.dFechaPartida = Convert.ToDateTime(dt.Rows[0][10]); 
                obj.cHoraPartida = Convert.ToString(dt.Rows[0][11]); 
                obj.dFechaRetorno = Convert.ToDateTime(dt.Rows[0][12]); 
                obj.cHoraRetorno = Convert.ToString(dt.Rows[0][13]); 
                obj.cCodCentroCosto = Convert.ToString(dt.Rows[0][14]); 
                obj.vNomCentroCosto = Convert.ToString(dt.Rows[0][15]); 
                obj.cCodCentroBeneficio = Convert.ToString(dt.Rows[0][16]); 
                obj.vNomCentroBeneficio = Convert.ToString(dt.Rows[0][17]); 
                obj.ccodTipoMoneda = Convert.ToString(dt.Rows[0][18]); 
                obj.vNomTipoMoneda = Convert.ToString(dt.Rows[0][19]);
                obj.fCantidadDias = Convert.ToDouble(dt.Rows[0][20]);
                obj.fMontoDia = Convert.ToDouble(dt.Rows[0][21]); 
                obj.fMontoSubTotal = Convert.ToDouble(dt.Rows[0][22]); 
                obj.fMontoOtrosgastos = Convert.ToDouble(dt.Rows[0][23]); 
                obj.fMontoTotal = Convert.ToDouble(dt.Rows[0][24]); 
                obj.tMotivoViaje = Convert.ToString(dt.Rows[0][25]); 

            }

            return obj;

        }

        public Model.SolicitudViatico Recupera_SolicitudViatico_y_LiquidacionViatico(string strCodSolicitud )
        {
            DataTable dt = new DataTable();
            Model.SolicitudViatico obj = new Model.SolicitudViatico();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Viatico.spp_sel_mvto_SolicitudViatico_y_LiquidacionViatico", strCodSolicitud);

            if (dt.Rows.Count == 0)
            {
                obj.cCodTipoSolicitud = "";
                obj.cCodSolicitud = "";
                obj.cCodSolicitud_Ampliacion = "";
                obj.cCodPersonal = "";
                obj.cCodUbigeo = "";
                obj.vNomUbigeo = "";
                obj.cCodTipoDestinoViaje = "";
                obj.vNomTipoDestinoViaje = "";
                obj.cCodEscalaViaje = "";
                obj.vNomEscalaViaje = "";
                obj.dFechaPartida = DateTime.Today;
                obj.cHoraPartida = "";
                obj.dFechaRetorno = DateTime.Today;
                obj.cHoraRetorno = "";
                obj.cCodCentroCosto = "";
                obj.vNomCentroCosto = "";
                obj.cCodCentroBeneficio = "";
                obj.vNomCentroBeneficio = "";
                obj.ccodTipoMoneda = "";
                obj.vNomTipoMoneda = "";
                obj.fCantidadDias = 0;
                obj.fMontoDia = 0;
                obj.fMontoSubTotal = 0;
                obj.fMontoOtrosgastos = 0;
                obj.fMontoTotal = 0;
                obj.fTotalLiquidacion = 0;
                obj.tMotivoViaje = "";

            }
            else
            {
                obj.cCodTipoSolicitud = Convert.ToString(dt.Rows[0][0]);
                obj.cCodSolicitud = Convert.ToString(dt.Rows[0][1]);
                obj.cCodSolicitud_Ampliacion = Convert.ToString(dt.Rows[0][2]);
                obj.cCodPersonal = Convert.ToString(dt.Rows[0][3]);
                obj.cCodUbigeo = Convert.ToString(dt.Rows[0][4]);
                obj.vNomUbigeo = Convert.ToString(dt.Rows[0][5]);
                obj.cCodTipoDestinoViaje = Convert.ToString(dt.Rows[0][6]);
                obj.vNomTipoDestinoViaje = Convert.ToString(dt.Rows[0][7]);
                obj.cCodEscalaViaje = Convert.ToString(dt.Rows[0][8]);
                obj.vNomEscalaViaje = Convert.ToString(dt.Rows[0][9]);
                obj.dFechaPartida = Convert.ToDateTime(dt.Rows[0][10]);
                obj.cHoraPartida = Convert.ToString(dt.Rows[0][11]);
                obj.dFechaRetorno = Convert.ToDateTime(dt.Rows[0][12]);
                obj.cHoraRetorno = Convert.ToString(dt.Rows[0][13]);
                obj.cCodCentroCosto = Convert.ToString(dt.Rows[0][14]);
                obj.vNomCentroCosto = Convert.ToString(dt.Rows[0][15]);
                obj.cCodCentroBeneficio = Convert.ToString(dt.Rows[0][16]);
                obj.vNomCentroBeneficio = Convert.ToString(dt.Rows[0][17]);
                obj.ccodTipoMoneda = Convert.ToString(dt.Rows[0][18]);
                obj.vNomTipoMoneda = Convert.ToString(dt.Rows[0][19]);
                obj.fCantidadDias = Convert.ToDouble(dt.Rows[0][20]);
                obj.fMontoDia = Convert.ToDouble(dt.Rows[0][21]);
                obj.fMontoSubTotal = Convert.ToDouble(dt.Rows[0][22]);
                obj.fMontoOtrosgastos = Convert.ToDouble(dt.Rows[0][23]);
                obj.fMontoTotal = Convert.ToDouble(dt.Rows[0][24]);
                obj.fTotalLiquidacion = Convert.ToDouble(dt.Rows[0][25]);
                obj.tMotivoViaje = Convert.ToString(dt.Rows[0][26]);

            }


            return obj;

        }

        public string Graba_SolicitudViatico(Model.SolicitudViatico objSolicitudViatico )
        {



            string strCodSolicitud;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Viatico.spp_ins_mvto_SolicitudViatico",
                                            objSolicitudViatico.cCodTipoSolicitud,
                                            objSolicitudViatico.cCodSolicitud_Ampliacion,
                                            objSolicitudViatico.cCodPersonal,
                                            objSolicitudViatico.cCodUbigeo,
                                            objSolicitudViatico.cCodTipoDestinoViaje,
                                            objSolicitudViatico.cCodEscalaViaje,
                                            objSolicitudViatico.dFechaPartida,
                                            objSolicitudViatico.cHoraPartida,
                                            objSolicitudViatico.dFechaRetorno,
                                            objSolicitudViatico.cHoraRetorno,
                                            objSolicitudViatico.fCantidadDias,
                                            objSolicitudViatico.cCodCentroCosto,
                                            objSolicitudViatico.ccodTipoMoneda,
                                            objSolicitudViatico.fMontoDia,
                                            objSolicitudViatico.tMotivoViaje
                                         );

                strCodSolicitud = Convert.ToString(dt.Rows[0][0].ToString());
            }
            catch (Exception e)
            {
                e.ToString();
                strCodSolicitud = "";
            }

            return strCodSolicitud;
        }

        public bool Modifica_SolicitudViatico(Model.SolicitudViatico objSolicitudViatico )
        {



            bool blnResult = false;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Viatico.spp_upd_mvto_SolicitudViatico",
                                            objSolicitudViatico.iIdSolicitud,
                                            objSolicitudViatico.cCodSolicitud,
                                            objSolicitudViatico.cCodTipoSolicitud,
                                            objSolicitudViatico.cCodSolicitud_Ampliacion,
                                            objSolicitudViatico.cCodPersonal,
                                            objSolicitudViatico.cCodUbigeo,
                                            objSolicitudViatico.cCodTipoDestinoViaje,
                                            objSolicitudViatico.cCodEscalaViaje,
                                            objSolicitudViatico.dFechaPartida,
                                            objSolicitudViatico.cHoraPartida,
                                            objSolicitudViatico.dFechaRetorno,
                                            objSolicitudViatico.cHoraRetorno,
                                            objSolicitudViatico.fCantidadDias,
                                            objSolicitudViatico.cCodCentroCosto,
                                            objSolicitudViatico.ccodTipoMoneda,
                                            objSolicitudViatico.fMontoDia,
                                            objSolicitudViatico.tMotivoViaje

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

        public bool Elimina_SolicitudViatico(string strCodSolicitud )
        {



            bool blnResult;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Viatico.spp_del_mvto_SolicitudViatico",
                                            strCodSolicitud
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

        public DataTable Lista_SolicitudViatico()
        {



            DataTable dt = new DataTable();

            dt = SqlHelper.ExecuteDataTable(strConnection,
                                      "Viatico.spp_lst_mvto_SolicitudViatico"
                                     );

            return dt;
        }

    }
}
