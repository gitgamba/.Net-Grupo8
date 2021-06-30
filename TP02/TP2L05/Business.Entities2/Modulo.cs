using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities
{
   public class Modulo:BusinessEntity
    {
        private string _Descripcion;

        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}
