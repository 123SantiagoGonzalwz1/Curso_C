using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPedidos
{
    public class clsProductos
    {
        public int idProductos { get; set; }
        public string Descripcion { get; set; }
        public string CodigoBarras { get; set; }

        public override string ToString()
        {
            return $"ID del producto: {idProductos}.\nDescripción: {Descripcion}.\nCódigo de Barras: {CodigoBarras}";
        }
    }
}
