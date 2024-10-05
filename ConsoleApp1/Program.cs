// Comentario de una línea

/*
* Comentario de
* varias líneas
*/

/// <summary>
///  Documentación en XML
/// </summary>

/* // Output
Console.WriteLine("Please enter the number: ");

// Input
string userInputText  = Console.ReadLine();

Console.WriteLine("Your value is: " + userInputText);

// Type conversion

int userInputNumber = Convert.ToInt32(userInputText);
int number = 10;
int result = userInputNumber + number;

Console.WriteLine(result); */

/* Console.WriteLine("Please write temperature: ");
int temperature = Convert.ToInt32(Console.ReadLine());

if (temperature > 20) {
    Console.WriteLine("You don't need a coat!");
    if (temperature > 35) {
        Console.WriteLine("It's really hot!");
    }
}

else
{
    Console.WriteLine("You need a coat!");
} */

/* // Crear un programa que verifique si un número es positivo o negativo.
Console.WriteLine("Por  favor, ingrese un número: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());



if(inputNumber > 0) {
    Console.WriteLine("El número ingresado es positivo");
}

else {
    Console.WriteLine("El número es negativo");
}

// Escribir un programa que tome dos números de la consola y muestre el máximo de los dos.
Console.WriteLine("Ingrese un número, por favor: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese un número, por favor: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2) {
    Console.WriteLine("El primer número es mayor");
}

else {
    Console.WriteLine("El segundo número es mayor");
} */

/* // Escribir un programa para clasificar una edad determinada.
Console.WriteLine("Ingrese su edad: ");
int age = Convert.ToInt32(Console.ReadLine());

// Categorizar la edad como "niño" (menos de 12 años), "adolescente" (de 12 a 18 años),
// "adulto" (de 19 a 60 años) o "mayor" (más de 60 años)
if (age < 12) {
    Console.WriteLine("Eres un niño");
} else if (age >= 12 && age <= 18) {
    Console.WriteLine("Eres un adolescente");
} else if (age >= 19 && age <= 60) {
    Console.WriteLine("Eres un adulto");
} else {
    Console.WriteLine("Eres un adulto mayor");
} */

/* int[] array1 = [3,5,7,9]; // Matriz con valores
int[] array2 = new int[4]; // Matriz vacía con un tamaño especifico

Console.WriteLine("Array 1 value 0: " + array1[0]);
Console.WriteLine("Array 2 value 0: " + array2[0]); */

/* for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("Ingrese sus valores: ");
string[] array = new string[5];

for (int i = 0; i < 5; i++)
{
    array[1] = Console.ReadLine();
}

Console.WriteLine("Elemento con index 2 es: " + array[2]); */

// Crear y mostrar una matriz de enteros
/* int[] array = [1,23,54,5,12];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Elemento con index " + i + " es: " + array[i]);
}
 */

/* Escribir un programa que cuente cuántos números
entre 1 y 100 son divisible por 3 sin dejar resto. */
/* 
int count = 0;

for (int i = 1; i <= 100; i++)
{
    if(i  % 3 == 0) {
        Console.WriteLine("Número divisible por 3: "+ i);
        count++;
    }

}

Console.WriteLine("El total de números divisible por 3 es: " + count); */

// Calcular la suma de todos los elementos en una matriz de números enteros
/* 
int[] numbers = new int[5];
int sum = 0;

Console.WriteLine("Ingrese 5 números enteros: ");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    sum += numbers[i];
}

Console.WriteLine("La suma de los elementos del array es: " + sum); */

/* Console.WriteLine("Por favor, ingresa un número: ");

try
{
    string inputText = Console.ReadLine();
    int convertNumber = Convert.ToInt32(inputText);
    Console.WriteLine("Tu valor es: " + convertNumber);
}
catch (Exception e)
{
    Console.WriteLine("¡El valor ingresado no es valido! " + e.message);
} */

