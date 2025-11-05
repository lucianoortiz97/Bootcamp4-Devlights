//// Crear una matriz de 10 x 10, y “esconder” varias ‘X’ en lugares aleatorios (la cantidad que el programador decida, pero no más de la mitad de los lugares
//disponibles en la matriz). El usuario deberá ingresar el lugar donde cree que hay una X, ingresando la fila y la columna por separado. Informar si acertó o no por cada
//ingreso. Se debe pedir al usuario ingresar valores por tantas X que se haya guardado. El usuario tiene 3 intentos para fallar. Al finalizar (Ya sea porque se
//terminaron los 3 intentos, o el jugador acertó todas las X) imprimir por pantalla la matriz con sus correspondientes X, mostrando un * donde no haya nada.

// Matriz 10x10
const int filas = 10;
const int columnas = 10;

char[,] matrizescondida = new char [filas, columnas];

// Inicializar y elegir X en posiciones aleatorias
for (int i = 0; i < filas; i++)
{
    for (int x = 0; x < columnas; x++)
    {
        matrizescondida [i, x] = '*';
    }
}


// Cantidad de X
int cantidadX = 5;
Random random = new Random();

for (int x= 0; x < cantidadX; x++)
{
    int a, b;
    do
    {
        a = random.Next(filas);
        b = random.Next(columnas);
    }
    while (matrizescondida[a, b] == 'X');
    matrizescondida[a, b] = 'X';
}

// 3 Intentos
int intentos = 0;
int fallidos = 0;

for (int x = 0; intentos <= 3; x++)
{
    Console.WriteLine($"Tienes {cantidadX} por encontrar, tienes 3 intentos");

    while(intentos <= cantidadX &&  fallidos <= 3)
    {
        Console.WriteLine("Ingresa fila: ");
        int fila = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa columna: ");
        int columnA = int.Parse(Console.ReadLine());

        if(fila < 0 || fila >= filas || columnA < 0 || columnA >= columnas)
        {
            Console.WriteLine("Fuera de posicion");
            continue;
        }
        if (matrizescondida[fila, columnA] == 'X') 
        {
            Console.WriteLine("Posicion acertada");
            matrizescondida[fila, columnas] = 'O';
            intentos++;
        }
        else
        {
            Console.WriteLine("Vacio. Intente nuevamente");
            fallidos++;
        }
    }
}

// Imprimir por pantalla
for  (int x = 0; x < filas ; x++)
{
    for (int a = 0; a < columnas; a++)
    {
        Console.WriteLine(matrizescondida[x, a] + " ");
    }
    Console.WriteLine();
}

if (fallidos >= 3) Console.WriteLine("Has perdido. Intentalo nuevamente");
else Console.WriteLine("Encontraste todas las X");
