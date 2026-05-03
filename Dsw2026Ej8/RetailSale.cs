using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class RetailSale : Sale
    {
        public RetailSale(decimal totalAmount) : base(totalAmount) { }

        public override decimal CalculateTotal()
        {
            return TotalAmount;
        }
    }
}
