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

// Crear un programa que verifique si un número es positivo o negativo.
Console.WriteLine("Por  favor, ingrese un número: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());



if(inputNumber > 0) {
    Console.WriteLine("El número ingresado es positivo");
}

else {
    Console.WriteLine("El número es negativo");
}

