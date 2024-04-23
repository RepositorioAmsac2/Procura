using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DocumentoTramite_Entidad
    {
        public int iIdDocumento_Entidad { get; set; }
		public long iIdDocumento { get; set; }
        public long iTipoDocumentoIdentidad { get; set; }
        public string cCodEntidad { get; set; }
        public string vDesEntidad { get; set; }
        public long iTipoDocumento { get; set; }
        public string cNumDocumento { get; set; }
        public DateTime dFecDocumento { get; set; }
    }
}
