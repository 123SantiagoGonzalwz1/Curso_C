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



