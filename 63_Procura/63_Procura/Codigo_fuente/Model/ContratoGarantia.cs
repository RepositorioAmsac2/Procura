using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ContratoGarantia
    {
        public int iIdContrato_Garantia { get; set; } = 0;
        public string cCodCompañia { get; set; } = "";
        public string cNroContrato { get; set; } = "";
        public string cNroGarantia { get; set; } = "";
        public string tDesGarantia { get; set; } = "";
        public DateTime dFecGarantia { get; set; } = DateTime.Now;
        public string cCodTipoGarantia { get; set; } = "";
        public string cCodClaseGarantia { get; set; } = "";
        public string cCodEntidadFinanciera { get; set; } = "";
        public double fMontoTotal { get; set; } = 0.0;
        public DateTime dFecInicio { get; set; } = DateTime.Now;
        public DateTime dFecFinal { get; set; } = DateTime.Now;

    }
}
