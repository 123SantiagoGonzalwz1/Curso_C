// Desafio
/* string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangramArray = pangram.Split(' ');

string[] newArray = new string[pangramArray.Length];

for (int i = 0; i < newArray.Length; i++)
{
    char[] letters = pangramArray[i].ToCharArray();
    Array.Reverse(letters);
    newArray[i] = new string(letters);
}

string result = String.Join(" ", newArray);
Console.WriteLine(result); */

/* string [] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
} */


/* Console.WriteLine("Sorted...");

Array.Sort(pallets); // ordena los elementos de la matriz de forma el alfanumérica
foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Console.WriteLine("");

Console.WriteLine("Reversed...");

Array.Reverse(pallets); // invierte el orden de los elementos
foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
} */

/* string value = "abc123";
char[] valueArray = value.ToCharArray();

// Array.Reverse(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(",");
foreach (var item in items)
{
    Console.WriteLine(item);
} */


// Desafio
/* string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderStreamArray = orderStream.Split(',');

Array.Sort(orderStreamArray);
foreach (var orders in orderStreamArray)
{
    if (orders.Length == 4)
    {
        Console.WriteLine(orders);
    } else
    {
        Console.WriteLine($"{orders} - Error");
    }
} */

/* string first = "Hello";
string second = "World";

Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!"); */
/* Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}", first, second); */

/* decimal price = 123.45m;
int discount = 50;

Console.WriteLine($"Price: {price:C} (Save {discount:C})"); */

/* decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units"); */

/* decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}"); */

/* decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You save {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!";
Console.WriteLine(yourDiscount); */

/* int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"    Shares: {productShares:N3} Product");
Console.WriteLine($"        Subtotal: {subtotal:C}");
Console.WriteLine($"            Tax: {taxPercentage:P2}");
Console.WriteLine($"        Total Billed: {total:C}"); */

/* string input = "Pad this";
Console.WriteLine(input.PadRight(12, '-'));
Console.WriteLine(input.PadLeft(12, '-')); */

/* string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine); */

// Desafio
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},\nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}\n", currentProfit).PadRight(16);

comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Your logic here
Console.WriteLine(comparisonMessage);