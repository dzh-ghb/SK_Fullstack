Student person1 = new Student("DZHITS", 14, "NDBT");
Teacher person2 = new Teacher("BUDKA", 24, "IT");
Employee person3 = new Employee("DEN", 28, 5000);

Student student = new Student("Student 1", 10, "School #19");
Teacher teacher = new("Teacher 1", 22, "benzologia");
Employee employee = new("Employee 1", 28, 9_000);

Repository repository = new();
repository.Add(person1, person2, person3);
repository.Add(student, employee, teacher);

Printer printer = new();
printer.Print(repository);
Console.WriteLine($"\nLength: {repository.Length()}");

Person somePerson = repository.getPersonById(0);
Console.WriteLine($"\n{somePerson.Name}, {somePerson.Age}");

Person per = new Student("", 0, ""); // полиморфная переменная (принцип полиморфизма)
per = new Teacher("", 0, "");
per = new Employee("", 0, 0);
per = new NullPerson();