using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Proyecto_Etapa_CostoFijo
    {
        public int IidProyecto_Etapa_CostoFijo { get; set; } = 0;
        public int IidProyecto_Etapa { get; set; } = 0;
		public string CcodRecurso { get; set; } = "";
        public string VnomRecurso { get; set; } = "";
        public string VnomCortoRecurso { get; set; } = "";
        public string CcodTipoRecurso { get; set; } = "";

        public string VnomTipoRecurso { get; set; } = "";
        public string vEtiqueta { get; set; } = "";
        public string cCodGrupoRecurso { get; set; } = "";
        public string VnomGrupoRecurso { get; set; } = "";
        public double fCapacidad { get; set; } = 0;
        public string cCodTipoTasa_Estandar { get; set; } = "";
        public string VnomTipoTasa_Estandar { get; set; } = "";
        public double fTasaEstandar { get; set; } = 0;
        public string cCodTipoTasa_HoraExtra { get; set; } = "";
        public string VnomTipoTasa_HoraExtra { get; set; } = "";
        public double fTasaHoraExtra { get; set; } = 0;
        public string cCodTipoMoneda_CostoUso { get; set; } = "";
        public string VnomTipoMoneda_CostoUso { get; set; } = "";
        public double fImporteCostoUso { get; set; } = 0;
        public string cCodTipoMoneda_CostoFijo { get; set; } = "";
        public string VnomTipoMoneda_CostoFijo { get; set; } = "";
        public double fImporteCostoFijo { get; set; } = 0;
        public string cCodTipoAcumulador { get; set; } = "";
        public string VnomTipoAcumulador { get; set; } = "";
        public string cCodCalendarioProyecto { get; set; } = "";
        public string tComentario { get; set; } = "";
    }
}
