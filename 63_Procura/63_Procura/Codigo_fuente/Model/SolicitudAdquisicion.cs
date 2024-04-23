using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class SolicitudAdquisicion
	{
		public int iIdSolicitud { get; set; } = 0;

		public string cCodEmpresa { get; set; } = ""; 
		public string cAñoProceso { get; set; } = "";
public string cNumExpediente { get; set; } = "";
		public DateTime dFecExpediente { get; set; } = DateTime.Now;
		public string tDesAdquisicion { get; set; } = "";
		public string cNumTDR { get; set; } = "";
		public double fImporte { get; set; } = 0;
		public string vTipoAdquisicion { get; set; } = "";
	}
}
