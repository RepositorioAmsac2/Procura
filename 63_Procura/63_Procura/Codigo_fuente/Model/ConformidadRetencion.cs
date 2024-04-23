using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConformidadRetencion
    {
        public int iIdContratoConformidad_Retencion { get; set; } = 0;
        public string cCodCompañia { get; set; } = "";
        public string cNroConformidad { get; set; } = "";
        public double fImporteRetencion { get; set; } = 0.0;
        public string tComentarioRetencion { get; set; } = "";

    }
}
