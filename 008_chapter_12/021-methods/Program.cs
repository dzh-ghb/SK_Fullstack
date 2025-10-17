// Определение и вызов метода
int Add(int a, int b)
{
    return a + b;
}

// Пример метода с переменным количеством параметров
int Sum(params int[] numbers)
{
    int result = 0;
    foreach (int number in numbers)
    {
        result += number;
    }
    return result;
}

double Multiply(double a, double b)
{
    return a * b;
}

// Пример метода расширения для класса string
int WordCount(string str)
{
    return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
}
int count = WordCount("Слово1,слово2.слово3?ещё слова");

// Вызов метода
Console.WriteLine("Сумма 5 и 3 равна " + Add(5, 3));

// Вызов метода с переменным количеством параметров
Console.WriteLine("Сумма чисел 1, 2, 3, 4 равна " + Sum(1, 2, 3, 4));

// Вызов перегруженных методов
Console.WriteLine("Произведение 5.5 и 2.2 равно " + Multiply(5.5, 2.2));
Console.WriteLine("Произведение 5 и 2 равно " + Multiply(5, 2));

// Использование метода расширения
string testString = "Hello, world! How are you?";
Console.WriteLine($"Количество слов в строке: '{testString}' = {testString.WordCount()}");

// Класс с методом расширения должен быть статическим
public static class StringExtensions
{
    // Определение метода расширения для подсчета слов в строке
    public static int WordCount(this string str)
    {
        return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}