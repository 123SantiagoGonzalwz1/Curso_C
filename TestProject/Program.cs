// Simulando un dado con el método random.next
/* Random dice = new(); // Instancia de una clase, objeto.
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

int firstValue = 500;
int secondValue = 600;
int largeValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largeValue); */


// Expresión booleana
/* string message = "El veloz zorro marrón salta sobre el perro perezoso.";
bool result = message.Contains("perro");
Console.WriteLine(result);

if (message.Contains("zorro"))
{
    Console.WriteLine("¿Qué dice el zorro?");
} */

// Juego de tres dados con condicionales if
/* Random dice = new();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Tirada de dados: {roll1} + {roll2} + {roll3} = {total}");

// Condición compuesta
if ((roll1 == roll2) || (roll2 == roll3) ||  (roll1 == roll3))
{
    if ((roll1 == roll2)  && (roll2 == roll3))
    {
        Console.WriteLine("¡Sacaste triples! Bonificación +6 al total.");
        total += 6;
    }
    else
    {
        Console.WriteLine("¡Sacaste pares! Bonificación +2 al total.");
        total+= 2;
    }
    Console.WriteLine($"El total incluyendo el bonus: {total}");
}

// Premios
if (total >= 16)
{
    Console.WriteLine("¡Ganaste un carro nuevo!");
}
else if (total >= 10)
{
    Console.WriteLine("¡Ganaste un computador nuevo!");
}
else if (total == 7)
{
    Console.WriteLine("¡Ganaste un viaje para dos!");
}
else
{
    Console.WriteLine("¡Ganaste un gatito!");
} */

// Mejora de la tasa de renovación de las suscripciones
/* Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0; */

/* Reglas
*   Regla 2: Si la suscripción del usuario expira en 10 días o menos, muestre el mensaje: Your subscription will expire soon. Renew now!
*   Regla 3: Si la suscripción del usuario expira en 5 días o menos, muestre los mensajes: Your subscription expires in _ days. Renew now and save 10%!
*   Regla 4: Si la suscripción del usuario expira en un día, muestre los mensajes: Your subscription expires within a day! Renew now and save 20%!
*   Regla 5: Si la suscripción del usuario ha expirado, muestre el mensaje: Your subscription has expired.
*   Regla 6: Si la suscripción del usuario no expira en 10 días o menos, no muestre ningún mensaje.
*/

/* if (daysUntilExpiration  == 0)
{
    Console.WriteLine("Su suscripción ha caducado");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Su suscripción caducará dentro de un día! ¡Renueve y ahorre 20%!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Su suscripción caducará en {daysUntilExpiration} días. ¡Renueve ahora y ahorre 10%!");
    discountPercentage = 10;
}
else if (daysUntilExpiration  <= 10)
{
    Console.WriteLine("Su suscripción caducará pronto. ¡Renueva ahora!");
}

// Oferta de descuento, de acuerdo a las reglas de negocio
if (discountPercentage > 0)
{
    Console.WriteLine($"Tienes un descuento y ahorras {discountPercentage}%.");

} */

/* string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789"; */

/* string[]  fraudulentOrderIDs = [ "A123", "B456", "C789" ];


Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process."); */
/* fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassing First:  {fraudulentOrderIDs[0]}"); */

/* string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
} */

/* int[] inventory = { 200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory."); */

// Identificar pedidos fraudulentos
/* string[] fraudulentOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orders in fraudulentOrderIDs)
{
    // Informe de los identificadores que comienzan con la letra 'B'
    if (orders.StartsWith("B")) {
        Console.WriteLine(orders);
    }
} */

// Nombres de variables locales
/* char userOption;
int gameScore;
float particlesPerMillion;
bool processedCustomer; */

// This is a code comment!

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
/* Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
} */

// Código con buenas legibilidad
/* Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
} */

// Desafio mejorar la legibilidad del código

/*
    El proposito de este código es invertir una cadena
    y contar el número de veces que aparece un cáracter
    determinado.
*/
string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");