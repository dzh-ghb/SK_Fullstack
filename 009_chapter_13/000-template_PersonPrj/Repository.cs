class Repository : IRepository
{
    private Person[] storage;
    private int count;
    private int index = 0;
    public Repository(int count)
    {
        this.count = count;
        this.storage = new Person[this.count];
    }

    // public int Index { get { return index; } }
    // public int Index { get => index; }
    public int Index => index;

    public void Append(params Person[] people)
    {
        foreach (var person in people)
        {
            if (index >= count) return;
            storage[index] = person;
            index++;
        }
    }

    public Person GetById(int id)
    {
        if (id < 0 || id >= index)
        {
            return new NullPerson();
        }
        return storage[id];
    }
}