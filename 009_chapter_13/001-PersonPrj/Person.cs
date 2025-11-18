class Person
{
    // конструктор класса - для начальной инициализации экземпляра класса
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // автосвойства - создание свойства и поля одновременно
    public string Name { get; set; }
    public int Age { get; private set; }

    override // переопределение метода
    public string ToString()
    {
        return $"{Name}, {Age}";
    }
}