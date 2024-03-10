using Patern3Csharp.Decorator;
using Patern3Csharp.Facade;

namespace Patern3Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar myCar = new BasicCar();

            myCar = new SportsPackage(myCar);
            myCar = new LuxuryPackage(myCar);

            Console.WriteLine("Description: " + myCar.GetDescription());
            Console.WriteLine("Cost: $" + myCar.GetCost());
        }
    }
}