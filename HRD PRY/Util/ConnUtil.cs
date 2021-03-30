using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRD_PRY
{
    public static class ConnUtil
    {

          public static string connectionString = Properties.Settings.Default.connStringDev;
       // public static string connectionString = Properties.Settings.Default.connStringProd;
        public static SqlConnection connection;
    }
}
