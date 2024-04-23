using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Proyecto_FuenteFinanciamiento
    {
        public int IidProyecto_FuenteFinanciamiento { get; set; } = 0;
        public string cCodProyecto { get; set; } = "";
        public string CcodFuenteFinanciamiento { get; set; } = "";
        public DateTime DfecInicio { get; set; } = DateTime.Today;
        public DateTime DfecTermino { get; set; } = DateTime.Today;
        public double FimporteFinanciamiento { get; set; } = 0.0;
        public string VclaseGasto { get; set; } = "";
        public Boolean bEstado { get; set; } = false;

    }
}
