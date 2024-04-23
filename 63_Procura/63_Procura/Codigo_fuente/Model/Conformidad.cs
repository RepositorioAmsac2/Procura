using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Conformidad
    {
        public int iIdContratoConformidad { get; set; } = 0;
        public string cCodCompañia { get; set; } = "";
        public string cNroContrato { get; set; } = "";
        public string cNroConformidad { get; set; } = "";
        public string cNroEntregable { get; set; } = "";
        public DateTime dFecEntregable { get; set; } = DateTime.Now;
        public DateTime dFecConformidad { get; set; } = DateTime.Now;
        public double fImporteConformidad { get; set; } = 0.0;
        public string tComentarioConformidad { get; set; } = "";
        public string cCodEmpleado { get; set; } = "";

    }
}
