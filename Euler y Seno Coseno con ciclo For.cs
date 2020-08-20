using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int n = 100;
            double sum = 0;

            Console.WriteLine(" ingrese valor de x: ");
            double x = double.Parse(Console.ReadLine());

            Double xrad = (180 * x) / Math.PI;
            //ejercicio 2
            for (int i = 0; i <= n; i++)
            {
                double y = (2 * i);
                sum += ((Math.Pow(-1, i)) / Factorial(y) )* Math.Pow(xrad, y);
            }
            
            Console.WriteLine(sum);

            //EJERCICIO 1
            //for (int i = 0; i <= n; i++)
            //{
                
            //    sum += Math.Pow(x, i) / Factorial(i);
            //}
            //Console.WriteLine(sum);

        }
        static double Factorial (double valor)
        {
            double total = 1;
            for (double i = valor; i > 1; i--)
            {
                total *= i;
            }
            return total;
        }
        
    }
}
