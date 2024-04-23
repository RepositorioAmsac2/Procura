using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProcesoLogistico_Insertado
    {
        public int iIdProcesoLogistico_Insertado { get; set; } = 0;

        public string cNumProcedimiento { get; set; } = "";
        public string cAñoProceso { get; set; } = "";
        public string cVersion { get; set; } = "";

        public DateTime dFecInsertado { get; set; } = DateTime.Today;

        public string tMotInsertado { get; set; } = "";

        public string cCodEmpleado { get; set; } = "";
        public string vApeEmpleado { get; set; } = "";
        public string cCodTipoDocumento { get; set; } = "";
        public string vDesTipoDocumento { get; set; } = "";
        public string cNumDocumento { get; set; } = "";
	    public string cCodMotivoInserccion { get; set; } = "";
        public string vDesTipoMotivo { get; set; } = "";
    }
}
