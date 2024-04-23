using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FormulaPlanilla
    {
        public int iIdFormula { get; set; } = 0;
        public string cCodTipoCalculo { get; set; } = "";
        public string cCodConcepto { get; set; } = "";
        public string tFormulaMensual { get; set; } = "";
        public string tFormulaVacacion { get; set; } = "";
        public string tFormulaGratificacion { get; set; } = "";
        public string tFormulaDiasHoras { get; set; } = "";
        public string cCodClaseConcepto { get; set; } = "";
    }
}
