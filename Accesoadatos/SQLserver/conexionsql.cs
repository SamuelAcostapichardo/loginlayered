using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Accesoadatos
{
    public abstract class Conexionsql
    {

        public SqlConnection S;
        private readonly string conection = ConfigurationManager.ConnectionStrings["presentacion.Properties.Settings.Setting"].ConnectionString;

        
        
        public SqlConnection Getconection() 
        {
            return new SqlConnection(conection);
        }
        
      
  }
}
    

