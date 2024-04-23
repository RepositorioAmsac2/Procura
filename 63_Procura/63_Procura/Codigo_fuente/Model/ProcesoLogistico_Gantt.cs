using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProcesoLogistico_Gantt
    {
        public int iIdPaso { get; set; } = 0;
        public int iCodTipoPaso { get; set; } = 0;
        public string vDescripcionTipoPaso { get; set; } = "";
        public string cCodPaso { get; set; } = "";
        public string vDesPaso { get; set; } = "";
        public DateTime dFecInicio { get; set; } = DateTime.Now;
        public DateTime dFecFinal { get; set; } = DateTime.Now;
        public int iPredecesora { get; set; } = 0;
        public int iCompletado { get; set; } = 0;
        public string vRecurso { get; set; } = "";
    }
}
