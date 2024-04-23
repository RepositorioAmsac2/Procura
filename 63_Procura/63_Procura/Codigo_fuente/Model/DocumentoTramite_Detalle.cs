using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DocumentoTramite_Detalle
    {
        public long iIdDocumento { get; set; }
        public long iIdDocumento_Detalle { get; set; }
        public long iIdDetalle { get; set; }
        public long iTipoMovimiento { get; set; }
        public DateTime dFecDetalle { get; set; }
        public string cCodEmisor { get; set; }
        public string cCodReceptor { get; set; }
        public long iCodEstado { get; set; }
        public bool bActivo { get; set; }
        public bool bLeido { get; set; }
        public bool bAdjunto { get; set; }
        public bool bSeguimiento { get; set; }
        public int iTipoContacto { get; set; }

    }
}
