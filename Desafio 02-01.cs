using System;

public class Program
{
    public static void Main()
    {
        // Entrada del usuario de las variables Y
        Console.Write("Ingrese Y: ");
        double y = double.Parse(Console.ReadLine());

        // Entrada del usuario de las variables Z
        Console.Write("Ingrese Z: ");
        double z = double.Parse(Console.ReadLine());

        //cálculo de Valores
        double t = Math.Sqrt((z * z) + (y * y));
        Console.Write("El valor de t es: " + t);

        double crad = Math.Asin(z / t);

        double arad = Math.Acos(z / t);

        //Conversión a radianes
        double a = ((180.0* arad)/Math.PI);
        Console.WriteLine("El valor de a es:" + a);

        double c = ((180.0 * crad) / Math.PI);
        Console.WriteLine("Elvalor de c es:" + c);

    }
}