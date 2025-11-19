class Student : Person
{
    public Student(string name, int age, string schoolName) : base(name, age) // проброс параметров в конструктор родителя
    {
        // base.Age += 10; // обращение к свойству суперкласса
        this.SchoolName = schoolName; // инициализация нового свойства
    }

    public string SchoolName { get; set; } // доп. свойство

    public override string ToString()
    {
        return base.ToString() + $", school: {SchoolName}"; // обращение к методу базового класса и дополнение логики
    }
}