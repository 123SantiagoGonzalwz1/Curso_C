/*string cadena = "¡Hola, Mundo!";
string cadena2 = cadena;
cadena = "Hola programadores.\n\"¡Mensaje de Bienvenda!\"";
string ruta = @"C:\Users\Santiago\Documents";
int programadores = 10;
decimal sueldo = 10500.5m;
string comunidad = $"Existen {programadores} programadores en la comunidad que ganan {sueldo:C}";
int tamanio = ruta.Length;
string nombre = "   Santiago González   ";

Console.WriteLine(cadena);
Console.WriteLine(cadena2);
Console.WriteLine(ruta);
Console.WriteLine(comunidad);

Console.WriteLine("Métodos String");

Console.WriteLine("El tamaño de la cadena ruta es: {0}", tamanio);
Console.WriteLine(nombre.Trim());
Console.WriteLine(nombre.Substring(3, 10));
Console.WriteLine(nombre.StartsWith("   S"));
Console.WriteLine(nombre.Contains("González"));
Console.WriteLine(nombre.Replace('e', 'o'));
Console.WriteLine(nombre.Trim().ToLower());
Console.WriteLine(nombre.Trim().ToUpper());
*/

// Comparación de Cadenas
string nombre = "Santiago González";

Console.WriteLine(nombre == "SANTIAGO GONZÁLEZ");
Console.WriteLine(nombre.Equals("SANTIAGO GONZÁLEZ", StringComparison.OrdinalIgnoreCase));

if (nombre == "SANTIAGO GONZÁLEZ")
{
    Console.WriteLine($"El nombre: {nombre} es igual a SANTIAGO GONZÁLEZ");
}
else
{
    Console.WriteLine($"El nombre: {nombre} no es igual a SANTIAGO GONZÁLEZ");
}

if (nombre.Equals("SANTIAGO GONZÁLEZ", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine($"El nombre: {nombre} es igual a SANTIAGO GONZÁLEZ");
}
else
{
    Console.WriteLine($"El nombre: {nombre} no es igual a SANTIAGO GONZÁLEZ");
}

// Valor para Fechas
DateTime fecha = DateTime.Now;

Console.WriteLine(fecha.ToShortDateString());
Console.WriteLine(fecha.ToLongDateString());
Console.WriteLine(fecha.ToString("yyyy-MM-dd hh-mm-ss"));