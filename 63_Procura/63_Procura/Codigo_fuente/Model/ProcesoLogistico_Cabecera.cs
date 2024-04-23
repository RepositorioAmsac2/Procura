namespace Model
{
    public class ProcesoLogistico_Cabecera
    {
        public int iIdProcesoLogistico_Cabecera { get; set; } = 0;
        public string cCodTipoProceso { get; set; } = "";
        public string cAñoProceso { get; set; } = "";

        public  string cVersion { get; set; } = "";

        public string cCodTipoDocumento { get; set; } = "";

        public string vDesTipoDocumento { get; set; } = "";

        public string cNumDocumento { get; set; } = "";

        public string tNota { get; set; } = "";
        public bool bActivo { get; set; } = false;

    }
}
