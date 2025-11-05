//Crear una variable para guardar los nombres de elementos para una “lista de supermercado”. Solicitar al usuario que ingrese el nombre de un elemento que va a
//comprar en el super y verificar que el elemento esté en la lista. Si no está, agregarlo e indicar que no estaba. Si está, quitarlo de la lista, y avisar que sí estaba. Al
//finalizar mostrar por pantalla los elementos que no compró y los que compró, pero no estaban en la lista. Si se quiere, mostrar también todos los elementos que el
//usuario compró. Para salir el usuario debe ingresar “fin”.

Console.WriteLine("== LISTA DE SUPERMERCADO ==");
Console.Write("Nombre del responsable: ");
string nombre = Console.ReadLine();

Console.WriteLine($"Te avisamos {nombre} que al escribir 'fin' veras la lista completa");

List<string> listaSuper = new List<string>();

string productos;

while(true)
{
    Console.Write("Agregar producto: ");
    productos = Console.ReadLine();

    if (productos == null) continue;

    string producto = productos.Trim();
    if (producto.Equals("fin", StringComparison.OrdinalIgnoreCase))
        break;

    if (string.IsNullOrEmpty(producto) )
    {
        Console.WriteLine("Ingrese un producto, no puede quedar vacio");
        continue;
    }

    //Evitar repeticiones de productos
    if (!listaSuper.Any(x => x.Equals(producto, StringComparison.InvariantCultureIgnoreCase)))
    {
        listaSuper.Add(producto);
        Console.WriteLine($"El productp {producto} ha sido añadido a la lista");
    }
    else
    {
        Console.WriteLine($"No es posible ingresar el producto {producto}. Ya esta en la lista ");
    }
}

Console.WriteLine("Lista inicial cargada: ");
if (listaSuper.Count < 0) Console.WriteLine("Vacia");
else Console.WriteLine(string.Join(", ", listaSuper));

//
Console.WriteLine("Ingresa los productos que compras: ");
Console.WriteLine($"Te avisamos {nombre} que al escribir 'fin' veras tus compras");

List<string> compra = new List<string>(); // Es posible usar foreach? Si, totalmente. Es más largo nomas (serian 2 listas)
HashSet<string> compradosNoDisponibles = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase); // Reemplazo de lista para menor confusión

while (true)
{
    Console.Write("Producto comprado: ");
    string prodComprado = Console.ReadLine();

    if (prodComprado == null) continue;

    string producto = prodComprado.Trim();

    if (producto.Equals("fin", StringComparison.OrdinalIgnoreCase))
        break;

    if(string.IsNullOrWhiteSpace(producto) ) {

        Console.WriteLine("Ingrese un producto correcto");
        continue;
        }
        

    compra.Add(producto);

int indice = -1;
for (int i = 0; i < listaSuper.Count; i++)
{
    if (listaSuper[i].Equals(productos, StringComparison.InvariantCultureIgnoreCase))
    {
        indice = i;
        break;
    }
}
if (indice >= 0)
{
    string eliminado = listaSuper[indice];
    listaSuper.RemoveAt(indice);
    Console.WriteLine($"El producto {eliminado} estaba en la lista y fue marcado como comprado");
}
else
{
    compradosNoDisponibles.Add(productos);
    Console.WriteLine($"El producto {productos} no estaba en la lista inicial");
}

Console.WriteLine("Resultados finales de compra");
Console.WriteLine("Productos NO COMPRADOS");
if (listaSuper.Count == 0) Console.WriteLine("Compraste todo en la lista");
else Console.WriteLine(string.Join(", ", listaSuper));

Console.WriteLine("Productos COMPRADOS pero NO estaban en la lista");
if (compradosNoDisponibles.Count == 0) Console.WriteLine("Ninguno. Todos estaban en lista");
else Console.WriteLine(string.Join(", ", compradosNoDisponibles));

Console.WriteLine("Los productos comprados son: ");
if (compra.Count == 0) Console.WriteLine("No compraste nada");
else Console.WriteLine(string.Join(", ", compra));

}


