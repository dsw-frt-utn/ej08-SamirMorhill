using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copyValue = originalValue;

            copyValue++;

            Product copiedProduct = product;

            copiedProduct.ActualDescription("New description");

            return $"{originalValue}-{copyValue}-{copiedProduct.Description}";



        }




    }
}
