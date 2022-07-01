using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Var6.Data
{
    public class User
    {
        public User(string name, string surname, DateTime dateOfAdding)
        {
            Name = name;
            Surname = surname;
            DateOfAdding = dateOfAdding;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfAdding { get; set; }
        public static List<User> users = new List<User>();
        public static List<string> titles = new List<string>() { "Name", "Surname", "DateOfAdding", " " };

    }
}
