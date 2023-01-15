using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCollections
{
    public class Collection
    {
        User _user1;
        User _user2;
        User _user3;

        public Collection()
        {
            _user1 = new User()
            {
                UserId = 1,
                FirstName = "Johnny",
                LastName = "Appleseed"
            };

            _user2 = new User()
            {
                UserId = 2,
                FirstName = "John",
                LastName = "Doe"
            };

            _user3 = new User()
            {
                UserId = 3,
                FirstName = "Paul",
                LastName = "Bunyan"
            };
        }

        public void ArraysFunction()
        {
            Console.WriteLine("Arrays");

            User[] users = new User[3];

            users[0] = _user1;
            users[1] = _user2;
            users[2] = _user3;

            for (int i = 0; i < 3; i++)
            {
                var user = users[i];
                Console.WriteLine($"User: {user.UserId} {user.FirstName} {user.LastName}");
            }
        }

        public void DictionaryFunction()
        {
            Console.WriteLine("Dictionary");

            var users = new Dictionary<int, User>();

            users.Add(_user1.UserId, _user1);
            users.Add(_user2.UserId, _user2);
            users.Add(_user3.UserId, _user3);

            User user = null;
            bool isMatchFound = users.TryGetValue(2, out user);

            if(isMatchFound)
            {
                Console.WriteLine($"User: {user.UserId} {user.FirstName} {user.LastName}");
            }

            //foreach (var user in users)
            //    Console.WriteLine($"User: {user.Key} {user.Value.FirstName} {user.Value.LastName}");
        }

        public void ListFunction()
        {
            Console.WriteLine("List Funciton");

            List<User> users = new List<User>();

            users.Add(_user1);
            users.Add(_user2);
            users.Add(_user3);

            //foreach(var user in users)
            //{
            //    Console.WriteLine($"User: {user.UserId} {user.FirstName} {user.LastName}");
            //}

            // Find the second user in the list
            //var user = users.FirstOrDefault(u => u.UserId == 3);
            //Console.WriteLine($"User: {user.UserId} {user.FirstName} {user.LastName}");

            var matchUsers = users.Where(u => u.FirstName.ToLower() == "paul").ToList();

            foreach(var user in matchUsers)
            {
                Console.WriteLine($"User: {user.UserId} {user.FirstName} {user.LastName}");
            }


        }

    }
}
