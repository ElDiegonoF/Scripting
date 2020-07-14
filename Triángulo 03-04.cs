using System;

public class Program
{
    public static void Main()
    {
        // Entrada del usuario de las variables
        Console.Write("Ingrese w: ");
        double w = double.Parse(Console.ReadLine());

        Console.Write("Ingrese d: ");
        double d = double.Parse(Console.ReadLine());

        Console.Write("Ingrese x: ");
        double x = double.Parse(Console.ReadLine());
        //Convertir d a rads
        double drad = d / (180.0 / Math.PI);
        // Calculos
        double z = Math.Sin(drad) * w;
        double xy = Math.Sqrt(((w)*(w)) - ((z)*(z)));
        double y = xy - x;
        //Resultado
        Console.WriteLine("y= " + y);
    }
}