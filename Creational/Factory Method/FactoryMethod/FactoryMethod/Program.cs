using FactoryMethod.FactoryImplementations;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var creditCard = new PlatinumFactory().CreateProduct();

            if (creditCard != null)
            {
                Console.WriteLine(creditCard.GetCardType());
                Console.WriteLine(creditCard.GetAnnualCharge());
                Console.WriteLine(creditCard.GetCreditLimit());
            }
            else
            {
                Console.WriteLine("Invalid card");
            }

            Console.ReadKey();
        }
    }
}
