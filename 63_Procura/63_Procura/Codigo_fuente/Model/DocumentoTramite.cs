using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DocumentoTramite
    {
        public long iTipoTramite { get; set; }
        public long iIdDocumento { get; set; }
        public long iTipoDocumento { get; set; }
        public string cNumDocumento { get; set; }
        public DateTime dFecDocumento { get; set; }
        public string tAsunto { get; set; }
        public string tReferencia { get; set; }
        public byte[] tMensaje { get; set; }
        public long iCodTipoSeguimiento { get; set; }
        public long iCodImportancia { get; set; }
        public string cCodContacto { get; set; }
        public string cCodUsuario { get; set; }
        public string cCodCeges { get; set; }

    }
}
