// Número dentro de rango: Pedir un número y verificar si está dentro del rango 1–100 (inclusive).

Console.WriteLine("Ingrese un número:");
int numero = int.Parse(Console.ReadLine());

if (numero >= 1 && numero <= 100)
{
    Console.WriteLine("El número esta dentro del rango 1-100");
}
else
{
    Console.WriteLine("El número esta fuera del rango 1-100");
}