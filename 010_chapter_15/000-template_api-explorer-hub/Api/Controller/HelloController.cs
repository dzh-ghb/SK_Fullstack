using Microsoft.AspNetCore.Mvc;

public class HelloController : BaseController
{
    [HttpGet("hello/{name}")]
    public string GetGreetingByName(string name)
    {
        return $"Привет, {name}!";
    }
}