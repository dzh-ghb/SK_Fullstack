using Microsoft.AspNetCore.Mvc;

public class TestController : BaseController
{
    // http://localhost:5000/api/Test/test
    [HttpGet("test")] // добавление маршрута, указание на GET-метод
    public string GetTestText() // endpoint (handler) в контроллере - метод
    {
        return "TEST_TEST";
    }

    [HttpGet("testRequest")]
    public ActionResult<string> GetTestRequest()
    {
        return BadRequest("BAD");
    }
}