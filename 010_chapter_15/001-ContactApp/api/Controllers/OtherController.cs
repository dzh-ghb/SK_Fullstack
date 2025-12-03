using Microsoft.AspNetCore.Mvc;

public class OtherController : BaseController
{
    // http://localhost:5000/api/Other/dzhits/{text}
    [HttpGet("dzhits/{text}")] // маршрут с аргументом
    public string GetSomeText(string text)
    {
        return $"DZHITS_{text.ToUpper()}";
    }
}