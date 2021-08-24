using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
   public class PlanAdapter : Adapter
    {
   
    public PlanAdapter()
    {

    }
    public List<Plan> GetAll()
    {
        List<Plan> Plan = new List<Plan>();
        try
        {
            OpenConnection();

            SqlCommand cmdPlan = new SqlCommand("SELECT * FROM Planes", sqlConn);

            SqlDataReader drPlan = cmdPlan.ExecuteReader();

            while (drPlan.Read())
            {
                Plan pl = new Plan();

               pl.ID = (int)drPlan["id_Plan"];
               pl.Desc_plan = (string)drPlan["desc_plan"];
               pl.Id_Especialidad = (int)drPlan["id_especialidad"];
               Plan.Add(pl);
            }

            drPlan.Close();
        }
        catch (Exception Ex)
        {
            Exception ExcepcionManejada = new Exception("Error al recuperar lista de Planes GetAll()", Ex);
            throw ExcepcionManejada;
        }
        finally
        {
            CloseConnection();
        }

        return Plan;

    }
    public Plan GetOne(int ID)
    {
        Plan pl = new Plan();
        try
        {
            OpenConnection();
            SqlCommand cmdPlan = new SqlCommand("SELECT * FROM Planes WHERE id_Plan = @ID", sqlConn);
            cmdPlan.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            SqlDataReader drPlan = cmdPlan.ExecuteReader();
            while (drPlan.Read())
            {

                    pl.ID = (int)drPlan["id_Plan"];
                    pl.Desc_plan = (string)drPlan["desc_plan"];
                    pl.Id_Especialidad = (int)drPlan["id_plan"];

                }
            drPlan.Close();
        }
        catch (Exception Ex)
        {
            Exception ExcepcionManejada = new Exception("Error al recuperar datos de Plan", Ex);
            throw ExcepcionManejada;
        }
        finally
        {
            CloseConnection();
        }
        if (pl.Desc_plan != null)
        {
            return pl;
        }
        else
        {
            Exception Ex = new Exception(" ");
            throw new Exception("El Plan no existe", Ex);
        }
    }
    public void Delete(int ID)
    {
        try
        {
            OpenConnection();
            SqlCommand cmdDelete = new SqlCommand("delete planes where id_Plan = @id", sqlConn);
            cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            cmdDelete.ExecuteNonQuery();
        }
        catch (Exception Ex)
        {
            Exception ExcepcionManjeada = new Exception("Error al eliminar Plan", Ex);
            throw ExcepcionManjeada;
        }
        finally
        {
            CloseConnection();
        }
    }
    public void Save(Plan Plan)
    {
        if (Plan.State == BusinessEntity.States.Deleted)
        {
            Delete(Plan.ID);
        }

        else if (Plan.State == BusinessEntity.States.New)
        {
            Insert(Plan);
        }
        else if (Plan.State == BusinessEntity.States.Modified)
        {
            Update(Plan);
        }
        Plan.State = BusinessEntity.States.Unmodified;
    }
    protected void Update(Plan Plan)
    {
        try
        {
            OpenConnection();
            SqlCommand cmdSave = new SqlCommand("UPDATE Planes SET desc_Plan = @descPlan, " +
                "id_Especialidad = @IdEsp" +
                "WHERE id_Plan = @id ", sqlConn);

            cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = Plan.ID;
            cmdSave.Parameters.Add("@descPlan", SqlDbType.VarChar, 50).Value = Plan.Desc_plan;
            cmdSave.Parameters.Add("@IdEsp", SqlDbType.Int).Value = Plan.Id_Especialidad;
            cmdSave.ExecuteNonQuery();
        }
        catch (Exception Ex)
        {
            Exception ExceptionManejada = new Exception("Error al modificar datos del Plan", Ex);
            throw ExceptionManejada;
        }
        finally
        {
            CloseConnection();
        }

    }
    protected void Insert(Plan Plan)
    {
        try
        {
            OpenConnection();
            SqlCommand cmdSave = new SqlCommand("INSERT INTO Planes (desc_plan,id_especialidad) " +
                                                             "values(@desPl,@idEsp) " +
                "select @@identity ", sqlConn);


                cmdSave.Parameters.Add("@desPl", SqlDbType.VarChar, 50).Value = Plan.Desc_plan;
                cmdSave.Parameters.Add("@idEsp", SqlDbType.Int).Value = Plan.Id_Especialidad;

            Plan.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());

        }
        catch (Exception Ex)
        {
            Exception ExceptionManejada = new Exception("Error al crear plan", Ex);
            throw ExceptionManejada;
        }
        finally
        {
            CloseConnection();
        }
    }
}
}
