// Contador hasta que sea cero: Pedir números enteros hasta que el usuario ingrese 0. Mostrar la cantidad de números introducidos.

double numero;
int contador = 0;

Console.WriteLine("Ingresa un número random (para finalizar escribir 0)");
numero = double.Parse(Console.ReadLine());

// Bucle mientras no se escriba 0
while (numero != 0)
{
    contador++;
    Console.WriteLine("Ingresaste el número: " + numero);
    Console.WriteLine("Ingresa un otro número random (para finalizar escribir 0)");
    numero = double.Parse(Console.ReadLine());
}

// Mensaje final
Console.WriteLine($"Escribiste la cantidad de: {contador} veces un número");
Console.WriteLine("Se ha finalizado, escribiste 0");
