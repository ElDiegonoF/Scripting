using System;

namespace Captcha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Bienvenido al Captcha! | Por favor responda la siguiente operación: "); //bienvenida

            Random aleatorio = new Random();

            int i = 3; // contador de oportunidades
            
            while(true)
            {
                //datos a sumar para el captcha
                int a = aleatorio.Next(0, 10);
                int b = aleatorio.Next(0, 10);

                int s = a + b; //suma correcta

                Console.WriteLine("cuánto es:"+ a + " + " +b + "?");//operación
                
                int r = int.Parse(Console.ReadLine());

                
                if(r == s)
                {
                    Console.WriteLine(" Bienvenido al programa. ");
                    break;
                }
                
                if(r !=s)
                {                     
                    i--;
                    Console.WriteLine(" ERROR | vuelve a intentar" + "te quedan " + i + "oportunidades"); 
                    continue;
                }

                if(i == 0)
                {
                    Console.WriteLine(" ACCESO DENEGADO | ¡¡PIERDETE BOT!! ");
                    break;
                }
            }
        }
    }
}
