using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Viatico
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
		public string FechaSalida { get; set; } = "";
		public string FechaRetorno { get; set; } = "";
		public string Destino { get; set; } = "";
		public string Procedencia { get; set; } = "";

	}
}
