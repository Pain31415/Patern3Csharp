using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern3Csharp.Decorator
{
    public abstract class CarDecorator : ICar
    {
        protected ICar decoratedCar;

        public CarDecorator(ICar car)
        {
            decoratedCar = car;
        }

        public virtual string GetDescription()
        {
            return decoratedCar.GetDescription();
        }

        public virtual double GetCost()
        {
            return decoratedCar.GetCost();
        }
    }
}
