using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ComisionesAdapter : Adapter
    {
        public List<Comisiones> GetAll()
        {

            //return new List<Usuario>(Usuarios);
            ///
            // Instanciamos el objeto lista a retornar
            List<Comisiones> Comisiones = new List<Comisiones>();


            try
            {
                // abrimos la conexión a la base de datos con el método que creamos antes 
                this.OpenConnection();

                /* 
                 * creamos un objeto SqlCommand que será la sentencia SQL 
                 * que vamos a ejecutar contra la base de datos 
                 * (los datos de la BD usaurio,contraseñam servidor,etc.
                 * están en el connection string)
                 */

                SqlCommand cmdComisiones = new SqlCommand("select * from comisiones", sqlConn);
                // 
                //instanciamos un objeto DataReader que será
                //   el que recuperará los datos de la BD
                //

                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();

                // Read() lee una fila de las devueltas por el comando sql
                // carga los datos en drUsuarios para poder accederlos,"
                // devuelve verdadero mientras haya podido leer datos
                // y avanza a la fila siguiente para el próximo read
                //
                while (drComisiones.Read())
                {
                    /// 
                    //  creamos un objeto Usuario de la capa de entidades para copiar
                    //  los datos de la fila del DataRead er al objeto de entidades
                    //
                   Comisiones com = new Comisiones();

                    //ahora copiamos los datos de la fila al objeto

                    com.ID = (int)drComisiones["id_comision"];
                    com.DescComision = (string)drComisiones["desc_comision"];
                    com.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                    com.IdPlan = (int)drComisiones["id_plan"];





                    //agregarnos el objeto con datos a la lista que devolveremos
                    Comisiones.Add(com);
                    
                }
                //cerramos la el DataReader y la conexión a la BD

                drComisiones.Close();

            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de usuarios", Ex);
                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }

            //devolvemos el objeto
            return Comisiones;




        }

        public Business.Entities.Comisiones GetOneId(int IdPlan)
        {
            //return Usuarios.Find(delegate(Usuario u) { return u.ID == ID; });
            Comisiones com = new Comisiones();
            try
            {
                OpenConnection();
                SqlCommand cmdComisiones = new SqlCommand("SELECT * FROM comisiones WHERE id_comision = @id_comision", sqlConn);
                cmdComisiones.Parameters.Add("@id_comision", SqlDbType.Int).Value = IdPlan;
                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();
                while (drComisiones.Read())
                {
                    com.ID = (int)drComisiones["id_comision"];
                    com.DescComision = (string)drComisiones["desc_comision"];
                    com.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                    com.IdPlan = (int)drComisiones["id_plan"];

                }
                drComisiones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (com.DescComision != null)
            {
                return com;
            }
            else
            {
                Exception Ex = new Exception(" ");
                throw new Exception("La comision no existe", Ex);
            }

        }

        public void Delete(int ID)
        {
            ////Comisiones.Remove(this.GetOne(ID));
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete comisiones where id_comision = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar comision", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Save(Comisiones comisiones)
        
        {
            if (comisiones.State == BusinessEntity.States.Deleted)
            {
                Delete(comisiones.ID);
            }

            else if (comisiones.State == BusinessEntity.States.New)
            {
                Insert(comisiones);
            }
            else if (comisiones.State == BusinessEntity.States.Modified)
            {
                Update(comisiones);
            }
            comisiones.State = BusinessEntity.States.Unmodified;
        }

        protected void Insert(Comisiones comisiones)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO comisiones (desc_comisiones , anio_especialidad ,id_plan)" +
                    "values(@desCom,@AnioEsp,@IdPlan)" +
                    "select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@desCom", SqlDbType.VarChar, 50).Value = comisiones.DescComision;
                cmdSave.Parameters.Add("@AnioEsp", SqlDbType.VarChar, 50).Value = comisiones.AnioEspecialidad;
                cmdSave.Parameters.Add("@IdPlan", SqlDbType.Bit).Value = comisiones.IdPlan;
               

                comisiones.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

                //cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear comision", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        protected void Update(Comisiones comisiones)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE comisiones SET desc_comisiones = @desCom, Anio_Especialidad = @AnioEsp, " +
                    "id_plan = @IdPlan", sqlConn);

                cmdSave.Parameters.Add("@desCom", SqlDbType.VarChar, 50).Value = comisiones.DescComision;
                cmdSave.Parameters.Add("@AnioEsp", SqlDbType.VarChar, 50).Value = comisiones.AnioEspecialidad;
                cmdSave.Parameters.Add("@IdPlan", SqlDbType.Bit).Value = comisiones.IdPlan;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos de la comision", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }

        }



    }
}
