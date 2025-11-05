//Diccionario de calificaciones: Crear un diccionario donde la clave sea el nombre del alumno y el valor sea su nota. El programa debe permitir:
//a.Agregar alumnos y sus notas. 
//b. Mostrar el promedio general del curso.
//c. Indicar el alumno con mejor nota y el de peor nota.
//    d. Hint: usar Dictionary<string, double> y recorrer con foreach

Dictionary<string, double> calificaciones = new Dictionary<string, double>();

Console.Write("Cuantos alumnos tiene el curso: ");
int alumnos = int.Parse(Console.ReadLine());

for  (int i = 0; i < alumnos; i++)
{
    Console.WriteLine($"Curso N°{i + 1}: ");
    Console.Write("Nombre del alumno: ");
    string nombre = Console.ReadLine();

    Console.Write("Nota: ");
    double nota = double.Parse(Console.ReadLine());

    calificaciones[nombre] = nota;
}

Console.WriteLine("Lista general de calificaciones");
foreach(var alumno in calificaciones)
{
    Console.WriteLine($"{alumno.Key}: {alumno.Value}");
}

double promedio = calificaciones.Values.Average();
Console.WriteLine($"El promedio general del curso es de: {promedio:F2}");

// Mejor y peor alumno 
var mejor = calificaciones.OrderByDescending(x => x.Value).First();
var peor = calificaciones.OrderBy(x => x.Value).First();

Console.WriteLine($"Mejor nota {mejor.Key} ({mejor.Value})");
Console.WriteLine($"Peor nota {peor.Key} ({peor.Value})");
