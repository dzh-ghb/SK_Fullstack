// Пример использования метода Concat (удобно для большого "склеивания")
string hello = "Hello, ";
string world = "world!";
string combined = string.Concat(hello, world);
// Выведет: Hello, world!
Console.WriteLine(combined);

// Пример использования метода Contains
bool containsWorld = combined.Contains("world");
// Выведет: true
Console.WriteLine($"Строка содержит 'world': {containsWorld}");

// Пример использования метода IndexOf
//                        0123456    789...
combined = string.Concat("Hello, ", "world!");
int indexOfW = combined.IndexOf('o'); // поиск с начала
int lastIndexOfW = combined.LastIndexOf('o'); // поиск с конца
// Выведет: 7
Console.WriteLine($"Индекс буквы 'w': {indexOfW}");
Console.WriteLine($"Индекс буквы 'w' с конца: {lastIndexOfW}");

// Пример использования метода Substring
string sub = combined.Substring(7, 4);
// Выведет: world!
Console.WriteLine(sub);

// Пример использования метода Replace (меняет не одно, а все найденные значения)
// combined = combined + "world " + "world123" + "world1 !";
string replaced = combined.Replace("world", "C#");
// Выведет: Hello, C#!
Console.WriteLine(replaced);

// Пример использования метода Split
var parts = "one,two,three".Split(',', ' ');
// Игнорирование пустых элементов
var parts1 = "1,  2    , 3, 4     ".Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"parts: {parts1[3]}");

// Выведет: one
Console.WriteLine($"Первая часть: {parts[0]}");

// Пример использования методов ToUpper и ToLower
string upper = combined.ToUpper(); // исходная строка не изменяется
// Выведет: HELLO, WORLD!
Console.WriteLine(upper);
string lower = combined.ToLower();
// Выведет: hello, world!
Console.WriteLine(lower);

// Пример использования метода Trim | TrimEnd | TrimStart
string trimmed = "  Hello, world!  ".Trim();
// Выведет: 'Hello, world!'
Console.WriteLine($"Обрезанная строка: '{trimmed}'");

// Пример получения длины строки
int length = combined.Length;
// Выведет: 13
Console.WriteLine($"Длина строки: {length}");

// Пример сравнения строк
// Игнорирование регистра при сравнении (через "==" сравнивает с точностью до регистра)
bool areEqual = string.Equals("Hello", "hello", StringComparison.OrdinalIgnoreCase);
// Выведет: false
Console.WriteLine($"Строки равны (без учета регистра): {areEqual}");

// 0 
string c = Convert.ToString(combined[1]); // [n] - индексатор
c = combined[1].ToString();
char c1 = combined[1];

