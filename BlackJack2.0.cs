using System;
using System.Xml;

namespace BlackJack2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int contador = 0;
            string si = "s";

            Console.WriteLine(" ¿Cuantos jugadores van a participar? (2 a 5)");//numero de jugadores a participar
            int jugadores = int.Parse(Console.ReadLine());
            while((jugadores < 2)|| (5 < jugadores))
            {
                Console.WriteLine("ERROR. mínimo 2 y máximo 5 jugadores: ");
                jugadores = int.Parse(Console.ReadLine());
            }

            // Comienza el Juego
            Console.WriteLine(" Comienza el Juego ");

            while (contador < jugadores)
            {
                Console.WriteLine("\n\nBienvenido jugador " + (contador + 1));
                int baraja = 0, total = 0; 

                while (true)
                {
                    baraja = aleatorio.Next(1, 11);
                    total += baraja;
                    Console.Write(" Carta= " + baraja);
                    Console.WriteLine(" total: " + total);

                    if (baraja == 1) //si saca 1, sale
                    {
                        Console.WriteLine(" (Eliminado) ");
                        Console.WriteLine(" total: " + total);
                        Console.WriteLine(" Gracias por jugar ");
                        break;
                    }
                    if ( 21 < total) //si llega a 21 concluye
                    {
                        Console.WriteLine(" (ganaste) ");
                        Console.WriteLine(" total: " + total);
                        Console.WriteLine(" Gracias por jugar ");
                        break;
                    }

                    Console.WriteLine(" ¿Deseas continuar? (s/n) "); //continuar?
                    si = Console.ReadLine();
                    
                    if (si == "n")
                    {
                        Console.WriteLine(" Retirado ");
                        break;
                    }
                    else if (si == "s")
                    {
                        continue;
                    }
                }
                contador++;

            }
        }
    }
}
