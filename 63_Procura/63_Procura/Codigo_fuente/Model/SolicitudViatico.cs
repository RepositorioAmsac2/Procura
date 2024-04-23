using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SolicitudViatico
    {
        public int iIdSolicitud { get; set; } = 0;
        public string cCodTipoSolicitud { get; set; } = "";
        public string cCodCeGe { get; set; } = "";
        public string vNomCeGe { get; set; } = "";
        public string cCodSolicitud { get; set; } = "";
        public string cCodSolicitud_Ampliacion { get; set; } = "";
        public string cCodPersonal { get; set; } = "";
        public string vApeEmpleado { get; set; } = "";
        public string LineaSolicitud { get; set; } = "";
        public string vApeLocadorServicio { get; set; } = "";
        public string cCodUbigeo_Origen { get; set; } = "";
        public string vNomUbigeo_Origen { get; set; } = "";
        public string cCodUbigeo { get; set; } = "";
        public string vNomUbigeo { get; set; } = "";
        public DateTime dFechaPartida { get; set; } = DateTime.Today;
        public DateTime dFechaRetorno { get; set; } = DateTime.Today;
        public string cHoraCompraPasaje_01 { get; set; } = "";
        public string cHoraCompraPasaje_02 { get; set; } = "";
        public double fCantidadDias { get; set; } = 0;
        public string tMotivoViaje { get; set; } = "";
        public string cCodFormulacion { get; set; } = "";
        public string cNumRequerimiento { get; set; } = "";
        public string cCodEmpleado { get; set; } = "";
    }
}
