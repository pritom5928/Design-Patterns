using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Interfaces
{
    public interface CreditCard
    {
        public string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
