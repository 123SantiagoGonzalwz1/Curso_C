﻿/* using System;
using System.IO;

// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
int petCount = 0;
string anotherPet = "y";
bool validEntry = false;
int petAge = 0;

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";

            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options
do
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
        // NOTE: We could put a do statement around the menuSelection entry to ensure a valid entry, but we
        //  use a conditional statement below that only processes the valid entry values, so the do statement 
        //  is not required here. 
    }

    // use switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j].ToString());
                    }
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        case "2":
            // Add a new animal friend to the ourAnimals array
            //
            // The ourAnimals array contains
            //    1. the species (cat or dog). a required field
            //    2. the ID number - for example C17
            //    3. the pet's age. can be blank at initial entry.
            //    4. the pet's nickname. can be blank.
            //    5. a description of the pet's physical appearance. can be blank.
            //    6. a description of the pet's personality. can be blank.

            anotherPet = "y";
            petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {
                // get species (cat or dog) - string animalSpecies is a required field 
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            //Console.WriteLine($"You entered: {animalSpecies}.");
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // get the pet's age. can be ? at initial entry.
                do
                {
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);


                // get a description of the pet's physical appearance - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (validEntry == false);


                // get a description of the pet's personality - animalPersonalityDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (validEntry == false);


                // get the pet's nickname. animalNickname can be blank.
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (validEntry == false);

                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                petCount = petCount + 1;

                // check maxPet limit
                if (petCount < maxPets)
                {
                    // another pet?
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
                //NOTE: The value of anotherPet (either "y" or "n") is evaluated in the while statement expression - at the top of the while loop
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            break;

        case "3":
            // Rastrear si todos los datos son válidos
            bool allDataValid = true;

            // Ensure animal ages and physical descriptions are complete
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    string currentAge = ourAnimals[i, 2].Replace("Age: ", "").Trim();
                    string currentPhysicalDescription = ourAnimals[i, 4].Replace("Physical description: ", "").Trim();

                    // Verificar si la edad o la descripción física es incompleta
                    if (currentAge == "?" || string.IsNullOrWhiteSpace(currentPhysicalDescription))
                    {
                        Console.WriteLine($"Pet {ourAnimals[i, 0]} is missing data.");
                        allDataValid = false;

                        // Si falta la edad o se desconoce
                        if (currentAge == "?")
                        {
                            bool validAge = false;
                            while (!validAge)
                            {
                                Console.WriteLine("Enter the correct age for this pet (numeric value):");
                                string newAge = Console.ReadLine();

                                // Validar que la edad es un valor numérico
                                if (int.TryParse(newAge, out int ageValue) && ageValue >= 0)
                                {
                                    ourAnimals[i, 2] = "Age: " + ageValue;
                                    validAge = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid age. Please enter a valid numeric value.");
                                }
                            }
                        }

                        // Si falta la descripción
                        if (string.IsNullOrWhiteSpace(currentPhysicalDescription))
                        {

                            bool validDescription = false;
                            while (!validDescription)
                            {
                                Console.WriteLine("Enter the physical description for this pet:");
                                string newPhysicalDescription = Console.ReadLine();

                                // Validar que la descripción no sea nula o vacía
                                if (!string.IsNullOrWhiteSpace(newPhysicalDescription) && newPhysicalDescription.Length > 0)
                                {
                                    ourAnimals[i, 4] = "Physical description: " + newPhysicalDescription;
                                    validDescription = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid description. It cannot be null or empty. Please enter a valid description.");
                                }
                            }
                        }
                    }
                }
            }

            // Si todos los datos eran válidos o se actualizaron exitosamente
            if (allDataValid)
            {
                Console.WriteLine("Age and physical description fields are complete for all of our friends.");
            }
            else
            {
                Console.WriteLine("All missing or incomplete data has been update sucessfully.");
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4":
            bool allNicknameDataValid = true;

            // Ensure animal nicknames and personality descriptions are complete
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    string currentNickname = ourAnimals[i, 3].Replace("Nickname: ", "").Trim();
                    string currentPersonalityDescription = ourAnimals[i, 5].Replace("Personality: ", "").Trim();

                    // Verificar si el apodo o la descripción de la personalidad está incompleta
                    if (string.IsNullOrWhiteSpace(currentNickname) || string.IsNullOrWhiteSpace(currentPersonalityDescription))
                    {
                        Console.WriteLine($"Pet {ourAnimals[i, 0]} is  missing nickname or personality data.");
                        allNicknameDataValid = false;

                        // Si falta el apodo
                        if (string.IsNullOrWhiteSpace(currentNickname))
                        {
                            bool  validNickname = false;
                            while (!validNickname)
                            {
                                Console.WriteLine("Enter the correct nickname for this pet: ");
                                string newNickname = Console.ReadLine();

                                // Validar que el apodo no sea nulo o vacío
                                if (!string.IsNullOrWhiteSpace(newNickname) && newNickname.Length > 0)
                                {
                                    ourAnimals[i, 3] = "Nickname: " + newNickname;
                                    validNickname = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid nickname. It cannot be null or empty.");
                                }

                            }

                        }

                        // Si falta la descripción de la personalidad
                        if (string.IsNullOrWhiteSpace(currentPersonalityDescription))
                        {
                            bool validPersonalityDescription = false;
                            while (!validPersonalityDescription)
                            {
                                Console.WriteLine("Enter the personality description for this pet: ");
                                string newPersonalityDescription = Console.ReadLine();

                                // Validar que la descripción no sea nula o vacía
                                if (!string.IsNullOrWhiteSpace(newPersonalityDescription) && newPersonalityDescription.Length > 0)
                                {
                                    ourAnimals[i, 5] = "Personality: " + newPersonalityDescription;
                                    validPersonalityDescription = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid personality description. It cannot be null or empty.");
                                }
                            }
                        }
                    }
                }
            }

            if (allNicknameDataValid)
            {
                Console.WriteLine("Nickname and personality description fields are complete for all pets.");
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "5":
            // Edit an animal’s age");
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            // Edit an animal’s personality description");
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        
        case "7":
            // Display all cats with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":
            // Display all dogs with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "exit");
 */

// Tipos de datos
/* Console.WriteLine("Signed integral types: ");

Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}"); */

/* Console.WriteLine("");
Console.WriteLine("Unsigned integral types: ");

Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong : {ulong.MinValue} to {ulong.MaxValue}"); */

// Punto flotante
/* Console.WriteLine("");
Console.WriteLine("Floating point types: ");

Console.WriteLine($"float : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)"); */

// Variable de tipo de referencia
// int[] data; // Referencia nula
// Instancia
// data = new int[3];

// Más simplificado
/* int[] data = new int[3];

string shortenedString = "Hello World!";
Console.WriteLine(shortenedString); */

/* int first = 2;
string second = "4";
string result = first + second;

Console.WriteLine(result); */
/* 
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}"); */

// Coerción
/* decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}"); */

// Conversión de restricción
/* decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float: {myFloat}"); */

// ToString()
/* int first =  5;
int second = 7;
string message = first.ToString() + second.ToString();

Console.WriteLine(message); */

// Parse()
/* string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);

Console.WriteLine(sum); */

// Clase Convert
/* string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);

Console.WriteLine(result); */

/* int value = (int)1.5m;
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m);
Console.WriteLine(value2); */

// TryParse()
/* string value = "102";
int result = 0;

if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

Console.WriteLine($"Measurement (w/ offset): {50 + result}"); */

/* string value = "bad";
int result = 0;

if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
{
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");
} */

/* string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number;

    if (decimal.TryParse(value, out number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}"); */

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");