using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProcesoLogistico_Paso_CambioEstado
    {
        public int iIdProcesoLogistico_Estado { get; set; }  = 0;

        public string cNumProcedimiento { get; set; } = "";
        public int iIdProcesoLogistico_Paso { get; set; } = 0;
        public string cCodPaso_Actual { get; set; } = "";
        public string cCodPaso_Inicial { get; set; } = "";
        public string cCodPaso_Final { get; set; } = "";
        public string cCodEstadoPaso { get; set; } = "";
        public string tNota { get; set; } = "";
    }
}
