using System;

public class Program
{
    public static void Main()
    {
        // Entrada del usuario de las variables C
        Console.Write("Ingrese c: ");
        double c = double.Parse(Console.ReadLine());

        // Entrada del usuario de las variables z
        Console.Write("Ingrese z: ");
        double z = double.Parse(Console.ReadLine());

        //Conversión a radianes
        double crad = c* (Math.PI/ 180,0);

        //cálculo de Valores
        double t = (z/ Math.Sin(crad));
        Console.Write("El valor de t es: " + t);

        double a = (180,0 - (c + 90,0));
        Console.Write("El valor de a es: " + a);

        double y = (t* Math.Cos(crad));
        Console.WriteLine("Elvalor de y es:" + y);

    }
}