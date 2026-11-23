
using System.Data.SqlClient;

namespace UniversityManagementSystem
{
    public static class Database
    {
        public static string ConnectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=UniversityDB;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
