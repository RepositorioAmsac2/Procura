using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Patrimonio_Transaccion
    {
        public int IidPatrimonio_Transaccion = 0;
        public string CcodPatrimonio = "";
        public string CcodTipoTransaccion = "";
        public string CnumTransaccion = "";
        public string CnumTransaccion_Referencia = "";
        public DateTime DfecTransaccion = DateTime.Today;
        public string CcodSegmentoOrigen = "";
        public string CcodSegmentoDestino = "";
        public string CtipoMovimiento = "";
        public string CtipoMovimiento_VidaUtil = "";
        public double Fcantidad = 1.0;
        public double FvalorPatrimonio_MN = 0.0;
        public double FvalorPatrimonio_ME = 0.0;
        public double FvalorPatrimonio_MN_tasa = 0.0;
        public double FvalorPatrimonio_ME_tasa = 0.0;
        public double FvalorResidual_MN = 1.0;
        public double FvalorResidual_ME = 1.0;
        public double FvalorResidual_MN_tasa = 1.0;
        public double FvalorResidual_ME_tasa = 1.0;
        public string CperiodoRegistro = "";
        public string CcodTipoMovimiento = "";

        public string CcodSegmento = "";
        public string CcodCentroCosto = "";
        public string CcodCentro = "";
        public string CcodEmplazamiento = "";
        public string CcodLocal = "";

        public string TubiFisica = "";
        public double FimportePatrimonioTransferido = 0.0;
        public string CperiodoAñosAnteriores = "";
        public double FimporteAñosAnteriores = 0.0;
        public string CperiodoMesesAnteriores = "";
        public double FimporteMesesAnteriores = 0.0;

        public double FdepAñoAntes_Tributario_MN = 0.0;
        public double FdepAcumulado_Tributario_MN = 0.0;
        public double FdepAñoAntes_Tributario_ME = 0.0;
        public double FdepAcumulado_Tributario_ME = 0.0;
        public double FdepAñoAntes_Financiero_MN = 0.0;
        public double FdepAcumulado_Financiero_MN = 0.0;
        public double FdepAñoAntes_Financiero_ME = 0.0;
        public double FdepAcumulado_Financiero_ME = 0.0;

        public string CcodMotivoBaja = "";
        public string CcodRecomendacionBaja = "";
        public string Tnota = "";

        public string CcodMotivoTransferencia = "";
        public string CcodRecomendacionTransferencia = "";
        public string TnotaTransferencia = "";

        public int IvidaUtil_Tributario = 0;
        public int IvidaUtil_Financiero = 0;
    }
}
