using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Data.Database
{
    public class SqlException
    {
        const string consKeyDefaultCnnString = "ConnStringExpress";
        private SqlConnection _sqlConn;

        public SqlConnection sqlConn { get; set; }

        protected void OpenConnection()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
           sqlConn = new SqlConnection(connectionstring);
            sqlConn.Open();
            //throw new Exception("Metodo no implementado");
          

       
        }

        protected void CloseConnection()
        {
            
            sqlConn.Close();
            sqlConn = null;
            //throw new Exception("Metodo no implementado");
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
