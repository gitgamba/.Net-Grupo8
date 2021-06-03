using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClasses1
{
    class Program
    {
        static void Main(string[] args)
        {
            A instancia_a = new A();
            B instancia_b = new B();

            string nombre = "Nombre";

            instancia_a.M1();
            instancia_a.M2();
            instancia_a.M3();
            instancia_b.M4();
            instancia_b.MostrarNombre(nombre);

            Console.ReadKey();
        }
    }
}
