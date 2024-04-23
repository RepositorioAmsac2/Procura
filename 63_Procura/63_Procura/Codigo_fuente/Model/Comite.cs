using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Comite
    {
        public int iIdComite { get; set; } = 0;
		public int iIdDocumentoComite { get; set; } = 0;
        public string cNumProcedimiento { get; set; } = "";
        public string tDesContratacion { get; set; } = "";
        public string cCodTipoComite { get; set; } = "";
        public string vDesTipoComite { get; set; } = "";
        public string cCodEstadoComite { get; set; } = "";
        public int iIntegrante { get; set; } = 0;
    }
}
