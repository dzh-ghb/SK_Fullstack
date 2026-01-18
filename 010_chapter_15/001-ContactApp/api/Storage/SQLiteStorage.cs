using Microsoft.Data.Sqlite;

public class SQLiteStorage : IStorage
{
    // строка подключения к БД
    private readonly string connectionString;

    public SQLiteStorage(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public bool Create(Contact contact)
    {
        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        var command = connection.CreateCommand();
        string query = "insert into contacts (name, phone, email) values (@name, @phone, @email);";
        command.CommandText = query;
        command.Parameters.AddWithValue("@name", contact.Name);
        command.Parameters.AddWithValue("@phone", contact.PhoneNumber);
        command.Parameters.AddWithValue("@email", contact.Email);

        // Console.WriteLine("sql >> " + query);
        return command.ExecuteNonQuery() > 0;
    }

    public List<Contact> GetAll()
    {
        var contacts = new List<Contact>();

        // создание и открытие подключения к БД
        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        // объект для выполнения запроса
        var command = connection.CreateCommand();
        string query = "select * from contacts;";
        command.CommandText = query;

        // извлечение данных
        using var reader = command.ExecuteReader();
        while (reader.Read()) // перебор объекта
        {
            contacts.Add(new Contact() // формирование объекта
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                PhoneNumber = reader.GetString(2),
                Email = reader.GetString(3)
            });
        }
        // reader.Close(); //при использовании using не нужно
        // connection.Close(); //при использовании using не нужно
        // Console.WriteLine("sql >> " + query);
        return contacts;
    }

    public (bool result, Contact contact) GetContact(int id)
    {
        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        var command = connection.CreateCommand();
        string query = "select * from contacts where id = @id;";
        command.CommandText = query;
        command.Parameters.AddWithValue("@id", id);

        // Console.WriteLine("sql >> " + query);
        using var reader = command.ExecuteReader();
        if (reader.Read())
        {
            Contact contact = new Contact()
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                PhoneNumber = reader.GetString(2),
                Email = reader.GetString(3)
            };
            return (true, contact);
        }
        return (false, new NonExistingContact()); //контакт-заглушка
    }

    public bool Update(ContactDto contactDto, int id)
    {
        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        var command = connection.CreateCommand();
        string query = "update contacts set name = @name, phone = @phone, email = @email where id = @id;";
        command.CommandText = query;
        command.Parameters.AddWithValue("@name", contactDto.Name);
        command.Parameters.AddWithValue("@phone", contactDto.PhoneNumber);
        command.Parameters.AddWithValue("@email", contactDto.Email);
        command.Parameters.AddWithValue("@id", id);

        // Console.WriteLine("sql >> " + query);
        return command.ExecuteNonQuery() > 0;
    }

    public bool Delete(int id)
    {
        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        var command = connection.CreateCommand();
        string query = "delete from contacts where id = @id";
        command.CommandText = query;
        command.Parameters.AddWithValue("@id", id);

        // Console.WriteLine("sql >> " + query);
        return command.ExecuteNonQuery() > 0;
    }
}