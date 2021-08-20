using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
   public class EspecialidadAdapter : Adapter
    {
        public EspecialidadAdapter()
        {

        }
        public List<Especialidad> GetAll()
        {
            List<Especialidad> especialidad = new List<Especialidad>();
            try
            {
                OpenConnection();

                SqlCommand cmdEspecialidad = new SqlCommand("SELECT * FROM especialidades", sqlConn);

                SqlDataReader drEspecialidad = cmdEspecialidad.ExecuteReader();

                while (drEspecialidad.Read())
                {
                    Especialidad esp = new Especialidad();

                    esp.ID = (int)drEspecialidad["id_Especialidad"];
                    esp.Desc_Especialidad = (string)drEspecialidad["desc_Especialidad"];

                    especialidad.Add(esp);
                }

                drEspecialidad.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Especialidades GetAll()", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }

            return especialidad;

        }
        public Especialidad GetOne(int ID)
        {
            Especialidad esp = new Especialidad();
            try
            {
                OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("SELECT * FROM especialidades WHERE id_Especialidad = @ID", sqlConn);
                cmdEspecialidad.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                SqlDataReader drEspecialidad = cmdEspecialidad.ExecuteReader();
                while (drEspecialidad.Read())
                {

                    esp.ID = (int)drEspecialidad["id_Especialidad"];
                    esp.Desc_Especialidad = (string)drEspecialidad["desc_Especialidad"];


                }
                drEspecialidad.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de Especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (esp.Desc_Especialidad != null)
            {
                return esp;
            }
            else
            {
                Exception Ex = new Exception(" ");
                throw new Exception("La especialidad no existe", Ex);
            }
        }
        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete especialidades where id_Especialidad = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar Especialidad", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.States.Deleted)
            {
                Delete(especialidad.ID);
            }

            else if (especialidad.State == BusinessEntity.States.New)
            {
                Insert(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                Update(especialidad);
            }
            especialidad.State = BusinessEntity.States.Unmodified;
        }
        protected void Update(Especialidad especialidad)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE especialidades SET desc_Especialidad = @descEsp, " +
                    "WHERE id_Especialidad = @id ", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = especialidad.ID;
                cmdSave.Parameters.Add("@descEsp", SqlDbType.VarChar, 50).Value = especialidad.Desc_Especialidad;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos de la Especialidad", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }

        }
        protected void Insert(Especialidad especialidad)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO especialidades (desc_Especialidad) " + "values(@descEsp)" +
                    "select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@descEsp", SqlDbType.VarChar, 50).Value = especialidad.Desc_Especialidad;

                especialidad.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());



            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear Especialidad (se encuentra en adapter) ", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }


        }
    }
}
