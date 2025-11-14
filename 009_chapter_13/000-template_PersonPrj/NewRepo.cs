class NewRepo : IRepository
{
    public List<Person> col;
    public int Index => col.Count;
    public NewRepo()
    {
        col = new List<Person>();
    }
    public void Append(params Person[] people)
    {
        foreach (var item in people)
        {
            col.Add(item); ;
        }
    }

    public Person GetById(int id)
    {
        return col[id];
    }
}