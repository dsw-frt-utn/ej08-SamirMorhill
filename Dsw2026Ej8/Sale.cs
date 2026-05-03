using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal TotalAmount { get; set; }

        protected Sale(decimal totalAmount)
        {
            TotalAmount = totalAmount;
        }
        virtual public decimal CalculateTotal()
        {
            return TotalAmount;
        }
    }
}
