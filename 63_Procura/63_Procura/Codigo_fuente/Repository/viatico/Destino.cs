using System;
using System.Linq;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Repository
{
    public class Destino
    {
        private string strConnection = "";
        public Destino()
        {
            Repository.DataAccess DA = new Repository.DataAccess();
            strConnection = DA.ReturnConnectionString_Viatico();

        }
        public Model.Destino Recupera_msto_Empleado_Destino(string strCodTipoDestinoViaje,
                                                             string strCodEscalaViaje
                                                            )
        {
            DataTable dt = new DataTable();
            Model.Destino obj = new Model.Destino();

            dt = SqlHelper.ExecuteDataTable(strConnection, "Viatico.spp_sel_msto_Empleado_Destino", strCodTipoDestinoViaje, strCodEscalaViaje);

            if (dt.Rows.Count == 0)
            {

                obj.iIdEscalaViaje = 0;
                obj.cCodTipoDestinoViaje = "";
                obj.vNomTipoDestinoViaje = "";
                obj.cCodEscalaViaje = "";
                obj.vNomEscalaViaje = "";
                obj.fMonto = 0.0;


            }
            else
            {

                obj.iIdEscalaViaje = Convert.ToInt32(dt.Rows[0][0]);
                obj.cCodTipoDestinoViaje = Convert.ToString(dt.Rows[0][1]);
                obj.vNomTipoDestinoViaje = Convert.ToString(dt.Rows[0][2]);
                obj.cCodEscalaViaje = Convert.ToString(dt.Rows[0][3]);
                obj.vNomEscalaViaje = Convert.ToString(dt.Rows[0][4]);
                obj.fMonto = Convert.ToDouble(dt.Rows[0][5]);


            }

            return obj;

        }
    }
}
