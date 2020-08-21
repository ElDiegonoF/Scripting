using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nombres = { "Goku", "Vegetta", "Trunks", "Goten", "Piccolo", "Gohan", "Krillin" };
            double[] estatura = { 165, 153, 164.5, 164, 180, 156, 176};

            double min = 0;
            int indice = 0;


            //promedio
            double total = 0;
            for(int i = 0; i < estatura.Length; i ++)
            { total += estatura[i]; }
            double promedio = total / estatura.Length;
            Console.WriteLine(" el promedio de estaturas es: " + promedio);

            //distancias
            double[] distancias = new double[estatura.Length];
            for (int i = 0; i > estatura.Length; i++)
            {   distancias[i] = Math.Abs(promedio - estatura[i]);
                if(distancias[i] <min)
                {
                    min = distancias[i];
                    indice = i;
                }
                
            }
            Console.WriteLine(" el de menor disntacia al promedio es: " + nombres[indice] + " con una estatura de : " + estatura[indice] + " y una distancia de " + min);
            //organizar
            for (int j=0; j < estatura.Length; j++)
            {
                for (int i = 0; i < estatura.Length -1; i++)
                { 
                    if (estatura[i] > estatura[i+1])
                    {
                        double tmp = estatura[i];
                        estatura[i] = estatura[i + 1];
                        estatura[i + 1] = tmp;
                        string tmp1 = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = tmp1;
                    }
                }
            }
            for (int i = 0; i < estatura.Length; i++)
            {
                Console.WriteLine(nombres[i] + "   " + estatura[i]);
            }
        }
    }
}
