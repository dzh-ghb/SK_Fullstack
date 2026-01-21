// int i = 251;
// double res = Math.Sqrt(i);
// System.Console.WriteLine(res);

// System.Console.WriteLine(i.Sqrt());

// i.Sqrt().Print();
// 251.Sqrt(0).Print();
251.Sqrt().Print();
251.12.Print();
"251".Print();

// создание методов расширений (доп. функционал для типов данных)
public static class Extension
{
    public static double Sqrt(this int x, int count = 2) // пример метода расширений
    {
        return Math.Round(Math.Sqrt(x), count);
    }

    public static void Print<T>(this T x) // обобщенный метод расширения
    {
        Console.WriteLine(x);
    }
}