using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Formulacion_HojaTrabajo_Cabecera
    {
        public int IidCabecera { get; set; } = 0;
        public string CcodCompañia { get; set; } = "";
        public string CañoProceso { get; set; } = "";
        public string Cversion { get; set; } = "";
        public string Cperiodo { get; set; } = "";
        public DateTime DfecFormulacion { get; set; } = DateTime.Today;
        public string Tnota { get; set; } = "";
        public Boolean Bactivo { get; set; } = false;
        public string cCodTipoDocumento { get; set; } = "";
        public string cNumDocumento { get; set; } = "";
        public string vDesTipoDocumento { get; set; } = "";
        public bool BajusteManual { get; set; } = false;
    }
}
