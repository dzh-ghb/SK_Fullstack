abstract class Person
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; protected set; }
    public int Age { get; protected set; }

    public override string ToString()
    {
        return $"Имя: {this.Name} возраст: {this.Age}";
    }
}