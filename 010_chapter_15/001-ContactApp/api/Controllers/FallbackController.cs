using Microsoft.AspNetCore.Mvc;

// контроллер обработки запросов на адреса, которые не описаны в контроллерах BaseController и ContactManagementController
[Route("[controller]")]
public class FallbackController : Controller
{
    [HttpGet("/")]
    public IActionResult Index()
    {
        return PhysicalFile(
            // поиск index.html
            Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot",
                "index.html"
            ), "text/HTML" // возвращаемые данные - html
        );
    }
}