public class InMemoryStorage : IStorage
{
    private List<Contact> Contacts { get; set; }

    public InMemoryStorage()
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

    public bool Create(ContactDto contactDto)
    {
        int id = (int)GetContactId(contactDto.Name, contactDto.PhoneNumber, contactDto.Email);
        foreach (var item in Contacts)
        {
            if (id == item.Id)
            {
                return false;
            }
        }
        Contact contact = new Contact
        {
            Id = Contacts.Count,
            Name = contactDto.Name,
            PhoneNumber = contactDto.PhoneNumber,
            Email = contactDto.Email,

        };
        Contacts.Add(contact);
        return true;
    }

    public List<Contact> GetAll()
    {
        return Contacts;
    }

    public (bool result, Contact contact) GetContact(int id)
    {
        for (int i = 0; i < Contacts.Count; i++)
        {
            if (Contacts[i].Id == id)
            {
                return (true, Contacts[i]);
            }
        }
        return (false, new NonExistingContact()); //контакт-заглушка
    }

    public bool Update(ContactDto contactDto, int id)
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
                return true;
            }
        }
        return false;
    }

    public bool Delete(int id)
    {
        for (int i = 0; i < Contacts.Count; i++)
        {
            if (Contacts[i].Id == id)
            {
                Contacts.Remove(Contacts[i]);
                return true;
            }
        }
        return false;
    }

    public long GetContactId(string name, string phoneNumber, string email)
    {
        for (int i = 0; i < Contacts.Count; i++)
        {
            if (Contacts[i].Name == name && Contacts[i].PhoneNumber == phoneNumber && Contacts[i].Email == email)
            {
                return i + 1;
            }
        }
        return -1;
    }
}