// Пример использования цикла while
Console.WriteLine("\nЦикл while:");
int iWhile = 0;
while (iWhile < 5)
{
    Console.WriteLine($"Значение i: {iWhile}");
    iWhile++;
}

// Пример использования цикла for
Console.WriteLine("Цикл for:");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Значение i: {i}");
}

// Пример использования цикла do-while
Console.WriteLine("\nЦикл do-while:");
int iDoWhile = 10;
do
{
    Console.WriteLine($"Значение i: {iDoWhile}");
    iDoWhile++;
} while (iDoWhile < 5);

// Пример использования break для прерывания цикла
Console.WriteLine("\nПример использования break:");
for (int i = 0; i < 10; i++)
{
    if (i == 5)
        break; // Выход из цикла, когда i равно 5
    Console.WriteLine(i);
}

// Пример использования continue для пропуска итераций
Console.WriteLine("\nПример использования continue:");
for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
        continue; // Пропустить чётные числа
    Console.WriteLine(i);
}

// Пример использования "цикла" foreach
Console.WriteLine("\nЦикл foreach:");
string names = "Анна, Борис, Виктор";
foreach (char symbol in names)
{
    Console.WriteLine(symbol);
}

for (double i = 0, j = 10; i < 10 && j > 0; i += 2.5, j++)
{
    Console.WriteLine($"{i}, {j}");
}