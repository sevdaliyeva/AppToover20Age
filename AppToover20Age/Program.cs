// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
static void Main(string[] args)
{
    User users = new User();
    users.GenerateUser("Nigar", "Sadiqova", 21, "Azerbaijan");
    users.GenerateUser("Leyla", "Muradova", 19, "Italy");
    users.GenerateUser("Gunel", "Mammadova", 25, "Norwey");
    users.GenerateUser("Fuad", "Sadiqova", 20, "China");
    users.GenerateUser("Aydin", "Sadiqova", 22, "Azerbaijan");
    users.GenerateUser("Adil", "Sadiqova", 23, "Finland");
    users.GenerateUser("Elxan", "Sadiqova", 41, "Denmark");
    users.GenerateUser("Gulnar", "Sadiqova", 31, "Japan");
    users.GenerateUser("Turan", "Sadiqova", 27, "Azerbaijan");
    users.GenerateUser("Ehmed", "Sadiqova", 9, "Turkey");
    List<User> users = new List<User>();
    User FindByAge(int age)
    {
        return users.Find(x => x.Age >20).FirstorDefault();
    }
    Console.WriteLine(FullName());
    User FindByAge(int age)
    {
        return users.Find(x => x.Age < 10).FirstorDefault();
 
    }
    User FindByCountry(string country)
    {
        return users.Find(x => x.Country==Turkey).Remove();
    }
}


