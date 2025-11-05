// Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en lugares pares.Imprimir la matriz por pantalla

using System.ComponentModel.DataAnnotations.Schema;

Console.WriteLine("Matriz 5x5 PIPIPIPI");
char[,] matriz = new char[5, 5]; //Fila x Columnas

for (int fila = 0; fila < 5; fila++)
{
    for (int columna = 0; columna < 5; columna++)
    {
        if((fila + columna) % 2 == 0) matriz[fila, columna] = 'P';
        else matriz[fila, columna] = 'I';
    }
}

Console.WriteLine("Matriz generada:");
for (int fila = 0; fila <5; fila++)
{
    for (int columna = 0; columna <5; columna++)
    {
        Console.Write(matriz[fila, columna] + " ");
    }
    Console.WriteLine(); 
}