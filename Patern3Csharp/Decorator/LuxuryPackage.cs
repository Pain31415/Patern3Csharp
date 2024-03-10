using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern3Csharp.Decorator
{
    public class LuxuryPackage : CarDecorator
    {
        public LuxuryPackage(ICar car) : base(car) { }

        public override string GetDescription()
        {
            return decoratedCar.GetDescription() + ", Luxury Package";
        }

        public override double GetCost()
        {
            return decoratedCar.GetCost() + 10000.0;
        }
    }
}
