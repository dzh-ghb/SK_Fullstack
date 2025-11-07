// bool IsEven(int x)
// {
//     return x % 2 == 0;
// }

// bool Check(int x)
// {
//     return x % 5 == 0 && x % 2 == 0;
// }

// Пример №1
// MyDelegate method = IsEven;
// var r = method(3);
// Console.WriteLine(r);

// Пример №2
// Метод, принимающий массив чисел
// и метод проверки этих чисел,
// возвращать новый массив чисел
// с учетом логики проверки;
// метод принимает в аргументы метод
// int[] CheckArr(int[] nums, MyDelegate logic)
int[] CheckArr(int[] nums, Func<int, bool> logic)
{
    int count = nums.Length;
    int countEven = 0;

    for (int i = 0; i < count; i++)
    {
        if (logic(nums[i])) countEven++;
    }

    int[] evenNums = new int[countEven];
    int pos = 0;

    for (int i = 0; i < count; i++)
    {
        if (logic(nums[i]))
        {
            evenNums[pos] = nums[i];
            pos++;
        }
    }
    return evenNums;
}

// №1 - передача метода
// int[] ints = CheckArr(new int[] { 1, 2, 3, 4, 5 }, Check); // CheckArr будет переваривать массив с учетом логики обычного метода в параметрах

// №2 - передача анонимного метода
// int[] ints = CheckArr(new int[] { 1, 2, 3, 4, 5 }, delegate (int x)
//  {
//      return x % 5 == 0 && x % 2 == 0;
//  }); // CheckArr будет переваривать массив с учетом логики анонимного метода

// №3 - укороченный вариант
// int[] ints = CheckArr(new int[] { 1, 20, 3, 4, 5 }, (int x) =>
//  {
//      return x % 5 == 0 && x % 2 == 0;
//  });

// №4 - более короткий вариант для однострочного тела
// int[] ints = CheckArr(new int[] { 1, 20, 3, 4, 5 }, (int x) => x % 5 == 0 && x % 2 == 0);

// №5 - лямбда-выражения - еще более укороченный вариант (в делегате четко определен тип - нет нужны указывать его здесь)
// int[] ints = CheckArr(new int[] { 1, 20, 3, 4, 5 }, x => x % 5 == 0 && x % 2 == 0);

// Func<int, bool> m = x => x % 5 == 0 && x % 2 == 0;
int[] ints = CheckArr(new int[] { 1, 20, 3, 4, 5 }, x => x % 5 == 0 && x % 2 == 0);

Console.WriteLine(String.Join(", ", ints));

// delegate bool MyDelegate(int val); // повторяет сигнатуру метода