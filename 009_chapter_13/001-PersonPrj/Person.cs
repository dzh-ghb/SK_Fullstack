abstract class Person // запрет на создание экземпляров класса
{
    // конструктор класса - для начальной инициализации экземпляра класса
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    // автосвойства - создание свойства и поля одновременно
    public string Name { get; protected set; }
    public int Age { get; protected set; }

    // public virtual string ToString() // virtual в базовом классе для разрешения переопределение метода в подклассах
    public override string ToString() // ToString - метод неявного суперкласса Object для всех классов в C#, поэтому override
    {
        return $"{Name}, {Age}";
    }
}