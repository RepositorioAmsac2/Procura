using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FormatoEjecucion_F07
    {
        public int iIdCabecera { get; set; } = 0;
        public string cCodTipoFormato { get; set; } = "";
        public string cCodSubTipoFormato { get; set; } = "";
        public string cOrden { get; set; } = "";
        public string cNumDocumento { get; set; } = "";
        public string cCodClaseCoste { get; set; } = "";
        public double fEjecutado { get; set; } = 0;
        public string vTextoBreve { get; set; } = "";
        public DateTime dFecEntrada { get; set; } = DateTime.Now;
        public string cCodMaterial { get; set; } = "";


    }
}
