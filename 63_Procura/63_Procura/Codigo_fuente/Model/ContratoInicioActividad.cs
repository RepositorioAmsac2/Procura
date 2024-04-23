using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ContratoInicioActividad
    {
        public int IidContrato_InicioActividad { get; set; } = 0;
        public string cCodCompañia { get; set; } = "";
        public string cNroContrato { get; set; } = "";
        public DateTime dFecInicio { get; set; } = DateTime.Now;
        public string tNota { get; set; } = "";
        public bool bActivo { get; set; } = true;

    }
}
