using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Configuracion_HojaTrabajo
    {
        public string VtituloHoja { get; set; } = "";
        public int IfilaInicialHoja { get; set; } = 0;
        public string CcodTipoConfiguracion { get; set; } = "";
        public int Icolumna { get; set; } = 0;
        public bool Bactivo { get; set; } = false;
        public string Cclave { get; set; } = "";
        public string CtipoDato { get; set; } = "";
    }
}
