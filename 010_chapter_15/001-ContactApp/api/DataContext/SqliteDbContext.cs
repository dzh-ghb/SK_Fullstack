using Microsoft.EntityFrameworkCore;

// класс для интеграции EF Core с СУБД SQLite (высокоуровневая абстракция для работы с данными)
public class SqliteDbContext : DbContext
{
    // объектная модель таблицы
    public DbSet<Contact> Contacts { get; set; }

    public SqliteDbContext(DbContextOptions<SqliteDbContext> options) : base(options)
    {
        // здесь мб конфигурация, описание связей и тд
    }
}