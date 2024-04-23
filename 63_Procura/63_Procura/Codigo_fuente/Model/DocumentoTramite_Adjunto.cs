using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DocumentoTramite_Adjunto
    {
        public long iIdDocumento_Asjunto { get; set; } = 0;
        public long iIdDetalle { get; set; } = 0;
        public long iIdDocumento { get; set; } = 0;
        public string vNombreArchivo { get; set; } = "";
        public string vGuid { get; set; } = "";
        public int iVersion { get; set; } = 0;
        public string vArchivo { get; set; } = "";
        public DateTime dFechaGrabacion { get; set; } = DateTime.Today;
        public long iTamañoArchivo { get; set; } = 0;
        public string cTipoDatoArchivo { get; set; } = "";

    }
}
