+++
```C#
// int getMinutes(string weekCount)
// {
//     double weeks = 0;
//     switch (weekCount.ToLower())
//     {
//         case "полнедели":
//             weeks = 0.5;
//             break;
//         case "неделя":
//             weeks = 1;
//             break;
//         case "две недели":
//             weeks = 2;
//             break;
//     }
//     return (int)Math.Floor(weeks * 7 * 24 * 60);
// }
// Console.Write("Количество недель: ");
// string weeks = Console.ReadLine();
// Console.WriteLine($"{getMinutes(weeks)} мин.");

int getMinutes(double weeks)
{
    return (int)Math.Floor(weeks * 7 * 24 * 60);
}
Console.Write("Количество недель: ");
double weekPart = double.Parse(Console.ReadLine());

Console.WriteLine($"{getMinutes(weekPart)} мин.");
```

### Формулировка
Вычисление количества минут в неделе.

### Пояснение
Для вычисления количества минут в неделе необходимо умножить количество дней в неделе на количество часов в сутках и на количество минут в часе. Таким образом, формула принимает вид: количество минут = 7 (дней в неделе) × 24 (часа в сутках) × 60 (минут в часе).

### Тесты

1. **Пример 1:**
   - Входные данные: Неделя
   - Вычисление: $7 \times 24 \times 60$
   - Результат: $10080$ минут

2. **Пример 2:**
   - Входные данные: Половина недели
   - Вычисление: $\frac{7}{2} \times 24 \times 60$
   - Результат: $5040$ минут

3. **Пример 3:**
   - Входные данные: Две недели
   - Вычисление: $2 \times 7 \times 24 \times 60$
   - Результат: $20160$ минут
