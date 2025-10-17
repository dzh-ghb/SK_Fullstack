// # ТЗ
// Метод, который создает новый массив
// int[] CreateArray(int count)
// Метод, который заполняет массив случайными числами
// int[] FillArray(int count)
// int[] FillArray(int[] emptyArray)
// Метод, который выводит массив на экран
// Print(int[] array)
// Метод, который ищет только четные числа
// int[] FindEven(int[] numbers)

// Метод, который создает новый массив
// int[] CreateArray(int count)
int[] CreateArray(int count)
{
    return new int[count];
}

// Метод, который заполняет массив случайными числами
int[] FillArray1(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = Random.Shared.Next(10);
    }
    return array;
}
int[] FillArray2(int[] emptyArray)
{
    int count = emptyArray.Length;
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = Random.Shared.Next(10);
    }
    return array;
}

// Метод, который выводит массив на экран
// ???
void PrintBad(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string Join(int[] array)
{
    string result = String.Empty; // ""
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        result += $"{array[i]} ";
    }
    return result;
}

// Метод, который ищет только четные числа
int[] FindEven(int[] numbers)
{

}

// int[] ints = CreateArray(12);
int[] ints = FillArray1(12);
// PrintBad(ints);
string output = Join(ints);
// Console.WriteLine(output);
File.WriteAllText("output_ints.txt", output);
int[] evenNumbers = FindEven(ints);
// PrintBad(evenNumbers);
output = Join(evenNumbers);
// Console.WriteLine(output);
File.WriteAllText("output_evenNumbers.txt", output);