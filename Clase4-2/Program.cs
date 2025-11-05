// Dada las edades de 20 personas guardadas en una lista, imprimir por pantalla cuántos son mayores de edad y cuántos no.

int mayores = 0;
int menores = 0;

List<int> edades = new List<int> ();

Console.WriteLine("Ingresa las edades de 20 personas: ");

for (int i = 1; i<= 20; i++)
{
    int edad;
    bool valido = false;

    while (!valido)
    {
        Console.WriteLine($"Edad de la {i} persona: ");
        string ingreso = Console.ReadLine ();
        
        if (int.TryParse(ingreso, out edad) && edad > 0)
        {
            edades.Add(edad);

            valido = true;

            if(edad >= 18)
                mayores++;
            else
                mayores++;
        }
        else
        {
            Console.WriteLine("Ingrese una edad correcta");
        }
    }
}

Console.WriteLine("Edades ingresadas: ");
    foreach (int i in edades)
{
    Console.WriteLine($"Edades: {i}");
}
Console.WriteLine($"Mayores de edad: {mayores}");
Console.WriteLine($"Menos de edad: {menores}");