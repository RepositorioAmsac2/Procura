using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Formato_Proyecto
    {
		public int iIdTraslado { get; set; } = 0;
		public string cCodEmpresa { get; set; } = "";
		public string cAñoProceso { get; set; } = "";
		public string cCodCeGe { get; set; } = "";
		public string cCodCeCo { get; set; } = "";
		public string cOrdenInversion { get; set; } = "";
		public string cCodIdea { get; set; } = "";
		public string cCodUnico { get; set; } = "";
		public string cEsTransferencia { get; set; } = "";
		public string cTipoInversion { get; set; } = "";
		public string cNaturaleza { get; set; } = "";
		public string vNombreInversion { get; set; } = "";
		public string cDepartamento { get; set; } = "";
		public string cProvincia { get; set; } = "";
		public string cDistrito { get; set; } = "";
		public double fCostoInversion { get; set; } = 0;
		public string cModalidadEjecucion { get; set; } = "";
		public string cUnidadEjecutoraInversion { get; set; } = "";
		public string cUnidadEjecutoraPresupuesto { get; set; } = "";
		public string cFuenteFinanciamiento { get; set; } = "";
		public DateTime dFechaInicioEjecucion { get; set; } = DateTime.Now;
		public DateTime dFechaFinalEjecucion { get; set; } = DateTime.Now;
	}
}
