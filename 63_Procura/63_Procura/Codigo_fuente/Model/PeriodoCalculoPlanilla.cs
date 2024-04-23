using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PeriodoCalculoPlanilla
    {
        public int iIdPeriodoCalculo { get; set; } = 0;
        public string cAñoProceso { get; set; } = "";
        public string cCodTipoCalculo { get; set; } = "";
        public string cPeriodoProceso { get; set; } = "";
        public DateTime dPeriodoInicial { get; set; } = DateTime.Now;
        public DateTime dPeriodoFinal { get; set; } = DateTime.Now;

        public int iUltimaSemana  { get; set; } = 0;
    }
}
