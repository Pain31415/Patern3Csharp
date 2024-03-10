using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern3Csharp.Decorator
{
    public class SportsPackage : CarDecorator
    {
        public SportsPackage(ICar car) : base(car) { }

        public override string GetDescription()
        {
            return decoratedCar.GetDescription() + ", Sports Package";
        }

        public override double GetCost()
        {
            return decoratedCar.GetCost() + 5000.0;
        }
    }
}
