using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Formulacion
    {
        public string CcodCompañia { get; set; } = "";
        public string CcodFormulacion { get; set; } = "";
        public string TdescripcionGasto { get; set; } = "";
        public int ItipoMovimiento { get; set; } = 0;
        public string CañoProceso { get; set; } = "";
        public string CcodFuenteFinanciamiento { get; set; } = "";
        public string VnomFuenteFinanciamiento { get; set; } = "";
        public string CcodCeGe { get; set; } = "";
        public string VnomCeGe { get; set; } = "";
        public string CcodCeCo { get; set; } = "";
        public string VnomCeCo { get; set; } = "";
        public string CcodProyecto { get; set; } = "";
        public string VnomProyecto { get; set; } = "";
        public string CcodComponente { get; set; } = "";
        public string VnomComponente { get; set; } = "";
        public string CcodPosPre { get; set; } = "";
        public string VnomPosPre { get; set; } = "";
        public string CcodFamiliaPosPre { get; set; } = "";
        public string VnomFamiliaPosPre { get; set; } = "";
        public string CcodClasificador { get; set; } = "";
        public string VnomClasificador { get; set; } = "";
        public string CcodClaseGasto { get; set; } = "";
        public string VnomClaseGasto { get; set; } = "";
        public double Fimporte { get; set; } = 0.0;
        public string CtipoFormulario { get; set; } = "";
    }
}
