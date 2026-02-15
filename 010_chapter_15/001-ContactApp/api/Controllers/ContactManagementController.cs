using Microsoft.AspNetCore.Mvc;

public class ContactManagementController : BaseController
{
    private readonly IPaginationStorage storage; // readonly - значение присваивается только один раз

    public ContactManagementController(IPaginationStorage storage)
    {
        this.storage = storage;
    }

    [HttpPost("contacts")]
    public IActionResult CreateContact([FromBody] ContactDto contactDto)
    {
        Contact result = storage.Create(contactDto);
        return result != null ? Created($"contacts/{result.Id}", result) : Conflict("Контакт с указанным ID уже существует");
    }

    [HttpGet("contacts")] // маршрут тот же, но методы разные - разрешено
    public ActionResult<List<Contact>> GetAllContacts()
    {
        return Ok(storage.GetAll());
    }

    // реализация по курсу
    [HttpGet("contacts/{id}")]
    public IActionResult GetContactById(int id)
    {
        var contact = storage.GetContactById(id);
        if (id < 0)
        {
            return BadRequest("Некорректный ID");
        }
        else if (contact == null)
        {
            return NotFound("Контакт с указанным ID не найден");
        }
        return Ok(contact);
    }

    // моя реализация
    // [HttpGet("contacts/{id}")]
    // public ActionResult<Contact> GetContactById(int id)
    // {
    //     var (result, contact) = storage.GetContact(id);
    //     if (result)
    //     {
    //         return Ok(contact);
    //     }
    //     else if (id >= 0)
    //     {
    //         return NotFound("Контакт с указанным ID не найден");
    //     }
    //     return BadRequest("Некорректный ID");
    // }

    [HttpPut("contacts/{id}")]
    public IActionResult UpdateContact([FromBody] ContactDto contactDto, int id)
    {
        bool result = storage.Update(contactDto, id);
        Contact contact = storage.GetContact(id).contact;
        return result ? Ok(contact) : Conflict("Контакт с указанным ID не найден");
    }

    [HttpDelete("contacts/{id}")]
    public IActionResult DeleteContact(int id)
    {
        bool result = storage.Delete(id);
        return result ? NoContent() : BadRequest("Контакт с указанным ID не найден");
    }
}