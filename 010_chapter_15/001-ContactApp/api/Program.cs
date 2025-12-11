var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
/* добавление контроллеров в сервисную коллекцию,
   включает сервисы маршрутизации запросов контроллером,
   сервисы обработки HTTP-запросов и тд*/
builder.Services.AddControllers();
// внедрение зависимости (паттерн, позволяющий создать единственный экземпляр класса)
builder.Services.AddSingleton<ContactStorage>();

var app = builder.Build();
// Настраиваем доступ к Swagger
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers(); // настройка маршрутизации запросов так,
// чтобы все HTTP-запросы перенаправлялись на контроллеры для обработки

app.Run();
