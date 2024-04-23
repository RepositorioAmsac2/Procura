using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProcesoLogistico_Paso
    {
        public int iIdProcesoLogistico_Paso { get; set; } = 0;
        public string cNumProcedimiento { get; set; } = "";
        public int iIdPaso { get; set; } = 0;
        public string cCodEmpleado { get; set; } = "";
        public string vDesPaso { get; set; } = "";
        public DateTime dFecInicio { get; set; } = DateTime.Today;
        public DateTime dFecFinal { get; set; } = DateTime.Today;
        public DateTime dFecApertura { get; set; } = DateTime.Today;

        public DateTime dFecCierre { get; set; } = DateTime.Today;
        public string tNota { get; set; } = "";

    }
}
