using Microsoft.AspNetCore.Mvc;

public class ContactManagementController : BaseController
{
    private readonly ContactStorage storage; // readonly - значение присваивается только один раз

    public ContactManagementController(ContactStorage storage)
    {
        this.storage = storage;
    }

    [HttpPost("contacts")]
    public IActionResult CreateContact([FromBody] Contact contact)
    {
        bool result = storage.Create(contact);
        return result ? Ok(contact) : Conflict("Контакт с указанным ID уже существует");
    }

    [HttpGet("contacts")] // маршрут тот же, но методы разные - разрешено
    public ActionResult<List<Contact>> GetAllContacts()
    {
        return Ok(storage.GetAll());
    }

    [HttpPut("contacts/{id}")]
    public IActionResult UpdateContact([FromBody] ContactDto contactDto, int id)
    {
        bool result = storage.Update(contactDto, id);
        // TODO: return Ok(storage.GetContact(id))
        return result ? Ok() : Conflict("Контакт с указанным ID не найден");
    }

    [HttpDelete("contacts/{id}")]
    public IActionResult DeleteContact(int id)
    {
        bool result = storage.Delete(id);
        return result ? NoContent() : BadRequest("Контакт с указанным ID не найден");
    }
}