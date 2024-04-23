using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProcesoLogistico_Duracion
    {
        public int IidProcesoLogistico_Duracion { get; set; } = 0;
        public string CnumProcedimiento { get; set; } = "";
        public string CcodPaso { get; set; } = "";
        public int IidPasoActoPrevio { get; set; } = 0;
        public int Iduracion { get; set; } = 0;
        public int ItipoDuracion { get; set; } = 1;
        public int IdiaEmail { get; set; } = 0;
        public string CcodEstadoDuracionPaso { get; set; } = "";
        public int Iorden { get; set; } = 0;
    }
}
