using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Patrimonio_Transferencia
    {
        public int IidPatrimonio_Transferencia { get; set; } = 0;
        public string CcodPatrimonio { get; set; } = "";
        public string CcodSegmento { get; set; } = "";
        public string CcodCentro { get; set; } = "";
        public string CcodEmplazamiento { get; set; } = "";
        public string CcodCentroCosto { get; set; } = "";
        public string Tlocal { get; set; } = "";

        public double Fcantidad { get; set; } = 0.0;
        public DateTime DfecTransferencia { get; set; } = DateTime.Today;
        public double FimportePatrimonioTransferido { get; set; } = 0.0;
        public string CperiodoAñosAnteriores { get; set; } = "";
        public double FimporteAñosAnteriores { get; set; } = 0.0;
        public string CperiodoMesesAnteriores { get; set; } = "";
        public double FimporteMesesAnteriores { get; set; } = 0.0;
        public bool Bestado { get; set; } = false;
    }
}
