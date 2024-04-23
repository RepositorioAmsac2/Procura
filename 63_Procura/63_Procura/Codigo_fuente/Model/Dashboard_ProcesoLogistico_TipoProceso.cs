using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Dashboard_ProcesoLogistico_TipoProceso
    {
        public string Version { get; set; } = "";
        public string Gerencia { get; set; } = "";
        public string Area { get; set; } = "";
        public string Procedimiento { get; set; } = "";
        public string ProcesoLogistico { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public string TipoProceso { get; set; } = "";
        public string Mes { get; set; } = "";
        public int Cantidad { get; set; } = 0;
        public double PrecioEstimado { get; set; } = 0;
    }
}
