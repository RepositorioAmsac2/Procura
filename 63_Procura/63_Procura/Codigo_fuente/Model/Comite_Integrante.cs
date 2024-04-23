using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Comite_Integrante
    {
        public int iIdComite_Integrante { get; set; } = 0;
		public int iIdComite { get; set; } = 0;
        public string cCodTipoIntegrante { get; set; } = "";
        public string cCodIntegrante { get; set; } = "";
        public string cCodCargoComite { get; set; } = "";
        public string cCodCondicionComite { get; set; } = "";
        public bool bFirmaActa { get; set; } = false;

        public string cCodEstadoComiteIntegrante { get; set; } = "";
    }
}
