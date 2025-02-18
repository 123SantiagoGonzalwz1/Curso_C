using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPedidos
{
    public class clsPersonas
    {
        private int _idPersona;
        private string _nombreCompleto;

        protected int IdPersona { get => _idPersona; set => _idPersona = value; }
        public string NombreCompleto { get => _nombreCompleto; set => _nombreCompleto = value; }

        public clsPersonas()
        {
            _idPersona = 0;
            _nombreCompleto = String.Empty;
        }
    }
}
