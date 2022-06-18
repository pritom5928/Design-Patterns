using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium";
        }
        public int GetAnnualCharge()
        {
            return 1000;
        }

        public int GetCreditLimit()
        {
            return 25000;
        }
    }
}
