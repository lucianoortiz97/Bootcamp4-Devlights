// Suma de números impares: Calcular la suma de los números impares del 1 al 100.

Console.WriteLine("Quieres saber cuantos números son impares del 1 al 100?");


int acumular = 0;
int impar = 0;

for  (int i = 0; i <= 10; i++)
{
    if (i % 2 != 0) // Si es impar
    {
        acumular += i; // Sumar
        impar++; // Contar impar


    }
}

Console.WriteLine("La cantidad de los números impares del 1 al 100 es: " +  acumular);

