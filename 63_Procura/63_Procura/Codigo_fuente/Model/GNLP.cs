using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GNLP
    {
        public int IidGNLP { get; set; } = 0;
        public int ItipoGNLP { get; set; } = 1;
        public string VnomTipoGNLP { get; set; } = "";
        public string CcodGrupoGNLP { get; set; } = "";
        public string VnomGrupoGNLP { get; set; } = "";
        public string CcodGNLP { get; set; } = "";
        public string CcodGNLP_Inicio { get; set; } = "";
        public string TnomGNLP { get; set; } = "";
        public string VnomCortoGNLP { get; set; } = "";

        public string CcodMacroGNLP { get; set; } = "";
        public string CcodEmpresa { get; set; } = "";
        public string CcodEmpresaContratante { get; set; } = "";

        public string VnomMacroGNLP { get; set; } = "";

        public string TObjGNLP { get; set; } = "";

        public string CcodNaturalezaGNLP { get; set; } = "";
        public string VnomNaturalezaGNLP { get; set; } = "";

        public string CcodClaseGNLP { get; set; } = "";
        public string VnomClaseGNLP { get; set; } = "";
        public string VnomLocalizacion { get; set; } = "";
        public string CcodEstadoGNLP { get; set; } = "";

        public string VnomEstadoGNLP { get; set; } = "";
        public string CcodCadenaFuncionalGNLP { get; set; } = "";

        public string VnomCadenaFuncionalGNLP { get; set; } = "";
        public string CcodUnidadFormuladoraGNLP { get; set; } = "";

        public string VnomUnidadFormuladoraGNLP { get; set; } = "";
        public string CcodUnidadEjecutoraGNLP { get; set; } = "";

        public string VnomUnidadEjecutoraGNLP { get; set; } = "";
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
