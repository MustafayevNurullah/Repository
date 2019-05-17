using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Connection
    {
        public Connection()
        {
            SqlConnectionStringBuilder stringbuilder = new SqlConnectionStringBuilder();
            stringbuilder.DataSource = "STHQ0116 - 08";
            stringbuilder.InitialCatalog = "Book";
            stringbuilder.UserID = "admin";
            stringbuilder.Password = "admin";
        SqlConnection sqlConnection = new SqlConnection(stringbuilder.ToString());
            sqlConnection.Open();
        }
       
    }
}
