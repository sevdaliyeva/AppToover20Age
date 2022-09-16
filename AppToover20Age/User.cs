using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppToover20Age
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }

        public User(string name,string surname,string country,int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Country = country;
            this.Age = age;

        }
        public void Fullname()
        {
            Console.WriteLine(Name + " " + Surname + " " + Country + " " + Age);
        }

    }
}
