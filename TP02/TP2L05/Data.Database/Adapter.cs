using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    {
        //Clave por defecto a utilizar para la cadena de coneccion
        const string consKeyDefaultCnnString = "ConnStringExpress";
        ////private SqlConnection _sqlConn; // visual conoce igual la _sqlconn (es para buena practica nomas) 
        
        public SqlConnection sqlConn { get; set; }


        protected void OpenConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();                                 //// se detectaba codigo inaccesible cuando estaba por debajo de new Exception
                                                            //throw new Exception("Metodo no implementado");
          
        }

        protected void CloseConnection()
        {
            sqlConn.Close();
            sqlConn = null;
                 //throw new Exception("Metodo no implementado");
                //SqlConnection sqlConn = new SqlConnection("ConnectionString"); // por que abriria una nueva conexion si quiero cerrarla? 
          
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }

       

    }
}
