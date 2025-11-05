//Inventario con múltiples colecciones: Diseñar un sistema de inventario básico usando distintas colecciones:
//a.Un List<string> con los productos disponibles.
//b.Un Dictionary<string, int> para registrar el stock de cada producto.
//c.Un Stack<string> para llevar el historial de acciones realizadas (agregar, quitar, vender).
//d.El programa debe permitir:
//i.Agregar un producto y su cantidad.
//ii. Vender un producto (restando stock).
//iii. Mostrar el inventario actual.
//iv. Mostrar las últimas 3 acciones registradas.
//e. Hint: combina listas, diccionarios y pilas para manipular distintos tipos de información.

List<string> productos = new List<string>();
Dictionary<string, int> stock = new Dictionary<string, int>();
Stack<string> historial  = new Stack<string>();

while (true)
{
    Console.WriteLine(" SISTEMA DE INVENTARIO");
    Console.WriteLine("Agregar productos");
    Console.WriteLine("Vender producto");
    Console.WriteLine("Mostrar inventario actual");
    Console.WriteLine("Ultimas 3 acciones");
    Console.WriteLine("Salir");
    Console.WriteLine("----");
    Console.Write("Elegir una opcion: ");
    string opcion = Console.ReadLine();

    if (opcion == "1")
    {
        Console.Write("Ingrese el nombre del producto: ");
        string producto = Console.ReadLine().Trim();

        Console.WriteLine("Ingrese la cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());

        //Para evitar duplicados
        if (!productos.Contains(producto)) { productos.Add(producto); }

        if (stock.ContainsKey(producto)) stock[producto] += cantidad;
        else stock[producto] = cantidad;

        historial.Push($"Se agrego {producto} al sistema y el total de {cantidad} unidades");
    }
    else if (opcion == "2")
    {
        Console.WriteLine("Producto a vender: ");
        string producto = Console.ReadLine();

        if (!stock.ContainsKey(producto))
        {
            Console.WriteLine("El producto no existe en el inventario");
            continue;
        }

        Console.WriteLine("Cantidad a vender: ");
        int cantidad = int.Parse(Console.ReadLine());

        if (cantidad > stock[producto])
        {
            Console.WriteLine("No hay stock");
        }
        else
        {
            stock[producto] -= cantidad;
            historial.Push($"Vendido: {producto} (-{cantidad})");

            if (stock[producto] == 0)
            {
                stock.Remove(producto);
                productos.Remove(producto);
                historial.Push($"Producto agotado: {producto}");
            }
        }
    }
    else if (opcion == "3")
    {
        Console.WriteLine("Inventario Actual");
        if (stock.Count == 0)
        {
            Console.WriteLine("Inventario vacio");
        }
        else
        {
            foreach (var item in stock)
            {
                Console.WriteLine($"STOCK: {item.Key}: {item.Value} unidades");
            }
        }
    }
    else if (opcion == "4")
    {
        Console.WriteLine("Ultimas 3 acciones: ");
        if (historial.Count == 0)
        {
            Console.WriteLine("No se registraron acciones");
        }
        else
        {
            foreach (var accion in historial.Take(3))
            {
                Console.WriteLine(accion);
            }
        }
    }
    else if (opcion == "5")
    {
        Console.WriteLine("Saliendo del sistema");
        break;
    }
    else
    {
        Console.WriteLine("Opcion incorrecta, intente nuevamente");
    }
}