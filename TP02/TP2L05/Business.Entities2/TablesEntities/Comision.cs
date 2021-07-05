using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {

        private string _DescComision;
        private int _AnioEspecialidad , _IdPlan; // seleccionar las 3 y hacer ctrl R ctrl E para inicializar

        public string DescComision { get => _DescComision; set => _DescComision = value; }
        public int AnioEspecialidad { get => _AnioEspecialidad; set => _AnioEspecialidad = value; }
        public int IdPlan { get => _IdPlan; set => _IdPlan = value; }
    }
}
