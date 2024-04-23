using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Proveedor
    {
     public int    iIdProveedor { get; set; }
     public string cCodEmpresa { get; set; }
     public string cCodProveedor { get; set; }
     public string vRazonSocial { get; set; }
     public string vDireccion { get; set; }
     public string vEmail { get; set; }
     public string cTelefono { get; set; }
     public string cCodTipoDocumentoIdentidad { get; set; }
     public string cNumDocumentoIdentidad { get; set; }
     public string cCodUbigeo { get; set; }
        public string vDepartamento { get; set; }
        public string vProvincia { get; set; }
        public string vDistrito { get; set; }


    }
}
