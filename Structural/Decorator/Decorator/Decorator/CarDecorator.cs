using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CarDecorator : ICar
    {
        protected ICar _car;
        public CarDecorator(ICar car)
        {
            _car = car;
        }

        public virtual ICar ManufactureCar()
        {
            return _car.ManufactureCar();
        }
    }
}
