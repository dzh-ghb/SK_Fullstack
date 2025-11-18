class Printer
{
    public void Print(Repository repository)
    {
        int count = repository.Count;

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(repository.getPersonById(i).ToString());
        }
    }
}