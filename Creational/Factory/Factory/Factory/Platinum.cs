﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Platinum : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum";
        }
        public int GetAnnualCharge()
        {
            return 2000;
        }

        public int GetCreditLimit()
        {
            return 50000;
        }
    }
}