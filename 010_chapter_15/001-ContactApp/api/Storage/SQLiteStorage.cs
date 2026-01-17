using System.Text;
using Microsoft.Data.Sqlite;

public class SQLiteStorage : IStorage
{
    // строка подключения к БД
    string connectionString = "Data Source = contacts.db";

    public bool Create(Contact contact)
    {
        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        var command = connection.CreateCommand();
        // string query = new StringBuilder() // высокая вероятность ошибки в запросе, например, забыть ''
        // .Append("insert into contacts (name, phone, email) values")
        // .Append($"('{contact.Name}', '{contact.PhoneNumber}', '{contact.Email}');")
        // .ToString();
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
        command.CommandText = "select * from contacts";

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
        return contacts;
    }

    public (bool result, Contact contact) GetContact(int id)
    {
        throw new NotImplementedException();
    }

    public bool Update(ContactDto contactDto, int id)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        var command = connection.CreateCommand();
        string query = "delete from contacts where id = @id";
        command.CommandText = query;
        command.Parameters.AddWithValue("@id", id);

        return command.ExecuteNonQuery() > 0;
    }
}