using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EntregableCabecera
    {
        public int IidEntregableCabecera { get; set; } = 0;
        public string cCodCompañia { get; set; } = "";
        public string cNroContrato { get; set; } = "";
        public string CNroEntregable { get; set; } = "";
        public string TDesEntregable { get; set; } = "";
        public int ITipoDuracion { get; set; } = 1; // 1 Dias Calendario 2 Dias Habiles
        public int IDiasDuracion { get; set; } = 0;
        public int IDiasDuracionTotal { get; set; } = 0;
        public int ITipoFactor { get; set; } = 1; // 1 Porcentaje 2 Importe
        public double FFactor { get; set; } = 0.0;
        public double FImporte { get; set; } = 0.0;
        public string DFecInicio { get; set; } = "";
        public string DFecFinal { get; set; } = "";

    }
}
