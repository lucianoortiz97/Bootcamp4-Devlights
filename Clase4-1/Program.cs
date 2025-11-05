// Dado que se tiene almacenado en una lista, los resultados de los últimos 10 exámenes de un alumno, calcular su promedio y
// mostrar por pantalla las 10 notas de los exámenes y el promedio resultante.

string alumno;
// Inicializar una lista con 10 examenes
List<double> notas = new List<double>();

// Datos 
Console.WriteLine("Escribir el nombre del alumno: ");
alumno = Console.ReadLine();

for (int i = 1; i<=10; i++)
{
    double nota;
    bool valido = false;

    while (!valido)
    {
        Console.WriteLine($"Ingresa la nota {i}: ");
        string ingreso = Console.ReadLine();

        if (double.TryParse(ingreso, out nota) && nota >= 0 && nota <= 10)
        {
            notas.Add(nota);
            valido = true;
        }
        else
        {
            Console.WriteLine("Error al ingresar la nota");
        }
    }
}

Console.WriteLine($"Alumno: {alumno}");
Console.WriteLine("Notas ingresadas: ");
for (int i = 0; i < notas.Count; i++)
{
    Console.WriteLine($"Prueba {i + 1}: {notas[i]}");
}

double promedio = notas.Average();
Console.WriteLine($"Promedio final de: {promedio:F2}");