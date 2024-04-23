using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Patrimonio_Depreciacion
    {
        public string CcodPatrimonio { get; set; } = "";
        public double FdepAñoAntes_Tributario_MN { get; set; }  = 0.0;
        public double FdepAcumulado_Tributario_MN { get; set; }  = 0.0;
        public double FdepAñoAntes_Tributario_ME { get; set; }  = 0.0;
        public double FdepAcumulado_Tributario_ME { get; set; } = 0.0;
        public double FdepAñoAntes_Financiero_MN { get; set; } = 0.0;
        public double FdepAcumulado_Financiero_MN { get; set; } = 0.0;
        public double FdepAñoAntes_Financiero_ME { get; set; } = 0.0;
        public double FdepAcumulado_Financiero_ME { get; set; } = 0.0;
    }
}
