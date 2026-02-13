using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

public static class AppServiceCollectionExtension
{
    public static IServiceCollection AddServiceCollection(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Добавляем сервисы Swagger
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

        var connectionString = configuration.GetConnectionString("SQLiteConnectionString");
        // внедрение зависимости (паттерн, позволяющий создать единственный экземпляр класса)
        services.AddDbContext<SqliteDbContext>(opt => opt.UseSqlite(connectionString)); // регистрация зависимости

        // services.AddSingleton<IStorage>(new SQLiteStorage(connectionString)); // передача экземпляра
        services.AddScoped<IStorage, SqliteEfStorage>();
        services.AddScoped<IInitializer, SqliteEfFakerInitializer>();

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