using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Patrimonio_Origen
    {
        public int IidPatrimonio_Origen { get; set; } = 0;
        public string CcodPatrimonio { get; set; } = "";
        public string CcodEntidad { get; set; } = "";
        public string CcodTipoDocumento { get; set; } = "";
        public string CserDocumento { get; set; } = "";
        public string CnumDocumento { get; set; } = "";
        public DateTime DfecDocumento { get; set; } = DateTime.Today;
        public string Tnota { get; set; } = "";
        public Boolean EsDocumentoInicial { get; set; } = false;

    }
}
