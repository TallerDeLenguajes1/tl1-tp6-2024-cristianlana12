// See https://aka.ms/new-console-template for more informati
int opcion;
int num1, num2;
float numDiv1, numDiv2, operacion;

Console.WriteLine("1_suma");
Console.WriteLine("2_resta");
Console.WriteLine("3_multiplicar");
Console.WriteLine("4_dividir");
Console.WriteLine("Ingrese la opcion deseada: ");
int.TryParse(Console.ReadLine(), out opcion);
switch (opcion)
{
    case 1:
        Console.WriteLine("Ingresar el numero 1: ");
        int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Ingrese el numero 2:");
        int.TryParse(Console.ReadLine(), out num2);
        operacion = num1 + num2;
        Console.WriteLine("El resultado es: "+operacion);
        break;

    case 2:
        Console.WriteLine("Ingresar el numero 1: ");
        int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Ingrese el numero 2:");
        int.TryParse(Console.ReadLine(), out num2);
        operacion = num1 - num2;
        Console.WriteLine("El resultado es: "+operacion);
        break;
    case 3:
        Console.WriteLine("Ingresar el numero 1: ");
        int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine("Ingrese el numero 2:");
        int.TryParse(Console.ReadLine(), out num2);
        operacion = num1 * num2;
        Console.WriteLine("El resultado es: "+operacion);
        break;
    case 4:
        Console.WriteLine("Ingresar el numero 1: ");
        float.TryParse(Console.ReadLine(), out numDiv1);
        Console.WriteLine("Ingrese el numero 2:");
        float.TryParse(Console.ReadLine(), out numDiv2);
        operacion = numDiv1 / numDiv2;
        Console.WriteLine("El resultado es: "+operacion);
        break;
}