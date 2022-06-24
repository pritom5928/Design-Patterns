using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Implementations
{
    public class Titanium : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 3000;
        }

        public string GetCardType()
        {
            return "This is Titanium service";
        }

        public int GetCreditLimit()
        {
            return 250000;
        }
    }
}
