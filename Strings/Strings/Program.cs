/* Console.WriteLine("Cédula Santiago González\n");

int altura = 170;
int edad = 20;

string nombre = "Santiago González";
string informacion = "Nació en Bogotá, es estudiante de Desarrollo de Software";
var hobby = "Deportista";

string cedula = $"La información de {nombre} es la siguiente:\n\tSu edad es: {edad}.\n\tSu altura es: {altura}cms.\n\tInformación relavante {informacion}.\n\tAdemás, su hobby es: {hobby}.";

Console.WriteLine(cedula); */

int totalJugador = 0;
int totalDealer = 0;
int num = 0;
string otraCarta = "";
string message = "";
string switchControl = "menu";
Random random = new();
int plazitCoins = 0;

while (true)
{
    Console.WriteLine("Welcome to P L A T Z I N O");
    Console.WriteLine("¿Cuántos platzicoins deseas?\nIngresa un entero.\nRecuerda que necesitas una moneda por ronda.");
    plazitCoins = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < plazitCoins; i++)
    {
        totalJugador = 0;
        totalDealer = 0;

        switch (switchControl)
        {
            case "menu":
                Console.WriteLine("Escriba '21' para jugar 21");
                switchControl = Console.ReadLine();
                i--;
                break;
            case "21":
                do
                {
                    num = random.Next(1, 12);
                    totalJugador += num;
                    Console.WriteLine("Toma una carta, jugador");
                    Console.WriteLine($"Te salió el número: {num}");
                    Console.WriteLine("¿Deseas otra carta?");
                    otraCarta = Console.ReadLine();
                }
                while (otraCarta == "Si" || otraCarta == "si" || otraCarta == "yes");

                totalDealer = random.Next(12, 23);
                Console.WriteLine($"La Máquina tiene {totalDealer}!");

                if (totalJugador > totalDealer && totalJugador < 22)
                {
                    message = "Venciste a la máquina, ¡Felicidades!";
                    switchControl = "menu";
                }
                else if (totalJugador >= 22)
                {
                    message = "Perdiste vs La Máquina, te pasaste de 21.";
                    switchControl = "menu";
                }
                else if (totalJugador <= totalDealer)
                {
                    message = "Perdiste vs La Máquina, ¡Lo siento!";
                    switchControl = "menu";
                }
                else
                {
                    message = "Condición no valida.";
                }

                Console.WriteLine(message);
                break;
            default:
                Console.WriteLine("Valor ingresado no valido en el C A S I N O.");
                break;
        }
    }
}


