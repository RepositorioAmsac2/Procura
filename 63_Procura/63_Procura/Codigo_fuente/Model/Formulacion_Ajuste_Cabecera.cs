using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Formulacion_Ajuste_Cabecera
    {
        public int IidFormulacion_Ajuste_Cabecera { get; set; } = 0;
        public string CañoProceso { get; set; } = "";
        public string CnumAjuste { get; set; } = "";
        public string CnumProcedimiento { get; set; } = "";
        public DateTime DfecAjuste { get; set; } = DateTime.Today;
        public string CcodCeGe { get; set; } = "";
        public string CcodEmpleado { get; set; } = "";
        public string Tmotivo { get; set; } = "";
        public string CtipoAjuste { get; set; } = "";
    }
}
