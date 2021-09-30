using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Negocio
{
    public class UsuarioData
    {
        private SqlConnection _conn;

        protected SqlConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }
        public UsuarioData()
        {
            this.Conn = new SqlConnection(
            "Data Source=.\\SQLExpress;Initial Catalog=tp2_net;Integrated Security=true;");
            /*
             * Este connection string es para conectarse con la base de datos academia en el servidor
             * del departamento sistemas desde una PC de los laboratorios de sistemas,
             * si realiza este Laboratorio desde su PC puede probar el siguiente connection string
             * 
             * "Data Source=localhost;Initial Catalog=academia;Integrated Security=true;"
             * 
             * Si realiza esta práctica sobre el MS SQL SERVER 2005 Express Edition entonce debe 
             * utilizar el siguiente connection string
             * 
             * "Data Source=localhost\SQLEXPRESS;Initial Catalog=academia;Integrated Security=true;"
             */

        }
        public List<Usuario> GetAll()
        {
            //Creo la lista en la que le voy a ir agregando los usuarios
            List<Usuario> listaUsuarios = new List<Usuario>();
            //Defino una variable de tipo Usuario
            Usuario usuarioActual;

            //Creo el comando para ejecutar la sentencia SQL, le asocio la Conexión también
            SqlCommand cmdGetUsuarios = new SqlCommand("select * from usuarios", this.Conn);

            //Abro la conexión
            this.Conn.Open();

            //Ejecuto la consulta, me devuelve un objeto SqlDataReader
            SqlDataReader rdrUsuarios = cmdGetUsuarios.ExecuteReader();

            //Recorro el SqlDataReader, transformo el registro a objeto y 
            //agrego ese objeto a la lista de usuarios
            while (rdrUsuarios.Read())
            {
               
                usuarioActual = new Usuario();

                usuarioActual.ID = (int)rdrUsuarios["id_usuario"];
               usuarioActual.Apellido = rdrUsuarios["apellido"].ToString();
                usuarioActual.Nombre = rdrUsuarios["nombre"].ToString();
                usuarioActual.Email = rdrUsuarios["email"].ToString();
                usuarioActual.Nombre_Usuario = rdrUsuarios["nombre_usuario"].ToString();
                usuarioActual.Clave = rdrUsuarios["clave"].ToString();
                usuarioActual.Habilitado = (bool)rdrUsuarios["habilitado"];

                //Agrego el objeto a la lista de usuarios
                listaUsuarios.Add(usuarioActual);

            }

            //Cierro la conexión
            this.Conn.Close();

            //Devuelvo la Lista de Usuarios
            return listaUsuarios;
        }
        public void BorrarUsuario(Usuario usuarioActual)
        {
            //Creo el comando para ejecutar la sentencia SQL de DELETE, 
            //le asocio la Conexión también
            SqlCommand cmdDeleteUsuario = new SqlCommand(" DELETE FROM usuarios WHERE id_usuario=@id ", this.Conn);

            //Le agrego los parámetros necesarios
            cmdDeleteUsuario.Parameters.Add(new SqlParameter("@id", usuarioActual.ID.ToString()));

            //Abro la Conexión
            this.Conn.Open();
            //Ejecuto la instrucción SQL de DELETE
            cmdDeleteUsuario.ExecuteNonQuery();

            //Cierro la Conexión
            this.Conn.Close();
        }

        public void ActualizarUsuario(Usuario usuarioActual)
        {
            //Creo el comando para ejecutar la sentencia SQL de DELETE, 
            //le asocio la Conexión también
            SqlCommand cmdActualizarUsuario = new SqlCommand(" UPDATE usuarios " +
                                               " SET apellido = @apellido, nombre = @nombre," +
                                               "email = @email, nombre_usuario = @nombre_usuario, " +
                                               " clave = @clave, habilitado = @hab WHERE id_usuario = @id ", this.Conn);

            //Le agrego los parámetros necesarios
            
            cmdActualizarUsuario.Parameters.Add(new SqlParameter("@apellido", usuarioActual.Apellido));
            cmdActualizarUsuario.Parameters.Add(new SqlParameter("@nombre", usuarioActual.Nombre));
            cmdActualizarUsuario.Parameters.Add(new SqlParameter("@email", usuarioActual.Email));
            cmdActualizarUsuario.Parameters.Add(new SqlParameter("@nombre_usuario", usuarioActual.Nombre_Usuario));
            cmdActualizarUsuario.Parameters.Add(new SqlParameter("@clave", usuarioActual.Clave));
            cmdActualizarUsuario.Parameters.Add(new SqlParameter("@id", usuarioActual.ID.ToString()));
            cmdActualizarUsuario.Parameters.Add(new SqlParameter("@hab", usuarioActual.Habilitado));

            //Abro la Conexión
            this.Conn.Open();
            //Ejecuto la instrucción SQL de UPDATE
            cmdActualizarUsuario.ExecuteNonQuery();
            //Cierro la Conexión
            this.Conn.Close();
        }

        public void AgregarUsuario(Usuario usuarioActual)
        {
            //Creo el comando para ejecutar la sentencia SQL de DELETE, 
            //le asocio la Conexión también
            SqlCommand cmdInsertarUsuario = new SqlCommand(" INSERT INTO usuarios(apellido, " +
                                               " nombre,email,nombre_usuario,clave,habilitado) " +
                                               " VALUES (@apellido,@nombre " +
                                               "@email,@usuario, @clave, @hab)", this.Conn);

            //Le agrego los parámetros necesarios
            
            cmdInsertarUsuario.Parameters.Add(new SqlParameter("@apellido", usuarioActual.Apellido));
            cmdInsertarUsuario.Parameters.Add(new SqlParameter("@nombre", usuarioActual.Nombre));
            cmdInsertarUsuario.Parameters.Add(new SqlParameter("@email", usuarioActual.Email));
            cmdInsertarUsuario.Parameters.Add(new SqlParameter("@usuario", usuarioActual.Nombre_Usuario));
            cmdInsertarUsuario.Parameters.Add(new SqlParameter("@clave", usuarioActual.Clave));
            cmdInsertarUsuario.Parameters.Add(new SqlParameter("@hab", usuarioActual.Habilitado));

            //Abro la Conexión
            this.Conn.Open();
            //Ejecuto la instrucción SQL de INSERT
            cmdInsertarUsuario.ExecuteNonQuery();
            //Cierro la Conexión
            this.Conn.Open();
        }



    }
}
