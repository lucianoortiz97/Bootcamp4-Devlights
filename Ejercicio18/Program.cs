// Suma acumulada con condición: Pedir números y sumar hasta que la suma supere 100. Mostrar cuántos números se ingresaron.

double contador = 0; // suma la cant. de nros ingresados
int cantidad = 0; // cantidad de veces ingresadas
string numeros;

do
{
    Console.WriteLine("Ingrese números randoms hasta llegar a 100 ");
    numeros = Console.ReadLine();
    double numero = double.Parse(numeros);
    contador += numero;
    cantidad++;
}
while (contador <= 100);
Console.WriteLine($"Se ingresaron {cantidad} de números");
Console.WriteLine($"La suma total que dio es de {contador}");

