### Первая ревизия без классов:

```csharp
const int count = 10;
int index = 0;
string[] name = new string[count];
int[] age = new int[count];

void CreatePerson(string personName, int personAge)
{
    if (index >= count) return;
    name[index] = personName;
    age[index] = personAge;
    index++;
}

(string personAge, int personName) GetPersonById(int id)
{
    if (id < 0 || id >= index) return ("empty", -1);
    string personName = name[id];
    int personAge = age[id];
    return (personName, personAge);
}

void PrintPersonById(int id)
{
    if (id < 0 || id >= index) return;

    Console.WriteLine($"Имя: {name[id]} возраст: {age[id]}");
}

void PrintPerson((string, int) person)
{
    Console.WriteLine($"Имя: {person.Item1} возраст: {person.Item2}");
}

for (int i = 0; i < count; i++)
{
    CreatePerson($"Имя {i}", Random.Shared.Next(10, 80));
    PrintPersonById(i);
}
```
### Первая ревизия class Person 

```csharp
class Person
{
    private string name;
    private int age;

    public Person(string n, int a)
    {
        name = n;
        age = a;
    }

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }
    // public string GetName()
    // {
    //     return name;
    // }
    // public void SetName(string value)
    // {
    //     name = value;
    // }

    public int Age
    {
        get { return age; }
        private set { age = value; }
    }
    // public int GetAge()
    // {
    //     return age;
    // }
    // public void SetAge(int a)
    // {
    //     age = a;
    // }
}
```