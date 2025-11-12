+++
```C#
bool isNum(string str)
{
    String nums = String.Join("", Enumerable.Range(0, 10).ToList());

    foreach (char each in str)
    {
        if (!nums.Contains(each)) return false;
    }
    return true;
}
string res = Console.ReadLine();
Console.WriteLine(isNum(res));
```

### Формулировка
Напишите программу, которая определяет, содержит ли строка только цифры.

### Пояснение
Программа должна принимать строку от пользователя и проверять, состоит ли она только из цифр.

### Тесты

1. **Пример 1:**
   - Входные данные: "12345"
   - Ожидаемый вывод: True

2. **Пример 2:**
   - Входные данные: "123a5"
   - Ожидаемый вывод: False

3. **Пример 3:**
   - Входные данные: "abc123"
   - Ожидаемый вывод: False

