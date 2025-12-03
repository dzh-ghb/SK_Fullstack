using Microsoft.AspNetCore.Mvc;

public class ContactManagementController : BaseController
{
    private readonly ContactStorage storage; // readonly - значение присваивается только один раз

    public ContactManagementController(ContactStorage storage)
    {
        this.storage = storage;
    }

    [HttpPost("contacts")]
    public void CreateContact([FromBody] Contact contact)
    {
        storage.Contacts.Add(contact);
    }

    [HttpGet("contacts")] // маршрут тот же, но методы разные - разрешено
    public List<Contact> GetAllContacts()
    {
        return storage.Contacts;
    }

    [HttpDelete("contacts/{id}")]
    public void DeleteContact(int id)
    {
        Contact contact;
        for (int i = 0; i < storage.Contacts.Count; i++)
        {
            if (storage.Contacts[i].Id == id)
            {
                contact = storage.Contacts[i];
                storage.Contacts.Remove(contact);
                return;
            }
        }
    }
}