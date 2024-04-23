using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Comite_Integrante_Reemplazo
    {
        public int iIdComite_Integrante { get; set; } = 0;
        public string cCodReemplazo { get; set; } = "";
        public DateTime dFecInicio { get; set; } = DateTime.Today;
        public DateTime dFecFinal { get; set; } = DateTime.Today;
        public string cCodEstadoReemplazoComite { get; set; } = "";
        public string cCodEstadoComiteIntegrante { get; set; } = "";
    }
}
