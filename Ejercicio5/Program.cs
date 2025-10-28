// Conversión de tipo: Pedir un número decimal y convertirlo a entero (usando conversión explícita).
// Mostrar ambos valores y comentar la diferencia.

Console.WriteLine("Ingrese un número decimal:");
decimal numeroDecimal = decimal.Parse(Console.ReadLine());

int numeroEntero = (int)numeroDecimal;

Console.WriteLine($"Número decimal: {numeroDecimal}");
Console.WriteLine($"Número entero: {numeroEntero}");

Console.WriteLine("La diferencia es que el número entero no tiene la parte decimal, " +
                  "ya que al convertirlo se trunca la parte fraccionaria.");