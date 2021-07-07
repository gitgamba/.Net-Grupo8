using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic
{
   public class PlanLogic : BusinessLogic
    {
        public PlanLogic()
        {
            this.PlanData = new PlanAdapter();
        }

        private PlanAdapter _PlanData;
        public PlanAdapter PlanData { get => _PlanData; set => _PlanData = value; }

        public Plan GetOneId(int ID)
        {
            try
            {
                return PlanData.GetOne(ID);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public List<Plan> getAll()
        {
            try
            {
                return PlanData.GetAll();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void Delete(int ID)
        {
            try
            {
                PlanData.Delete(ID);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void Save(Plan pl)
        {
            try
            {
                PlanData.Save(pl);
            }
            catch (Exception Ex) { throw Ex; }
        }

    }

}

