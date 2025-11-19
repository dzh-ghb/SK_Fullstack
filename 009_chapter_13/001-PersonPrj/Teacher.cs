class Teacher : Person
{
    public Teacher(string name, int age, string subject) : base(name, age)
    {
        this.Subject = subject;
    }

    public string Subject { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", subject: {Subject}";
    }
}