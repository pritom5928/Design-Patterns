using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar bmwCar1 = new BMWCar();
            bmwCar1.ManufactureCar();
            Console.WriteLine(bmwCar1 + "\n\n");

            DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
            carWithDieselEngine.ManufactureCar();

            Console.WriteLine();

            ICar bmwCar2 = new BMWCar();
            PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
            carWithPetrolEngine.ManufactureCar();
            Console.ReadKey();

        }
    }
}
