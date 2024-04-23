using System;

namespace Model
{
    public class ProcesoLogistico_Detalle
    {
        public int iIdProcesoLogistico_Detalle { get; set; } = 0;
        public int iIdProcesoLogistico_Cabecera { get; set; } = 0;
        public string cCodTipoProcesoLogistico { get; set; } = "";

        public string cNumeroRelacionado { get; set; } = "";
        public string cAñoProceso  { get; set; } = "";
        public string cVersion  { get; set; } = "";
        public string cCodProcesoLogistico { get; set; } = "";
        public string cNumProcedimiento  { get; set; } = "";
        public string cCodTipoProceso { get; set; } = "";
        public string vDesTipoProceso { get; set; } = "";
        public string cCodObjetoContratacion { get; set; } = "";
        public string vDesObjetoContratacion { get; set; } = "";
        public string cCodUnidadMedida { get; set; } = "036";
        public string vDesUnidadMedida { get; set; } = "UNIDAD";
        public string tDesContratacion { get; set; } = "";
        public string tDesJustificacion { get; set; } = "";
        public double fCantidad { get; set; } = 1.0;
        public double fPrecioEstimado { get; set; } = 0.0;
        public string cCodTipoMoneda { get; set; } = "LO";
        public string vNomTipoMoneda { get; set; } = "Nuevo Sol";
        public string cCodTipoFuenteFinanciamiento { get; set; } = "";
        public string vDesTipoFuenteFinanciamiento   { get; set; } = "";
        public DateTime dFechaPrevista { get; set; } = DateTime.Today;
        public string cCodTipoAdquisicion { get; set; } = "";
        public string vDesTipoAdquisicion { get; set; } = "";
        public string cCodEntidadEncargadaConvocante { get; set; } = "";
        public string cCodModalidadSeleccion { get; set; } = "";
        public string vDesModalidadSeleccion { get; set; } = "";
        public string cCodCentro { get; set; } = "";
        public string vNomCentro { get; set; } = "";
        public string cCodCentroGestor { get; set; } = "";
        public string vNomCentroGestor { get; set; } = "";
        public string tObservacion { get; set; } = "";
        public int iIdProcesoLogistico_Eliminado { get; set; } = 0;
        public int iIdProcesoLogistico_Modificado { get; set; } = 0;

        public string vApeOperadorLogistico { get; set; } = "";
        public string cCodEmpleado { get; set; } = "";
        public string cCodTipoDocumento { get; set; } = "";
        public string cNumDocumento { get; set; } = "";


        //-- Eliminado

        public string cCodMotivoInserccion { get; set; } = "";
        public DateTime dFecInsertado { get; set; } = DateTime.Today;
        public string tMotInsertado { get; set; } = "";

        //-- Modificado

        public string cCodMotivoModificacion { get; set; } = "";
        public DateTime dFecModificado { get; set; } = DateTime.Today;
        public string tMotModificado { get; set; } = "";

        //-- Eliminado

        public string cCodMotivoEliminacion { get; set; } = "";
        public DateTime dFecEliminado { get; set; } = DateTime.Today;
        public string tMotEliminado { get; set; } = "";

        // Plantilla
        public string cCodTipoPlantilla  { get; set; } = "";

    }
}
