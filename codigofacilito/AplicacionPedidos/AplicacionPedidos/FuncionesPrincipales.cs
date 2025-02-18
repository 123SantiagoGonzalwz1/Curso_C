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
            clsClientes cliente = new clsClientes();

            cliente.idCliente = 1;
            cliente.NombreCompleto = "Santiago González";
            cliente.Rfc = "SGF010165";
            Console.WriteLine(cliente.ToString());
        }

        public static void EjemploRecordProducto()
        {
            clsProductos producto = new();
            clsProductos producto2 = new();

            producto.idProductos = 1;
            producto.Descripcion = "REF MANZANA 600 ML";
            producto.CodigoBarras = "0001";

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
            clsProductosPrecios producto = new();

            producto.idProductos = 1;
            producto.Descripcion = "REF MANZANA 600 ML";
            producto.CodigoBarras = "0001";
            producto.PrecioPublico = 17.5m;
            producto.PrecioMayoreo = 17;
            producto.PorcentajeIva = 16;
            producto.PorcentajeIeps = 8;

            decimal precioSinImpuestos;

            Console.WriteLine(producto);

            recMontosImpuestos Montos = new(0, 0); 
            precioSinImpuestos = producto.DesglosaImpuestos(Montos);

            Console.WriteLine(precioSinImpuestos.ToString("C"));
            Console.WriteLine(Montos.ToString());
        }
    }
}
