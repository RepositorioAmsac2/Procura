using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Proyecto_Etapa
    {
        public int IidProyecto_Etapa { get; set; } = 0;
        public int IidProyecto { get; set; } = 0;
        public DateTime DfechaInicio { get; set; } = DateTime.Today;
        public DateTime DfechaFin { get; set; } = DateTime.Today;
        public DateTime DfechaFinalizado { get; set; } = DateTime.Today;
        public string CcodEtapaProyecto { get; set; } = "";
        public string CcodTareaProyecto { get; set; } = "";
        public string Tdescripcion { get; set; } = "";


    }
}
