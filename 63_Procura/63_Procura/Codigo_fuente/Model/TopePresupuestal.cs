using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TopePresupuestal
    {
        public int IidTopePresupuestal { get; set; } = 0;
        public string CcodEmpresa { get; set; } = "";
        public string CañoProceso { get; set; } = "";
        public string Cversion { get; set; } = "";
        public string CcodTipoGasto { get; set; } = "";
        public string VnomTipoGasto { get; set; } = "";
        public string CcodFuenteFinanciamiento { get; set; } = "";
        public string VnomFuenteFinanciamiento { get; set; } = "";
        public string CcodProyecto { get; set; } = "";
        public string VnomProyecto { get; set; } = "";
        public string CcodComponente { get; set; } = "";
        public string VnomComponente { get; set; } = "";
        public double FTopePresupuestal { get; set; } = 0.0;
    }
}

