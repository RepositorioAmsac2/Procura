using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HojaTrabajo_Formato_Detalle
    {
		public int iIdFormatoDetalle { get; set; } = 0;
		public string cCodFormato { get; set; } = "";
		public string cCodCampo { get; set; } = "";
		public string vNomCampo { get; set; } = "";
		public string vValCampo { get; set; } = "";
		public string vDesCampo { get; set; } = "";
		public int iNumeroColumna { get; set; } = 0;
		public string cColumna { get; set; } = "";
	}
}
