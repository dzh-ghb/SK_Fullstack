using MyApp.Models;
using MyApp.Interfaces;

namespace MyApp.Services
{
    public class PersonService : IPersonService
    {
        public Person CreatePerson(string name, int age)
        {
            return new Person(name, age);
        }
    }
}