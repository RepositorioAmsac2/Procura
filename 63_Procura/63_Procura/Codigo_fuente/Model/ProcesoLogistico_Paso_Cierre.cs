using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProcesoLogistico_Paso_Cierre
    {
        public int iIdProcesoLogistico_Paso_Cierre { get; set; } = 0;

        public int iIdProcesoLogistico_Paso { get; set; } = 0;
        public string cCodTipoCierrePaso { get; set; } = "";

        public string vDesTipoCierrePaso { get; set; } = "";
        public DateTime dFecCierre { get; set; } = DateTime.Today;
        public string cCodEmpleado { get; set; } = "";
        public string cCodEstadoCierrePaso { get; set; } = "";
        public string tNota { get; set; } = "";
    }
}
