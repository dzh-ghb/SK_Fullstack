// // Пример ввода строки с консоли
// Console.Write("Введите ваше имя: ");
// string name = Console.ReadLine();
// // Вывод приветствия с именем пользователя
// Console.WriteLine($"Привет, {name}!"); // интерполяция строк (значение подставляется во время компиляции)
// Console.WriteLine("Привет, " + name + "!");

// // Пример ввода одного символа с консоли
// Console.Write("Нажмите любую клавишу, чтобы продолжить...");
// ConsoleKeyInfo keyInfo = Console.ReadKey();
// // Вывод информации о нажатой клавише
// Console.WriteLine($"\nВы нажали клавишу {keyInfo.KeyChar}.");

// // Пример обработки числового ввода
// Console.Write("Введите ваш возраст: ");
// string inputAge = Console.ReadLine();

// // Попытка преобразовать строку в число
// int age = default;
// bool parseResult = int.TryParse(inputAge, out age);
// // Вывод возраста, если ввод корректен
// Console.WriteLine($"Получилось ли преобразовать: {parseResult}");

Console.WriteLine("Input #1");
string s1 = Console.ReadLine();
Console.WriteLine($"Input >> {s1}");

Console.WriteLine("Press any key...");
ConsoleKeyInfo keyInfo = Console.ReadKey();
Console.WriteLine($"\npressed {keyInfo.KeyChar} key");

Console.WriteLine("Input #2");
bool parseResult = int.TryParse(Console.ReadLine(), out int age);
Console.WriteLine($"Success? {parseResult}");
