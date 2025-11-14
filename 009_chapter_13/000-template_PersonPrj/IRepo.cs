interface IRepo<T>
{
    int Index { get; }
    void Append(params T[] people);
    public T GetById(int id);
}
