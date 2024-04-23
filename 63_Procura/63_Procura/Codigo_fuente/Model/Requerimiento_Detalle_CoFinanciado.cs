using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Requerimiento_Detalle_CoFinanciado
    {
        public int IidRequerimiento_Cofinanciado { get; set; } = 0;
        public string CnumRequerimiento { get; set; } = "";
        public string CcodPosPre { get; set; } = "";
        public string CcodClasificador { get; set; } = "";
        public string CcodFuenteFinanciamiento { get; set; } = "";
        public string CcodCeCo { get; set; } = "";
        public string CcodServicio { get; set; } = "";
        public string CcodMaterial { get; set; } = "";
        public double Fimporte { get; set; } = 0.0;
        public string Tnota { get; set; } = "";
    }
}
