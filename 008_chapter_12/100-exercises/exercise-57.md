+++
```C#
using System.Data;

int len = int.Parse(Console.ReadLine());

List<int> nums = Enumerable.Range(0, len)
    .Select(i => Random.Shared.Next(0, 51))
    .ToList();

int avg = (int)nums.Average();
int diff = Math.Abs(nums[0] - avg);
int res = nums[0];
Console.WriteLine($"diff-0 {diff}; res-0 {res}");

for (int i = 1; i < nums.Count; i++)
{
    if (Math.Abs(nums[i] - avg) < diff)
    {
        res = nums[i];
        diff = Math.Abs(nums[i] - avg);
        Console.WriteLine($"diff-{i} {diff}; res {res}");
    }
}

Console.WriteLine(String.Join(", ", nums));
Console.WriteLine($"avg {avg}");
Console.WriteLine($"res {res}");
```

### Формулировка
Найти в массиве элемент, наиболее близкий к среднему арифметическому всех его элементов.

### Пояснение
Программа должна принимать на вход массив чисел. Затем она должна вычислить среднее арифметическое всех элементов массива и найти элемент, который наиболее близок к этому среднему значению. Если таких элементов несколько, можно вернуть любой из них.

### Тесты

1. **Пример 1:**
   - Вход: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
   - Ожидаемый результат: 5 или 6

2. **Пример 2:**
   - Вход: [11, 22, 33, 44, 55, 66, 77, 88, 99]
   - Ожидаемый результат: 55

3. **Пример 3:**
   - Вход: [2, 4, 6, 8, 10]
   - Ожидаемый результат: 6

