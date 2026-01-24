var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы Swagger
builder.Services.AddServiceCollection(builder.Configuration);

var app = builder.Build();
// Настраиваем доступ к Swagger
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers(); // настройка маршрутизации запросов так,
// чтобы все HTTP-запросы перенаправлялись на контроллеры для обработки
app.UseCors("CorsPolicy"); // применение политики
app.Run();
