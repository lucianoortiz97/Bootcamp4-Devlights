//Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los días de la semana. La estructura es para registrar la temperatura diaria de una cabina de
//pago, estos oscilan entre los 7 y 38 grados. Deberá llenar la matriz de forma aleatoria para el mes de mayo donde el primer día inicia en lunes y el último (31) se
//ubica en el miércoles (la matriz puede ser inicializada con valores aleatorios desde el principio del programa, no es necesario pedir los valores al usuario para cada
//posición). Se nos pide hacer lo siguiente: 
//a.Obtener la temperatura más alta y baja de la semana y que día se produjo (lunes, martes, etc.)
//b. Promedio de temperatura de la semana.
//c. Temperatura más alta del mes y su día.

int[,] temperaturas = new int[5, 7];

Random rand = new Random();

// Llenar matriz con temperaturas aleatorias
for (int semanas = 0; semanas < 5; semanas++)
{
    for (int dia = 0; dia < 7; dia++)
    {
        temperaturas[semanas, dia] = rand.Next(7, 38); // num aleatorio entre 7 y 38 grados
    }
}

// Dias para resultados
string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

// Mostrar matriz
for (int semana = 0; semana < 5; semana++)
{
    Console.WriteLine($"Semana {semana + 1}: ");
    for (int dia = 0; dia < 7; dia++)
    {
        Console.Write($"{temperaturas[semana, dia]} ");
    }
    Console.WriteLine();
}

// Temperatura máxima y mínima por semana
for (int semana = 0; semana < 5; semana++)
{
    int diaMax = 0;
    int diaMin = 0;
    int tempMax = temperaturas[semana, 0];
    int tempMin = temperaturas[semana, 0];

    for (int dia = 0; dia < 7; dia++)
    {
        if (temperaturas[semana, dia] > tempMax)
        {
            tempMax = temperaturas[semana, dia];
            diaMax = dia;
        }
        if (temperaturas[semana, dia] < tempMin)
        {
            tempMin = temperaturas[semana, dia];
            diaMin = dia;
        }
    }

    Console.WriteLine($"Semana {semana + 1}: ");
    Console.WriteLine($"  Máxima {tempMax}°C el {dias[diaMax]}");
    Console.WriteLine($"  Mínima {tempMin}°C el {dias[diaMin]}");

    // Promedio semanal
    int suma = 0;
    for (int dia = 0; dia < 7; dia++)
    {
        suma += temperaturas[semana, dia];
    }
    double promedio = (double)suma / 7;
    Console.WriteLine($"  Promedio semanal: {promedio:F2}°C");
}

// Temperatura más alta del mes y día
int tempMaxMes = temperaturas[0, 0];
int semanaMax = 0;
int diaMaxMes = 0;

for (int semana = 0; semana < 5; semana++)
{
    for (int dia = 0; dia < 7; dia++)
    {
        if (temperaturas[semana, dia] > tempMaxMes)
        {
            semanaMax = semana;
            diaMaxMes = dia;
            tempMaxMes = temperaturas[semana, dia];
        }
    }
}

Console.WriteLine();
Console.WriteLine($"La temperatura más alta del mes fue {tempMaxMes}°C el {dias[diaMaxMes]} de la semana {semanaMax + 1}");
