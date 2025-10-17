static class Methods
{
    public static int[] CreateArray(int count)
    {
        return new int[count];
    }
    public static int[] FillArray1(int count)
    {
        int[] array = new int[count];
        for (int i = 0; i < count; i++)
        {
            array[i] = Random.Shared.Next(10);
        }
        return array;
    }
    public static int[] FillArray2(int[] emptyArray)
    {
        int count = emptyArray.Length;
        int[] array = new int[count];
        for (int i = 0; i < count; i++)
        {
            array[i] = Random.Shared.Next(10);
        }
        return array;
    }
    public static void PrintBad(int[] array)
    {
        int count = array.Length;
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
    public static string Join(int[] array)
    {
        string result = String.Empty; // ""
        int count = array.Length;
        for (int i = 0; i < count; i++)
        {
            result += $"{array[i]} ";
        }
        return result;
    }
    public static int[] FindEven(int[] numbers)
    {
        int count = numbers.Length;
        int countEven = 0;

        for (int i = 0; i < count; i++)
        {
            if (numbers[i] % 2 == 0) countEven++;
        }

        int[] evenNumbers = new int[countEven];
        int pos = 0;
        for (int i = 0; i < count; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenNumbers[pos] = numbers[i];
                pos++;
            }
        }
        return evenNumbers;
    }
}