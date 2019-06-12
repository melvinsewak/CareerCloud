using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public class SqlUtility
    {
        public static string ConnectionString { get; set; } = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
    }
}
