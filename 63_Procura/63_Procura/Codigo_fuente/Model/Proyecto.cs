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
        public string VnomTipoProyecto { get; set; } = "";
        public string CcodGrupoProyecto { get; set; } = "";
        public string VnomGrupoProyecto { get; set; } = "";
        public string CcodProyecto { get; set; } = "";
        public string CcodProyecto_Inicio { get; set; } = "";
        public string TnomProyecto { get; set; } = "";
        public string VnomCortoProyecto { get; set; } = "";

        public string CcodMacroProyecto { get; set; } = "";
        public string CcodEmpresa { get; set; } = "";
        public string CcodEmpresaContratante { get; set; } = "";

        public string VnomMacroProyecto { get; set; } = "";

        public string TObjProyecto { get; set; } = "";

        public string CcodNaturalezaProyecto { get; set; } = "";
        public string VnomNaturalezaProyecto { get; set; } = "";

        public string CcodClaseProyecto { get; set; } = "";
        public string VnomClaseProyecto { get; set; } = "";
        public string VnomLocalizacion { get; set; } = "";
        public string CcodEstadoProyecto { get; set; } = "";

        public string VnomEstadoProyecto { get; set; } = "";
        public string CcodCadenaFuncionalProyecto { get; set; } = "";

        public string VnomCadenaFuncionalProyecto { get; set; } = "";
        public string CcodUnidadFormuladoraProyecto { get; set; } = "";

        public string VnomUnidadFormuladoraProyecto { get; set; } = "";
        public string CcodUnidadEjecutoraProyecto { get; set; } = "";

        public string VnomUnidadEjecutoraProyecto { get; set; } = "";
        public double Ilatitud { get; set; } = 0;
        public double Ilongitud { get; set; } = 0;
        public DateTime DfecInicio { get; set; } = DateTime.Today;
        public DateTime DfecVencimiento { get; set; } = DateTime.Today;
        public DateTime DfecCierre { get; set; } = DateTime.Today;

        public string CcodTipoMoneda_Viable { get; set; } = "";

        public string VmomTipoMoneda_Viable { get; set; } = "";
        public decimal FimpViable { get; set; } = 0;

        public string CcodTipoMoneda_Final { get; set; } = "";

        public string VnomTipoMoneda_Final { get; set; } = "";
        public decimal FimpFinal { get; set; } = 0;
        public string Tobjetivo { get; set; } = "";
        public string TobjetivoEstrategico { get; set; } = "";
        public string Tdescripcion { get; set; } = "";
        public string TbeneficioCuantitativo { get; set; } = "";
        public string TbeneficioCualitativo { get; set; } = "";
        public string CcodUnico { get; set; } = "";
        public string CcodOrden { get; set; } = "";
        public string CnumOrden { get; set; } = "";
        public string CperiodoInicio { get; set; } = "";
        public string CperiodoFinal { get; set; } = "";
        public string CcodEstadoActual { get; set; } = "";
        public string Tobservacion { get; set; } = "";

    }
}
