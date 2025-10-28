// Contar vocales: Pedir una palabra y contar cuántas vocales tiene.

Console.WriteLine("Ingresa una palabra y te dire cuantas vocales tiene: ");
string palabra = Console.ReadLine();

palabra = palabra.ToLower();

int vocales = 0;

foreach (char x in palabra)
{
    if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
            {
            vocales++;
            }
}
Console.WriteLine($"La palabra {palabra} tiene {vocales} de vocales");