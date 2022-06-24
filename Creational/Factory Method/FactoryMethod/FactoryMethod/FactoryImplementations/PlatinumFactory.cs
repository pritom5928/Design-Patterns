﻿using FactoryMethod.Factory;
using FactoryMethod.Implementations;
using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.FactoryImplementations
{
    public class PlatinumFactory : CreditCardFactory
    {
        public override CreditCard MakeProduct()
        {
            CreditCard card = new Platinum();
            return card;
        }
    }
}
