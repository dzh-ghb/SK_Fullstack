// класс для подстройки всего, что связано с клиентом
public class ConfigMiddleware
{
    private readonly RequestDelegate next;

    public ConfigMiddleware(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // если запрос на /config.js
        if (context.Request.Path == "/config.js")
        {
            // подготовка ответа
            var scheme = context.Request.Scheme;
            var host = context.Request.Host.Value;
            var pathBase = context.Request.PathBase.Value;

            // формирование url API
            var apiUrl = $"{scheme}://{host}{pathBase}/api/ContactManagement";

            // указание url значением в поле конфига
            var config = $@"window.config = {{
                apiUrl: '{apiUrl}'
            }}";

            // указание на JS-файл
            context.Response.ContentType = "application/javascript";
            // возвращение ответа
            await context.Response.WriteAsync(config);
        }
        else
        {
            await this.next(context); // проброс без логики
        }
    }
}