// Пример работы с числовыми типами целых чисел
int integerNumber = 42;
Console.WriteLine("Целое число: " + integerNumber);

// Пример работы с числовым типом с плавающей точкой
double floatingPointNumber = 3.14;
Console.WriteLine("Число с плавающей точкой: " + floatingPointNumber);

// Пример работы с логическим типом
bool booleanValue = true && true;
Console.WriteLine("Логическое значение: " + booleanValue);

// Пример работы с символьным типом
char character = 'A';
Console.WriteLine("Символ: " + character);

string name = "John Doe";

// Особый тип данных - object
object anyType = "Это строка";

Console.WriteLine("Object хранит: " + anyType);
anyType = 10;
Console.WriteLine("Теперь object хранит: " + anyType);

// Пример работы с перечислениями
Week today = Week.Friday;
Console.WriteLine("День недели: " + today);
enum Week
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
