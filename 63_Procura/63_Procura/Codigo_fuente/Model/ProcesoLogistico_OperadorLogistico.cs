using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProcesoLogistico_OperadorLogistico
    {
        public int iIdProcesoLogistico_OperadorLogistico { get; set; } = 0;

        public string cAñoProceso { get; set; } = "";
        public string cCodProcesoLogistico { get; set; } = "";
        public string cCodOperadorLogistico { get; set; } = "";

        public string vApeOperadorLogistico { get; set; } = "";
        public string cCodEstadoOperadorLogistico { get; set; } = "";
        public string vDesEstadoOperadorLogistico { get; set; } = "";
        public string cCodTipoProceso { get; set; } = "";
        public string vDesTipoProceso { get; set; } = "";

        public string tDesContratacion { get; set; } = "";
    }
}
