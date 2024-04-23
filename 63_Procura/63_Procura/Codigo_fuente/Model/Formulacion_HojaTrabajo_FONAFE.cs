using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Formulacion_HojaTrabajo_FONAFE
    {
        public int iIdFonafe { get; set; } = 0;
		public string cCodEmpresa { get; set; } = "";
        public string cAñoProceso { get; set; } = "";
        public string cPeriodo { get; set; } = "";
        public string cCodLinea { get; set; } = "";
        public double fValor { get; set; } = 0;
    }
}
