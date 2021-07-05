using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Comisiones : BusinessEntity
    {
        private string _Descripcion;
        private int _AnioEspecialidad, _IdPlan;

        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int AnioEspecialidad { get => _AnioEspecialidad; set => _AnioEspecialidad = value; }
        public int IdPlan { get => _IdPlan; set => _IdPlan = value; }
    }
}
