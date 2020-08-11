using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            bool gameover = false;
            int turno = 0;
            int dado = 0;
            int total = 0;

            int a = 2;

            while (100 > total || gameover != true)
            {
                if (total > 99 || a == 0)
                {
                    Console.WriteLine(" ganaste ");
                    break;
                }

                Console.WriteLine(" ¿Quieres continuar? ");
                string si = Console.ReadLine();

                if (si == "s")
                {
                    dado = aleatorio.Next(11, 11);
                    total += (dado);
                    turno++;
                    Console.WriteLine(" dado= " + dado);
                    Console.WriteLine(" Total= " + total);
                }
                else if (si == "n")
                {
                Console.WriteLine(" (Perdiste) ");
                    break;
                }


                if(dado == 12 && a == 2)
                {
                    a--;
                    Console.Write(" saca ahora 10 y ganas.   ");
                }
                else if (dado == 10 && a == 1 )
                {
                  a--;   
                }
                else
                {
                    a = 2 ;
                }

                if (turno > 3)
                {
                    if ((dado % 2) == 0)
                    {
                        gameover = false;
                    }
                    else
                    {
                        Console.WriteLine(" perdiste . ");
                        
                        break;
                    }
                }


            }
            Console.WriteLine("Turnos jugados" + turno);
            Console.WriteLine(" total: " + total);
            Console.WriteLine(" Gracias por jugar ");
            
        }
    }
}

