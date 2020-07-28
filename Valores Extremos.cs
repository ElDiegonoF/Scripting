using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            int i = 0, max = 0, min = 0;
            string maxname = "a", minname = "s";
            Console.Write("Ingrese El numero de datos (n):   ");
            int n = int.Parse(Console.ReadLine());
            
            while (i < n)
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.Write("Nombre:");
                string name = (Console.ReadLine());

                if (i == 0)
                {
                    max = edad;
                    min = edad;
                    maxname = name;
                    minname = name;
                }
                if (edad > max) 
                {
                    max = edad;
                    maxname = name;
                }
                if ( min > edad)
                {
                    min = edad;
                    minname = name;
                }
                total += edad;
                i++;

            }
            double promedio = total / n;
            Console.WriteLine("Promedio= " + promedio);
            Console.WriteLine("Mayor= " + max + "Nombre del mayor:" + maxname);
            Console.WriteLine("Menor= " + min + "Nombre del menor:" + minname);
        }
    }
}
