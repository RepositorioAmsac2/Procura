using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Requerimiento_Detalle_Cronograma
    {
        public int IidRequerimiento_Detalle { get; set; } = 0;
        public string CañoProceso { get; set; } = "";
        public double Fene { get; set; } = 0;
        public double Ffeb { get; set; } = 0;
        public double Fmar { get; set; } = 0;
        public double Fabr { get; set; } = 0;
        public double Fmay { get; set; } = 0;
        public double Fjun { get; set; } = 0;
        public double Fjul { get; set; } = 0;
        public double Fago { get; set; } = 0;
        public double Fset { get; set; } = 0;
        public double Foct { get; set; } = 0;
        public double Fnov { get; set; } = 0;
        public double Fdic { get; set; } = 0;

    }
}
