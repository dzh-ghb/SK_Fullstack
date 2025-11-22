// обобщенный интерфейс (не привязан к конкретному типу)
interface IRepository<T>
{
    int Count { get; }
    void Add(params T[] data);
    T GetById(int id);
}