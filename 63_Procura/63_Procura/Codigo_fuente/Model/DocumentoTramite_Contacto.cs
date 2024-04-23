using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DocumentoTramite_Contacto
    {

        public long iIdDocumento_Contacto { get; set; }
                public long iIdDetalle { get; set; }
        public long iIdDocumento { get; set; }
        public string cCodContacto { get; set; }
        public string vCorreoElectronico { get; set; }

    }
}
