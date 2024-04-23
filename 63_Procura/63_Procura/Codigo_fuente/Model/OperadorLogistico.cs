
namespace Model
{
    public class OperadorLogistico
    {
        public int iIdEmpleado { get; set; } = 0;
        public string cCodEmpleado { get; set; } = "";
        public string cCodDependencia { get; set; } = "";

        public string cCodCentroGestor { get; set; } = "";
        public string vNomCentroGestor { get; set; } = "";
        public string vEmail { get; set; } = "";
        public string vPasosAtras { get; set; } = "";
        public string vPasosAdelante { get; set; } = "";
	    public string vLogUsuario { get; set; } = "";
    }
}
