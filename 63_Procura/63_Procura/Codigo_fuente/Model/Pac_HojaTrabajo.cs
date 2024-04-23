using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pac_HojaTrabajo
    {
        public int iIdPac { get; set; } = 0;
        public string cAñoProceso { get; set; } = "";
        public string cCodPac { get; set; } = "";
        public string cCodObjetoContratacion { get; set; } = "";
        public string tDesContratacion { get; set; } = "";
        public string cCodCeGe { get; set; } = "";
        public string cCodCeCo { get; set; } = "";
        public string vDesUnidad { get; set; } = "";
        public string cCodTipoProceso { get; set; } = "";
        public string cColor { get; set; } = "";
        public string tJustificacion { get; set; } = "";
        public DateTime dfecReqLogistica { get; set; } = DateTime.Now;
        public DateTime dfecProConvocatoria { get; set; } = DateTime.Now;
        public string cCodMoneda { get; set; } = "";
        public double fValIncluyeIgv { get; set; } = 0;
        public double fValIncluyeTipoCambio { get; set; } = 0;
        public int iPlazoEjecucionContractual { get; set; } = 0;

    }
}
