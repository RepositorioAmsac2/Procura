using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProcesoAdquisicion
    {
        public int iIdProcesoAdquisicion { get; set; } = 0;

        public string cCodEmpresa { get; set; } = "";

        public string cAñoProceso { get; set; } = "";
        public string cCodProcesoAdquisicion { get; set; } = "";
        public string cNumProcedimiento { get; set; } = "";
        public string cCodTipoProceso { get; set; } = "";
        public string vDesTipoProceso { get; set; } = "";
        public string cCodObjetoContratacion { get; set; } = "";
        public string vDesObjetoContratacion { get; set; } = "";
        public string tDesContratacion { get; set; } = "";
        public string tObjetivo { get; set; } = "";
        public DateTime dFechaPrevista { get; set; } = DateTime.Today;
        public string cCodTipoAdquisicion { get; set; } = "";
        public string vDesTipoAdquisicion { get; set; } = "";
        public string cCodEntidadEncargadaConvocante { get; set; } = "";
        public string vNomEntidadEncargadaConvocante { get; set; } = "";
        public string cCodModalidadSeleccion { get; set; } = "";
        public string vDesModalidadSeleccion { get; set; } = "";
    }
}
