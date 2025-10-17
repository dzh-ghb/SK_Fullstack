#region Code
// List<int> ints = new();
// for (int i = 0; i < 10; i++)
// {
//     ints.Add(Random.Shared.Next(10));
// }
// Console.WriteLine(String.Join(", ", ints));
// List<int> evens = new();
// for (int i = 0; i < ints.Count; i++)
// {
//     if (ints[i] % 2 == 0)
//     {
//         evens.Add(ints[i]);
//     }
// }
// Console.WriteLine(String.Join(", ", evens));
#endregion

#region Code
// int GetRandom(int item)
// {
//     return Random.Shared.Next(10);
// }

// bool Check(int item)
// {
//     return item % 2 == 0;
// }

// List<int> ints = Enumerable.Range(0, 10)
//     // .Select(item => Random.Shared.Next(10))
//     .Select(GetRandom)
//     // .Select(e => e * 3)
//     // .Select(e => e + 1)
//     .ToList();

// // .Where(item => item % 2 == 0)
// var res = ints
//     .Where(Check)
//     .OrderBy(e => e);

// Console.WriteLine(ints.Count);
// Console.WriteLine(String.Join(", ", ints));
// Console.WriteLine(String.Join(", ", res));

#endregion

var res = Enumerable.Range(0, 60000)
                     .Select(i => Random.Shared.Next(1, 7))
                     .GroupBy(e => e)
                     .OrderBy(e => e.Key);

// Console.WriteLine(String.Join(", ", cube));

foreach (var item in res)
{
    Console.WriteLine($"{item.Key} {item.Count()}");
}





























// // Пример использования Where для фильтрации
// List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
// var evenNumbers = numbers.Where(n => n % 2 == 0);
// Console.WriteLine("Четные числа:");
// foreach (var n in evenNumbers)
// {
//     Console.WriteLine(n);
// }

// // Пример использования Select для проекции
// var squares = numbers.Select(n => n * n);
// Console.WriteLine("Квадраты чисел:");
// foreach (var square in squares)
// {
//     Console.WriteLine(square);
// }

// // Пример использования агрегирующих функций
// Console.WriteLine($"Количество элементов: {numbers.Count()}");
// Console.WriteLine($"Сумма элементов: {numbers.Sum()}");
// Console.WriteLine($"Среднее значение: {numbers.Average()}");
// Console.WriteLine($"Минимальное значение: {numbers.Min()}");
// Console.WriteLine($"Максимальное значение: {numbers.Max()}");

// // Пример использования OrderBy и OrderByDescending для сортировки
// Console.WriteLine("Сортировка по возрастанию:");
// var sortedNumbers = numbers.OrderBy(n => n);
// foreach (var n in sortedNumbers)
// {
//     Console.WriteLine(n);
// }

// Console.WriteLine("Сортировка по убыванию:");
// var sortedNumbersDesc = numbers.OrderByDescending(n => n);
// foreach (var n in sortedNumbersDesc)
// {
//     Console.WriteLine(n);
// }

// // Пример использования GroupBy для группировки
// List<Person> people = new List<Person>
// {
//     new Person { Name = "Иван", Age = 30 },
//     new Person { Name = "Мария", Age = 25 },
//     new Person { Name = "Анна", Age = 30 }
// };
// var groups = people.GroupBy(p => p.Age);
// foreach (var group in groups)
// {
//     Console.WriteLine($"Возраст: {group.Key}");
//     foreach (var person in group)
//     {
//         Console.WriteLine($"    Имя: {person.Name}");
//     }
// }

// // Пример использования Union для объединения
// int[] first = { 1, 2, 3 };
// int[] second = { 3, 4, 5 };
// var combinedUnique = first.Union(second);
// Console.WriteLine("Уникальные элементы из двух массивов:");
// foreach (var n in combinedUnique)
// {
//     Console.WriteLine(n);
// }

// public class Person
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
// }
