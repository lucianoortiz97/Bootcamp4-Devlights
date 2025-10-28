// Comparación de tres números: Pedir tres números distintos y mostrar cuál es el mayor y cuál el menor.

Console.WriteLine("Ingrese el primer número:");
string numero1 = Console.ReadLine();

Console.WriteLine("Ingrese el segundo número:");
string numero2 = Console.ReadLine();

Console.WriteLine("Ingrese el tercer número:");
string numero3 = Console.ReadLine();

// Variables para guardar los números convertidos
double num1, num2, num3;

// Convertir las entradas a números
if (double.TryParse(numero1, out num1) && double.TryParse(numero2, out num2) && double.TryParse(numero3, out num3))
{
    // Encontrar el mayor y el menor
    double mayor = Math.Max(num1, Math.Max(num2, num3));
    double menor = Math.Min(num1, Math.Min(num2, num3));
    Console.WriteLine($"El número mayor es: {mayor}");
}

