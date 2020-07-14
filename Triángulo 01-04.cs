using System;

public static program()
{
    public static void Main()
{
    // Entrada del usuario de las variables
    Console.Write("Ingrese b: ");
    double b = double.Parse(Console.ReadLine());

    Console.Write("Ingrese z: ");
    double z = double.Parse(Console.ReadLine());

    Console.Write("Ingrese y: ");
    double y = double.Parse(Console.ReadLine());
    // Calculos 1
    double arad = Math.Atan(y / z);
    double crad = Math.Atan(z / y);
    //Convertir arad y crad a grados
    double a = arad * (180.0 / Math.PI);
    double c = crad * (180.0 / Math.PI);
    //Convertir b a radianes
    double brad = b / (180.0 / Math.PI);
    //Calculos 2
    double t = y / Math.Cos(crad);
    double e = (180.0 - (c));
    double d = (180.0 - (e + b));
    //Convertir d a radianes
    double drad = d / (180.0 / Math.PI);
    //Calculo final
    double x = (t * Math.Sin(brad)) / Math.Sin(drad);
    //Resultado
    Console.WriteLine("x= " + x);
}
}