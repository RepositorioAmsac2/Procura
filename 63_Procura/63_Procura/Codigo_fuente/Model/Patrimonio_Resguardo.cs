using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Patrimonio_Resguardo
    {
        public int IidPatrimonio_Resguardo { get; set; } = 0;
        public string CcodPatrimonio { get; set; } = "";
        public string CcodResponsable { get; set; } = "";
        public DateTime DfecResguardo { get; set; } = DateTime.Today;
        public bool Bestado { get; set; } = false;
    }
}
