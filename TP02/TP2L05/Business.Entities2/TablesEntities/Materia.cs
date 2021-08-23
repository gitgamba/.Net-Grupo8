using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        private string _DescMateria;
        private int _HorasSem, _HorasTot, _IdPlan;

        public string DescMateria { get => _DescMateria; set => _DescMateria = value; }
        public int HorasSem { get => _HorasSem; set => _HorasSem = value; }
        public int HorasTot { get => _HorasTot; set => _HorasTot = value; }
        public int IdPlan { get => _IdPlan; set => _IdPlan = value; }
    }
}
