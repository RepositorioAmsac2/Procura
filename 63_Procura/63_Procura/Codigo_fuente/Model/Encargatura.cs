using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Encargatura
    {
        public int iIdEncargatura { get; set; } = 0;
        public string cNumDocumento { get; set; } = "";
        public string cCodEmpleado_Encargado { get; set; } = "";
        public string vNomEmpleado_Encargado { get; set; } = "";
        public string cCodTipoEncargatura { get; set; } = "01";
        public string vNomTipoEncargatura { get; set; } = "";
        public string dFecInicio { get; set; } = "";
        public Boolean bEncargaturaIndeterminada { get; set; } = true;
        public string dFecFinal { get; set; } = "";
        public string cCodEmpleado_Reemplazado { get; set; } = "";
        public string vNomEmpleado_Reemplazado { get; set; } = "";
        public string cCodCeCo { get; set; } = "";
        public string vNomCeCo { get; set; } = "";
    }
}
