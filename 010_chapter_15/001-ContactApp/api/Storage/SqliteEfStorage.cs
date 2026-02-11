
using Microsoft.EntityFrameworkCore;

public class SqliteEfStorage : IStorage
{
    // контекст для взаимодействия с БД ("контекст == БД")
    private readonly SqliteDbContext context;

    public SqliteEfStorage(SqliteDbContext context)
    {
        this.context = context;
    }

    public Contact Create(ContactDto contactDto)
    {
        Contact contact = new Contact
        {
            Name = contactDto.Name,
            PhoneNumber = contactDto.PhoneNumber,
            Email = contactDto.Email
        };

        context.Contacts.Add(contact);
        context.SaveChanges();
        return contact;
    }

    public List<Contact> GetAll()
    {
        return context.Contacts.ToList(); // БД.таблица.преобразовать_в_список()
    }

    public (bool result, Contact contact) GetContact(int id)
    {
        var contact = context.Contacts.Find(id);
        if (contact == null)
        {
            return (false, new NonExistingContact());
        }
        return (true, contact);
    }

    public bool Update(ContactDto contactDto, int id)
    {
        var contact = context.Contacts.Find(id);
        if (contact == null)
        {
            return false;
        }
        contact.Name = contactDto.Name;
        contact.PhoneNumber = contactDto.PhoneNumber;
        contact.Email = contactDto.Email;
        context.SaveChanges();
        return true;
    }

    public bool Delete(int id)
    {
        var contact = context.Contacts.Find(id);
        if (contact == null)
        {
            return false;
        }
        context.Contacts.Remove(contact);
        context.SaveChanges();
        return true;
    }
}