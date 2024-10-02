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
int[] array = [1,23,54,5,12];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Elemento con index " + i + " es: " + array[i]);
}
