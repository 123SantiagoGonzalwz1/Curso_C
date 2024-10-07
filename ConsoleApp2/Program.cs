/* Secuencias de escape:
\ Para usar comillas dobles en la cadena
\n Agrega una nueva línea
\t Agrega tabulación

Literal de cadena textual:
@ Conserva los espacios en blanco y caracteres */
/* Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// Generar factura en Japonés usando Unicode
Console.Write("\n\n\u65e5\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// Comando para correr la aplicación
Console.WriteLine(@"c:\invoices\app.exe -j"); */

// Concatenación de cadenas
/* string firstName = "Bob";
string greeting = "Hello ";
Console.WriteLine(greeting + " " + firstName + "!"); */

// Interpolación de cadenas: permite hacer referencia a la variable 'projectName' y literal de cadena textual: nos permite usar el \
/* string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data"); */

// Desafío mostrando el siguiente mensaje con lo aprendido
string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($"View English output: \n\t c:\\Exercise\\{projectName}\\data.txt");
Console.Write("\n");
Console.WriteLine($"{russianMessage}: \n\t c:\\Exercise\\{projectName}\\ru-Ru\\data.txt");