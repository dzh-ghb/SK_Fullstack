// Пример использования метода Abs для получения абсолютного значения
Console.WriteLine("Абсолютное значение -5: " + Math.Abs(-5));

// Пример использования методов Max и Min
Console.WriteLine("Наибольшее число из 5 и 10: " + Math.Max(5, 10));
Console.WriteLine("Наименьшее число из 5 и 10: " + Math.Min(5, 10));

// Примеры округления чисел
Console.WriteLine("Округление до ближайшего большего целого (2.3): " + Math.Ceiling(2.3));
Console.WriteLine("Округление до ближайшего меньшего целого (2.7): " + Math.Floor(2.7));
Console.WriteLine("Округление до ближайшего четного - по дефолту (2.5): " + Math.Round(2.5));
Console.WriteLine("Округление до ближайшего целого (2.5): " + Math.Round(2.5, MidpointRounding.AwayFromZero));

// Примеры тригонометрических функций
double angle = Math.PI / 4; // 45 градусов в радианах
Console.WriteLine("Синус 45 градусов: " + Math.Sin(angle));
Console.WriteLine("Косинус 45 градусов: " + Math.Cos(angle));
Console.WriteLine("Тангенс 45 градусов: " + Math.Tan(angle));

// Примеры экспоненциальных и логарифмических функций
Console.WriteLine("e в степени 2: " + Math.Exp(2));
Console.WriteLine("Натуральный логарифм числа e: " + Math.Log(Math.E));
Console.WriteLine("Десятичный логарифм числа 100: " + Math.Log10(100));

// Примеры степенных функций
Console.WriteLine("2 в степени 1 / 3 (аналог кубического корня из восьми): " + Math.Pow(8, 1.0 / 3));
Console.WriteLine("Квадратный корень из 16: " + Math.Sqrt(16));

// Вывод констант
Console.WriteLine("Число e: " + Math.E);
Console.WriteLine("Число Pi: " + Math.PI);
