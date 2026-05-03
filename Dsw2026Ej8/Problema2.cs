using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal totalCalculado = quantity <= 0 ? 0 : quantity * unitPrice;

            var resumenVenta = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = totalCalculado,
            };

            return $"{resumenVenta.Code}-{resumenVenta.Description}-{resumenVenta.Total}";
        }

    }
}
