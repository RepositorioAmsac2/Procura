using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProcesoLogistico_Paso_Apertura
    {
        public int iIdProcesoLogistico_Paso_Apertura { get; set; } = 0;
        public int iIdProcesoLogistico_Paso { get; set; } = 0;
        public string cCodTipoAperturaPaso { get; set; } = "";
        public DateTime dFecApertura { get; set; } = DateTime.Today;
        public string cCodEmpleado { get; set; } = "";
        public string cCodEstadoAperturaPaso { get; set; } = "";
        public string tNota { get; set; } = "";
    }
}
