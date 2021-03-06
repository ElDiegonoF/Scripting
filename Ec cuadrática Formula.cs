﻿using System;

namespace Formula_ecuacion_cuadratica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos 
            Console.WriteLine("Ingrese a:");
            Double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese peso en b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese peso en c:");
            double c = double.Parse(Console.ReadLine());

            //calculo de la ecuación cuadrática
            Double discriminante = ((b * b) - (4) * (a) * (c));

            if (discriminante == 0)
            {
                double x = -b / (a * 2);
                Console.WriteLine("Solo hay una solución" + x);
            }
            else if (discriminante > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (a * 2);
                double x2 = (-b - Math.Sqrt(discriminante)) / (a * 2);
                Console.WriteLine("Hay dos soluciones:");
                Console.WriteLine("X1:" + x1);
                Console.WriteLine("X2:" + x2);
            }
            else
            {
                Console.WriteLine("No hay ni una posible solución");
            }
        }
    }
}
