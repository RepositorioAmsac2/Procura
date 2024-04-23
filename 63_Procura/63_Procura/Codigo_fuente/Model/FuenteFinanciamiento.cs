using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FuenteFinanciamiento
    {
        public int IidFuenteFinanciamiento { get; set; } = 0;

        public string CcodEmpresa { get; set; } = "";
        public string CcodFuenteFinanciamiento { get; set; } = "";
        public string VnomFuenteFinanciamiento { get; set; } = "";
    }
}
