public class ContactStorage
{
    public ContactStorage()
    {
        this.Contacts = new List<Contact>();
    }

    public List<Contact> Contacts { get; set; }
}