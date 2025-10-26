using System.Text;

// Пример использования оператора +
string hello = "Hello, ";
string world = "world!";
string greeting1 = hello + world;
// Выведет: Hello, world!
Console.WriteLine(greeting1);

// Пример использования метода String.Concat
string greeting2 = String.Concat("Hello, ", "world", "!");
// Выведет: Hello, world!
Console.WriteLine(greeting2);

// Пример использования метода String.Join
string[] words = { "Hello", "world" };
string greeting3 = String.Join(", ", words) + "!";
// Выведет: Hello, world!
Console.WriteLine(greeting3);

// Пример использования строковой интерполяции
string greeting4 = $"Hello, {world}";
// greeting4[3] = '!';
// Выведет: Hello, world!
Console.WriteLine(greeting4);

// Пример использования StringBuilder для конкатенации строк

StringBuilder sb = new();
sb.Append("Hello, ");
sb.Append("world!");
sb.Append(123);
sb[1] = '!'; // мутабельный тип - обычные строки изменять нельзя
string greeting5 = sb.ToString();
// Выведет: Hello, world!
Console.WriteLine(greeting5);

// Пример интернирования строк
string a = "Hello, world!";
string b = "Hello, world!";
// true, так как строки интернированы
bool areSame1 = ReferenceEquals(a, b);
Console.WriteLine($"Строки a и b интернированы: {areSame1}");

string s1 = "Hello,";
string s2 = " world!";
string a2 = s1 + s2;
string b2 = "Hello, world!";
// false, так как строки не интернированы после конкатенации
bool areSame2 = ReferenceEquals(a2, b2);
Console.WriteLine($"Строки a2 и b2 интернированы: {areSame2}");

// Пример ручного интернирования строк
string nonInterned = String.Intern(a2);
// теперь true, так как строка a2 была интернирована
bool areSame3 = ReferenceEquals(nonInterned, b2);
Console.WriteLine($"Строки nonInterned и b2 интернированы после ручного интернирования: {areSame3}");
