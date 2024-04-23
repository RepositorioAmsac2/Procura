using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FormatoEjecucion_F02
    {
		public int iIdCabecera { get; set; } = 0;
		public string cCodTipoFormato { get; set; } = "";
		public string cCodSubTipoFormato { get; set; } = "";
		public string cCodCuentaContable { get; set; } = "";
		public string vNomCuentaContable { get; set; } = "";
		public double fDebe { get; set; } = 0;
		public double fHaber { get; set; } = 0;

	}
}
