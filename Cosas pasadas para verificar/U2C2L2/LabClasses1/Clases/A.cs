using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class A
    {

        private string NombreInst;
        private string _nomInst;

        public string NI
        {
            get
            {
                return _nomInst;
            }
            set
            {
                _nomInst = value;
            }
        }

        public A() {
            NombreInst = "Instancia sin nombre";     
        }

        public A(string nombre)
        {
            NombreInst = nombre;
        }

        public void MostrarNombre(string nombre)
        {
            Console.WriteLine(nombre);
        }

        public void M1()
        {
            Console.WriteLine("M1 invocado");
        }
        public void M2()
        {
            Console.WriteLine("M2 invocado");
        }
        public void M3()
        {
            Console.WriteLine("M3 invocado");
        }


    }

}
