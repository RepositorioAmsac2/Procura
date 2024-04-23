using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Conformidadgarantia
    {
        public int iIdContratoConformidad_Garantia { get; set; } = 0;
        public string cCodCompañia { get; set; } = "";
        public string cNroConformidad { get; set; } = "";
        public double fImporteGarantia { get; set; } = 0.0;
        public string tComentarioGarantia { get; set; } = "";

    }
}
