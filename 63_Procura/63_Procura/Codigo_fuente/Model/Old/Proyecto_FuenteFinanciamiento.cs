using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Proyecto_FuenteFinanciamiento
    {
        public int IidProyecto { get; set; } = 0;
        public int IidProyecto_FuenteFinanciamiento { get; set; } = 0;
        public string CcodFuenteFinanciamiento { get; set; } = "";
        public string VnomFuenteFinanciamiento { get; set; } = "";

        public double FimporteFinanciamiento { get; set; } = 0.0;

    }
}
