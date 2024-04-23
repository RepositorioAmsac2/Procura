using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BuenaPro
    {
        public int iIdBuenaPro { get; set; } = 0;
        public string cCodTipoProceso { get; set; } = "";
        public string cNroProceso { get; set; } = "";
        public string tDesProceso { get; set; } = "";
        public string cCodObjetoContratacion { get; set; } = "";
        public string cCodGanador { get; set; } = "";
        public string CcodTipoMoneda { get; set; } = "";
        public double FtipoCambio { get; set; } = 0.0;
        public double FprecioUnitario_Local { get; set; } = 0.0;
        public double FprecioUnitario_Extranjero { get; set; } = 0.0;
        public string CcodTipoImpuesto { get; set; } = "";
        public double Fimpuesto_Local { get; set; } = 0.0;
        public double Fimpuesto_Extranjero { get; set; } = 0.0;
        public string cNroContrato { get; set; } = "";
    }
}
