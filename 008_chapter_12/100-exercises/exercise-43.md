+++
```C#
string input = Console.ReadLine();

HashSet<char> uniqueChars = new();
foreach (char c in input) uniqueChars.Add(c);
Console.WriteLine(String.Join("", uniqueChars));
Dictionary<char, int> res = new(uniqueChars.Count);
foreach (char c in uniqueChars)
{
    res.Add(c, 0);
}
Console.WriteLine(String.Join("", res));

for (int i = 0; i < input.Length; i++)
{
    foreach (var key in res.Keys)
    {
        if (key == input[i]) res[key]++;
    }
}
Console.WriteLine(String.Join("", res));
```

### Формулировка
Напишите программу, которая подсчитывает количество вхождений каждой буквы в строке и выводит их в формате словаря.

### Пояснение
Программа должна принимать строку от пользователя, подсчитывать количество вхождений каждой буквы и выводить результат в виде словаря, где ключи - это буквы, а значения - количество их вхождений.

### Тесты

1. **Пример 1:**
   - Входные данные: "абракадабра"
   - Ожидаемый вывод: {'а': 5, 'б': 2, 'р': 2, 'к': 1, 'д': 1}

2. **Пример 2:**
   - Входные данные: "hello"
   - Ожидаемый вывод: {'h': 1, 'e': 1, 'l': 2, 'o': 1}

3. **Пример 3:**
   - Входные данные: "programming"
   - Ожидаемый вывод: {'p': 1, 'r': 2, 'o': 1, 'g': 2, 'a': 1, 'm': 2, 'i': 1, 'n': 1}

