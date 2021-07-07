using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Plan:BusinessEntity
    {
        private string _Desc_plan;
        private int _Id_Especialidad;
        public string Desc_plan { get => _Desc_plan; set => _Desc_plan = value; }
        public int Id_Especialidad { get => _Id_Especialidad; set => _Id_Especialidad = value; }
    }
}
