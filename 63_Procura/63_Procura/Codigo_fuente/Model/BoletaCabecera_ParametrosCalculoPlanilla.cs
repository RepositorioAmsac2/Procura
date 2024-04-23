using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BoletaCabecera_ParametrosCalculoPlanilla
    {
        public string cAñoProceso { get; set; } = "";
        public string cPeriodoProceso { get; set; } = "";
        public string vDesPeriodoProceso { get; set; } = "";
        public DateTime dPeriodoInicial { get; set; } = DateTime.Now;
        public DateTime dPeriodoFinal { get; set; } = DateTime.Now;
        public string cCodTipoPlanilla { get; set; } = "";
        public string vDesTipoPlanilla { get; set; } = "";
        public string cCodPeriodicidadRemunerativa { get; set; } = "";
    }
}
