// Exepción de ArrayTypeMismatchException
/* string[] names = { "Dog", "Cat", "Fish" };
Object[] objs = (Object[])names;

Object obj = (Object)13;
objs[2] = obj;

// Exepción DivideByZeroException
int number1 = 3000;
int number2 = 0;
Console.WriteLine(number1 / number2);

// Excepción de FormatException
int valueEntered;
string userValue = "two";
valueEntered = int.Parse(userValue);

// Excepción de IndexOutOfRangeException
int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
int[] values2 = new int[6];

values2[values1.Length - 1] = values1[values1.Length - 1];

// Excepción de InvalidCastException
object obj = "This is a string";
int num = (int)obj;

// Excepción de NullReferenceException
int[] values = null;
for (int i = 0; i <= 9; i++)
{
    values[i] = i * 2;
}

string? lowCaseString = null;
Console.WriteLine(lowCaseString.ToUpper());

// Excepción de OverflowException
decimal x = 400;
byte i;

i = (byte)x;
Console.WriteLine(i); */

/* try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has ocurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;

    try
    {
        Console.WriteLine(float1 / float2);
        Console.WriteLine(number1 / number2);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
    }
    checked
    {
        try
        {
            smallNumber = (byte)number1;
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
        }
    }
} */

/* string[] inputValues = new string[]{ "three", "9999999999", "0", "2" };

foreach (string inputValue in inputValues)
{
    int numValue = 0;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid readResult. Please enter a valid number.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number you entered is too large or too small.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
} */

/* checked
{
    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
    }
}

try
{
    string? str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null." + ex.Message);
}

try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range." + ex.Message);
}

try
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
}

Console.WriteLine("Exiting program."); */

/* Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());

Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;

bool exit = false;

do
{
    try
    {
        averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

        exit = true;
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("An error has ocurred.");
        Console.WriteLine(ex.Message);
        Console.WriteLine($"The upper bound must be greater than {lowerBound}");
        Console.WriteLine($"Enter a new upper bound (or enter Exit to quit): ");
        string? userResponse = Console.ReadLine();
        if (userResponse.ToLower().Contains("exit"))
        {
            exit = true;
        }
        else
        {
            exit = false;
            upperBound = int.Parse(userResponse);
        }
    }
} while (exit == false);

Console.ReadLine();

static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{

    if (lowerBound >= upperBound)
    {
        throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
    }

    int sum = 0;
    int count = 0;
    decimal average = 0;

    for (int i = lowerBound; i <= upperBound; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
            count++;
        }
    }

    average = (decimal)sum / count;

    return average;

} */

string[][] userEnteredValues = new string[][]
{
    new string[] { "1", "2", "3" },
    new string[] { "1", "two", "3" },
    new string[] { "0", "1", "2" }
};

try
{
    Workflow1(userEnteredValues);
    Console.WriteLine("'Workflow1' completed successfully.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error ocurred during 'Workflow1'");
    Console.WriteLine(ex.Message);
}

static void Workflow1(string[][] userEnteredValues)
{
    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message);
            Console.WriteLine();
        }
    }
}

static void Process1(String[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        bool integerFormat = int.TryParse(userValue, out valueEntered);

        if (integerFormat == true)
        {
            if (valueEntered != 0)
            {
                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }
            }
            else
            {
                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
            }
        }
        else
        {
            throw new FormatException("Invalid data. User input values must be valid integers.");
        }
    }
}