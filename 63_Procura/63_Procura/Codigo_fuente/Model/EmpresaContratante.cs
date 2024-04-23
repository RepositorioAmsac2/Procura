using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EmpresaContratante
    {
		public int Id { get; set; } = 0;
		public string Codigo { get; set; } = "";
		public string EmpresaCodigo { get; set; } = "";
		public string Nombre { get; set; } = "";
		public string NombreCorto { get; set; } = "";
		public string TipoDocumentoIdentidad { get; set; } = "";
		public string NumeroDocumentoIdentidad { get; set; } = "";
	}
}
