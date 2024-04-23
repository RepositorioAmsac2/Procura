using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class ListaReasignacion
	{
		public string LineaFormulacion { get; set; } = "";
		public double Importe_Total { get; set; } = 0;
		public double Importe { get; set; } = 0;
		public double Importe_Anterior { get; set; } = 0;
		public string Proyecto { get; set; } = "";
		public string Componente { get; set; } = "";
		public string ClaseGasto { get; set; } = "";
		public string Clasificador { get; set; } = "";
		public string PosicionPresupuestal { get; set; } = "";
		public string FuenteFinanciamiento { get; set; } = "";
		public string CentroCosto { get; set; } = "";
		public string cCodFormulacion { get; set; } = "";

	}
}
