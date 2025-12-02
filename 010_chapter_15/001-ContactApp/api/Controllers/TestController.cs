using Microsoft.AspNetCore.Mvc;

[ApiController] // атрибут
[Route("api/[controller]")] // маршрутизация контроллера (http://localhost:5000/api/Test)
public class TestController : ControllerBase
{
    // http://localhost:5000/api/Test/test
    [HttpGet("test")] // добавление маршрута, указание на GET-метод
    public string GetTestText() // endpoint (handler) в контроллере - метод
    {
        return "TEST_TEST";
    }
}