public class ContactStorage
{
    public ContactStorage()
    {
        this.Contacts = new List<Contact>();

        // наполнение списка контактов фейковыми данными
        for (int i = 1; i <= 5; i++)
        {
            this.Contacts.Add(new Contact()
            {
                Id = i,
                Name = $"FullName {i}",
                Email = $"{Guid.NewGuid().ToString().Substring(0, 5)}_{i}@dzhits.ru"
            });
        }
    }

    public List<Contact> Contacts { get; set; }
}