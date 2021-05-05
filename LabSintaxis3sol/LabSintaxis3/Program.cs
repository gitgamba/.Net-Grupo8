using System;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            string[] lista = new string[6];
          

            Console.WriteLine("inicio");
                Console.WriteLine();


            for (int i =0 ; i < cantIteraciones ; i++)
            {
                lista[i] = Console.ReadLine();
            }
            
            Console.WriteLine();
            Console.WriteLine("mostrar");
            Console.WriteLine();
            
            for (int i = (cantIteraciones); i > -1; i--)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}
