using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ContratoAnticipo
    {
        public int iIdContrato_Anticipo { get; set; } = 0;
        public string cCodCompañia { get; set; } = "";
        public string cNroContrato { get; set; } = "";
        public string cCodTipoAnticipo { get; set; } = "";
        public string cNroAnticipo { get; set; } = "";
        public string tDesAnticipo { get; set; } = "";
        public string cNrogarantia { get; set; } = "";
        public DateTime dFecAnticipo { get; set; } = DateTime.Today;

        public Int32 iTipoDocumento { get; set; } = 0;

        public string cSigla { get; set; } = "";

        public string cSerDocumento { get; set; } = "";
        public string cNroDocumento { get; set; } = "";

        public DateTime dFecDocumento { get; set; } = DateTime.Now;

        public double fBaseImponible { get; set; } = 0.0;

        public string cCodTipoImpuesto { get; set; } = "";

        public double fImpuesto { get; set; } = 0.0;

        public double fMontoTotal { get; set; } = 0.0;

    }
}
