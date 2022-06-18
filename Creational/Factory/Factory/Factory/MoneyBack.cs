using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "Money Back";
        }
        public int GetAnnualCharge()
        {
            return 500;
        }

        public int GetCreditLimit()
        {
            return 15000;
        }
    }
}
