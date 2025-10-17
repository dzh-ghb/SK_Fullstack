using MyApp.Models;

namespace MyApp.Interfaces
{
    public interface IPersonService
    {
        Person CreatePerson(string name, int age);
    }
}