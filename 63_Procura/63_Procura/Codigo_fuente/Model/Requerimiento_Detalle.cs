using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Requerimiento_Detalle
    {
        public int IidRequerimiento_Cabecera { get; set; } = 0;
        public int IidRequerimiento_Detalle { get; set; } = 0;
        public string CcodFormulacion { get; set; } = "";
        public string CañoProceso { get; set; } = "";
        public string CnumeroAño { get; set; } = "";
        public double Fimporte { get; set; } = 0.0;
        public Boolean bIncluyeImpuesto { get; set; } = false;
        public Double FfactorImpuesto { get; set; } = 0.0;
        public string CcodUsuario { get; set; } = "";
        public string CnumSolicitud { get; set; } = "";
    }
}
