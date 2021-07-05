using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
=======
>>>>>>> 2b74063e1ed834291b3066b652e3ba4681257c49
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

<<<<<<< HEAD
=======

>>>>>>> 2b74063e1ed834291b3066b652e3ba4681257c49
namespace Data.Database
{
    public class ComisionesAdapter : Adapter
    {
<<<<<<< HEAD
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
=======
        public ComisionesAdapter()
        {

        }
        public List<Comisiones> GetAll()
        {
            List<Comisiones> comisiones = new List<Comisiones>();
            try
            {
                OpenConnection();

                SqlCommand cmdComisiones = new SqlCommand("SELECT * FROM comisiones", sqlConn);

                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();

                while (drComisiones.Read())
                {
                    Comisiones com = new Comisiones();

                    com.ID = (int)drComisiones["id_comision"];
                    com.Descripcion = (string)drComisiones["desc_comision"];
                    com.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                    com.IdPlan = (int)drComisiones["id_plan"];
                    comisiones.Add(com);
                }

                drComisiones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de comisiones GetAll()", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }

            return comisiones;

        }
        public Comisiones GetOne(int ID)
        {
>>>>>>> 2b74063e1ed834291b3066b652e3ba4681257c49
            Comisiones com = new Comisiones();
            try
            {
                OpenConnection();
<<<<<<< HEAD
                SqlCommand cmdComisiones = new SqlCommand("SELECT * FROM comisiones WHERE id_comision = @id_comision", sqlConn);
                cmdComisiones.Parameters.Add("@id_comision", SqlDbType.Int).Value = IdPlan;
=======
                SqlCommand cmdComisiones = new SqlCommand("SELECT * FROM comisiones WHERE id_comision = @ID", sqlConn);
                cmdComisiones.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
>>>>>>> 2b74063e1ed834291b3066b652e3ba4681257c49
                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();
                while (drComisiones.Read())
                {
                    com.ID = (int)drComisiones["id_comision"];
<<<<<<< HEAD
                    com.DescComision = (string)drComisiones["desc_comision"];
                    com.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
=======
                    com.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                    com.Descripcion = (string)drComisiones["desc_comision"];
>>>>>>> 2b74063e1ed834291b3066b652e3ba4681257c49
                    com.IdPlan = (int)drComisiones["id_plan"];

                }
                drComisiones.Close();
            }
            catch (Exception Ex)
            {
<<<<<<< HEAD
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de usuario", Ex);
=======
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de comision", Ex);
>>>>>>> 2b74063e1ed834291b3066b652e3ba4681257c49
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
<<<<<<< HEAD
            if (com.DescComision != null)
=======
            if (com.Descripcion != null)
>>>>>>> 2b74063e1ed834291b3066b652e3ba4681257c49
            {
                return com;
            }
            else
            {
                Exception Ex = new Exception(" ");
                throw new Exception("La comision no existe", Ex);
            }
<<<<<<< HEAD

        }

        public void Delete(int ID)
        {
            ////Comisiones.Remove(this.GetOne(ID));
=======
        }
        public void Delete(int ID)
        {
>>>>>>> 2b74063e1ed834291b3066b652e3ba4681257c49
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete comisiones where id_comision = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
<<<<<<< HEAD
                Exception ExcepcionManjeada = new Exception("Error al eliminar comision", Ex);
=======
                Exception ExcepcionManjeada = new Exception("Error al eliminar la comision", Ex);
>>>>>>> 2b74063e1ed834291b3066b652e3ba4681257c49
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }
<<<<<<< HEAD

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
=======
        public void Save(Comisiones comision)
        {
            if (comision.State == BusinessEntity.States.Deleted)
            {
                Delete(comision.ID);
            }

            else if (comision.State == BusinessEntity.States.New)
            {
                Insert(comision);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                Update(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
        }
        protected void Update(Comisiones comision)
>>>>>>> 2b74063e1ed834291b3066b652e3ba4681257c49
        {
            try
            {
                OpenConnection();
<<<<<<< HEAD
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
=======
                SqlCommand cmdSave = new SqlCommand("UPDATE comisiones SET desc_comision = @descCom, " +
                    "anio_especialidad= @AnioEsp, id_plan = @IdPlan " +
                    "WHERE id_comision = @id ", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = comision.ID;
                cmdSave.Parameters.Add("@descCom", SqlDbType.VarChar, 50).Value = comision.Descripcion;
                    ;
                cmdSave.Parameters.Add("@AnioEsp", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@IdPlan", SqlDbType.Int).Value = comision.IdPlan;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del comision", Ex);
>>>>>>> 2b74063e1ed834291b3066b652e3ba4681257c49
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
<<<<<<< HEAD
        }

        protected void Update(Comisiones comisiones)
=======

        }
        protected void Insert(Comisiones comision)
>>>>>>> 2b74063e1ed834291b3066b652e3ba4681257c49
        {
            try
            {
                OpenConnection();
<<<<<<< HEAD
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
=======
                SqlCommand cmdSave = new SqlCommand("INSERT INTO comisiones (desc_comision,anio_especialidad,id_plan) " +
                    "values(@desCom,@AnioEsp,@IdPlan) " +
                    "select @@identity ", sqlConn);


                cmdSave.Parameters.Add("@desCom", SqlDbType.VarChar, 50).Value = comision.Descripcion;
                cmdSave.Parameters.Add("@AnioEsp", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@IdPlan", SqlDbType.Int).Value = comision.IdPlan;

                comision.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear comision", Ex);
>>>>>>> 2b74063e1ed834291b3066b652e3ba4681257c49
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
<<<<<<< HEAD

        }



    }
=======
        }
    }


>>>>>>> 2b74063e1ed834291b3066b652e3ba4681257c49
}
