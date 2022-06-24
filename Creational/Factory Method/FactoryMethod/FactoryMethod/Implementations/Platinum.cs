using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Implementations
{
    public class Platinum : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 2000;
        }

        public string GetCardType()
        {
            return "This is Platinum service";
        }

        public int GetCreditLimit()
        {
            return 100000;
        }
    }
}
