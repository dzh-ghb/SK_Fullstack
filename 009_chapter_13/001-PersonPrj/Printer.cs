class Printer
{
    public void Print(Repository repository)
    {
        int count = repository.Count;

        for (int i = 0; i < count; i++)
        {
            Person temp = repository.getPersonById(i);
            Console.WriteLine($"{temp.Name}, {temp.Age}");
        }
    }
}