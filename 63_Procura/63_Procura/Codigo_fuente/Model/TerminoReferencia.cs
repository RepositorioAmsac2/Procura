using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TerminoReferencia
    {
        public int iIdTerminoReferencia { get; set; } = 0;
		public string cAñoProceso { get; set; } = "";
		public string cCodCeGe { get; set; } = "";
		public string EmpleadoID { get; set; } = "";
		public string EmpleadoID_Emisor { get; set; } = "";
		public string cNumDocumento { get; set; } = "";
		public DateTime dFecDocumento { get; set; } = DateTime.Today;
		public string tTitulo { get; set; } = "";
		public string vAdjunto { get; set; } = "";
		public Boolean bAtiendeDocumento { get; set; } = false;
		public string cTipoMovimiento { get; set; } = "";
		public string vPara { get; set; } = "";
		public string vCC { get; set; } = "";
		public string tMensaje { get; set; } = "";
        public string cCodEtapaCierre { get; set; } = "";
    }
}
