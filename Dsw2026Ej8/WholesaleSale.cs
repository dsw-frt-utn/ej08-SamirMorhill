using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal totalAmount) : base(totalAmount) { }

        public override decimal CalculateTotal()
        {
            return TotalAmount * 0.9m; 
        }

    }
}
