using System.Text;
using SuperHeroesApp;
using SuperHeroesApp.Models;

var imprimirInfo = new ImprimirInfo();

SuperPoder poderVolar = new();
poderVolar.nombre = "Volar";
poderVolar.descripcion = "Capacidad para poder volar y planear en el aire";
poderVolar.nivel = NivelPoder.NivelTres;

SuperPoder superFuerza = new();
superFuerza.nombre = "Super Fuerza";
superFuerza.descripcion = "Físico extraordinariamente potenciado";
superFuerza.nivel = NivelPoder.NivelCinco;

SuperPoder regeneracion = new();
regeneracion.nombre = "Regeneración";
regeneracion.descripcion = "Capacidad para restaurar partes del cuerpo dañadas";
regeneracion.nivel = NivelPoder.NivelCuatro;

SuperHeroe superman = new();
SuperHeroe spiderman = new();

superman.id = 1;
superman.nombre = "   Superman   ";
superman.identidadSecreta = "Clark Kent";
superman.ciudad = "Metropolis";
superman.puedeVolar = true;
imprimirInfo.ImprimirSuperHero(superman);

//SuperHeroeRecord superHeroRecord = new(1, "Superman", "Clark kent");
//SuperHeroeRecord superHeroeRecord2 = new(1, "Superman", "Clark kent");

//Console.WriteLine(superHeroRecord == superHeroeRecord2);

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.superPoderes = poderesSuperman;
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);
string resultSalvarMundo = superman.SalvarElMundo();
Console.WriteLine(resultSalvarMundo);
string resultSalvarTierra = superman.SalvarLaTierra();
Console.WriteLine(resultSalvarTierra);

spiderman.id = 2;
spiderman.nombre = "Spider-Man";
spiderman.identidadSecreta = "Piter Parker";
spiderman.ciudad = "New York";
List<SuperPoder> poderesSpiderman = new List<SuperPoder>();
poderesSpiderman.Add(superFuerza);
spiderman.superPoderes = poderesSpiderman;
spiderman.puedeVolar = false;


var wolverine = new AntiHeroe();
wolverine.id = 3;
wolverine.nombre = "Wolwerine";
wolverine.identidadSecreta = "Logan";
wolverine.puedeVolar = false;
imprimirInfo.ImprimirSuperHero(wolverine);

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superFuerza);
wolverine.superPoderes = poderesWolverine;
string resultWolverinePoderes = wolverine.UsarSuperPoderes();
Console.WriteLine(resultWolverinePoderes);

string accionAntiHeroe = wolverine.RealizarAccionDeAntiHeroe("Atacar a la policia");
Console.WriteLine(accionAntiHeroe);


enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres,
    NivelCuatro,
    NivelCinco
}

public record SuperHeroeRecord(int id, string nombre, string identidadSecreta);