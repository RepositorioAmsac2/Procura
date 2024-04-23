using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SolicitudViatico_OtroGasto
    {
        public int iIdSolicitudViatico_OtroGasto { get; set; } = 0;
        public string cCodPersonal { get; set; } = "";
        public string cCodSolicitud { get; set; } = "";
        public string cCodConcepto { get; set; } = "";
		public string vNomConcepto { get; set; } = "";
        public double dMonto { get; set; } = 0.0;
        public DateTime dfechaRegistro { get; set; } = DateTime.Now;
    }
}
