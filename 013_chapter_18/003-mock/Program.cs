using Bogus;

var faker = new Faker<Contact>("ru")
    .RuleFor(c => c.FullName, f => f.Name.FullName()) // сопоставление нашей модели и фейк-данных
    .RuleFor(c => c.Email, f => f.Internet.Email());

var data = faker.Generate(10); // создание коллекции данных

foreach (var item in data)
{
    Console.WriteLine(item);
}

// нужная модель данных
class Contact
{
    public string FullName { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"{this.FullName}, {this.Email}";
    }
}