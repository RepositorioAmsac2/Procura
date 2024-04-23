using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Paso_Ajuste
    {
        public string CcodCeGe { get; set; } = "";
        public string CnumAjuste { get; set; } = "";
        public DateTime DfecPaso { get; set; } = DateTime.Today;
        public string CPaso { get; set; } = "";
        public string CestadoPaso { get; set; } = "";
        public string CcodEmpleado { get; set; } = "";
    }
}
