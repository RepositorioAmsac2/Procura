using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EjecucionPresupuestal_Detalle
    {
        public int IidCabecera { get; set; } = 0;
        public int IidDetalle { get; set; } = 0;
        public string CcodPosPre { get; set; } = "";
        public string CcodCeGe { get; set; } = "";
        public string Corden { get; set; } = "";
        public double Fimporte { get; set; } = 0;
    }
}
