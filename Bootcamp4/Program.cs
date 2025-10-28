// Número positivo o negativo: Pedir un número y mostrar si es positivo, negativo o cero.

Console.WriteLine("Ingrese un número[positivo, negativo, decimal o cero]: ");
string respuesta = Console.ReadLine(); // Respuesta del usuario

if (double.TryParse(respuesta, out double numero)) // Validar si es un nro o texto
{
    if (numero < 0)
    {
        Console.WriteLine("El número es negativo");
    }
    else if (numero > 0)
    {
        Console.WriteLine("El número es positivo");
    }
    else
    {
        Console.WriteLine("El número es cero");
    }
}
else
{
    Console.WriteLine("Error: Solo se aceptan números");
}