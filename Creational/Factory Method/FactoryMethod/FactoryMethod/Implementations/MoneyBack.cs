using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Implementations
{
    public class MoneyBack : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 1500;
        }

        public string GetCardType()
        {
            return "This is MoneyBack service";
        }

        public int GetCreditLimit()
        {
            return 50000;
        }
    }
}
