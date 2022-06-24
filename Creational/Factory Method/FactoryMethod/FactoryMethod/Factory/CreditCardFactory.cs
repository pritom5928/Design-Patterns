using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public abstract class CreditCardFactory
    {
        public abstract CreditCard MakeProduct();

        public CreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
