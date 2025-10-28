// Descuento en tienda: Pedir el precio de un producto y aplicar un descuento del 10% si el precio es mayor a $1000.

Console.WriteLine("Desea saber si el producto tiene descuento? (s/n)");
string respuesta = Console.ReadLine();
if (respuesta == "s")
{
    Console.WriteLine("Ingrese el precio del producto:");
    double precioUnidad = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la cantidad de productos:");
    int cantidad = int.Parse(Console.ReadLine());

    double precioTotal = precioUnidad * cantidad;
    if (precioTotal >= 1000 )
    {
        double descuento = precioTotal * 0.10;  
        double precioConDescuento = precioTotal - descuento;
        Console.WriteLine($"El precio total con descuento es: ${precioConDescuento}");
    }
    else
    {
        Console.WriteLine($"El precio total es: ${precioTotal}, no posee descuento");
    }


}
else
{
    Console.WriteLine("Gracias por su consulta");
}