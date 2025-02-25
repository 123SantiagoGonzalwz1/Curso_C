using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPedidos
{
    public class clsRepositorioArchivoProductos : intRepositorioProducto
    {
        public string NombreArchivo { get; set; }

        public clsRepositorioArchivoProductos(string nombreArchivo)
        {
            NombreArchivo = nombreArchivo;
        }

        public Dictionary<string, recProductos> ObtenTodos()
        {
            TextReader textReader;
            string linea;
            Dictionary<string, recProductos> Productos = new();

            try
            {
                using (textReader = new StreamReader(NombreArchivo))
                {
                    do
                    {
                        linea = textReader.ReadLine();
                        if (linea != null)
                        {
                            string[] campos = linea.Split(',');
                            Productos.Add(campos[2], new recProductos(
                                Convert.ToInt32(campos[0]), campos[1], campos[2]));
                        }
                    }
                    while (linea != null);
                    textReader.Close();
                }
                return Productos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
