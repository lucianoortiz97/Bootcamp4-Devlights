// Múltiplos de un número: Pedir dos números e indicar si el primero es múltiplo del segundo.

Console.WriteLine ("Ingresar el primer número:");
double numero1 = Convert.ToDouble (Console.ReadLine ());

Console.WriteLine ("Ingresar el segundo número:");
double numero2 = Convert.ToDouble (Console.ReadLine ());

if (numero1 % numero2 == 0)
{
    Console.WriteLine ($"El número {numero1} es múltiplo de {numero2}");
}
else
{
    Console.WriteLine ($"El número {numero1} no es múltiplo de {numero2}");
}

