int[] array = new int[10];

try
{
    Console.WriteLine(array[2]);
}
catch
{
    Console.WriteLine("Какая-то ошибка ");
}
finally
{
    Console.WriteLine("+++");
}

















return;
// Базовая структура обработки исключений
try
{
    int[] myArray = { 1, 2, 3 };
    Console.WriteLine(myArray[3]); // Попытка доступа за пределы массива, вызовет IndexOutOfRangeException
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine("Индекс вне границ массива!");
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Операция завершена.");
}

// Выбрасывание исключений
try
{
    CheckAge(17); // Вызов метода, который может выбросить исключение
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}
catch (MyCustomException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
// Работа с собственными типами исключений
try
{
    throw new MyCustomException("Это моё собственное исключение.");
}
catch (MyCustomException e)
{
    Console.WriteLine(e.Message);
}


void CheckAge(int age)
{
    if (age < 18)
    {
        throw new ArgumentException("Возраст должен быть не меньше 18");
    }
}


// Обработка исключений чтения файла
try
{
    File.ReadAllText("nonexistent.txt");
}
catch (FileNotFoundException)
{
    Console.WriteLine("Файл не найден.");
}

// Создание собственного типа исключения
public class MyCustomException : Exception
{
    public MyCustomException(string message) : base(message)
    {
    }
}
