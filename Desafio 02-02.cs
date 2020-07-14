using System;

public class Program
{
    public static void Main()
    {
        // Entrada del usuario de las variables t
        Console.Write("Ingrese t: ");
        double t = double.Parse(Console.ReadLine());

        // Entrada del usuario de las variables a
        Console.Write("Ingrese a: ");
        double a = double.Parse(Console.ReadLine());

        //Conversión a radianes
        double arad = a* (Math.PI/ 180.0);

        //cálculo de Valores
        double y = ((t) * Math.Sin(arad));
        Console.Write("El valor de y es: " + y);

        double z = ((t) * Math.Cos(arad));
        Console.Write("El valor de z es: " + z);

        double c = ((180.0 - (a+90.0)));
        Console.WriteLine("Elvalor de c es:" + c);

    }
}