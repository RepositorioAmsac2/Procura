using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EtapaProyecto
    {
        public int IidEtapaProyecto { get; set; } = 0;
		public string CcodClaseProyecto { get; set; } = "";
        public string VnomClaseProyecto { get; set; } = "";
        public string CcodEtapaProyecto { get; set; } = "";
        public string VnomEtapaProyecto { get; set; } = "";
        public string VnomCortoEtapaProyecto { get; set; } = "";
        public bool BestadoEtapaProyecto { get; set; } = true;
    }
}
