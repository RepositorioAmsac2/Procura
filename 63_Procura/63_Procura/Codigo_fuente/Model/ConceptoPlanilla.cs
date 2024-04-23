using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConceptoPlanilla
    {
        public int iIdConcepto { get; set; } = 0;
        public string cCodEmpresa { get; set; } = "";
        public string cCodConcepto { get; set; } = "";
        public string cCodGrupo { get; set; } = "";
        public string vDesConcepto { get; set; } = "";
        public string cCodTipoMovimientoConcepto { get; set; } = "";
        public string cCodClaseConcepto { get; set; } = "";
        public string cCodTipoConcepto { get; set; } = "";
        public bool bIncluyeImporte { get; set; } = false;
        public string cCodCalculoActual { get; set; } = "";
        public bool bCalculoPromedio { get; set; } = false;
        public string cCodConceptoRTPS { get; set; } = "";
        public string cCodEntidad { get; set; } = "";
    }
}
