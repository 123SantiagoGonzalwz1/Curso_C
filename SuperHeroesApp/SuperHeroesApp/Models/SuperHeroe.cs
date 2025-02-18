using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperHeroesApp.Interfaces;

namespace SuperHeroesApp.Models
{
    internal class SuperHeroe : Heroe, ISuperHeroe
    {
        private string _nombre;
        public int id { get; set; } = 1;

        public override string nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value.Trim();
            }
        }

        public string nombreEIdentidadSecreta
        {
            get
            {
                return $"{nombre} ({identidadSecreta})";
            }
        }
        
        public string identidadSecreta { get; set; }
        public string ciudad;
        public List<SuperPoder> superPoderes;
        public bool puedeVolar;

        public SuperHeroe()
        {
            id = 1;
            superPoderes = new List<SuperPoder>();
            puedeVolar = false;
        }

        public string UsarSuperPoderes()
        {
            StringBuilder sb = new();

            foreach (var poder in superPoderes)
            {
                sb.AppendLine($"{nombreEIdentidadSecreta} esta usando el super poder {poder.nombre}!!!");
            }

            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{nombreEIdentidadSecreta} ha salvado el mundo.";
        }

        public override string SalvarLaTierra()
        {
            // return base.SalvarLaTierra();
            return $"{nombreEIdentidadSecreta} ha salvado la tierra.";
        }
    }
}
