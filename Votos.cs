using System;
using System.Linq;
using System.Threading;

namespace votos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("número de votos por el partido 1");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("número de votos por el partido 2");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("número de votos en blanco");
            int Blanco = int.Parse(Console.ReadLine());

            Console.WriteLine("número de votos anulados");
            int anulados = int.Parse(Console.ReadLine());

            Console.WriteLine("número total de la población de todas las edades");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("el porcentaje (de 0 a 100%) de la poblacion que es mayor de edad");
            int p = int.Parse(Console.ReadLine());


            int abs = (int)(n * (p / 100)) - (a + b + Blanco + anulados);

            bool c1 = anulados < (a + b) * 0.3;
            bool c2 = Blanco < (a + b);
            bool c3 = abs < n;

            if ((c1 || c2) && c3)
            {
                Console.WriteLine("las votaciones fueron exitosas");

                if (b < a)
                {
                    Console.WriteLine("El partido 1 es el ganador");
                }
                else
                {
                    Console.WriteLine("El partido 2 es el ganador");
                }
            }
            else
            {
                Console.WriteLine("las elecciones deben hacerse otra vez");
            }
        }
    }
}

