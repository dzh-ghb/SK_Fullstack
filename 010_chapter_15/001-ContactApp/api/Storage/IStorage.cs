public interface IStorage
{
    bool Create(ContactDto contact);

    List<Contact> GetAll();

    (bool result, Contact contact) GetContact(int id);

    bool Update(ContactDto contactDto, int id);

    bool Delete(int id);

    long GetContactId(string name, string phoneNumber, string email);
}