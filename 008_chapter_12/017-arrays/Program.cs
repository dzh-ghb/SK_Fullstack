// Определение и инициализация массива
// int[] myArray1 = new int[5]; // после этого нужна инициализация
// int[] myArray2 = new int[5] { 2, 1, 77, 22, 221 };
int[] myArray = { 2, 1, 77, 22, 221 }; // инициализация сразу
// int[] myArray = [2, 1, 77, 22, 221]; // компактный вариант
Console.WriteLine($"Инициализированный массив: {String.Join(", ", myArray)}");

// Пример использования цикла for для прохода по массиву
Console.WriteLine("\nПроход по массиву с использованием цикла for:");
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($"Элемент {i}: {myArray[i]}");
}

// Пример использования цикла foreach для прохода по массиву
Console.WriteLine("\nПроход по массиву с использованием цикла foreach:");
foreach (int element in myArray)
{
    Console.WriteLine(element);
}

// Доступ к элементам массива
Console.WriteLine($"\nПервый элемент массива: {myArray[0]}");
myArray[1] = 20;
Console.WriteLine($"Второй элемент массива после изменения: {myArray[1]}");

// Array.Resize(ref myArray, 100); // изменения длины массива
// Array.Sort(myArray); // сортировка элементов по возрастанию
// Array.Reverse(myArray); // разворот массива
// Console.WriteLine(String.Join(", ", myArray));

// Работа с многомерным массивом
int[,] multiDimensionalArray = new int[2, 3] { { 2, 3, 4 }, { 1, 1, 1 } };
multiDimensionalArray[0, 0] = 1;
multiDimensionalArray[1, 2] = 2;
Console.WriteLine("\nМногомерный массив:");

for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
{
    for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
    {
        int el = multiDimensionalArray[i, j];
        Console.Write(el + " ");
    }
    Console.WriteLine();
}

// Работа с зубчатым массивом (массив массивов)
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[3] { 17, 28, 39 }; // первый элемент массива - массива
jaggedArray[1] = new int[2] { 1, 2 };
jaggedArray[2] = new int[] { 1, 2, 2, 1, 12, 3, 4, 5, 5 };
Console.WriteLine("\nЗубчатый массив:");
foreach (int[] arr in jaggedArray) // перебор "строк"
{
    foreach (int element in arr) // перебор элементов на каждой "строке"
    {
        Console.Write(element + " ");
    }
    Console.WriteLine();
}