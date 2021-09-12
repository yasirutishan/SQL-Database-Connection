using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Data_Entry_DB
{
    public class ConnectionManager
    {
        public static SqlConnection newCon;
        public static string Constr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            newCon = new SqlConnection(Constr);
            return newCon;
        }
    }
}
