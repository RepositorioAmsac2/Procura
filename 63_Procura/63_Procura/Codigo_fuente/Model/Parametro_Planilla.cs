using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Parametro_Planilla
    {
        public int iIdParametro { get; set; } = 0;
        public string cCodEmpresa { get; set; } = "";
        public string cRuc { get; set; } = "";
        public string vRazonSocial { get; set; } = "";
        public string vCorreoElectronico { get; set; } = "";
        public string cCodTipoVia { get; set; } = "";
        public string vNombreVia { get; set; } = "";
        public string cNumeroVia { get; set; } = "";
        public string cNumeroInterior { get; set; } = "";
        public string cCodTipoZona { get; set; } = "";
        public string vNombreZona { get; set; } = "";
        public string vReferencia { get; set; } = "";
        public string cCodUbigeo { get; set; } = "";
        public string cRucSeguroSocial { get; set; } = "";
        public string cCodConcepto_RetencionJudicial { get; set; } = "";
        public string cCodConcepto_CuotaSindical { get; set; } = "";
        public string cCodConcepto_HorasExtrasSimples { get; set; } = "";
        public string cCodConcepto_HorasExtrasDobles { get; set; } = "";
        public string cCodConcepto_VacacionesIngreso { get; set; } = "";
        public string cCodConcepto_VacacionesDescuento { get; set; } = "";
        public string cCodConcepto_GratificacionDescuento { get; set; } = "";
        public string cCodConcepto_Faltas { get; set; } = "";
        public string cCodConcepto_Licencias { get; set; } = "";
        public string cCodConcepto_Permisos { get; set; } = "";
        public string cCodConcepto_CantidadHES { get; set; } = "";
        public string cCodConcepto_CantidadHED { get; set; } = "";
        public string cCodConcepto_CantidadDF { get; set; } = "";
        public string cCodConcepto_CantidadF { get; set; } = "";
        public string cCodConcepto_CantidadL { get; set; } = "";
        public string cCodConcepto_CantidadP { get; set; } = "";
        public string cCodConcepto_CantidadT { get; set; } = "";
        public string cCodConcepto_CantidadDNTI { get; set; } = "";
        public bool bManejaMeta { get; set; } = false;
        public string cIpServidorCorreo { get; set; } = "";
        public string vCorreoRRHH { get; set; } = "";
        public string vCorreoTIC { get; set; } = "";
        public string cCodConcepto_Grati_NoAfecta5ta_1 { get; set; } = "";
        public string cCodConcepto_Grati_NoAfecta5ta_2 { get; set; } = "";
    }
}
