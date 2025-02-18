global using libPedidos;
using AplicacionPedidos;

int opcion = 0;

do
{
    Console.WriteLine("Menú de Opciones\n");

    Console.WriteLine("1. Ejemplo de cliente.\n");
    Console.WriteLine("2. Ejemplo de record de producto.\n");
    Console.WriteLine("3. Ejemplo de paso de parámetros a un método.\n");
    Console.WriteLine("20. Salir\n");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            FuncionesPrincipales.EjemploCliente();
            break;
        case 2:
            FuncionesPrincipales.EjemploRecordProducto();
            break;
        case 3:
            FuncionesPrincipales.EjemploDesglosaImpuestos();
            break;
        default:
            break;
    }
}
while (opcion != 20);