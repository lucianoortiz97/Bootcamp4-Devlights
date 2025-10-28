// Clasificación por edad: Pedir la edad y mostrar si la persona es niño, adolescente, adulto o adulto mayor (usa if-else if-else).

Console.WriteLine("Ingrese su edad:");
int edad = int.Parse(Console.ReadLine());

if (edad >= 0 && edad <= 12)
{
    Console.WriteLine("Es un niño");
}
else if (edad >= 13 && edad <= 24)
{
    Console.WriteLine("Es un adolescente");
}
else if (edad >= 25 && edad <= 64)
{
    Console.WriteLine("Es un adulto");
}
else if (edad >= 65)
{
    Console.WriteLine("Es un adulto mayor");
}
else
{
    Console.WriteLine("Ingrese una edad");
}