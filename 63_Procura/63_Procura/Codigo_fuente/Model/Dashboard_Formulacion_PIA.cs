using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Dashboard_Formulacion_PIA
    {
		public string NOMBRE_TIPO { get; set; } = "";
		public string NOMBRE_SUBTIPO { get; set; } = "";
		public string SIGLA_GERENCIA { get; set; } = "";
		public string NOMBRE_GERENCIA { get; set; } = "";
		public string NOMBRE_CEGE { get; set; } = "";
		public string NOMBRE_CLASIFICADOR { get; set; } = "";
		public string NOMBRE_POSPRE { get; set; } = "";
		public double ANTERIOR { get; set; } = 0;
		public double ACTUAL { get; set; } = 0;
		public double DIFERENCIA { get; set; } = 0;
		public double VARIACION { get; set; } = 0;
	}
}
