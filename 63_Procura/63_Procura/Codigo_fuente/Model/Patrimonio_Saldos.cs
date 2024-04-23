using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Patrimonio_Saldos
    {
        public string CcodPatrimonio { get; set; } = "";
        public double Fcantidad { get; set; } = 1.0;
        public double FvalorResidual_MN { get; set; } = 1.0;
        public double FvalorResidual_ME { get; set; } = 1.0;
        public double FvalorActivo_MN { get; set; } = 0.0;
        public double FvalorActivo_ME { get; set; } = 0.0;
        public double FvalorResidual_MN_tasa { get; set; } = 1.0;
        public double FvalorResidual_ME_tasa { get; set; } = 1.0;
        public double FvalorActivo_MN_tasa { get; set; } = 0.0;
        public double FvalorActivo_ME_tasa { get; set; } = 0.0;
        public int IvidaUtil_Tributario { get; set; } = 0;
        public int IvidaUtil_Financiero { get; set; } = 0;
    }
}
