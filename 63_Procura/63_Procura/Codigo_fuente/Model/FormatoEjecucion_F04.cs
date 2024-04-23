using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FormatoEjecucion_F04
    {
        public int iIdCabecera { get; set; } = 0;
        public string cCodTipoFormato { get; set; } = "";
        public string cCodSubTipoFormato { get; set; } = "";
        public string vTipoValor { get; set; } = "";
        public string cDocPrecedente { get; set; } = "";
        public string cDocReferenciaCP { get; set; } = "";
        public string cDocReferencia { get; set; } = "";
        public string cReferenciaPago { get; set; } = "";
        public string cReferencia { get; set; } = "";
        public string cDocControlPres { get; set; } = "";
        public DateTime dFecActualizacion { get; set; } = DateTime.Now;
        public string cNumPosicionDocRef { get; set; } = "";
        public string cClaseImporte { get; set; } = "";
        public string cCodPosPre { get; set; } = "";
        public string cCodCeGe { get; set; } = "";
        public double fEjecutado { get; set; } = 0;
        public string vTexto { get; set; } = "";
        public double fComprometido { get; set; } = 0;
        public string cFondo { get; set; } = "";
        public string cCuentaMayor { get; set; } = "";
        public string cCLiente { get; set; } = "";
        public string cAcreedor { get; set; } = "";
        public string vNombre1 { get; set; } = "";
        public string vNombre { get; set; } = "";
        public string cIndicadorEstadistico { get; set; } = "";
        public string cNivSaldo { get; set; } = "";
        public string cPosicionIncluida { get; set; } = "";
        public string cClaseDocumento { get; set; } = "";
        public string cOrden { get; set; } = "";

    }
}
