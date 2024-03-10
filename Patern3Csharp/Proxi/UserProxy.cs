using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern3Csharp.Proxi
{
    public class User
    {
        public required string Name { get; set; }
        public required string Role { get; set; }
    }

    public class UserFacade
    {
        private User[] users;

        public UserFacade()
        {
            users = new User[] {
            new User { Name = "John", Role = "Admin" },
            new User { Name = "Alice", Role = "User" },
            new User { Name = "Bob", Role = "User" }
        };
        }

        public User? GetUser(string name)
        {
            foreach (var user in users)
            {
                if (user.Name == name)
                {
                    return user;
                }
            }
            return null;
        }
    }

    public class UserProxy : UserFacade
    {
        private UserFacade userFacade;

        public UserProxy()
        {
            userFacade = new UserFacade();
        }

        public User? GetUser(string name, string requestingUserRole)
        {
            User user = userFacade.GetUser(name);

            if (user != null && user.Role == "Admin")
            {
                return user;
            }
            else if (user != null && user.Role == "User" && requestingUserRole == "Admin")
            {
                return user;
            }
            else
            {
                Console.WriteLine("Access denied. Insufficient permissions.");
                return null;
            }
        }
    }
}
