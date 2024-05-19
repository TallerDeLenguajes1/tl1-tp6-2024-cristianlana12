// See https://aka.ms/new-console-template for more information
int opcion;
double num1, operacio;

Console.WriteLine("1_valor absoluto");
Console.WriteLine("2_cuadrado");
Console.WriteLine("3_raiz cuadrada");
Console.WriteLine("4_seno");
Console.WriteLine("5_coseno");
Console.WriteLine("6_parte entera");
Console.WriteLine("Ingrese una opcion: ");
int.TryParse(Console.ReadLine(), out opcion);

switch (opcion)
{
    case 1:
        Console.WriteLine("Ingrese el numero 1:");
        double.TryParse(Console.ReadLine(), out num1);
        operacio = Math.Abs(num1);
        Console.WriteLine("el resultado es: "+operacio);
        break;
    case 2:
        Console.WriteLine("Ingrese el numero 1:");
        double.TryParse(Console.ReadLine(), out num1);
        operacio = Math.Pow(num1,2);
        Console.WriteLine("el resultado es: "+operacio);
        break;
    case 3:
        Console.WriteLine("Ingrese el numero 1:");
        double.TryParse(Console.ReadLine(), out num1);
        operacio = Math.Sqrt(num1);
        Console.WriteLine("el resultado es: "+operacio);
        break;
    case 4:
        Console.WriteLine("Ingrese el numero 1:");
        double.TryParse(Console.ReadLine(), out num1);
        operacio = Math.Sin(num1);
        Console.WriteLine("el resultado es: "+operacio);
        break;
    case 5:
        Console.WriteLine("Ingrese el numero 1:");
        double.TryParse(Console.ReadLine(), out num1);
        operacio = Math.Cos(num1);
        Console.WriteLine("el resultado es: "+operacio);
        break;
    case 6:
        Console.WriteLine("Ingrese el numero 1:");
        double.TryParse(Console.ReadLine(), out num1);
        operacio = Math.Floor(num1);
        Console.WriteLine("la parte entera del numero es: "+operacio);
        break;
}