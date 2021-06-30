using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    {
        const string consKeyDefaultCnnString = "ConnStringExpress";

        private SqlConnection sqlConn = new SqlConnection("ConnectionString");

        protected void OpenConnection()
        {
            var connectionstring = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connectionstring);
            sqlConn.Open();
            throw new Exception("Metodo no implementado");
          

       
        }

        protected void CloseConnection()
        {
            sqlConn = null;
            sqlConn.Close();
            throw new Exception("Metodo no implementado");
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
