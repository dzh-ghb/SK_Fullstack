class Printer
{
    public void Print(IRepositoryPerson repository) // передача интерфейса в параметры
    {
        int count = repository.Count;

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(repository.GetById(i).ToString());
        }
    }
}