using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Proyecto
    {
        public int IidProyecto { get; set; } = 0;

        public int ItipoProyecto { get; set; } = 1;
        public string CcodGrupoProyecto { get; set; } = "";
        public string VnomGrupoProyecto { get; set; } = "";

        public string CcodProyecto { get; set; } = "";

        public string TnomProyecto { get; set; } = "";
        public string VnomCortoProyecto { get; set; } = "";

        public string CcodMacroProyecto { get; set; } = "";

        public string VnomMacroProyecto { get; set; } = "";

        public string TObjProyecto { get; set; } = "";

        public string CcodNaturalezaProyecto { get; set; } = "";
        public string VnomNaturalezaProyecto { get; set; } = "";

        public string CcodClaseProyecto { get; set; } = "";
        public string VnomClaseProyecto { get; set; } = "";

        public string CcodLocalizacion { get; set; } = "";

        public string VnomLocalizacion { get; set; } = "";
        public string CcodEstadoProyecto { get; set; } = "";

        public string VnomEstadoProyecto { get; set; } = "";
        public string CcodCadenaFuncionalProyecto { get; set; } = "";

        public string VnomCadenaFuncionalProyecto { get; set; } = "";
        public string CcodUnidadFormuladoraProyecto { get; set; } = "";

        public string VnomUnidadFormuladoraProyecto { get; set; } = "";
        public string CcodUnidadEjecutoraProyecto { get; set; } = "";

        public string VnomUnidadEjecutoraProyecto { get; set; } = "";
        public string CcodUbicacionGeografica { get; set; } = "";
        public string VnomUbicacionGeografica { get; set; } = "";

        public string CcodSNIP { get; set; } = "";

        public DateTime DfecInicio { get; set; } = DateTime.Today;
        public DateTime DfecVencimiento { get; set; } = DateTime.Today;
        public DateTime DfecCierre { get; set; } = DateTime.Today;

        public string CcodTipoMoneda_Viable { get; set; } = "";

        public string VmomTipoMoneda_Viable { get; set; } = "";
        public decimal FimpViable { get; set; } = 0;

        public string CcodTipoMoneda_Final { get; set; } = "";

        public string VnomTipoMoneda_Final { get; set; } = "";
        public decimal FimpFinal { get; set; } = 0;

    }
}
