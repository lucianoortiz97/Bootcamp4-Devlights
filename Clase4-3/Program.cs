// Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y el que tenga menos letras de todos.

List<string> estudiantes = new List<string>();

Console.WriteLine("Ingrese la cantidad de estudiantes: ");
int cantidad = Convert.ToInt32(Console.ReadLine());

for  (int i = 1;  i <= cantidad; i++)
{
    Console.WriteLine($"Ingresa el nombre del estudiante {i}: ");
    string nombre = Console.ReadLine();

    if (!string.IsNullOrEmpty(nombre) ) // Chequea que no llegue vacio
    {
        estudiantes.Add( nombre ); 
    }
    else
    {
        Console.WriteLine("Nombre invalido, intente nuevamente");
        i--;
    }
}

string NombreCorto = estudiantes[0];
string NombreLargo = estudiantes[0];

foreach (string nombre in estudiantes)
{
    if (nombre.Length > NombreLargo.Length)
        NombreLargo = nombre;

    if (nombre.Length < NombreCorto.Length)
        NombreCorto = nombre;
}

Console.WriteLine("Nombres Ingresados:");
foreach (var e  in estudiantes)
{
    Console.WriteLine($"Estudiante: {e}");
}
Console.WriteLine($"Nombre con mas letras: {NombreLargo} con {NombreLargo.Length} letras");
Console.WriteLine($"Nombre con menos letras: {NombreCorto} con {NombreCorto.Length} letras");
