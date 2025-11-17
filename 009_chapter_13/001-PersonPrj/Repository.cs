class Repository
{
    private List<Person> people;

    // public int Count { get { return people.Count; } } // не сладко
    // public int Count { get => people.Count; } // сладко
    public int Count => people.Count; //очень сладко (геттер, только чтение)

    public Repository()
    {
        people = new List<Person>();
    }

    public void Add(Person person)
    {
        people.Add(person);
    }

    public Person getPersonById(int id)
    {
        if (id < 0 || id >= people.Count) return new Person("empty", -1); // заглушка
        return people[id];
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

    public int Length()
    {
        return people.Count;
    }
}

#region Code
// private int count;
// private int index = 0;

// public Repository(int count)
// this.count = count;

// index++;
#endregion