using Bogus;
using Microsoft.EntityFrameworkCore;

public class SqliteEfFakerInitializer : IInitializer
{
    // контекст для работы с БД
    private readonly SqliteDbContext context;

    public SqliteEfFakerInitializer(SqliteDbContext context)
    {
        this.context = context;
    }

    private string GenerateEmailForName(string name)
    {
        string email = Transliterate(name)
            .ToLower()
            .Replace(" ", ".") + "@example.ru";

        return email;
    }

    private string Transliterate(string name)
    {
        Dictionary<char, string> translitTable = new Dictionary<char, string>
        {
            {'а',"a"},{'б',"b"},{'в',"v"},{'г',"g"},{'д',"d"},
            {'е',"e"},{'ё',"yo"},{'ж',"zh"},{'з',"z"},{'и',"i"},
            {'й',"y"},{'к',"k"},{'л',"l"},{'м',"m"},{'н',"n"},
            {'о',"o"},{'п',"p"},{'р',"r"},{'с',"s"},{'т',"t"},
            {'у',"u"},{'ф',"f"},{'х',"kh"},{'ц',"ts"},{'ч',"ch"},
            {'ш',"sh"},{'щ',"shch"},{'ъ',""},{'ы',"y"},{'ь',""},
            {'э',"e"},{'ю',"yu"},{'я',"ya"}
        };

        var result = "";
        foreach (var ch in name.ToLower())
        {
            if (translitTable.ContainsKey(ch))
                result += translitTable[ch];
            else
                result += ch;
        }

        return result;
    }

    public void Initialize()
    {
        context.Database.Migrate(); // фактически - создание БД с применением миграций
        if (!context.Contacts.Any()) // если данных в таблице нет
        {
            var faker = new Faker<Contact>("ru")
                .RuleFor(c => c.Name, f => f.Name.FullName())
                .RuleFor(c => c.PhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(c => c.Email, (f, c) => GenerateEmailForName(c.Name));

            var contacts = faker.Generate(20);

            context.Contacts.AddRange(contacts);
            context.SaveChanges();
        }
    }
}