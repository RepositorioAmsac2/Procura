using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Comite_Resolucion
    {
        public int iIdDocumentoComite { get; set; } = 0;
		public string cPerProceso { get; set; } = "";
        public DateTime dFecDocumento { get; set; } = DateTime.Today;
        public string cCodTipoDocumento { get; set; } = "";
        public string cNumDocumento { get; set; } = "";
		public string tNota { get; set; } = "";
        public bool bEstado { get; set; } = false;
    }
}
