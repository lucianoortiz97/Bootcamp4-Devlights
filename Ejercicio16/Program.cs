// Promedio de notas: Pedir 5 notas, calcular el promedio y mostrar si el estudiante aprueba (>=6) o no.

double nota1, nota2, nota3, nota4, nota5;
double promedio;
string nombre;

Console.WriteLine("==== Calculador de Promedios ====");

Console.WriteLine("Ingresar el nombre del alumno: ");
nombre = Console.ReadLine();

Console.WriteLine("Ingresa la primer nota");
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingresa la segunda nota");
nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingresa la tercera nota");
nota3 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingresa la cuarta nota");
nota4 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingresa la quinta nota");
nota5 = double.Parse(Console.ReadLine());

promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

Console.WriteLine($"El promedio del alumno {nombre} es: {promedio}");

if (promedio >= 6)
{
    Console.WriteLine("El alumno se salvó");
}
else
{
    Console.WriteLine("El alumno vuelve en Diciembre");
}


