using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Empleado_Baja
    {
        public int iIdEmpleado_Baja { get; set; } = 0;
        public int iIdEmpleado_Contrato { get; set; } = 0;
        public string cCodEmpleado { get; set; } = "";
        public string cCodMotivoBaja { get; set; } = "";
        public DateTime dFecBaja { get; set; } = DateTime.Now;
        public string tNotaBaja { get; set; } = "";
        public bool bEstado { get; set; } = false;
    }
}
