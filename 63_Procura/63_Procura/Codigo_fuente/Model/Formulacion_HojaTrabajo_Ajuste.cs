using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Formulacion_HojaTrabajo_Ajuste
	{
		public int iIdAjuste { get; set; } = 0;
		public string cCodEmpresa { get; set; } = "";
		public string cAñoProceso { get; set; } = "";
		public string cVersion { get; set; } = "";
		public string cPeriodo { get; set; } = "";
		public string cCodPosPre { get; set; } = "";
		public string cCodGerencia { get; set; } = "";
		public double fValor { get; set; } = 0;
		public double fAjuste { get; set; } = 0;

	}
}
