using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic 
{
    public class EspecialidadLogic : BusinessLogic
    {
        public EspecialidadLogic()
        {
            this.EspecialidadData = new EspecialidadAdapter();
        }

        private EspecialidadAdapter _EspecialidadData;
        public EspecialidadAdapter EspecialidadData { get => _EspecialidadData; set => _EspecialidadData = value; }

        public Especialidad GetOneId(int ID)
        {
            try
            {
                return EspecialidadData.GetOne(ID);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public List<Especialidad> getAll()
        {
            try
            {
                return EspecialidadData.GetAll();
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
                EspecialidadData.Delete(ID);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void Save(Especialidad com)
        {
            try
            {
            EspecialidadData.Save(com);
        }
            catch (Exception Ex) { throw Ex; }
}

    }
}
