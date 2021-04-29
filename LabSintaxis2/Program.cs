using System;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText;

            Console.WriteLine("Ingrese un texto");
            Console.WriteLine();

            inputText = Console.ReadLine();
            if (!(string.IsNullOrEmpty(inputText)))
            {
                Console.Clear();
                Console.WriteLine("texto: ");
                Console.WriteLine(inputText);
            }
            else Console.WriteLine("no ingreso nada");
            Console.Clear();

            //Menu de opciones con case 


            Console.WriteLine("Menu con IF");
            Console.WriteLine("Elija una unica opcion");
            Console.WriteLine();
            Console.WriteLine("1) Mostrar la frase en mayusculas");
            Console.WriteLine("2) Mostrar la frase en minusculas");
            Console.WriteLine("3) Mostrar Cantidad de caracteres");

            ConsoleKeyInfo opcion = Console.ReadKey();


            Console.Clear();

            if (opcion.Key == ConsoleKey.D1) Console.WriteLine(inputText.ToUpper());
            else if (opcion.Key == ConsoleKey.D2) Console.WriteLine(inputText.ToLower());
            else if (opcion.Key == ConsoleKey.D3) Console.WriteLine(inputText.Length);

            Console.ReadKey();



            Console.Clear();
            Console.WriteLine("Menu con Case");
            Console.WriteLine("Elija una unica opcion");
            Console.WriteLine();
            Console.WriteLine("1) Mostrar la frase en mayusculas");
            Console.WriteLine("2) Mostrar la frase en minusculas");
            Console.WriteLine("3) Mostrar Cantidad de caracteres");
            int option; option = Console.Read();
            switch (option)
            {
                case '1':
                    Console.WriteLine(inputText.ToUpper());
                    break;

                case '2':
                    Console.WriteLine(inputText.ToLower());
                    break;
                case '3':
                    Console.WriteLine(inputText.Length);
                    break;

            }
            Console.ReadKey();
            
 
        
        
        }}}

