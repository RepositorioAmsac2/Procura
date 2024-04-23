using System.Configuration;

namespace Repository
{
    public class DataAccess
    {
        public string ReturnConnectionString_Acceso()
        {

            var strConn = ConfigurationManager.ConnectionStrings["CONEXACCESO"].ConnectionString;

            return strConn;
        }

        public string ReturnConnectionString_SAFNET()
        {
            var strConn = ConfigurationManager.ConnectionStrings["CONEXSAFNET"].ConnectionString;

            return strConn;
        }

    }
}
