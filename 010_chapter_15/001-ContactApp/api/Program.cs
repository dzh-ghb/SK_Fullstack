var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Настраиваем доступ к Swagger
app.UseSwagger();
app.UseSwaggerUI();

// Настройка маршрутизации | роутинга | эндпоинтов
app.MapGet("/test", () => "TEST_TEST");

app.MapGet("/dzhits/{text}", (string text) => $"DZHITS_{text}");

app.Run();
