using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();        

            // dado 
            int dado = 0;
            

            int i = 2; //comodín de usar los dados especiales

            int total = 0;

            int l = 3; // vidas

            int uno = 0; //contador de si saca 1
            int seis = 0; //contador de si saca doble 6

            string si = "s";

            while (99 > total)
            {
                
                
                //dados especiales
                if (i !=0 )
                {
                    Console.WriteLine(" ¿Desea usar el comodín de dados especiales? ");
                    string yes = Console.ReadLine();
                    if (yes == "s")
                    {
                        dado = aleatorio.Next(1, 13);

                        total += (dado);
                        i--;

                        

                    }
                    else if (yes == "n")
                    {     
                        dado = aleatorio.Next(1, 7);
                        total += (dado);

                        
                    }
                }

                //ciclo dados normales
                else if (i == 0)
                {
                    dado = aleatorio.Next(1, 7);
                    total += (dado);

                          
                }

                Console.WriteLine(" especial =" + dado);
                Console.WriteLine(" total= " + total);
                Console.WriteLine(" vidas= " + l);

                //si saca doble 1 pierde una vida y pierde 10 puntos de total.
                if (dado == 1 && uno == 0)
                {
                    uno++;
                }
                else if (dado == 1 && uno == 1)
                {
                    l --;
                    total -= 10;
                    uno = 0;
                    Console.WriteLine(" Perdiste una vida y 10 puntos. Vidas:  "+ l);
                }
               
                if(l == 0)
                {
                    Console.WriteLine(" Perdiste ");
                    break;
                }

                //si saca doble 6 suma una vida (solo si no es menor a 3).
                if(dado == 6 && seis == 0)
                {
                    seis++;             
                }
                else if ((dado == 6 && seis == 1) && 3 > l)
                {
                    l++;
                    Console.WriteLine(" Ganaste 1 vida. Vidas:  " + l);
                }
                else
                {
                    seis = 0;
                }

                if (total > 99)
                {
                    Console.WriteLine(" ganaste ");
                    break;
                }

                Console.WriteLine(" ¿Quieres continuar? ");
                si = Console.ReadLine();
                if (si == "n")
                {
                    Console.WriteLine(" (Perdiste) ");
                    break;
                }
                else if(si =="s")
                {
                    continue;
                }
            }
            
            Console.WriteLine(" total: " + total);
            Console.WriteLine(" Gracias por jugar ");
        }
    }
}