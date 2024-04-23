using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FichaPresupuestal_Paso
    {
        public string CnumProcedimiento { get; set; } = "";
        public DateTime DfecPaso { get; set; } = DateTime.Today;
        public string CPaso { get; set; } = "";
        public string CestadoPaso { get; set; } = "";
    }
}
