using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic
{
    public class MateriasLogic : BusinessLogic
    {
        public MateriasLogic()
        {
            this.MateriasData = new MateriasAdapter();
        }
        private MateriasAdapter MateriasData;
        public MateriasAdapter MateriasData { get => MateriasData; set => MateriasData = value; }

        public Materias GetOneId(int ID)
        {
            try
            {
                return MateriasData.GetOne(ID);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }

}
