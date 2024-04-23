using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PO_HojaTrabajo_Cabecera
    {
        public int IidCabecera { get; set; } = 0;
        public string CcodCompañia { get; set; } = "";
        public string CañoProceso { get; set; } = "";
        public string CmesProceso { get; set; } = "";
        public DateTime DfecProceso { get; set; } = DateTime.Today;
        public string Tnota { get; set; } = "";
        public Boolean Bactivo { get; set; } = false;

    }
}
