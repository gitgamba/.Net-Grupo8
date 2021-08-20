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
            this.ComisionData = new ComisionAdapter();
        }

        private ComisionAdapter _ComisionData;
        public ComisionAdapter ComisionData { get => _ComisionData; set => _ComisionData = value; }

        public Comision GetOneId(int ID)
        {
            try
            {
                return ComisionData.GetOne(ID);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public List<Comision> getAll()
        {
            try
            {
                return ComisionData.GetAll();
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
                ComisionData.Delete(ID);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void Save(Comision com)
        {
            //try
            //{
                ComisionData.Save(com);
            //}
            //catch (Exception Ex) { throw Ex; }
        }
      
    }
}

