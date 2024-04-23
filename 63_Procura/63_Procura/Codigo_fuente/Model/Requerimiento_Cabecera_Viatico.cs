using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Requerimiento_Cabecera_Viatico
    {
        public int iIdRequerimiento_Cabecera_Viatico { get; set; } = 0;
        public string cNumRequerimiento { get; set; } = "";
        public string cCodViajero { get; set; } = "";
        public string vNomViajero { get; set; } = "";
        public string cNumDocumentoIdentidad { get; set; } = "";
        public string cCodAeropuertoOrigen { get; set; } = "";
        public string vNomAeropuertoOrigen { get; set; } = "";
        public string cCodAeropuertoDestino { get; set; } = "";
        public string vNomAeropuertoDestino { get; set; } = "";
        public DateTime dFechaPartida { get; set; } = DateTime.Today;
        public string cHoraPartida { get; set; } = "";
        public DateTime dFechaRetorno { get; set; } = DateTime.Today;
        public string cHoraRetorno { get; set; } = "";
        public Boolean bSoloIda { get; set; } = false;
    }
}
