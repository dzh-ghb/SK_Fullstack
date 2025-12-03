using Microsoft.AspNetCore.Mvc;

public class StorageController : BaseController
{
    // корректный способ
    private DataContext dataContext;

    public StorageController(DataContext dataContext)
    {
        this.dataContext = dataContext;
    }

    [HttpGet("SetString/{value}")] // endpoint
    public void SetString(string value)
    {
        // некорректный способ (через статику)
        // DataContext.Str = value;
        dataContext.Str = value;
    }

    [HttpGet("GetString")]
    public string GetString()
    {
        return dataContext.Str;
    }
}