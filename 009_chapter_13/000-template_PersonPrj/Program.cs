Teacher person1 = new Teacher("Ваня К.", 23, "Математика");
Student person2 = new Student("Юля К.", 10, "Школа #322");
Employee person3 = new Employee("Инна В.", 25, 40000);

Student student = new Student("Студент 1", 11, "Школа # 322");
Console.WriteLine(student.ToString());
Employee employee = new Employee("Рабочий 1", 31, 40000);
Console.WriteLine(employee.ToString());
Teacher teacher = new Teacher("Учитель 1", 33, "Математика");
Console.WriteLine(teacher.ToString());

// Repository repository = new Repository(10);
// repository.Append(person1, person2, person3);
// repository.Append(student, employee, teacher);

NewRepo newRepo = new NewRepo();
newRepo.Append(person1, person2, person3);
newRepo.Append(student, employee, teacher);

for (int i = 0; i < 1000; i++)
{
    newRepo.Append(new Employee(
        $"Сотрудник {i}",
        Random.Shared.Next(20, 70),
        Random.Shared.Next(20, 70) * 1500
        ));
}
Printer printer = new Printer();
printer.Print(newRepo);

Person person = new Teacher("", 0, "");
person = new Student("", 0, "");
person = new Employee("", 0, 0);
person = new NullPerson();