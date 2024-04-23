using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrdenTrabajo
    {
        public int iIdOrden { get; set; } = 0;
		public string cNumOrden { get; set; } = "";
        public string vDesOrden { get; set; } = "";
        public string cCodClaseOrden { get; set; } = "";
        public string vDesClaseOrden { get; set; } = "";
        public string cCodCentroCosto { get; set; } = "";
        public string vNomCentroCosto { get; set; } = "";
    }
}
