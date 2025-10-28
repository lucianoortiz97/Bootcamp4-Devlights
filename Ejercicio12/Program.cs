// Contador de pares: Pedir un número N y mostrar cuántos números pares hay entre 1 y N.

Console.WriteLine("Ingrese un número N:");
int n = int.Parse(Console.ReadLine());

int cantPares = 0;

for (int i = 0; i < n; i++)
{
    cantPares++;
}
Console.WriteLine($"La cantidad de números pares entre 1 y {n} es: {cantPares}");

