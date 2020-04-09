using System.Data.SqlClient;

namespace Gama.RedeSocial.Infrastructure.Persistence.Repository
{
    public class SqlConnectionFactory
    {
        public static SqlConnection Create()
        {
            return new SqlConnection(@"server =WIN-7RD4JTEAKQ;Integrated Security=true;Database=AvaTalkBD");
            //return new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Integrated Security=True;Database=AvaTalkBD");
        }
    }
}
