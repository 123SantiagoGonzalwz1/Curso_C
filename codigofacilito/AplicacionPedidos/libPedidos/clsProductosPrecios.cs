using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPedidos
{
    public class clsProductosPrecios : clsProductos
    {
        public decimal PrecioPublico { get; set; }
        public decimal PrecioMayoreo { get; set; }
        public decimal PorcentajeIva { get; set; }
        public decimal PorcentajeIeps { get; set; }

        public override string ToString()
        {
            return base.ToString() +
                $"Precio público: {PrecioPublico:C}.\n" +
                $"Precio mayoreo: {PrecioMayoreo:C}.\n" +
                $"Porcentaje IVA: {PorcentajeIva}%.\n" +
                $"Porcentaje IEPS: {PorcentajeIeps}%.\n";
        }

        public decimal DesglosaImpuestos(recMontosImpuestos Montos)
        {
            recImpuestos Impuestos = new (PorcentajeIva, PorcentajeIeps);
            decimal resultado = CalculoPrecios.DesglosaImpuestos(PrecioPublico, Impuestos, Montos);

            return resultado;
        }
    }
}
