using System.Linq;

// создание набора из N элементов
List<int> ints = Enumerable.Range(0, 20) // набор из 20 элементов (0..19)
    .Select(i => Random.Shared.Next(1, 20)) // перезаполнение случайными числами (аналог map?)
                                            // .Select(GetRandom)
    .Where(i => i % 2 == 0) // фильтрация (аналог filter?)
                            // .Where(IsEven) // фильтрация
    .OrderBy(i => i) // сортировка (аналог sort?)
    .ToList(); // сохранение в список
Console.WriteLine(ints.Count);
Console.WriteLine(String.Join(", ", ints));

#region Code#1
// разбор лямбда-функций, описанных выше
// i => Random.Shared.Next(1, 20):
// int GetRandom(int i) // параметр не используется
// {
//     return Random.Shared.Next(1, 20);
// }
// // i => i % 2 == 0:
// bool IsEven(int i)
// {
//     return i % 2 == 0;
// }
#endregion

#region Code#2
// List<int> ints = new();
// // заполнение без LINQ ("по старинке")
// for (int i = 0; i < 10; i++)
// {
//     ints.Add(Random.Shared.Next(1, 20));
// }
// Console.WriteLine(String.Join(", ", ints));
// // отбор только четных элементов ("по старинке")
// List<int> evenInts = new();
// for (int i = 0; i < ints.Count; i++)
// {
//     if (ints[i] % 2 == 0)
//     {
//         evenInts.Add(ints[i]);
//     }
// }
// Console.WriteLine(String.Join(", ", evenInts));
#endregion