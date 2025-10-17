
// MyMethodDelegate method = IsEven;

// var r = method(1);
// Console.WriteLine(r);


// Написать метод, который будет принимать массив
// и метод проверки этих чисел
// возвращать новый массив чисел
// с учетом логики проверки

// bool IsEven(int x)
// {
//     return x % 2 == 0;
// }
// bool Check(int x)
// {
//     return x % 5 == 0 && x % 2 == 0;
// }

int[] CheckArray(int[] numbers, Func<int, bool> logic)
{
    int count = numbers.Length;
    int countEven = 0;

    for (int i = 0; i < count; i++)
    {
        if (logic(numbers[i])) countEven++;
    }

    int[] evenNumbers = new int[countEven];
    int pos = 0;
    for (int i = 0; i < count; i++)
    {
        if (logic(numbers[i]))
        {
            evenNumbers[pos] = numbers[i];
            pos++;
        }
    }
    return evenNumbers;
}

// int[] ints = CheckArray(new int[] { 1, 21, 3, 40, 5 }, delegate (int x)
// {
//     return x % 5 == 0 && x % 2 == 0;
// });
// int[] ints = CheckArray(new int[] { 1, 21, 3, 40, 5 }, delegate (int x)
// {
//     return x % 2 == 0;
// });

// int[] ints = CheckArray(new int[] { 1, 21, 3, 40, 5 }, (int x) =>
// {
//     return x % 2 == 0;
// });

// int[] ints = CheckArray(new int[] { 1, 21, 3, 40, 5 }, (int x) => x % 2 == 0);
int[] ints = CheckArray(new int[] { 1, 21, 3, 40, 5 }, x => x % 2 == 0);

// Func<int, bool> m = x => x % 2 == 0;

Console.WriteLine(String.Join(", ", ints));

// delegate bool MyMethodDelegate(int value);














// int Add(int x, int y)
// {
//     return x + y;
// }

// int Multiply(int x, int y)
// {
//     return x * y;
// }

// // Использование делегата с методом Add
// Operation op = Add;
// Console.WriteLine($"Сумма 5 и 3: {op(5, 3)}");

// // Использование делегата с лямбда-выражением
// op = (x, y) => x - y;
// Console.WriteLine($"Разница 5 и 3: {op(5, 3)}");

// // Создание многоадресного делегата
// op += Multiply; // Добавляем метод Multiply к делегату
//                 // Поскольку делегат теперь многоадресный, последний метод в цепочке определяет возвращаемое значение
// Console.WriteLine($"Произведение 5 и 3: {op(5, 3)}");

// // Использование встроенных делегатов
// Action<string> showMessage = Console.WriteLine; // Делегат для метода без возвращаемого значения
// showMessage("Привет, мир!");

// Func<int, int, int> sum = (x, y) => x + y; // Делегат для метода с возвращаемым значением
// Console.WriteLine($"Сумма через Func: {sum(5, 3)}");

// // Определение делегата
// public delegate int Operation(int x, int y);
