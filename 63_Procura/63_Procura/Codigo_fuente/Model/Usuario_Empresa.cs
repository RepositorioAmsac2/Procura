using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario_Empresa
    {
		public int IidUsuario { get; set; } = 0;
		public string CcodEmpresa { get; set; } = "";
		public string Usuario { get; set; } = "";
		public string Clave { get; set; } = "";
		public string Nombre { get; set; } = "";
		public string Cargo { get; set; } = "";
		public string CcodCeCo { get; set; } = "";
		public string VnomCeCo { get; set; } = "";
		public string CcodCeGe { get; set; } = "";
		public string VnomCeGe { get; set; } = "";
		public string CcodGerencia { get; set; } = "";
		public string VnomGerencia { get; set; } = "";
	}
}
