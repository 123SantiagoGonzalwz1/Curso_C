using System.Data;

// TIPOS DE ENTEROS
int i = 123;
byte a = 0b1111_1111;
long k = 0xAFD12;

// TIPOS CON PUNTO FLOTANTE
decimal d = 5.3m;
float f = 10.4f;
double g = 20.0d;

// TIPO BOOLEANO
bool bandera = true;

// TIPO CARACTER
char c = 'a';

// VALORES NULOS
int? valorNulo = null;

// VALORES TIPO VAR
var s = 0;

Console.WriteLine("El valor de i es: {0}", i);
Console.WriteLine("El valor de a es: {0}", a);
Console.WriteLine("El valor de k es: {0:X}", k);

Console.WriteLine("\nValores con punto flotante\n");

Console.WriteLine("El valor de d es: {0}", d);
Console.WriteLine("El valor de f es: {0}", f);
Console.WriteLine("El valor de g es: {0}", g);

Console.WriteLine("El valor de bandera es: {0}", bandera);
Console.WriteLine("El valor de c es: {0}", c);
