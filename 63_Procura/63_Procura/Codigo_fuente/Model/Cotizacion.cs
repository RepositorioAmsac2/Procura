using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cotizacion
    {
        public int iIdCotizacion { get; set; } = 0;

        public string cCodEmpresa  { get; set; } = "";
        public string cNumProcedimiento { get; set; } = "";
        public string cCodProveedor { get; set; } = "";
        public string cCodTipoMoneda { get; set; } = "LO";
        public double fImporteCotizacion { get; set; } = 0.0;
        public DateTime dFecRecepcion { get; set; } = DateTime.Now;
        public string tObservacion { get; set; } = "";
    }
}
