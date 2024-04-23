using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Formulacion_HojaTrabajo_Configuracion
    {
		public int IidDetalle { get; set; } = 0;
		public int IidItem { get; set; } = 0;
		public int Icolumna { get; set; } = 0;
		public string Ccolumna { get; set; } = "";
		public string VnombreColumna { get; set; } = "";
		public string Vmensaje { get; set; } = "";
		public string Cclave { get; set; } = "";
		public string CtipoDato { get; set; } = "";
		public bool Bactivo { get; set; } = false;
		public string cActivo { get; set; } = "";

	}
}
