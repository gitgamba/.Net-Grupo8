using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Comisiones : BusinessEntity
    {
<<<<<<< HEAD

        private string _DescComision;
        private int _AnioEspecialidad , _IdPlan; // seleccionar las 3 y hacer ctrl R ctrl E para inicializar

        public string DescComision { get => _DescComision; set => _DescComision = value; }
=======
        private string _Descripcion;
        private int _AnioEspecialidad, _IdPlan;

        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
>>>>>>> 2b74063e1ed834291b3066b652e3ba4681257c49
        public int AnioEspecialidad { get => _AnioEspecialidad; set => _AnioEspecialidad = value; }
        public int IdPlan { get => _IdPlan; set => _IdPlan = value; }
    }
}
