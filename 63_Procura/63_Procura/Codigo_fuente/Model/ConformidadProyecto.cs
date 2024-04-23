using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConformidadProyecto
    {
        public int iIdConformidad_Proyecto { get; set; } = 0;
        public string cCodCompañia { get; set; } = "";
        public string cNroConformidad { get; set; } = "";
        public string cCodProyecto { get; set; } = "";
        public string cCodFuenteFinanciamiento { get; set; } = "";
        public string cCodFormulacion { get; set; } = "";
        public double fImporteConformidad { get; set; } = 0.0;

    }
}
