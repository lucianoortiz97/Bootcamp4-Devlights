// Operador ternario: Pedir un número y mostrar "Par" o "Impar" usando el operador ternario.

Console.WriteLine("Ingrese un número:");
int numero = int.Parse(Console.ReadLine());

int resultado = (numero % 2 == 0) ? 1 : 0;
string mensaje = (resultado == 1) ? "Par" : "Impar";

Console.WriteLine(mensaje);