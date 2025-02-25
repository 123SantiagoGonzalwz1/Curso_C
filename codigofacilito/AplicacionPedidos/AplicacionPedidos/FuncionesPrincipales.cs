using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionPedidos
{
    public static class FuncionesPrincipales
    {
        public static void EjemploCliente()
        {
            clsClientes cliente = new()
            {
                idCliente = 1,
                NombreCompleto = "Santiago González",
                Rfc = "SGF010165"
            };
            Console.WriteLine(cliente.ToString());
        }

        public static void EjemploRecordProducto()
        {
            clsProductos producto = new()
            {
                idProductos = 1,
                Descripcion = "REF MANZANA 600 ML",
                CodigoBarras = "0001"
            };

            clsProductos producto2 = new();
            producto2 = producto;

            recProductos rProducto = new(1, "REF MANZANA 600 ML", "0001");
            recProductos rProducto2 = rProducto;

            Console.WriteLine($"Producto: {producto}");
            Console.WriteLine($"Producto2: {producto2}");
            Console.WriteLine($"rProcducto: {rProducto}");
            Console.WriteLine($"rProducto2: {rProducto2}");

            if (producto == producto2)
            {
                Console.WriteLine("Los objetos son iguales");
            }
            else
            {
                Console.WriteLine("Los objetos son diferentes");
            }

            if (rProducto == rProducto2)
            {
                Console.WriteLine("Los registros son iguales");
            }
            else
            {
                Console.WriteLine("Los registros son diferentes");
            }

        }

        public static void EjemploDesglosaImpuestos()
        {
            clsProductosPrecios producto = new()
            {
                idProductos = 1,
                Descripcion = "REF MANZANA 600 ML",
                CodigoBarras = "0001",
                PrecioPublico = 17.5m,
                PrecioMayoreo = 17,
                PorcentajeIva = 16,
                PorcentajeIeps = 8
            };

            decimal precioSinImpuestos;

            Console.WriteLine(producto);

            recMontosImpuestos Montos = new(0, 0); 
            precioSinImpuestos = producto.DesglosaImpuestos(Montos);

            Console.WriteLine(precioSinImpuestos.ToString("C"));
            Console.WriteLine(Montos.ToString());
        }

        public static void EjemploColeccionesClientes()
        {
            List<clsClientes> Clientes = [];
            int opcion = 0;

            do
            {
                Console.WriteLine("Opciones de la lista de clientes.\n");

                Console.WriteLine("1. Agregar cliente.");
                Console.WriteLine("2. Mostrar lista.");
                Console.WriteLine("3. Eliminar cliente.");
                Console.WriteLine("4. Salir.");
                opcion = Convert.ToInt32(Console.ReadLine());
                
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Dame los datos del cliente.\n");
                        clsClientes cliente = new();

                        Console.WriteLine("Ingresa el ID del cliente: ");
                        cliente.idCliente = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingresa el nombre completo del cliente: ");
                        cliente.NombreCompleto = Console.ReadLine();
                        Console.WriteLine("Ingresa el RFC del cliente: ");
                        cliente.Rfc = Console.ReadLine();
                        Clientes.Add(cliente);
                        break;
                    case 2:
                        foreach (clsClientes item in Clientes)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ingresa la posición de la lista: ");
                        int posicion = Convert.ToInt32(Console.ReadLine());
                        Clientes.RemoveAt(posicion);
                        break;
                    default:
                        break;
                }

            } while (opcion != 4);
        }

        public static void EjemploDiccionario()
        {
            try
            {
                clsRepositorioArchivoProductos repoArchProductos = new(@"C:\Users\Santiago\Documents\github-proyectos\proyectos\github\curso-c\codigofacilito\AplicacionPedidos\AplicacionPedidos\Archivos\Productos.txt");
                ctrObtenProductos cProductos = new(repoArchProductos);
                cProductos.ObtenProductos();
                int opcion = 0;

                do
                {
                    Console.WriteLine("Opciones del diccionario de productos.\n");

                    Console.WriteLine("1. Ver la lista de productos.");
                    Console.WriteLine("2. Buscar un producto por código de barras.");
                    Console.WriteLine("3. Salir.");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            foreach (recProductos item in cProductos.Productos.Values)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            break;
                        case 2:
                            Console.WriteLine("Ingresa el código de barras: ");
                            string codigo = Console.ReadLine();

                            if (cProductos.ObtenProducto(codigo, out recProductos producto))
                                Console.WriteLine($"El valor encontrado es: {producto}");
                            else
                                Console.WriteLine("El producto no se encontró.");
                            break;
                        default:
                            break;
                    }

                } while (opcion != 3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
