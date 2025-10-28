// Contador de letras: Pedir una palabra y mostrar cuántas letras tiene.

Console.WriteLine("Ingrese una palabra: ");
string palabra = Console.ReadLine();

int cantLetras = palabra.Length;
Console.WriteLine($"La palabra {palabra} tiene {cantLetras} cantidad de letras");
