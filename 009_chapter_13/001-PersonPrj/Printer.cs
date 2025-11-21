class Printer
{
    public void Print(IRepository repository) // передача интерфейса в параметры
    {
        int count = repository.Count;

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(repository.GetById(i).ToString());
        }
    }
}