interface IRepository
{
    int Count { get; }
    void Add(params Person[] people);
    Person GetById(int id);
}