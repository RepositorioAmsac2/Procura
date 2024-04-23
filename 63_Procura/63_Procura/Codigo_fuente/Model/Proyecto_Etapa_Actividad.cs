using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Proyecto_Etapa_Actividad
    {
        public int IidProyecto_Etapa_Actividad { get; set; } = 0;
        public int IidProyecto_Etapa { get; set; } = 0;
        public string CcodActividad { get; set; } = "";
        public string VnomActividad { get; set; } = "";
        public string CcodTipoActividad { get; set; } = "";
        public string VnomTipoActividad { get; set; } = "";

        public DateTime DfecInicio { get; set; } = DateTime.Today;

        public string ChoraInicio { get; set; } = "";
        public DateTime DfecFin { get; set; } = DateTime.Today;
        public string ChoraFin { get; set; } = "";
        public string tComentario { get; set; } = "";

    }
}
