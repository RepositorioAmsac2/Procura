using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class adenda
    {
        public int iIdAdenda { get; set; } = 0;
        public string cCodCompañia { get; set; } = "";
        public string cNroContrato { get; set; } = "";
        public string cNroAdenda { get; set; } = "";
        public string tDesAdenda { get; set; } = "";
        public DateTime dFecAdenda { get; set; } = DateTime.Now;
        public string cCodTipoAdenda { get; set; } = "";
        public string vDesTipoAdenda { get; set; } = "";
        public string cNroEntregable { get; set; } = "";
        public int iDias { get; set; } = 0;
        public double fImporte { get; set; } = 0.0;

    }
}
