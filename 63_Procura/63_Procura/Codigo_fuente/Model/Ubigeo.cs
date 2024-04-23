using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ubigeo
    {
        public int iIdUbigeo { get; set; } = 0;
        public string cCodUbigeo { get; set; } = "";
        public string cCodPais { get; set; } = "";

        public string vDesPais { get; set; } = "";

        public string cCodDepartamento { get; set; } = "";

        public string vDesDepartamento { get; set; } = "";

        public string cCodProvincia { get; set; } = "";

        public string vDesProvincia { get; set; } = "";

        public string cCodDistrito { get; set; } = "";

        public string vDesDistrito { get; set; } = "";

        public string cCodIndicadorImpuesto { get; set; } = "";

        public string cCodDestinoViaje { get; set; } = "";
        public string vNomDestinoViaje { get; set; } = "";
    }
}
