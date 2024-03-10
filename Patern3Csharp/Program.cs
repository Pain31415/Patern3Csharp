using Patern3Csharp.Proxi;

namespace Patern3Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserProxy userProxy = new UserProxy();

            User adminUser = userProxy.GetUser("John", "Admin");
            if (adminUser != null)
            {
                Console.WriteLine("User found: " + adminUser.Name);
            }
        }
    }

}