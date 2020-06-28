using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DBConnect
    {
        private SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-L3TGD7A\TRUNGTU;Initial Catalog=DMS;Integrated Security=True");
        public LinqSQLDataDataContext context = new LinqSQLDataDataContext();

    }
}
