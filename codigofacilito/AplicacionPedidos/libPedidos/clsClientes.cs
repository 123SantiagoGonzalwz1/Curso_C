using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPedidos
{
    public class clsClientes : clsPersonas
    {
        public string Rfc { get; set; }
        public int idCliente 
        {
            get { return IdPersona; }
            set { IdPersona = value; }
        }

        public override string ToString()
        {
            string cadena = $"ID del client: {idCliente.ToString()}.\nNombre Completo: {NombreCompleto}.\nRfc: {Rfc}.";
            return cadena;
        }
    }
}
