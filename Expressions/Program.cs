/* Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a"); */
/*
string value1 = " a";
string value2 = "A ";

Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); */
/*
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a"); */

/* Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1); */

/* string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow")); */

/* int a = 7;
int b = 6;
Console.WriteLine(a != b) // True

string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2) // False */

// Operador condicional
/* int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50; 
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}"); */

// En este desafío, implementará un operador condicional para simular un "cara o cruz".
// La lógica de decisión resultante mostrará heads o tails.
/* Random coin = new();
int flip = coin.Next(0, 2);

Console.WriteLine((flip == 0) ? "heads" : "tails"); */
/* 
string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
} */

/* bool flag = true;
int value = 0;

if (flag)
{

    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}"); */

// Usando un bloque de código sin llaves, cuando alla solo una línea de código
// bool flag = true;

// No es muy legible
// if (flag) Console.WriteLine(flag);

// Correcto
/* if(flag)
    Console.WriteLine(flag); */

/* string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck"); */

/* int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{

    total += number;

    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}"); */

/* int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager Associate";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}"); */

// Desafio convertir las instrucciones if, elseif, else a switch-case
/* string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color  = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}"); */
//  Inicializador - Condición - Iterador
/* for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i); // Cuerpo
} */

/* for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
} */

/* for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i); // Cuerpo
} */

/* for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
} */

/* string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
} */

// Desafio FizzBuzz
for (int i = 1; i <= 100; i++)
{
    if (i  % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else if (i % 3 == 0  && i % 5 == 0)
        Console.WriteLine($"{i} - FizzBuzz");
    else
        Console.WriteLine($"{i}");
}