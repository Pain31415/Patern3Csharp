using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern3Csharp.Decorator
{
    public class BasicCar : ICar
    {
        public string GetDescription()
        {
            return "Basic Car";
        }

        public double GetCost()
        {
            return 15000.0;
        }
    }
}
