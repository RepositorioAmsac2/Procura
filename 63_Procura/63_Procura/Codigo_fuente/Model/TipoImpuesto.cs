using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TipoImpuesto
    {
        public int iIdTipoImpuesto { get; set; } = 0;
        public string cCodTipoImpuesto { get; set; } = "";
        public string vDesTipoImpuesto { get; set; } = "";
        public string cSigla { get; set; } = "";

        public double fFactor { get; set; } = 0.0;
        public DateTime dFecInicio { get; set; } = DateTime.Now;
        public DateTime dFecFinal { get; set; } = DateTime.Now;

    }
}
