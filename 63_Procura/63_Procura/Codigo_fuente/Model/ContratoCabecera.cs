using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ContratoCabecera
    {
        public int IidContrato { get; set; } = 0;
        public string CCodCompañia { get; set; } = "";
        public string CNroProceso { get; set; } = "";
        public DateTime DFecProceso { get; set; } = DateTime.Now;
        public string CNroContrato { get; set; } = "";
        public string TDesContrato { get; set; } = "";
        public string CCodTipoProceso { get; set; } = ""; //FK MonedaDocumento
        public string VDesTipoProceso { get; set; } = ""; //FK MonedaDocumento
        public string CCodObjetoContratacion { get; set; } = ""; //FK MonedaDocumento
        public string VDesObjetoContratacion { get; set; } = ""; //FK MonedaDocumento
        public string CcodTipoMoneda { get; set; } = "";
        public double FtipoCambio { get; set; } = 0.0;
        public double FprecioUnitario_Local { get; set; } = 0.0;
        public double FprecioUnitario_Extranjero { get; set; } = 0.0;
        public string CcodTipoImpuesto { get; set; } = "";
        public double Fimpuesto_Local { get; set; } = 0.0;
        public double Fimpuesto_Extranjero { get; set; } = 0.0;
        public string CCodTipoContrato { get; set; } = ""; //FK MonedaDocumento
        public string cCodContratista { get; set; } = "";
        public string cCodDestinatarioPago { get; set; } = "";
        public DateTime DFecSuscripcionContrato { get; set; } = DateTime.Now;
        public DateTime DFecVigencia_Inicio { get; set; } = DateTime.Now;
        public DateTime DFecVigencia_Final { get; set; } = DateTime.Now;
        public bool bTieneMontosAdicionales { get; set; } = false;
        public bool bRequiereRetencionGarantia { get; set; } = false;
        public bool bSolicitaAnticipo { get; set; } = false;
        public bool bSeAplicaPenalidad { get; set; } = false;
        public string cCodProveedor { get; set; } = "";
        public string vRazonSocial { get; set; } = "";
        public string cCodAdministradorContrato { get; set; } = "";
        public string cCodEmpleado { get; set; } = "";
    }
}
