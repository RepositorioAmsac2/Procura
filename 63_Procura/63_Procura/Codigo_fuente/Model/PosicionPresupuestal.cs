using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PosicionPresupuestal
    {
        public int IidPosPre { get; set; } = 0;
        public string CcodPosPre { get; set; } = "";
        public string VnomPosPre { get; set; } = "";
        public string CcodClasificador { get; set; } = "";
        public string VnomClasificador { get; set; } = "";
        public string CcodObjetoContratacion { get; set; } = "";
        public string CcodFamiliaPosicionPresupuestal { get; set; } = "";
        public string CcodClaseGasto { get; set; } = "";
        public string VnomClaseGasto { get; set; } = "";
        public string CcodFormato { get; set; } = "";
    }
}
