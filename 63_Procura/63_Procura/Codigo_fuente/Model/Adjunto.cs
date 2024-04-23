using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Adjunto
    {
        public int iIdAdjunto { get; set; } = 0;
        public int iTipoMovimiento { get; set; } = 0;
        public int iIdPac_Movimiento { get; set; } = 0;
        public string vArchivoOriginal { get; set; } = "";
        public string vArchivoActual { get; set; } = "";
        public string vNombre { get; set; } = "";
        public DateTime dFechaCreacion { get; set; } = DateTime.Today;
        public string cCodEmpleado { get; set; } = "";
        public string cCodEstadoAdjunto { get; set; } = "";
    }
}
