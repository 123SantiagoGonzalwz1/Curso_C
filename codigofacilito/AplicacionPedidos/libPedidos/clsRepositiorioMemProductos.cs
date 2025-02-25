using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPedidos
{
    public class clsRepositorioMemProductos : intRepositorioProducto
    {
        public Dictionary<string, recProductos> ObtenTodos()
        {
            Dictionary<string, recProductos> Productos = new()
            {
                {"00001", new recProductos(1, "REF MANZANA 600 ML", "00001")},
                {"00002", new recProductos(2, "DET COLOR 1 KG", "00002")},
                {"00003", new recProductos(3, "LATA ATUN X 300 G", "00003")},
                {"00004", new recProductos(4, "CREMA SOL 1 LT", "00004")},
                {"00005", new recProductos(5, "REF NARANJA 2 L", "00005")},
                {"00006", new recProductos(6, "ARROZ Z 1 KG", "00006")},
                {"00007", new recProductos(7, "PALETA MIA 20 G", "00007")}
            };
            
            return Productos;
        }
    }
}