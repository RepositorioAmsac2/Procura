using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FormatoEjecucion_F08
    {
        public int iIdCabecera { get; set; } = 0;
        public string cCodTipoFormato { get; set; } = "";
        public string cCodSubTipoFormato { get; set; } = "";
        public string cCodClaseOrden { get; set; } = "";
        public string cCodPosPre { get; set; } = "";
        public double fEjecutado { get; set; } = 0;

    }
}
