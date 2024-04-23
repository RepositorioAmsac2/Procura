using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConformidadDocumentoTributario
    {
        public int iIdContratoConformidad_Documento { get; set; } = 0;
        public string CcodCompañia { get; set; } = "";
        public string CnroConformidad { get; set; } = "";
        public int ITipoDocumento { get; set; } = 0;
        public string VdesDocumento { get; set; } = "";
        public string CserDocumento { get; set; } = "";
        public string CnumDocumento { get; set; } = "";
        public DateTime Dfecdocumento { get; set; } = DateTime.Now;
        public string CcodTipoImpuesto { get; set; } = "";
        public double fAfecto { get; set; } = 0.0;
        public double fImpuesto { get; set; } = 0.0;
        public double fSubTotal { get; set; } = 0.0;
        public double fInafecto { get; set; } = 0.0;
        public double fTotal { get; set; } = 0.0;

    }
}
