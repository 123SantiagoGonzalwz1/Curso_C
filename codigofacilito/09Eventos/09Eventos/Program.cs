using _09Eventos;

int opcion = 0;

do
{
    Console.WriteLine("1. Eventos con Delgados.\n");
    Console.WriteLine("2. Eventos con EventHandler.\n");
    Console.WriteLine("3. Eventos con Delegados y Expresiones Lambda.\n");
    Console.WriteLine("4. Eventos con EventHandler y Expresiones Lambda.\n");
    Console.WriteLine("10. Salir.");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            clsRepositorioDelegado repo = new();
            repo.ReportarAvance += MuestraAvance;
            repo.ObtenTodos();
            break;
        case 2:
            clsRepositorioEventHandler repo2 = new();
            repo2.ReportaAvance += MuestraAvance2;
            repo2.ObtenTodos();
            break;
        case 3:
            clsRepositorioDelegado repo3 = new();
            repo3.ReportarAvance += (int i) => { Console.Write(i.ToString() + " "); };
            repo3.ObtenTodos();
            break;
        case 4:
            clsRepositorioEventHandler repo4 = new();
            repo4.ReportaAvance += (object? _, Argumentos e) => { Console.Write(e.Valor.ToString() + " "); };
            repo4.ObtenTodos();
            break;
        default:
            break;
    }
}
while (opcion != 10);

void MuestraAvance2(object? sender, Argumentos e)
{
    Console.Write(e.Valor.ToString() + " ");
}

void MuestraAvance(int valor)
{
    Console.Write(valor.ToString() + " ");
}