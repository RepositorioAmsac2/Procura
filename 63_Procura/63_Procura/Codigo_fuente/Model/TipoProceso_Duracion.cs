using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TipoProceso_Duracion
    {
        public int iIdTipoProceso_Duracion { get; set; } = 0;
        public string cAñoProceso { get; set; } = "";
        public string cCodTipoProceso { get; set; } = "";
        public string cCodObjetoContratacion { get; set; } = "";
        public int iIdPaso { get; set; } = 0;
        public int iDuracion { get; set; } = 0;
        public int iTipoDuracion { get; set; } = 1;
        public int iDiaEmail { get; set; } = 0;
        public string cCodEstadoDuracionPaso { get; set; } = "";
        public int iOrden { get; set; } = 1;
    }
}
