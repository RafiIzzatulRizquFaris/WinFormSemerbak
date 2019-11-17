using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormSemerbak
{
    class Env
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N2LO0FB;Initial Catalog=sbhDB;Integrated Security=True");
    }
}
