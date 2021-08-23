using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;


namespace Data.Database.TablesAdapter
{
    public class MateriasAdapter : Adapter
    {
        public MateriasAdapter()
        {

        }
        public List<Materia> GetAll()
        {
            List<Materia> Materia = new List<Materia>();
            try
            {
                OpenConnection();

                SqlCommand cmdMateria = new SqlCommand("SELECT * FROM materias", sqlConn);

                SqlDataReader drMateria = cmdMateria.ExecuteReader();

                while (drMateria.Read())
                {
                    Materia mat = new Materia();

                    mat.ID = (int)drMateria["id_materia"];
                    mat.DescMateria = (string)drMateria["desc_materia"];
                    mat.HorasSem = (int)drMateria["hs_semanales"];
                    mat.HorasTot = (int)drMateria["hs_totales"];
                    mat.IdPlan = (int)drMateria["id_plan"];
                    Materia.Add(mat);
                }

                drMateria.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Materiaes GetAll()", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }

            return Materia;

        }
        public Materia GetOne(int ID)
        {
            Materia mat = new Materia();
            try
            {
                OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("SELECT * FROM Materias WHERE id_materia = @ID", sqlConn);
                cmdMateria.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                SqlDataReader drMateria = cmdMateria.ExecuteReader();
                while (drMateria.Read())
                {
                    mat.ID = (int)drMateria["id_materia"];
                    mat.DescMateria = (string)drMateria["desc_materia"];
                    mat.HorasSem = (int)drMateria["hs_semanales"];
                    mat.HorasTot = (int)drMateria["hs_totales"];
                    mat.IdPlan = (int)drMateria["id_plan"];
                }
                drMateria.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de Materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            if (mat.DescMateria != null)
            {
                return mat;
            }
            else
            {
                Exception Ex = new Exception(" ");
                throw new Exception("La Materia no existe", Ex);
            }
        }
        public void Delete(int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete Materias where id_Materia = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManjeada = new Exception("Error al eliminar la Materia", Ex);
                throw ExcepcionManjeada;
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Save(Materia Materia)
        {
            if (Materia.State == BusinessEntity.States.Deleted)
            {
                Delete(Materia.ID);
            }

            else if (Materia.State == BusinessEntity.States.New)
            {
                Insert(Materia);
            }
            else if (Materia.State == BusinessEntity.States.Modified)
            {
                Update(Materia);
            }
            Materia.State = BusinessEntity.States.Unmodified;
        }
        protected void Update(Materia Materia)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE Materias SET desc_Materia = @descMat, " +
                    "hs_semanales = @HsSem, hs_totales = @HsTot , id_plan = @IdPlan " +
                    "WHERE id_materia = @id ", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = Materia.ID;
                cmdSave.Parameters.Add("@descMat", SqlDbType.VarChar, 50).Value = Materia.DescMateria;
                cmdSave.Parameters.Add("@HsSem", SqlDbType.Int).Value = Materia.HorasSem;
                cmdSave.Parameters.Add("@HsTot", SqlDbType.Int).Value = Materia.HorasTot;
                cmdSave.Parameters.Add("@IdPlan", SqlDbType.Int).Value = Materia.IdPlan;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del Materia", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }

        }
        protected void Insert(Materia Materia)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO Materiaes (desc_Materia,hs_semanales, hs_totales,id_plan) " +
                                                                             "values(@desCom,@HsSem,@HsTot,@IdPlan) " +
                    "select @@identity ", sqlConn);

                cmdSave.Parameters.Add("@descMat", SqlDbType.VarChar, 50).Value = Materia.DescMateria;
                cmdSave.Parameters.Add("@HsSem", SqlDbType.Int).Value = Materia.HorasSem;
                cmdSave.Parameters.Add("@HsTot", SqlDbType.Int).Value = Materia.HorasTot;
                cmdSave.Parameters.Add("@IdPlan", SqlDbType.Int).Value = Materia.IdPlan;

                Materia.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al crear Materia", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

    }

}
