using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Patrimonio_TipoMovimiento
    {
        public int IidTipoMovimientoPatrimonio { get; set; } = 0;
        public string CcodTipoMovimientoPatrimonio { get; set; } = "";
        public string VdesTipoMovimientoPatrimonio { get; set; } = "";
        public int ItipoMovimiento { get; set; } = 1;
        public Boolean BrequiereDepreciacionAnterior { get; set; } = false;
    }
}
