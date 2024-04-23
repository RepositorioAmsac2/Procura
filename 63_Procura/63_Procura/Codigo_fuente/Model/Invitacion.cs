using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Invitacion
    {
        public int iIdInvitacion { get; set; } = 0;
        public string cCodEmpresa { get; set; } = "";
        public string cNumProcedimiento { get; set; } = "";
        public string cNumRequerimiento { get; set; } = "";
        public string cCodProveedor { get; set; } = "";
        public string cRucProveedor { get; set; } = "";
        public string vNomProveedor { get; set; } = "";
        public string vEmail { get; set; } = "";
        public DateTime dFecInvitacion { get; set; } = DateTime.Now;
        public bool bEsProveedor { get; set; } = true;
    }
}
