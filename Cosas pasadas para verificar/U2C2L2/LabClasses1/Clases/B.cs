using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class B : A
    {

        public B() : base("Instancia de B"){

        }

        public void M4()
        {
            Console.WriteLine("Mensaje del hijo Invocado");
        }

    }
}
