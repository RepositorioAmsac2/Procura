using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class FormatoEjecucion_F03
	{
		public int iIdCabecera { get; set; } = 0;
		public string cCodTipoFormato { get; set; } = "";
		public string cCodSubTipoFormato { get; set; } = "";
		public string cCodCuentaContable { get; set; } = "";
		public string cNumDocumento { get; set; } = "";
		public DateTime dFecDocumento { get; set; } = DateTime.Now;
		public DateTime dFecContabilizacion { get; set; } = DateTime.Now;
		public string cCodClaseDocumento { get; set; } = "";
		public string vAsignacion { get; set; } = "";
		public string vReferencia { get; set; } = "";
		public string cCuentaAcreedorNIF { get; set; } = "";
		public string vCuentaAcreedorNombre { get; set; } = "";
		public string vTexto { get; set; } = "";
		public string vSegmento { get; set; } = "";
		public string cMoneda { get; set; } = "";
		public double fImporteMoneda { get; set; } = 0;
		public double fImporteLibroMayor { get; set; } = 0;
		public string vNombreUsuario { get; set; } = "";

	}
}
