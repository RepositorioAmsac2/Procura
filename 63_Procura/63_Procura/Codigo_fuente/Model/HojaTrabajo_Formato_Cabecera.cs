using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HojaTrabajo_Formato_Cabecera
    {
        public int iIdFormato { get; set; } = 0;
	    public string cCodFormato { get; set; } = "";
        public string vNomFormato { get; set; } = "";
        public string cCodTipoFOrmulacion { get; set; } = "";
        public string cCodSubTipoFormulacion { get; set; } = "";
        public string cCodCeGe { get; set; } = "";
        public string cCodCeCo { get; set; } = "";
        public int iFilaInicial { get; set; } = 0;
        public int iColumnaInicial { get; set; } = 0;
        public int iColumnaPosPre { get; set; } = 0;
        public int iColumnaCeCo { get; set; } = 0;
        public int iColumnaDetalleGasto { get; set; } = 0;
    }
}
