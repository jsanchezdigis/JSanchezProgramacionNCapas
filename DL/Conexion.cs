using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DL
{
    public class Conexion
    {
        public static string GetConectionString()
        {
            return ConfigurationManager.ConnectionStrings["JSanchezProgramacionNCapas"].ConnectionString.ToString();
            //return ConfigurationManager.ConnectionStrings["Data Source=.;Initial Catalog=JSanchezProgramacionNCapas;Persist Security Info=True;User ID=sa;Password=pass@word1"].ConnectionString.ToString();
        }
    }
}
