using System;

namespace Dado_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            bool gameover = false;
            int t = 0;
            int dado1 = 0;
            int dado2 = 0;
            int total = 0;

            int a = 0;

            while (100 > total && gameover != true)
            {
                Console.WriteLine(" ¿Quieres continuar? ");
                string si = Console.ReadLine();

                if (si == "s")
                {
                    dado1 = aleatorio.Next(1, 7);
                    dado2 = aleatorio.Next(1, 7);
                    total += (dado1 + dado2);
                    t++;
                    Console.WriteLine(" dado1= " + dado1 + "dado2= " + dado2);
                    Console.WriteLine(" Total= " + total);

                    if ((dado1 + dado2) > 6)
                    {
                        a++;
                    }
                    else if (dado1 == 1 && dado2 == 1)
                    {
                        Console.WriteLine(" (Perdiste) ");
                        gameover = true;
                    }
                }
                else if (si == "n")
                {
                    Console.WriteLine(" (Perdiste) ");
                    gameover = true;
                }
            }
            if (total > 99)
            {
                Console.WriteLine(" (ganaste) ");
            }
            double porcentaje = ((double) a / t)*100;
            Console.WriteLine("porcentaje de turnos que sacaste más de 6" + porcentaje);
            Console.WriteLine(" total: " + total);
            Console.WriteLine(" Gracias por jugar ");
        }
    }
}