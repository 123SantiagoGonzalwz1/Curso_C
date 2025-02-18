using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Interfaces
{
    internal interface ISuperHeroe
    {
        int id { get; set; }
        string nombre { get; set; }
        string identidadSecreta { get; set; }
    }
}
