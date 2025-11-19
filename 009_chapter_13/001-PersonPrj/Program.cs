Person person1 = new Person("DZHITS", 28);
Person person2 = new Person("BEN", 15);

Repository repository = new();
repository.Add(person1, person2);
for (int i = 0; i < 5; i++)
{
    repository.Add(new Person($"Person {i}", i));
}

Printer printer = new();
printer.Print(repository);
Console.WriteLine($"\nLength: {repository.Length()}");

Person somePerson = repository.getPersonById(0);
Console.WriteLine($"\n{somePerson.Name}, {somePerson.Age}");

Student student = new Student("Student 1", 10, "School #19");
Console.WriteLine("\n" + student.ToString());

Employee employee = new("Employee 1", 28, 9_000);
Console.WriteLine("\n" + employee.ToString());

Teacher teacher = new("Teacher 1", 22, "benzologia");
Console.WriteLine("\n" + teacher.ToString());