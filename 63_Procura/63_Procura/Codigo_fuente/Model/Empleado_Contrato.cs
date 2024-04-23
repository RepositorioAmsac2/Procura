using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Empleado_Contrato
    {
        public int iIdEmpleado_Contrato { get; set; } = 0;
        public int iIdEmpleado_Baja { get; set; } = 0;
        public string cCodEmpleado { get; set; } = "";
        public string cCodEmpresaContratante { get; set; } = "";
        public string cCodEmpresaIntermediaria { get; set; } = "";
        public string cCodTipoDocumentoLaboral { get; set; } = "";
        public string cNumDocumento { get; set; } = "";
        public string cCodTipoEmpleado { get; set; } = "";
        public DateTime dFecIngreso { get; set; } = DateTime.Now;
        public DateTime dFecTermino { get; set; } = DateTime.Now;
        public string cCodClaseEmpleado { get; set; } = "";
        public string cCodNivelSalarial { get; set; } = "";
        public string cCodPeriodicidadRemunerativa { get; set; } = "";
        public string cCodTipoContratoLaboral { get; set; } = "";
        public string cCodTipoRemuneracion { get; set; } = "";
        public string cCodCategoriaOcupacional { get; set; } = "";
        public string cCodOcupacion { get; set; } = "";
        public string cCodRegimenLaboral { get; set; } = "";
        public string tNota { get; set; } = "";
        public bool bEstado { get; set; } = false;
        public double fRemuneracionMensual { get; set; } = 0.0;
        public string cCodTipoMoneda { get; set; } = "";
        public double fHorasSemanales { get; set; } = 0.0;
        public string cCodTipoFormatoContrato { get; set; } = "";
        public string cCodObra { get; set; } = "";
        public double fMesTrabajo { get; set; } = 0.0;
    }
}
