using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ValorEstimado
    {
		public int iIdValorEstimado { get; set; } = 0;
		public string cCodEmpresa { get; set; } = "";
		public string cAñoProceso { get; set; } = "";
		public string cNumProcedimiento { get; set; } = "";
		public string cCodProveedor { get; set; } = "";
		public string CcodTipoMoneda { get; set; } = "";
		public double FtipoCambio { get; set; } = 0.0;
		public double FprecioUnitario_Local { get; set; } = 0.0;
		public double FprecioUnitario_Extranjero { get; set; } = 0.0;
		public string CcodTipoImpuesto { get; set; } = "";
		public double Fimpuesto_Local { get; set; } = 0.0;
		public double Fimpuesto_Extranjero { get; set; } = 0.0;
		public DateTime dFecEstimacion { get; set; } = DateTime.Now;
		public string tObservacion { get; set; } = "";
		public string cCodEstadoValorEstimado { get; set; } = "";
	}
}
