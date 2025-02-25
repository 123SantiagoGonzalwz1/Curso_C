using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPedidos
{
    public class ctrObtenProductos
    {
        private intRepositorioProducto repoProductos;
        public Dictionary<string, recProductos> Productos { get; set; }
        public ctrObtenProductos(intRepositorioProducto prepoProductos)
        {
            repoProductos = prepoProductos;
            Productos = new Dictionary<string, recProductos>();
        }

        public void ObtenProductos()
        {
            Productos.Clear();
            Productos = repoProductos.ObtenTodos();
        }

        public bool ObtenProducto(string codigoBarras, out recProductos producto)
        {
            return Productos.TryGetValue(codigoBarras,
                                         out producto);
        }
    }
}
