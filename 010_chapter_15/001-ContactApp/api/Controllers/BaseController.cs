using Microsoft.AspNetCore.Mvc;

[ApiController] // атрибут
// маршрутизация контроллера (http://localhost:5000/api/[название контроллера без приставки])
[Route("api/[controller]")]
public /*abstract*/ class BaseController : ControllerBase
{
}