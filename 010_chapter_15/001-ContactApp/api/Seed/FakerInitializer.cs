using Bogus;
using Microsoft.Data.Sqlite;

public class FakerInitializer : IInitializer
{
    private string connectionString;

    public FakerInitializer(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void Initialize()
    {
        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @"
            CREATE TABLE IF NOT EXISTS contacts (
                id    INTEGER PRIMARY KEY AUTOINCREMENT,
                name  TEXT    NOT NULL
                      DEFAULT ('Joe Peach'),
                phone TEXT    NOT NULL
                      DEFAULT ('Номер не указан'),
                email TEXT    NOT NULL
                      DEFAULT ('Email не указан'));";
        command.ExecuteNonQuery(); // отработает, если таблицы нет

        command.CommandText = @"SELECT count(*) FROM contacts;";
        long count = (long)command.ExecuteScalar();

        if (count == 0) // отработает, если записей в таблице нет
        {
            var faker = new Faker<Contact>("ru")
            .RuleFor(c => c.Name, f => f.Name.FullName())
            .RuleFor(c => c.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(c => c.Email, f => f.Internet.Email());

            var contacts = faker.Generate(10);

            foreach (var contact in contacts)
            {
                command.CommandText = @"
                    INSERT INTO contacts (name, phone, email)
                    VALUES (@name, @phone, @email);";
                command.Parameters.Clear(); // очистка коллекции параметров на каждой итерации цикла
                command.Parameters.AddWithValue("@name", contact.Name);
                command.Parameters.AddWithValue("@phone", contact.PhoneNumber);
                command.Parameters.AddWithValue("@email", contact.Email);
                command.ExecuteNonQuery();
            }
        }
    }
}