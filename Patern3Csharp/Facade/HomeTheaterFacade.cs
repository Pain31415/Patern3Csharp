using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern3Csharp.Facade
{
    class LightSubsystem
    {
        public void TurnOn()
        {
            Console.WriteLine("Lights are on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Lights are off");
        }
    }

    class SoundSubsystem
    {
        public void TurnOn()
        {
            Console.WriteLine("Sound system is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sound system is off");
        }
    }
    class HomeTheaterFacade
    {
        private LightSubsystem lights;
        private SoundSubsystem sound;

        public HomeTheaterFacade()
        {
            lights = new LightSubsystem();
            sound = new SoundSubsystem();
        }

        public void WatchMovie()
        {
            Console.WriteLine("Get ready to watch a movie...");
            lights.TurnOn();
            sound.TurnOn();
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down the movie theater...");
            lights.TurnOff();
            sound.TurnOff();
        }
    }
}
