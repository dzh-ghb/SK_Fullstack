using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API (список контактов)",
    });
});
/* добавление контроллеров в сервисную коллекцию,
   включает сервисы маршрутизации запросов контроллером,
   сервисы обработки HTTP-запросов и тд*/
builder.Services.AddControllers();
// внедрение зависимости (паттерн, позволяющий создать единственный экземпляр класса)
builder.Services.AddSingleton<IStorage, SQLiteStorage>(); //использование реализации по интерфейсу

// описание разрешений на доступ к ресурсу
builder.Services.AddCors(opt =>
    opt.AddPolicy("CorsPolicy", policy => // конкретное правило/политика
    {
        policy.AllowAnyMethod() // доступ любого метода
        .AllowAnyHeader() // доступ любых заголовков
        .WithOrigins(args[0]); // работа только с конкретным клиентом (url приложения),
        // указание через внешний аргумент
    }));

var app = builder.Build();
// Настраиваем доступ к Swagger
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers(); // настройка маршрутизации запросов так,
// чтобы все HTTP-запросы перенаправлялись на контроллеры для обработки
app.UseCors("CorsPolicy"); // применение политики
app.Run();
