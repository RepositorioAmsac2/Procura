using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Empleado
    {
        //Personal

        public string cCodEmpresa { get; set; } = "";
        public string CCodPersonal { get; set; } = "";
        public string VApePersonal { get; set; } = "";
        public string CCodEscalaViaje { get; set; } = "";
        public string VNomEscalaViaje { get; set; } = "";
        public string CCodCargo { get; set; } = "";
        public string VDesCargo { get; set; } = "";
        public string CDni { get; set; } = "";
        public string CCodTipoEmpleado { get; set; } = "";
        public string VDesTipoEmpleado { get; set; } = "";
        public string CCodCentroCosto { get; set; } = "";
        public string VNomCentroCosto { get; set; } = "";
        public string CCodCentroGestor { get; set; } = "";
        public string VNomCentroGestor { get; set; } = "";
        public int Idigito { get; set; } = 2;
        public string CCodCentroBeneficio { get; set; } = "";
        public string VNomCentroBeneficio { get; set; } = "";
        public string CCodCentro { get; set; } = "";
        public string VNomCentro { get; set; } = "";
        public string CCodZona { get; set; } = "";
        public string VNomzona { get; set; } = "";
        public string Cpaso { get; set; } = "";
        public string CCodCentroGestorSuperior { get; set; } = "";

        //Empleado
        public int iIdEmpleado { get; set; } = 0;
        public string cCodEmpleado { get; set; } = "";
        public string vPriNombre { get; set; } = "";
        public string vSegNombre { get; set; } = "";
        public string vPriApellido { get; set; } = "";
        public string vSegApellido { get; set; } = "";
        public string vEmail { get; set; } = "";
        public string cCodTipoDocumentoIdentidad { get; set; } = "";
        public string cNumDocumentoIdentidad { get; set; } = "";
        public string cCodNacionalidad { get; set; } = "";
        public string cCodSexo { get; set; } = "";
        public DateTime dFecNacimiento { get; set; } = DateTime.Now;
        public int iIdEmpleado_Contrato { get; set; } = 0;
        public string cCodTipoCalculo { get; set; } = "";
        public string cHorIngreso { get; set; } = "";
        public string cHorSalida { get; set; } = "";
        public string cHorIngresoTarde { get; set; } = "";
        public string cHorSalidaTarde { get; set; } = "";
        public int iIdEmpleado_Turno { get; set; } = 0;
        public string cCodUbiArea { get; set; } = "";
    }
}
