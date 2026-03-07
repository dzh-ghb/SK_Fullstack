// объект с инфраструктурой приложения
var builder = WebApplication.CreateBuilder(args);

// расширение над IServiceCollection для регистрации зависимостей в отдельном классе
builder.Services.AddServiceCollection(builder.Configuration);

// сборка приложения и подготовка pipeline
var app = builder.Build();
// далее настраивается middleware

// расширение над IServiceProvider для инициализации БД перед началом работы приложения
var connectionString = builder.Configuration.GetConnectionString("SQLiteConnectionString");
app.Services.AddCustomService();

// доступ к Swagger
app.UseSwagger();
app.UseSwaggerUI();

// СПРАВКА: порядок указания компонентов (middleware) конвейера важен!
// подключение кастомного middleware в pipeline (с логикой формирования url)
app.UseConfigMiddleware();
// middleware для обслуживания файлов по умолчанию (index.html и тд)
app.UseDefaultFiles();
// middleware для обслуживания CSS, JS, изображения и тд для возможности возвращаться
// статические файлы клиенту (статические, т.к. клиент собран и файлы там неизменны)
app.UseStaticFiles();
// middleware настройки маршрутизации приложения,
// маршрут по умолчанию для всех не найденных путей (маршруты вне BaseController и ContactManagementController)
app.MapFallbackToController("Index", "Fallback");

app.MapControllers(); // настройка маршрутизации запросов так,
// чтобы все HTTP-запросы перенаправлялись на контроллеры для обработки
app.UseCors("CorsPolicy"); // применение политики
app.Run();
