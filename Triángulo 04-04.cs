using System;

public class Program
{
    public static void Main()
    {
        // Entrada del usuario de las variables
        Console.Write("Ingrese w: ");
        double w = double.Parse(Console.ReadLine());

        Console.Write("Ingrese t: ");
        double t = double.Parse(Console.ReadLine());

        Console.Write("Ingrese c: ");
        double c = double.Parse(Console.ReadLine());
        // Calculos 1
        double e = (180 - c);
        //Convertir e a rads
        double erad = e / (180.0 / Math.PI);
        // Calculos 2
        double drad = Math.Asin((Math.Sin(erad) * (t)) / w);
        //Convertir drad a grados
        double d = drad * (180.0 / Math.PI);
        // Calculos 3
        double b = (180.0 - (d + e));
        //Convertir b a rads
        double brad = b / (180.0 / Math.PI);
        // Calculo Final
        double x = (Math.Sin(brad) * (t)) / Math.Sin(drad);
        //Resultado
        Console.WriteLine("x= " + x);
    }
}