using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ParametroGestion_Empleado
    {
        public int iIdParametroGestion { get; set; } = 0;
        public string cCodParametroGestion { get; set; } = "";

        public string vDesParametroGestion { get; set; } = "";

        public string vValParametroGestion { get; set; } = "";

        public DateTime dFecInicial { get; set; } = DateTime.Now;

        public DateTime dFecFinal { get; set; } = DateTime.Now;

        public Boolean bCerrado { get; set; } = true;
    }
}