// Console.WriteLine("Por favor, ingresa el tamaño del cubo: ");
// int bucketSize = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Por favor, ingresa el tamaño del barril: ");
// int barrelSize = Convert.ToInt32(Console.ReadLine());

// int waterInsideBarrel = 0;

// while (waterInsideBarrel <= barrelSize)
// {
//     waterInsideBarrel = bucketSize + waterInsideBarrel;
//     Console.WriteLine("Agua dentro del barril: " + waterInsideBarrel);
// }

/* for (int i = 0; i < 10; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine("Continuar por: " + i);
        continue;
    }
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine("Descanso para: " + i);
        break;
    }
    Console.WriteLine(i);
} */

// Crear un programa que imprima números del 1 al 10 usando un bucle while
/* int numbers = 1;

while (numbers  <= 10)
{
    Console.WriteLine("Numero: " + numbers);
    numbers++;
} */

// Escribir un programa que pida número al usuario continuamente hasta que ingrese 0,
// momento en el cual el programa debería terminar usando una declaración break.

/* while (true)
{
    Console.WriteLine("Por favor, ingrese  un número (0 para salir): ");
    int number = Convert.ToInt32(Console.ReadLine());

    if(number == 0) {
        break;
    } else {
        Console.WriteLine("El número ingresado es: " + number);
    }
} */

// Desarrollar un programa que imprima solo números impares del 1 al 20,
// omitiendo números pares usando una instrucción continue.

/* int increment = 1;

while (increment <= 20)

{
    if(increment  % 2 == 0) {
        increment++;
        continue;
    }

    Console.WriteLine("El número es impar: " + increment);
    increment++;
} */

/* // 0-255
byte smallNumber = 100;

// -128 - 127
sbyte signedSmallNumber = -125;

int maxInt = int.MaxValue;
Console.WriteLine("Máximo valor de entero: " + maxInt);
uint maxUint = uint.MaxValue;
Console.WriteLine("Máximo valor de un  entero sin signo: " + maxUint);
long maxLong = long.MaxValue;
Console.WriteLine("Máximo  valor de largo: " + maxLong);

double result = 3.14 * 2;
Console.WriteLine("3.14 * 2 = " + result);

double floatingPoint = 5 / 3;
Console.WriteLine("5 / 3 " + floatingPoint);

float resultFloat = 3.6666666666f / 2;
Console.WriteLine("3.6666666666f / 2 " + resultFloat);

decimal resultDecimal = 3.6666666666m / 2;
Console.WriteLine("3.6666666666m / 2 " + resultDecimal);

char z = 'z';
string text = "Hello";
char fromString = text[0];
Console.WriteLine("Primer char: " + fromString);

DateTime timeNow = DateTime.Now;
Console.WriteLine("Fecha de ahora: " + timeNow);

var i = 5;
Console.WriteLine("Número de var: " + i);

var s = "Hello";
Console.WriteLine("Texto de var: " + s);

var a = new[] { 0,1,2 };
Console.WriteLine("Array[1] de var: " + a[1]); */

/* int i = 10;
double d = i;
Console.WriteLine(i);

double d2 = 10.5;
Console.WriteLine("d2 = " + d2);

int i2 = (int)d2;
Console.WriteLine("i2 = " + i2);

double d3 = i2;
Console.WriteLine("d3  = " + d3); */

/* Console.WriteLine("Por favor, ingrese un número del 1 al 5: ");
var number = Convert.ToInt32(Console.ReadLine());
Number num = (Number)number;
Console.WriteLine(num);

enum Number
{
    One = 1,
    Two = 2,
    Three = 3,
    Four = 4
} */
/* switch (number)
{
    case 1:
        Console.WriteLine("Uno");
        break;
    case 2:
        Console.WriteLine("Dos");
        break;

    case 3:
        Console.WriteLine("Tres");
        break;

    case 4:
        Console.WriteLine("Cuatro");
        break;

    case 5:
        Console.WriteLine("Cinco");
        break;

    default:
        Console.WriteLine("¡El valor no es soportado!");
        break;
} */

