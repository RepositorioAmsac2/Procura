using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SolicitudViatico_Rendicion_Impuesto
    {
        public int iIdSolicitudViatico_Rendicion_Impuesto { get; set; } = 0;
        public int iIdSolicitudViatico_Rendicion { get; set; } = 0;
        public string cCodSolicitud { get; set; } = "";
        public string cCodIndicadorImpuesto { get; set; } = "";
        public string vNomIndicadorImpuesto { get; set; } = "";
        public double dImpuesto { get; set; } = 0.0;
    }
}
