using Patern3Csharp.Facade;

namespace Patern3Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeTheaterFacade homeTheater = new HomeTheaterFacade();

            homeTheater.WatchMovie();

            homeTheater.EndMovie();
        }
    }

}