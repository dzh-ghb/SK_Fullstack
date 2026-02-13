var builder = WebApplication.CreateBuilder(args);

// расширение над IServiceCollection для регистрации зависимостей в отдельном классе
builder.Services.AddServiceCollection(builder.Configuration);

var app = builder.Build();

// расширение над IServiceProvider для инициализации БД перед началом работы приложения
var connectionString = builder.Configuration.GetConnectionString("SQLiteConnectionString");
app.Services.AddCustomService();

// Настраиваем доступ к Swagger
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers(); // настройка маршрутизации запросов так,
// чтобы все HTTP-запросы перенаправлялись на контроллеры для обработки
app.UseCors("CorsPolicy"); // применение политики
app.Run();
