// Menú con switch: Crear un menú con opciones (1. Sumar, 2. Restar, 3. Multiplicar, 4. Dividir).
// Pedir dos números y ejecutar la operación elegida.

// Declaración de variables
int opcion;
double numero1, numero2, resultado;

// Mostrar el menu
Console.WriteLine("Seleccione una operación:");
Console.WriteLine("1. Sumar");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");

// Leer la operación del usuario
opcion = int.Parse(Console.ReadLine());

// Pedir los dos números

Console.WriteLine("Ingrese el primer número:");
numero1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número:");
numero2 = double.Parse(Console.ReadLine());

// Ejecutar la operación elegida
switch (opcion)
{
    case 1:
        resultado = numero1 + numero2;
        Console.WriteLine($"El resultado de la suma es: {resultado}");
        break;
    case 2:
        resultado = numero1 - numero2;
        Console.WriteLine($"El resultado de la resta es: {resultado}");
        break;
    case 3:
        resultado = numero1 * numero2;
        Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
        break;
    case 4:
        if (numero2 != 0)
        {
            resultado = numero1 / numero2;
            Console.WriteLine($"El resultado de la división es: {resultado}");
        }
        else
        {
            Console.WriteLine("No es posible dividir por cero");
        }
        break;
    default:
        Console.WriteLine("Solo esta permitido el menú del 1 al 4");
        break;
}

