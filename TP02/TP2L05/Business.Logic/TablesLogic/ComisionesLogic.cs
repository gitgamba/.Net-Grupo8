using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ComisionesLogic : BusinessLogic
    {
       public ComisionesLogic()
        {
            this.ComisionesData = new ComisionesAdapter();
        }

        private ComisionesAdapter _ComisionesData;
public ComisionesAdapter ComisionesData { get => _ComisionesData; set => _ComisionesData = value; }

        public Comisiones GetOneId(int ID)
        {
            try
            {
                return ComisionesData.GetOne(ID);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public List<Comisiones> getAll()
        {
            try
            {
                return ComisionesData.GetAll();
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
                ComisionesData.Delete(ID);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void Save(Comisiones com)
        {
            try
            {
                ComisionesData.Save(com);
            }
            catch (Exception Ex) { throw Ex; }
        }
      
    }
}

