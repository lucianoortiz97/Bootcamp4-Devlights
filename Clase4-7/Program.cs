//// Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la primera fila y la primera columna se debe guardar los números (de 0 a 9), estando el cero en
//la primera posición (fila 0, columna 0). El resto de los lugares debe ser calculado usando los números que se dispone, por ejemplo, en la fila 1, calcular 1*1, 1*2, 1*3,
//etc. usando las posiciones del array o arreglo. Al finalizar el cálculo, mostrar la matriz por pantalla

// Matriz 10x10
int[,] matriz = new int[10, 10];

// Cargar datos a la tabla 
for (int i = 0; i < 10; i++)
{
    matriz[0, i] = i;
    matriz[i, 0] = i;
}

// Multiplicar valores
for (int fila = 1; fila < 10; fila++)
{
    for (int columna = 1; columna < 10; columna++)
    {
        matriz[fila, columna] = matriz[fila, 0] * matriz[0, columna];
    }
}

//Mostrar por pantalla
for(int fila = 0; fila < 10; fila++)
{
    for (int columna = 0; columna < 10; columna++)
    {
        Console.Write($"{matriz[fila, columna], 4}"); 
    }
    Console.WriteLine(); // unica forma de que se haga los espacios
}
