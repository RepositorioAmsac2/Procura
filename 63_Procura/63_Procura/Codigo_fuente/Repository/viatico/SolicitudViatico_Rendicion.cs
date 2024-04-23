using System;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Repository
{
    public class SolicitudViatico_Rendicion
    {
        private string strConnection = "";
        public SolicitudViatico_Rendicion()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Viatico();

        }
        public Model.SolicitudViatico_Rendicion Recupera_SolicitudViatico_Rendicion(string intIdSolicitudViatico_Rendicion )
        {
            DataTable dt = new DataTable();
            Model.SolicitudViatico_Rendicion obj = new Model.SolicitudViatico_Rendicion();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Viatico.spp_sel_mvto_SolicitudViatico_Rendicion", intIdSolicitudViatico_Rendicion);

            if (dt.Rows.Count == 0)
            {
                obj.iIdSolicitudViatico_Rendicion = 0;
                obj.cCodSolicitud = "";
		        obj.cCodConcepto = "";
                obj.vNomConcepto = "";
                obj.dFechaInicio = DateTime.Today;
                obj.dFechaFinal = DateTime.Today;
                obj.cCodProveedor = "";
                obj.vNomProveedor = "";
		        obj.cCodClaseDocumento = "";
                obj.vNomClaseDocumento = "";
                obj.cSerieDocumento = "";
                obj.cNumeroDocumento = "";
                obj.cNumeroDocumentoAdicional = "";
                obj.dFechaDocumento = DateTime.Today;
                obj.cCodTipoMoneda = "";
                obj.dImporte = 0.0;
		        obj.dImpuesto = 0.0;
                obj.dOtroImporte = 0.0;
                obj.dTotal =  0.0;
                obj.cCodCentroCosto = "";
                obj.tObservacion = "";
                obj.dFechaRegistro = "";
            }
            else
            {

                obj.iIdSolicitudViatico_Rendicion = Convert.ToInt32(dt.Rows[0][0]);
                obj.cCodSolicitud = Convert.ToString(dt.Rows[0][1]);
                obj.cCodConcepto = Convert.ToString(dt.Rows[0][2]);
                obj.vNomConcepto = Convert.ToString(dt.Rows[0][3]);
                obj.dFechaInicio = Convert.ToDateTime(dt.Rows[0][4]);
                obj.dFechaFinal = Convert.ToDateTime(dt.Rows[0][5]);
                obj.cCodProveedor = Convert.ToString(dt.Rows[0][6]);
                obj.vNomProveedor = Convert.ToString(dt.Rows[0][7]);
                obj.cCodClaseDocumento = Convert.ToString(dt.Rows[0][8]);
                obj.vNomClaseDocumento = Convert.ToString(dt.Rows[0][9]);
                obj.cSerieDocumento = Convert.ToString(dt.Rows[0][10]);
                obj.cNumeroDocumento = Convert.ToString(dt.Rows[0][11]);
                obj.cNumeroDocumentoAdicional = Convert.ToString(dt.Rows[0][12]);
                obj.dFechaDocumento = Convert.ToDateTime(dt.Rows[0][13]);
                obj.cCodTipoMoneda = Convert.ToString(dt.Rows[0][14]);
                obj.dImporte = Convert.ToDouble(dt.Rows[0][15]);
                obj.dImpuesto = Convert.ToDouble(dt.Rows[0][16]);
                obj.dOtroImporte = Convert.ToDouble(dt.Rows[0][17]);
                obj.dTotal = Convert.ToDouble(dt.Rows[0][18]);
                obj.cCodCentroCosto = Convert.ToString(dt.Rows[0][19]);
                obj.tObservacion = Convert.ToString(dt.Rows[0][20]);
                obj.dFechaRegistro = Convert.ToString(dt.Rows[0][21]);


            }

            return obj;

        }


        public int Graba_SolicitudViatico_Rendicion(Model.SolicitudViatico_Rendicion objLiquidacionViatico )
        {



            int intIdSolicitudViatico_Rendicion;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Viatico.spp_ins_mvto_SolicitudViatico_Rendicion",
                                            objLiquidacionViatico.cCodSolicitud,
                                            objLiquidacionViatico.cCodConcepto,
                                            objLiquidacionViatico.dFechaInicio,
                                            objLiquidacionViatico.dFechaFinal,
                                            objLiquidacionViatico.cCodProveedor,
                                            objLiquidacionViatico.cCodClaseDocumento,
                                            objLiquidacionViatico.cSerieDocumento,
                                            objLiquidacionViatico.cNumeroDocumento,
                                            objLiquidacionViatico.cNumeroDocumentoAdicional,
                                            objLiquidacionViatico.dFechaDocumento,
                                            objLiquidacionViatico.cCodTipoMoneda,
                                            objLiquidacionViatico.dImporte,
                                            objLiquidacionViatico.dOtroImporte,
                                            objLiquidacionViatico.cCodCentroCosto,
                                            objLiquidacionViatico.tObservacion
                                         );

                intIdSolicitudViatico_Rendicion = Convert.ToInt32(dt.Rows[0][0]);
            }
            catch (Exception e)
            {
                e.ToString();
                intIdSolicitudViatico_Rendicion = 0;
            }

            return intIdSolicitudViatico_Rendicion;
        }

        public int Modifica_SolicitudViatico_Rendicion(Model.SolicitudViatico_Rendicion objLiquidacionViatico )
        {



            int intIdSolicitudViatico_Rendicion;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Viatico.spp_upd_mvto_SolicitudViatico_Rendicion",
                                            objLiquidacionViatico.iIdSolicitudViatico_Rendicion,
                                            objLiquidacionViatico.cCodSolicitud,
                                            objLiquidacionViatico.cCodConcepto,
                                            objLiquidacionViatico.dFechaInicio,
                                            objLiquidacionViatico.dFechaFinal,
                                            objLiquidacionViatico.cCodProveedor,
                                            objLiquidacionViatico.cCodClaseDocumento,
                                            objLiquidacionViatico.cSerieDocumento,
                                            objLiquidacionViatico.cNumeroDocumento,
                                            objLiquidacionViatico.cNumeroDocumentoAdicional,
                                            objLiquidacionViatico.dFechaDocumento,
                                            objLiquidacionViatico.cCodTipoMoneda,
                                            objLiquidacionViatico.dImporte,
                                            objLiquidacionViatico.dOtroImporte,
                                            objLiquidacionViatico.cCodCentroCosto,
                                            objLiquidacionViatico.tObservacion
                                         );

                intIdSolicitudViatico_Rendicion = objLiquidacionViatico.iIdSolicitudViatico_Rendicion;
            }
            catch (Exception e)
            {
                e.ToString();
                intIdSolicitudViatico_Rendicion = 0;
            }

            return intIdSolicitudViatico_Rendicion;
        }

        public bool Elimina_SolicitudViatico_Rendicion(int intIdSolicitudViatico_Rendicion )
        {



            bool blnResult;

            DataTable dt = new DataTable();

            try
            {

                dt = SqlHelper.ExecuteDataTable(strConnection,
                                          "Viatico.spp_del_mvto_SolicitudViatico_Rendicion",
                                            intIdSolicitudViatico_Rendicion
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

        public DataTable Lista_SolicitudViatico_Rendicion(string strCodSolicitud )
        {



            DataTable dt = new DataTable();

            dt = SqlHelper.ExecuteDataTable(strConnection,
                                      "Viatico.spp_lst_mvto_SolicitudViatico_Rendicion",
                                      strCodSolicitud
                                     );

            return dt;
        }

    }
}
