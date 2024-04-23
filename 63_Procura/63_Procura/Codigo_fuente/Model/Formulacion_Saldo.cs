using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Formulacion_Saldo
    {
        public string CañoProceso { get; set; } = "";
        public string CcodFormulacion { get; set; } = "";
        public double fFormulado_cero { get; set; } = 0.0;
        public double fAjuste { get; set; } = 0.0;
        public double fFormulado_uno { get; set; } = 0.0;
        public double fFormulado_dos { get; set; } = 0.0;
        public double fFormulado_tres { get; set; } = 0.0;
        public double fGasto_cero { get; set; } = 0.0;
        public double fGasto_uno { get; set; } = 0.0;
        public double fGasto_dos { get; set; } = 0.0;
        public double fGasto_tres { get; set; } = 0.0;
        public double FimporteComprometido { get; set; } = 0.0;
        public double FimporteEjecutado { get; set; } = 0.0;
    }
}
