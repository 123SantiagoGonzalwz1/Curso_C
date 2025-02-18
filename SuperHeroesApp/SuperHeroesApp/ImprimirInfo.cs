using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperHeroesApp.Interfaces;

namespace SuperHeroesApp
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHero(ISuperHeroe superHeroe)
        {
            Console.WriteLine($"Id: {superHeroe.id}");
            Console.WriteLine($"Nombre: {superHeroe.nombre}");
            Console.WriteLine($"Identidad Secreta: {superHeroe.identidadSecreta}");
        }
    }
}
