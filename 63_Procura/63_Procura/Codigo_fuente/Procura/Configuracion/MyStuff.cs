using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WINlogistica
{
    public static class MyStuff
    {
        public static string CodigoEmpleado { get; set; }

        public static string CodigoUsuario { get; set; }
        public static string CodigoJefatura { get; set; }
        public static string AñoProceso { get; set; }
        public static string PeriodoProceso { get; set; }
        public static string RutaServidor { get; set; }
        public static string CodigoCentroCosto { get; set; }
        public static string NombreCentroCosto { get; set; }
        public static string CodigoCentroGestor { get; set; }
        public static string CodigoCentroGestorSuperior { get; set; }
        public static string NombreCentroGestor { get; set; }
        public static int DigitoCentroGestor { get; set; }
        public static string CodigoEmpresa { get; set; }
        public static string Empresa { get; set; }
        public static string Version { get; set; }

        public static bool UsaWCF { get; set; }
        public static bool InicioControlItem { get; set; }
        public static string NombreEmpleado { get; set; }
        public static string NombreEmpresa { get; set; }
        public static bool TieneControlTotal { get; set; }


        static MyStuff()
        {

            InicioControlItem = true;
            CodigoEmpleado = "5224";
            CodigoJefatura = "6253";
            CodigoUsuario = "Gatc02";
            AñoProceso = "2021";
            PeriodoProceso = "201905";
            RutaServidor = ""; //"D:\Logistica";
            UsaWCF = false;
            CodigoCentroCosto = "101180";
            NombreCentroCosto = "Dpto. Logistica";
            CodigoCentroGestor = "10102040";
            NombreCentroGestor = "LOGISTICA";
            CodigoCentroGestorSuperior = "10102040";
            Empresa = "Activos Mineros SAC";
            CodigoEmpresa = "20103795631";
            Version = "01";
            DigitoCentroGestor = 8;
            TieneControlTotal = false;
            NombreEmpleado = "Tornero Yaya Henry";
        }
    }
}
