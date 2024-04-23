using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProcesoLogistico_Cabecera_Adjunto
    {
        public int IidAdjunto { get; set; } = 0;
        public string CañoProceso { get; set; } = "";
        public string Cversion { get; set; } = "";
        public string VarchivoOriginal { get; set; } = "";
        public string VarchivoActual { get; set; } = "";
        public string Vnombre { get; set; } = "";
        public DateTime DfechaCreacion { get; set; } = DateTime.Today;
        public string CcodEmpleado { get; set; } = "";
        public string CcodEstadoAdjunto { get; set; } = "";
        public string Tnota { get; set; } = "";
    }
}