/* enum Categories {

    Electronics = 1,
    Food = 5,
    Automotive = 6,
    Arts = 10,
    BeautyCare = 11,
    Fashion = 15
} */

/* double number = 4556.67;
Console.WriteLine(number.ToString("C"));

string str1 = "s1";
string str2 = "s2";
string str3 = "s3";

string concatenation = "extra " + str1 + str2 + str3 + " info";
string interpolation = $"extra {str1} {str2} {str3} info";
Console.WriteLine("Concatenación = " + concatenation);
Console.WriteLine($"Interpolación = {interpolation}");
Console.WriteLine("Interpolación  = {interpolation}"); */

/* string s1 = "Si existe un carácter o cadena especificada.";
bool result = s1.Contains("carácter");
Console.WriteLine($"Resultado: {result}");

string s2 = "character1";
string s3 = "character1";
bool result2 = s2.Equals(s3);
Console.WriteLine($"Resultado: {result2}");

string s4 = "El método devuelve una nueva cadena.";
string s5 = s4.Insert(9, " extra words");
Console.WriteLine(s5);

string s6 = "Roman Malyi fdsf";
string[] s7 = s6.Split(' ');
Console.WriteLine(s7[2]);

string s8 = "ROMAN";
string s9 = s8.ToLower();
Console.WriteLine(s9);

string s10 = "**Malyi**";
string s11 = s10.Trim('*');
Console.WriteLine(s11);

string s12 = "  Malyi  ";
string s13 = s12.Trim();
Console.WriteLine(s13); */

/* DateTime date1 = new DateTime(2025, 5, 15);
DateTime date2 = DateTime.Now;

date1 = date1.AddDays(1);
date2 = date2.AddDays(-5);

Console.WriteLine(date1);
Console.WriteLine(date1.ToString("M/d/yy"));

if(date1 > date2) {
    Console.WriteLine("date1 > date2");
}

Console.WriteLine("Por favor, ingresa tu fecha de cumpleaños: ");
DateTime birthday = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Tu fecha es: " + birthday); */

/* TimeSpan span1 = new TimeSpan(30, 10, 0);
TimeSpan span2 = TimeSpan.FromHours(100);

DateTime date1 = DateTime.Now;
DateTime date2 = date1.AddHours(40);
TimeSpan span3 = date2 - date1;

TimeSpan result = span1.Add(new TimeSpan(45, 0, 0));

Console.WriteLine(span1);
Console.WriteLine(span1.ToString("g"));

Console.WriteLine("Escribe tu intervalo de tiempo: ");
TimeSpan s = TimeSpan.Parse(Console.ReadLine());
Console.WriteLine(s); */

// Crear un programa que convierta un número en el nombre de un mes usando la declaración switch-case
Console.WriteLine("Por favor, ingresa un número del 1 al 12");
int month = Convert.ToInt32(Console.ReadLine());

switch (month)
{
    case 1:
        Console.WriteLine("Enero");
        break;
    case 2:
        Console.WriteLine("Febrero");
        break;
    case 3:
        Console.WriteLine("Marzo");
        break;
    case 4:
        Console.WriteLine("Abril");
        break;
    case 5:
        Console.WriteLine("Mayo");
        break;
    case 6:
        Console.WriteLine("Junio");
        break;
    case 7:
        Console.WriteLine("Julio");
        break;
    case 8:
        Console.WriteLine("Agosto");
        break;
    case 9:
        Console.WriteLine("Septiembre");
        break;
    case 10:
        Console.WriteLine("Octubre");
        break;
    case 11:
        Console.WriteLine("Noviembre");
        break;
    case 12:
        Console.WriteLine("Diciembre");
        break;
    default:
        Console.WriteLine("¡Número no válido!");
        break;
}