using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Formulacion_Ajuste_Detalle
    {
        public int IidFormulacion_Ajuste_Cabecera { get; set; } = 0;
        public int IidFormulacion_Ajuste_Detalle { get; set; } = 0;
        public string CcodCompañia { get; set; } = "";
	    public string CcodFormulacion { get; set; } = "";
        public string CtipoMovimiento { get; set; } = "";
        public string CañoProceso { get; set; } = "";
         public string TdescripcionGasto { get; set; } = "";
        public double Fimporte { get; set; } = 0.0;
        public string CcodEmpleado { get; set; } = "";
    }
}
