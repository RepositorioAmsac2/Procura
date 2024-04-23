using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MotivoRechazoRequerimiento
    {
        public int IidMotivoRechazo {get;set;} = 0;
        public string CcodMotivoRechazo { get; set; } = "";
        public string VnomMotivoRechazo { get; set; } = "";
        public string CcodTipoRechazo { get; set; } = "";
    }
}
