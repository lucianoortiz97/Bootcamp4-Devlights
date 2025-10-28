// Cálculo de impuestos: Pedir un ingreso anual y calcular el impuesto:
// < 10,000: 0% 10,000–50,000: 10% 50,000: 20%
// Mostrar el monto de impuesto a pagar.

Console.WriteLine("Ingrese su ingreso anual:");
double ingresoAnual = double.Parse(Console.ReadLine());

double impuesto = 0;

if (ingresoAnual < 10000)
{
    impuesto = 0;
}
else if (ingresoAnual >= 10000 && ingresoAnual <= 50000)
{
    impuesto = ingresoAnual * 0.10;
}
else
{
    impuesto = ingresoAnual * 0.20;
}

Console.WriteLine($"El monto de impuesto a pagar es: {impuesto}");