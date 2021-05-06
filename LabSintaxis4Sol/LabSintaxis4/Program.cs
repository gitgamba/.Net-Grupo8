using System;

namespace LabSintaxis4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 4.1
            /*  
                         int nro1 = 0;
                         int nro2 = 0;
                         Console.WriteLine("Ingrese dos numeros de manera consecutiva");
                         nro1 = int.Parse(Console.ReadLine());
                         nro2 = int.Parse(Console.ReadLine());
                         Console.WriteLine("El resultado de la suma de " + nro1 + " y " + nro2 + " es " + (nro1 + nro2));
            */
            //Ejercicio 4.2
            /*
                    Console.WriteLine("Ingrese un año");
                    int año = int.Parse(Console.ReadLine());

                    if (((año % 4) == 0))
                        {
                            if (año % 100 == 0)
                                {
                                    if (año % 400 == 0)
                                        {
                                            Console.WriteLine("El año es bisiesto");
                                        }
                                    else Console.WriteLine("El año no es bisiesto");
                                }
                            else Console.WriteLine("El año es bisiesto");
                        }
                    else Console.WriteLine("El año no es bisiesto");
           */
            //Ejercicio 4.3 Fibonacci 
            int i, n1, n2, n3;
            
            
            
            n1 = 0;
            n2 = 1;
            n3 = 0;



            Console.WriteLine(n1);
                Console.WriteLine(n2);
            for (i = 0; i < 20; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;

                Console.WriteLine(n3);
                }






           


        }
    }
}
