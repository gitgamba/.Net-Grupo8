using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejs123
{

    class Ej123
    {
        static void Main(string[] args)
        {
            #region EJERCICIO 1
            /*string[] provincias = 
            {
                "Buenos Aires", "Catamarca", "Chaco", "Chubut", "Cordoba", "Corrientes", "Entre Rios", 
                "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquen", "Rio Negro", "Salta", "San Juan", 
                "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego", "Tucuman" 
            };
            //LINQ
            var prov = from p in provincias
                       where p.StartsWith("S") || p.StartsWith("T")
                       select p;

            Console.WriteLine("Las provincias que empiezan con S o T son: ");
            foreach(string element in prov)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();*/
            #endregion
            //-----------------------------------------------------------------------------------------------------------

            #region EJERCICIO 2
            /*List<int> numeros = new List<int>();
            int num;

            Console.WriteLine("Ingrese numeros. 0 para terminar");
            do
            {
                num = int.Parse(Console.ReadLine());
                numeros.Add(num);

            } while (num != 0);

            var mayores = from m in numeros
                          where m > 20
                          select m;

            Console.WriteLine();
            Console.WriteLine("Los numeros mayores a 20 son: ");
            foreach(int element in mayores)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();*/
            #endregion

            //-----------------------------------------------------------------------------------------------------------

            #region EJERCICIO 3
            ArrayList ciudades = new ArrayList();
            string busqueda;

            ciudades.Add(new Ciudad { Nombre = "ROSARIO", Codigo = 2000 });
            ciudades.Add(new Ciudad { Nombre = "FUNES", Codigo = 2132 });
            ciudades.Add(new Ciudad { Nombre = "PUEBLO ESTHER", Codigo = 2126 });

            Console.WriteLine("Ingrese expresion de busqueda con 3 letras (ejemplo para Rosario es 'ros'): ");
            busqueda = Console.ReadLine().ToUpper();

            var ciudadElegida = from Ciudad c in ciudades
                                where c.Nombre.Contains(busqueda)
                                select c.Codigo;
            Console.WriteLine();
            Console.Write("El codigo postal de la ciudad es: ");
            foreach(int codigo in ciudadElegida)
            {
                Console.WriteLine(codigo);
            }
            Console.ReadKey();
            #endregion
        }
    }

    #region Ejemplo sencillo de enum
    /*enum Semaforo
    {
        Rojo,
        RojoAmbar,
        Verde,
        Ambar
    };
    class DemoEnum
    {
        public static void Main()
        {
            Semaforo luz;
            luz = Semaforo.RojoAmbar;
            Console.WriteLine(luz);
            Console.ReadKey();
        }
    }*/
    #endregion
}
