Person person1 = new Person("DZHITS", 28);
Person person2 = new Person("BEN", 15);

Repository repository = new();
repository.Add(person1, person2);
for (int i = 0; i < 10; i++)
{
    repository.Add(new Person($"Person {i}", i));
}

Printer printer = new();
printer.Print(repository);
Console.WriteLine($"\nLength: {repository.Length()}");

Person somePerson = repository.getPersonById(0);
Console.WriteLine($"\n{somePerson.Name}, {somePerson.Age}");

#region Code
// person1.Name = "Ben";
// person1.Age = 29;
// person1.SetName("DZHITS");
// person1.SetAge(28);
// Console.WriteLine($"{person1.Name}, {person1.Age}");
// Console.WriteLine($"{person2.Name}, {person2.Age}");
#endregion