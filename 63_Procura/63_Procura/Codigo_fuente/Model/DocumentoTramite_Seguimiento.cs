using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DocumentoTramite_Seguimiento
    {
        public long iIdDocumento_Seguimiento { get; set; }
        public long iIdDocumento { get; set; }

        public long iCodTipoSeguimiento { get; set; }
        public DateTime dFecha { get; set; }

        public String cHora { get; set; }

        public int iDiasAlerta { get; set; }

    }
}
