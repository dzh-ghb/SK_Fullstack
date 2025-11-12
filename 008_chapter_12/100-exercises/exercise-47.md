+++
```C#
using System.Text;

(string str, string res) getRes(int length)
{
    string lowerLetters = "абвгдежзийклмнопрстуфхцчшщъыьэюяabcdefghijklmnopqrstuvwxyz";
    char[] arr = new char[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = lowerLetters[Random.Shared.Next(lowerLetters.Length)];
    }

    Dictionary<char, int> res = new();
    for (int i = 0; i < lowerLetters.Length; i++)
    {
        res.Add(lowerLetters[i], 0);
    }

    for (int i = 0; i < length; i++)
    {
        if (lowerLetters.Contains(arr[i].ToString().ToLower())) res[arr[i]]++;
    }

    StringBuilder sB = new("{");
    foreach (var pair in res)
    {
        sB.Append($"'{pair.Key}':{pair.Value}, ");
    }
    sB.Remove(sB.Length - 2, 2);
    sB.Append('}');
    // string resStr = sB.ToString().Substring(0, sB.Length - 1);
    return ((String.Join("", arr)), sB.ToString());
}

int len = int.Parse(Console.ReadLine());
(string str1, string res1) res = getRes(len);
Console.WriteLine(res.str1 + "\n" + res.res1);
```

### Формулировка
Напишите программу, которая заполняет массив случайными буквами и находит частоту встречаемости каждой буквы в массиве.

### Пояснение
Программа должна сгенерировать массив заданного размера, заполненный случайными буквами, а затем подсчитать, сколько раз каждая буква встречается в массиве.

### Тесты

1. **Пример 1:**
   - Размер массива: 20
   - Ожидаемый вывод: {'a': 4, 'b': 3, 'c': 1, 'd': 2, 'e': 2, 'f': 1, 'g': 1, 'h': 1, 'i': 1, 'j': 1, 'k': 1, 'l': 1, 'm': 1, 'n': 1, 'o': 1, 'p': 1, 'q': 1, 'r': 1, 's': 1, 't': 1}

2. **Пример 2:**
   - Размер массива: 30
   - Ожидаемый вывод: {'a': 5, 'b': 2, 'c': 2, 'd': 1, 'e': 4, 'f': 1, 'g': 1, 'h': 1, 'i': 1, 'j': 1, 'k': 1, 'l': 1, 'm': 2, 'n': 1, 'o': 1, 'p': 1, 'q': 1, 'r': 2, 's': 1, 't': 1, 'u': 1, 'v': 1, 'w': 1, 'x': 1, 'y': 1, 'z': 1}

3. **Пример 3:**
   - Размер массива: 25
   - Ожидаемый вывод: {'a': 3, 'b': 2, 'c': 1, 'd': 2, 'e': 1, 'f': 1, 'g': 1, 'h': 2, 'i': 1, 'j': 1, 'k': 1, 'l': 1, 'm': 1, 'n': 1, 'o': 1, 'p': 1, 'q': 1, 'r': 1, 's': 1, 't': 1, 'u': 1, 'v': 1, 'w': 1, 'x': 1, 'y': 1, 'z': 1}

