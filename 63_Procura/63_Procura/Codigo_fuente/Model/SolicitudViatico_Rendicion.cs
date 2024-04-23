using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SolicitudViatico_Rendicion
    {
        public int iIdSolicitudViatico_Rendicion { get; set; } = 0;
        public string cCodSolicitud { get; set; } = "";
        public string cCodConcepto { get; set; } = "";
        public string vNomConcepto { get; set; } = "";
        public DateTime dFechaInicio { get; set; } = DateTime.Today;
        public DateTime dFechaFinal { get; set; } = DateTime.Today;
        public string cCodProveedor { get; set; } = "";
        public string vNomProveedor { get; set; } = "";
        public string cCodClaseDocumento { get; set; } = "";
        public string vNomClaseDocumento { get; set; } = "";
        public string cSerieDocumento { get; set; } = "";
        public string cNumeroDocumento { get; set; } = "";
        public string cNumeroDocumentoAdicional { get; set; } = "";
        public DateTime dFechaDocumento { get; set; } = DateTime.Today;
        public string cCodTipoMoneda { get; set; } = "";
        public double dImporte { get; set; } = 0.0;
        public double dImpuesto { get; set; } = 0.0;
        public double dOtroImporte { get; set; } = 0.0;
        public double dTotal { get; set; } = 0.0;
        public string cCodCentroCosto { get; set; } = "";
        public string tObservacion { get; set; } = "";
        public string dFechaRegistro { get; set; } = "";

    }
}
