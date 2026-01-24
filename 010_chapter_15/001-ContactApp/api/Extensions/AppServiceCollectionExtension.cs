using Microsoft.OpenApi.Models;

public static class AppServiceCollectionExtension
{
    public static IServiceCollection AddServiceCollection(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(opt =>
        {
            opt.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "API (список контактов)",
            });
        });
        /* добавление контроллеров в сервисную коллекцию,
           включает сервисы маршрутизации запросов контроллером,
           сервисы обработки HTTP-запросов и тд*/
        services.AddControllers();
        var stringConnection = configuration.GetConnectionString("SQLiteStringConnection");
        // внедрение зависимости (паттерн, позволяющий создать единственный экземпляр класса)
        services.AddSingleton<IStorage>(new SQLiteStorage(stringConnection)); // передача экземпляра

        // описание разрешений на доступ к ресурсу
        services.AddCors(opt =>
            opt.AddPolicy("CorsPolicy", policy => // конкретное правило/политика
            {
                policy.AllowAnyMethod() // доступ любого метода
                .AllowAnyHeader() // доступ любых заголовков
                .WithOrigins(configuration["client"]); // работа только с конкретным клиентом (url приложения),
                                                       // указание через внешний аргумент
            }));

        return services;
    }
}