class Student : Person
{
    public Student(string name, int age, string schoolName)
    : base(name, age)
    {
        SchoolName = schoolName;
    }

    public string SchoolName { get; set; }

    public override string ToString()
    {
        return base.ToString() + $" школа: {this.SchoolName}";
    }
}