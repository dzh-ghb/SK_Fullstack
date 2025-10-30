// Пример использования HashSet<T>
Console.WriteLine("\nHashSet<T> пример:");
HashSet<int> numbers = new HashSet<int>() { 1, 2, 3, 4, 5 };
// Добавление элемента (уникальные значения)
numbers.Add(6);
// Удаление элемента
numbers.Remove(2);
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

// Примеры операций с HashSet<T>
HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
HashSet<int> set2 = new HashSet<int>() { 4, 5, 6, 7, 8 };
// Пересечение (Intersection) множеств:
set1.IntersectWith(set2);
Console.WriteLine("\nПересечение множеств set1 и set2:");
foreach (var number in set1)
{
    Console.WriteLine(number);
}

// Объединение (Union) множеств:
set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
set2 = new HashSet<int>() { 4, 5, 6, 7, 8 };
// set1 теперь содержит все уникальные 
// элементы из обоих множеств
set1.UnionWith(set2);
Console.WriteLine("\nОбъединение множеств set1 и set2:");
foreach (var number in set1)
{
    Console.WriteLine(number);
}

// Разность (Difference) множеств:
set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
set2 = new HashSet<int>() { 4, 5, 6, 7, 8 };
// set1 теперь содержит только элементы, 
// присутствующие в set1 и отсутствующие в set2
set1.ExceptWith(set2);
Console.WriteLine("\nОбъединение множеств set1 и set2:");
foreach (var number in set1)
{
    Console.WriteLine(number);
}