using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Patrimonio
    {
        public int IidPatrimonio {get;set;} =  0;
        public string CcodPatrimonio {get;set;} =  "";
        public string CcodPatrimonio_SAP {get;set;} =  "";
        public string CcodPatrimonio_NIIF {get;set;} =  "";
        public string CcodPatrimonio_GIS {get;set;} =  "";
        public string CcodPatrimonioAnt {get;set;} =  "";
        public string VdesPatrimonio {get;set;} =  "";
        public string CcodTipoIncorporacion {get;set;} =  "C";
        public string CcodSubActividad {get;set;} =  "";
        public string CcodComponente {get;set;} =  "";
        public string CcodSed {get;set;} =  "";
        public string CcodTipoPatrimonio {get;set;} =  "F";
        public string CcodMarca {get;set;} =  "";
        public string VdesModelo {get;set;} =  "";
        public string VnumSerie {get;set;} =  "";
        public string CcodClasePatrimonio {get;set;} =  "335";
        public string CcodSupranumero {get;set;} =  "";
        public string CcodActividad {get;set;} =  "5";
        public string CcodEstadoConservacion {get;set;} =  "B";
        public string CcodUnidadMedida {get;set;} =  "5";
        public double Fpresentacion {get;set;} =  1.0;
        public string TespecificacionTecnica {get;set;} =  "";
        public string CnumTransaccion {get;set;} =  "";

        public string CcodTipoFactorCalculo_Tributario {get;set;} =  "A";
        public string CcodTipoFactorCalculo_Financiero {get;set;} =  "A";

        public double FvidaUtilFinanciera {get;set;} =  0.0;
        public double FvidaUtilTributaria {get;set;} =  0.0;

        public double FvalorResidual_MN {get;set;} =  1.0;
        public double FvalorResidual_ME {get;set;} =  1.0;

        public double FvalorResidual_MN_tasa {get;set;} =  1.0;
        public double FvalorResidual_ME_tasa {get;set;} =  1.0;


        public string CcodTipoMoneda {get;set;} =  "01";

        public double FvalorPatrimonio_MN {get;set;} =  0.0;
        public double FvalorPatrimonio_ME {get;set;} =  0.0;
        public double FvalorPatrimonio_MN_tasa {get;set;} =  0.0;
        public double FvalorPatrimonio_ME_tasa {get;set;} =  0.0;

        public string TinsRRPP {get;set;} =  "";
        public string Tprocedencia {get;set;} =  "";
        public string CcodColor {get;set;} =  "";
        public string CnumMotor {get;set;} =  "";
        public string CañoFabricacion {get;set;} =  "";
        public string CnumPlaca {get;set;} =  "";
        public DateTime DfecConstruccion {get;set;} =  DateTime.Today;

        public string CsubEstacion {get;set;} =  "";

        public string CcodMetodoDepreciacion_01 {get;set;} =  "L";
        public string CcodMetodoDepreciacion_02 {get;set;} =  "L";

        public DateTime DfecIncorporacion { get; set; } = DateTime.Today;

        public string Cperiodo { get; set; } = "";

    }
}
