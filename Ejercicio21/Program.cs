// Mini cajero automático Simular un cajero con un saldo inicial.
// Mostrar un menú con opciones:
// ● 1) Consultar saldo ● 2) Depositar ● 3) Retirar ● 4) Salir
// Validar que no se retire más de lo que hay y que los montos sean positivos.

string nombreSimulador;
double saldoInicial = 17500;
bool menuActivo = true;

Console.WriteLine("Antes de utilizar el simulador ingresa tu nombre: ");
nombreSimulador = Console.ReadLine();

while (menuActivo) // Con while se mantiene siempre activo el menú
{
    Console.WriteLine($"=== BIENVENIDO AL CAJERO AUTOMÁTICO DE {nombreSimulador} ===");
    Console.WriteLine("Opciones de menú:");
    Console.WriteLine("1- Consultar saldo");
    Console.WriteLine("2- Depositar");
    Console.WriteLine("3- Retirar");
    Console.WriteLine("4- Salir");

    Console.Write("Selecciona una opción: ");
    string opcion = Console.ReadLine();


    switch (opcion)
    {
        case "1":
            Console.WriteLine("=== SALDO ===");
            Console.WriteLine($"El saldo de {nombreSimulador} es de {saldoInicial}");
            break;

        case "2":
            Console.WriteLine("=== DEPOSITAR ===");
            Console.Write($"Pesos a negrear: ");

            if (double.TryParse(Console.ReadLine(), out double deposito) && deposito >= 0)
            {
                saldoInicial += deposito;
                Console.WriteLine($"Depositado con exito. Ahora tiene ${saldoInicial}");
            }
            else
            {
                Console.WriteLine("Solo depositos positivos");
            }
            break;

        case "3":
            Console.WriteLine("=== RETIRAR ===");
            Console.Write("Ingresa el monto a reirar: ");
            if (double.TryParse(Console.ReadLine(), out double retirar) && retirar >= 0)
            {
                if (retirar <= saldoInicial)
                {
                    saldoInicial -= retirar;
                    Console.WriteLine($"Retiro con exito. Nuevo saldo ${saldoInicial}");
                }
                else
                {
                    Console.WriteLine("No se pudo realizar el deposito. Solo números positivos");
                }
            }
            break;

        case "4":
            Console.WriteLine("Gracias por utilizar el cajero");
            menuActivo = false;
            break;
    }
    if (menuActivo)
    {
        Console.WriteLine("Escribir cualquier letra para volver al menú");
        Console.ReadKey();
        Console.Clear();
    }
}