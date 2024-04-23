using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TipoDocumento
    {
        public int iIdTipoDocumento { get; set; } = 0;
        public long iTipoDocumento { get; set; } = 0;
        public string vDesTipoDocumento { get; set; } = "";
        public string cSigla { get; set; } = "";

        public bool bEsDocumentoTributario { get; set; }
        public int iLongitudSerie { get; set; } = 5;
        public int iLongitudDocumento { get; set; } = 15;

        public string cCodTipoImpuesto { get; set; } = "";

    }
}
