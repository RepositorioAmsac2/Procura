using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FormatoEjecucion_F05
    {
        public int iIdCabecera { get; set; } = 0;
        public string cCodTipoFormato { get; set; } = "";
        public string cCodSubTipoFormato { get; set; } = "";
        public string cCodCeGe { get; set; } = "";
        public string cOrden { get; set; } = "";
        public double fImpSoles { get; set; } = 0;
        public string cCodPosPre { get; set; } = "";
        public string cCuenta { get; set; } = "";
        public string cNumDocumento { get; set; } = "";
        public DateTime dFecDocumento { get; set; } = DateTime.Now;
        public string vTexto { get; set; } = "";

    }
}
