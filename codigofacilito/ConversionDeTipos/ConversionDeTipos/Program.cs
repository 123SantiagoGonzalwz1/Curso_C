byte b = 200;
long l = 2000;
string cadena = "2000";
string cadena2 = "2000f";
decimal e = 0m;

// Conversiones
long bl = b;
byte lb = (byte)l;
decimal d = Convert.ToDecimal(cadena);
int i = Convert.ToInt32("2");
DateTime fecha = Convert.ToDateTime("2024-11-23");

if (Decimal.TryParse(cadena2, out e))
{
    Console.WriteLine("El valor del decimal e es: {0}", e);
}
else
{
    Console.WriteLine("La conversión no se pudo realizar.");
}

Console.WriteLine($"El valor del long bl es: {bl}");
Console.WriteLine($"El valor del byte lb es: {lb}");
Console.WriteLine($"El valor del decimal d es: {d}");
Console.WriteLine(i.ToString());
Console.WriteLine(fecha.ToShortDateString());