class Repository : IRepository
{
    private List<Person> storage;

    // public int Count { get { return people.Count; } } // не сладко
    // public int Count { get => people.Count; } // сладко
    public int Count => storage.Count; //очень сладко (геттер, только чтение)

    public Repository()
    {
        storage = new List<Person>();
    }

    // добавление нескольких персонажей
    public void Add(params Person[] people)
    {
        foreach (var item in people)
        {
            storage.Add(item);
        }
    }

    public Person GetById(int id)
    {
        if (id < 0 || id >= storage.Count) return new NullPerson(); // заглушка, паттерн NullObject
        return storage[id];
    }

    #region It's unnecessary here
    // метод лишний для класса БД
    // public void Print()
    // {
    //     foreach (Person person in people)
    //     {
    //         Console.WriteLine($"{person.Name}, {person.Age}");
    //     }
    // }
    #endregion

    public int GetCount()
    {
        return storage.Count;
    }
}

#region Code
// private int count;
// private int index = 0;

// public Repository(int count)
// this.count = count;

// index++;
#endregion