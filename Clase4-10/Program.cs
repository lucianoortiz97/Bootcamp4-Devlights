//Simulador de atención en ventanilla: Usar una cola (Queue) para simular la atenciónde clientes en una ventanilla bancaria.
//a. Encolar nombres de clientes.
//b. Atender (desencolar) uno por uno hasta que no queden.
//c. Mostrar en pantalla quién está siendo atendido y cuántos quedan en la fila.
//d. Hint: usar Enqueue() Agrega elemento, Dequeue() Quita y devuelve, y Count.c indica cant de elmentos

Queue<string> fila = new Queue<string>();

// Crear fila de clientes
Console.Write("Ingrese la cantidad de clientes en ventana: ");
int clientes = int.Parse(Console.ReadLine());

//Agregar clientes
for (int i = 0; i < clientes; i++)
{
    Console.WriteLine("Ingresa el nombre del cliente: ");
    string nombre = Console.ReadLine();
    fila.Enqueue(nombre);
}


Console.WriteLine("Carga de clientes");

//Atender clientes
while (fila.Count > 0)
{
    string cliente = fila.Dequeue();
    Console.WriteLine($"Atiendo a: {cliente} - quedan {fila.Count} en fila");

    Thread.Sleep(2000); // efecto que pasa al otro cliente
}

Console.WriteLine("No quedan mas clientes en fila");


