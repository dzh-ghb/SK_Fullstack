var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// добавление контроллеров в сервисную коллекцию
builder.Services.AddControllers();

var app = builder.Build();
// Настраиваем доступ к Swagger
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers(); // настройка маршрутизации запросов так,
// чтобы все HTTP-запросы перенаправлялись на контроллеры для обработки

app.Run();
