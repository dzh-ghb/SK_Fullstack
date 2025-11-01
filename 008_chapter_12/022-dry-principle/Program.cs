using System.Runtime.CompilerServices;
using System.Text;

int[] GetArr(int length)
{
    return new int[length];
}

void FillingArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Random.Shared.Next(150);
    }
}

string getArrElements(int[] arr)
{
    StringBuilder mutableStr = new();
    for (int i = 0; i < arr.Length; i++)
    {
        mutableStr.Append($"el_{i + 1} - {arr[i]}\n");
    }
    return mutableStr.ToString();
}

int GetSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += (arr[i] >= 9 && arr[i] < 100) ? arr[i] : 0;
        // Console.WriteLine($"el_{i + 1} - {arr[i]}");
    }
    return sum;
}

Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());
int[] arr = GetArr(length: length); // именованный аргумент
FillingArr(arr);

Console.WriteLine(getArrElements(arr));
Console.Write($"Сумма двухзначных элементов: {GetSum(arr)}");