using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Proyecto_CentroCosto
    {
        public int IidProyecto { get; set; } = 0;
        public int IidProyecto_CentroCosto { get; set; } = 0;
        public string CcodArea { get; set; } = "";
        public string VnomArea { get; set; } = "";

        public string CcodCentroCosto { get; set; } = "";
        public string VnomCentroCosto { get; set; } = "";
    }
}
