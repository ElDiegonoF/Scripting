using System;

namespace tutoria_3_semana_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos 
            Console.WriteLine("Ingrese estadura en cm:");
            Double estatura = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese peso en Kg:");
            double peso = double.Parse(Console.ReadLine());

            //calculo IMC
            Double Indice = (peso / (estatura * estatura));

            if (Indice < 18.5)
            {
                Console.WriteLine("tas de bajo del peso normal ");
            }
            else if (18.5 < Indice && Indice < 24.9)
            {
                Console.WriteLine("Peso normal ");
            }
            else if (25.0 < Indice && Indice < 29.9)
            {
                Console.WriteLine("Tu peso es superior al normal ");
            }
            else 
            {
                Console.WriteLine("estás gordo ceboso");
            }
        }
    }
}
