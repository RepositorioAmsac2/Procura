using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Destino
    {
        public int iIdEscalaViaje { get; set; } = 0;
		public string cCodTipoDestinoViaje { get; set; } = "";
        public string vNomTipoDestinoViaje { get; set; } = "";
        public string cCodEscalaViaje { get; set; } = "";
        public string vNomEscalaViaje { get; set; } = "";
        public Double fMonto { get; set; } = 0.0;
    }
}
