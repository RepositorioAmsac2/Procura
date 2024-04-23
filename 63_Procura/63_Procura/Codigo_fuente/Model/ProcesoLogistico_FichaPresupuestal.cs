using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProcesoLogistico_FichaPresupuestal
    {
		public string cCodEmpresa { get; set; } = "";
		public string cNumProcedimiento { get; set; } = "";
		public double fImporte { get; set; } = 0.0;
		public DateTime dFecMovimiento { get; set; } = DateTime.Now;
		public string cCodEmpleado { get; set; } = "";
		public string tObservacion { get; set; } = "";
		public string cCodEstadoProcesoLogistico_FichaPresupuestal { get; set; } = "";

		public int iIdPaso { get; set; } = 0;
	}
}
