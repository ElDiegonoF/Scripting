using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random aleatorio = new Random();

            // dados 
            int dado = 0;
            int dado2 = 0;

            int total = 0;//total acumulado

            int l = 3; // vidas

            int t = 2; //Turnos para perder vida

            int p = 0; // Turnos para dos dados

            int turnos = 0; //Turnos Jugados
            

            while (99 > total)
            {

                //dados
            
                Console.WriteLine(" ¿Desea seguir? ");
                string yes = Console.ReadLine();
                if (yes == "s")
                {
                    dado = aleatorio.Next(1, 7);
                    Console.WriteLine(" (Dado): " + dado);
                    total += (dado);
                    t--;
                    p++;
                    turnos++;
                }
                else if (yes == "n")
                {
                    Console.WriteLine(" (Perdiste) ");
                    break;
                }
                

                //ciclo en el turno 3
                if (p == 3)
                {
                    dado2 = aleatorio.Next(1, 7);
                    Console.WriteLine(" (Dado2): " + dado2);
                    total += (dado2);
                    p = 0;
                }
                
                Console.WriteLine(" total= " + total);
                Console.WriteLine(" vidas= " + l);
                Console.WriteLine(" Turnos Jugados : " + turnos);

                if (t == 0)//Cuando el Jugador pierda una vida por cada 2 turnos
                {
                    l--;
                    t = 2;
                }

                if (total > 99) // si el jugador supera los 100 puntos
                {
                    Console.WriteLine(" (Ganaste) ");
                    break;
                }

                if (l == 0) //Si el jugador se queda sin vidas
                {
                    Console.WriteLine(" (Perdiste) ");
                    break;
                }

                if((dado == dado2) && 3 > l)
                {
                    l++;
                }

            }

            Console.WriteLine(" total: " + total);
            Console.WriteLine(" (Gracias por jugar) ");
            Console.WriteLine(" Quedaste con " + l + " vidas. ");
            Console.WriteLine(" Turnos Jugados : " + turnos);
        }
    }
}
