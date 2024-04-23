using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TipoMovimientoPatrimonio
    {
        public int IidTipoMovimientoPatrimonio { get; set; } = 0;
        public string CcodTipoMovimientoPatrimonio { get; set; } = "";
        public string VdesTipoMovimientoPatrimonio  { get; set; } = "";
        public string vSigTipoMovimientoPatrimonio { get; set; } = "";
        public int ItipoMovimiento { get; set; } = 0;
        public Boolean BrequiereDepreciacionAnterior { get; set; } = false;
    }
}
