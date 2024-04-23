using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CajaChica
    {
		public string NumeroProceso_Formateado { get; set; } = "";
		public string NumeroProceso { get; set; } = "";
		public string PreparadoPor { get; set; } = "";
		public string NombreCompleto { get; set; } = "";
		public string FechaProceso { get; set; } = "";
		public double MontoAdelanto { get; set; } = 0;
		public string Estado { get; set; } = "";
		public string AprobadoPor { get; set; } = "";
		public string UltimaFechaModif { get; set; } = "";
		public string observaciones { get; set; } = "";

	}
}
