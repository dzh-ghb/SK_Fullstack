public interface IStorage
{
    bool Create(Contact contact);

    List<Contact> GetAll();

    (bool result, Contact contact) GetContact(int id);

    bool Update(ContactDto contactDto, int id);

    bool Delete(int id);
}