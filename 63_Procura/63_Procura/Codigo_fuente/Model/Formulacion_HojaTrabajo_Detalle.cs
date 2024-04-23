using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Formulacion_HojaTrabajo_Detalle
    {
        public int iIdDetalle { get; set; }
        public int iIdCabecera { get; set; }
        public string cCodTipoFormulacion { get; set; }
        public string cCodSubTipoFormulacion { get; set; }
        public string cCodFormulacion { get; set; }
        public string tDescripcionGasto { get; set; }
        public string iTipoMovimiento { get; set; }
        public string cCodClaseGasto { get; set; }
        public string cCodClasificador { get; set; }
        public string cCodPosPre { get; set; }
        public string cCodFuenteFinanciamiento { get; set; }
        public string cCodProyecto { get; set; }
        public string cCodComponente { get; set; }
        public string cCodCeGe { get; set; }
        public string cCodCeCo_CeGe { get; set; }
        public string cCodCeCo { get; set; }
        public string cTipoOrden { get; set; }
        public string cNumeroOrden { get; set; }
        public double fPia { get; set; }
        public double fSistema { get; set; }
        public double fSaldoOrdenes { get; set; }
        public double fEjecutado { get; set; }
        public double fPendiente { get; set; }
        public double fSaldo { get; set; }

        public String cCodPlanEstrategico { get; set; } = "";
    }
}
