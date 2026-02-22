
public class SqlitePaginationEfStorage : SqliteEfStorage, IPaginationStorage
{
    public SqlitePaginationEfStorage(SqliteDbContext context) : base(context)
    {
    }

    public Contact GetContactById(int id)
    {
        return base.context.Contacts.Find(id);
    }

    public (List<Contact>, int totalCount) GetContactsPart(int pageNumber, int pageSize)
    {
        int totalCount = base.context.Contacts.Count();

        List<Contact> partOfContacts = base.context.Contacts
        .Skip((pageNumber - 1) * pageSize) // пропуск определенного количества элементов (-1 для удобной нумерации страниц)
        .Take(pageSize) // выбор определенного количества элементов
        .ToList();

        return (partOfContacts, totalCount);
    }
}