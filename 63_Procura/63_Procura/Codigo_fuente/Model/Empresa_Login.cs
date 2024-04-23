using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Empresa_Login
    {
        public int IidEmpresa { get; set; } = 0;
        public string CcodEmpresa { get; set; } = "";
        public string VnomEmpresa { get; set; } = "";

        public byte[] Pimg_LogoIzquierdo { get; set; }

        public byte[] Pimg_LogoCentro { get; set; }

        public byte[] Pimg_LogoMenu { get; set; }
    }
}
