using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fase_ActividadProyecto
    {
        public int IidFaseProyecto { get; set; } = 0;
        public int IidFase_ActividadProyecto { get; set; } = 0;
        public string CcodActividadProyecto { get; set; } = "";
        public string VnomActividadProyecto { get; set; } = "";
        public string VnomCortoActividadProyecto { get; set; } = "";

        public int Inivel_ActividadProyecto { get; set; } = 1;
        public bool BestadoActividadProyecto { get; set; } = true;
    }
}
