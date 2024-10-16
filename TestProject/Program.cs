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
/* string originalMessage = "The quick brown fox jumps over the lazy dog.";

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
Console.WriteLine($"'o' appears {letterCount} times."); */

// Student Grading
/* using System;

// initialize variables - graded assignments
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

string[] studentNames = new string[]  { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{

    string currentStudent = name;

    if (currentStudent == "Sophia")
    {
        studentScores = sophiaScores;
    }
    else if (currentStudent == "Andrew")
    {
        studentScores = andrewScores;
    }
    else if (currentStudent == "Emma")
    {
        studentScores = emmaScores;
    }
    else if (currentStudent == "Logan")
    {
        studentScores = loganScores;
    }
    else if (currentStudent == "Becky")
    {
        studentScores = beckyScores;
    }
    else if (currentStudent == "Chris")
    {
        studentScores = chrisScores;
    }
    else if (currentStudent == "Eric")
    {
        studentScores = ericScores;
    }
    else if (currentStudent == "Gregor")
    {
        studentScores = gregorScores;
    }
    else
    {
        continue;
    }

    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    int gradeAssignments = 0;

    foreach (int score in studentScores)
    {
        gradeAssignments += 1;

        if (gradeAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
        }
        else
        {
            sumAssignmentScores += score / 10;
        }
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
    {
        currentStudentLetterGrade = "A+";
    }
    else if (currentStudentGrade >= 93)
    {
        currentStudentLetterGrade = "A";
    }
    else  if (currentStudentGrade >= 90)
    {
        currentStudentLetterGrade = "A-";
    }
    else if (currentStudentGrade >= 87)
    {
        currentStudentLetterGrade = "B+";
    }
    else if (currentStudentGrade >= 83)
    {
        currentStudentLetterGrade = "B";
    }
    else if (currentStudentGrade >= 80)
    {
        currentStudentLetterGrade = "B-";
    }
    else if (currentStudentGrade >= 77)
    {
        currentStudentLetterGrade = "C+";
    }
    else if (currentStudentGrade >= 73)
    {
        currentStudentLetterGrade = "C";
    }
    else if (currentStudentGrade >= 70)
    {
        currentStudentLetterGrade = "C-";
    }
    else if (currentStudentGrade >= 67)
    {
        currentStudentLetterGrade = "D+";
    }
    else if (currentStudentGrade >= 63)
    {
        currentStudentLetterGrade = "D";
    }
    else if (currentStudentGrade >= 60)
    {
        currentStudentLetterGrade = "D-";
    }
    else
    {
        currentStudentLetterGrade = "F";
    }


    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
 */

/*
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
- use the following report format to report student grades:

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;
    int extraCreditScore = 0;  // Cambiado para manejar solo un crédito adicional

    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;
    decimal finalGrade = 0;
    decimal extraCreditPoints = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        // Sumar solo los exámenes (primeros 5 puntajes)
        if (gradedAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
        }
        else
        {
            // Solo el primer valor de crédito adicional
            extraCreditScore = score;
            break;  // Rompemos el loop aquí para evitar sumar más de un crédito
        }
    }

    // Calcular el promedio de los exámenes
    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    // Calcular la puntuación final con el crédito adicional (10%)
    finalGrade = (sumAssignmentScores + (extraCreditScore * 0.10M)) / examAssignments;

    // Calcular los puntos de crédito adicionales ajustados
    extraCreditPoints = extraCreditScore * 0.10M;

    // Asignar la calificación en letras basada en `finalGrade`
    if (finalGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (finalGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (finalGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (finalGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (finalGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (finalGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (finalGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (finalGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (finalGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (finalGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (finalGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (finalGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    // Mostrar los resultados corregidos
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade:F1}\t\t{finalGrade:F2}\t{currentStudentLetterGrade}\t{extraCreditScore} ({extraCreditPoints:F2} pts)");
}

// Mantener la consola abierta para ver los resultados
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();

