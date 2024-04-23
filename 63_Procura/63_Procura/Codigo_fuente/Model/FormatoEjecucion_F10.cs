using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FormatoEjecucion_F10
    {
        public int iIdCabecera { get; set; } = 0;
        public string cCodTipoFormato { get; set; } = "";
        public string cCodSubTipoFormato { get; set; } = "";
        public string cCodClaseOrden { get; set; } = "";
        public string cOrden { get; set; } = "";
        public double fPresupuestoActual { get; set; } = 0;
        public double fPresupuestoInicial { get; set; } = 0;
    }
}
