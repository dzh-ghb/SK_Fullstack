// Пример неявного преобразования типов
int myInt = 123; // 4 байта
// Неявное преобразование из int в double
double myDouble = myInt; // 8 байт
Console.WriteLine("Неявное преобразование int в double: " + myDouble);

// Пример явного преобразования типов (приведение типов)
double anotherDouble = 123.456; // 8 байт
// Явное преобразование из double в int
int anotherInt = (int)anotherDouble; // 4 байта
Console.WriteLine("Явное преобразование double в int: " + anotherInt);

// Преобразование с использованием класса Convert
string intString = "123";
int fromStringToInt = Convert.ToInt32(intString); // Преобразует строку в int
Console.WriteLine("Преобразование строки в int с использованием Convert: " + fromStringToInt);

// Преобразование с использованием метода Parse
string doubleString = "123.456";
// Преобразует строку в double
double fromStringToDouble = double.Parse(doubleString);
Console.WriteLine("Преобразование строки в double с использованием Parse: " + fromStringToDouble);

// Преобразование с использованием метода TryParse
string invalidIntString = "123";
int parseResult;
// Пытается преобразовать строку в int
bool isSuccess = int.TryParse(invalidIntString, out parseResult);
Console.WriteLine("Попытка преобразования строки в int с использованием TryParse: " + isSuccess + ", результат: " + parseResult);
