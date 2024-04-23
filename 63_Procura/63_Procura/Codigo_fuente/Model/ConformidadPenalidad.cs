using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConformidadPenalidad
    {
        public int iIdContratoConformidad_Penalidad { get; set; } = 0;
        public string cCodCompañia { get; set; } = "";
        public string cNroConformidad { get; set; } = "";
        public double fImportePenalidad { get; set; } = 0.0;
        public string tComentarioPenalidad { get; set; } = "";

    }
}
