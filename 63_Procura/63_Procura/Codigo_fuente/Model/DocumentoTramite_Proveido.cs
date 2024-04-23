using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DocumentoTramite_Proveido
    {
        public long iIdDocumento_Proveido { get; set; }
       public long iIdDocumento { get; set; }
       public  long iIdDetalle { get; set; }
       public string cCodContacto { get; set; }
       public long iCodTipoProveido { get; set; }
       public string tNota { get; set; }

    }
}
