using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PO_HojaTrabajo_Detalle_Item
    {
        public int iIdItem { get; set; }
        public int iIdDetalle { get; set; }
        public string cAño { get; set; }
        public string cMes { get; set; }
        public string cNumeroAño { get; set; }
        public double fImporte { get; set; }
    }
}
