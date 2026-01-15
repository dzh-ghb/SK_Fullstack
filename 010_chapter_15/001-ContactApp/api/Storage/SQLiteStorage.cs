public class SQLiteStorage : IStorage
{
    public bool Create(Contact contact)
    {
        throw new NotImplementedException();
    }

    public List<Contact> GetAll()
    {
        throw new NotImplementedException();
    }

    public (bool result, Contact contact) GetContact(int id)
    {
        throw new NotImplementedException();
    }

    public bool Update(ContactDto contactDto, int id)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }
}