class Teacher : Person
{
    public Teacher(string name, int age, string subject)
    : base(name, age)
    {
        Subject = subject;
    }

    public string Subject { get; set; }

    public override string ToString()
    {
        return base.ToString() + $" предмет: {Subject}";
    }
}