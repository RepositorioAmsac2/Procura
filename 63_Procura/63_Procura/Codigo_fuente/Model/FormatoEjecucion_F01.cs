using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class FormatoEjecucion_F01
	{
		public int iIdCabecera { get; set; } = 0;
		public string cCodTipoFormato { get; set; } = "";
		public string cCodSubTipoFormato { get; set; } = "";
		public string cCodCuentaContable { get; set; } = "";
		public string vNomCuentaContable { get; set; } = "";
		public string cCodConcepto { get; set; } = "";
		public string vNomConcepto { get; set; } = "";
		public double fBaseImponible_Antes { get; set; } = 0;
		public double fIgv_Antes { get; set; } = 0;
		public double fOtros_Antes { get; set; } = 0;
		public double fBaseImponible { get; set; } = 0;
		public double fIgv { get; set; } = 0;
		public double fOtros { get; set; } = 0;
	}
}
