using System;

public class Program
{
    public static void Main()
    {
        // Entrada del usuario de las variables
        Console.Write("Ingrese d: ");
        double d = double.Parse(Console.ReadLine());

        Console.Write("Ingrese b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Ingrese y: ");
        double y = double.Parse(Console.ReadLine());
        // Calculos 1
        double e = 180.0 - (d + b);
        double c = 180.0 - e;
        //Pasar c a rads
        double crad = c / (180.0 / Math.PI);
        //Calculo final
        double z = (Math.Tan(crad) * y);
        //Resultado
        Console.WriteLine("z= " + z);
    }
}