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
        storage.Create(contact);
    }

    [HttpGet("contacts")] // маршрут тот же, но методы разные - разрешено
    public List<Contact> GetAllContacts()
    {
        return storage.GetAll();
    }

    [HttpPut("contacts/{id}")]
    public void UpdateContact([FromBody] ContactDto contactDto, int id)
    {
        storage.Update(contactDto, id);
    }

    [HttpDelete("contacts/{id}")]
    public void DeleteContact(int id)
    {
        storage.Delete(id);
    }
}