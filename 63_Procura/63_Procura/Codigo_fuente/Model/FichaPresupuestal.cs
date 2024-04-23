using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FichaPresupuestal
    {
        // Valor Estimado
        public string CNumProcedimiento { get; set; } = "";
        public string DFecMovimiento { get; set; } = "";
        public string TDesContratacion { get; set; } = "";
        public double FPrecioEstimado { get; set; } = 0.0;

        // Proveedor
        public string RUC { get; set; } = "";
		public string RazonSocial { get; set; } = "";
        public string Direccion { get; set; } = "";

        //Requerimiento
        public string CNumRequerimiento { get; set; } = "";
        public string DFecRequerimiento { get; set; } = "";
        public string VTipoAdquisicion { get; set; } = "";
        public double TImporte { get; set; } = 0;
        public string TDetalleContratacion { get; set; } = "";
        public string TJustificacion { get; set; } = "";
        public double Fresto { get; set; } = 0;
        public double Frequerimiento { get; set; } = 0;
		public string CnumRequerimiento_Nuevo { get; set; } = "";
        public string DfecRequerimiento_Nuevo { get; set; } = "";
    }
}
