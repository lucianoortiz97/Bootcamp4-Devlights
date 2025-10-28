// Tabla de multiplicar: Pedir un número y mostrar su tabla de multiplicar del 1 al 10.

int respuesta;
int resultado;

Console.WriteLine("Ingrese un número para multiplicar: ");
respuesta = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    resultado = respuesta * i;
    Console.WriteLine(respuesta + " x " + i + " = " + resultado);
}


