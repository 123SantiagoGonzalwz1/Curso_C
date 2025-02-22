﻿using System;
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
                $"Precio público: {PrecioPublico.ToString("C")}.\n" +
                $"Precio mayoreo: {PrecioMayoreo.ToString("C")}.\n" +
                $"Porcentaje IVA: {PorcentajeIva.ToString()}%.\n" +
                $"Porcentaje IEPS: {PorcentajeIeps.ToString()}%.\n";
        }

        public decimal DesglosaImpuestos(recMontosImpuestos Montos)
        {
            decimal resultado = 0;
            recImpuestos Impuestos = new (PorcentajeIva, PorcentajeIeps);
            resultado = CalculoPrecios.DesglosaImpuestos(PrecioPublico, Impuestos, Montos);

            return resultado;
        }
    }
}
