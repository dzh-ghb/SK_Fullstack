public static class AppServiceProviderExtension
{
    public static IServiceProvider AddCustomService(
        this IServiceProvider services,
        IConfiguration configuration
    )
    {
        using var scope = services.CreateScope(); // коллекция зарегистрированных сервисов

        var storage = scope.ServiceProvider.GetService<IStorage>(); // получение зависимости типа IStorage
        var dbStorage = storage as SQLiteStorage; // каст к конкретному типу хранилища
        if (dbStorage != null) // если зависимость БЫЛА зарегистрирована
        {
            var connectionString = configuration.GetConnectionString("SQLiteConnectionString");
            new FakerInitializer(connectionString).Initialize(); // инициализация БД
        }
        return services;
    }
}