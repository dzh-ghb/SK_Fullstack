public class ContactStorage
{
    private List<Contact> Contacts { get; set; }

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
                PhoneNumber = $"899912{i}",
                Email = $"{Guid.NewGuid().ToString().Substring(0, 5)}_{i}@dzhits.ru"
            });
        }
    }

    public void Create(Contact contact)
    {
        Contacts.Add(contact);
    }

    public List<Contact> GetAll()
    {
        return Contacts;
    }

    public void Update(ContactDto contactDto, int id)
    {
        Contact contact;
        for (int i = 0; i < Contacts.Count; i++)
        {
            if (Contacts[i].Id == id)
            {
                contact = Contacts[i];
                // проверка, если пустое значение - данные не заменяются
                if (!String.IsNullOrEmpty(contactDto.Name))
                {
                    contact.Name = contactDto.Name;
                }
                if (!String.IsNullOrEmpty(contactDto.PhoneNumber))
                {
                    contact.PhoneNumber = contactDto.PhoneNumber;
                }
                if (!String.IsNullOrEmpty(contactDto.Email))
                {
                    contact.Email = contactDto.Email;
                }
                return;
            }
        }
    }

    public void Delete(int id)
    {
        for (int i = 0; i < Contacts.Count; i++)
        {
            if (Contacts[i].Id == id)
            {
                Contacts.Remove(Contacts[i]);
                return;
            }
        }
    }
}