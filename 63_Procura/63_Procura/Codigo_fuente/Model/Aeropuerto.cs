using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Aeropuerto
    {
        public int iIdAeropuerto { get; set; } = 0;
        public string cCodUbiGeo { get; set; } = "";
        public string cCodAeropuerto { get; set; } = "";
        public string vNomAeropuerto { get; set; } = "";
        public string vNomCiudad { get; set; } = "";
        public double fAlturaPie { get; set; } = 0.0;
        public double fALturaMetro { get; set; } = 0.0;
    }
}
