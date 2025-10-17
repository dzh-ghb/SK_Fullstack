// Пример использования if, else if, и else

using System.Security.Cryptography;

int value = 5;
if (value < 5)
{
    Console.WriteLine("Число меньше 5.");
}
else
{
    Console.WriteLine("Число больше или равно 5.");
}


int number = 10;
if (number < 5)
{
    Console.WriteLine("Число меньше 5.");
}
else if (number < 10)
{
    Console.WriteLine("Число меньше 10.");
}
else
{
    Console.WriteLine("Число больше или равно 10.");
}

// Пример использования switch
int month = 1;
switch (month)
{
    case 1:
        Console.WriteLine("Январь");
        break;
    case 2:
        Console.WriteLine("Январь");
        break;
    case 3:
        Console.WriteLine("Январь");
        break;
    // Дополнительные case можно добавлять по аналогии
    default:
        Console.WriteLine("Это не январь и не февраль и не март");
        break;
}

// Пример использования тернарного условного оператора
int anotherNumber = 7;
string result = "";
if (anotherNumber < 10) { result = "Меньше 10"; }
else { result = "10 или больше"; }

result = anotherNumber < 10 ? "Меньше 10" : "10 или больше";
Console.WriteLine(result);

// Пример использования switch выражений
int temp = 15;


string resultValueTemp = temp switch
{
    1 => "Один",
    2 => "Два",
    3 => "Три",
    // _ служит для обозначения всех остальных случаев
    _ => "Какое-то значение"
};

Console.WriteLine($"temp: {temp}, resultValueTemp: {resultValueTemp}");

temp = 15;
resultValueTemp = temp switch
{
    1 => "Один",
    >= 5 and <= 7 => "5 <= temp <= 7",
    8 or 9 => "temp равно 8 или 9.",
    10 or 11 or 12 => "temp равно 10 или 11 или 12.",
    >= 15 => "Больше или равен 15.",
    <= 5 => "Меньше или равно 5.",
    not 13 => "temp точно не 13.",
    _ => "Какое-то другое значение"
};

Console.WriteLine($"temp: {temp}, resultValueTemp: {resultValueTemp}");


var day = DayOfWeek.Monday;
var dayType = day switch
{
    DayOfWeek.Saturday => "Выходной",
    DayOfWeek.Sunday => "Выходной",
    _ => "Будний день"
};

if (day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
{
    dayType = "Выходной";
}
else
{
    dayType = "Будний день";
}
Console.WriteLine(dayType);
