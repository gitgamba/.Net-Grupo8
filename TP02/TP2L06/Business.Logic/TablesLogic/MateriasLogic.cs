using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;
using Data.Database.TablesAdapter;

namespace Business.Logic
{
    public class MateriasLogic : BusinessLogic
    {
        public MateriasLogic()
        {
            this.MateriaData = new MateriasAdapter();
        }
        private MateriasAdapter _MateriaData;
        public MateriasAdapter MateriaData { get => _MateriaData; set => _MateriaData = value; }

        public Materia GetOneId(int ID)
        {
            try
            {
                return MateriaData.GetOne(ID);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public List<Materia> getAll()
        {
            try
            {
                return MateriaData.GetAll();
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
                MateriaData.Delete(ID);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void Save(Materia com)
        {
            //try
            //{
            MateriaData.Save(com);
            //}
            //catch (Exception Ex) { throw Ex; }
        }

    }
}


