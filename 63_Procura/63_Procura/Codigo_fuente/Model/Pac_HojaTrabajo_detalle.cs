using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pac_HojaTrabajo_detalle
    {
		public int iIdDetalle { get; set; } = 0;
		public int iIdCabecera { get; set; } = 0;
		public string cCodCeGe { get; set; } = "";
		public string cCodPac { get; set; } = "";
		public string cCodFormulacion { get; set; } = "";
		public double fImporteFormulacion { get; set; } = 0;

	}
}
